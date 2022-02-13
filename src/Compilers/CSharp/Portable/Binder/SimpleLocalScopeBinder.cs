// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Immutable;
using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class SimpleLocalScopeBinder : LocalScopeBinder
    {
        private readonly ImmutableArray<LocalSymbol> _locals;

        public SimpleLocalScopeBinder(ImmutableArray<LocalSymbol> locals, Binder next) : base(f_10365_703_707_C(next))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10365, 604, 761);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10365, 733, 750);

                _locals = locals;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10365, 604, 761);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10365, 604, 761);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10365, 604, 761);
            }
        }

        protected override ImmutableArray<LocalSymbol> BuildLocals()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10365, 773, 884);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10365, 858, 873);

                return _locals;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10365, 773, 884);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10365, 773, 884);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10365, 773, 884);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<LocalSymbol> GetDeclaredLocalsForScope(SyntaxNode scopeDesignator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10365, 896, 1068);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10365, 1020, 1057);

                throw f_10365_1026_1056();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10365, 896, 1068);

                System.Exception
                f_10365_1026_1056()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10365, 1026, 1056);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10365, 896, 1068);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10365, 896, 1068);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<LocalFunctionSymbol> GetDeclaredLocalFunctionsForScope(CSharpSyntaxNode scopeDesignator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10365, 1080, 1274);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10365, 1226, 1263);

                throw f_10365_1232_1262();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10365, 1080, 1274);

                System.Exception
                f_10365_1232_1262()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10365, 1232, 1262);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10365, 1080, 1274);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10365, 1080, 1274);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SimpleLocalScopeBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10365, 459, 1281);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10365, 459, 1281);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10365, 459, 1281);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10365, 459, 1281);

        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10365_703_707_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10365, 604, 761);
            return return_v;
        }

    }
}
