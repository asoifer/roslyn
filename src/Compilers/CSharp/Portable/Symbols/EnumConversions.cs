// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal static partial class EnumConversions
    {
        internal static TypeKind ToTypeKind(this DeclarationKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10103, 374, 1378);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10103, 461, 1367);

                switch (kind)
                {

                    case DeclarationKind.Class:
                    case DeclarationKind.Script:
                    case DeclarationKind.ImplicitClass:
                    case DeclarationKind.SimpleProgram:
                    case DeclarationKind.Record:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10103, 461, 1367);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10103, 754, 776);

                        return TypeKind.Class;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10103, 461, 1367);

                    case DeclarationKind.Submission:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10103, 461, 1367);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10103, 850, 877);

                        return TypeKind.Submission;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10103, 461, 1367);

                    case DeclarationKind.Delegate:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10103, 461, 1367);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10103, 949, 974);

                        return TypeKind.Delegate;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10103, 461, 1367);

                    case DeclarationKind.Enum:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10103, 461, 1367);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10103, 1042, 1063);

                        return TypeKind.Enum;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10103, 461, 1367);

                    case DeclarationKind.Interface:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10103, 461, 1367);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10103, 1136, 1162);

                        return TypeKind.Interface;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10103, 461, 1367);

                    case DeclarationKind.Struct:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10103, 461, 1367);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10103, 1232, 1255);

                        return TypeKind.Struct;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10103, 461, 1367);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10103, 461, 1367);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10103, 1305, 1352);

                        throw f_10103_1311_1351(kind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10103, 461, 1367);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10103, 374, 1378);

                System.Exception
                f_10103_1311_1351(Microsoft.CodeAnalysis.CSharp.DeclarationKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10103, 1311, 1351);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10103, 374, 1378);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10103, 374, 1378);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static EnumConversions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10103, 312, 1385);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10103, 312, 1385);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10103, 312, 1385);
        }

    }
}
