// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.Diagnostics
{
    internal partial class SuppressMessageAttributeState
    {
        private const string
        s_suppressionPrefix = "~"
        ;

        [StructLayout(LayoutKind.Auto)]
        private struct TargetSymbolResolver
        {

            private static readonly char[] s_nameDelimiters;

            private static readonly string[] s_callingConventionStrings;

            private static readonly ParameterInfo[] s_noParameters;

            private readonly Compilation _compilation;

            private readonly TargetScope _scope;

            private readonly string _name;

            private int _index;

            public TargetSymbolResolver(Compilation compilation, TargetScope scope, string fullyQualifiedName)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(272, 1441, 1721);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 1572, 1599);

                    _compilation = compilation;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 1617, 1632);

                    _scope = scope;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 1650, 1677);

                    _name = fullyQualifiedName;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 1695, 1706);

                    _index = 0;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(272, 1441, 1721);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(272, 1441, 1721);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(272, 1441, 1721);
                }
            }

            private static string RemovePrefix(string id, string prefix)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(272, 1737, 2046);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 1830, 2001) || true) && (id != null && (DynAbs.Tracing.TraceSender.Expression_True(272, 1834, 1862) && prefix != null) && (DynAbs.Tracing.TraceSender.Expression_True(272, 1834, 1913) && f_272_1866_1913(id, prefix, StringComparison.Ordinal)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 1830, 2001);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 1955, 1982);

                        return id[f_272_1965_1978(prefix)..];
                        DynAbs.Tracing.TraceSender.TraceExitCondition(272, 1830, 2001);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 2021, 2031);

                    return id;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(272, 1737, 2046);

                    bool
                    f_272_1866_1913(string
                    this_param, string
                    value, System.StringComparison
                    comparisonType)
                    {
                        var return_v = this_param.StartsWith(value, comparisonType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 1866, 1913);
                        return return_v;
                    }


                    int
                    f_272_1965_1978(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 1965, 1978);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(272, 1737, 2046);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(272, 1737, 2046);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public ImmutableArray<ISymbol> Resolve(out bool resolvedWithDocCommentIdFormat)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(272, 2535, 10227);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 2647, 2686);

                    resolvedWithDocCommentIdFormat = false;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 2704, 2833) || true) && (f_272_2708_2735(_name))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 2704, 2833);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 2777, 2814);

                        return ImmutableArray<ISymbol>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(272, 2704, 2833);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 2963, 3028);

                    var
                    nameWithoutPrefix = RemovePrefix(_name, s_suppressionPrefix)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 3046, 3148);

                    var
                    docIdResults = f_272_3065_3147(nameWithoutPrefix, _compilation)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 3166, 3334) || true) && (docIdResults.Length > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 3166, 3334);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 3235, 3273);

                        resolvedWithDocCommentIdFormat = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 3295, 3315);

                        return docIdResults;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(272, 3166, 3334);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 3354, 3404);

                    var
                    results = f_272_3368_3403()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 3547, 3568);

                    bool
                    isEvent = false
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 3586, 3754) || true) && (f_272_3590_3602(_name) >= 2 && (DynAbs.Tracing.TraceSender.Expression_True(272, 3590, 3626) && f_272_3611_3619(_name, 0) == 'e') && (DynAbs.Tracing.TraceSender.Expression_True(272, 3590, 3645) && f_272_3630_3638(_name, 1) == ':'))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 3586, 3754);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 3687, 3702);

                        isEvent = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 3724, 3735);

                        _index = 2;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(272, 3586, 3754);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 3774, 3845);

                    INamespaceOrTypeSymbol
                    containingSymbol = f_272_3816_3844(_compilation)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 3863, 3899);

                    bool?
                    segmentIsNamedTypeName = null
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 3919, 10156) || true) && (true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 3919, 10156);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 3972, 4009);

                            var
                            segment = ParseNextNameSegment()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 4168, 4199);

                            bool
                            isIndexerProperty = false
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 4221, 4544) || true) && (segment == "Item" && (DynAbs.Tracing.TraceSender.Expression_True(272, 4225, 4267) && PeekNextChar() == '['))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 4221, 4544);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 4317, 4342);

                                isIndexerProperty = true;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 4368, 4521) || true) && (f_272_4372_4393(_compilation) == LanguageNames.CSharp)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 4368, 4521);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 4475, 4494);

                                    segment = "this[]";
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(272, 4368, 4521);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(272, 4221, 4544);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 4568, 4628);

                            var
                            candidateMembers = f_272_4591_4627(containingSymbol, segment)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 4650, 4761) || true) && (candidateMembers.Length == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 4650, 4761);
                                DynAbs.Tracing.TraceSender.TraceBreak(272, 4732, 4738);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(272, 4650, 4761);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 4785, 5219) || true) && (f_272_4789_4820(segmentIsNamedTypeName))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 4785, 5219);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 4870, 5138);

                                candidateMembers = (DynAbs.Tracing.TraceSender.Conditional_F1(272, 4889, 4917) || ((f_272_4889_4917(segmentIsNamedTypeName) && DynAbs.Tracing.TraceSender.Conditional_F2(272, 4949, 5027)) || DynAbs.Tracing.TraceSender.Conditional_F3(272, 5059, 5137))) ? f_272_4949_5027(candidateMembers.Where(s => s.Kind == SymbolKind.NamedType)) : f_272_5059_5137(candidateMembers.Where(s => s.Kind != SymbolKind.NamedType));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 5166, 5196);

                                segmentIsNamedTypeName = null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(272, 4785, 5219);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 5243, 5261);

                            int?
                            arity = null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 5283, 5317);

                            ParameterInfo[]
                            parameters = null
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 5389, 5583) || true) && (_scope != TargetScope.Namespace && (DynAbs.Tracing.TraceSender.Expression_True(272, 5393, 5449) && PeekNextChar() == '`'))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 5389, 5583);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 5499, 5508);

                                ++_index;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 5534, 5560);

                                arity = ReadNextInteger();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(272, 5389, 5583);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 5674, 5704);

                            var
                            nextChar = PeekNextChar()
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 5728, 7808) || true) && (!isIndexerProperty && (DynAbs.Tracing.TraceSender.Expression_True(272, 5732, 5769) && nextChar == '(') || (DynAbs.Tracing.TraceSender.Expression_False(272, 5732, 5809) || isIndexerProperty && (DynAbs.Tracing.TraceSender.Expression_True(272, 5773, 5809) && nextChar == '[')))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 5728, 7808);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 5859, 5893);

                                parameters = ParseParameterList();

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 5919, 6097) || true) && (parameters == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 5919, 6097);
                                    DynAbs.Tracing.TraceSender.TraceBreak(272, 6064, 6070);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(272, 5919, 6097);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(272, 5728, 7808);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 5728, 7808);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 6147, 7808) || true) && (nextChar == '.' || (DynAbs.Tracing.TraceSender.Expression_False(272, 6151, 6185) || nextChar == '+'))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 6147, 7808);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 6235, 6244);

                                    ++_index;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 6272, 7025) || true) && (arity > 0 || (DynAbs.Tracing.TraceSender.Expression_False(272, 6276, 6304) || nextChar == '+'))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 6272, 7025);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 6550, 6625);

                                        containingSymbol = GetFirstMatchingNamedType(candidateMembers, arity ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(272, 6613, 6623) ?? 0));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(272, 6272, 7025);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 6272, 7025);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 6929, 6998);

                                        containingSymbol = GetFirstMatchingNamespaceOrType(candidateMembers);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(272, 6272, 7025);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 7053, 7336) || true) && (containingSymbol == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 7053, 7336);
                                        DynAbs.Tracing.TraceSender.TraceBreak(272, 7303, 7309);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(272, 7053, 7336);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 7364, 7748) || true) && (f_272_7368_7389(containingSymbol) == SymbolKind.NamedType)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 7364, 7748);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 7680, 7721);

                                        segmentIsNamedTypeName = nextChar == '+';
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(272, 7364, 7748);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 7776, 7785);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(272, 6147, 7808);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(272, 5728, 7808);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 7832, 8475) || true) && (_scope == TargetScope.Member && (DynAbs.Tracing.TraceSender.Expression_True(272, 7836, 7886) && !isIndexerProperty) && (DynAbs.Tracing.TraceSender.Expression_True(272, 7836, 7908) && parameters != null))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 7832, 8475);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 7958, 7986);

                                TypeInfo?
                                returnType = null
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 8012, 8195) || true) && (PeekNextChar() == ':')
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 8012, 8195);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 8095, 8104);

                                    ++_index;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 8134, 8168);

                                    returnType = ParseNamedType(null);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(272, 8012, 8195);
                                }
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 8223, 8418);
                                    foreach (var method in f_272_8246_8313_I(GetMatchingMethods(candidateMembers, arity, parameters, returnType)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 8223, 8418);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 8371, 8391);

                                        f_272_8371_8390(results, method);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(272, 8223, 8418);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(272, 1, 196);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(272, 1, 196);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(272, 8446, 8452);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(272, 7832, 8475);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 8499, 8520);

                            ISymbol
                            singleResult
                            = default(ISymbol);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 8544, 9960);

                            switch (_scope)
                            {

                                case TargetScope.Namespace:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 8544, 9960);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 8665, 8749);

                                    singleResult = candidateMembers.FirstOrDefault(s => s.Kind == SymbolKind.Namespace);
                                    DynAbs.Tracing.TraceSender.TraceBreak(272, 8779, 8785);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(272, 8544, 9960);

                                case TargetScope.Type:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 8544, 9960);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 8865, 8936);

                                    singleResult = GetFirstMatchingNamedType(candidateMembers, arity ?? (DynAbs.Tracing.TraceSender.Expression_Null<int?>(272, 8924, 8934) ?? 0));
                                    DynAbs.Tracing.TraceSender.TraceBreak(272, 8966, 8972);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(272, 8544, 9960);

                                case TargetScope.Member:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 8544, 9960);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 9054, 9786) || true) && (isIndexerProperty)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 9054, 9786);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 9141, 9210);

                                        singleResult = GetFirstMatchingIndexer(candidateMembers, parameters);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(272, 9054, 9786);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 9054, 9786);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 9276, 9786) || true) && (isEvent)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 9276, 9786);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 9353, 9433);

                                            singleResult = candidateMembers.FirstOrDefault(s => s.Kind == SymbolKind.Event);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(272, 9276, 9786);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 9276, 9786);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 9563, 9755);

                                            singleResult = candidateMembers.FirstOrDefault(s =>
                                                                                s.Kind != SymbolKind.Namespace &&
                                                                                s.Kind != SymbolKind.NamedType);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(272, 9276, 9786);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(272, 9054, 9786);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(272, 9816, 9822);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(272, 8544, 9960);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 8544, 9960);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 9888, 9937);

                                    throw f_272_9894_9936(_scope);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(272, 8544, 9960);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 9984, 10107) || true) && (singleResult != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 9984, 10107);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 10058, 10084);

                                f_272_10058_10083(results, singleResult);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(272, 9984, 10107);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(272, 10131, 10137);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(272, 3919, 10156);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(272, 3919, 10156);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(272, 3919, 10156);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 10176, 10212);

                    return f_272_10183_10211(results);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(272, 2535, 10227);

                    bool
                    f_272_2708_2735(string
                    value)
                    {
                        var return_v = string.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 2708, 2735);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    f_272_3065_3147(string
                    id, Microsoft.CodeAnalysis.Compilation
                    compilation)
                    {
                        var return_v = DocumentationCommentId.GetSymbolsForDeclarationId(id, compilation);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 3065, 3147);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.ISymbol>
                    f_272_3368_3403()
                    {
                        var return_v = ArrayBuilder<ISymbol>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 3368, 3403);
                        return return_v;
                    }


                    int
                    f_272_3590_3602(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 3590, 3602);
                        return return_v;
                    }


                    char
                    f_272_3611_3619(string
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 3611, 3619);
                        return return_v;
                    }


                    char
                    f_272_3630_3638(string
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 3630, 3638);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.INamespaceSymbol
                    f_272_3816_3844(Microsoft.CodeAnalysis.Compilation
                    this_param)
                    {
                        var return_v = this_param.GlobalNamespace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 3816, 3844);
                        return return_v;
                    }


                    string
                    f_272_4372_4393(Microsoft.CodeAnalysis.Compilation
                    this_param)
                    {
                        var return_v = this_param.Language;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 4372, 4393);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    f_272_4591_4627(Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                    this_param, string
                    name)
                    {
                        var return_v = this_param.GetMembers(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 4591, 4627);
                        return return_v;
                    }


                    bool
                    f_272_4789_4820(bool?
                    this_param)
                    {
                        var return_v = this_param.HasValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 4789, 4820);
                        return return_v;
                    }


                    bool
                    f_272_4889_4917(bool?
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 4889, 4917);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    f_272_4949_5027(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ISymbol>
                    items)
                    {
                        var return_v = items.ToImmutableArray<Microsoft.CodeAnalysis.ISymbol>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 4949, 5027);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    f_272_5059_5137(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ISymbol>
                    items)
                    {
                        var return_v = items.ToImmutableArray<Microsoft.CodeAnalysis.ISymbol>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 5059, 5137);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_272_7368_7389(Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 7368, 7389);
                        return return_v;
                    }


                    int
                    f_272_8371_8390(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.ISymbol>
                    this_param, Microsoft.CodeAnalysis.IMethodSymbol
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.ISymbol)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 8371, 8390);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IMethodSymbol>
                    f_272_8246_8313_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IMethodSymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 8246, 8313);
                        return return_v;
                    }


                    System.Exception
                    f_272_9894_9936(Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetScope
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 9894, 9936);
                        return return_v;
                    }


                    int
                    f_272_10058_10083(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.ISymbol>
                    this_param, Microsoft.CodeAnalysis.ISymbol
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 10058, 10083);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    f_272_10183_10211(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.ISymbol>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 10183, 10211);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(272, 2535, 10227);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(272, 2535, 10227);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private string ParseNextNameSegment()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(272, 10243, 12155);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 10631, 11419) || true) && (PeekNextChar() == '#')
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 10631, 11419);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 10698, 10707);

                        ++_index;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 10908, 11400) || true) && (PeekNextChar() == '[')
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 10908, 11400);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 10983, 11377);
                                foreach (string callingConvention in f_272_11020_11046_I(s_callingConventionStrings))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 10983, 11377);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 11104, 11350) || true) && (callingConvention == f_272_11129_11178(_name, _index, f_272_11153_11177(callingConvention)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 11104, 11350);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 11244, 11279);

                                        _index += f_272_11254_11278(callingConvention);
                                        DynAbs.Tracing.TraceSender.TraceBreak(272, 11313, 11319);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(272, 11104, 11350);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(272, 10983, 11377);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(272, 1, 395);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(272, 1, 395);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(272, 10908, 11400);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(272, 10631, 11419);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 11439, 11454);

                    string
                    segment
                    = default(string);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 11580, 11760);

                    int
                    delimiterOffset = (DynAbs.Tracing.TraceSender.Conditional_F1(272, 11602, 11623) || ((PeekNextChar() == '.' && DynAbs.Tracing.TraceSender.Conditional_F2(272, 11647, 11693)) || DynAbs.Tracing.TraceSender.Conditional_F3(272, 11717, 11759))) ? f_272_11647_11693(_name, s_nameDelimiters, _index + 1) : f_272_11717_11759(_name, s_nameDelimiters, _index)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 11780, 12105) || true) && (delimiterOffset >= 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 11780, 12105);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 11846, 11887);

                        segment = _name[_index..delimiterOffset];
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 11909, 11934);

                        _index = delimiterOffset;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(272, 11780, 12105);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 11780, 12105);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 12016, 12042);

                        segment = _name[_index..];
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 12064, 12086);

                        _index = f_272_12073_12085(_name);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(272, 11780, 12105);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 12125, 12140);

                    return segment;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(272, 10243, 12155);

                    int
                    f_272_11153_11177(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 11153, 11177);
                        return return_v;
                    }


                    string
                    f_272_11129_11178(string
                    this_param, int
                    startIndex, int
                    length)
                    {
                        var return_v = this_param.Substring(startIndex, length);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 11129, 11178);
                        return return_v;
                    }


                    int
                    f_272_11254_11278(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 11254, 11278);
                        return return_v;
                    }


                    string[]
                    f_272_11020_11046_I(string[]
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 11020, 11046);
                        return return_v;
                    }


                    int
                    f_272_11647_11693(string
                    this_param, char[]
                    anyOf, int
                    startIndex)
                    {
                        var return_v = this_param.IndexOfAny(anyOf, startIndex);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 11647, 11693);
                        return return_v;
                    }


                    int
                    f_272_11717_11759(string
                    this_param, char[]
                    anyOf, int
                    startIndex)
                    {
                        var return_v = this_param.IndexOfAny(anyOf, startIndex);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 11717, 11759);
                        return return_v;
                    }


                    int
                    f_272_12073_12085(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 12073, 12085);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(272, 10243, 12155);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(272, 10243, 12155);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private char PeekNextChar()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(272, 12171, 12299);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 12231, 12284);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(272, 12238, 12260) || ((_index >= f_272_12248_12260(_name) && DynAbs.Tracing.TraceSender.Conditional_F2(272, 12263, 12267)) || DynAbs.Tracing.TraceSender.Conditional_F3(272, 12270, 12283))) ? '\0' : f_272_12270_12283(_name, _index);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(272, 12171, 12299);

                    int
                    f_272_12248_12260(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 12248, 12260);
                        return return_v;
                    }


                    char
                    f_272_12270_12283(string
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 12270, 12283);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(272, 12171, 12299);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(272, 12171, 12299);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private int ReadNextInteger()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(272, 12315, 12637);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 12377, 12387);

                    int
                    n = 0
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 12407, 12593) || true) && (_index < f_272_12423_12435(_name) && (DynAbs.Tracing.TraceSender.Expression_True(272, 12414, 12466) && f_272_12439_12466(f_272_12452_12465(_name, _index))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 12407, 12593);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 12508, 12543);

                            n = n * 10 + (f_272_12522_12535(_name, _index) - '0');
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 12565, 12574);

                            ++_index;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(272, 12407, 12593);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(272, 12407, 12593);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(272, 12407, 12593);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 12613, 12622);

                    return n;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(272, 12315, 12637);

                    int
                    f_272_12423_12435(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 12423, 12435);
                        return return_v;
                    }


                    char
                    f_272_12452_12465(string
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 12452, 12465);
                        return return_v;
                    }


                    bool
                    f_272_12439_12466(char
                    c)
                    {
                        var return_v = char.IsDigit(c);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 12439, 12466);
                        return return_v;
                    }


                    char
                    f_272_12522_12535(string
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 12522, 12535);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(272, 12315, 12637);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(272, 12315, 12637);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private ParameterInfo[] ParseParameterList()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(272, 12653, 14394);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 12793, 12854);

                    f_272_12793_12853(PeekNextChar() == '(' || (DynAbs.Tracing.TraceSender.Expression_False(272, 12806, 12852) || PeekNextChar() == '['));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 12872, 12881);

                    ++_index;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 12901, 12931);

                    var
                    nextChar = PeekNextChar()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 12949, 13146) || true) && (nextChar == ')' || (DynAbs.Tracing.TraceSender.Expression_False(272, 12953, 12987) || nextChar == ']'))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 12949, 13146);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 13074, 13083);

                        ++_index;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 13105, 13127);

                        return s_noParameters;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(272, 12949, 13146);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 13166, 13214);

                    var
                    builder = f_272_13180_13213()
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 13234, 13870) || true) && (true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 13234, 13870);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 13287, 13320);

                            var
                            parameter = ParseParameter()
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 13342, 13616) || true) && (parameter != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 13342, 13616);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 13413, 13442);

                                f_272_13413_13441(builder, parameter.Value);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(272, 13342, 13616);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 13342, 13616);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 13540, 13555);

                                f_272_13540_13554(builder);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 13581, 13593);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(272, 13342, 13616);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 13640, 13851) || true) && (PeekNextChar() == ',')
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 13640, 13851);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 13715, 13724);

                                ++_index;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(272, 13640, 13851);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 13640, 13851);
                                DynAbs.Tracing.TraceSender.TraceBreak(272, 13822, 13828);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(272, 13640, 13851);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(272, 13234, 13870);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(272, 13234, 13870);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(272, 13234, 13870);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 13890, 13916);

                    nextChar = PeekNextChar();

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 13934, 14327) || true) && (nextChar == ')' || (DynAbs.Tracing.TraceSender.Expression_False(272, 13938, 13972) || nextChar == ']'))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 13934, 14327);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 14081, 14090);

                        ++_index;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(272, 13934, 14327);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 13934, 14327);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 14259, 14274);

                        f_272_14259_14273(                    // Malformed parameter list: missing close parenthesis or bracket
                                            builder);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 14296, 14308);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(272, 13934, 14327);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 14347, 14379);

                    return f_272_14354_14378(builder);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(272, 12653, 14394);

                    int
                    f_272_12793_12853(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 12793, 12853);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetSymbolResolver.ParameterInfo>
                    f_272_13180_13213()
                    {
                        var return_v = new Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetSymbolResolver.ParameterInfo>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 13180, 13213);
                        return return_v;
                    }


                    int
                    f_272_13413_13441(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetSymbolResolver.ParameterInfo>
                    this_param, Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetSymbolResolver.ParameterInfo
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 13413, 13441);
                        return 0;
                    }


                    int
                    f_272_13540_13554(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetSymbolResolver.ParameterInfo>
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 13540, 13554);
                        return 0;
                    }


                    int
                    f_272_14259_14273(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetSymbolResolver.ParameterInfo>
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 14259, 14273);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetSymbolResolver.ParameterInfo[]
                    f_272_14354_14378(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetSymbolResolver.ParameterInfo>
                    this_param)
                    {
                        var return_v = this_param.ToArrayAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 14354, 14378);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(272, 12653, 14394);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(272, 12653, 14394);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private ParameterInfo? ParseParameter()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(272, 14410, 14861);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 14482, 14509);

                    var
                    type = ParseType(null)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 14527, 14616) || true) && (type == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 14527, 14616);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 14585, 14597);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(272, 14527, 14616);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 14636, 14675);

                    var
                    isRefOrOut = PeekNextChar() == '&'
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 14693, 14777) || true) && (isRefOrOut)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 14693, 14777);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 14749, 14758);

                        ++_index;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(272, 14693, 14777);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 14797, 14846);

                    return f_272_14804_14845(type.Value, isRefOrOut);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(272, 14410, 14861);

                    Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetSymbolResolver.ParameterInfo
                    f_272_14804_14845(Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetSymbolResolver.TypeInfo
                    type, bool
                    isRefOrOut)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetSymbolResolver.ParameterInfo(type, isRefOrOut);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 14804, 14845);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(272, 14410, 14861);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(272, 14410, 14861);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private TypeInfo? ParseType(ISymbol bindingContext)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(272, 14877, 17198);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 14961, 14978);

                    TypeInfo?
                    result
                    = default(TypeInfo?);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 14998, 15025);

                    IgnoreCustomModifierList();

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 15045, 15770) || true) && (PeekNextChar() == '!')
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 15045, 15770);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 15112, 15163);

                        result = ParseIndexedTypeParameter(bindingContext);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(272, 15045, 15770);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 15045, 15770);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 15245, 15285);

                        result = ParseNamedType(bindingContext);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 15500, 15751) || true) && (bindingContext != null && (DynAbs.Tracing.TraceSender.Expression_True(272, 15504, 15545) && result.HasValue) && (DynAbs.Tracing.TraceSender.Expression_True(272, 15504, 15570) && f_272_15549_15570_M(!result.Value.IsBound)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 15500, 15751);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 15620, 15653);

                            _index = result.Value.StartIndex;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 15679, 15728);

                            result = ParseNamedTypeParameter(bindingContext);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(272, 15500, 15751);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(272, 15045, 15770);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 15790, 15881) || true) && (result == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 15790, 15881);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 15850, 15862);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(272, 15790, 15881);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 15901, 17025) || true) && (result.Value.IsBound)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 15901, 17025);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 15967, 16002);

                        var
                        typeSymbol = result.Value.Type
                        ;
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 16102, 16947) || true) && (true)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 16102, 16947);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 16163, 16190);

                                IgnoreCustomModifierList();
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 16218, 16248);

                                var
                                nextChar = PeekNextChar()
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 16274, 16618) || true) && (nextChar == '[')
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 16274, 16618);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 16351, 16391);

                                    typeSymbol = ParseArrayType(typeSymbol);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 16421, 16552) || true) && (typeSymbol == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 16421, 16552);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 16509, 16521);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(272, 16421, 16552);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 16582, 16591);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(272, 16274, 16618);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 16646, 16890) || true) && (nextChar == '*')
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 16646, 16890);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 16723, 16732);

                                    ++_index;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 16762, 16824);

                                    typeSymbol = f_272_16775_16823(_compilation, typeSymbol);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 16854, 16863);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(272, 16646, 16890);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(272, 16918, 16924);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(272, 16102, 16947);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(272, 16102, 16947);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(272, 16102, 16947);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 16971, 17006);

                        return TypeInfo.Create(typeSymbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(272, 15901, 17025);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 17117, 17151);

                    IgnorePointerAndArraySpecifiers();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 17169, 17183);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(272, 14877, 17198);

                    bool
                    f_272_15549_15570_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 15549, 15570);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.IPointerTypeSymbol
                    f_272_16775_16823(Microsoft.CodeAnalysis.Compilation
                    this_param, Microsoft.CodeAnalysis.ITypeSymbol
                    pointedAtType)
                    {
                        var return_v = this_param.CreatePointerTypeSymbol(pointedAtType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 16775, 16823);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(272, 14877, 17198);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(272, 14877, 17198);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private void IgnoreCustomModifierList()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(272, 17214, 18180);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 18012, 18165) || true) && (PeekNextChar() == '{')
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 18012, 18165);
                        try
                        {
                            for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 18079, 18146) || true) && (_index < f_272_18095_18107(_name) && (DynAbs.Tracing.TraceSender.Expression_True(272, 18086, 18131) && f_272_18111_18124(_name, _index) != '}'))
   ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 18133, 18141)
   , ++_index, DynAbs.Tracing.TraceSender.TraceExitCondition(272, 18079, 18146))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 18079, 18146);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(272, 1, 68);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(272, 1, 68);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(272, 18012, 18165);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(272, 17214, 18180);

                    int
                    f_272_18095_18107(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 18095, 18107);
                        return return_v;
                    }


                    char
                    f_272_18111_18124(string
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 18111, 18124);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(272, 17214, 18180);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(272, 17214, 18180);
                }
            }

            private void IgnorePointerAndArraySpecifiers()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(272, 18196, 19307);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 18275, 18299);

                    bool
                    inBrackets = false
                    ;
                    try
                    {
                        for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 18317, 19292) || true) && (_index < f_272_18333_18345(_name))
   ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 18347, 18355)
   , ++_index, DynAbs.Tracing.TraceSender.TraceExitCondition(272, 18317, 19292))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 18317, 19292);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 18397, 19273);

                            switch (PeekNextChar())
                            {

                                case '[':
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 18397, 19273);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 18508, 18526);

                                    inBrackets = true;
                                    DynAbs.Tracing.TraceSender.TraceBreak(272, 18556, 18562);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(272, 18397, 19273);

                                case ']':
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 18397, 19273);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 18627, 18812) || true) && (!inBrackets)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 18627, 18812);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 18774, 18781);

                                        return;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(272, 18627, 18812);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 18842, 18861);

                                    inBrackets = false;
                                    DynAbs.Tracing.TraceSender.TraceBreak(272, 18891, 18897);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(272, 18397, 19273);

                                case '*':
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 18397, 19273);
                                    DynAbs.Tracing.TraceSender.TraceBreak(272, 18962, 18968);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(272, 18397, 19273);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 18397, 19273);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 19032, 19214) || true) && (!inBrackets)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 19032, 19214);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 19176, 19183);

                                        return;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(272, 19032, 19214);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(272, 19244, 19250);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(272, 18397, 19273);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(272, 1, 976);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(272, 1, 976);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(272, 18196, 19307);

                    int
                    f_272_18333_18345(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 18333, 18345);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(272, 18196, 19307);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(272, 18196, 19307);
                }
            }

            private TypeInfo? ParseIndexedTypeParameter(ISymbol bindingContext)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(272, 19323, 21256);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 19423, 19447);

                    var
                    startIndex = _index
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 19467, 19503);

                    f_272_19467_19502(PeekNextChar() == '!');
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 19521, 19530);

                    ++_index;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 19550, 20520) || true) && (PeekNextChar() == '!')
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 19550, 20520);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 19682, 19691);

                        ++_index;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 19713, 19762);

                        var
                        methodTypeParameterIndex = ReadNextInteger()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 19786, 19838);

                        var
                        methodContext = bindingContext as IMethodSymbol
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 19860, 20331) || true) && (methodContext != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 19860, 20331);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 19935, 19983);

                            var
                            count = methodContext.TypeParameters.Length
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 20009, 20222) || true) && (count > 0 && (DynAbs.Tracing.TraceSender.Expression_True(272, 20013, 20058) && methodTypeParameterIndex < count))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 20009, 20222);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 20116, 20195);

                                return TypeInfo.Create(f_272_20139_20167(methodContext)[methodTypeParameterIndex]);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(272, 20009, 20222);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 20296, 20308);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(272, 19860, 20331);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 20459, 20501);

                        return TypeInfo.CreateUnbound(startIndex);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(272, 19550, 20520);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 20601, 20644);

                    var
                    typeParameterIndex = ReadNextInteger()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 20664, 21078) || true) && (bindingContext != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 20664, 21078);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 20732, 20823);

                        var
                        typeParameter = GetNthTypeParameter(f_272_20772_20801(bindingContext), typeParameterIndex)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 20845, 20981) || true) && (typeParameter != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 20845, 20981);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 20920, 20958);

                            return TypeInfo.Create(typeParameter);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(272, 20845, 20981);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 21047, 21059);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(272, 20664, 21078);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 21199, 21241);

                    return TypeInfo.CreateUnbound(startIndex);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(272, 19323, 21256);

                    int
                    f_272_19467_19502(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 19467, 19502);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeParameterSymbol>
                    f_272_20139_20167(Microsoft.CodeAnalysis.IMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 20139, 20167);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.INamedTypeSymbol
                    f_272_20772_20801(Microsoft.CodeAnalysis.ISymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 20772, 20801);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(272, 19323, 21256);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(272, 19323, 21256);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private TypeInfo? ParseNamedTypeParameter(ISymbol bindingContext)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(272, 21272, 22760);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 21370, 21407);

                    f_272_21370_21406(bindingContext != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 21427, 21474);

                    var
                    typeParameterName = ParseNextNameSegment()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 21494, 21546);

                    var
                    methodContext = bindingContext as IMethodSymbol
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 21564, 22068) || true) && (methodContext != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 21564, 22068);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 21724, 21729);
                            // Check this method's type parameters for a name that matches
                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 21715, 22049) || true) && (i < methodContext.TypeParameters.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 21772, 21775)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(272, 21715, 22049))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 21715, 22049);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 21825, 22026) || true) && (f_272_21829_21865(f_272_21829_21857(methodContext)[i]) == typeParameterName)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 21825, 22026);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 21944, 21999);

                                    return TypeInfo.Create(f_272_21967_21994(methodContext)[i]);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(272, 21825, 22026);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(272, 1, 335);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(272, 1, 335);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(272, 21564, 22068);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 22197, 22243);

                        // Walk up the symbol tree until we find a type parameter with a name that matches
                        for (var
        containingType = f_272_22214_22243(bindingContext)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 22188, 22713) || true) && (containingType != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 22269, 22315)
        , containingType = f_272_22286_22315(containingType), DynAbs.Tracing.TraceSender.TraceExitCondition(272, 22188, 22713))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 22188, 22713);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 22366, 22371);
                                for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 22357, 22694) || true) && (i < containingType.TypeParameters.Length)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 22415, 22418)
            , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(272, 22357, 22694))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 22357, 22694);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 22468, 22671) || true) && (f_272_22472_22509(f_272_22472_22501(containingType)[i]) == typeParameterName)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 22468, 22671);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 22588, 22644);

                                        return TypeInfo.Create(f_272_22611_22639(containingType)[i]);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(272, 22468, 22671);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(272, 1, 338);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(272, 1, 338);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(272, 1, 526);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(272, 1, 526);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 22733, 22745);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(272, 21272, 22760);

                    int
                    f_272_21370_21406(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 21370, 21406);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeParameterSymbol>
                    f_272_21829_21857(Microsoft.CodeAnalysis.IMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 21829, 21857);
                        return return_v;
                    }


                    string
                    f_272_21829_21865(Microsoft.CodeAnalysis.ITypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 21829, 21865);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeSymbol>
                    f_272_21967_21994(Microsoft.CodeAnalysis.IMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeArguments;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 21967, 21994);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.INamedTypeSymbol
                    f_272_22214_22243(Microsoft.CodeAnalysis.ISymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 22214, 22243);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.INamedTypeSymbol
                    f_272_22286_22315(Microsoft.CodeAnalysis.INamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 22286, 22315);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeParameterSymbol>
                    f_272_22472_22501(Microsoft.CodeAnalysis.INamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 22472, 22501);
                        return return_v;
                    }


                    string
                    f_272_22472_22509(Microsoft.CodeAnalysis.ITypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 22472, 22509);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeSymbol>
                    f_272_22611_22639(Microsoft.CodeAnalysis.INamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeArguments;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 22611, 22639);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(272, 21272, 22760);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(272, 21272, 22760);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private TypeInfo? ParseNamedType(ISymbol bindingContext)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(272, 22776, 25943);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 22865, 22936);

                    INamespaceOrTypeSymbol
                    containingSymbol = f_272_22907_22935(_compilation)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 22956, 22980);

                    int
                    startIndex = _index
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 23000, 25928) || true) && (true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 23000, 25928);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 23053, 23090);

                            var
                            segment = ParseNextNameSegment()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 23112, 23172);

                            var
                            candidateMembers = f_272_23135_23171(containingSymbol, segment)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 23194, 23341) || true) && (candidateMembers.Length == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 23194, 23341);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 23276, 23318);

                                return TypeInfo.CreateUnbound(startIndex);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(272, 23194, 23341);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 23365, 23379);

                            int
                            arity = 0
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 23401, 23433);

                            TypeInfo[]
                            typeArguments = null
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 23505, 23664) || true) && (PeekNextChar() == '`')
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 23505, 23664);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 23580, 23589);

                                ++_index;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 23615, 23641);

                                arity = ReadNextInteger();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(272, 23505, 23664);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 23741, 24234) || true) && (PeekNextChar() == '<')
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 23741, 24234);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 23816, 23870);

                                typeArguments = ParseTypeArgumentList(bindingContext);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 23896, 24018) || true) && (typeArguments == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 23896, 24018);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 23979, 23991);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(272, 23896, 24018);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 24046, 24211) || true) && (f_272_24050_24084(typeArguments, a => !a.IsBound))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 24046, 24211);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 24142, 24184);

                                    return TypeInfo.CreateUnbound(startIndex);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(272, 24046, 24211);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(272, 23741, 24234);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 24258, 24288);

                            var
                            nextChar = PeekNextChar()
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 24310, 25415) || true) && (nextChar == '.' || (DynAbs.Tracing.TraceSender.Expression_False(272, 24314, 24348) || nextChar == '+'))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 24310, 25415);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 24398, 24407);

                                ++_index;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 24435, 25038) || true) && (arity > 0 || (DynAbs.Tracing.TraceSender.Expression_False(272, 24439, 24467) || nextChar == '+'))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 24435, 25038);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 24645, 24715);

                                    containingSymbol = GetFirstMatchingNamedType(candidateMembers, arity);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(272, 24435, 25038);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 24435, 25038);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 24942, 25011);

                                    containingSymbol = GetFirstMatchingNamespaceOrType(candidateMembers);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(272, 24435, 25038);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 25066, 25355) || true) && (containingSymbol == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 25066, 25355);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 25316, 25328);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(272, 25066, 25355);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 25383, 25392);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(272, 24310, 25415);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 25439, 25520);

                            INamedTypeSymbol
                            typeSymbol = GetFirstMatchingNamedType(candidateMembers, arity)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 25542, 25649) || true) && (typeSymbol == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 25542, 25649);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 25614, 25626);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(272, 25542, 25649);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 25673, 25850) || true) && (typeArguments != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 25673, 25850);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 25748, 25827);

                                typeSymbol = f_272_25761_25826(typeSymbol, f_272_25782_25825(f_272_25782_25815(typeArguments, t => t.Type)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(272, 25673, 25850);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 25874, 25909);

                            return TypeInfo.Create(typeSymbol);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(272, 23000, 25928);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(272, 23000, 25928);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(272, 23000, 25928);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(272, 22776, 25943);

                    Microsoft.CodeAnalysis.INamespaceSymbol
                    f_272_22907_22935(Microsoft.CodeAnalysis.Compilation
                    this_param)
                    {
                        var return_v = this_param.GlobalNamespace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 22907, 22935);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    f_272_23135_23171(Microsoft.CodeAnalysis.INamespaceOrTypeSymbol
                    this_param, string
                    name)
                    {
                        var return_v = this_param.GetMembers(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 23135, 23171);
                        return return_v;
                    }


                    bool
                    f_272_24050_24084(Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetSymbolResolver.TypeInfo[]
                    source, System.Func<Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetSymbolResolver.TypeInfo, bool>
                    predicate)
                    {
                        var return_v = source.Any<Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetSymbolResolver.TypeInfo>(predicate);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 24050, 24084);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ITypeSymbol>
                    f_272_25782_25815(Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetSymbolResolver.TypeInfo[]
                    source, System.Func<Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetSymbolResolver.TypeInfo, Microsoft.CodeAnalysis.ITypeSymbol>
                    selector)
                    {
                        var return_v = source.Select<Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetSymbolResolver.TypeInfo, Microsoft.CodeAnalysis.ITypeSymbol>(selector);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 25782, 25815);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ITypeSymbol[]
                    f_272_25782_25825(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ITypeSymbol>
                    source)
                    {
                        var return_v = source.ToArray<Microsoft.CodeAnalysis.ITypeSymbol>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 25782, 25825);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.INamedTypeSymbol
                    f_272_25761_25826(Microsoft.CodeAnalysis.INamedTypeSymbol
                    this_param, params Microsoft.CodeAnalysis.ITypeSymbol[]
                    typeArguments)
                    {
                        var return_v = this_param.Construct(typeArguments);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 25761, 25826);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(272, 22776, 25943);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(272, 22776, 25943);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private TypeInfo[] ParseTypeArgumentList(ISymbol bindingContext)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(272, 25959, 27071);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 26056, 26092);

                    f_272_26056_26091(PeekNextChar() == '<');
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 26110, 26119);

                    ++_index;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 26139, 26182);

                    var
                    builder = f_272_26153_26181()
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 26202, 26758) || true) && (true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 26202, 26758);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 26255, 26292);

                            var
                            type = ParseType(bindingContext)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 26314, 26456) || true) && (type == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 26314, 26456);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 26380, 26395);

                                f_272_26380_26394(builder);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 26421, 26433);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(272, 26314, 26456);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 26480, 26504);

                            f_272_26480_26503(
                                                builder, type.Value);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 26528, 26739) || true) && (PeekNextChar() == ',')
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 26528, 26739);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 26603, 26612);

                                ++_index;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(272, 26528, 26739);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 26528, 26739);
                                DynAbs.Tracing.TraceSender.TraceBreak(272, 26710, 26716);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(272, 26528, 26739);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(272, 26202, 26758);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(272, 26202, 26758);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(272, 26202, 26758);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 26778, 27004) || true) && (PeekNextChar() == '>')
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 26778, 27004);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 26845, 26854);

                        ++_index;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(272, 26778, 27004);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 26778, 27004);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 26936, 26951);

                        f_272_26936_26950(builder);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 26973, 26985);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(272, 26778, 27004);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 27024, 27056);

                    return f_272_27031_27055(builder);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(272, 25959, 27071);

                    int
                    f_272_26056_26091(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 26056, 26091);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetSymbolResolver.TypeInfo>
                    f_272_26153_26181()
                    {
                        var return_v = new Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetSymbolResolver.TypeInfo>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 26153, 26181);
                        return return_v;
                    }


                    int
                    f_272_26380_26394(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetSymbolResolver.TypeInfo>
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 26380, 26394);
                        return 0;
                    }


                    int
                    f_272_26480_26503(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetSymbolResolver.TypeInfo>
                    this_param, Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetSymbolResolver.TypeInfo
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 26480, 26503);
                        return 0;
                    }


                    int
                    f_272_26936_26950(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetSymbolResolver.TypeInfo>
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 26936, 26950);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetSymbolResolver.TypeInfo[]
                    f_272_27031_27055(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetSymbolResolver.TypeInfo>
                    this_param)
                    {
                        var return_v = this_param.ToArrayAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 27031, 27055);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(272, 25959, 27071);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(272, 25959, 27071);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private ITypeSymbol ParseArrayType(ITypeSymbol typeSymbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(272, 27087, 28013);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 27178, 27214);

                    f_272_27178_27213(PeekNextChar() == '[');
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 27232, 27241);

                    ++_index;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 27259, 27272);

                    int
                    rank = 1
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 27292, 27998) || true) && (true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 27292, 27998);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 27345, 27375);

                            var
                            nextChar = PeekNextChar()
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 27397, 27946) || true) && (nextChar == ',')
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 27397, 27946);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 27466, 27473);

                                ++rank;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(272, 27397, 27946);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 27397, 27946);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 27523, 27946) || true) && (nextChar == ']')
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 27523, 27946);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 27592, 27601);

                                    ++_index;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 27627, 27687);

                                    return f_272_27634_27686(_compilation, typeSymbol, rank);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(272, 27523, 27946);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 27523, 27946);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 27737, 27946) || true) && (!f_272_27742_27764(nextChar) && (DynAbs.Tracing.TraceSender.Expression_True(272, 27741, 27783) && nextChar != '.'))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 27737, 27946);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 27911, 27923);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(272, 27737, 27946);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(272, 27523, 27946);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(272, 27397, 27946);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 27970, 27979);

                            ++_index;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(272, 27292, 27998);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(272, 27292, 27998);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(272, 27292, 27998);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(272, 27087, 28013);

                    int
                    f_272_27178_27213(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 27178, 27213);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.IArrayTypeSymbol
                    f_272_27634_27686(Microsoft.CodeAnalysis.Compilation
                    this_param, Microsoft.CodeAnalysis.ITypeSymbol
                    elementType, int
                    rank)
                    {
                        var return_v = this_param.CreateArrayTypeSymbol(elementType, rank);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 27634, 27686);
                        return return_v;
                    }


                    bool
                    f_272_27742_27764(char
                    c)
                    {
                        var return_v = char.IsDigit(c);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 27742, 27764);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(272, 27087, 28013);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(272, 27087, 28013);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private ISymbol GetFirstMatchingIndexer(ImmutableArray<ISymbol> candidateMembers, ParameterInfo[] parameters)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(272, 28029, 28569);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 28171, 28522);
                        foreach (var symbol in f_272_28194_28210_I(candidateMembers))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 28171, 28522);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 28252, 28299);

                            var
                            propertySymbol = symbol as IPropertySymbol
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 28321, 28503) || true) && (propertySymbol != null && (DynAbs.Tracing.TraceSender.Expression_True(272, 28325, 28408) && AllParametersMatch(f_272_28370_28395(propertySymbol), parameters)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 28321, 28503);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 28458, 28480);

                                return propertySymbol;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(272, 28321, 28503);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(272, 28171, 28522);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(272, 1, 352);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(272, 1, 352);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 28542, 28554);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(272, 28029, 28569);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IParameterSymbol>
                    f_272_28370_28395(Microsoft.CodeAnalysis.IPropertySymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 28370, 28395);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    f_272_28194_28210_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 28194, 28210);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(272, 28029, 28569);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(272, 28029, 28569);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private ImmutableArray<IMethodSymbol> GetMatchingMethods(ImmutableArray<ISymbol> candidateMembers, int? arity, ParameterInfo[] parameters, TypeInfo? returnType)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(272, 28585, 30117);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 28778, 28826);

                    var
                    builder = f_272_28792_28825()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 28846, 30046);
                        foreach (var symbol in f_272_28869_28885_I(candidateMembers))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 28846, 30046);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 28927, 28970);

                            var
                            methodSymbol = symbol as IMethodSymbol
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 28992, 29173) || true) && (methodSymbol == null || (DynAbs.Tracing.TraceSender.Expression_False(272, 28996, 29091) || (arity != null && (DynAbs.Tracing.TraceSender.Expression_True(272, 29046, 29090) && f_272_29063_29081(methodSymbol) != arity))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 28992, 29173);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 29141, 29150);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(272, 28992, 29173);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 29197, 29339) || true) && (!AllParametersMatch(f_272_29221_29244(methodSymbol), parameters))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 29197, 29339);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 29307, 29316);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(272, 29197, 29339);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 29363, 30027) || true) && (returnType == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 29363, 30027);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 29509, 29535);

                                f_272_29509_29534(                        // If no return type specified, then any matches
                                                        builder, methodSymbol);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(272, 29363, 30027);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 29363, 30027);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 29709, 29789);

                                var
                                boundReturnType = BindParameterOrReturnType(methodSymbol, returnType.Value)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 29815, 30004) || true) && (boundReturnType != null && (DynAbs.Tracing.TraceSender.Expression_True(272, 29819, 29893) && f_272_29846_29893(f_272_29846_29869(methodSymbol), boundReturnType)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 29815, 30004);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 29951, 29977);

                                    f_272_29951_29976(builder, methodSymbol);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(272, 29815, 30004);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(272, 29363, 30027);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(272, 28846, 30046);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(272, 1, 1201);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(272, 1, 1201);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 30066, 30102);

                    return f_272_30073_30101(builder);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(272, 28585, 30117);

                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.IMethodSymbol>
                    f_272_28792_28825()
                    {
                        var return_v = new Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.IMethodSymbol>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 28792, 28825);
                        return return_v;
                    }


                    int
                    f_272_29063_29081(Microsoft.CodeAnalysis.IMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 29063, 29081);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IParameterSymbol>
                    f_272_29221_29244(Microsoft.CodeAnalysis.IMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 29221, 29244);
                        return return_v;
                    }


                    int
                    f_272_29509_29534(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.IMethodSymbol>
                    this_param, Microsoft.CodeAnalysis.IMethodSymbol
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 29509, 29534);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.ITypeSymbol
                    f_272_29846_29869(Microsoft.CodeAnalysis.IMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 29846, 29869);
                        return return_v;
                    }


                    bool
                    f_272_29846_29893(Microsoft.CodeAnalysis.ITypeSymbol
                    this_param, Microsoft.CodeAnalysis.ITypeSymbol
                    other)
                    {
                        var return_v = this_param.Equals((Microsoft.CodeAnalysis.ISymbol)other);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 29846, 29893);
                        return return_v;
                    }


                    int
                    f_272_29951_29976(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.IMethodSymbol>
                    this_param, Microsoft.CodeAnalysis.IMethodSymbol
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 29951, 29976);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    f_272_28869_28885_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ISymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 28869, 28885);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IMethodSymbol>
                    f_272_30073_30101(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.IMethodSymbol>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 30073, 30101);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(272, 28585, 30117);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(272, 28585, 30117);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool AllParametersMatch(ImmutableArray<IParameterSymbol> symbolParameters, ParameterInfo[] expectedParameters)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(272, 30133, 30743);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 30284, 30414) || true) && (symbolParameters.Length != f_272_30315_30340(expectedParameters))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 30284, 30414);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 30382, 30395);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(272, 30284, 30414);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 30443, 30448);

                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 30434, 30696) || true) && (i < f_272_30454_30479(expectedParameters))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 30481, 30484)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(272, 30434, 30696))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 30434, 30696);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 30526, 30677) || true) && (!ParameterMatches(symbolParameters[i], expectedParameters[i]))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 30526, 30677);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 30641, 30654);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(272, 30526, 30677);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(272, 1, 263);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(272, 1, 263);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 30716, 30728);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(272, 30133, 30743);

                    int
                    f_272_30315_30340(Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetSymbolResolver.ParameterInfo[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 30315, 30340);
                        return return_v;
                    }


                    int
                    f_272_30454_30479(Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetSymbolResolver.ParameterInfo[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 30454, 30479);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(272, 30133, 30743);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(272, 30133, 30743);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool ParameterMatches(IParameterSymbol symbol, ParameterInfo parameterInfo)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(272, 30759, 31260);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 30910, 31048) || true) && ((f_272_30915_30929(symbol) == RefKind.None) == parameterInfo.IsRefOrOut)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 30910, 31048);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 31016, 31029);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(272, 30910, 31048);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 31068, 31159);

                    var
                    parameterType = BindParameterOrReturnType(f_272_31114_31137(symbol), parameterInfo.Type)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 31179, 31245);

                    return parameterType != null && (DynAbs.Tracing.TraceSender.Expression_True(272, 31186, 31244) && f_272_31211_31244(f_272_31211_31222(symbol), parameterType));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(272, 30759, 31260);

                    Microsoft.CodeAnalysis.RefKind
                    f_272_30915_30929(Microsoft.CodeAnalysis.IParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 30915, 30929);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ISymbol
                    f_272_31114_31137(Microsoft.CodeAnalysis.IParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 31114, 31137);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ITypeSymbol
                    f_272_31211_31222(Microsoft.CodeAnalysis.IParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 31211, 31222);
                        return return_v;
                    }


                    bool
                    f_272_31211_31244(Microsoft.CodeAnalysis.ITypeSymbol
                    this_param, Microsoft.CodeAnalysis.ITypeSymbol
                    other)
                    {
                        var return_v = this_param.Equals((Microsoft.CodeAnalysis.ISymbol)other);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 31211, 31244);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(272, 30759, 31260);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(272, 30759, 31260);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private ITypeSymbol BindParameterOrReturnType(ISymbol bindingContext, TypeInfo type)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(272, 31276, 31733);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 31393, 31487) || true) && (type.IsBound)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 31393, 31487);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 31451, 31468);

                        return type.Type;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(272, 31393, 31487);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 31507, 31533);

                    var
                    currentIndex = _index
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 31551, 31576);

                    _index = type.StartIndex;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 31594, 31638);

                    var
                    result = this.ParseType(bindingContext)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 31656, 31678);

                    _index = currentIndex;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 31698, 31718);

                    return DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(result, 272, 31705, 31717)?.Type;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(272, 31276, 31733);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(272, 31276, 31733);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(272, 31276, 31733);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static INamedTypeSymbol GetFirstMatchingNamedType(ImmutableArray<ISymbol> candidateMembers, int arity)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(272, 31749, 32083);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 31892, 32068);

                    return (INamedTypeSymbol)candidateMembers.FirstOrDefault(s =>
                                        s.Kind == SymbolKind.NamedType &&
                                        ((INamedTypeSymbol)s).Arity == arity);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(272, 31749, 32083);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(272, 31749, 32083);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(272, 31749, 32083);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static INamespaceOrTypeSymbol GetFirstMatchingNamespaceOrType(ImmutableArray<ISymbol> candidateMembers)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(272, 32099, 32464);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 32243, 32449);

                    return (INamespaceOrTypeSymbol)candidateMembers
                                        .FirstOrDefault(s =>
                                            s.Kind == SymbolKind.Namespace ||
                                            s.Kind == SymbolKind.NamedType);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(272, 32099, 32464);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(272, 32099, 32464);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(272, 32099, 32464);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static ITypeParameterSymbol GetNthTypeParameter(INamedTypeSymbol typeSymbol, int n)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(272, 32480, 32962);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 32604, 32688);

                    var
                    containingTypeParameterCount = GetTypeParameterCount(f_272_32661_32686(typeSymbol))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 32706, 32860) || true) && (n < containingTypeParameterCount)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 32706, 32860);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 32784, 32841);

                        return GetNthTypeParameter(f_272_32811_32836(typeSymbol), n);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(272, 32706, 32860);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 32880, 32947);

                    return f_272_32887_32912(typeSymbol)[n - containingTypeParameterCount];
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(272, 32480, 32962);

                    Microsoft.CodeAnalysis.INamedTypeSymbol
                    f_272_32661_32686(Microsoft.CodeAnalysis.INamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 32661, 32686);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.INamedTypeSymbol
                    f_272_32811_32836(Microsoft.CodeAnalysis.INamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 32811, 32836);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ITypeParameterSymbol>
                    f_272_32887_32912(Microsoft.CodeAnalysis.INamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 32887, 32912);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(272, 32480, 32962);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(272, 32480, 32962);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static int GetTypeParameterCount(INamedTypeSymbol typeSymbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(272, 32978, 33298);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 33080, 33172) || true) && (typeSymbol == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(272, 33080, 33172);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 33144, 33153);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(272, 33080, 33172);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 33192, 33283);

                    return typeSymbol.TypeParameters.Length + GetTypeParameterCount(f_272_33256_33281(typeSymbol));
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(272, 32978, 33298);

                    Microsoft.CodeAnalysis.INamedTypeSymbol
                    f_272_33256_33281(Microsoft.CodeAnalysis.INamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(272, 33256, 33281);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(272, 32978, 33298);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(272, 32978, 33298);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            [StructLayout(LayoutKind.Auto)]
            private struct TypeInfo
            {

                public readonly ITypeSymbol Type;

                public readonly int StartIndex;

                public bool IsBound
                {
                    get
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterMethod(272, 33784, 33804);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 33787, 33804);
                            return this.Type != null; DynAbs.Tracing.TraceSender.TraceExitMethod(272, 33784, 33804);
                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(272, 33784, 33804);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(272, 33784, 33804);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                }

                private TypeInfo(ITypeSymbol type, int startIndex)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(272, 33825, 34003);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 33916, 33933);

                        this.Type = type;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 33955, 33984);

                        this.StartIndex = startIndex;
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(272, 33825, 34003);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(272, 33825, 34003);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(272, 33825, 34003);
                    }
                }

                public static TypeInfo Create(ITypeSymbol type)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(272, 34023, 34209);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 34111, 34138);

                        f_272_34111_34137(type != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 34160, 34190);

                        return f_272_34167_34189(type, -1);
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(272, 34023, 34209);

                        int
                        f_272_34111_34137(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 34111, 34137);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetSymbolResolver.TypeInfo
                        f_272_34167_34189(Microsoft.CodeAnalysis.ITypeSymbol
                        type, int
                        startIndex)
                        {
                            var return_v = new Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetSymbolResolver.TypeInfo(type, startIndex);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 34167, 34189);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(272, 34023, 34209);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(272, 34023, 34209);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public static TypeInfo CreateUnbound(int startIndex)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(272, 34229, 34431);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 34322, 34352);

                        f_272_34322_34351(startIndex >= 0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 34374, 34412);

                        return f_272_34381_34411(null, startIndex);
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(272, 34229, 34431);

                        int
                        f_272_34322_34351(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 34322, 34351);
                            return 0;
                        }


                        Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetSymbolResolver.TypeInfo
                        f_272_34381_34411(Microsoft.CodeAnalysis.ITypeSymbol
                        type, int
                        startIndex)
                        {
                            var return_v = new Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetSymbolResolver.TypeInfo(type, startIndex);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 34381, 34411);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(272, 34229, 34431);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(272, 34229, 34431);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                static TypeInfo()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(272, 33314, 34446);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(272, 33314, 34446);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(272, 33314, 34446);
                }
            }

            [StructLayout(LayoutKind.Auto)]
            private struct ParameterInfo
            {

                public readonly TypeInfo Type;

                public readonly bool IsRefOrOut;

                public ParameterInfo(TypeInfo type, bool isRefOrOut)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(272, 34668, 34848);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 34761, 34778);

                        this.Type = type;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 34800, 34829);

                        this.IsRefOrOut = isRefOrOut;
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(272, 34668, 34848);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(272, 34668, 34848);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(272, 34668, 34848);
                    }
                }
                static ParameterInfo()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(272, 34462, 34863);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(272, 34462, 34863);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(272, 34462, 34863);
                }
            }
            static TargetSymbolResolver()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(272, 655, 34874);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 787, 883);
                s_nameDelimiters = new char[] { ':', '.', '+', '(', ')', '<', '>', '[', ']', '{', '}', ',', '&', '*', '`' }; 
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 931, 1137);
                s_callingConventionStrings = new string[] {
                    "[vararg]",
                "[cdecl]",
                "[fastcall]",
                "[stdcall]",
                "[thiscall]"
                            }; 
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(272, 1194, 1239);
                s_noParameters = f_272_1211_1239(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(272, 655, 34874);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(272, 655, 34874);
            }

            static Microsoft.CodeAnalysis.Diagnostics.SuppressMessageAttributeState.TargetSymbolResolver.ParameterInfo[]
            f_272_1211_1239()
            {
                var return_v = Array.Empty<ParameterInfo>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(272, 1211, 1239);
                return return_v;
            }

        }
    }
}
