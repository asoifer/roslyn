// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class WithNullableContextBinder : Binder
    {
        private readonly SyntaxTree _syntaxTree;

        private readonly int _position;

        internal WithNullableContextBinder(SyntaxTree syntaxTree, int position, Binder next)
        : base(f_10380_577_581_C(next))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10380, 472, 767);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10380, 407, 418);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10380, 450, 459);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10380, 607, 640);

                f_10380_607_639(syntaxTree != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10380, 654, 682);

                f_10380_654_681(position >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10380, 696, 721);

                _syntaxTree = syntaxTree;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10380, 735, 756);

                _position = position;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10380, 472, 767);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10380, 472, 767);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10380, 472, 767);
            }
        }

        internal override bool AreNullableAnnotationsGloballyEnabled()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10380, 779, 943);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10380, 866, 932);

                return f_10380_873_931(f_10380_873_877(), _syntaxTree, _position);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10380, 779, 943);

                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10380_873_877()
                {
                    var return_v = Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10380, 873, 877);
                    return return_v;
                }


                bool
                f_10380_873_931(Microsoft.CodeAnalysis.CSharp.Binder?
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree, int
                position)
                {
                    var return_v = this_param.AreNullableAnnotationsEnabled(syntaxTree, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10380, 873, 931);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10380, 779, 943);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10380, 779, 943);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static WithNullableContextBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10380, 306, 950);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10380, 306, 950);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10380, 306, 950);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10380, 306, 950);

        int
        f_10380_607_639(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10380, 607, 639);
            return 0;
        }


        int
        f_10380_654_681(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10380, 654, 681);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10380_577_581_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10380, 472, 767);
            return return_v;
        }

    }
}
