// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal enum DeclarationKind : byte
    {
        Namespace,
        Class,
        Interface,
        Struct,
        Enum,
        Delegate,
        Script,
        Submission,
        ImplicitClass,
        SimpleProgram,
        Record
    }
    internal static partial class EnumConversions
    {
        internal static DeclarationKind ToDeclarationKind(this SyntaxKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10391, 760, 1596);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10391, 856, 1585);

                switch (kind)
                {

                    case SyntaxKind.ClassDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10391, 856, 1585);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10391, 936, 965);

                        return DeclarationKind.Class;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10391, 856, 1585);

                    case SyntaxKind.InterfaceDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10391, 856, 1585);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10391, 1021, 1054);

                        return DeclarationKind.Interface;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10391, 856, 1585);

                    case SyntaxKind.StructDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10391, 856, 1585);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10391, 1107, 1137);

                        return DeclarationKind.Struct;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10391, 856, 1585);

                    case SyntaxKind.NamespaceDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10391, 856, 1585);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10391, 1193, 1226);

                        return DeclarationKind.Namespace;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10391, 856, 1585);

                    case SyntaxKind.EnumDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10391, 856, 1585);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10391, 1277, 1305);

                        return DeclarationKind.Enum;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10391, 856, 1585);

                    case SyntaxKind.DelegateDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10391, 856, 1585);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10391, 1360, 1392);

                        return DeclarationKind.Delegate;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10391, 856, 1585);

                    case SyntaxKind.RecordDeclaration:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10391, 856, 1585);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10391, 1445, 1475);

                        return DeclarationKind.Record;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10391, 856, 1585);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10391, 856, 1585);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10391, 1523, 1570);

                        throw f_10391_1529_1569(kind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10391, 856, 1585);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10391, 760, 1596);

                System.Exception
                f_10391_1529_1569(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10391, 1529, 1569);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10391, 760, 1596);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10391, 760, 1596);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static EnumConversions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10391, 698, 1603);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10391, 698, 1603);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10391, 698, 1603);
        }

    }
}
