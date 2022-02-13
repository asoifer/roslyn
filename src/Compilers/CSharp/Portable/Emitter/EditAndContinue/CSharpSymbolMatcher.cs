// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE;
using Microsoft.CodeAnalysis.Symbols;

namespace Microsoft.CodeAnalysis.CSharp.Emit
{
    internal sealed class CSharpSymbolMatcher : SymbolMatcher
    {
        private readonly MatchDefs _defs;

        private readonly MatchSymbols _symbols;

        public CSharpSymbolMatcher(
                    IReadOnlyDictionary<AnonymousTypeKey, AnonymousTypeValue> anonymousTypeMap,
                    SourceAssemblySymbol sourceAssembly,
                    EmitContext sourceContext,
                    SourceAssemblySymbol otherAssembly,
                    EmitContext otherContext,
                    ImmutableDictionary<ISymbolInternal, ImmutableArray<ISymbolInternal>> otherSynthesizedMembersOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10940, 898, 1594);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 831, 836);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 877, 885);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 1328, 1387);

                _defs = f_10940_1336_1386(sourceContext, otherContext);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 1401, 1583);

                _symbols = f_10940_1412_1582(anonymousTypeMap, sourceAssembly, otherAssembly, otherSynthesizedMembersOpt, f_10940_1506_1581(f_10940_1525_1580(otherAssembly, SpecialType.System_Object)));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10940, 898, 1594);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 898, 1594);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 898, 1594);
            }
        }

        public CSharpSymbolMatcher(
                    IReadOnlyDictionary<AnonymousTypeKey, AnonymousTypeValue> anonymousTypeMap,
                    SourceAssemblySymbol sourceAssembly,
                    EmitContext sourceContext,
                    PEAssemblySymbol otherAssembly)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10940, 1606, 2193);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 831, 836);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 877, 885);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 1882, 1944);

                _defs = f_10940_1890_1943(sourceContext, otherAssembly);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 1960, 2182);

                _symbols = f_10940_1971_2181(anonymousTypeMap, sourceAssembly, otherAssembly, otherSynthesizedMembersOpt: null, deepTranslatorOpt: null);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10940, 1606, 2193);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 1606, 2193);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 1606, 2193);
            }
        }

        public override Cci.IDefinition MapDefinition(Cci.IDefinition definition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 2205, 2529);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 2303, 2468) || true) && (f_10940_2307_2338_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(definition, 10940, 2307, 2338)?.GetInternalSymbol()) is Symbol symbol)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 2303, 2468);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 2389, 2453);

                    return (Cci.IDefinition)f_10940_2413_2452_I(f_10940_2413_2435(_symbols, symbol).GetCciAdapter());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 2303, 2468);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 2484, 2518);

                return f_10940_2491_2517(_defs, definition);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 2205, 2529);

                Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                f_10940_2307_2338_I(Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 2307, 2338);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10940_2413_2435(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = this_param?.Visit(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 2413, 2435);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SymbolAdapter?
                f_10940_2413_2452_I(Microsoft.CodeAnalysis.CSharp.SymbolAdapter?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 2413, 2452);
                    return return_v;
                }


                Microsoft.Cci.IDefinition
                f_10940_2491_2517(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchDefs
                this_param, Microsoft.Cci.IDefinition?
                def)
                {
                    var return_v = this_param.VisitDef(def);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 2491, 2517);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 2205, 2529);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 2205, 2529);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Cci.INamespace MapNamespace(Cci.INamespace @namespace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 2541, 2752);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 2636, 2741);

                return (Cci.INamespace)f_10940_2659_2740_I(f_10940_2659_2723(_symbols, 
                    (NamespaceSymbol?)f_10940_2691_2722_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression
                    (@namespace, 10940, 2691, 2722)?.GetInternalSymbol())).GetCciAdapter());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 2541, 2752);

                Microsoft.CodeAnalysis.Symbols.INamespaceSymbolInternal?
                f_10940_2691_2722_I(Microsoft.CodeAnalysis.Symbols.INamespaceSymbolInternal?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 2691, 2722);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10940_2659_2723(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol?
                symbol)
                {
                    var return_v = this_param?.Visit((Microsoft.CodeAnalysis.CSharp.Symbol?)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 2659, 2723);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SymbolAdapter?
                f_10940_2659_2740_I(Microsoft.CodeAnalysis.CSharp.SymbolAdapter?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 2659, 2740);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 2541, 2752);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 2541, 2752);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Cci.ITypeReference MapReference(Cci.ITypeReference reference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 2764, 3072);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 2866, 3033) || true) && (f_10940_2870_2900_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(reference, 10940, 2870, 2900)?.GetInternalSymbol()) is Symbol symbol)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 2866, 3033);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 2951, 3018);

                    return (Cci.ITypeReference)f_10940_2978_3017_I(f_10940_2978_3000(_symbols, symbol).GetCciAdapter());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 2866, 3033);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 3049, 3061);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 2764, 3072);

                Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                f_10940_2870_2900_I(Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 2870, 2900);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10940_2978_3000(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = this_param?.Visit(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 2978, 3000);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SymbolAdapter?
                f_10940_2978_3017_I(Microsoft.CodeAnalysis.CSharp.SymbolAdapter?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 2978, 3017);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 2764, 3072);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 2764, 3072);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool TryGetAnonymousTypeName(AnonymousTypeManager.AnonymousTypeTemplateSymbol template, out string name, out int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 3084, 3319);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 3237, 3308);

                return f_10940_3244_3307(_symbols, template, out name, out index);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 3084, 3319);

                bool
                f_10940_3244_3307(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol
                type, out string
                name, out int
                index)
                {
                    var return_v = this_param.TryGetAnonymousTypeName(type, out name, out index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 3244, 3307);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 3084, 3319);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 3084, 3319);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private abstract class MatchDefs
        {
            private readonly EmitContext _sourceContext;

            private readonly ConcurrentDictionary<Cci.IDefinition, Cci.IDefinition> _matches;

            private IReadOnlyDictionary<string, Cci.INamespaceTypeDefinition> _lazyTopLevelTypes;

            public MatchDefs(EmitContext sourceContext)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10940, 3642, 3888);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 3518, 3526);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 3607, 3625);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 3718, 3749);

                    _sourceContext = sourceContext;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 3767, 3873);

                    _matches = f_10940_3778_3872(ReferenceEqualityComparer.Instance);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10940, 3642, 3888);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 3642, 3888);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 3642, 3888);
                }
            }

            public Cci.IDefinition VisitDef(Cci.IDefinition def)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 3904, 4057);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 3989, 4042);

                    return f_10940_3996_4041(_matches, def, this.VisitDefInternal);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 3904, 4057);

                    Microsoft.Cci.IDefinition
                    f_10940_3996_4041(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.Cci.IDefinition, Microsoft.Cci.IDefinition>
                    this_param, Microsoft.Cci.IDefinition
                    key, System.Func<Microsoft.Cci.IDefinition, Microsoft.Cci.IDefinition>
                    valueFactory)
                    {
                        var return_v = this_param.GetOrAdd(key, valueFactory);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 3996, 4041);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 3904, 4057);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 3904, 4057);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private Cci.IDefinition VisitDefInternal(Cci.IDefinition def)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 4073, 5892);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 4167, 4205);

                    var
                    type = def as Cci.ITypeDefinition
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 4223, 5066) || true) && (type != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 4223, 5066);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 4281, 4348);

                        var
                        namespaceType = f_10940_4301_4347(type, _sourceContext)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 4370, 4509) || true) && (namespaceType != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 4370, 4509);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 4445, 4486);

                            return f_10940_4452_4485(this, namespaceType);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 4370, 4509);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 4533, 4594);

                        var
                        nestedType = f_10940_4550_4593(type, _sourceContext)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 4616, 4649);

                        f_10940_4616_4648(nestedType != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 4673, 4766);

                        var
                        otherContainer = (Cci.ITypeDefinition)f_10940_4715_4765(this, f_10940_4729_4764(nestedType))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 4788, 4899) || true) && (otherContainer == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 4788, 4899);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 4864, 4876);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 4788, 4899);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 4923, 5047);

                        return f_10940_4930_5046(otherContainer, nestedType, GetNestedTypes, (a, b) => StringOrdinalComparer.Equals(a.Name, b.Name));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 4223, 5066);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 5086, 5132);

                    var
                    member = def as Cci.ITypeDefinitionMember
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 5150, 5741) || true) && (member != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 5150, 5741);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 5210, 5299);

                        var
                        otherContainer = (Cci.ITypeDefinition)f_10940_5252_5298(this, f_10940_5266_5297(member))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 5321, 5432) || true) && (otherContainer == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 5321, 5432);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 5397, 5409);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 5321, 5432);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 5456, 5496);

                        var
                        field = def as Cci.IFieldDefinition
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 5518, 5722) || true) && (field != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 5518, 5722);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 5585, 5699);

                            return f_10940_5592_5698(otherContainer, field, GetFields, (a, b) => StringOrdinalComparer.Equals(a.Name, b.Name));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 5518, 5722);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 5150, 5741);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 5831, 5877);

                    throw f_10940_5837_5876(def);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 4073, 5892);

                    Microsoft.Cci.INamespaceTypeDefinition?
                    f_10940_4301_4347(Microsoft.Cci.ITypeDefinition
                    this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                    context)
                    {
                        var return_v = this_param.AsNamespaceTypeDefinition(context);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 4301, 4347);
                        return return_v;
                    }


                    Microsoft.Cci.INamespaceTypeDefinition
                    f_10940_4452_4485(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchDefs
                    this_param, Microsoft.Cci.INamespaceTypeDefinition
                    def)
                    {
                        var return_v = this_param.VisitNamespaceType(def);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 4452, 4485);
                        return return_v;
                    }


                    Microsoft.Cci.INestedTypeDefinition?
                    f_10940_4550_4593(Microsoft.Cci.ITypeDefinition
                    this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                    context)
                    {
                        var return_v = this_param.AsNestedTypeDefinition(context);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 4550, 4593);
                        return return_v;
                    }


                    int
                    f_10940_4616_4648(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 4616, 4648);
                        return 0;
                    }


                    Microsoft.Cci.ITypeDefinition
                    f_10940_4729_4764(Microsoft.Cci.INestedTypeDefinition
                    this_param)
                    {
                        var return_v = this_param.ContainingTypeDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 4729, 4764);
                        return return_v;
                    }


                    Microsoft.Cci.IDefinition
                    f_10940_4715_4765(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchDefs
                    this_param, Microsoft.Cci.ITypeDefinition
                    def)
                    {
                        var return_v = this_param.VisitDef((Microsoft.Cci.IDefinition)def);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 4715, 4765);
                        return return_v;
                    }


                    Microsoft.Cci.INestedTypeDefinition
                    f_10940_4930_5046(Microsoft.Cci.ITypeDefinition
                    otherContainer, Microsoft.Cci.INestedTypeDefinition
                    member, System.Func<Microsoft.Cci.ITypeDefinition, System.Collections.Generic.IEnumerable<Microsoft.Cci.INestedTypeDefinition>>
                    getMembers, System.Func<Microsoft.Cci.INestedTypeDefinition, Microsoft.Cci.INestedTypeDefinition, bool>
                    predicate)
                    {
                        var return_v = VisitTypeMembers(otherContainer, member, getMembers, predicate);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 4930, 5046);
                        return return_v;
                    }


                    Microsoft.Cci.ITypeDefinition
                    f_10940_5266_5297(Microsoft.Cci.ITypeDefinitionMember
                    this_param)
                    {
                        var return_v = this_param.ContainingTypeDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 5266, 5297);
                        return return_v;
                    }


                    Microsoft.Cci.IDefinition
                    f_10940_5252_5298(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchDefs
                    this_param, Microsoft.Cci.ITypeDefinition
                    def)
                    {
                        var return_v = this_param.VisitDef((Microsoft.Cci.IDefinition)def);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 5252, 5298);
                        return return_v;
                    }


                    Microsoft.Cci.IFieldDefinition
                    f_10940_5592_5698(Microsoft.Cci.ITypeDefinition
                    otherContainer, Microsoft.Cci.IFieldDefinition
                    member, System.Func<Microsoft.Cci.ITypeDefinition, System.Collections.Generic.IEnumerable<Microsoft.Cci.IFieldDefinition>>
                    getMembers, System.Func<Microsoft.Cci.IFieldDefinition, Microsoft.Cci.IFieldDefinition, bool>
                    predicate)
                    {
                        var return_v = VisitTypeMembers(otherContainer, member, getMembers, predicate);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 5592, 5698);
                        return return_v;
                    }


                    System.Exception
                    f_10940_5837_5876(Microsoft.Cci.IDefinition
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 5837, 5876);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 4073, 5892);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 4073, 5892);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected abstract IEnumerable<Cci.INamespaceTypeDefinition> GetTopLevelTypes();

            protected abstract IEnumerable<Cci.INestedTypeDefinition> GetNestedTypes(Cci.ITypeDefinition def);

            protected abstract IEnumerable<Cci.IFieldDefinition> GetFields(Cci.ITypeDefinition def);

            private Cci.INamespaceTypeDefinition VisitNamespaceType(Cci.INamespaceTypeDefinition def)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 6218, 7039);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 6684, 6801) || true) && (!f_10940_6689_6728(f_10940_6710_6727(def)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 6684, 6801);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 6770, 6782);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 6684, 6801);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 6821, 6866);

                    var
                    topLevelTypes = f_10940_6841_6865(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 6884, 6922);

                    Cci.INamespaceTypeDefinition
                    otherDef
                    = default(Cci.INamespaceTypeDefinition);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 6940, 6990);

                    f_10940_6940_6989(topLevelTypes, f_10940_6966_6974(def), out otherDef);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 7008, 7024);

                    return otherDef;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 6218, 7039);

                    string
                    f_10940_6710_6727(Microsoft.Cci.INamespaceTypeDefinition
                    this_param)
                    {
                        var return_v = this_param.NamespaceName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 6710, 6727);
                        return return_v;
                    }


                    bool
                    f_10940_6689_6728(string
                    value)
                    {
                        var return_v = string.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 6689, 6728);
                        return return_v;
                    }


                    System.Collections.Generic.IReadOnlyDictionary<string, Microsoft.Cci.INamespaceTypeDefinition>
                    f_10940_6841_6865(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchDefs
                    this_param)
                    {
                        var return_v = this_param.GetTopLevelTypesByName();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 6841, 6865);
                        return return_v;
                    }


                    string?
                    f_10940_6966_6974(Microsoft.Cci.INamespaceTypeDefinition
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 6966, 6974);
                        return return_v;
                    }


                    bool
                    f_10940_6940_6989(System.Collections.Generic.IReadOnlyDictionary<string, Microsoft.Cci.INamespaceTypeDefinition>
                    this_param, string?
                    key, out Microsoft.Cci.INamespaceTypeDefinition
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 6940, 6989);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 6218, 7039);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 6218, 7039);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private IReadOnlyDictionary<string, Cci.INamespaceTypeDefinition> GetTopLevelTypesByName()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 7055, 7925);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 7178, 7864) || true) && (_lazyTopLevelTypes == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 7178, 7864);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 7250, 7353);

                        var
                        typesByName = f_10940_7268_7352(StringOrdinalComparer.Instance)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 7375, 7750);
                            foreach (var type in f_10940_7396_7414_I(f_10940_7396_7414(this)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 7375, 7750);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 7565, 7727) || true) && (f_10940_7569_7609(f_10940_7590_7608(type)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 7565, 7727);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 7667, 7700);

                                    f_10940_7667_7699(typesByName, f_10940_7683_7692(type), type);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 7565, 7727);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 7375, 7750);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10940, 1, 376);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10940, 1, 376);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 7774, 7845);

                        f_10940_7774_7844(ref _lazyTopLevelTypes, typesByName, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 7178, 7864);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 7884, 7910);

                    return _lazyTopLevelTypes;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 7055, 7925);

                    System.Collections.Generic.Dictionary<string, Microsoft.Cci.INamespaceTypeDefinition>
                    f_10940_7268_7352(Roslyn.Utilities.StringOrdinalComparer
                    comparer)
                    {
                        var return_v = new System.Collections.Generic.Dictionary<string, Microsoft.Cci.INamespaceTypeDefinition>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 7268, 7352);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<Microsoft.Cci.INamespaceTypeDefinition>
                    f_10940_7396_7414(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchDefs
                    this_param)
                    {
                        var return_v = this_param.GetTopLevelTypes();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 7396, 7414);
                        return return_v;
                    }


                    string
                    f_10940_7590_7608(Microsoft.Cci.INamespaceTypeDefinition
                    this_param)
                    {
                        var return_v = this_param.NamespaceName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 7590, 7608);
                        return return_v;
                    }


                    bool
                    f_10940_7569_7609(string
                    value)
                    {
                        var return_v = string.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 7569, 7609);
                        return return_v;
                    }


                    string?
                    f_10940_7683_7692(Microsoft.Cci.INamespaceTypeDefinition
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 7683, 7692);
                        return return_v;
                    }


                    int
                    f_10940_7667_7699(System.Collections.Generic.Dictionary<string, Microsoft.Cci.INamespaceTypeDefinition>
                    this_param, string?
                    key, Microsoft.Cci.INamespaceTypeDefinition
                    value)
                    {
                        this_param.Add(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 7667, 7699);
                        return 0;
                    }


                    System.Collections.Generic.IEnumerable<Microsoft.Cci.INamespaceTypeDefinition>
                    f_10940_7396_7414_I(System.Collections.Generic.IEnumerable<Microsoft.Cci.INamespaceTypeDefinition>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 7396, 7414);
                        return return_v;
                    }


                    System.Collections.Generic.IReadOnlyDictionary<string, Microsoft.Cci.INamespaceTypeDefinition>?
                    f_10940_7774_7844(ref System.Collections.Generic.IReadOnlyDictionary<string, Microsoft.Cci.INamespaceTypeDefinition>?
                    location1, System.Collections.Generic.Dictionary<string, Microsoft.Cci.INamespaceTypeDefinition>
                    value, System.Collections.Generic.IReadOnlyDictionary<string, Microsoft.Cci.INamespaceTypeDefinition>?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, (System.Collections.Generic.IReadOnlyDictionary<string, Microsoft.Cci.INamespaceTypeDefinition>)value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 7774, 7844);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 7055, 7925);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 7055, 7925);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static T VisitTypeMembers<T>(
                            Cci.ITypeDefinition otherContainer,
                            T member,
                            Func<Cci.ITypeDefinition, IEnumerable<T>> getMembers,
                            Func<T, T, bool> predicate)
                            where T : class, Cci.ITypeDefinitionMember
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10940, 7941, 8643);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 8532, 8628);

                    return f_10940_8539_8627<T>(f_10940_8539_8565<T>(getMembers, otherContainer), otherMember => predicate(member, otherMember));
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10940, 7941, 8643);

                    System.Collections.Generic.IEnumerable<T>
                    f_10940_8539_8565<T>(System.Func<Microsoft.Cci.ITypeDefinition, System.Collections.Generic.IEnumerable<T>>
                    this_param, Microsoft.Cci.ITypeDefinition
                    arg) where T : class, Cci.ITypeDefinitionMember

                    {
                        var return_v = this_param.Invoke(arg);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 8539, 8565);
                        return return_v;
                    }


                    T
                    f_10940_8539_8627<T>(System.Collections.Generic.IEnumerable<T>
                    source, System.Func<T, bool>
                    predicate) where T : class, Cci.ITypeDefinitionMember

                    {
                        var return_v = source.FirstOrDefault<T>(predicate);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 8539, 8627);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 7941, 8643);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 7941, 8643);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static MatchDefs()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10940, 3331, 8654);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10940, 3331, 8654);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 3331, 8654);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10940, 3331, 8654);

            System.Collections.Concurrent.ConcurrentDictionary<Microsoft.Cci.IDefinition, Microsoft.Cci.IDefinition>
            f_10940_3778_3872(Roslyn.Utilities.ReferenceEqualityComparer
            comparer)
            {
                var return_v = new System.Collections.Concurrent.ConcurrentDictionary<Microsoft.Cci.IDefinition, Microsoft.Cci.IDefinition>((System.Collections.Generic.IEqualityComparer<Microsoft.Cci.IDefinition>)comparer);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 3778, 3872);
                return return_v;
            }

        }
        private sealed class MatchDefsToMetadata : MatchDefs
        {
            private readonly PEAssemblySymbol _otherAssembly;

            public MatchDefsToMetadata(EmitContext sourceContext, PEAssemblySymbol otherAssembly) : base(f_10940_8918_8931_C(sourceContext))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10940, 8808, 9011);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 8777, 8791);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 8965, 8996);

                    _otherAssembly = otherAssembly;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10940, 8808, 9011);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 8808, 9011);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 8808, 9011);
                }
            }

            protected override IEnumerable<Cci.INamespaceTypeDefinition> GetTopLevelTypes()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 9027, 9351);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 9139, 9210);

                    var
                    builder = f_10940_9153_9209()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 9228, 9286);

                    f_10940_9228_9285(builder, f_10940_9254_9284(_otherAssembly));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 9304, 9336);

                    return f_10940_9311_9335(builder);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 9027, 9351);

                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.INamespaceTypeDefinition>
                    f_10940_9153_9209()
                    {
                        var return_v = ArrayBuilder<Cci.INamespaceTypeDefinition>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 9153, 9209);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    f_10940_9254_9284(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.GlobalNamespace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 9254, 9284);
                        return return_v;
                    }


                    int
                    f_10940_9228_9285(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.INamespaceTypeDefinition>
                    builder, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    @namespace)
                    {
                        GetTopLevelTypes(builder, @namespace);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 9228, 9285);
                        return 0;
                    }


                    Microsoft.Cci.INamespaceTypeDefinition[]
                    f_10940_9311_9335(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.INamespaceTypeDefinition>
                    this_param)
                    {
                        var return_v = this_param.ToArrayAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 9311, 9335);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 9027, 9351);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 9027, 9351);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected override IEnumerable<Cci.INestedTypeDefinition> GetNestedTypes(Cci.ITypeDefinition def)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 9367, 9627);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 9497, 9531);

                    var
                    type = (PENamedTypeSymbol)def
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 9549, 9612);

                    return f_10940_9556_9611(f_10940_9556_9577(type));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 9367, 9627);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    f_10940_9556_9577(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetTypeMembers();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 9556, 9577);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<Microsoft.Cci.INestedTypeDefinition>
                    f_10940_9556_9611(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    source)
                    {
                        var return_v = source.Cast<Microsoft.Cci.INestedTypeDefinition>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 9556, 9611);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 9367, 9627);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 9367, 9627);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected override IEnumerable<Cci.IFieldDefinition> GetFields(Cci.ITypeDefinition def)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 9643, 9889);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 9763, 9797);

                    var
                    type = (PENamedTypeSymbol)def
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 9815, 9874);

                    return f_10940_9822_9873(f_10940_9822_9844(type));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 9643, 9889);

                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                    f_10940_9822_9844(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetFieldsToEmit();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 9822, 9844);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<Microsoft.Cci.IFieldDefinition>
                    f_10940_9822_9873(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                    source)
                    {
                        var return_v = source.Cast<Microsoft.Cci.IFieldDefinition>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 9822, 9873);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 9643, 9889);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 9643, 9889);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static void GetTopLevelTypes(ArrayBuilder<Cci.INamespaceTypeDefinition> builder, NamespaceSymbol @namespace)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10940, 9905, 10503);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 10054, 10488);
                        foreach (var member in f_10940_10077_10100_I(f_10940_10077_10100(@namespace)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 10054, 10488);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 10142, 10469) || true) && (f_10940_10146_10157(member) == SymbolKind.Namespace)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 10142, 10469);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 10231, 10282);

                                f_10940_10231_10281(builder, member);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 10142, 10469);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 10142, 10469);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 10380, 10446);

                                f_10940_10380_10445(builder, f_10940_10422_10444(member));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 10142, 10469);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 10054, 10488);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10940, 1, 435);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10940, 1, 435);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10940, 9905, 10503);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10940_10077_10100(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    this_param)
                    {
                        var return_v = this_param.GetMembers();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 10077, 10100);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10940_10146_10157(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 10146, 10157);
                        return return_v;
                    }


                    int
                    f_10940_10231_10281(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.INamespaceTypeDefinition>
                    builder, Microsoft.CodeAnalysis.CSharp.Symbol
                    @namespace)
                    {
                        GetTopLevelTypes(builder, (Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol)@namespace);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 10231, 10281);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.SymbolAdapter
                    f_10940_10422_10444(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.GetCciAdapter();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 10422, 10444);
                        return return_v;
                    }


                    int
                    f_10940_10380_10445(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.INamespaceTypeDefinition>
                    this_param, Microsoft.CodeAnalysis.CSharp.SymbolAdapter
                    item)
                    {
                        this_param.Add((Microsoft.Cci.INamespaceTypeDefinition)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 10380, 10445);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10940_10077_10100_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 10077, 10100);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 9905, 10503);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 9905, 10503);
                }
            }

            static MatchDefsToMetadata()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10940, 8666, 10514);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10940, 8666, 10514);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 8666, 10514);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10940, 8666, 10514);

            static Microsoft.CodeAnalysis.Emit.EmitContext
            f_10940_8918_8931_C(Microsoft.CodeAnalysis.Emit.EmitContext
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10940, 8808, 9011);
                return return_v;
            }

        }
        private sealed class MatchDefsToSource : MatchDefs
        {
            private readonly EmitContext _otherContext;

            public MatchDefsToSource(
                            EmitContext sourceContext,
                            EmitContext otherContext) : base(f_10940_10797_10810_C(sourceContext))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10940, 10660, 10888);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 10844, 10873);

                    _otherContext = otherContext;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10940, 10660, 10888);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 10660, 10888);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 10660, 10888);
                }
            }

            protected override IEnumerable<Cci.INamespaceTypeDefinition> GetTopLevelTypes()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 10904, 11101);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 11016, 11086);

                    return f_10940_11023_11085(_otherContext.Module, _otherContext);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 10904, 11101);

                    System.Collections.Generic.IEnumerable<Microsoft.Cci.INamespaceTypeDefinition>
                    f_10940_11023_11085(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                    this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                    context)
                    {
                        var return_v = this_param.GetTopLevelTypeDefinitions(context);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 11023, 11085);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 10904, 11101);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 10904, 11101);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected override IEnumerable<Cci.INestedTypeDefinition> GetNestedTypes(Cci.ITypeDefinition def)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 11117, 11303);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 11247, 11288);

                    return f_10940_11254_11287(def, _otherContext);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 11117, 11303);

                    System.Collections.Generic.IEnumerable<Microsoft.Cci.INestedTypeDefinition>
                    f_10940_11254_11287(Microsoft.Cci.ITypeDefinition
                    this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                    context)
                    {
                        var return_v = this_param.GetNestedTypes(context);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 11254, 11287);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 11117, 11303);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 11117, 11303);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            protected override IEnumerable<Cci.IFieldDefinition> GetFields(Cci.ITypeDefinition def)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 11319, 11490);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 11439, 11475);

                    return f_10940_11446_11474(def, _otherContext);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 11319, 11490);

                    System.Collections.Generic.IEnumerable<Microsoft.Cci.IFieldDefinition>
                    f_10940_11446_11474(Microsoft.Cci.ITypeDefinition
                    this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                    context)
                    {
                        var return_v = this_param.GetFields(context);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 11446, 11474);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 11319, 11490);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 11319, 11490);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static MatchDefsToSource()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10940, 10526, 11501);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10940, 10526, 11501);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 10526, 11501);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10940, 10526, 11501);

            static Microsoft.CodeAnalysis.Emit.EmitContext
            f_10940_10797_10810_C(Microsoft.CodeAnalysis.Emit.EmitContext
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10940, 10660, 10888);
                return return_v;
            }

        }
        private sealed class MatchSymbols : CSharpSymbolVisitor<Symbol>
        {
            private readonly IReadOnlyDictionary<AnonymousTypeKey, AnonymousTypeValue> _anonymousTypeMap;

            private readonly SourceAssemblySymbol _sourceAssembly;

            private readonly AssemblySymbol _otherAssembly;

            private readonly ImmutableDictionary<ISymbolInternal, ImmutableArray<ISymbolInternal>> _otherSynthesizedMembersOpt;

            private readonly SymbolComparer _comparer;

            private readonly ConcurrentDictionary<Symbol, Symbol> _matches;

            private readonly ConcurrentDictionary<ISymbolInternal, IReadOnlyDictionary<string, ImmutableArray<ISymbolInternal>>> _otherMembers;

            public MatchSymbols(
                            IReadOnlyDictionary<AnonymousTypeKey, AnonymousTypeValue> anonymousTypeMap,
                            SourceAssemblySymbol sourceAssembly,
                            AssemblySymbol otherAssembly,
                            ImmutableDictionary<ISymbolInternal, ImmutableArray<ISymbolInternal>> otherSynthesizedMembersOpt,
                            DeepTranslator deepTranslatorOpt)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10940, 12958, 13952);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 11676, 11693);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 11746, 11761);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 11855, 11869);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 12225, 12252);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 12301, 12310);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 12379, 12387);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 12928, 12941);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 13371, 13408);

                    _anonymousTypeMap = anonymousTypeMap;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 13426, 13459);

                    _sourceAssembly = sourceAssembly;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 13477, 13508);

                    _otherAssembly = otherAssembly;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 13526, 13583);

                    _otherSynthesizedMembersOpt = otherSynthesizedMembersOpt;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 13601, 13657);

                    _comparer = f_10940_13613_13656(this, deepTranslatorOpt);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 13675, 13763);

                    _matches = f_10940_13686_13762(ReferenceEqualityComparer.Instance);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 13781, 13937);

                    _otherMembers = f_10940_13797_13936(ReferenceEqualityComparer.Instance);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10940, 12958, 13952);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 12958, 13952);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 12958, 13952);
                }
            }

            internal bool TryGetAnonymousTypeName(AnonymousTypeManager.AnonymousTypeTemplateSymbol type, out string name, out int index)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 13968, 14450);
                    Microsoft.CodeAnalysis.Emit.AnonymousTypeValue otherType = default(Microsoft.CodeAnalysis.Emit.AnonymousTypeValue);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 14125, 14343) || true) && (f_10940_14129_14174(this, type, out otherType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 14125, 14343);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 14216, 14238);

                        name = otherType.Name;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 14260, 14290);

                        index = otherType.UniqueIndex;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 14312, 14324);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 14125, 14343);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 14363, 14375);

                    name = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 14393, 14404);

                    index = -1;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 14422, 14435);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 13968, 14450);

                    bool
                    f_10940_14129_14174(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol
                    type, out Microsoft.CodeAnalysis.Emit.AnonymousTypeValue
                    otherType)
                    {
                        var return_v = this_param.TryFindAnonymousType(type, out otherType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 14129, 14174);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 13968, 14450);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 13968, 14450);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Symbol DefaultVisit(Symbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 14466, 14664);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 14612, 14649);

                    throw f_10940_14618_14648();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 14466, 14664);

                    System.Exception
                    f_10940_14618_14648()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 14618, 14648);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 14466, 14664);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 14466, 14664);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Symbol Visit(Symbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 14680, 15070);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 14756, 14830);

                    f_10940_14756_14829((object)f_10940_14777_14802(symbol) != (object)_otherAssembly);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 15010, 15055);

                    return f_10940_15017_15054(_matches, symbol, base.Visit);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 14680, 15070);

                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10940_14777_14802(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 14777, 14802);
                        return return_v;
                    }


                    int
                    f_10940_14756_14829(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 14756, 14829);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10940_15017_15054(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    key, System.Func<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                    valueFactory)
                    {
                        var return_v = this_param.GetOrAdd(key, valueFactory);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 15017, 15054);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 14680, 15070);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 14680, 15070);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Symbol VisitArrayType(ArrayTypeSymbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 15086, 16062);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 15180, 15246);

                    var
                    otherElementType = (TypeSymbol)f_10940_15215_15245(this, f_10940_15226_15244(symbol))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 15264, 15480) || true) && (otherElementType is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 15264, 15480);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 15449, 15461);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 15264, 15480);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 15500, 15593);

                    var
                    otherModifiers = f_10940_15521_15592(this, symbol.ElementTypeWithAnnotations.CustomModifiers)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 15613, 15837) || true) && (f_10940_15617_15633(symbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 15613, 15837);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 15675, 15818);

                        return f_10940_15682_15817(_otherAssembly, symbol.ElementTypeWithAnnotations.WithTypeAndModifiers(otherElementType, otherModifiers));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 15613, 15837);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 15857, 16047);

                    return f_10940_15864_16046(_otherAssembly, symbol.ElementTypeWithAnnotations.WithTypeAndModifiers(otherElementType, otherModifiers), f_10940_16000_16011(symbol), f_10940_16013_16025(symbol), f_10940_16027_16045(symbol));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 15086, 16062);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10940_15226_15244(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ElementType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 15226, 15244);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10940_15215_15245(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    symbol)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 15215, 15245);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10940_15521_15592(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    modifiers)
                    {
                        var return_v = this_param.VisitCustomModifiers(modifiers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 15521, 15592);
                        return return_v;
                    }


                    bool
                    f_10940_15617_15633(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsSZArray;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 15617, 15633);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                    f_10940_15682_15817(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    declaringAssembly, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    elementType)
                    {
                        var return_v = ArrayTypeSymbol.CreateSZArray(declaringAssembly, elementType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 15682, 15817);
                        return return_v;
                    }


                    int
                    f_10940_16000_16011(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Rank;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 16000, 16011);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<int>
                    f_10940_16013_16025(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Sizes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 16013, 16025);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<int>
                    f_10940_16027_16045(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.LowerBounds;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 16027, 16045);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                    f_10940_15864_16046(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    declaringAssembly, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    elementType, int
                    rank, System.Collections.Immutable.ImmutableArray<int>
                    sizes, System.Collections.Immutable.ImmutableArray<int>
                    lowerBounds)
                    {
                        var return_v = ArrayTypeSymbol.CreateMDArray(declaringAssembly, elementType, rank, sizes, lowerBounds);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 15864, 16046);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 15086, 16062);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 15086, 16062);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Symbol VisitEvent(EventSymbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 16078, 16236);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 16164, 16221);

                    return f_10940_16171_16220(this, symbol, AreEventsEqual);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 16078, 16236);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10940_16171_16220(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    member, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol, bool>
                    predicate)
                    {
                        var return_v = this_param.VisitNamedTypeMember<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>(member, predicate);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 16171, 16220);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 16078, 16236);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 16078, 16236);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Symbol VisitField(FieldSymbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 16252, 16410);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 16338, 16395);

                    return f_10940_16345_16394(this, symbol, AreFieldsEqual);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 16252, 16410);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10940_16345_16394(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    member, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol, bool>
                    predicate)
                    {
                        var return_v = this_param.VisitNamedTypeMember<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>(member, predicate);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 16345, 16394);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 16252, 16410);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 16252, 16410);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Symbol VisitMethod(MethodSymbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 16426, 16693);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 16568, 16602);

                    f_10940_16568_16601(f_10940_16581_16600(symbol));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 16620, 16678);

                    return f_10940_16627_16677(this, symbol, AreMethodsEqual);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 16426, 16693);

                    bool
                    f_10940_16581_16600(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 16581, 16600);
                        return return_v;
                    }


                    int
                    f_10940_16568_16601(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 16568, 16601);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10940_16627_16677(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    member, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol, bool>
                    predicate)
                    {
                        var return_v = this_param.VisitNamedTypeMember<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>(member, predicate);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 16627, 16677);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 16426, 16693);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 16426, 16693);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Symbol VisitModule(ModuleSymbol module)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 16709, 17733);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 16797, 16866);

                    var
                    otherAssembly = (AssemblySymbol)f_10940_16833_16865(this, f_10940_16839_16864(module))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 16884, 16982) || true) && (otherAssembly is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 16884, 16982);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 16951, 16963);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 16884, 16982);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 17039, 17155) || true) && (f_10940_17043_17057(module) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 17039, 17155);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 17104, 17136);

                        return f_10940_17111_17132(otherAssembly)[0];
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 17039, 17155);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 17239, 17244);

                        // match non-manifest module by name:
                        for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 17230, 17686) || true) && (i < otherAssembly.Modules.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 17280, 17283)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 17230, 17686))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 17230, 17686);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 17325, 17368);

                            var
                            otherModule = f_10940_17343_17364(otherAssembly)[i]
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 17511, 17667) || true) && (f_10940_17515_17575(f_10940_17515_17537(), f_10940_17545_17561(otherModule), f_10940_17563_17574(module)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 17511, 17667);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 17625, 17644);

                                return otherModule;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 17511, 17667);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10940, 1, 457);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10940, 1, 457);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 17706, 17718);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 16709, 17733);

                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10940_16839_16864(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 16839, 16864);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10940_16833_16865(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    symbol)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 16833, 16865);
                        return return_v;
                    }


                    int
                    f_10940_17043_17057(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Ordinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 17043, 17057);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                    f_10940_17111_17132(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.Modules;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 17111, 17132);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                    f_10940_17343_17364(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.Modules;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 17343, 17364);
                        return return_v;
                    }


                    System.StringComparer
                    f_10940_17515_17537()
                    {
                        var return_v = StringComparer.Ordinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 17515, 17537);
                        return return_v;
                    }


                    string
                    f_10940_17545_17561(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 17545, 17561);
                        return return_v;
                    }


                    string
                    f_10940_17563_17574(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 17563, 17574);
                        return return_v;
                    }


                    bool
                    f_10940_17515_17575(System.StringComparer
                    this_param, string
                    x, string
                    y)
                    {
                        var return_v = this_param.Equals(x, y);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 17515, 17575);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 16709, 17733);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 16709, 17733);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Symbol VisitAssembly(AssemblySymbol assembly)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 17749, 19039);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 17843, 17941) || true) && (f_10940_17847_17864(assembly))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 17843, 17941);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 17906, 17922);

                        return assembly;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 17843, 17941);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 18378, 18528) || true) && (f_10940_18382_18445(assembly, _sourceAssembly))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 18378, 18528);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 18487, 18509);

                        return _otherAssembly;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 18378, 18528);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 18661, 18992);
                        foreach (var otherReferencedAssembly in f_10940_18701_18752_I(f_10940_18701_18752(f_10940_18701_18723(_otherAssembly)[0])))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 18661, 18992);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 18794, 18973) || true) && (f_10940_18798_18869(assembly, otherReferencedAssembly))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 18794, 18973);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 18919, 18950);

                                return otherReferencedAssembly;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 18794, 18973);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 18661, 18992);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10940, 1, 332);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10940, 1, 332);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 19012, 19024);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 17749, 19039);

                    bool
                    f_10940_17847_17864(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.IsLinked;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 17847, 17864);
                        return return_v;
                    }


                    bool
                    f_10940_18382_18445(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    left, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    right)
                    {
                        var return_v = IdentityEqualIgnoringVersionWildcard(left, (Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol)right);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 18382, 18445);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                    f_10940_18701_18723(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.Modules;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 18701, 18723);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    f_10940_18701_18752(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.ReferencedAssemblySymbols;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 18701, 18752);
                        return return_v;
                    }


                    bool
                    f_10940_18798_18869(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    left, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    right)
                    {
                        var return_v = IdentityEqualIgnoringVersionWildcard(left, right);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 18798, 18869);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    f_10940_18701_18752_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 18701, 18752);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 17749, 19039);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 17749, 19039);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static bool IdentityEqualIgnoringVersionWildcard(AssemblySymbol left, AssemblySymbol right)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10940, 19055, 19649);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 19187, 19220);

                    var
                    leftIdentity = f_10940_19206_19219(left)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 19238, 19273);

                    var
                    rightIdentity = f_10940_19258_19272(right)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 19293, 19634);

                    return f_10940_19300_19389(f_10940_19300_19343(), f_10940_19351_19368(leftIdentity), f_10940_19370_19388(rightIdentity)) && (DynAbs.Tracing.TraceSender.Expression_True(10940, 19300, 19532) && f_10940_19417_19532((f_10940_19418_19445(left) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Version>(10940, 19418, 19469) ?? f_10940_19449_19469(leftIdentity))), f_10940_19478_19506(right) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Version>(10940, 19478, 19531) ?? f_10940_19510_19531(rightIdentity)))) && (DynAbs.Tracing.TraceSender.Expression_True(10940, 19300, 19633) && f_10940_19560_19633(leftIdentity, rightIdentity));
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10940, 19055, 19649);

                    Microsoft.CodeAnalysis.AssemblyIdentity
                    f_10940_19206_19219(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.Identity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 19206, 19219);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.AssemblyIdentity
                    f_10940_19258_19272(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.Identity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 19258, 19272);
                        return return_v;
                    }


                    System.StringComparer
                    f_10940_19300_19343()
                    {
                        var return_v = AssemblyIdentityComparer.SimpleNameComparer;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 19300, 19343);
                        return return_v;
                    }


                    string
                    f_10940_19351_19368(Microsoft.CodeAnalysis.AssemblyIdentity
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 19351, 19368);
                        return return_v;
                    }


                    string
                    f_10940_19370_19388(Microsoft.CodeAnalysis.AssemblyIdentity
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 19370, 19388);
                        return return_v;
                    }


                    bool
                    f_10940_19300_19389(System.StringComparer
                    this_param, string
                    x, string
                    y)
                    {
                        var return_v = this_param.Equals(x, y);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 19300, 19389);
                        return return_v;
                    }


                    System.Version
                    f_10940_19418_19445(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.AssemblyVersionPattern;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 19418, 19445);
                        return return_v;
                    }


                    System.Version
                    f_10940_19449_19469(Microsoft.CodeAnalysis.AssemblyIdentity
                    this_param)
                    {
                        var return_v = this_param.Version;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 19449, 19469);
                        return return_v;
                    }


                    System.Version
                    f_10940_19478_19506(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.AssemblyVersionPattern;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 19478, 19506);
                        return return_v;
                    }


                    System.Version
                    f_10940_19510_19531(Microsoft.CodeAnalysis.AssemblyIdentity
                    this_param)
                    {
                        var return_v = this_param.Version;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 19510, 19531);
                        return return_v;
                    }


                    bool
                    f_10940_19417_19532(System.Version
                    this_param, System.Version
                    obj)
                    {
                        var return_v = this_param.Equals(obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 19417, 19532);
                        return return_v;
                    }


                    bool
                    f_10940_19560_19633(Microsoft.CodeAnalysis.AssemblyIdentity
                    x, Microsoft.CodeAnalysis.AssemblyIdentity
                    y)
                    {
                        var return_v = AssemblyIdentity.EqualIgnoringNameAndVersion(x, y);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 19560, 19633);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 19055, 19649);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 19055, 19649);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Symbol VisitNamespace(NamespaceSymbol @namespace)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 19665, 20444);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 19763, 19819);

                    var
                    otherContainer = f_10940_19784_19818(this, f_10940_19790_19817(@namespace))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 19837, 19876);

                    f_10940_19837_19875(otherContainer is object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 19896, 20429);

                    switch (f_10940_19904_19923(otherContainer))
                    {

                        case SymbolKind.NetModule:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 19896, 20429);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 20017, 20060);

                            f_10940_20017_20059(f_10940_20030_20058(@namespace));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 20086, 20140);

                            return f_10940_20093_20139(((ModuleSymbol)otherContainer));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 19896, 20429);

                        case SymbolKind.Namespace:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 19896, 20429);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 20216, 20290);

                            return f_10940_20223_20289(this, otherContainer, @namespace, AreNamespacesEqual);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 19896, 20429);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 19896, 20429);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 20348, 20410);

                            throw f_10940_20354_20409(f_10940_20389_20408(otherContainer));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 19896, 20429);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 19665, 20444);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10940_19790_19817(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 19790, 19817);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10940_19784_19818(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    symbol)
                    {
                        var return_v = this_param.Visit(symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 19784, 19818);
                        return return_v;
                    }


                    int
                    f_10940_19837_19875(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 19837, 19875);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10940_19904_19923(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 19904, 19923);
                        return return_v;
                    }


                    bool
                    f_10940_20030_20058(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    this_param)
                    {
                        var return_v = this_param.IsGlobalNamespace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 20030, 20058);
                        return return_v;
                    }


                    int
                    f_10940_20017_20059(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 20017, 20059);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    f_10940_20093_20139(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.GlobalNamespace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 20093, 20139);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    f_10940_20223_20289(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    otherTypeOrNamespace, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    sourceMember, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol, bool>
                    predicate)
                    {
                        var return_v = this_param.FindMatchingMember<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>((Microsoft.CodeAnalysis.Symbols.ISymbolInternal)otherTypeOrNamespace, sourceMember, predicate);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 20223, 20289);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10940_20389_20408(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 20389, 20408);
                        return return_v;
                    }


                    System.Exception
                    f_10940_20354_20409(Microsoft.CodeAnalysis.SymbolKind
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 20354, 20409);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 19665, 20444);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 19665, 20444);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Symbol VisitDynamicType(DynamicTypeSymbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 20460, 20637);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 20558, 20622);

                    return f_10940_20565_20621(_otherAssembly, SpecialType.System_Object);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 20460, 20637);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10940_20565_20621(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param, Microsoft.CodeAnalysis.SpecialType
                    type)
                    {
                        var return_v = this_param.GetSpecialType(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 20565, 20621);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 20460, 20637);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 20460, 20637);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Symbol VisitNamedType(NamedTypeSymbol sourceType)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 20653, 24150);
                    Microsoft.CodeAnalysis.Emit.AnonymousTypeValue value = default(Microsoft.CodeAnalysis.Emit.AnonymousTypeValue);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 20751, 20799);

                    var
                    originalDef = f_10940_20769_20798(sourceType)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 20817, 22581) || true) && ((object)originalDef != (object)sourceType)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 20817, 22581);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 20904, 20954);

                        HashSet<DiagnosticInfo>
                        useSiteDiagnostics = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 20976, 21051);

                        var
                        typeArguments = f_10940_20996_21050(sourceType, ref useSiteDiagnostics)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 21075, 21126);

                        var
                        otherDef = (NamedTypeSymbol)f_10940_21107_21125(this, originalDef)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 21148, 21253) || true) && (otherDef is null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 21148, 21253);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 21218, 21230);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 21148, 21253);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 21277, 21335);

                        var
                        otherTypeParameters = f_10940_21303_21334(otherDef)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 21357, 21388);

                        bool
                        translationFailed = false
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 21412, 22033);

                        var
                        otherTypeArguments = typeArguments.SelectAsArray((t, v) =>
                                            {
                                                var newType = (TypeSymbol)v.Visit(t.Type);

                                                if (newType is null)
                                                {
                            // For a newly added type, there is no match in the previous generation, so it could be null.
                            translationFailed = true;
                                                    newType = t.Type;
                                                }

                                                return t.WithTypeAndModifiers(newType, v.VisitCustomModifiers(t.CustomModifiers));
                                            }, this)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 22057, 22282) || true) && (translationFailed)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 22057, 22282);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 22247, 22259);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 22057, 22282);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 22410, 22495);

                        var
                        typeMap = f_10940_22424_22494(otherTypeParameters, otherTypeArguments, allowAlpha: true)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 22517, 22562);

                        return f_10940_22524_22561(typeMap, otherDef);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 20817, 22581);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 22601, 22639);

                    f_10940_22601_22638(f_10940_22614_22637(sourceType));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 22659, 22720);

                    var
                    otherContainer = f_10940_22680_22719(this, f_10940_22691_22718(sourceType))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 22884, 22983) || true) && (otherContainer is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 22884, 22983);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 22952, 22964);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 22884, 22983);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 23003, 24135);

                    switch (f_10940_23011_23030(otherContainer))
                    {

                        case SymbolKind.Namespace:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 23003, 24135);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 23124, 23525) || true) && (sourceType is AnonymousTypeManager.AnonymousTypeTemplateSymbol template)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 23124, 23525);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 23257, 23336);

                                f_10940_23257_23335((object)otherContainer == (object)f_10940_23304_23334(_otherAssembly));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 23366, 23412);

                                f_10940_23366_23411(this, template, out value);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 23442, 23498);

                                return (NamedTypeSymbol)f_10940_23466_23497_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(value.Type, 10940, 23466, 23497).GetInternalSymbol());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 23124, 23525);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 23553, 23744) || true) && (f_10940_23557_23583(sourceType))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 23553, 23744);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 23641, 23717);

                                return f_10940_23648_23716(this, f_10940_23654_23715(sourceType));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 23553, 23744);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 23772, 23846);

                            return f_10940_23779_23845(this, otherContainer, sourceType, AreNamedTypesEqual);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 23003, 24135);

                        case SymbolKind.NamedType:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 23003, 24135);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 23922, 23996);

                            return f_10940_23929_23995(this, otherContainer, sourceType, AreNamedTypesEqual);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 23003, 24135);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 23003, 24135);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 24054, 24116);

                            throw f_10940_24060_24115(f_10940_24095_24114(otherContainer));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 23003, 24135);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 20653, 24150);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10940_20769_20798(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 20769, 20798);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10940_20996_21050(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                    useSiteDiagnostics)
                    {
                        var return_v = this_param.GetAllTypeArguments(ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 20996, 21050);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10940_21107_21125(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    symbol)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 21107, 21125);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10940_21303_21334(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type)
                    {
                        var return_v = type.GetAllTypeParameters();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 21303, 21334);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                    f_10940_22424_22494(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    from, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    to, bool
                    allowAlpha)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap(from, to, allowAlpha: allowAlpha);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 22424, 22494);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10940_22524_22561(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    previous)
                    {
                        var return_v = this_param.SubstituteNamedType(previous);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 22524, 22561);
                        return return_v;
                    }


                    bool
                    f_10940_22614_22637(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 22614, 22637);
                        return return_v;
                    }


                    int
                    f_10940_22601_22638(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 22601, 22638);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10940_22691_22718(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 22691, 22718);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10940_22680_22719(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    symbol)
                    {
                        var return_v = this_param.Visit(symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 22680, 22719);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10940_23011_23030(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 23011, 23030);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    f_10940_23304_23334(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.GlobalNamespace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 23304, 23334);
                        return return_v;
                    }


                    int
                    f_10940_23257_23335(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 23257, 23335);
                        return 0;
                    }


                    bool
                    f_10940_23366_23411(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol
                    type, out Microsoft.CodeAnalysis.Emit.AnonymousTypeValue
                    otherType)
                    {
                        var return_v = this_param.TryFindAnonymousType(type, out otherType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 23366, 23411);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                    f_10940_23466_23497_I(Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 23466, 23497);
                        return return_v;
                    }


                    bool
                    f_10940_23557_23583(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsAnonymousType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 23557, 23583);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10940_23654_23715(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type)
                    {
                        var return_v = AnonymousTypeManager.TranslateAnonymousTypeSymbol(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 23654, 23715);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10940_23648_23716(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    symbol)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 23648, 23716);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10940_23779_23845(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    otherTypeOrNamespace, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    sourceMember, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, bool>
                    predicate)
                    {
                        var return_v = this_param.FindMatchingMember<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>((Microsoft.CodeAnalysis.Symbols.ISymbolInternal)otherTypeOrNamespace, sourceMember, predicate);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 23779, 23845);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10940_23929_23995(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    otherTypeOrNamespace, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    sourceMember, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, bool>
                    predicate)
                    {
                        var return_v = this_param.FindMatchingMember<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>((Microsoft.CodeAnalysis.Symbols.ISymbolInternal)otherTypeOrNamespace, sourceMember, predicate);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 23929, 23995);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10940_24095_24114(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 24095, 24114);
                        return return_v;
                    }


                    System.Exception
                    f_10940_24060_24115(Microsoft.CodeAnalysis.SymbolKind
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 24060, 24115);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 20653, 24150);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 20653, 24150);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Symbol VisitParameter(ParameterSymbol parameter)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 24166, 24417);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 24365, 24402);

                    throw f_10940_24371_24401();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 24166, 24417);

                    System.Exception
                    f_10940_24371_24401()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 24371, 24401);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 24166, 24417);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 24166, 24417);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Symbol VisitPointerType(PointerTypeSymbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 24433, 25101);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 24531, 24596);

                    var
                    otherPointedAtType = (TypeSymbol)f_10940_24568_24595(this, f_10940_24574_24594(symbol))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 24614, 24832) || true) && (otherPointedAtType is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 24614, 24832);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 24801, 24813);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 24614, 24832);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 24850, 24945);

                    var
                    otherModifiers = f_10940_24871_24944(this, symbol.PointedAtTypeWithAnnotations.CustomModifiers)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 24963, 25086);

                    return f_10940_24970_25085(symbol.PointedAtTypeWithAnnotations.WithTypeAndModifiers(otherPointedAtType, otherModifiers));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 24433, 25101);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10940_24574_24594(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.PointedAtType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 24574, 24594);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10940_24568_24595(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    symbol)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 24568, 24595);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10940_24871_24944(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    modifiers)
                    {
                        var return_v = this_param.VisitCustomModifiers(modifiers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 24871, 24944);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                    f_10940_24970_25085(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    pointedAtType)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol(pointedAtType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 24970, 25085);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 24433, 25101);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 24433, 25101);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Symbol VisitFunctionPointerType(FunctionPointerTypeSymbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 25117, 27385);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 25231, 25258);

                    var
                    sig = f_10940_25241_25257(symbol)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 25278, 25334);

                    var
                    otherReturnType = (TypeSymbol)f_10940_25312_25333(this, f_10940_25318_25332(sig))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 25352, 25452) || true) && (otherReturnType is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 25352, 25452);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 25421, 25433);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 25352, 25452);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 25472, 25547);

                    var
                    otherRefCustomModifiers = f_10940_25502_25546(this, f_10940_25523_25545(sig))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 25565, 25739);

                    var
                    otherReturnTypeWithAnnotations = sig.ReturnTypeWithAnnotations.WithTypeAndModifiers(otherReturnType, f_10940_25670_25737(this, sig.ReturnTypeWithAnnotations.CustomModifiers))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 25759, 25827);

                    var
                    otherParameterTypes = ImmutableArray<TypeWithAnnotations>.Empty
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 25845, 25931);

                    ImmutableArray<ImmutableArray<CustomModifier>>
                    otherParamRefCustomModifiers = default
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 25951, 27207) || true) && (f_10940_25955_25973(sig) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 25951, 27207);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 26019, 26110);

                        var
                        otherParamsBuilder = f_10940_26044_26109(f_10940_26090_26108(sig))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 26132, 26251);

                        var
                        otherParamRefCustomModifiersBuilder = f_10940_26174_26250(f_10940_26231_26249(sig))
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 26275, 26992);
                            foreach (var param in f_10940_26297_26311_I(f_10940_26297_26311(sig)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 26275, 26992);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 26361, 26407);

                                var
                                otherType = (TypeSymbol)f_10940_26389_26406(this, f_10940_26395_26405(param))
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 26433, 26680) || true) && (otherType is null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 26433, 26680);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 26512, 26538);

                                    f_10940_26512_26537(otherParamsBuilder);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 26568, 26611);

                                    f_10940_26568_26610(otherParamRefCustomModifiersBuilder);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 26641, 26653);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 26433, 26680);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 26708, 26796);

                                f_10940_26708_26795(
                                                        otherParamRefCustomModifiersBuilder, f_10940_26748_26794(this, f_10940_26769_26793(param)));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 26822, 26969);

                                f_10940_26822_26968(otherParamsBuilder, param.TypeWithAnnotations.WithTypeAndModifiers(otherType, f_10940_26903_26966(this, param.TypeWithAnnotations.CustomModifiers)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 26275, 26992);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10940, 1, 718);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10940, 1, 718);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 27016, 27078);

                        otherParameterTypes = f_10940_27038_27077(otherParamsBuilder);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 27100, 27188);

                        otherParamRefCustomModifiers = f_10940_27131_27187(otherParamRefCustomModifiersBuilder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 25951, 27207);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 27227, 27370);

                    return f_10940_27234_27369(symbol, otherReturnTypeWithAnnotations, otherParameterTypes, otherRefCustomModifiers, otherParamRefCustomModifiers);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 25117, 27385);

                    Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                    f_10940_25241_25257(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Signature;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 25241, 25257);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10940_25318_25332(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 25318, 25332);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10940_25312_25333(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    symbol)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 25312, 25333);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10940_25523_25545(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RefCustomModifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 25523, 25545);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10940_25502_25546(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    modifiers)
                    {
                        var return_v = this_param.VisitCustomModifiers(modifiers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 25502, 25546);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10940_25670_25737(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    modifiers)
                    {
                        var return_v = this_param.VisitCustomModifiers(modifiers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 25670, 25737);
                        return return_v;
                    }


                    int
                    f_10940_25955_25973(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ParameterCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 25955, 25973);
                        return return_v;
                    }


                    int
                    f_10940_26090_26108(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ParameterCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 26090, 26108);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10940_26044_26109(int
                    capacity)
                    {
                        var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance(capacity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 26044, 26109);
                        return return_v;
                    }


                    int
                    f_10940_26231_26249(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ParameterCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 26231, 26249);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>>
                    f_10940_26174_26250(int
                    capacity)
                    {
                        var return_v = ArrayBuilder<ImmutableArray<CustomModifier>>.GetInstance(capacity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 26174, 26250);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10940_26297_26311(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 26297, 26311);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10940_26395_26405(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 26395, 26405);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10940_26389_26406(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    symbol)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 26389, 26406);
                        return return_v;
                    }


                    int
                    f_10940_26512_26537(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 26512, 26537);
                        return 0;
                    }


                    int
                    f_10940_26568_26610(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>>
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 26568, 26610);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10940_26769_26793(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.RefCustomModifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 26769, 26793);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10940_26748_26794(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    modifiers)
                    {
                        var return_v = this_param.VisitCustomModifiers(modifiers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 26748, 26794);
                        return return_v;
                    }


                    int
                    f_10940_26708_26795(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>>
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 26708, 26795);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10940_26903_26966(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    modifiers)
                    {
                        var return_v = this_param.VisitCustomModifiers(modifiers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 26903, 26966);
                        return return_v;
                    }


                    int
                    f_10940_26822_26968(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 26822, 26968);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10940_26297_26311_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 26297, 26311);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10940_27038_27077(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 27038, 27077);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>>
                    f_10940_27131_27187(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 27131, 27187);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                    f_10940_27234_27369(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    substitutedReturnType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    substitutedParameterTypes, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    refCustomModifiers, System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>>
                    paramRefCustomModifiers)
                    {
                        var return_v = this_param.SubstituteTypeSymbol(substitutedReturnType, substitutedParameterTypes, refCustomModifiers, paramRefCustomModifiers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 27234, 27369);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 25117, 27385);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 25117, 27385);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Symbol VisitProperty(PropertySymbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 27401, 27569);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 27493, 27554);

                    return f_10940_27500_27553(this, symbol, ArePropertiesEqual);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 27401, 27569);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10940_27500_27553(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    member, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol, bool>
                    predicate)
                    {
                        var return_v = this_param.VisitNamedTypeMember<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>(member, predicate);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 27500, 27553);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 27401, 27569);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 27401, 27569);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Symbol VisitTypeParameter(TypeParameterSymbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 27585, 28751);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 27687, 27738);

                    var
                    indexed = symbol as IndexedTypeParameterSymbol
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 27756, 27859) || true) && ((object)indexed != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 27756, 27859);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 27825, 27840);

                        return indexed;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 27756, 27859);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 27879, 27935);

                    ImmutableArray<TypeParameterSymbol>
                    otherTypeParameters
                    = default(ImmutableArray<TypeParameterSymbol>);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 27953, 28010);

                    var
                    otherContainer = f_10940_27974_28009(this, f_10940_27985_28008(symbol))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 28028, 28073);

                    f_10940_28028_28072((object)otherContainer != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 28093, 28673);

                    switch (f_10940_28101_28120(otherContainer))
                    {

                        case SymbolKind.NamedType:
                        case SymbolKind.ErrorType:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 28093, 28673);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 28262, 28333);

                            otherTypeParameters = f_10940_28284_28332(((NamedTypeSymbol)otherContainer));
                            DynAbs.Tracing.TraceSender.TraceBreak(10940, 28359, 28365);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 28093, 28673);

                        case SymbolKind.Method:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 28093, 28673);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 28436, 28504);

                            otherTypeParameters = f_10940_28458_28503(((MethodSymbol)otherContainer));
                            DynAbs.Tracing.TraceSender.TraceBreak(10940, 28530, 28536);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 28093, 28673);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 28093, 28673);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 28592, 28654);

                            throw f_10940_28598_28653(f_10940_28633_28652(otherContainer));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 28093, 28673);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 28693, 28736);

                    return otherTypeParameters[f_10940_28720_28734(symbol)];
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 27585, 28751);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10940_27985_28008(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 27985, 28008);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10940_27974_28009(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    symbol)
                    {
                        var return_v = this_param.Visit(symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 27974, 28009);
                        return return_v;
                    }


                    int
                    f_10940_28028_28072(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 28028, 28072);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10940_28101_28120(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 28101, 28120);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10940_28284_28332(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 28284, 28332);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10940_28458_28503(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 28458, 28503);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10940_28633_28652(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 28633, 28652);
                        return return_v;
                    }


                    System.Exception
                    f_10940_28598_28653(Microsoft.CodeAnalysis.SymbolKind
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 28598, 28653);
                        return return_v;
                    }


                    int
                    f_10940_28720_28734(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Ordinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 28720, 28734);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 27585, 28751);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 27585, 28751);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private ImmutableArray<CustomModifier> VisitCustomModifiers(ImmutableArray<CustomModifier> modifiers)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 28767, 28968);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 28901, 28953);

                    return modifiers.SelectAsArray(VisitCustomModifier);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 28767, 28968);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 28767, 28968);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 28767, 28968);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private CustomModifier VisitCustomModifier(CustomModifier modifier)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 28984, 29415);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 29084, 29172);

                    var
                    type = (NamedTypeSymbol)f_10940_29112_29171(this, f_10940_29123_29170(((CSharpCustomModifier)modifier)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 29190, 29225);

                    f_10940_29190_29224((object)type != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 29243, 29400);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10940, 29250, 29269) || ((f_10940_29250_29269(modifier) && DynAbs.Tracing.TraceSender.Conditional_F2(10940, 29293, 29334)) || DynAbs.Tracing.TraceSender.Conditional_F3(10940, 29358, 29399))) ? f_10940_29293_29334(type) : f_10940_29358_29399(type);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 28984, 29415);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10940_29123_29170(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpCustomModifier
                    this_param)
                    {
                        var return_v = this_param.ModifierSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 29123, 29170);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10940_29112_29171(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    symbol)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 29112, 29171);
                        return return_v;
                    }


                    int
                    f_10940_29190_29224(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 29190, 29224);
                        return 0;
                    }


                    bool
                    f_10940_29250_29269(Microsoft.CodeAnalysis.CustomModifier
                    this_param)
                    {
                        var return_v = this_param.IsOptional;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 29250, 29269);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CustomModifier
                    f_10940_29293_29334(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    modifier)
                    {
                        var return_v = CSharpCustomModifier.CreateOptional(modifier);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 29293, 29334);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CustomModifier
                    f_10940_29358_29399(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    modifier)
                    {
                        var return_v = CSharpCustomModifier.CreateRequired(modifier);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 29358, 29399);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 28984, 29415);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 28984, 29415);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal bool TryFindAnonymousType(AnonymousTypeManager.AnonymousTypeTemplateSymbol type, out AnonymousTypeValue otherType)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 29431, 29789);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 29587, 29674);

                    f_10940_29587_29673((object)f_10940_29608_29629(type) == (object)f_10940_29641_29672(_sourceAssembly));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 29694, 29774);

                    return f_10940_29701_29773(_anonymousTypeMap, f_10940_29731_29757(type), out otherType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 29431, 29789);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10940_29608_29629(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 29608, 29629);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    f_10940_29641_29672(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.GlobalNamespace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 29641, 29672);
                        return return_v;
                    }


                    int
                    f_10940_29587_29673(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 29587, 29673);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.Emit.AnonymousTypeKey
                    f_10940_29731_29757(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol
                    this_param)
                    {
                        var return_v = this_param.GetAnonymousTypeKey();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 29731, 29757);
                        return return_v;
                    }


                    bool
                    f_10940_29701_29773(System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue>
                    this_param, Microsoft.CodeAnalysis.Emit.AnonymousTypeKey
                    key, out Microsoft.CodeAnalysis.Emit.AnonymousTypeValue
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 29701, 29773);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 29431, 29789);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 29431, 29789);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private Symbol VisitNamedTypeMember<T>(T member, Func<T, T, bool> predicate)
                            where T : Symbol
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 29805, 30324);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 29948, 30010);

                    var
                    otherType = (NamedTypeSymbol)f_10940_29981_30009<T>(this, f_10940_29987_30008<T>(member))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 30139, 30233) || true) && (otherType is null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 30139, 30233);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 30202, 30214);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 30139, 30233);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 30253, 30309);

                    return f_10940_30260_30308<T>(this, otherType, member, predicate);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 29805, 30324);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10940_29987_30008<T>(T
                    this_param) where T : Symbol

                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 29987, 30008);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10940_29981_30009<T>(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    symbol) where T : Symbol

                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 29981, 30009);
                        return return_v;
                    }


                    T
                    f_10940_30260_30308<T>(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    otherTypeOrNamespace, T
                    sourceMember, System.Func<T, T, bool>
                    predicate) where T : Symbol

                    {
                        var return_v = this_param.FindMatchingMember<T>((Microsoft.CodeAnalysis.Symbols.ISymbolInternal)otherTypeOrNamespace, sourceMember, predicate);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 30260, 30308);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 29805, 30324);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 29805, 30324);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private T FindMatchingMember<T>(ISymbolInternal otherTypeOrNamespace, T sourceMember, Func<T, T, bool> predicate)
                            where T : Symbol
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 30340, 31175);
                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal> otherMembers = default(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 30520, 30583);

                    f_10940_30520_30582<T>(!f_10940_30534_30581<T>(f_10940_30555_30580<T>(sourceMember)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 30603, 30695);

                    var
                    otherMembersByName = f_10940_30628_30694<T>(_otherMembers, otherTypeOrNamespace, GetAllEmittedMembers)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 30713, 31128) || true) && (f_10940_30717_30796<T>(otherMembersByName, f_10940_30748_30773<T>(sourceMember), out otherMembers))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 30713, 31128);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 30838, 31109);
                            foreach (var otherMember in f_10940_30866_30878_I(otherMembers))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 30838, 31109);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 30928, 31086) || true) && (otherMember is T other && (DynAbs.Tracing.TraceSender.Expression_True(10940, 30932, 30988) && f_10940_30958_30988<T>(predicate, sourceMember, other)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 30928, 31086);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 31046, 31059);

                                    return other;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 30928, 31086);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 30838, 31109);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10940, 1, 272);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10940, 1, 272);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 30713, 31128);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 31148, 31160);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 30340, 31175);

                    string
                    f_10940_30555_30580<T>(T
                    this_param) where T : Symbol

                    {
                        var return_v = this_param.MetadataName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 30555, 30580);
                        return return_v;
                    }


                    bool
                    f_10940_30534_30581<T>(string
                    value) where T : Symbol

                    {
                        var return_v = string.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 30534, 30581);
                        return return_v;
                    }


                    int
                    f_10940_30520_30582<T>(bool
                    condition) where T : Symbol

                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 30520, 30582);
                        return 0;
                    }


                    System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>
                    f_10940_30628_30694<T>(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>>
                    this_param, Microsoft.CodeAnalysis.Symbols.ISymbolInternal
                    key, System.Func<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>>
                    valueFactory) where T : Symbol

                    {
                        var return_v = this_param.GetOrAdd(key, valueFactory);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 30628, 30694);
                        return return_v;
                    }


                    string
                    f_10940_30748_30773<T>(T
                    this_param) where T : Symbol

                    {
                        var return_v = this_param.MetadataName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 30748, 30773);
                        return return_v;
                    }


                    bool
                    f_10940_30717_30796<T>(System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>
                    this_param, string
                    key, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>
                    value) where T : Symbol

                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 30717, 30796);
                        return return_v;
                    }


                    bool
                    f_10940_30958_30988<T>(System.Func<T, T, bool>
                    this_param, T
                    arg1, T
                    arg2) where T : Symbol

                    {
                        var return_v = this_param.Invoke(arg1, arg2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 30958, 30988);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>
                    f_10940_30866_30878_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 30866, 30878);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 30340, 31175);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 30340, 31175);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool AreArrayTypesEqual(ArrayTypeSymbol type, ArrayTypeSymbol other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 31191, 31692);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 31389, 31459);

                    f_10940_31389_31458(type.ElementTypeWithAnnotations.CustomModifiers.IsEmpty);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 31477, 31548);

                    f_10940_31477_31547(other.ElementTypeWithAnnotations.CustomModifiers.IsEmpty);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 31568, 31677);

                    return f_10940_31575_31601(type, other) && (DynAbs.Tracing.TraceSender.Expression_True(10940, 31575, 31676) && f_10940_31626_31676(this, f_10940_31640_31656(type), f_10940_31658_31675(other)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 31191, 31692);

                    int
                    f_10940_31389_31458(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 31389, 31458);
                        return 0;
                    }


                    int
                    f_10940_31477_31547(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 31477, 31547);
                        return 0;
                    }


                    bool
                    f_10940_31575_31601(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                    other)
                    {
                        var return_v = this_param.HasSameShapeAs(other);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 31575, 31601);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10940_31640_31656(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ElementType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 31640, 31656);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10940_31658_31675(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ElementType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 31658, 31675);
                        return return_v;
                    }


                    bool
                    f_10940_31626_31676(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    other)
                    {
                        var return_v = this_param.AreTypesEqual(type, other);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 31626, 31676);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 31191, 31692);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 31191, 31692);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool AreEventsEqual(EventSymbol @event, EventSymbol other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 31708, 31957);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 31807, 31875);

                    f_10940_31807_31874(f_10940_31820_31873(f_10940_31849_31860(@event), f_10940_31862_31872(other)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 31893, 31942);

                    return f_10940_31900_31941(_comparer, f_10940_31917_31928(@event), f_10940_31930_31940(other));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 31708, 31957);

                    string
                    f_10940_31849_31860(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 31849, 31860);
                        return return_v;
                    }


                    string
                    f_10940_31862_31872(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 31862, 31872);
                        return return_v;
                    }


                    bool
                    f_10940_31820_31873(string
                    a, string
                    b)
                    {
                        var return_v = StringOrdinalComparer.Equals(a, b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 31820, 31873);
                        return return_v;
                    }


                    int
                    f_10940_31807_31874(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 31807, 31874);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10940_31917_31928(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 31917, 31928);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10940_31930_31940(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 31930, 31940);
                        return return_v;
                    }


                    bool
                    f_10940_31900_31941(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols.SymbolComparer
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    other)
                    {
                        var return_v = this_param.Equals(source, other);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 31900, 31941);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 31708, 31957);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 31708, 31957);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool AreFieldsEqual(FieldSymbol field, FieldSymbol other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 31973, 32219);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 32071, 32138);

                    f_10940_32071_32137(f_10940_32084_32136(f_10940_32113_32123(field), f_10940_32125_32135(other)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 32156, 32204);

                    return f_10940_32163_32203(_comparer, f_10940_32180_32190(field), f_10940_32192_32202(other));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 31973, 32219);

                    string
                    f_10940_32113_32123(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 32113, 32123);
                        return return_v;
                    }


                    string
                    f_10940_32125_32135(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 32125, 32135);
                        return return_v;
                    }


                    bool
                    f_10940_32084_32136(string
                    a, string
                    b)
                    {
                        var return_v = StringOrdinalComparer.Equals(a, b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 32084, 32136);
                        return return_v;
                    }


                    int
                    f_10940_32071_32137(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 32071, 32137);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10940_32180_32190(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 32180, 32190);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10940_32192_32202(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 32192, 32202);
                        return return_v;
                    }


                    bool
                    f_10940_32163_32203(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols.SymbolComparer
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    other)
                    {
                        var return_v = this_param.Equals(source, other);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 32163, 32203);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 31973, 32219);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 31973, 32219);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool AreMethodsEqual(MethodSymbol method, MethodSymbol other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 32235, 32978);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 32337, 32405);

                    f_10940_32337_32404(f_10940_32350_32403(f_10940_32379_32390(method), f_10940_32392_32402(other)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 32425, 32459);

                    f_10940_32425_32458(f_10940_32438_32457(method));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 32477, 32510);

                    f_10940_32477_32509(f_10940_32490_32508(other));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 32530, 32572);

                    method = f_10940_32539_32571(method);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 32590, 32630);

                    other = f_10940_32598_32629(other);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 32650, 32963);

                    return f_10940_32657_32710(_comparer, f_10940_32674_32691(method), f_10940_32693_32709(other)) && (DynAbs.Tracing.TraceSender.Expression_True(10940, 32657, 32771) && f_10940_32735_32771(f_10940_32735_32749(method), f_10940_32757_32770(other))) && (DynAbs.Tracing.TraceSender.Expression_True(10940, 32657, 32865) && method.Parameters.SequenceEqual(f_10940_32828_32844(other), AreParametersEqual)) && (DynAbs.Tracing.TraceSender.Expression_True(10940, 32657, 32962) && method.TypeParameters.SequenceEqual(f_10940_32926_32946(other), AreTypesEqual));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 32235, 32978);

                    string
                    f_10940_32379_32390(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 32379, 32390);
                        return return_v;
                    }


                    string
                    f_10940_32392_32402(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 32392, 32402);
                        return return_v;
                    }


                    bool
                    f_10940_32350_32403(string
                    a, string
                    b)
                    {
                        var return_v = StringOrdinalComparer.Equals(a, b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 32350, 32403);
                        return return_v;
                    }


                    int
                    f_10940_32337_32404(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 32337, 32404);
                        return 0;
                    }


                    bool
                    f_10940_32438_32457(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 32438, 32457);
                        return return_v;
                    }


                    int
                    f_10940_32425_32458(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 32425, 32458);
                        return 0;
                    }


                    bool
                    f_10940_32490_32508(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 32490, 32508);
                        return return_v;
                    }


                    int
                    f_10940_32477_32509(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 32477, 32509);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10940_32539_32571(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    method)
                    {
                        var return_v = SubstituteTypeParameters(method);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 32539, 32571);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10940_32598_32629(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    method)
                    {
                        var return_v = SubstituteTypeParameters(method);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 32598, 32629);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10940_32674_32691(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 32674, 32691);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10940_32693_32709(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 32693, 32709);
                        return return_v;
                    }


                    bool
                    f_10940_32657_32710(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols.SymbolComparer
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    other)
                    {
                        var return_v = this_param.Equals(source, other);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 32657, 32710);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.RefKind
                    f_10940_32735_32749(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 32735, 32749);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.RefKind
                    f_10940_32757_32770(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 32757, 32770);
                        return return_v;
                    }


                    bool
                    f_10940_32735_32771(Microsoft.CodeAnalysis.RefKind
                    this_param, Microsoft.CodeAnalysis.RefKind
                    obj)
                    {
                        var return_v = this_param.Equals((object)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 32735, 32771);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10940_32828_32844(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 32828, 32844);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10940_32926_32946(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 32926, 32946);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 32235, 32978);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 32235, 32978);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static MethodSymbol SubstituteTypeParameters(MethodSymbol method)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10940, 32994, 33443);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 33100, 33134);

                    f_10940_33100_33133(f_10940_33113_33132(method));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 33154, 33197);

                    var
                    typeParameters = f_10940_33175_33196(method)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 33215, 33245);

                    int
                    n = typeParameters.Length
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 33263, 33348) || true) && (n == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 33263, 33348);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 33315, 33329);

                        return method;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 33263, 33348);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 33368, 33428);

                    return f_10940_33375_33427(method, f_10940_33392_33426(n));
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10940, 32994, 33443);

                    bool
                    f_10940_33113_33132(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 33113, 33132);
                        return return_v;
                    }


                    int
                    f_10940_33100_33133(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 33100, 33133);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10940_33175_33196(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 33175, 33196);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10940_33392_33426(int
                    count)
                    {
                        var return_v = IndexedTypeParameterSymbol.Take(count);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 33392, 33426);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10940_33375_33427(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    typeArguments)
                    {
                        var return_v = this_param.Construct(typeArguments);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 33375, 33427);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 32994, 33443);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 32994, 33443);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool AreNamedTypesEqual(NamedTypeSymbol type, NamedTypeSymbol other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 33459, 34167);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 33568, 33650);

                    f_10940_33568_33649(f_10940_33581_33648(f_10940_33610_33627(type), f_10940_33629_33647(other)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 33759, 33863);

                    f_10940_33759_33862(type.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics.All(t => t.CustomModifiers.IsEmpty));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 33881, 33986);

                    f_10940_33881_33985(other.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics.All(t => t.CustomModifiers.IsEmpty));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 34006, 34152);

                    return type.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics.SequenceEqual(f_10940_34081_34135(other), AreTypesEqual);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 33459, 34167);

                    string
                    f_10940_33610_33627(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.MetadataName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 33610, 33627);
                        return return_v;
                    }


                    string
                    f_10940_33629_33647(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.MetadataName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 33629, 33647);
                        return return_v;
                    }


                    bool
                    f_10940_33581_33648(string
                    a, string
                    b)
                    {
                        var return_v = StringOrdinalComparer.Equals(a, b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 33581, 33648);
                        return return_v;
                    }


                    int
                    f_10940_33568_33649(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 33568, 33649);
                        return 0;
                    }


                    int
                    f_10940_33759_33862(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 33759, 33862);
                        return 0;
                    }


                    int
                    f_10940_33881_33985(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 33881, 33985);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10940_34081_34135(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 34081, 34135);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 33459, 34167);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 33459, 34167);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool AreNamespacesEqual(NamespaceSymbol @namespace, NamespaceSymbol other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 34183, 34431);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 34298, 34386);

                    f_10940_34298_34385(f_10940_34311_34384(f_10940_34340_34363(@namespace), f_10940_34365_34383(other)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 34404, 34416);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 34183, 34431);

                    string
                    f_10940_34340_34363(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    this_param)
                    {
                        var return_v = this_param.MetadataName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 34340, 34363);
                        return return_v;
                    }


                    string
                    f_10940_34365_34383(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    this_param)
                    {
                        var return_v = this_param.MetadataName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 34365, 34383);
                        return return_v;
                    }


                    bool
                    f_10940_34311_34384(string
                    a, string
                    b)
                    {
                        var return_v = StringOrdinalComparer.Equals(a, b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 34311, 34384);
                        return return_v;
                    }


                    int
                    f_10940_34298_34385(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 34298, 34385);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 34183, 34431);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 34183, 34431);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool AreParametersEqual(ParameterSymbol parameter, ParameterSymbol other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 34447, 34853);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 34561, 34610);

                    f_10940_34561_34609(f_10940_34574_34591(parameter) == f_10940_34595_34608(other));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 34628, 34838);

                    return f_10940_34635_34707(f_10940_34664_34686(parameter), f_10940_34688_34706(other)) && (DynAbs.Tracing.TraceSender.Expression_True(10940, 34635, 34768) && (f_10940_34733_34750(parameter) == f_10940_34754_34767(other))) && (DynAbs.Tracing.TraceSender.Expression_True(10940, 34635, 34837) && f_10940_34793_34837(_comparer, f_10940_34810_34824(parameter), f_10940_34826_34836(other)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 34447, 34853);

                    int
                    f_10940_34574_34591(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Ordinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 34574, 34591);
                        return return_v;
                    }


                    int
                    f_10940_34595_34608(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Ordinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 34595, 34608);
                        return return_v;
                    }


                    int
                    f_10940_34561_34609(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 34561, 34609);
                        return 0;
                    }


                    string
                    f_10940_34664_34686(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.MetadataName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 34664, 34686);
                        return return_v;
                    }


                    string
                    f_10940_34688_34706(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.MetadataName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 34688, 34706);
                        return return_v;
                    }


                    bool
                    f_10940_34635_34707(string
                    a, string
                    b)
                    {
                        var return_v = StringOrdinalComparer.Equals(a, b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 34635, 34707);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.RefKind
                    f_10940_34733_34750(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 34733, 34750);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.RefKind
                    f_10940_34754_34767(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 34754, 34767);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10940_34810_34824(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 34810, 34824);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10940_34826_34836(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 34826, 34836);
                        return return_v;
                    }


                    bool
                    f_10940_34793_34837(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols.SymbolComparer
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    other)
                    {
                        var return_v = this_param.Equals(source, other);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 34793, 34837);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 34447, 34853);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 34447, 34853);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool ArePointerTypesEqual(PointerTypeSymbol type, PointerTypeSymbol other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 34869, 35333);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 35073, 35145);

                    f_10940_35073_35144(type.PointedAtTypeWithAnnotations.CustomModifiers.IsEmpty);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 35163, 35236);

                    f_10940_35163_35235(other.PointedAtTypeWithAnnotations.CustomModifiers.IsEmpty);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 35256, 35318);

                    return f_10940_35263_35317(this, f_10940_35277_35295(type), f_10940_35297_35316(other));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 34869, 35333);

                    int
                    f_10940_35073_35144(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 35073, 35144);
                        return 0;
                    }


                    int
                    f_10940_35163_35235(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 35163, 35235);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10940_35277_35295(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.PointedAtType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 35277, 35295);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10940_35297_35316(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.PointedAtType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 35297, 35316);
                        return return_v;
                    }


                    bool
                    f_10940_35263_35317(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    other)
                    {
                        var return_v = this_param.AreTypesEqual(type, other);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 35263, 35317);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 34869, 35333);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 34869, 35333);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool AreFunctionPointerTypesEqual(FunctionPointerTypeSymbol type, FunctionPointerTypeSymbol other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 35349, 36198);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 35488, 35513);

                    var
                    sig = f_10940_35498_35512(type)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 35531, 35562);

                    var
                    otherSig = f_10940_35546_35561(other)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 35582, 35704);

                    f_10940_35582_35703(f_10940_35619_35648(sig), f_10940_35650_35661(sig), f_10940_35663_35685(sig), allowOut: false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 35722, 35859);

                    f_10940_35722_35858(f_10940_35759_35793(otherSig), f_10940_35795_35811(otherSig), f_10940_35813_35840(otherSig), allowOut: false);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 35877, 36071) || true) && (f_10940_35881_35892(sig) != f_10940_35896_35912(otherSig) || (DynAbs.Tracing.TraceSender.Expression_False(10940, 35881, 35997) || !f_10940_35917_35997(this, f_10940_35931_35960(sig), f_10940_35962_35996(otherSig))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 35877, 36071);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 36039, 36052);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 35877, 36071);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 36091, 36183);

                    return sig.Parameters.SequenceEqual(f_10940_36127_36146(otherSig), AreFunctionPointerParametersEqual);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 35349, 36198);

                    Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                    f_10940_35498_35512(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Signature;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 35498, 35512);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                    f_10940_35546_35561(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Signature;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 35546, 35561);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10940_35619_35648(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnTypeWithAnnotations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 35619, 35648);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.RefKind
                    f_10940_35650_35661(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 35650, 35661);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10940_35663_35685(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RefCustomModifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 35663, 35685);
                        return return_v;
                    }


                    int
                    f_10940_35582_35703(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    type, Microsoft.CodeAnalysis.RefKind
                    refKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    refCustomModifiers, bool
                    allowOut)
                    {
                        ValidateFunctionPointerParamOrReturn(type, refKind, refCustomModifiers, allowOut: allowOut);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 35582, 35703);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10940_35759_35793(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnTypeWithAnnotations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 35759, 35793);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.RefKind
                    f_10940_35795_35811(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 35795, 35811);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10940_35813_35840(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RefCustomModifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 35813, 35840);
                        return return_v;
                    }


                    int
                    f_10940_35722_35858(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    type, Microsoft.CodeAnalysis.RefKind
                    refKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    refCustomModifiers, bool
                    allowOut)
                    {
                        ValidateFunctionPointerParamOrReturn(type, refKind, refCustomModifiers, allowOut: allowOut);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 35722, 35858);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.RefKind
                    f_10940_35881_35892(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 35881, 35892);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.RefKind
                    f_10940_35896_35912(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 35896, 35912);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10940_35931_35960(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnTypeWithAnnotations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 35931, 35960);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10940_35962_35996(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnTypeWithAnnotations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 35962, 35996);
                        return return_v;
                    }


                    bool
                    f_10940_35917_35997(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    type, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    other)
                    {
                        var return_v = this_param.AreTypesEqual(type, other);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 35917, 35997);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10940_36127_36146(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 36127, 36146);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 35349, 36198);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 35349, 36198);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool AreFunctionPointerParametersEqual(ParameterSymbol param, ParameterSymbol otherParam)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 36214, 36773);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 36344, 36465);

                    f_10940_36344_36464(f_10940_36381_36406(param), f_10940_36408_36421(param), f_10940_36423_36447(param), allowOut: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 36483, 36619);

                    f_10940_36483_36618(f_10940_36520_36550(otherParam), f_10940_36552_36570(otherParam), f_10940_36572_36601(otherParam), allowOut: true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 36639, 36758);

                    return f_10940_36646_36659(param) == f_10940_36663_36681(otherParam) && (DynAbs.Tracing.TraceSender.Expression_True(10940, 36646, 36757) && f_10940_36685_36757(this, f_10940_36699_36724(param), f_10940_36726_36756(otherParam)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 36214, 36773);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10940_36381_36406(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeWithAnnotations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 36381, 36406);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.RefKind
                    f_10940_36408_36421(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 36408, 36421);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10940_36423_36447(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.RefCustomModifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 36423, 36447);
                        return return_v;
                    }


                    int
                    f_10940_36344_36464(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    type, Microsoft.CodeAnalysis.RefKind
                    refKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    refCustomModifiers, bool
                    allowOut)
                    {
                        ValidateFunctionPointerParamOrReturn(type, refKind, refCustomModifiers, allowOut: allowOut);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 36344, 36464);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10940_36520_36550(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeWithAnnotations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 36520, 36550);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.RefKind
                    f_10940_36552_36570(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 36552, 36570);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10940_36572_36601(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.RefCustomModifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 36572, 36601);
                        return return_v;
                    }


                    int
                    f_10940_36483_36618(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    type, Microsoft.CodeAnalysis.RefKind
                    refKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    refCustomModifiers, bool
                    allowOut)
                    {
                        ValidateFunctionPointerParamOrReturn(type, refKind, refCustomModifiers, allowOut: allowOut);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 36483, 36618);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.RefKind
                    f_10940_36646_36659(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 36646, 36659);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.RefKind
                    f_10940_36663_36681(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 36663, 36681);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10940_36699_36724(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeWithAnnotations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 36699, 36724);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10940_36726_36756(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeWithAnnotations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 36726, 36756);
                        return return_v;
                    }


                    bool
                    f_10940_36685_36757(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    type, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    other)
                    {
                        var return_v = this_param.AreTypesEqual(type, other);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 36685, 36757);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 36214, 36773);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 36214, 36773);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            [Conditional("DEBUG")]
            private static void ValidateFunctionPointerParamOrReturn(TypeWithAnnotations type, RefKind refKind, ImmutableArray<CustomModifier> refCustomModifiers, bool allowOut)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10940, 36789, 37743);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 37023, 37066);

                    f_10940_37023_37065(type.CustomModifiers.IsEmpty);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 37084, 37156);

                    f_10940_37084_37155(f_10940_37097_37154(refCustomModifiers, refKind, allowOut));

                    static bool verifyRefModifiers(ImmutableArray<CustomModifier> modifiers, RefKind refKind, bool allowOut)
                    {
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10940, 37176, 37728);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 37321, 37369);

                            f_10940_37321_37368(RefKind.RefReadOnly == RefKind.In);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 37391, 37709);

                            switch (refKind)
                            {

                                case RefKind.RefReadOnly:
                                case RefKind.Out when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 37524, 37537) || true) && (allowOut) && (DynAbs.Tracing.TraceSender.Expression_True(10940, 37524, 37537) || true)
                            :
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 37391, 37709);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 37568, 37597);

                                    return modifiers.Length == 1;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 37391, 37709);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 37391, 37709);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 37661, 37686);

                                    return modifiers.IsEmpty;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 37391, 37709);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10940, 37176, 37728);

                            int
                            f_10940_37321_37368(bool
                            condition)
                            {
                                Debug.Assert(condition);
                                DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 37321, 37368);
                                return 0;
                            }

                        }
                        catch
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 37176, 37728);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 37176, 37728);
                        }
                        throw new System.Exception("Slicer error: unreachable code");
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10940, 36789, 37743);

                    int
                    f_10940_37023_37065(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 37023, 37065);
                        return 0;
                    }


                    bool
                    f_10940_37097_37154(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    modifiers, Microsoft.CodeAnalysis.RefKind
                    refKind, bool
                    allowOut)
                    {
                        var return_v = verifyRefModifiers(modifiers, refKind, allowOut);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 37097, 37154);
                        return return_v;
                    }


                    int
                    f_10940_37084_37155(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 37084, 37155);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 36789, 37743);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 36789, 37743);
                }
            }

            private bool ArePropertiesEqual(PropertySymbol property, PropertySymbol other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 37759, 38199);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 37870, 37956);

                    f_10940_37870_37955(f_10940_37883_37954(f_10940_37912_37933(property), f_10940_37935_37953(other)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 37974, 38184);

                    return f_10940_37981_38024(_comparer, f_10940_37998_38011(property), f_10940_38013_38023(other)) && (DynAbs.Tracing.TraceSender.Expression_True(10940, 37981, 38087) && f_10940_38049_38087(f_10940_38049_38065(property), f_10940_38073_38086(other))) && (DynAbs.Tracing.TraceSender.Expression_True(10940, 37981, 38183) && property.Parameters.SequenceEqual(f_10940_38146_38162(other), AreParametersEqual));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 37759, 38199);

                    string
                    f_10940_37912_37933(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.MetadataName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 37912, 37933);
                        return return_v;
                    }


                    string
                    f_10940_37935_37953(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.MetadataName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 37935, 37953);
                        return return_v;
                    }


                    bool
                    f_10940_37883_37954(string
                    a, string
                    b)
                    {
                        var return_v = StringOrdinalComparer.Equals(a, b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 37883, 37954);
                        return return_v;
                    }


                    int
                    f_10940_37870_37955(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 37870, 37955);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10940_37998_38011(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 37998, 38011);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10940_38013_38023(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 38013, 38023);
                        return return_v;
                    }


                    bool
                    f_10940_37981_38024(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols.SymbolComparer
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    other)
                    {
                        var return_v = this_param.Equals(source, other);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 37981, 38024);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.RefKind
                    f_10940_38049_38065(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 38049, 38065);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.RefKind
                    f_10940_38073_38086(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 38073, 38086);
                        return return_v;
                    }


                    bool
                    f_10940_38049_38087(Microsoft.CodeAnalysis.RefKind
                    this_param, Microsoft.CodeAnalysis.RefKind
                    obj)
                    {
                        var return_v = this_param.Equals((object)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 38049, 38087);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10940_38146_38162(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 38146, 38162);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 37759, 38199);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 37759, 38199);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static bool AreTypeParametersEqual(TypeParameterSymbol type, TypeParameterSymbol other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10940, 38215, 39299);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 38343, 38387);

                    f_10940_38343_38386(f_10940_38356_38368(type) == f_10940_38372_38385(other));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 38405, 38471);

                    f_10940_38405_38470(f_10940_38418_38469(f_10940_38447_38456(type), f_10940_38458_38468(other)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 38752, 38830);

                    f_10940_38752_38829(f_10940_38765_38794(type) == f_10940_38798_38828(other));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 38848, 38922);

                    f_10940_38848_38921(f_10940_38861_38888(type) == f_10940_38892_38920(other));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 38940, 39022);

                    f_10940_38940_39021(f_10940_38953_38984(type) == f_10940_38988_39020(other));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 39040, 39122);

                    f_10940_39040_39121(f_10940_39053_39084(type) == f_10940_39088_39120(other));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 39140, 39254);

                    f_10940_39140_39253(type.ConstraintTypesNoUseSiteDiagnostics.Length == other.ConstraintTypesNoUseSiteDiagnostics.Length);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 39272, 39284);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10940, 38215, 39299);

                    int
                    f_10940_38356_38368(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Ordinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 38356, 38368);
                        return return_v;
                    }


                    int
                    f_10940_38372_38385(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Ordinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 38372, 38385);
                        return return_v;
                    }


                    int
                    f_10940_38343_38386(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 38343, 38386);
                        return 0;
                    }


                    string
                    f_10940_38447_38456(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 38447, 38456);
                        return return_v;
                    }


                    string
                    f_10940_38458_38468(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 38458, 38468);
                        return return_v;
                    }


                    bool
                    f_10940_38418_38469(string
                    a, string
                    b)
                    {
                        var return_v = StringOrdinalComparer.Equals(a, b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 38418, 38469);
                        return return_v;
                    }


                    int
                    f_10940_38405_38470(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 38405, 38470);
                        return 0;
                    }


                    bool
                    f_10940_38765_38794(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.HasConstructorConstraint;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 38765, 38794);
                        return return_v;
                    }


                    bool
                    f_10940_38798_38828(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.HasConstructorConstraint;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 38798, 38828);
                        return return_v;
                    }


                    int
                    f_10940_38752_38829(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 38752, 38829);
                        return 0;
                    }


                    bool
                    f_10940_38861_38888(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.HasValueTypeConstraint;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 38861, 38888);
                        return return_v;
                    }


                    bool
                    f_10940_38892_38920(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.HasValueTypeConstraint;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 38892, 38920);
                        return return_v;
                    }


                    int
                    f_10940_38848_38921(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 38848, 38921);
                        return 0;
                    }


                    bool
                    f_10940_38953_38984(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.HasUnmanagedTypeConstraint;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 38953, 38984);
                        return return_v;
                    }


                    bool
                    f_10940_38988_39020(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.HasUnmanagedTypeConstraint;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 38988, 39020);
                        return return_v;
                    }


                    int
                    f_10940_38940_39021(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 38940, 39021);
                        return 0;
                    }


                    bool
                    f_10940_39053_39084(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.HasReferenceTypeConstraint;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 39053, 39084);
                        return return_v;
                    }


                    bool
                    f_10940_39088_39120(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.HasReferenceTypeConstraint;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 39088, 39120);
                        return return_v;
                    }


                    int
                    f_10940_39040_39121(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 39040, 39121);
                        return 0;
                    }


                    int
                    f_10940_39140_39253(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 39140, 39253);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 38215, 39299);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 38215, 39299);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool AreTypesEqual(TypeWithAnnotations type, TypeWithAnnotations other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 39315, 39627);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 39427, 39479);

                    f_10940_39427_39478(type.CustomModifiers.IsDefaultOrEmpty);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 39497, 39550);

                    f_10940_39497_39549(other.CustomModifiers.IsDefaultOrEmpty);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 39568, 39612);

                    return f_10940_39575_39611(this, type.Type, other.Type);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 39315, 39627);

                    int
                    f_10940_39427_39478(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 39427, 39478);
                        return 0;
                    }


                    int
                    f_10940_39497_39549(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 39497, 39549);
                        return 0;
                    }


                    bool
                    f_10940_39575_39611(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    other)
                    {
                        var return_v = this_param.AreTypesEqual(type, other);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 39575, 39611);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 39315, 39627);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 39315, 39627);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool AreTypesEqual(TypeSymbol type, TypeSymbol other)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 39643, 40894);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 39737, 39838) || true) && (f_10940_39741_39750(type) != f_10940_39754_39764(other))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 39737, 39838);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 39806, 39819);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 39737, 39838);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 39858, 40879);

                    switch (f_10940_39866_39875(type))
                    {

                        case SymbolKind.ArrayType:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 39858, 40879);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 39969, 40042);

                            return f_10940_39976_40041(this, type, other);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 39858, 40879);

                        case SymbolKind.PointerType:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 39858, 40879);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 40120, 40199);

                            return f_10940_40127_40198(this, type, other);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 39858, 40879);

                        case SymbolKind.FunctionPointerType:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 39858, 40879);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 40285, 40388);

                            return f_10940_40292_40387(this, type, other);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 39858, 40879);

                        case SymbolKind.NamedType:
                        case SymbolKind.ErrorType:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 39858, 40879);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 40512, 40585);

                            return f_10940_40519_40584(this, type, other);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 39858, 40879);

                        case SymbolKind.TypeParameter:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 39858, 40879);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 40665, 40750);

                            return f_10940_40672_40749(type, other);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 39858, 40879);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 39858, 40879);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 40808, 40860);

                            throw f_10940_40814_40859(f_10940_40849_40858(type));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 39858, 40879);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 39643, 40894);

                    Microsoft.CodeAnalysis.SymbolKind
                    f_10940_39741_39750(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 39741, 39750);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10940_39754_39764(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 39754, 39764);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10940_39866_39875(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 39866, 39875);
                        return return_v;
                    }


                    bool
                    f_10940_39976_40041(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    other)
                    {
                        var return_v = this_param.AreArrayTypesEqual((Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol)type, (Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol)other);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 39976, 40041);
                        return return_v;
                    }


                    bool
                    f_10940_40127_40198(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    other)
                    {
                        var return_v = this_param.ArePointerTypesEqual((Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol)type, (Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol)other);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 40127, 40198);
                        return return_v;
                    }


                    bool
                    f_10940_40292_40387(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    other)
                    {
                        var return_v = this_param.AreFunctionPointerTypesEqual((Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol)type, (Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol)other);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 40292, 40387);
                        return return_v;
                    }


                    bool
                    f_10940_40519_40584(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    other)
                    {
                        var return_v = this_param.AreNamedTypesEqual((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)type, (Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)other);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 40519, 40584);
                        return return_v;
                    }


                    bool
                    f_10940_40672_40749(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    other)
                    {
                        var return_v = AreTypeParametersEqual((Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol)type, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol)other);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 40672, 40749);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10940_40849_40858(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 40849, 40858);
                        return return_v;
                    }


                    System.Exception
                    f_10940_40814_40859(Microsoft.CodeAnalysis.SymbolKind
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 40814, 40859);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 39643, 40894);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 39643, 40894);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private IReadOnlyDictionary<string, ImmutableArray<ISymbolInternal>> GetAllEmittedMembers(ISymbolInternal symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 40910, 42150);
                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal> synthesizedMembers = default(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 41056, 41114);

                    var
                    members = f_10940_41070_41113()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 41134, 41727) || true) && (f_10940_41138_41149(symbol) == SymbolKind.NamedType)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 41134, 41727);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 41215, 41250);

                        var
                        type = (NamedTypeSymbol)symbol
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 41272, 41313);

                        f_10940_41272_41312(members, f_10940_41289_41311(type));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 41335, 41376);

                        f_10940_41335_41375(members, f_10940_41352_41374(type));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 41398, 41440);

                        f_10940_41398_41439(members, f_10940_41415_41438(type));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 41462, 41502);

                        f_10940_41462_41501(members, f_10940_41479_41500(type));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 41524, 41569);

                        f_10940_41524_41568(members, f_10940_41541_41567(type));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 41134, 41727);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 41134, 41727);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 41651, 41708);

                        f_10940_41651_41707(members, f_10940_41668_41706(((NamespaceSymbol)symbol)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 41134, 41727);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 41747, 41963) || true) && (_otherSynthesizedMembersOpt != null && (DynAbs.Tracing.TraceSender.Expression_True(10940, 41751, 41865) && f_10940_41790_41865(_otherSynthesizedMembersOpt, symbol, out synthesizedMembers)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 41747, 41963);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 41907, 41944);

                        f_10940_41907_41943(members, synthesizedMembers);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 41747, 41963);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 41983, 42070);

                    var
                    result = f_10940_41996_42069(members, s => s.MetadataName, StringOrdinalComparer.Instance)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 42088, 42103);

                    f_10940_42088_42102(members);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 42121, 42135);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 40910, 42150);

                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>
                    f_10940_41070_41113()
                    {
                        var return_v = ArrayBuilder<ISymbolInternal>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 41070, 41113);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10940_41138_41149(Microsoft.CodeAnalysis.Symbols.ISymbolInternal
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 41138, 41149);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                    f_10940_41289_41311(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetEventsToEmit();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 41289, 41311);
                        return return_v;
                    }


                    int
                    f_10940_41272_41312(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>
                    this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol>
                    items)
                    {
                        this_param.AddRange((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>)items);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 41272, 41312);
                        return 0;
                    }


                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                    f_10940_41352_41374(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetFieldsToEmit();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 41352, 41374);
                        return return_v;
                    }


                    int
                    f_10940_41335_41375(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>
                    this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                    items)
                    {
                        this_param.AddRange((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>)items);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 41335, 41375);
                        return 0;
                    }


                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    f_10940_41415_41438(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetMethodsToEmit();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 41415, 41438);
                        return return_v;
                    }


                    int
                    f_10940_41398_41439(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>
                    this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    items)
                    {
                        this_param.AddRange((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>)items);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 41398, 41439);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    f_10940_41479_41500(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetTypeMembers();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 41479, 41500);
                        return return_v;
                    }


                    int
                    f_10940_41462_41501(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    items)
                    {
                        this_param.AddRange<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>(items);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 41462, 41501);
                        return 0;
                    }


                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                    f_10940_41541_41567(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetPropertiesToEmit();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 41541, 41567);
                        return return_v;
                    }


                    int
                    f_10940_41524_41568(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>
                    this_param, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                    items)
                    {
                        this_param.AddRange((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>)items);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 41524, 41568);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10940_41668_41706(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    this_param)
                    {
                        var return_v = this_param.GetMembers();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 41668, 41706);
                        return return_v;
                    }


                    int
                    f_10940_41651_41707(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                    items)
                    {
                        this_param.AddRange<Microsoft.CodeAnalysis.CSharp.Symbol>(items);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 41651, 41707);
                        return 0;
                    }


                    bool
                    f_10940_41790_41865(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>
                    this_param, Microsoft.CodeAnalysis.Symbols.ISymbolInternal
                    key, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 41790, 41865);
                        return return_v;
                    }


                    int
                    f_10940_41907_41943(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>
                    items)
                    {
                        this_param.AddRange(items);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 41907, 41943);
                        return 0;
                    }


                    System.Collections.Generic.Dictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>
                    f_10940_41996_42069(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>
                    this_param, System.Func<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, string>
                    keySelector, Roslyn.Utilities.StringOrdinalComparer
                    comparer)
                    {
                        var return_v = this_param.ToDictionary<string>(keySelector, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 41996, 42069);
                        return return_v;
                    }


                    int
                    f_10940_42088_42102(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 42088, 42102);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 40910, 42150);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 40910, 42150);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            private sealed class SymbolComparer
            {
                private readonly MatchSymbols _matcher;

                private readonly DeepTranslator _deepTranslatorOpt;

                public SymbolComparer(MatchSymbols matcher, DeepTranslator deepTranslatorOpt)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(10940, 42362, 42631);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 42264, 42272);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 42323, 42341);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 42480, 42510);

                        f_10940_42480_42509(matcher != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 42532, 42551);

                        _matcher = matcher;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 42573, 42612);

                        _deepTranslatorOpt = deepTranslatorOpt;
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(10940, 42362, 42631);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 42362, 42631);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 42362, 42631);
                    }
                }

                public bool Equals(TypeSymbol source, TypeSymbol other)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 42651, 43123);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 42747, 42802);

                        var
                        visitedSource = (TypeSymbol)f_10940_42779_42801(_matcher, source)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 42824, 42926);

                        var
                        visitedOther = (DynAbs.Tracing.TraceSender.Conditional_F1(10940, 42843, 42871) || (((_deepTranslatorOpt != null) && DynAbs.Tracing.TraceSender.Conditional_F2(10940, 42874, 42917)) || DynAbs.Tracing.TraceSender.Conditional_F3(10940, 42920, 42925))) ? (TypeSymbol)f_10940_42886_42917(_deepTranslatorOpt, other) : other
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 42950, 43104);

                        return f_10940_42957_43095_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(visitedSource, 10940, 42957, 43095)?.Equals(visitedOther, TypeCompareKind.IgnoreDynamicAndTupleNames | TypeCompareKind.IgnoreNullableModifiersForReferenceTypes)) == true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 42651, 43123);

                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10940_42779_42801(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        symbol)
                        {
                            var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 42779, 42801);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10940_42886_42917(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.DeepTranslator
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        symbol)
                        {
                            var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 42886, 42917);
                            return return_v;
                        }


                        bool?
                        f_10940_42957_43095_I(bool?
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 42957, 43095);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 42651, 43123);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 42651, 43123);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                static SymbolComparer()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10940, 42166, 43138);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10940, 42166, 43138);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 42166, 43138);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10940, 42166, 43138);

                int
                f_10940_42480_42509(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 42480, 42509);
                    return 0;
                }

            }

            static MatchSymbols()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10940, 11513, 43149);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10940, 11513, 43149);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 11513, 43149);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10940, 11513, 43149);

            Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols.SymbolComparer
            f_10940_13613_13656(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
            matcher, Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.DeepTranslator
            deepTranslatorOpt)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols.SymbolComparer(matcher, deepTranslatorOpt);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 13613, 13656);
                return return_v;
            }


            System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
            f_10940_13686_13762(Roslyn.Utilities.ReferenceEqualityComparer
            comparer)
            {
                var return_v = new System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>((System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>)comparer);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 13686, 13762);
                return return_v;
            }


            System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>>
            f_10940_13797_13936(Roslyn.Utilities.ReferenceEqualityComparer
            comparer)
            {
                var return_v = new System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Generic.IReadOnlyDictionary<string, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>>((System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>)comparer);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 13797, 13936);
                return return_v;
            }

        }
        internal sealed class DeepTranslator : CSharpSymbolVisitor<Symbol>
        {
            private readonly ConcurrentDictionary<Symbol, Symbol> _matches;

            private readonly NamedTypeSymbol _systemObject;

            public DeepTranslator(NamedTypeSymbol systemObject)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10940, 43392, 43626);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 43306, 43314);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 43362, 43375);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 43476, 43564);

                    _matches = f_10940_43487_43563(ReferenceEqualityComparer.Instance);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 43582, 43611);

                    _systemObject = systemObject;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10940, 43392, 43626);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 43392, 43626);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 43392, 43626);
                }
            }

            public override Symbol DefaultVisit(Symbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 43642, 43840);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 43788, 43825);

                    throw f_10940_43794_43824();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 43642, 43840);

                    System.Exception
                    f_10940_43794_43824()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 43794, 43824);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 43642, 43840);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 43642, 43840);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Symbol Visit(Symbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 43856, 44000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 43932, 43985);

                    return f_10940_43939_43984(_matches, symbol, DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Visit(symbol), 10940, 43965, 43983));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 43856, 44000);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10940_43939_43984(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    key, Microsoft.CodeAnalysis.CSharp.Symbol
                    value)
                    {
                        var return_v = this_param.GetOrAdd(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 43939, 43984);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 43856, 44000);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 43856, 44000);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Symbol VisitArrayType(ArrayTypeSymbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 44016, 44866);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 44110, 44181);

                    var
                    translatedElementType = (TypeSymbol)f_10940_44150_44180(this, f_10940_44161_44179(symbol))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 44199, 44297);

                    var
                    translatedModifiers = f_10940_44225_44296(this, symbol.ElementTypeWithAnnotations.CustomModifiers)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 44317, 44591) || true) && (f_10940_44321_44337(symbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 44317, 44591);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 44379, 44572);

                        return f_10940_44386_44571(f_10940_44416_44470(f_10940_44416_44451(symbol)), symbol.ElementTypeWithAnnotations.WithTypeAndModifiers(translatedElementType, translatedModifiers));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 44317, 44591);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 44611, 44851);

                    return f_10940_44618_44850(f_10940_44648_44702(f_10940_44648_44683(symbol)), symbol.ElementTypeWithAnnotations.WithTypeAndModifiers(translatedElementType, translatedModifiers), f_10940_44804_44815(symbol), f_10940_44817_44829(symbol), f_10940_44831_44849(symbol));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 44016, 44866);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10940_44161_44179(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ElementType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 44161, 44179);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10940_44150_44180(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.DeepTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    symbol)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 44150, 44180);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10940_44225_44296(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.DeepTranslator
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    modifiers)
                    {
                        var return_v = this_param.VisitCustomModifiers(modifiers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 44225, 44296);
                        return return_v;
                    }


                    bool
                    f_10940_44321_44337(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsSZArray;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 44321, 44337);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10940_44416_44451(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 44416, 44451);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10940_44416_44470(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 44416, 44470);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                    f_10940_44386_44571(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    declaringAssembly, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    elementType)
                    {
                        var return_v = ArrayTypeSymbol.CreateSZArray(declaringAssembly, elementType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 44386, 44571);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10940_44648_44683(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 44648, 44683);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10940_44648_44702(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 44648, 44702);
                        return return_v;
                    }


                    int
                    f_10940_44804_44815(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Rank;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 44804, 44815);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<int>
                    f_10940_44817_44829(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Sizes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 44817, 44829);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<int>
                    f_10940_44831_44849(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.LowerBounds;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 44831, 44849);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                    f_10940_44618_44850(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    declaringAssembly, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    elementType, int
                    rank, System.Collections.Immutable.ImmutableArray<int>
                    sizes, System.Collections.Immutable.ImmutableArray<int>
                    lowerBounds)
                    {
                        var return_v = ArrayTypeSymbol.CreateMDArray(declaringAssembly, elementType, rank, sizes, lowerBounds);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 44618, 44850);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 44016, 44866);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 44016, 44866);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Symbol VisitDynamicType(DynamicTypeSymbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 44882, 45016);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 44980, 45001);

                    return _systemObject;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 44882, 45016);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 44882, 45016);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 44882, 45016);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Symbol VisitNamedType(NamedTypeSymbol type)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 45032, 46403);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 45124, 45166);

                    var
                    originalDef = f_10940_45142_45165(type)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 45184, 46124) || true) && ((object)originalDef != type)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 45184, 46124);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 45257, 45307);

                        HashSet<DiagnosticInfo>
                        useSiteDiagnostics = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 45329, 45795);

                        var
                        translatedTypeArguments = f_10940_45359_45407(type, ref useSiteDiagnostics).SelectAsArray((t, v) => t.WithTypeAndModifiers((TypeSymbol)v.Visit(t.Type),
                                                                                                                                                                          v.VisitCustomModifiers(t.CustomModifiers)), this)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 45819, 45888);

                        var
                        translatedOriginalDef = (NamedTypeSymbol)f_10940_45864_45887(this, originalDef)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 45910, 46025);

                        var
                        typeMap = f_10940_45924_46024(f_10940_45936_45980(translatedOriginalDef), translatedTypeArguments, allowAlpha: true)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 46047, 46105);

                        return f_10940_46054_46104(typeMap, translatedOriginalDef);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 45184, 46124);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 46144, 46176);

                    f_10940_46144_46175(f_10940_46157_46174(type));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 46196, 46356) || true) && (f_10940_46200_46220(type))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 46196, 46356);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 46262, 46337);

                        return f_10940_46269_46336(this, f_10940_46280_46335(type));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 46196, 46356);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 46376, 46388);

                    return type;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 45032, 46403);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10940_45142_45165(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 45142, 45165);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10940_45359_45407(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                    useSiteDiagnostics)
                    {
                        var return_v = this_param.GetAllTypeArguments(ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 45359, 45407);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10940_45864_45887(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.DeepTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    symbol)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 45864, 45887);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10940_45936_45980(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type)
                    {
                        var return_v = type.GetAllTypeParameters();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 45936, 45980);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                    f_10940_45924_46024(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    from, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    to, bool
                    allowAlpha)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap(from, to, allowAlpha: allowAlpha);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 45924, 46024);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10940_46054_46104(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    previous)
                    {
                        var return_v = this_param.SubstituteNamedType(previous);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 46054, 46104);
                        return return_v;
                    }


                    bool
                    f_10940_46157_46174(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 46157, 46174);
                        return return_v;
                    }


                    int
                    f_10940_46144_46175(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 46144, 46175);
                        return 0;
                    }


                    bool
                    f_10940_46200_46220(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsAnonymousType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 46200, 46220);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10940_46280_46335(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type)
                    {
                        var return_v = AnonymousTypeManager.TranslateAnonymousTypeSymbol(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 46280, 46335);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10940_46269_46336(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.DeepTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    symbol)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 46269, 46336);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 45032, 46403);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 45032, 46403);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Symbol VisitPointerType(PointerTypeSymbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 46419, 46876);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 46517, 46592);

                    var
                    translatedPointedAtType = (TypeSymbol)f_10940_46559_46591(this, f_10940_46570_46590(symbol))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 46610, 46710);

                    var
                    translatedModifiers = f_10940_46636_46709(this, symbol.PointedAtTypeWithAnnotations.CustomModifiers)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 46728, 46861);

                    return f_10940_46735_46860(symbol.PointedAtTypeWithAnnotations.WithTypeAndModifiers(translatedPointedAtType, translatedModifiers));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 46419, 46876);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10940_46570_46590(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.PointedAtType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 46570, 46590);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10940_46559_46591(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.DeepTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    symbol)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 46559, 46591);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10940_46636_46709(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.DeepTranslator
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    modifiers)
                    {
                        var return_v = this_param.VisitCustomModifiers(modifiers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 46636, 46709);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                    f_10940_46735_46860(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    pointedAtType)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol(pointedAtType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 46735, 46860);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 46419, 46876);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 46419, 46876);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Symbol VisitFunctionPointerType(FunctionPointerTypeSymbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 46892, 48873);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 47006, 47033);

                    var
                    sig = f_10940_47016_47032(symbol)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 47051, 47112);

                    var
                    translatedReturnType = (TypeSymbol)f_10940_47090_47111(this, f_10940_47096_47110(sig))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 47130, 47314);

                    var
                    translatedReturnTypeWithAnnotations = sig.ReturnTypeWithAnnotations.WithTypeAndModifiers(translatedReturnType, f_10940_47245_47312(this, sig.ReturnTypeWithAnnotations.CustomModifiers))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 47332, 47412);

                    var
                    translatedRefCustomModifiers = f_10940_47367_47411(this, f_10940_47388_47410(sig))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 47432, 47505);

                    var
                    translatedParameterTypes = ImmutableArray<TypeWithAnnotations>.Empty
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 47523, 47614);

                    ImmutableArray<ImmutableArray<CustomModifier>>
                    translatedParamRefCustomModifiers = default
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 47634, 48675) || true) && (f_10940_47638_47656(sig) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 47634, 48675);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 47702, 47798);

                        var
                        translatedParamsBuilder = f_10940_47732_47797(f_10940_47778_47796(sig))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 47820, 47944);

                        var
                        translatedParamRefCustomModifiersBuilder = f_10940_47867_47943(f_10940_47924_47942(sig))
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 47968, 48440);
                            foreach (var param in f_10940_47990_48004_I(f_10940_47990_48004(sig)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10940, 47968, 48440);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 48054, 48110);

                                var
                                translatedParamType = (TypeSymbol)f_10940_48092_48109(this, f_10940_48098_48108(param))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 48136, 48298);

                                f_10940_48136_48297(translatedParamsBuilder, param.TypeWithAnnotations.WithTypeAndModifiers(translatedParamType, f_10940_48232_48295(this, param.TypeWithAnnotations.CustomModifiers)));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 48324, 48417);

                                f_10940_48324_48416(translatedParamRefCustomModifiersBuilder, f_10940_48369_48415(this, f_10940_48390_48414(param)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 47968, 48440);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10940, 1, 473);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10940, 1, 473);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 48464, 48536);

                        translatedParameterTypes = f_10940_48491_48535(translatedParamsBuilder);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 48558, 48656);

                        translatedParamRefCustomModifiers = f_10940_48594_48655(translatedParamRefCustomModifiersBuilder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10940, 47634, 48675);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 48695, 48858);

                    return f_10940_48702_48857(symbol, translatedReturnTypeWithAnnotations, translatedParameterTypes, translatedRefCustomModifiers, translatedParamRefCustomModifiers);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 46892, 48873);

                    Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                    f_10940_47016_47032(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Signature;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 47016, 47032);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10940_47096_47110(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 47096, 47110);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10940_47090_47111(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.DeepTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    symbol)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 47090, 47111);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10940_47245_47312(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.DeepTranslator
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    modifiers)
                    {
                        var return_v = this_param.VisitCustomModifiers(modifiers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 47245, 47312);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10940_47388_47410(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RefCustomModifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 47388, 47410);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10940_47367_47411(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.DeepTranslator
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    modifiers)
                    {
                        var return_v = this_param.VisitCustomModifiers(modifiers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 47367, 47411);
                        return return_v;
                    }


                    int
                    f_10940_47638_47656(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ParameterCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 47638, 47656);
                        return return_v;
                    }


                    int
                    f_10940_47778_47796(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ParameterCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 47778, 47796);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10940_47732_47797(int
                    capacity)
                    {
                        var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance(capacity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 47732, 47797);
                        return return_v;
                    }


                    int
                    f_10940_47924_47942(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ParameterCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 47924, 47942);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>>
                    f_10940_47867_47943(int
                    capacity)
                    {
                        var return_v = ArrayBuilder<ImmutableArray<CustomModifier>>.GetInstance(capacity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 47867, 47943);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10940_47990_48004(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 47990, 48004);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10940_48098_48108(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 48098, 48108);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10940_48092_48109(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.DeepTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    symbol)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 48092, 48109);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10940_48232_48295(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.DeepTranslator
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    modifiers)
                    {
                        var return_v = this_param.VisitCustomModifiers(modifiers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 48232, 48295);
                        return return_v;
                    }


                    int
                    f_10940_48136_48297(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 48136, 48297);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10940_48390_48414(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.RefCustomModifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 48390, 48414);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10940_48369_48415(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.DeepTranslator
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    modifiers)
                    {
                        var return_v = this_param.VisitCustomModifiers(modifiers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 48369, 48415);
                        return return_v;
                    }


                    int
                    f_10940_48324_48416(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>>
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 48324, 48416);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10940_47990_48004_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 47990, 48004);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10940_48491_48535(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 48491, 48535);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>>
                    f_10940_48594_48655(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 48594, 48655);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                    f_10940_48702_48857(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    substitutedReturnType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    substitutedParameterTypes, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    refCustomModifiers, System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>>
                    paramRefCustomModifiers)
                    {
                        var return_v = this_param.SubstituteTypeSymbol(substitutedReturnType, substitutedParameterTypes, refCustomModifiers, paramRefCustomModifiers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 48702, 48857);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 46892, 48873);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 46892, 48873);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Symbol VisitTypeParameter(TypeParameterSymbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 48889, 49020);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 48991, 49005);

                    return symbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 48889, 49020);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 48889, 49020);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 48889, 49020);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private ImmutableArray<CustomModifier> VisitCustomModifiers(ImmutableArray<CustomModifier> modifiers)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 49036, 49237);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 49170, 49222);

                    return modifiers.SelectAsArray(VisitCustomModifier);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 49036, 49237);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 49036, 49237);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 49036, 49237);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private CustomModifier VisitCustomModifier(CustomModifier modifier)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10940, 49253, 49724);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 49353, 49451);

                    var
                    translatedType = (NamedTypeSymbol)f_10940_49391_49450(this, f_10940_49402_49449(((CSharpCustomModifier)modifier)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 49469, 49514);

                    f_10940_49469_49513((object)translatedType != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10940, 49532, 49709);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10940, 49539, 49558) || ((f_10940_49539_49558(modifier) && DynAbs.Tracing.TraceSender.Conditional_F2(10940, 49582, 49633)) || DynAbs.Tracing.TraceSender.Conditional_F3(10940, 49657, 49708))) ? f_10940_49582_49633(translatedType) : f_10940_49657_49708(translatedType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10940, 49253, 49724);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10940_49402_49449(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpCustomModifier
                    this_param)
                    {
                        var return_v = this_param.ModifierSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 49402, 49449);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10940_49391_49450(Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.DeepTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    symbol)
                    {
                        var return_v = this_param.Visit((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 49391, 49450);
                        return return_v;
                    }


                    int
                    f_10940_49469_49513(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 49469, 49513);
                        return 0;
                    }


                    bool
                    f_10940_49539_49558(Microsoft.CodeAnalysis.CustomModifier
                    this_param)
                    {
                        var return_v = this_param.IsOptional;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10940, 49539, 49558);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CustomModifier
                    f_10940_49582_49633(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    modifier)
                    {
                        var return_v = CSharpCustomModifier.CreateOptional(modifier);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 49582, 49633);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CustomModifier
                    f_10940_49657_49708(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    modifier)
                    {
                        var return_v = CSharpCustomModifier.CreateRequired(modifier);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 49657, 49708);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10940, 49253, 49724);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 49253, 49724);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static DeepTranslator()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10940, 43161, 49735);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10940, 43161, 49735);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 43161, 49735);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10940, 43161, 49735);

            System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
            f_10940_43487_43563(Roslyn.Utilities.ReferenceEqualityComparer
            comparer)
            {
                var return_v = new System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>((System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>)comparer);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 43487, 43563);
                return return_v;
            }

        }

        static CSharpSymbolMatcher()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10940, 730, 49742);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10940, 730, 49742);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10940, 730, 49742);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10940, 730, 49742);

        Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchDefsToSource
        f_10940_1336_1386(Microsoft.CodeAnalysis.Emit.EmitContext
        sourceContext, Microsoft.CodeAnalysis.Emit.EmitContext
        otherContext)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchDefsToSource(sourceContext, otherContext);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 1336, 1386);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10940_1525_1580(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
        this_param, Microsoft.CodeAnalysis.SpecialType
        type)
        {
            var return_v = this_param.GetSpecialType(type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 1525, 1580);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.DeepTranslator
        f_10940_1506_1581(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        systemObject)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.DeepTranslator(systemObject);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 1506, 1581);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
        f_10940_1412_1582(System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue>
        anonymousTypeMap, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
        sourceAssembly, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
        otherAssembly, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>
        otherSynthesizedMembersOpt, Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.DeepTranslator
        deepTranslatorOpt)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols(anonymousTypeMap, sourceAssembly, (Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol)otherAssembly, otherSynthesizedMembersOpt, deepTranslatorOpt);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 1412, 1582);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchDefsToMetadata
        f_10940_1890_1943(Microsoft.CodeAnalysis.Emit.EmitContext
        sourceContext, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAssemblySymbol
        otherAssembly)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchDefsToMetadata(sourceContext, otherAssembly);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 1890, 1943);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols
        f_10940_1971_2181(System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue>
        anonymousTypeMap, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
        sourceAssembly, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAssemblySymbol
        otherAssembly, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>
        otherSynthesizedMembersOpt, Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.DeepTranslator
        deepTranslatorOpt)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Emit.CSharpSymbolMatcher.MatchSymbols(anonymousTypeMap, sourceAssembly, (Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol)otherAssembly, otherSynthesizedMembersOpt: otherSynthesizedMembersOpt, deepTranslatorOpt: deepTranslatorOpt);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10940, 1971, 2181);
            return return_v;
        }

    }
}
