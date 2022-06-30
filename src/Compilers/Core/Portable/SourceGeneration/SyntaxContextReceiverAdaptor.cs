// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;

namespace Microsoft.CodeAnalysis
{
    internal sealed class SyntaxContextReceiverAdaptor : ISyntaxContextReceiver
    {
        private SyntaxContextReceiverAdaptor(ISyntaxReceiver receiver)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(559, 488, 659);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(559, 671, 711);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(559, 575, 648);

                Receiver = receiver ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.ISyntaxReceiver>(559, 586, 647) ?? throw f_559_604_647(nameof(receiver)));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(559, 488, 659);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(559, 488, 659);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(559, 488, 659);
            }
        }

        public ISyntaxReceiver Receiver { get; }

        public void OnVisitSyntaxNode(GeneratorSyntaxContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(559, 785, 828);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(559, 788, 828);
                f_559_788_828(f_559_788_796(), context.Node); DynAbs.Tracing.TraceSender.TraceExitMethod(559, 785, 828);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(559, 785, 828);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(559, 785, 828);
            }

            Microsoft.CodeAnalysis.ISyntaxReceiver
            f_559_788_796()
            {
                var return_v = Receiver;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(559, 788, 796);
                return return_v;
            }


            int
            f_559_788_828(Microsoft.CodeAnalysis.ISyntaxReceiver
            this_param, Microsoft.CodeAnalysis.SyntaxNode
            syntaxNode)
            {
                this_param.OnVisitSyntaxNode(syntaxNode);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(559, 788, 828);
                return 0;
            }

        }

        public static SyntaxContextReceiverCreator Create(SyntaxReceiverCreator creator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(559, 922, 1235);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(559, 925, 1235);
                return () =>
                        {
                            var rx = creator();
                            if (rx is object)
                            {
                                return new SyntaxContextReceiverAdaptor(rx);
                            }
            // in the case that the creator function returns null, we'll also return a null adaptor
            return null;
                        }; DynAbs.Tracing.TraceSender.TraceExitMethod(559, 922, 1235);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(559, 922, 1235);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(559, 922, 1235);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SyntaxContextReceiverAdaptor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(559, 396, 1243);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(559, 396, 1243);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(559, 396, 1243);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(559, 396, 1243);

        static System.ArgumentNullException
        f_559_604_647(string
        paramName)
        {
            var return_v = new System.ArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(559, 604, 647);
            return return_v;
        }

    }
}
