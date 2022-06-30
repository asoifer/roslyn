// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Symbols;

namespace Microsoft.CodeAnalysis.Emit
{
    internal abstract class SymbolMatcher
    {
        public abstract Cci.ITypeReference MapReference(Cci.ITypeReference reference);

        public abstract Cci.IDefinition MapDefinition(Cci.IDefinition definition);

        public abstract Cci.INamespace MapNamespace(Cci.INamespace @namespace);

        public ISymbolInternal MapDefinitionOrNamespace(ISymbolInternal symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(769, 769, 1084);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 865, 902);

                var
                adapter = f_769_879_901(symbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 916, 1073);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(769, 923, 962) || 
                    (((adapter is Cci.IDefinition) && DynAbs.Tracing.TraceSender.Conditional_F2(769, 965, 1011)) || 
                    DynAbs.Tracing.TraceSender.Conditional_F3(769, 1014, 1072))) ? f_769_965_1011_I(f_769_965_990(this, ((Cci.IDefinition)adapter)).GetInternalSymbol()) : f_769_1014_1072_I(f_769_1014_1051(this, adapter).GetInternalSymbol());
                DynAbs.Tracing.TraceSender.TraceExitMethod(769, 769, 1084);

                Microsoft.Cci.IReference
                f_769_879_901(Microsoft.CodeAnalysis.Symbols.ISymbolInternal
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(769, 879, 901);
                    return return_v;
                }


                Microsoft.Cci.IDefinition?
                f_769_965_990(Microsoft.CodeAnalysis.Emit.SymbolMatcher
                this_param, Microsoft.Cci.IDefinition
                definition)
                {
                    var return_v = this_param?.MapDefinition(definition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(769, 965, 990);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                f_769_965_1011_I(Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(769, 965, 1011);
                    return return_v;
                }


                Microsoft.Cci.INamespace?
                f_769_1014_1051(Microsoft.CodeAnalysis.Emit.SymbolMatcher
                this_param, Microsoft.Cci.IReference
                @namespace)
                {
                    var return_v = this_param?.MapNamespace((Microsoft.Cci.INamespace)@namespace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(769, 1014, 1051);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Symbols.INamespaceSymbolInternal?
                f_769_1014_1072_I(Microsoft.CodeAnalysis.Symbols.INamespaceSymbolInternal?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(769, 1014, 1072);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(769, 769, 1084);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(769, 769, 1084);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public EmitBaseline MapBaselineToCompilation(
                    EmitBaseline baseline,
                    Compilation targetCompilation,
                    CommonPEModuleBuilder targetModuleBuilder,
                    ImmutableDictionary<ISymbolInternal, ImmutableArray<ISymbolInternal>> mappedSynthesizedMembers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(769, 1096, 3094);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 1468, 1521);

                var
                typesAdded = f_769_1485_1520(this, baseline.TypesAdded)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 1535, 1590);

                var
                eventsAdded = f_769_1553_1589(this, baseline.EventsAdded)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 1604, 1659);

                var
                fieldsAdded = f_769_1622_1658(this, baseline.FieldsAdded)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 1673, 1730);

                var
                methodsAdded = f_769_1692_1729(this, baseline.MethodsAdded)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 1744, 1807);

                var
                propertiesAdded = f_769_1766_1806(this, baseline.PropertiesAdded)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 1823, 3083);

                return f_769_1830_3082(baseline, targetCompilation, targetModuleBuilder, baseline.Ordinal, baseline.EncId, typesAdded, eventsAdded, fieldsAdded, methodsAdded, propertiesAdded, eventMapAdded: baseline.EventMapAdded, propertyMapAdded: baseline.PropertyMapAdded, methodImplsAdded: baseline.MethodImplsAdded, tableEntriesAdded: baseline.TableEntriesAdded, blobStreamLengthAdded: baseline.BlobStreamLengthAdded, stringStreamLengthAdded: baseline.StringStreamLengthAdded, userStringStreamLengthAdded: baseline.UserStringStreamLengthAdded, guidStreamLengthAdded: baseline.GuidStreamLengthAdded, anonymousTypeMap: f_769_2724_2768(this, f_769_2742_2767(baseline)), synthesizedMembers: mappedSynthesizedMembers, addedOrChangedMethods: f_769_2873_2929(this, baseline.AddedOrChangedMethods), debugInformationProvider: baseline.DebugInformationProvider, localSignatureProvider: baseline.LocalSignatureProvider);
                DynAbs.Tracing.TraceSender.TraceExitMethod(769, 1096, 3094);

                System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.ITypeDefinition, int>
                f_769_1485_1520(Microsoft.CodeAnalysis.Emit.SymbolMatcher
                this_param, System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.ITypeDefinition, int>
                items)
                {
                    var return_v = this_param.MapDefinitions<Microsoft.Cci.ITypeDefinition, int>(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(769, 1485, 1520);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IEventDefinition, int>
                f_769_1553_1589(Microsoft.CodeAnalysis.Emit.SymbolMatcher
                this_param, System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IEventDefinition, int>
                items)
                {
                    var return_v = this_param.MapDefinitions<Microsoft.Cci.IEventDefinition, int>(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(769, 1553, 1589);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IFieldDefinition, int>
                f_769_1622_1658(Microsoft.CodeAnalysis.Emit.SymbolMatcher
                this_param, System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IFieldDefinition, int>
                items)
                {
                    var return_v = this_param.MapDefinitions<Microsoft.Cci.IFieldDefinition, int>(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(769, 1622, 1658);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IMethodDefinition, int>
                f_769_1692_1729(Microsoft.CodeAnalysis.Emit.SymbolMatcher
                this_param, System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IMethodDefinition, int>
                items)
                {
                    var return_v = this_param.MapDefinitions<Microsoft.Cci.IMethodDefinition, int>(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(769, 1692, 1729);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IPropertyDefinition, int>
                f_769_1766_1806(Microsoft.CodeAnalysis.Emit.SymbolMatcher
                this_param, System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IPropertyDefinition, int>
                items)
                {
                    var return_v = this_param.MapDefinitions<Microsoft.Cci.IPropertyDefinition, int>(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(769, 1766, 1806);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue>
                f_769_2742_2767(Microsoft.CodeAnalysis.Emit.EmitBaseline
                this_param)
                {
                    var return_v = this_param.AnonymousTypeMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(769, 2742, 2767);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue>
                f_769_2724_2768(Microsoft.CodeAnalysis.Emit.SymbolMatcher
                this_param, System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue>
                anonymousTypeMap)
                {
                    var return_v = this_param.MapAnonymousTypes(anonymousTypeMap);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(769, 2724, 2768);
                    return return_v;
                }


                System.Collections.Generic.IReadOnlyDictionary<int, Microsoft.CodeAnalysis.Emit.AddedOrChangedMethodInfo>
                f_769_2873_2929(Microsoft.CodeAnalysis.Emit.SymbolMatcher
                this_param, System.Collections.Generic.IReadOnlyDictionary<int, Microsoft.CodeAnalysis.Emit.AddedOrChangedMethodInfo>
                addedOrChangedMethods)
                {
                    var return_v = this_param.MapAddedOrChangedMethods(addedOrChangedMethods);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(769, 2873, 2929);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Emit.EmitBaseline
                f_769_1830_3082(Microsoft.CodeAnalysis.Emit.EmitBaseline
                this_param, Microsoft.CodeAnalysis.Compilation
                compilation, Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
                moduleBuilder, int
                ordinal, System.Guid
                encId, System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.ITypeDefinition, int>
                typesAdded, System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IEventDefinition, int>
                eventsAdded, System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IFieldDefinition, int>
                fieldsAdded, System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IMethodDefinition, int>
                methodsAdded, System.Collections.Generic.IReadOnlyDictionary<Microsoft.Cci.IPropertyDefinition, int>
                propertiesAdded, System.Collections.Generic.IReadOnlyDictionary<int, int>
                eventMapAdded, System.Collections.Generic.IReadOnlyDictionary<int, int>
                propertyMapAdded, System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.MethodImplKey, int>
                methodImplsAdded, System.Collections.Immutable.ImmutableArray<int>
                tableEntriesAdded, int
                blobStreamLengthAdded, int
                stringStreamLengthAdded, int
                userStringStreamLengthAdded, int
                guidStreamLengthAdded, System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue>
                anonymousTypeMap, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>
                synthesizedMembers, System.Collections.Generic.IReadOnlyDictionary<int, Microsoft.CodeAnalysis.Emit.AddedOrChangedMethodInfo>
                addedOrChangedMethods, System.Func<System.Reflection.Metadata.MethodDefinitionHandle, Microsoft.CodeAnalysis.Emit.EditAndContinueMethodDebugInformation>
                debugInformationProvider, System.Func<System.Reflection.Metadata.MethodDefinitionHandle, System.Reflection.Metadata.StandaloneSignatureHandle>
                localSignatureProvider)
                {
                    var return_v = this_param.With(compilation, moduleBuilder, ordinal, encId, typesAdded, eventsAdded, fieldsAdded, methodsAdded, propertiesAdded, eventMapAdded: eventMapAdded, propertyMapAdded: propertyMapAdded, methodImplsAdded: methodImplsAdded, tableEntriesAdded: tableEntriesAdded, blobStreamLengthAdded: blobStreamLengthAdded, stringStreamLengthAdded: stringStreamLengthAdded, userStringStreamLengthAdded: userStringStreamLengthAdded, guidStreamLengthAdded: guidStreamLengthAdded, anonymousTypeMap: anonymousTypeMap, synthesizedMembers: synthesizedMembers, addedOrChangedMethods: addedOrChangedMethods, debugInformationProvider: debugInformationProvider, localSignatureProvider: localSignatureProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(769, 1830, 3082);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(769, 1096, 3094);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(769, 1096, 3094);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IReadOnlyDictionary<K, V> MapDefinitions<K, V>(IReadOnlyDictionary<K, V> items)
                    where K : class, Cci.IDefinition
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(769, 3106, 3899);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 3264, 3345);

                var
                result = f_769_3277_3344(Cci.SymbolEquivalentEqualityComparer.Instance)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 3359, 3858);
                    foreach (var pair in f_769_3380_3385_I(items))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(769, 3359, 3858);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 3419, 3456);

                        var
                        key = (K)f_769_3432_3455(this, pair.Key)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 3739, 3843) || true) && (key != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(769, 3739, 3843);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 3796, 3824);

                            f_769_3796_3823(result, key, pair.Value);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(769, 3739, 3843);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(769, 3359, 3858);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(769, 1, 500);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(769, 1, 500);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 3874, 3888);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(769, 3106, 3899);

                System.Collections.Generic.Dictionary<K, V>
                f_769_3277_3344(Microsoft.Cci.SymbolEquivalentEqualityComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<K, V>((System.Collections.Generic.IEqualityComparer<K>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(769, 3277, 3344);
                    return return_v;
                }


                Microsoft.Cci.IDefinition
                f_769_3432_3455(Microsoft.CodeAnalysis.Emit.SymbolMatcher
                this_param, K
                definition)
                {
                    var return_v = this_param.MapDefinition((Microsoft.Cci.IDefinition)definition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(769, 3432, 3455);
                    return return_v;
                }


                int
                f_769_3796_3823(System.Collections.Generic.Dictionary<K, V>
                this_param, K
                key, V
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(769, 3796, 3823);
                    return 0;
                }


                System.Collections.Generic.IReadOnlyDictionary<K, V>
                f_769_3380_3385_I(System.Collections.Generic.IReadOnlyDictionary<K, V>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(769, 3380, 3385);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(769, 3106, 3899);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(769, 3106, 3899);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IReadOnlyDictionary<int, AddedOrChangedMethodInfo> MapAddedOrChangedMethods(IReadOnlyDictionary<int, AddedOrChangedMethodInfo> addedOrChangedMethods)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(769, 3911, 4350);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 4093, 4154);

                var
                result = f_769_4106_4153()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 4170, 4309);
                    foreach (var pair in f_769_4191_4212_I(addedOrChangedMethods))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(769, 4170, 4309);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 4246, 4294);

                        f_769_4246_4293(result, pair.Key, pair.Value.MapTypes(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(769, 4170, 4309);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(769, 1, 140);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(769, 1, 140);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 4325, 4339);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(769, 3911, 4350);

                System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Emit.AddedOrChangedMethodInfo>
                f_769_4106_4153()
                {
                    var return_v = new System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Emit.AddedOrChangedMethodInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(769, 4106, 4153);
                    return return_v;
                }


                int
                f_769_4246_4293(System.Collections.Generic.Dictionary<int, Microsoft.CodeAnalysis.Emit.AddedOrChangedMethodInfo>
                this_param, int
                key, Microsoft.CodeAnalysis.Emit.AddedOrChangedMethodInfo
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(769, 4246, 4293);
                    return 0;
                }


                System.Collections.Generic.IReadOnlyDictionary<int, Microsoft.CodeAnalysis.Emit.AddedOrChangedMethodInfo>
                f_769_4191_4212_I(System.Collections.Generic.IReadOnlyDictionary<int, Microsoft.CodeAnalysis.Emit.AddedOrChangedMethodInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(769, 4191, 4212);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(769, 3911, 4350);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(769, 3911, 4350);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IReadOnlyDictionary<AnonymousTypeKey, AnonymousTypeValue> MapAnonymousTypes(IReadOnlyDictionary<AnonymousTypeKey, AnonymousTypeValue> anonymousTypeMap)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(769, 4362, 5033);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 4546, 4614);

                var
                result = f_769_4559_4613()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 4630, 4992);
                    foreach (var pair in f_769_4651_4667_I(anonymousTypeMap))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(769, 4630, 4992);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 4701, 4720);

                        var
                        key = pair.Key
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 4738, 4761);

                        var
                        value = pair.Value
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 4779, 4837);

                        var
                        type = (Cci.ITypeDefinition)f_769_4811_4836(this, value.Type)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 4855, 4882);

                        f_769_4855_4881(type != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 4900, 4977);

                        f_769_4900_4976(result, key, f_769_4916_4975(value.Name, value.UniqueIndex, type));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(769, 4630, 4992);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(769, 1, 363);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(769, 1, 363);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 5008, 5022);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(769, 4362, 5033);

                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue>
                f_769_4559_4613()
                {
                    var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(769, 4559, 4613);
                    return return_v;
                }


                Microsoft.Cci.IDefinition
                f_769_4811_4836(Microsoft.CodeAnalysis.Emit.SymbolMatcher
                this_param, Microsoft.Cci.ITypeDefinition
                definition)
                {
                    var return_v = this_param.MapDefinition((Microsoft.Cci.IDefinition)definition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(769, 4811, 4836);
                    return return_v;
                }


                int
                f_769_4855_4881(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(769, 4855, 4881);
                    return 0;
                }


                Microsoft.CodeAnalysis.Emit.AnonymousTypeValue
                f_769_4916_4975(string
                name, int
                uniqueIndex, Microsoft.Cci.ITypeDefinition
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.Emit.AnonymousTypeValue(name, uniqueIndex, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(769, 4916, 4975);
                    return return_v;
                }


                int
                f_769_4900_4976(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue>
                this_param, Microsoft.CodeAnalysis.Emit.AnonymousTypeKey
                key, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(769, 4900, 4976);
                    return 0;
                }


                System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue>
                f_769_4651_4667_I(System.Collections.Generic.IReadOnlyDictionary<Microsoft.CodeAnalysis.Emit.AnonymousTypeKey, Microsoft.CodeAnalysis.Emit.AnonymousTypeValue>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(769, 4651, 4667);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(769, 4362, 5033);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(769, 4362, 5033);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ImmutableDictionary<ISymbolInternal, ImmutableArray<ISymbolInternal>> MapSynthesizedMembers(
                    ImmutableDictionary<ISymbolInternal, ImmutableArray<ISymbolInternal>> previousMembers,
                    ImmutableDictionary<ISymbolInternal, ImmutableArray<ISymbolInternal>> newMembers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(769, 5875, 8805);
                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal> newSynthesizedMembers = default(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 6350, 6447) || true) && (f_769_6354_6375(previousMembers) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(769, 6350, 6447);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 6414, 6432);

                    return newMembers;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(769, 6350, 6447);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 6463, 6581);

                var
                synthesizedMembersBuilder = f_769_6495_6580()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 6597, 6644);

                f_769_6597_6643(
                            synthesizedMembersBuilder, newMembers);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 6660, 8731);
                    foreach (var pair in f_769_6681_6696_I(previousMembers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(769, 6660, 8731);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 6730, 6763);

                        var
                        previousContainer = pair.Key
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 6781, 6806);

                        var
                        members = pair.Value
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 6826, 6892);

                        var
                        mappedContainer = f_769_6848_6891(this, previousContainer)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 6910, 7160) || true) && (mappedContainer == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(769, 6910, 7160);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 7052, 7110);

                            f_769_7052_7109(                    // No update to any member of the container type.  
                                                synthesizedMembersBuilder, previousContainer, members);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 7132, 7141);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(769, 6910, 7160);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 7180, 7513) || true) && (!f_769_7185_7255(newMembers, mappedContainer, out newSynthesizedMembers))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(769, 7180, 7513);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 7407, 7463);

                            f_769_7407_7462(                    // The container has been updated but the update didn't produce any synthesized members.
                                                synthesizedMembersBuilder, mappedContainer, members);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 7485, 7494);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(769, 7180, 7513);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 7709, 7773);

                        var
                        memberBuilder = f_769_7729_7772()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 7791, 7837);

                        f_769_7791_7836(memberBuilder, newSynthesizedMembers);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 7857, 8616);
                            foreach (var member in f_769_7880_7887_I(members))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(769, 7857, 8616);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 7929, 7981);

                                var
                                mappedMember = f_769_7948_7980(this, member)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 8003, 8597) || true) && (mappedMember != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(769, 8003, 8597);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 8391, 8450);

                                    f_769_8391_8449(newSynthesizedMembers.Contains(mappedMember));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(769, 8003, 8597);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(769, 8003, 8597);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 8548, 8574);

                                    f_769_8548_8573(memberBuilder, member);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(769, 8003, 8597);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(769, 7857, 8616);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(769, 1, 760);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(769, 1, 760);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 8636, 8716);

                        synthesizedMembersBuilder[mappedContainer] = f_769_8681_8715(memberBuilder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(769, 6660, 8731);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(769, 1, 2072);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(769, 1, 2072);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(769, 8747, 8794);

                return f_769_8754_8793(synthesizedMembersBuilder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(769, 5875, 8805);

                int
                f_769_6354_6375(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(769, 6354, 6375);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>.Builder
                f_769_6495_6580()
                {
                    var return_v = ImmutableDictionary.CreateBuilder<ISymbolInternal, ImmutableArray<ISymbolInternal>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(769, 6495, 6580);
                    return return_v;
                }


                int
                f_769_6597_6643(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>.Builder
                this_param, System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>
                items)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>>)items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(769, 6597, 6643);
                    return 0;
                }


                Microsoft.CodeAnalysis.Symbols.ISymbolInternal
                f_769_6848_6891(Microsoft.CodeAnalysis.Emit.SymbolMatcher
                this_param, Microsoft.CodeAnalysis.Symbols.ISymbolInternal
                symbol)
                {
                    var return_v = this_param.MapDefinitionOrNamespace(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(769, 6848, 6891);
                    return return_v;
                }


                int
                f_769_7052_7109(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>.Builder
                this_param, Microsoft.CodeAnalysis.Symbols.ISymbolInternal
                key, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(769, 7052, 7109);
                    return 0;
                }


                bool
                f_769_7185_7255(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>
                this_param, Microsoft.CodeAnalysis.Symbols.ISymbolInternal
                key, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(769, 7185, 7255);
                    return return_v;
                }


                int
                f_769_7407_7462(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>.Builder
                this_param, Microsoft.CodeAnalysis.Symbols.ISymbolInternal
                key, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(769, 7407, 7462);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>
                f_769_7729_7772()
                {
                    var return_v = ArrayBuilder<ISymbolInternal>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(769, 7729, 7772);
                    return return_v;
                }


                int
                f_769_7791_7836(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(769, 7791, 7836);
                    return 0;
                }


                Microsoft.CodeAnalysis.Symbols.ISymbolInternal
                f_769_7948_7980(Microsoft.CodeAnalysis.Emit.SymbolMatcher
                this_param, Microsoft.CodeAnalysis.Symbols.ISymbolInternal
                symbol)
                {
                    var return_v = this_param.MapDefinitionOrNamespace(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(769, 7948, 7980);
                    return return_v;
                }


                int
                f_769_8391_8449(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(769, 8391, 8449);
                    return 0;
                }


                int
                f_769_8548_8573(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>
                this_param, Microsoft.CodeAnalysis.Symbols.ISymbolInternal
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(769, 8548, 8573);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>
                f_769_7880_7887_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(769, 7880, 7887);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>
                f_769_8681_8715(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(769, 8681, 8715);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>
                f_769_6681_6696_I(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(769, 6681, 6696);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>
                f_769_8754_8793(System.Collections.Immutable.ImmutableDictionary<Microsoft.CodeAnalysis.Symbols.ISymbolInternal, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Symbols.ISymbolInternal>>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(769, 8754, 8793);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(769, 5875, 8805);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(769, 5875, 8805);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SymbolMatcher()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(769, 460, 8812);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(769, 460, 8812);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(769, 460, 8812);
        }


        static SymbolMatcher()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(769, 460, 8812);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(769, 460, 8812);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(769, 460, 8812);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(769, 460, 8812);
    }
}
