// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

// Copied from:
// https://github.com/dotnet/runtime/blob/218ef0f7776c2c20f6c594e3475b80f1fe2d7d08/src/libraries/System.Private.CoreLib/src/System/Runtime/CompilerServices/IsExternalInit.cs

using System.ComponentModel;

namespace System.Runtime.CompilerServices
{
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal static class IsExternalInit
    {
        static IsExternalInit()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(342, 660, 761);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(342, 660, 761);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(342, 660, 761);
        }

    }
}
