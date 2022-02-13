// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Syntax;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Syntax
{
    /// <summary>
    /// Describes how to report a warning diagnostic.
    /// </summary>
    internal enum PragmaWarningState : byte
    {
        /// <summary>
        /// Report a diagnostic by default.
        /// Either there is no corresponding #pragma, or the action is "restore".
        /// </summary>
        Default = 0,

        /// <summary>
        /// Diagnostic is enabled.
        /// NOTE: this may be removed as part of https://github.com/dotnet/roslyn/issues/36550
        /// </summary>
        Enabled = 1,

        /// <summary>
        /// Diagnostic is disabled.
        /// </summary>
        Disabled = 2,
    }
    internal class CSharpPragmaWarningStateMap : AbstractWarningStateMap<PragmaWarningState>
    {
        public CSharpPragmaWarningStateMap(SyntaxTree syntaxTree) : base(f_10752_1319_1329_C(syntaxTree))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10752, 1241, 1352);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10752, 1241, 1352);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10752, 1241, 1352);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10752, 1241, 1352);
            }
        }

        protected override WarningStateMapEntry[] CreateWarningStateMapEntries(SyntaxTree syntaxTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10752, 1364, 1912);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 1565, 1632);

                var
                directives = f_10752_1582_1631()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 1646, 1700);

                f_10752_1646_1699(syntaxTree, directives);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 1763, 1839);

                WarningStateMapEntry[]
                result = f_10752_1795_1838(directives)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 1853, 1871);

                f_10752_1853_1870(directives);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 1887, 1901);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10752, 1364, 1912);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>
                f_10752_1582_1631()
                {
                    var return_v = ArrayBuilder<DirectiveTriviaSyntax>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10752, 1582, 1631);
                    return return_v;
                }


                int
                f_10752_1646_1699(Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>
                directiveList)
                {
                    GetAllPragmaWarningDirectives(syntaxTree, directiveList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10752, 1646, 1699);
                    return 0;
                }


                Microsoft.CodeAnalysis.Syntax.AbstractWarningStateMap<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningState>.WarningStateMapEntry[]
                f_10752_1795_1838(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>
                directiveList)
                {
                    var return_v = CreatePragmaWarningStateEntries(directiveList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10752, 1795, 1838);
                    return return_v;
                }


                int
                f_10752_1853_1870(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10752, 1853, 1870);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10752, 1364, 1912);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10752, 1364, 1912);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void GetAllPragmaWarningDirectives(SyntaxTree syntaxTree, ArrayBuilder<DirectiveTriviaSyntax> directiveList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10752, 2039, 2769);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 2187, 2758);
                    foreach (var d in f_10752_2205_2241_I(f_10752_2205_2241(f_10752_2205_2225(syntaxTree))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10752, 2187, 2758);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 2275, 2415) || true) && (f_10752_2279_2290_M(!d.IsActive) || (DynAbs.Tracing.TraceSender.Expression_False(10752, 2279, 2345) || f_10752_2294_2302(d) != SyntaxKind.PragmaWarningDirectiveTrivia))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10752, 2275, 2415);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 2387, 2396);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10752, 2275, 2415);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 2435, 2481);

                        var
                        w = (PragmaWarningDirectiveTriviaSyntax)d
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 2590, 2743) || true) && (f_10752_2594_2630_M(!w.DisableOrRestoreKeyword.IsMissing) && (DynAbs.Tracing.TraceSender.Expression_True(10752, 2594, 2661) && f_10752_2634_2661_M(!w.WarningKeyword.IsMissing)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10752, 2590, 2743);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 2703, 2724);

                            f_10752_2703_2723(directiveList, w);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10752, 2590, 2743);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10752, 2187, 2758);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10752, 1, 572);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10752, 1, 572);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10752, 2039, 2769);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10752_2205_2225(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10752, 2205, 2225);
                    return return_v;
                }


                System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>
                f_10752_2205_2241(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.GetDirectives();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10752, 2205, 2241);
                    return return_v;
                }


                bool
                f_10752_2279_2290_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10752, 2279, 2290);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10752_2294_2302(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10752, 2294, 2302);
                    return return_v;
                }


                bool
                f_10752_2594_2630_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10752, 2594, 2630);
                    return return_v;
                }


                bool
                f_10752_2634_2661_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10752, 2634, 2661);
                    return return_v;
                }


                int
                f_10752_2703_2723(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>
                this_param, Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10752, 2703, 2723);
                    return 0;
                }


                System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>
                f_10752_2205_2241_I(System.Collections.Generic.IList<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10752, 2205, 2241);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10752, 2039, 2769);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10752, 2039, 2769);
            }
        }

        private static WarningStateMapEntry[] CreatePragmaWarningStateEntries(ArrayBuilder<DirectiveTriviaSyntax> directiveList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10752, 3142, 7205);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 3287, 3351);

                var
                entries = new WarningStateMapEntry[f_10752_3326_3345(directiveList) + 1]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 3365, 3379);

                var
                index = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 3533, 3628);

                var
                accumulatedSpecificWarningState = f_10752_3571_3627()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 3755, 3819);

                var
                accumulatedGeneralWarningState = PragmaWarningState.Default
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 3835, 3938);

                var
                current = f_10752_3849_3937(0, PragmaWarningState.Default, accumulatedSpecificWarningState)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 3952, 3977);

                entries[index] = current;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 3993, 6916) || true) && (index < f_10752_4008_4027(directiveList))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10752, 3993, 6916);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 4061, 4105);

                        var
                        currentDirective = f_10752_4084_4104(directiveList, index)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 4123, 4205);

                        var
                        currentPragmaDirective = (PragmaWarningDirectiveTriviaSyntax)currentDirective
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 4273, 4722);

                        PragmaWarningState
                        directiveState = currentPragmaDirective.DisableOrRestoreKeyword.Kind() switch
                        {
                            SyntaxKind.DisableKeyword when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 4410, 4466) && DynAbs.Tracing.TraceSender.Expression_True(10752, 4410, 4466))
=> PragmaWarningState.Disabled,
                            SyntaxKind.RestoreKeyword when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 4489, 4544) && DynAbs.Tracing.TraceSender.Expression_True(10752, 4489, 4544))
=> PragmaWarningState.Default,
                            SyntaxKind.EnableKeyword when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 4567, 4621) && DynAbs.Tracing.TraceSender.Expression_True(10752, 4567, 4621))
=> PragmaWarningState.Enabled,
                            var kind when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 4644, 4702) && DynAbs.Tracing.TraceSender.Expression_True(10752, 4644, 4702))
=> throw f_10752_4662_4702(kind)
                        }
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 4834, 6670) || true) && (currentPragmaDirective.ErrorCodes.Count == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10752, 4834, 6670);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 5000, 5048);

                            accumulatedGeneralWarningState = directiveState;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 5070, 5161);

                            accumulatedSpecificWarningState = f_10752_5104_5160();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10752, 4834, 6670);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10752, 4834, 6670);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 5335, 5340);
                                // Compute warning numbers from the current directive's codes
                                for (int
            x = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 5326, 6651) || true) && (x < currentPragmaDirective.ErrorCodes.Count)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 5387, 5390)
            , x++, DynAbs.Tracing.TraceSender.TraceExitCondition(10752, 5326, 6651))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10752, 5326, 6651);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 5440, 5500);

                                    var
                                    currentErrorCode = f_10752_5463_5496(currentPragmaDirective)[x]
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 5526, 5636) || true) && (f_10752_5530_5556(currentErrorCode) || (DynAbs.Tracing.TraceSender.Expression_False(10752, 5530, 5596) || f_10752_5560_5596(currentErrorCode)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10752, 5526, 5636);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 5627, 5636);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10752, 5526, 5636);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 5664, 5691);

                                    var
                                    errorId = string.Empty
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 5717, 6276) || true) && (f_10752_5721_5744(currentErrorCode) == SyntaxKind.NumericLiteralExpression)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10752, 5717, 6276);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 5841, 5903);

                                        var
                                        token = f_10752_5853_5902(((LiteralExpressionSyntax)currentErrorCode))
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 5933, 6005);

                                        errorId = f_10752_5943_6004(MessageProvider.Instance, token.Value!);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10752, 5717, 6276);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10752, 5717, 6276);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 6063, 6276) || true) && (f_10752_6067_6090(currentErrorCode) == SyntaxKind.IdentifierName)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10752, 6063, 6276);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 6177, 6249);

                                            errorId = ((IdentifierNameSyntax)currentErrorCode).Identifier.ValueText;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10752, 6063, 6276);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10752, 5717, 6276);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 6304, 6628) || true) && (!f_10752_6309_6343(errorId))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10752, 6304, 6628);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 6502, 6601);

                                        accumulatedSpecificWarningState = f_10752_6536_6600(accumulatedSpecificWarningState, errorId, directiveState);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10752, 6304, 6628);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10752, 1, 1326);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10752, 1, 1326);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10752, 4834, 6670);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 6690, 6832);

                        current = f_10752_6700_6831(f_10752_6725_6750(currentDirective).SourceSpan.End, accumulatedGeneralWarningState, accumulatedSpecificWarningState);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 6850, 6858);

                        ++index;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 6876, 6901);

                        entries[index] = current;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10752, 3993, 6916);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10752, 3993, 6916);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10752, 3993, 6916);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 7017, 7022);

                    // Make sure the entries array is correctly sorted.
                    for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 7008, 7155) || true) && (i < f_10752_7028_7042(entries) - 1)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 7048, 7051)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(10752, 7008, 7155))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10752, 7008, 7155);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 7085, 7140);

                        f_10752_7085_7139(entries[i].CompareTo(entries[i + 1]) < 0);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10752, 1, 148);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10752, 1, 148);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10752, 7179, 7194);

                return entries;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10752, 3142, 7205);

                int
                f_10752_3326_3345(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10752, 3326, 3345);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningState>
                f_10752_3571_3627()
                {
                    var return_v = ImmutableDictionary.Create<string, PragmaWarningState>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10752, 3571, 3627);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.AbstractWarningStateMap<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningState>.WarningStateMapEntry
                f_10752_3849_3937(int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningState
                general, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningState>
                specific)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.AbstractWarningStateMap<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningState>.WarningStateMapEntry(position, general, specific);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10752, 3849, 3937);
                    return return_v;
                }


                int
                f_10752_4008_4027(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10752, 4008, 4027);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                f_10752_4084_4104(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10752, 4084, 4104);
                    return return_v;
                }


                System.Exception
                f_10752_4662_4702(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10752, 4662, 4702);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningState>
                f_10752_5104_5160()
                {
                    var return_v = ImmutableDictionary.Create<string, PragmaWarningState>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10752, 5104, 5160);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SeparatedSyntaxList<Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax>
                f_10752_5463_5496(Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningDirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.ErrorCodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10752, 5463, 5496);
                    return return_v;
                }


                bool
                f_10752_5530_5556(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.IsMissing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10752, 5530, 5556);
                    return return_v;
                }


                bool
                f_10752_5560_5596(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.ContainsDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10752, 5560, 5596);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10752_5721_5744(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10752, 5721, 5744);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10752_5853_5902(Microsoft.CodeAnalysis.CSharp.Syntax.LiteralExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Token;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10752, 5853, 5902);
                    return return_v;
                }


                string
                f_10752_5943_6004(Microsoft.CodeAnalysis.CSharp.MessageProvider
                this_param, object
                errorCode)
                {
                    var return_v = this_param.GetIdForErrorCode((int)errorCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10752, 5943, 6004);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10752_6067_6090(Microsoft.CodeAnalysis.CSharp.Syntax.ExpressionSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10752, 6067, 6090);
                    return return_v;
                }


                bool
                f_10752_6309_6343(string
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10752, 6309, 6343);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningState>
                f_10752_6536_6600(System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningState>
                this_param, string
                key, Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningState
                value)
                {
                    var return_v = this_param.SetItem(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10752, 6536, 6600);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10752_6725_6750(Microsoft.CodeAnalysis.CSharp.Syntax.DirectiveTriviaSyntax
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10752, 6725, 6750);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Syntax.AbstractWarningStateMap<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningState>.WarningStateMapEntry
                f_10752_6700_6831(int
                position, Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningState
                general, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningState>
                specific)
                {
                    var return_v = new Microsoft.CodeAnalysis.Syntax.AbstractWarningStateMap<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningState>.WarningStateMapEntry(position, general, specific);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10752, 6700, 6831);
                    return return_v;
                }


                int
                f_10752_7028_7042(Microsoft.CodeAnalysis.Syntax.AbstractWarningStateMap<Microsoft.CodeAnalysis.CSharp.Syntax.PragmaWarningState>.WarningStateMapEntry[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10752, 7028, 7042);
                    return return_v;
                }


                int
                f_10752_7085_7139(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10752, 7085, 7139);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10752, 3142, 7205);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10752, 3142, 7205);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CSharpPragmaWarningStateMap()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10752, 1136, 7212);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10752, 1136, 7212);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10752, 1136, 7212);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10752, 1136, 7212);

        static Microsoft.CodeAnalysis.SyntaxTree
        f_10752_1319_1329_C(Microsoft.CodeAnalysis.SyntaxTree
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10752, 1241, 1352);
            return return_v;
        }

    }
}
