// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal enum GeneratedNameKind
    {
        None = 0,

        // Used by EE:
        ThisProxyField = '4',
        HoistedLocalField = '5',
        DisplayClassLocalOrField = '8',
        LambdaMethod = 'b',
        LambdaDisplayClass = 'c',
        StateMachineType = 'd',
        LocalFunction = 'g', // note collision with Deprecated_InitializerLocal, however this one is only used for method names

        // Used by EnC:
        AwaiterField = 'u',
        HoistedSynthesizedLocalField = 's',

        // Currently not parsed:
        StateMachineStateField = '1',
        IteratorCurrentBackingField = '2',
        StateMachineParameterProxyField = '3',
        ReusableHoistedLocalField = '7',
        LambdaCacheField = '9',
        FixedBufferField = 'e',
        AnonymousType = 'f',
        TransparentIdentifier = 'h',
        AnonymousTypeField = 'i',
        AutoPropertyBackingField = 'k',
        IteratorCurrentThreadIdField = 'l',
        IteratorFinallyMethod = 'm',
        BaseMethodWrapper = 'n',
        AsyncBuilderField = 't',
        DynamicCallSiteContainerType = 'o',
        DynamicCallSiteField = 'p',
        AsyncIteratorPromiseOfValueOrEndBackingField = 'v',
        DisposeModeField = 'w',
        CombinedTokensField = 'x', // last

        // Deprecated - emitted by Dev12, but not by Roslyn.
        // Don't reuse the values because the debugger might encounter them when consuming old binaries.
        [Obsolete]
        Deprecated_OuterscopeLocals = '6',
        [Obsolete]
        Deprecated_IteratorInstance = 'a',
        [Obsolete]
        Deprecated_InitializerLocal = 'g',
        [Obsolete]
        Deprecated_AnonymousTypeTypeParameter = 'j',
        [Obsolete]
        Deprecated_DynamicDelegate = 'q',
        [Obsolete]
        Deprecated_ComrefCallLocal = 'r',
    }
    internal static class GeneratedNameKindExtensions
    {
        internal static bool IsTypeName(this GeneratedNameKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10662, 2251, 2675);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10662, 2336, 2664);

                switch (kind)
                {

                    case GeneratedNameKind.LambdaDisplayClass:
                    case GeneratedNameKind.StateMachineType:
                    case GeneratedNameKind.DynamicCallSiteContainerType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10662, 2336, 2664);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10662, 2574, 2586);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10662, 2336, 2664);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10662, 2336, 2664);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10662, 2636, 2649);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10662, 2336, 2664);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10662, 2251, 2675);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10662, 2251, 2675);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10662, 2251, 2675);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static GeneratedNameKindExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10662, 2185, 2682);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10662, 2185, 2682);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10662, 2185, 2682);
        }

    }
}
