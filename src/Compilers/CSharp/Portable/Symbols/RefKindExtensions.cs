// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal static partial class RefKindExtensions
    {
        public static bool IsManagedReference(this RefKind refKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10151, 403, 590);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10151, 487, 532);

                f_10151_487_531(refKind <= RefKind.RefReadOnly);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10151, 548, 579);

                return refKind != RefKind.None;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10151, 403, 590);

                int
                f_10151_487_531(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10151, 487, 531);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10151, 403, 590);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10151, 403, 590);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static RefKind GetRefKind(this SyntaxKind syntaxKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10151, 602, 1185);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10151, 687, 1174);

                switch (syntaxKind)
                {

                    case SyntaxKind.RefKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10151, 687, 1174);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10151, 788, 807);

                        return RefKind.Ref;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10151, 687, 1174);

                    case SyntaxKind.OutKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10151, 687, 1174);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10151, 874, 893);

                        return RefKind.Out;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10151, 687, 1174);

                    case SyntaxKind.InKeyword:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10151, 687, 1174);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10151, 959, 977);

                        return RefKind.In;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10151, 687, 1174);

                    case SyntaxKind.None:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10151, 687, 1174);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10151, 1038, 1058);

                        return RefKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10151, 687, 1174);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10151, 687, 1174);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10151, 1106, 1159);

                        throw f_10151_1112_1158(syntaxKind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10151, 687, 1174);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10151, 602, 1185);

                System.Exception
                f_10151_1112_1158(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10151, 1112, 1158);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10151, 602, 1185);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10151, 602, 1185);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsWritableReference(this RefKind refKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10151, 1197, 1646);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10151, 1282, 1635);

                switch (refKind)
                {

                    case RefKind.Ref:
                    case RefKind.Out:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10151, 1282, 1635);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10151, 1405, 1417);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10151, 1282, 1635);

                    case RefKind.None:
                    case RefKind.In:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10151, 1282, 1635);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10151, 1509, 1522);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10151, 1282, 1635);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10151, 1282, 1635);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10151, 1570, 1620);

                        throw f_10151_1576_1619(refKind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10151, 1282, 1635);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10151, 1197, 1646);

                System.Exception
                f_10151_1576_1619(Microsoft.CodeAnalysis.RefKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10151, 1576, 1619);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10151, 1197, 1646);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10151, 1197, 1646);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static RefKindExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10151, 339, 1653);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10151, 339, 1653);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10151, 339, 1653);
        }

    }
}
