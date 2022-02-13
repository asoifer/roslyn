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
    internal static class SymbolKindExtensions
    {
        public static LocalizableErrorArgument Localize(this SymbolKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10166, 490, 1998);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10166, 584, 1987);

                switch (kind)
                {

                    case SymbolKind.Namespace:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10166, 584, 1987);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10166, 678, 723);

                        return f_10166_685_722(MessageID.IDS_SK_NAMESPACE);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10166, 584, 1987);

                    case SymbolKind.NamedType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10166, 584, 1987);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10166, 789, 829);

                        return f_10166_796_828(MessageID.IDS_SK_TYPE);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10166, 584, 1987);

                    case SymbolKind.TypeParameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10166, 584, 1987);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10166, 899, 940);

                        return f_10166_906_939(MessageID.IDS_SK_TYVAR);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10166, 584, 1987);

                    case SymbolKind.Method:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10166, 584, 1987);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10166, 1003, 1045);

                        return f_10166_1010_1044(MessageID.IDS_SK_METHOD);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10166, 584, 1987);

                    case SymbolKind.Property:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10166, 584, 1987);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10166, 1110, 1154);

                        return f_10166_1117_1153(MessageID.IDS_SK_PROPERTY);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10166, 584, 1987);

                    case SymbolKind.Event:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10166, 584, 1987);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10166, 1216, 1257);

                        return f_10166_1223_1256(MessageID.IDS_SK_EVENT);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10166, 584, 1987);

                    case SymbolKind.Field:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10166, 584, 1987);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10166, 1319, 1360);

                        return f_10166_1326_1359(MessageID.IDS_SK_FIELD);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10166, 584, 1987);

                    case SymbolKind.Local:
                    case SymbolKind.Parameter:
                    case SymbolKind.RangeVariable:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10166, 584, 1987);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10166, 1514, 1558);

                        return f_10166_1521_1557(MessageID.IDS_SK_VARIABLE);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10166, 584, 1987);

                    case SymbolKind.Alias:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10166, 584, 1987);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10166, 1620, 1661);

                        return f_10166_1627_1660(MessageID.IDS_SK_ALIAS);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10166, 584, 1987);

                    case SymbolKind.Label:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10166, 584, 1987);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10166, 1723, 1764);

                        return f_10166_1730_1763(MessageID.IDS_SK_LABEL);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10166, 584, 1987);

                    case SymbolKind.Preprocessing:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10166, 584, 1987);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10166, 1834, 1881);

                        throw f_10166_1840_1880(kind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10166, 584, 1987);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10166, 584, 1987);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10166, 1929, 1972);

                        return f_10166_1936_1971(MessageID.IDS_SK_UNKNOWN);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10166, 584, 1987);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10166, 490, 1998);

                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10166_685_722(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10166, 685, 722);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10166_796_828(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10166, 796, 828);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10166_906_939(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10166, 906, 939);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10166_1010_1044(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10166, 1010, 1044);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10166_1117_1153(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10166, 1117, 1153);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10166_1223_1256(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10166, 1223, 1256);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10166_1326_1359(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10166, 1326, 1359);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10166_1521_1557(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10166, 1521, 1557);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10166_1627_1660(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10166, 1627, 1660);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10166_1730_1763(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10166, 1730, 1763);
                    return return_v;
                }


                System.Exception
                f_10166_1840_1880(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10166, 1840, 1880);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10166_1936_1971(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10166, 1936, 1971);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10166, 490, 1998);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10166, 490, 1998);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SymbolKindExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10166, 431, 2005);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10166, 431, 2005);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10166, 431, 2005);
        }

    }
}
