// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.CodeAnalysis.Collections;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CodeGen
{
    internal sealed class PrivateImplementationDetails : DefaultTypeDef, Cci.INamespaceTypeDefinition
    {
        internal const string
        SynthesizedStringHashFunctionName = "ComputeStringHash"
        ;

        private readonly CommonPEModuleBuilder _moduleBuilder;

        private readonly Cci.ITypeReference _systemObject;

        private readonly Cci.ITypeReference _systemValueType;

        private readonly Cci.ITypeReference _systemInt8Type;

        private readonly Cci.ITypeReference _systemInt16Type;

        private readonly Cci.ITypeReference _systemInt32Type;

        private readonly Cci.ITypeReference _systemInt64Type;

        private readonly Cci.ICustomAttribute _compilerGeneratedAttribute;

        private readonly string _name;

        private int _frozen;

        private ImmutableArray<SynthesizedStaticField> _orderedSynthesizedFields;

        private readonly ConcurrentDictionary<ImmutableArray<byte>, MappedField> _mappedFields;

        private ModuleVersionIdField? _mvidField;

        private readonly ConcurrentDictionary<int, InstrumentationPayloadRootField> _instrumentationPayloadRootFields;

        private ImmutableArray<Cci.IMethodDefinition> _orderedSynthesizedMethods;

        private readonly ConcurrentDictionary<string, Cci.IMethodDefinition> _synthesizedMethods;

        private ImmutableArray<Cci.ITypeReference> _orderedProxyTypes;

        private readonly ConcurrentDictionary<uint, Cci.ITypeReference> _proxyTypes;

        internal PrivateImplementationDetails(
                    CommonPEModuleBuilder moduleBuilder,
                    string moduleName,
                    int submissionSlotIndex,
                    Cci.ITypeReference systemObject,
                    Cci.ITypeReference systemValueType,
                    Cci.ITypeReference systemInt8Type,
                    Cci.ITypeReference systemInt16Type,
                    Cci.ITypeReference systemInt32Type,
                    Cci.ITypeReference systemInt64Type,
                    Cci.ICustomAttribute compilerGeneratedAttribute)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(78, 3467, 4684);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 1363, 1377);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 1451, 1464);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 1533, 1549);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 1631, 1646);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 1736, 1752);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 1842, 1858);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 1946, 1962);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 2055, 2082);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 2119, 2124);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 2233, 2240);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 2454, 2573);
                this._mappedFields = f_78_2483_2573(ByteSequenceComparer.Instance); DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 2616, 2626);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 2799, 2899);
                this._instrumentationPayloadRootFields = f_78_2835_2899(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 3096, 3188);
                this._synthesizedMethods = f_78_3131_3188(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 3388, 3454);
                this._proxyTypes = f_78_3402_3454(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 4002, 4043);

                f_78_4002_4042(systemObject != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 4057, 4101);

                f_78_4057_4100(systemValueType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 4117, 4148);

                _moduleBuilder = moduleBuilder;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 4162, 4191);

                _systemObject = systemObject;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 4205, 4240);

                _systemValueType = systemValueType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 4256, 4289);

                _systemInt8Type = systemInt8Type;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 4303, 4338);

                _systemInt16Type = systemInt16Type;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 4352, 4387);

                _systemInt32Type = systemInt32Type;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 4401, 4436);

                _systemInt64Type = systemInt64Type;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 4452, 4509);

                _compilerGeneratedAttribute = compilerGeneratedAttribute;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 4525, 4592);

                var
                isNetModule = moduleBuilder.OutputKind == OutputKind.NetModule
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 4606, 4673);

                _name = f_78_4614_4672(moduleName, submissionSlotIndex, isNetModule);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(78, 3467, 4684);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 3467, 4684);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 3467, 4684);
            }
        }

        private static string GetClassName(string moduleName, int submissionSlotIndex, bool isNetModule)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(78, 4696, 5391);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 5018, 5220);

                var
                name = (DynAbs.Tracing.TraceSender.Conditional_F1(78, 5029, 5040) || ((isNetModule && DynAbs.Tracing.TraceSender.Conditional_F2(78, 5068, 5158)) || DynAbs.Tracing.TraceSender.Conditional_F3(78, 5186, 5219))) ? $"<PrivateImplementationDetails><{f_78_5102_5155(moduleName)}>" : $"<PrivateImplementationDetails>"
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 5236, 5352) || true) && (submissionSlotIndex >= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(78, 5236, 5352);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 5298, 5337);

                    name += f_78_5306_5336(submissionSlotIndex);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(78, 5236, 5352);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 5368, 5380);

                return name;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(78, 4696, 5391);

                string
                f_78_5102_5155(string
                moduleName)
                {
                    var return_v = MetadataHelpers.MangleForTypeNameIfNeeded(moduleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 5102, 5155);
                    return return_v;
                }


                string
                f_78_5306_5336(int
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 5306, 5336);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 4696, 5391);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 4696, 5391);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void Freeze()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 5403, 6523);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 5450, 5503);

                var
                wasFrozen = f_78_5466_5502(ref _frozen, 1)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 5517, 5622) || true) && (wasFrozen != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(78, 5517, 5622);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 5569, 5607);

                    throw f_78_5575_5606();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(78, 5517, 5622);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 5667, 5821);

                ArrayBuilder<SynthesizedStaticField>
                fieldsBuilder = f_78_5720_5820(f_78_5769_5788(_mappedFields) + ((DynAbs.Tracing.TraceSender.Conditional_F1(78, 5792, 5810) || ((_mvidField != null && DynAbs.Tracing.TraceSender.Conditional_F2(78, 5813, 5814)) || DynAbs.Tracing.TraceSender.Conditional_F3(78, 5817, 5818))) ? 1 : 0))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 5835, 5880);

                f_78_5835_5879(fieldsBuilder, f_78_5858_5878(_mappedFields));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 5894, 5995) || true) && (_mvidField != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(78, 5894, 5995);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 5950, 5980);

                    f_78_5950_5979(fieldsBuilder, _mvidField);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(78, 5894, 5995);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 6009, 6074);

                f_78_6009_6073(fieldsBuilder, f_78_6032_6072(_instrumentationPayloadRootFields));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 6088, 6131);

                f_78_6088_6130(fieldsBuilder, FieldComparer.Instance);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 6145, 6208);

                _orderedSynthesizedFields = f_78_6173_6207(fieldsBuilder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 6254, 6366);

                _orderedSynthesizedMethods = f_78_6283_6365(f_78_6283_6351(f_78_6283_6326(_synthesizedMethods, kvp => kvp.Key), kvp => kvp.Value));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 6416, 6512);

                _orderedProxyTypes = f_78_6437_6511(f_78_6437_6497(f_78_6437_6472(_proxyTypes, kvp => kvp.Key), kvp => kvp.Value));
                DynAbs.Tracing.TraceSender.TraceExitMethod(78, 5403, 6523);

                int
                f_78_5466_5502(ref int
                location1, int
                value)
                {
                    var return_v = Interlocked.Exchange(ref location1, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 5466, 5502);
                    return return_v;
                }


                System.InvalidOperationException
                f_78_5575_5606()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 5575, 5606);
                    return return_v;
                }


                int
                f_78_5769_5788(System.Collections.Concurrent.ConcurrentDictionary<System.Collections.Immutable.ImmutableArray<byte>, Microsoft.CodeAnalysis.CodeGen.MappedField>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(78, 5769, 5788);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.SynthesizedStaticField>
                f_78_5720_5820(int
                capacity)
                {
                    var return_v = ArrayBuilder<SynthesizedStaticField>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 5720, 5820);
                    return return_v;
                }


                System.Collections.Generic.ICollection<Microsoft.CodeAnalysis.CodeGen.MappedField>
                f_78_5858_5878(System.Collections.Concurrent.ConcurrentDictionary<System.Collections.Immutable.ImmutableArray<byte>, Microsoft.CodeAnalysis.CodeGen.MappedField>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(78, 5858, 5878);
                    return return_v;
                }


                int
                f_78_5835_5879(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.SynthesizedStaticField>
                this_param, System.Collections.Generic.ICollection<Microsoft.CodeAnalysis.CodeGen.MappedField>
                items)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CodeGen.SynthesizedStaticField>)items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 5835, 5879);
                    return 0;
                }


                int
                f_78_5950_5979(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.SynthesizedStaticField>
                this_param, Microsoft.CodeAnalysis.CodeGen.ModuleVersionIdField
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CodeGen.SynthesizedStaticField)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 5950, 5979);
                    return 0;
                }


                System.Collections.Generic.ICollection<Microsoft.CodeAnalysis.CodeGen.InstrumentationPayloadRootField>
                f_78_6032_6072(System.Collections.Concurrent.ConcurrentDictionary<int, Microsoft.CodeAnalysis.CodeGen.InstrumentationPayloadRootField>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(78, 6032, 6072);
                    return return_v;
                }


                int
                f_78_6009_6073(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.SynthesizedStaticField>
                this_param, System.Collections.Generic.ICollection<Microsoft.CodeAnalysis.CodeGen.InstrumentationPayloadRootField>
                items)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CodeGen.SynthesizedStaticField>)items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 6009, 6073);
                    return 0;
                }


                int
                f_78_6088_6130(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.SynthesizedStaticField>
                this_param, Microsoft.CodeAnalysis.CodeGen.PrivateImplementationDetails.FieldComparer
                comparer)
                {
                    this_param.Sort((System.Collections.Generic.IComparer<Microsoft.CodeAnalysis.CodeGen.SynthesizedStaticField>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 6088, 6130);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CodeGen.SynthesizedStaticField>
                f_78_6173_6207(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CodeGen.SynthesizedStaticField>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 6173, 6207);
                    return return_v;
                }


                System.Linq.IOrderedEnumerable<System.Collections.Generic.KeyValuePair<string, Microsoft.Cci.IMethodDefinition>>
                f_78_6283_6326(System.Collections.Concurrent.ConcurrentDictionary<string, Microsoft.Cci.IMethodDefinition>
                source, System.Func<System.Collections.Generic.KeyValuePair<string, Microsoft.Cci.IMethodDefinition>, string>
                keySelector)
                {
                    var return_v = source.OrderBy<System.Collections.Generic.KeyValuePair<string, Microsoft.Cci.IMethodDefinition>, string>(keySelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 6283, 6326);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.IMethodDefinition>
                f_78_6283_6351(System.Linq.IOrderedEnumerable<System.Collections.Generic.KeyValuePair<string, Microsoft.Cci.IMethodDefinition>>
                source, System.Func<System.Collections.Generic.KeyValuePair<string, Microsoft.Cci.IMethodDefinition>, Microsoft.Cci.IMethodDefinition>
                selector)
                {
                    var return_v = source.Select<System.Collections.Generic.KeyValuePair<string, Microsoft.Cci.IMethodDefinition>, Microsoft.Cci.IMethodDefinition>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 6283, 6351);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IMethodDefinition>
                f_78_6283_6365(System.Collections.Generic.IEnumerable<Microsoft.Cci.IMethodDefinition>
                items)
                {
                    var return_v = items.AsImmutable<Microsoft.Cci.IMethodDefinition>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 6283, 6365);
                    return return_v;
                }


                System.Linq.IOrderedEnumerable<System.Collections.Generic.KeyValuePair<uint, Microsoft.Cci.ITypeReference>>
                f_78_6437_6472(System.Collections.Concurrent.ConcurrentDictionary<uint, Microsoft.Cci.ITypeReference>
                source, System.Func<System.Collections.Generic.KeyValuePair<uint, Microsoft.Cci.ITypeReference>, uint>
                keySelector)
                {
                    var return_v = source.OrderBy<System.Collections.Generic.KeyValuePair<uint, Microsoft.Cci.ITypeReference>, uint>(keySelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 6437, 6472);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.ITypeReference>
                f_78_6437_6497(System.Linq.IOrderedEnumerable<System.Collections.Generic.KeyValuePair<uint, Microsoft.Cci.ITypeReference>>
                source, System.Func<System.Collections.Generic.KeyValuePair<uint, Microsoft.Cci.ITypeReference>, Microsoft.Cci.ITypeReference>
                selector)
                {
                    var return_v = source.Select<System.Collections.Generic.KeyValuePair<uint, Microsoft.Cci.ITypeReference>, Microsoft.Cci.ITypeReference>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 6437, 6497);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ITypeReference>
                f_78_6437_6511(System.Collections.Generic.IEnumerable<Microsoft.Cci.ITypeReference>
                items)
                {
                    var return_v = items.AsImmutable<Microsoft.Cci.ITypeReference>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 6437, 6511);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 5403, 6523);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 5403, 6523);
            }
        }

        private bool IsFrozen
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 6557, 6572);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 6560, 6572);
                    return _frozen != 0; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 6557, 6572);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 6557, 6572);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 6557, 6572);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Cci.IFieldReference CreateDataField(ImmutableArray<byte> data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 6585, 7070);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 6681, 6705);

                f_78_6681_6704(f_78_6694_6703_M(!IsFrozen));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 6719, 6803);

                Cci.ITypeReference
                type = f_78_6745_6802(_proxyTypes, data.Length, GetStorageStruct)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 6817, 7059);

                return f_78_6824_7058(_mappedFields, data, data0 =>
                            {
                                var name = GenerateDataFieldName(data0);
                                var newField = new MappedField(name, this, type, data0);
                                return newField;
                            });
                DynAbs.Tracing.TraceSender.TraceExitMethod(78, 6585, 7070);

                bool
                f_78_6694_6703_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(78, 6694, 6703);
                    return return_v;
                }


                int
                f_78_6681_6704(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 6681, 6704);
                    return 0;
                }


                Microsoft.Cci.ITypeReference
                f_78_6745_6802(System.Collections.Concurrent.ConcurrentDictionary<uint, Microsoft.Cci.ITypeReference>
                this_param, int
                key, System.Func<uint, Microsoft.Cci.ITypeReference>
                valueFactory)
                {
                    var return_v = this_param.GetOrAdd((uint)key, valueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 6745, 6802);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.MappedField
                f_78_6824_7058(System.Collections.Concurrent.ConcurrentDictionary<System.Collections.Immutable.ImmutableArray<byte>, Microsoft.CodeAnalysis.CodeGen.MappedField>
                this_param, System.Collections.Immutable.ImmutableArray<byte>
                key, System.Func<System.Collections.Immutable.ImmutableArray<byte>, Microsoft.CodeAnalysis.CodeGen.MappedField>
                valueFactory)
                {
                    var return_v = this_param.GetOrAdd(key, valueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 6824, 7058);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 6585, 7070);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 6585, 7070);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Cci.ITypeReference GetStorageStruct(uint size)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 7082, 7786);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 7161, 7699);

                switch (size)
                {

                    case 1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(78, 7161, 7699);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 7236, 7312);

                        return _systemInt8Type ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.Cci.ITypeReference>(78, 7243, 7311) ?? f_78_7262_7311(1, this, _systemValueType));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(78, 7161, 7699);

                    case 2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(78, 7161, 7699);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 7359, 7436);

                        return _systemInt16Type ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.Cci.ITypeReference>(78, 7366, 7435) ?? f_78_7386_7435(2, this, _systemValueType));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(78, 7161, 7699);

                    case 4:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(78, 7161, 7699);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 7483, 7560);

                        return _systemInt32Type ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.Cci.ITypeReference>(78, 7490, 7559) ?? f_78_7510_7559(4, this, _systemValueType));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(78, 7161, 7699);

                    case 8:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(78, 7161, 7699);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 7607, 7684);

                        return _systemInt64Type ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.Cci.ITypeReference>(78, 7614, 7683) ?? f_78_7634_7683(8, this, _systemValueType));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(78, 7161, 7699);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 7715, 7775);

                return f_78_7722_7774(size, this, _systemValueType);
                DynAbs.Tracing.TraceSender.TraceExitMethod(78, 7082, 7786);

                Microsoft.CodeAnalysis.CodeGen.ExplicitSizeStruct
                f_78_7262_7311(int
                size, Microsoft.CodeAnalysis.CodeGen.PrivateImplementationDetails
                containingType, Microsoft.Cci.ITypeReference
                sysValueType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.ExplicitSizeStruct((uint)size, containingType, sysValueType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 7262, 7311);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ExplicitSizeStruct
                f_78_7386_7435(int
                size, Microsoft.CodeAnalysis.CodeGen.PrivateImplementationDetails
                containingType, Microsoft.Cci.ITypeReference
                sysValueType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.ExplicitSizeStruct((uint)size, containingType, sysValueType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 7386, 7435);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ExplicitSizeStruct
                f_78_7510_7559(int
                size, Microsoft.CodeAnalysis.CodeGen.PrivateImplementationDetails
                containingType, Microsoft.Cci.ITypeReference
                sysValueType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.ExplicitSizeStruct((uint)size, containingType, sysValueType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 7510, 7559);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ExplicitSizeStruct
                f_78_7634_7683(int
                size, Microsoft.CodeAnalysis.CodeGen.PrivateImplementationDetails
                containingType, Microsoft.Cci.ITypeReference
                sysValueType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.ExplicitSizeStruct((uint)size, containingType, sysValueType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 7634, 7683);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ExplicitSizeStruct
                f_78_7722_7774(uint
                size, Microsoft.CodeAnalysis.CodeGen.PrivateImplementationDetails
                containingType, Microsoft.Cci.ITypeReference
                sysValueType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.ExplicitSizeStruct(size, containingType, sysValueType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 7722, 7774);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 7082, 7786);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 7082, 7786);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Cci.IFieldReference GetModuleVersionId(Cci.ITypeReference mvidType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 7798, 8205);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 7899, 8104) || true) && (_mvidField == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(78, 7899, 8104);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 7955, 7979);

                    f_78_7955_7978(f_78_7968_7977_M(!IsFrozen));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 7997, 8089);

                    f_78_7997_8088(ref _mvidField, f_78_8041_8081(this, mvidType), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(78, 7899, 8104);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 8120, 8162);

                f_78_8120_8161(f_78_8133_8148(_mvidField) == mvidType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 8176, 8194);

                return _mvidField;
                DynAbs.Tracing.TraceSender.TraceExitMethod(78, 7798, 8205);

                bool
                f_78_7968_7977_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(78, 7968, 7977);
                    return return_v;
                }


                int
                f_78_7955_7978(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 7955, 7978);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.ModuleVersionIdField
                f_78_8041_8081(Microsoft.CodeAnalysis.CodeGen.PrivateImplementationDetails
                containingType, Microsoft.Cci.ITypeReference
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CodeGen.ModuleVersionIdField((Microsoft.Cci.INamedTypeDefinition)containingType, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 8041, 8081);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CodeGen.ModuleVersionIdField?
                f_78_7997_8088(ref Microsoft.CodeAnalysis.CodeGen.ModuleVersionIdField?
                location1, Microsoft.CodeAnalysis.CodeGen.ModuleVersionIdField
                value, Microsoft.CodeAnalysis.CodeGen.ModuleVersionIdField?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 7997, 8088);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_78_8133_8148(Microsoft.CodeAnalysis.CodeGen.ModuleVersionIdField
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(78, 8133, 8148);
                    return return_v;
                }


                int
                f_78_8120_8161(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 8120, 8161);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 7798, 8205);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 7798, 8205);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Cci.IFieldReference GetOrAddInstrumentationPayloadRoot(int analysisKind, Cci.ITypeReference payloadRootType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 8217, 8870);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 8359, 8409);

                InstrumentationPayloadRootField?
                payloadRootField
                = default(InstrumentationPayloadRootField?);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 8423, 8750) || true) && (!f_78_8428_8509(_instrumentationPayloadRootFields, analysisKind, out payloadRootField))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(78, 8423, 8750);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 8543, 8567);

                    f_78_8543_8566(f_78_8556_8565_M(!IsFrozen));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 8585, 8735);

                    payloadRootField = f_78_8604_8734(_instrumentationPayloadRootFields, analysisKind, kind => new InstrumentationPayloadRootField(this, kind, payloadRootType));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(78, 8423, 8750);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 8766, 8821);

                f_78_8766_8820(f_78_8779_8800(payloadRootField) == payloadRootType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 8835, 8859);

                return payloadRootField;
                DynAbs.Tracing.TraceSender.TraceExitMethod(78, 8217, 8870);

                bool
                f_78_8428_8509(System.Collections.Concurrent.ConcurrentDictionary<int, Microsoft.CodeAnalysis.CodeGen.InstrumentationPayloadRootField>
                this_param, int
                key, out Microsoft.CodeAnalysis.CodeGen.InstrumentationPayloadRootField?
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 8428, 8509);
                    return return_v;
                }


                bool
                f_78_8556_8565_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(78, 8556, 8565);
                    return return_v;
                }


                int
                f_78_8543_8566(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 8543, 8566);
                    return 0;
                }


                Microsoft.CodeAnalysis.CodeGen.InstrumentationPayloadRootField
                f_78_8604_8734(System.Collections.Concurrent.ConcurrentDictionary<int, Microsoft.CodeAnalysis.CodeGen.InstrumentationPayloadRootField>
                this_param, int
                key, System.Func<int, Microsoft.CodeAnalysis.CodeGen.InstrumentationPayloadRootField>
                valueFactory)
                {
                    var return_v = this_param.GetOrAdd(key, valueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 8604, 8734);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_78_8779_8800(Microsoft.CodeAnalysis.CodeGen.InstrumentationPayloadRootField
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(78, 8779, 8800);
                    return return_v;
                }


                int
                f_78_8766_8820(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 8766, 8820);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 8217, 8870);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 8217, 8870);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IOrderedEnumerable<KeyValuePair<int, InstrumentationPayloadRootField>> GetInstrumentationPayloadRoots()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 8958, 9218);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 9095, 9118);

                f_78_9095_9117(f_78_9108_9116());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 9132, 9207);

                return f_78_9139_9206(_instrumentationPayloadRootFields, analysis => analysis.Key);
                DynAbs.Tracing.TraceSender.TraceExitMethod(78, 8958, 9218);

                bool
                f_78_9108_9116()
                {
                    var return_v = IsFrozen;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(78, 9108, 9116);
                    return return_v;
                }


                int
                f_78_9095_9117(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 9095, 9117);
                    return 0;
                }


                System.Linq.IOrderedEnumerable<System.Collections.Generic.KeyValuePair<int, Microsoft.CodeAnalysis.CodeGen.InstrumentationPayloadRootField>>
                f_78_9139_9206(System.Collections.Concurrent.ConcurrentDictionary<int, Microsoft.CodeAnalysis.CodeGen.InstrumentationPayloadRootField>
                source, System.Func<System.Collections.Generic.KeyValuePair<int, Microsoft.CodeAnalysis.CodeGen.InstrumentationPayloadRootField>, int>
                keySelector)
                {
                    var return_v = source.OrderBy<System.Collections.Generic.KeyValuePair<int, Microsoft.CodeAnalysis.CodeGen.InstrumentationPayloadRootField>, int>(keySelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 9139, 9206);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 8958, 9218);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 8958, 9218);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool TryAddSynthesizedMethod(Cci.IMethodDefinition method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 9328, 9637);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 9420, 9444);

                f_78_9420_9443(f_78_9433_9442_M(!IsFrozen));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 9553, 9608);

                return f_78_9560_9607(_synthesizedMethods, f_78_9587_9598(method), method);
                DynAbs.Tracing.TraceSender.TraceExitMethod(78, 9328, 9637);

                bool
                f_78_9433_9442_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(78, 9433, 9442);
                    return return_v;
                }


                int
                f_78_9420_9443(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 9420, 9443);
                    return 0;
                }


                string?
                f_78_9587_9598(Microsoft.Cci.IMethodDefinition
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(78, 9587, 9598);
                    return return_v;
                }


                bool
                f_78_9560_9607(System.Collections.Concurrent.ConcurrentDictionary<string, Microsoft.Cci.IMethodDefinition>
                this_param, string?
                key, Microsoft.Cci.IMethodDefinition
                value)
                {
                    var return_v = this_param.TryAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 9560, 9607);
                    return return_v;
                }

#nullable enable
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 9328, 9637);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 9328, 9637);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IEnumerable<Cci.IFieldDefinition> GetFields(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 9649, 9835);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 9754, 9777);

                f_78_9754_9776(f_78_9767_9775());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 9791, 9824);

                return _orderedSynthesizedFields;
                DynAbs.Tracing.TraceSender.TraceExitMethod(78, 9649, 9835);

                bool
                f_78_9767_9775()
                {
                    var return_v = IsFrozen;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(78, 9767, 9775);
                    return return_v;
                }


                int
                f_78_9754_9776(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 9754, 9776);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 9649, 9835);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 9649, 9835);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IEnumerable<Cci.IMethodDefinition> GetMethods(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 9847, 10036);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 9954, 9977);

                f_78_9954_9976(f_78_9967_9975());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 9991, 10025);

                return _orderedSynthesizedMethods;
                DynAbs.Tracing.TraceSender.TraceExitMethod(78, 9847, 10036);

                bool
                f_78_9967_9975()
                {
                    var return_v = IsFrozen;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(78, 9967, 9975);
                    return return_v;
                }


                int
                f_78_9954_9976(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 9954, 9976);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 9847, 10036);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 9847, 10036);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Cci.IMethodDefinition? GetMethod(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 10118, 10330);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 10197, 10227);

                Cci.IMethodDefinition?
                method
                = default(Cci.IMethodDefinition?);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 10241, 10291);

                f_78_10241_10290(_synthesizedMethods, name, out method);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 10305, 10319);

                return method;
                DynAbs.Tracing.TraceSender.TraceExitMethod(78, 10118, 10330);

                bool
                f_78_10241_10290(System.Collections.Concurrent.ConcurrentDictionary<string, Microsoft.Cci.IMethodDefinition>
                this_param, string
                key, out Microsoft.Cci.IMethodDefinition?
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 10241, 10290);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 10118, 10330);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 10118, 10330);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IEnumerable<Cci.INestedTypeDefinition> GetNestedTypes(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 10342, 10560);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 10457, 10480);

                f_78_10457_10479(f_78_10470_10478());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 10494, 10549);

                return _orderedProxyTypes.OfType<ExplicitSizeStruct>();
                DynAbs.Tracing.TraceSender.TraceExitMethod(78, 10342, 10560);

                bool
                f_78_10470_10478()
                {
                    var return_v = IsFrozen;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(78, 10470, 10478);
                    return return_v;
                }


                int
                f_78_10457_10479(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 10457, 10479);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 10342, 10560);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 10342, 10560);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 10606, 10618);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 10609, 10618);
                return f_78_10609_10618(this); DynAbs.Tracing.TraceSender.TraceExitMethod(78, 10606, 10618);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 10606, 10618);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 10606, 10618);
            }
            throw new System.Exception("Slicer error: unreachable code");

            string
            f_78_10609_10618(Microsoft.CodeAnalysis.CodeGen.PrivateImplementationDetails
            this_param)
            {
                var return_v = this_param.Name;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(78, 10609, 10618);
                return return_v;
            }

        }

        public override Cci.ITypeReference GetBaseClass(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 10700, 10716);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 10703, 10716);
                return _systemObject; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 10700, 10716);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 10700, 10716);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 10700, 10716);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IEnumerable<Cci.ICustomAttribute> GetAttributes(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 10729, 11102);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 10838, 11005) || true) && (_compilerGeneratedAttribute != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(78, 10838, 11005);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 10911, 10990);

                    return f_78_10918_10989(_compilerGeneratedAttribute);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(78, 10838, 11005);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 11021, 11091);

                return f_78_11028_11090();
                DynAbs.Tracing.TraceSender.TraceExitMethod(78, 10729, 11102);

                System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
                f_78_10918_10989(Microsoft.Cci.ICustomAttribute
                value)
                {
                    var return_v = SpecializedCollections.SingletonEnumerable(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 10918, 10989);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
                f_78_11028_11090()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<Cci.ICustomAttribute>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 11028, 11090);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 10729, 11102);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 10729, 11102);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void Dispatch(Cci.MetadataVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 11114, 11228);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 11197, 11217);

                f_78_11197_11216(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(78, 11114, 11228);

                int
                f_78_11197_11216(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.CodeAnalysis.CodeGen.PrivateImplementationDetails
                namespaceTypeDefinition)
                {
                    this_param.Visit((Microsoft.Cci.INamespaceTypeDefinition)namespaceTypeDefinition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 11197, 11216);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 11114, 11228);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 11114, 11228);
            }
        }

        public override Cci.INamespaceTypeDefinition AsNamespaceTypeDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 11332, 11339);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 11335, 11339);
                return this; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 11332, 11339);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 11332, 11339);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 11332, 11339);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Cci.INamespaceTypeReference AsNamespaceTypeReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 11421, 11428);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 11424, 11428);
                    return this; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 11421, 11428);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 11421, 11428);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 11421, 11428);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 11460, 11468);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 11463, 11468);
                    return _name; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 11460, 11468);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 11460, 11468);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 11460, 11468);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsPublic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 11502, 11510);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 11505, 11510);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 11502, 11510);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 11502, 11510);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 11502, 11510);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Cci.IUnitReference GetUnit(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 11523, 11696);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 11602, 11649);

                f_78_11602_11648(context.Module == _moduleBuilder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 11663, 11685);

                return _moduleBuilder;
                DynAbs.Tracing.TraceSender.TraceExitMethod(78, 11523, 11696);

                int
                f_78_11602_11648(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 11602, 11648);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 11523, 11696);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 11523, 11696);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string NamespaceName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 11736, 11751);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 11739, 11751);
                    return string.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 11736, 11751);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 11736, 11751);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 11736, 11751);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static string GenerateDataFieldName(ImmutableArray<byte> data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(78, 11764, 12198);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 11860, 11921);

                var
                hash = f_78_11871_11920(data)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 11935, 11972);

                char[]
                c = new char[hash.Length * 2]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 11986, 11996);

                int
                i = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 12010, 12150);
                    foreach (var b in f_78_12028_12032_I(hash))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(78, 12010, 12150);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 12066, 12091);

                        c[i++] = f_78_12075_12090(b >> 4);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 12109, 12135);

                        c[i++] = f_78_12118_12134(b & 0xF);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(78, 12010, 12150);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(78, 1, 141);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(78, 1, 141);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 12166, 12187);

                return f_78_12173_12186(c);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(78, 11764, 12198);

                System.Collections.Immutable.ImmutableArray<byte>
                f_78_11871_11920(System.Collections.Immutable.ImmutableArray<byte>
                bytes)
                {
                    var return_v = CryptographicHashProvider.ComputeSourceHash(bytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 11871, 11920);
                    return return_v;
                }


                char
                f_78_12075_12090(int
                x)
                {
                    var return_v = Hexchar(x);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 12075, 12090);
                    return return_v;
                }


                char
                f_78_12118_12134(int
                x)
                {
                    var return_v = Hexchar(x);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 12118, 12134);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<byte>
                f_78_12028_12032_I(System.Collections.Immutable.ImmutableArray<byte>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 12028, 12032);
                    return return_v;
                }


                string
                f_78_12173_12186(char[]
                value)
                {
                    var return_v = new string(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 12173, 12186);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 11764, 12198);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 11764, 12198);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static char Hexchar(int x)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 12258, 12308);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 12261, 12308);
                return (char)((DynAbs.Tracing.TraceSender.Conditional_F1(78, 12268, 12276) || (((x <= 9) && DynAbs.Tracing.TraceSender.Conditional_F2(78, 12279, 12288)) || DynAbs.Tracing.TraceSender.Conditional_F3(78, 12291, 12307))) ? (x + '0') : (x + ('A' - 10))); DynAbs.Tracing.TraceSender.TraceExitMethod(78, 12258, 12308);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 12258, 12308);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 12258, 12308);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private sealed class FieldComparer : IComparer<SynthesizedStaticField>
        {
            public static readonly FieldComparer Instance;

            private FieldComparer()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(78, 12500, 12553);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(78, 12500, 12553);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 12500, 12553);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 12500, 12553);
                }
            }

            public int Compare(SynthesizedStaticField? x, SynthesizedStaticField? y)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 12569, 12930);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 12674, 12721);

                    f_78_12674_12720(x is object && (DynAbs.Tracing.TraceSender.Expression_True(78, 12693, 12719) && y is object));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 12812, 12865);

                    f_78_12812_12864(f_78_12831_12837(x) != null && (DynAbs.Tracing.TraceSender.Expression_True(78, 12831, 12863) && f_78_12849_12855(y) != null));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 12883, 12915);

                    return f_78_12890_12914(f_78_12890_12896(x), f_78_12907_12913(y));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(78, 12569, 12930);

                    int
                    f_78_12674_12720(bool
                    b)
                    {
                        RoslynDebug.Assert(b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 12674, 12720);
                        return 0;
                    }


                    string
                    f_78_12831_12837(Microsoft.CodeAnalysis.CodeGen.SynthesizedStaticField
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(78, 12831, 12837);
                        return return_v;
                    }


                    string
                    f_78_12849_12855(Microsoft.CodeAnalysis.CodeGen.SynthesizedStaticField
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(78, 12849, 12855);
                        return return_v;
                    }


                    int
                    f_78_12812_12864(bool
                    b)
                    {
                        RoslynDebug.Assert(b);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 12812, 12864);
                        return 0;
                    }


                    string
                    f_78_12890_12896(Microsoft.CodeAnalysis.CodeGen.SynthesizedStaticField
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(78, 12890, 12896);
                        return return_v;
                    }


                    string
                    f_78_12907_12913(Microsoft.CodeAnalysis.CodeGen.SynthesizedStaticField
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(78, 12907, 12913);
                        return return_v;
                    }


                    int
                    f_78_12890_12914(string
                    this_param, string
                    strB)
                    {
                        var return_v = this_param.CompareTo(strB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 12890, 12914);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 12569, 12930);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 12569, 12930);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static FieldComparer()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(78, 12321, 12941);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 12453, 12483);
                Instance = f_78_12464_12483(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(78, 12321, 12941);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 12321, 12941);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(78, 12321, 12941);

            static Microsoft.CodeAnalysis.CodeGen.PrivateImplementationDetails.FieldComparer
            f_78_12464_12483()
            {
                var return_v = new Microsoft.CodeAnalysis.CodeGen.PrivateImplementationDetails.FieldComparer();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 12464, 12483);
                return return_v;
            }

        }

        static PrivateImplementationDetails()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(78, 930, 12948);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 1256, 1311);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(78, 930, 12948);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 930, 12948);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(78, 930, 12948);

        System.Collections.Concurrent.ConcurrentDictionary<System.Collections.Immutable.ImmutableArray<byte>, Microsoft.CodeAnalysis.CodeGen.MappedField>
        f_78_2483_2573(Microsoft.CodeAnalysis.Collections.ByteSequenceComparer
        comparer)
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<System.Collections.Immutable.ImmutableArray<byte>, Microsoft.CodeAnalysis.CodeGen.MappedField>((System.Collections.Generic.IEqualityComparer<System.Collections.Immutable.ImmutableArray<byte>>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 2483, 2573);
            return return_v;
        }


        System.Collections.Concurrent.ConcurrentDictionary<int, Microsoft.CodeAnalysis.CodeGen.InstrumentationPayloadRootField>
        f_78_2835_2899()
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<int, Microsoft.CodeAnalysis.CodeGen.InstrumentationPayloadRootField>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 2835, 2899);
            return return_v;
        }


        System.Collections.Concurrent.ConcurrentDictionary<string, Microsoft.Cci.IMethodDefinition>
        f_78_3131_3188()
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<string, Microsoft.Cci.IMethodDefinition>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 3131, 3188);
            return return_v;
        }


        System.Collections.Concurrent.ConcurrentDictionary<uint, Microsoft.Cci.ITypeReference>
        f_78_3402_3454()
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<uint, Microsoft.Cci.ITypeReference>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 3402, 3454);
            return return_v;
        }


        static int
        f_78_4002_4042(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 4002, 4042);
            return 0;
        }


        static int
        f_78_4057_4100(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 4057, 4100);
            return 0;
        }


        static string
        f_78_4614_4672(string
        moduleName, int
        submissionSlotIndex, bool
        isNetModule)
        {
            var return_v = GetClassName(moduleName, submissionSlotIndex, isNetModule);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 4614, 4672);
            return return_v;
        }

    }
    internal sealed class ExplicitSizeStruct : DefaultTypeDef, Cci.INestedTypeDefinition
    {
        private readonly uint _size;

        private readonly Cci.INamedTypeDefinition _containingType;

        private readonly Cci.ITypeReference _sysValueType;

        internal ExplicitSizeStruct(uint size, PrivateImplementationDetails containingType, Cci.ITypeReference sysValueType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(78, 13327, 13582);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 13181, 13186);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 13239, 13254);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 13301, 13314);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 13468, 13481);

                _size = size;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 13495, 13528);

                _containingType = containingType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 13542, 13571);

                _sysValueType = sysValueType;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(78, 13327, 13582);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 13327, 13582);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 13327, 13582);
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 13641, 13688);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 13644, 13688);
                return f_78_13644_13670(_containingType) + "." + f_78_13679_13688(this); DynAbs.Tracing.TraceSender.TraceExitMethod(78, 13641, 13688);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 13641, 13688);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 13641, 13688);
            }
            throw new System.Exception("Slicer error: unreachable code");

            string?
            f_78_13644_13670(Microsoft.Cci.INamedTypeDefinition
            this_param)
            {
                var return_v = this_param.ToString();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 13644, 13670);
                return return_v;
            }


            string
            f_78_13679_13688(Microsoft.CodeAnalysis.CodeGen.ExplicitSizeStruct
            this_param)
            {
                var return_v = this_param.Name;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(78, 13679, 13688);
                return return_v;
            }

        }

        public override ushort Alignment
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 13734, 13738);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 13737, 13738);
                    return 1; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 13734, 13738);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 13734, 13738);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 13734, 13738);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Cci.ITypeReference GetBaseClass(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 13820, 13836);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 13823, 13836);
                return _sysValueType; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 13820, 13836);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 13820, 13836);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 13820, 13836);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override LayoutKind Layout
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 13883, 13905);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 13886, 13905);
                    return LayoutKind.Explicit; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 13883, 13905);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 13883, 13905);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 13883, 13905);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override uint SizeOf
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 13946, 13954);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 13949, 13954);
                    return _size; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 13946, 13954);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 13946, 13954);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 13946, 13954);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override void Dispatch(Cci.MetadataVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 13967, 14081);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 14050, 14070);

                f_78_14050_14069(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(78, 13967, 14081);

                int
                f_78_14050_14069(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.CodeAnalysis.CodeGen.ExplicitSizeStruct
                nestedTypeDefinition)
                {
                    this_param.Visit((Microsoft.Cci.INestedTypeDefinition)nestedTypeDefinition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 14050, 14069);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 13967, 14081);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 13967, 14081);
            }
        }

        public string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 14112, 14151);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 14115, 14151);
                    return "__StaticArrayInitTypeSize=" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (_size).ToString(), 78, 14146, 14151); DynAbs.Tracing.TraceSender.TraceExitMethod(78, 14112, 14151);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 14112, 14151);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 14112, 14151);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Cci.ITypeDefinition ContainingTypeDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 14216, 14234);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 14219, 14234);
                    return _containingType; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 14216, 14234);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 14216, 14234);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 14216, 14234);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Cci.TypeMemberVisibility Visibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 14290, 14325);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 14293, 14325);
                    return Cci.TypeMemberVisibility.Private; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 14290, 14325);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 14290, 14325);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 14290, 14325);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsValueType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 14371, 14378);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 14374, 14378);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 14371, 14378);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 14371, 14378);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 14371, 14378);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Cci.ITypeReference GetContainingType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 14456, 14474);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 14459, 14474);
                return _containingType; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 14456, 14474);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 14456, 14474);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 14456, 14474);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Cci.INestedTypeDefinition AsNestedTypeDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 14573, 14580);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 14576, 14580);
                return this; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 14573, 14580);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 14573, 14580);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 14573, 14580);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Cci.INestedTypeReference AsNestedTypeReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 14656, 14663);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 14659, 14663);
                    return this; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 14656, 14663);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 14656, 14663);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 14656, 14663);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static ExplicitSizeStruct()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(78, 13058, 14671);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(78, 13058, 14671);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 13058, 14671);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(78, 13058, 14671);
    }
    internal abstract class SynthesizedStaticField : Cci.IFieldDefinition
    {
        private readonly Cci.INamedTypeDefinition _containingType;

        private readonly Cci.ITypeReference _type;

        private readonly string _name;

        internal SynthesizedStaticField(string name, Cci.INamedTypeDefinition containingType, Cci.ITypeReference type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(78, 14927, 15313);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 14807, 14822);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 14869, 14874);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 14909, 14914);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 15062, 15095);

                f_78_15062_15094(name != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 15109, 15152);

                f_78_15109_15151(containingType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 15166, 15199);

                f_78_15166_15198(type != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 15215, 15248);

                _containingType = containingType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 15262, 15275);

                _type = type;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 15289, 15302);

                _name = name;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(78, 14927, 15313);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 14927, 15313);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 14927, 15313);
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 15359, 15488);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 15362, 15488);
                return $"{(object?)f_78_15374_15399(_type) ?? (DynAbs.Tracing.TraceSender.Expression_Null<object?>(78, 15365, 15408) ?? _type)} {(object?)f_78_15420_15455(_containingType) ?? (DynAbs.Tracing.TraceSender.Expression_Null<object?>(78, 15411, 15474) ?? _containingType)}.{f_78_15477_15486(this)}"; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 15359, 15488);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 15359, 15488);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 15359, 15488);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
            f_78_15374_15399(Microsoft.Cci.ITypeReference
            this_param)
            {
                var return_v = this_param.GetInternalSymbol();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 15374, 15399);
                return return_v;
            }


            Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
            f_78_15420_15455(Microsoft.Cci.INamedTypeDefinition
            this_param)
            {
                var return_v = this_param.GetInternalSymbol();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 15420, 15455);
                return return_v;
            }


            string
            f_78_15477_15486(Microsoft.CodeAnalysis.CodeGen.SynthesizedStaticField
            this_param)
            {
                var return_v = this_param.Name;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(78, 15477, 15486);
                return return_v;
            }

        }

        public MetadataConstant? GetCompileTimeValue(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 15567, 15574);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 15570, 15574);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 15567, 15574);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 15567, 15574);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 15567, 15574);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public abstract ImmutableArray<byte> MappedData { get; }

        public bool IsCompileTimeConstant
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 15689, 15697);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 15692, 15697);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 15689, 15697);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 15689, 15697);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 15689, 15697);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsNotSerialized
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 15738, 15746);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 15741, 15746);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 15738, 15746);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 15738, 15746);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 15738, 15746);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsReadOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 15782, 15789);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 15785, 15789);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 15782, 15789);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 15782, 15789);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 15782, 15789);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsRuntimeSpecial
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 15831, 15839);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 15834, 15839);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 15831, 15839);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 15831, 15839);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 15831, 15839);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 15878, 15886);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 15881, 15886);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 15878, 15886);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 15878, 15886);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 15878, 15886);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsStatic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 15920, 15927);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 15923, 15927);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 15920, 15927);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 15920, 15927);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 15920, 15927);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsMarshalledExplicitly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 15975, 15983);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 15978, 15983);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 15975, 15983);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 15975, 15983);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 15975, 15983);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Cci.IMarshallingInformation? MarshallingInformation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 16055, 16062);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 16058, 16062);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 16055, 16062);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 16055, 16062);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 16055, 16062);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<byte> MarshallingDescriptor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 16125, 16157);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 16128, 16157);
                    return default(ImmutableArray<byte>); DynAbs.Tracing.TraceSender.TraceExitMethod(78, 16125, 16157);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 16125, 16157);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 16125, 16157);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int Offset
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 16212, 16257);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 16218, 16255);

                    throw f_78_16224_16254();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(78, 16212, 16257);

                    System.Exception
                    f_78_16224_16254()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(78, 16224, 16254);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 16170, 16268);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 16170, 16268);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Cci.ITypeDefinition ContainingTypeDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 16332, 16350);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 16335, 16350);
                    return _containingType; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 16332, 16350);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 16332, 16350);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 16332, 16350);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Cci.TypeMemberVisibility Visibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 16406, 16442);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 16409, 16442);
                    return Cci.TypeMemberVisibility.Assembly; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 16406, 16442);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 16406, 16442);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 16406, 16442);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Cci.ITypeReference GetContainingType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 16520, 16538);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 16523, 16538);
                return _containingType; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 16520, 16538);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 16520, 16538);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 16520, 16538);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<Cci.ICustomAttribute> GetAttributes(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 16640, 16705);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 16643, 16705);
                return f_78_16643_16705(); DynAbs.Tracing.TraceSender.TraceExitMethod(78, 16640, 16705);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 16640, 16705);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 16640, 16705);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
            f_78_16643_16705()
            {
                var return_v = SpecializedCollections.EmptyEnumerable<Cci.ICustomAttribute>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 16643, 16705);
                return return_v;
            }

        }

        public void Dispatch(Cci.MetadataVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 16718, 16823);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 16792, 16812);

                f_78_16792_16811(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(78, 16718, 16823);

                int
                f_78_16792_16811(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.CodeAnalysis.CodeGen.SynthesizedStaticField
                fieldDefinition)
                {
                    this_param.Visit((Microsoft.Cci.IFieldDefinition)fieldDefinition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 16792, 16811);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 16718, 16823);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 16718, 16823);
            }
        }

        public Cci.IDefinition AsDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 16835, 16964);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 16916, 16953);

                throw f_78_16922_16952();
                DynAbs.Tracing.TraceSender.TraceExitMethod(78, 16835, 16964);

                System.Exception
                f_78_16922_16952()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(78, 16922, 16952);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 16835, 16964);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 16835, 16964);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Symbols.ISymbolInternal? Cci.IReference.GetInternalSymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 17036, 17043);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 17039, 17043);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 17036, 17043);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 17036, 17043);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 17036, 17043);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 17075, 17083);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 17078, 17083);
                    return _name; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 17075, 17083);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 17075, 17083);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 17075, 17083);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsContextualNamedEntity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 17132, 17140);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 17135, 17140);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 17132, 17140);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 17132, 17140);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 17132, 17140);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Cci.ITypeReference GetType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 17208, 17216);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 17211, 17216);
                return _type; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 17208, 17216);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 17208, 17216);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 17208, 17216);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Cci.ITypeReference Type
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 17262, 17270);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 17265, 17270);
                    return _type; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 17262, 17270);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 17262, 17270);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 17262, 17270);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Cci.IFieldDefinition GetResolvedField(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 17349, 17356);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 17352, 17356);
                return this; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 17349, 17356);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 17349, 17356);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 17349, 17356);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Cci.ISpecializedFieldReference? AsSpecializedFieldReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 17436, 17443);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 17439, 17443);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 17436, 17443);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 17436, 17443);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 17436, 17443);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public MetadataConstant Constant
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 17513, 17558);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 17519, 17556);

                    throw f_78_17525_17555();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(78, 17513, 17558);

                    System.Exception
                    f_78_17525_17555()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(78, 17525, 17555);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 17456, 17569);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 17456, 17569);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 17581, 17861);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 17796, 17850);

                throw f_78_17802_17849();
                DynAbs.Tracing.TraceSender.TraceExitMethod(78, 17581, 17861);

                System.Exception
                f_78_17802_17849()
                {
                    var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(78, 17802, 17849);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 17581, 17861);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 17581, 17861);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 17873, 18146);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 18081, 18135);

                throw f_78_18087_18134();
                DynAbs.Tracing.TraceSender.TraceExitMethod(78, 17873, 18146);

                System.Exception
                f_78_18087_18134()
                {
                    var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(78, 18087, 18134);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 17873, 18146);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 17873, 18146);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SynthesizedStaticField()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(78, 14679, 18153);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(78, 14679, 18153);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 14679, 18153);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(78, 14679, 18153);

        static int
        f_78_15062_15094(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 15062, 15094);
            return 0;
        }


        static int
        f_78_15109_15151(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 15109, 15151);
            return 0;
        }


        static int
        f_78_15166_15198(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 15166, 15198);
            return 0;
        }

    }
    internal sealed class ModuleVersionIdField : SynthesizedStaticField
    {
        internal ModuleVersionIdField(Cci.INamedTypeDefinition containingType, Cci.ITypeReference type)
        : base(f_78_18361_18367_C("MVID"), containingType, type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(78, 18245, 18412);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(78, 18245, 18412);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 18245, 18412);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 18245, 18412);
            }
        }

        public override ImmutableArray<byte> MappedData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 18472, 18504);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 18475, 18504);
                    return default(ImmutableArray<byte>); DynAbs.Tracing.TraceSender.TraceExitMethod(78, 18472, 18504);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 18472, 18504);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 18472, 18504);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static ModuleVersionIdField()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(78, 18161, 18512);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(78, 18161, 18512);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 18161, 18512);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(78, 18161, 18512);

        static string
        f_78_18361_18367_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(78, 18245, 18412);
            return return_v;
        }

    }
    internal sealed class InstrumentationPayloadRootField : SynthesizedStaticField
    {
        internal InstrumentationPayloadRootField(Cci.INamedTypeDefinition containingType, int analysisIndex, Cci.ITypeReference payloadType)
        : base(f_78_18768_18808_C("PayloadRoot" + f_78_18784_18808(analysisIndex)), containingType, payloadType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(78, 18615, 18860);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(78, 18615, 18860);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 18615, 18860);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 18615, 18860);
            }
        }

        public override ImmutableArray<byte> MappedData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 18920, 18952);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 18923, 18952);
                    return default(ImmutableArray<byte>); DynAbs.Tracing.TraceSender.TraceExitMethod(78, 18920, 18952);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 18920, 18952);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 18920, 18952);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static InstrumentationPayloadRootField()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(78, 18520, 18960);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(78, 18520, 18960);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 18520, 18960);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(78, 18520, 18960);

        static string
        f_78_18784_18808(int
        this_param)
        {
            var return_v = this_param.ToString();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 18784, 18808);
            return return_v;
        }


        static string
        f_78_18768_18808_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(78, 18615, 18860);
            return return_v;
        }

    }
    internal sealed class MappedField : SynthesizedStaticField
    {
        private readonly ImmutableArray<byte> _block;

        internal MappedField(string name, Cci.INamedTypeDefinition containingType, Cci.ITypeReference type, ImmutableArray<byte> block)
        : base(f_78_19352_19356_C(name), containingType, type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(78, 19204, 19477);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 19404, 19435);

                f_78_19404_19434(f_78_19417_19433_M(!block.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 19451, 19466);

                _block = block;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(78, 19204, 19477);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 19204, 19477);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 19204, 19477);
            }
        }

        public override ImmutableArray<byte> MappedData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 19537, 19546);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 19540, 19546);
                    return _block; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 19537, 19546);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 19537, 19546);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 19537, 19546);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static MappedField()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(78, 19072, 19554);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(78, 19072, 19554);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 19072, 19554);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(78, 19072, 19554);

        bool
        f_78_19417_19433_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(78, 19417, 19433);
            return return_v;
        }


        static int
        f_78_19404_19434(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 19404, 19434);
            return 0;
        }


        static string
        f_78_19352_19356_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(78, 19204, 19477);
            return return_v;
        }

    }
    internal abstract class DefaultTypeDef : Cci.ITypeDefinition
    {
        public IEnumerable<Cci.IEventDefinition> GetEvents(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 19824, 19889);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 19827, 19889);
                return f_78_19827_19889(); DynAbs.Tracing.TraceSender.TraceExitMethod(78, 19824, 19889);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 19824, 19889);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 19824, 19889);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Generic.IEnumerable<Microsoft.Cci.IEventDefinition>
            f_78_19827_19889()
            {
                var return_v = SpecializedCollections.EmptyEnumerable<Cci.IEventDefinition>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 19827, 19889);
                return return_v;
            }

        }

        public IEnumerable<Cci.MethodImplementation> GetExplicitImplementationOverrides(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 20016, 20085);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 20019, 20085);
                return f_78_20019_20085(); DynAbs.Tracing.TraceSender.TraceExitMethod(78, 20016, 20085);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 20016, 20085);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 20016, 20085);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Generic.IEnumerable<Microsoft.Cci.MethodImplementation>
            f_78_20019_20085()
            {
                var return_v = SpecializedCollections.EmptyEnumerable<Cci.MethodImplementation>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 20019, 20085);
                return return_v;
            }

        }

        public virtual IEnumerable<Cci.IFieldDefinition> GetFields(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 20191, 20256);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 20194, 20256);
                return f_78_20194_20256(); DynAbs.Tracing.TraceSender.TraceExitMethod(78, 20191, 20256);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 20191, 20256);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 20191, 20256);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Generic.IEnumerable<Microsoft.Cci.IFieldDefinition>
            f_78_20194_20256()
            {
                var return_v = SpecializedCollections.EmptyEnumerable<Cci.IFieldDefinition>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 20194, 20256);
                return return_v;
            }

        }

        public IEnumerable<Cci.IGenericTypeParameter> GenericParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 20346, 20416);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 20349, 20416);
                    return f_78_20349_20416(); DynAbs.Tracing.TraceSender.TraceExitMethod(78, 20346, 20416);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 20346, 20416);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 20346, 20416);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ushort GenericParameterCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 20465, 20469);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 20468, 20469);
                    return 0; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 20465, 20469);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 20465, 20469);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 20465, 20469);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool HasDeclarativeSecurity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 20517, 20525);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 20520, 20525);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 20517, 20525);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 20517, 20525);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 20517, 20525);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IEnumerable<Cci.TypeReferenceWithAttributes> Interfaces(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 20635, 20711);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 20638, 20711);
                return f_78_20638_20711(); DynAbs.Tracing.TraceSender.TraceExitMethod(78, 20635, 20711);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 20635, 20711);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 20635, 20711);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Generic.IEnumerable<Microsoft.Cci.TypeReferenceWithAttributes>
            f_78_20638_20711()
            {
                var return_v = SpecializedCollections.EmptyEnumerable<Cci.TypeReferenceWithAttributes>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 20638, 20711);
                return return_v;
            }

        }

        public bool IsAbstract
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 20747, 20755);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 20750, 20755);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 20747, 20755);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 20747, 20755);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 20747, 20755);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsBeforeFieldInit
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 20798, 20806);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 20801, 20806);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 20798, 20806);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 20798, 20806);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 20798, 20806);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsComObject
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 20843, 20851);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 20846, 20851);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 20843, 20851);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 20843, 20851);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 20843, 20851);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsGeneric
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 20886, 20894);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 20889, 20894);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 20886, 20894);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 20886, 20894);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 20886, 20894);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsInterface
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 20931, 20939);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 20934, 20939);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 20931, 20939);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 20931, 20939);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 20931, 20939);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsDelegate
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 20975, 20983);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 20978, 20983);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 20975, 20983);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 20975, 20983);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 20975, 20983);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsRuntimeSpecial
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 21025, 21033);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 21028, 21033);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 21025, 21033);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 21025, 21033);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 21025, 21033);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsSerializable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 21073, 21081);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 21076, 21081);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 21073, 21081);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 21073, 21081);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 21073, 21081);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 21120, 21128);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 21123, 21128);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 21120, 21128);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 21120, 21128);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 21120, 21128);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsWindowsRuntimeImport
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 21176, 21184);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 21179, 21184);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 21176, 21184);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 21176, 21184);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 21176, 21184);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsSealed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 21218, 21225);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 21221, 21225);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 21218, 21225);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 21218, 21225);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 21218, 21225);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual IEnumerable<Cci.IMethodDefinition> GetMethods(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 21333, 21399);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 21336, 21399);
                return f_78_21336_21399(); DynAbs.Tracing.TraceSender.TraceExitMethod(78, 21333, 21399);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 21333, 21399);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 21333, 21399);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Generic.IEnumerable<Microsoft.Cci.IMethodDefinition>
            f_78_21336_21399()
            {
                var return_v = SpecializedCollections.EmptyEnumerable<Cci.IMethodDefinition>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 21336, 21399);
                return return_v;
            }

        }

        public virtual IEnumerable<Cci.INestedTypeDefinition> GetNestedTypes(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 21515, 21585);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 21518, 21585);
                return f_78_21518_21585(); DynAbs.Tracing.TraceSender.TraceExitMethod(78, 21515, 21585);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 21515, 21585);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 21515, 21585);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Generic.IEnumerable<Microsoft.Cci.INestedTypeDefinition>
            f_78_21518_21585()
            {
                var return_v = SpecializedCollections.EmptyEnumerable<Cci.INestedTypeDefinition>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 21518, 21585);
                return return_v;
            }

        }

        public IEnumerable<Cci.IPropertyDefinition> GetProperties(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 21690, 21758);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 21693, 21758);
                return f_78_21693_21758(); DynAbs.Tracing.TraceSender.TraceExitMethod(78, 21690, 21758);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 21690, 21758);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 21690, 21758);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Generic.IEnumerable<Microsoft.Cci.IPropertyDefinition>
            f_78_21693_21758()
            {
                var return_v = SpecializedCollections.EmptyEnumerable<Cci.IPropertyDefinition>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 21693, 21758);
                return return_v;
            }

        }

        public IEnumerable<Cci.SecurityAttribute> SecurityAttributes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 21845, 21911);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 21848, 21911);
                    return f_78_21848_21911(); DynAbs.Tracing.TraceSender.TraceExitMethod(78, 21845, 21911);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 21845, 21911);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 21845, 21911);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public CharSet StringFormat
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 21952, 21967);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 21955, 21967);
                    return CharSet.Ansi; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 21952, 21967);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 21952, 21967);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 21952, 21967);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual IEnumerable<Cci.ICustomAttribute> GetAttributes(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 22077, 22142);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 22080, 22142);
                return f_78_22080_22142(); DynAbs.Tracing.TraceSender.TraceExitMethod(78, 22077, 22142);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 22077, 22142);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 22077, 22142);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
            f_78_22080_22142()
            {
                var return_v = SpecializedCollections.EmptyEnumerable<Cci.ICustomAttribute>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 22080, 22142);
                return return_v;
            }

        }

        public Cci.IDefinition AsDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 22212, 22219);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 22215, 22219);
                return this; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 22212, 22219);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 22212, 22219);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 22212, 22219);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Symbols.ISymbolInternal? Cci.IReference.GetInternalSymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 22292, 22299);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 22295, 22299);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 22292, 22299);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 22292, 22299);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 22292, 22299);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool IsEnum
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 22331, 22339);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 22334, 22339);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 22331, 22339);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 22331, 22339);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 22331, 22339);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Cci.ITypeDefinition GetResolvedType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 22416, 22423);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 22419, 22423);
                return this; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 22416, 22423);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 22416, 22423);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 22416, 22423);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Cci.PrimitiveTypeCode TypeCode
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 22474, 22511);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 22477, 22511);
                    return Cci.PrimitiveTypeCode.NotPrimitive; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 22474, 22511);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 22474, 22511);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 22474, 22511);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public TypeDefinitionHandle TypeDef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 22584, 22629);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 22590, 22627);

                    throw f_78_22596_22626();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(78, 22584, 22629);

                    System.Exception
                    f_78_22596_22626()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(78, 22596, 22626);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 22524, 22640);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 22524, 22640);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Cci.IGenericMethodParameterReference? AsGenericMethodParameterReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 22731, 22738);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 22734, 22738);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 22731, 22738);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 22731, 22738);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 22731, 22738);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Cci.IGenericTypeInstanceReference? AsGenericTypeInstanceReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 22824, 22831);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 22827, 22831);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 22824, 22831);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 22824, 22831);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 22824, 22831);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Cci.IGenericTypeParameterReference? AsGenericTypeParameterReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 22919, 22926);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 22922, 22926);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 22919, 22926);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 22919, 22926);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 22919, 22926);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual Cci.INamespaceTypeDefinition? AsNamespaceTypeDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 23031, 23038);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 23034, 23038);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 23031, 23038);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 23031, 23038);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 23031, 23038);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual Cci.INamespaceTypeReference? AsNamespaceTypeReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 23120, 23127);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 23123, 23127);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 23120, 23127);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 23120, 23127);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 23120, 23127);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Cci.ISpecializedNestedTypeReference? AsSpecializedNestedTypeReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 23217, 23224);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 23220, 23224);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 23217, 23224);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 23217, 23224);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 23217, 23224);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual Cci.INestedTypeDefinition? AsNestedTypeDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 23323, 23330);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 23326, 23330);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 23323, 23330);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 23323, 23330);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 23323, 23330);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual Cci.INestedTypeReference? AsNestedTypeReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 23406, 23413);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 23409, 23413);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 23406, 23413);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 23406, 23413);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 23406, 23413);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Cci.ITypeDefinition AsTypeDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 23491, 23498);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 23494, 23498);
                return this; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 23491, 23498);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 23491, 23498);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 23491, 23498);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool MangleName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 23534, 23542);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 23537, 23542);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 23534, 23542);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 23534, 23542);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 23534, 23542);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual ushort Alignment
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 23587, 23591);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 23590, 23591);
                    return 0; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 23587, 23591);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 23587, 23591);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 23587, 23591);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual Cci.ITypeReference GetBaseClass(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 23604, 23744);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 23696, 23733);

                throw f_78_23702_23732();
                DynAbs.Tracing.TraceSender.TraceExitMethod(78, 23604, 23744);

                System.Exception
                f_78_23702_23732()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(78, 23702, 23732);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 23604, 23744);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 23604, 23744);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual LayoutKind Layout
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 23789, 23807);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 23792, 23807);
                    return LayoutKind.Auto; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 23789, 23807);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 23789, 23807);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 23789, 23807);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual uint SizeOf
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 23847, 23851);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 23850, 23851);
                    return 0; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 23847, 23851);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 23847, 23851);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 23847, 23851);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual void Dispatch(Cci.MetadataVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 23864, 23994);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 23946, 23983);

                throw f_78_23952_23982();
                DynAbs.Tracing.TraceSender.TraceExitMethod(78, 23864, 23994);

                System.Exception
                f_78_23952_23982()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(78, 23952, 23982);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 23864, 23994);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 23864, 23994);
            }
        }

        public virtual bool IsValueType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 24038, 24046);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 24041, 24046);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(78, 24038, 24046);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 24038, 24046);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 24038, 24046);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 24059, 24339);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 24274, 24328);

                throw f_78_24280_24327();
                DynAbs.Tracing.TraceSender.TraceExitMethod(78, 24059, 24339);

                System.Exception
                f_78_24280_24327()
                {
                    var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(78, 24280, 24327);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 24059, 24339);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 24059, 24339);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(78, 24351, 24624);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(78, 24559, 24613);

                throw f_78_24565_24612();
                DynAbs.Tracing.TraceSender.TraceExitMethod(78, 24351, 24624);

                System.Exception
                f_78_24565_24612()
                {
                    var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(78, 24565, 24612);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(78, 24351, 24624);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 24351, 24624);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public DefaultTypeDef()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(78, 19662, 24631);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(78, 19662, 24631);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 19662, 24631);
        }


        static DefaultTypeDef()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(78, 19662, 24631);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(78, 19662, 24631);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(78, 19662, 24631);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(78, 19662, 24631);

        System.Collections.Generic.IEnumerable<Microsoft.Cci.IGenericTypeParameter>
        f_78_20349_20416()
        {
            var return_v = SpecializedCollections.EmptyEnumerable<Cci.IGenericTypeParameter>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 20349, 20416);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<Microsoft.Cci.SecurityAttribute>
        f_78_21848_21911()
        {
            var return_v = SpecializedCollections.EmptyEnumerable<Cci.SecurityAttribute>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(78, 21848, 21911);
            return return_v;
        }

    }
}
