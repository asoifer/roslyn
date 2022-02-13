// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed partial class AnonymousTypeManager
    {
        internal sealed class NameAndIndex
        {
            public NameAndIndex(string name, int index)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10429, 740, 885);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 924, 928);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 963, 968);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 816, 833);

                    this.Name = name;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 851, 870);

                    this.Index = index;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10429, 740, 885);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 740, 885);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 740, 885);
                }
            }

            public readonly string Name;

            public readonly int Index;

            static NameAndIndex()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10429, 681, 980);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10429, 681, 980);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 681, 980);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10429, 681, 980);
        }
        internal sealed class AnonymousTypeTemplateSymbol : NamedTypeSymbol
        {
            private NameAndIndex _nameAndIndex;

            private readonly ImmutableArray<TypeParameterSymbol> _typeParameters;

            private readonly ImmutableArray<Symbol> _members;

            internal readonly ImmutableArray<MethodSymbol> SpecialMembers;

            internal readonly ImmutableArray<AnonymousTypePropertySymbol> Properties;

            private readonly MultiDictionary<string, Symbol> _nameToSymbols;

            internal readonly AnonymousTypeManager Manager;

            private Location _smallestLocation;

            internal readonly string TypeDescriptorKey;

            internal AnonymousTypeTemplateSymbol(AnonymousTypeManager manager, AnonymousTypeDescriptor typeDescr)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10429, 2756, 5721);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 1435, 1448);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 2148, 2202);
                    this._nameToSymbols = f_10429_2165_2202(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 2340, 2347);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 2588, 2605);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 2722, 2739);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 2890, 2913);

                    this.Manager = manager;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 2931, 2970);

                    this.TypeDescriptorKey = typeDescr.Key;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 2988, 3027);

                    _smallestLocation = typeDescr.Location;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 3245, 3266);

                    _nameAndIndex = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 3286, 3328);

                    int
                    fieldsCount = typeDescr.Fields.Length
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 3346, 3385);

                    int
                    membersCount = fieldsCount * 3 + 1
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 3433, 3501);

                    var
                    membersBuilder = f_10429_3454_3500(membersCount)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 3519, 3610);

                    var
                    propertiesBuilder = f_10429_3543_3609(fieldsCount)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 3628, 3715);

                    var
                    typeParametersBuilder = f_10429_3656_3714(fieldsCount)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 3779, 3793);

                        // Process fields
                        for (int
        fieldIndex = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 3770, 4745) || true) && (fieldIndex < fieldsCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 3821, 3833)
        , fieldIndex++, DynAbs.Tracing.TraceSender.TraceExitCondition(10429, 3770, 4745))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10429, 3770, 4745);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 3875, 3931);

                            AnonymousTypeField
                            field = typeDescr.Fields[fieldIndex]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 4000, 4180);

                            AnonymousTypeParameterSymbol
                            typeParameter =
                            f_10429_4070_4179(this, fieldIndex, f_10429_4121_4178(field.Name))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 4202, 4243);

                            f_10429_4202_4242(typeParametersBuilder, typeParameter);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 4306, 4445);

                            AnonymousTypePropertySymbol
                            property = f_10429_4345_4444(this, field, TypeWithAnnotations.Create(typeParameter), fieldIndex)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 4467, 4499);

                            f_10429_4467_4498(propertiesBuilder, property);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 4572, 4601);

                            f_10429_4572_4600(
                                                // Property related symbols
                                                membersBuilder, property);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 4623, 4665);

                            f_10429_4623_4664(membersBuilder, f_10429_4642_4663(property));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 4687, 4726);

                            f_10429_4687_4725(membersBuilder, f_10429_4706_4724(property));
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10429, 1, 976);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10429, 1, 976);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 4765, 4826);

                    _typeParameters = f_10429_4783_4825(typeParametersBuilder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 4844, 4901);

                    this.Properties = f_10429_4862_4900(propertiesBuilder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 4959, 5037);

                    f_10429_4959_5036(
                                    // Add a constructor
                                    membersBuilder, f_10429_4978_5035(this, this.Properties));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 5055, 5102);

                    _members = f_10429_5066_5101(membersBuilder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 5120, 5166);

                    f_10429_5120_5165(membersCount == _members.Length);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 5229, 5361);
                        foreach (var symbol in f_10429_5252_5260_I(_members))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10429, 5229, 5361);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 5302, 5342);

                            f_10429_5302_5341(_nameToSymbols, f_10429_5321_5332(symbol), symbol);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10429, 5229, 5361);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10429, 1, 133);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10429, 1, 133);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 5448, 5706);

                    this.SpecialMembers = f_10429_5470_5705(f_10429_5528_5569(this), f_10429_5592_5638(this), f_10429_5661_5704(this));
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10429, 2756, 5721);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 2756, 5721);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 2756, 5721);
                }
            }

            protected override NamedTypeSymbol WithTupleDataCore(TupleExtraData newData)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 5831, 5870);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 5834, 5870);
                    throw f_10429_5840_5870(); DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 5831, 5870);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 5831, 5870);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 5831, 5870);
                }
                throw new System.Exception("Slicer error: unreachable code");

                System.Exception
                f_10429_5840_5870()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10429, 5840, 5870);
                    return return_v;
                }

            }

            internal AnonymousTypeKey GetAnonymousTypeKey()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 5887, 6155);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 5967, 6082);

                    var
                    properties = Properties.SelectAsArray(p => new AnonymousTypeKeyField(p.Name, isKey: false, ignoreCase: false))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 6100, 6140);

                    return f_10429_6107_6139(properties);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 5887, 6155);

                    Microsoft.CodeAnalysis.Emit.AnonymousTypeKey
                    f_10429_6107_6139(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Emit.AnonymousTypeKeyField>
                    fields)
                    {
                        var return_v = new Microsoft.CodeAnalysis.Emit.AnonymousTypeKey(fields);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 6107, 6139);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 5887, 6155);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 5887, 6155);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal Location SmallestLocation
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 6586, 6736);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 6630, 6670);

                        f_10429_6630_6669(_smallestLocation != null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 6692, 6717);

                        return _smallestLocation;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 6586, 6736);

                        int
                        f_10429_6630_6669(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 6630, 6669);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 6519, 6751);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 6519, 6751);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal NameAndIndex NameAndIndex
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 6834, 6918);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 6878, 6899);

                        return _nameAndIndex;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 6834, 6918);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 6767, 7237);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 6767, 7237);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                set
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 6936, 7222);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 6980, 7055);

                        var
                        oldValue = f_10429_6995_7054(ref _nameAndIndex, value, null)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 7077, 7203);

                        f_10429_7077_7202(oldValue == null || (DynAbs.Tracing.TraceSender.Expression_False(10429, 7090, 7201) || ((oldValue.Name == value.Name) && (DynAbs.Tracing.TraceSender.Expression_True(10429, 7136, 7200) && (oldValue.Index == value.Index)))));
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 6936, 7222);

                        Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.NameAndIndex
                        f_10429_6995_7054(ref Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.NameAndIndex
                        location1, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.NameAndIndex
                        value, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.NameAndIndex
                        comparand)
                        {
                            var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 6995, 7054);
                            return return_v;
                        }


                        int
                        f_10429_7077_7202(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 7077, 7202);
                            return 0;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 6767, 7237);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 6767, 7237);
                    }
                }
            }

            internal void AdjustLocation(Location location)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 7533, 8651);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 7613, 7647);

                    f_10429_7613_7646(f_10429_7626_7645(location));
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 7667, 8636) || true) && (true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10429, 7667, 8636);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 7934, 7987);

                            Location
                            currentSmallestLocation = _smallestLocation
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 8009, 8301) || true) && (currentSmallestLocation != null && (DynAbs.Tracing.TraceSender.Expression_True(10429, 8013, 8134) && f_10429_8048_8130(f_10429_8048_8072(this.Manager), currentSmallestLocation, location) < 0))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10429, 8009, 8301);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 8271, 8278);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10429, 8009, 8301);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 8325, 8617) || true) && (f_10429_8329_8456(f_10429_8345_8430(ref _smallestLocation, location, currentSmallestLocation), currentSmallestLocation))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10429, 8325, 8617);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 8587, 8594);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10429, 8325, 8617);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10429, 7667, 8636);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10429, 7667, 8636);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10429, 7667, 8636);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 7533, 8651);

                    bool
                    f_10429_7626_7645(Microsoft.CodeAnalysis.Location
                    this_param)
                    {
                        var return_v = this_param.IsInSource;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10429, 7626, 7645);
                        return return_v;
                    }


                    int
                    f_10429_7613_7646(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 7613, 7646);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10429_8048_8072(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                    this_param)
                    {
                        var return_v = this_param.Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10429, 8048, 8072);
                        return return_v;
                    }


                    int
                    f_10429_8048_8130(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param, Microsoft.CodeAnalysis.Location
                    loc1, Microsoft.CodeAnalysis.Location
                    loc2)
                    {
                        var return_v = this_param.CompareSourceLocations(loc1, loc2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 8048, 8130);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Location?
                    f_10429_8345_8430(ref Microsoft.CodeAnalysis.Location
                    location1, Microsoft.CodeAnalysis.Location
                    value, Microsoft.CodeAnalysis.Location?
                    comparand)
                    {
                        var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 8345, 8430);
                        return return_v;
                    }


                    bool
                    f_10429_8329_8456(Microsoft.CodeAnalysis.Location?
                    objA, Microsoft.CodeAnalysis.Location?
                    objB)
                    {
                        var return_v = ReferenceEquals((object?)objA, (object?)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 8329, 8456);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 7533, 8651);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 7533, 8651);
                }
            }

            public override ImmutableArray<Symbol> GetMembers()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 8667, 8782);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 8751, 8767);

                    return _members;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 8667, 8782);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 8667, 8782);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 8667, 8782);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override IEnumerable<FieldSymbol> GetFieldsToEmit()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 8798, 9205);

                    var listYield = new List<FieldSymbol>();
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 8891, 9190);
                        foreach (var m in f_10429_8909_8926_I(f_10429_8909_8926(this)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10429, 8891, 9190);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 8968, 9171);

                            switch (f_10429_8976_8982(m))
                            {

                                case SymbolKind.Field:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10429, 8968, 9171);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 9084, 9112);

                                    listYield.Add((FieldSymbol)m);
                                    DynAbs.Tracing.TraceSender.TraceBreak(10429, 9142, 9148);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10429, 8968, 9171);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10429, 8891, 9190);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10429, 1, 300);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10429, 1, 300);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 8798, 9205);

                    return listYield;

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10429_8909_8926(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol
                    this_param)
                    {
                        var return_v = this_param.GetMembers();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 8909, 8926);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10429_8976_8982(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10429, 8976, 8982);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10429_8909_8926_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 8909, 8926);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 8798, 9205);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 8798, 9205);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override bool HasCodeAnalysisEmbeddedAttribute
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 9277, 9285);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 9280, 9285);
                        return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 9277, 9285);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 9277, 9285);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 9277, 9285);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override ImmutableArray<TypeWithAnnotations> TypeArgumentsWithAnnotationsNoUseSiteDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 9437, 9487);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 9443, 9485);

                        return f_10429_9450_9484(this);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 9437, 9487);

                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                        f_10429_9450_9484(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol
                        this_param)
                        {
                            var return_v = this_param.GetTypeParametersAsTypeArguments();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 9450, 9484);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 9302, 9502);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 9302, 9502);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override ImmutableArray<Symbol> GetMembers(string name)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 9518, 9928);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 9613, 9648);

                    var
                    symbols = f_10429_9627_9647(_nameToSymbols, name)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 9666, 9728);

                    var
                    builder = f_10429_9680_9727(symbols.Count)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 9746, 9857);
                        foreach (var symbol in f_10429_9769_9776_I(symbols))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10429, 9746, 9857);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 9818, 9838);

                            f_10429_9818_9837(builder, symbol);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10429, 9746, 9857);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10429, 1, 112);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10429, 1, 112);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 9877, 9913);

                    return f_10429_9884_9912(builder);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 9518, 9928);

                    Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet
                    f_10429_9627_9647(Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbol>
                    this_param, string
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10429, 9627, 9647);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10429_9680_9727(int
                    capacity)
                    {
                        var return_v = ArrayBuilder<Symbol>.GetInstance(capacity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 9680, 9727);
                        return return_v;
                    }


                    int
                    f_10429_9818_9837(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 9818, 9837);
                        return 0;
                    }


                    Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet
                    f_10429_9769_9776_I(Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 9769, 9776);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10429_9884_9912(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 9884, 9912);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 9518, 9928);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 9518, 9928);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override ImmutableArray<Symbol> GetEarlyAttributeDecodingMembers()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 9944, 10101);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 10052, 10086);

                    return f_10429_10059_10085(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 9944, 10101);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10429_10059_10085(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol
                    this_param)
                    {
                        var return_v = this_param.GetMembersUnordered();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 10059, 10085);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 9944, 10101);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 9944, 10101);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override ImmutableArray<Symbol> GetEarlyAttributeDecodingMembers(string name)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 10117, 10280);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 10236, 10265);

                    return f_10429_10243_10264(this, name);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 10117, 10280);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10429_10243_10264(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol
                    this_param, string
                    name)
                    {
                        var return_v = this_param.GetMembers(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 10243, 10264);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 10117, 10280);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 10117, 10280);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override IEnumerable<string> MemberNames
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 10376, 10411);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 10382, 10409);

                        return f_10429_10389_10408(_nameToSymbols);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 10376, 10411);

                        System.Collections.Generic.Dictionary<string, Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet>.KeyCollection
                        f_10429_10389_10408(Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbol>
                        this_param)
                        {
                            var return_v = this_param.Keys;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10429, 10389, 10408);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 10296, 10426);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 10296, 10426);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override Symbol ContainingSymbol
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 10514, 10583);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 10520, 10581);

                        return f_10429_10527_10580(f_10429_10527_10564(f_10429_10527_10551(this.Manager)));
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 10514, 10583);

                        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        f_10429_10527_10551(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                        this_param)
                        {
                            var return_v = this_param.Compilation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10429, 10527, 10551);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                        f_10429_10527_10564(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        this_param)
                        {
                            var return_v = this_param.SourceModule;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10429, 10527, 10564);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                        f_10429_10527_10580(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                        this_param)
                        {
                            var return_v = this_param.GlobalNamespace;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10429, 10527, 10580);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 10442, 10598);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 10442, 10598);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override string Name
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 10674, 10708);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 10680, 10706);

                        return _nameAndIndex.Name;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 10674, 10708);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 10614, 10723);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 10614, 10723);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override bool HasSpecialName
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 10809, 10830);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 10815, 10828);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 10809, 10830);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 10739, 10845);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 10739, 10845);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override bool MangleName
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 10927, 10957);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 10933, 10955);

                        return f_10429_10940_10950(this) > 0;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 10927, 10957);

                        int
                        f_10429_10940_10950(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol
                        this_param)
                        {
                            var return_v = this_param.Arity;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10429, 10940, 10950);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 10861, 10972);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 10861, 10972);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override int Arity
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 11046, 11084);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 11052, 11082);

                        return _typeParameters.Length;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 11046, 11084);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 10988, 11099);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 10988, 11099);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override bool IsImplicitlyDeclared
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 11189, 11209);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 11195, 11207);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 11189, 11209);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 11115, 11224);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 11115, 11224);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override ImmutableArray<TypeParameterSymbol> TypeParameters
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 11339, 11370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 11345, 11368);

                        return _typeParameters;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 11339, 11370);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 11240, 11385);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 11240, 11385);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override bool IsAbstract
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 11465, 11486);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 11471, 11484);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 11465, 11486);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 11401, 11501);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 11401, 11501);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public sealed override bool IsRefLikeType
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 11591, 11612);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 11597, 11610);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 11591, 11612);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 11517, 11627);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 11517, 11627);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public sealed override bool IsReadOnly
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 11714, 11735);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 11720, 11733);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 11714, 11735);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 11643, 11750);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 11643, 11750);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override bool IsSealed
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 11828, 11848);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 11834, 11846);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 11828, 11848);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 11766, 11863);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 11766, 11863);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override bool MightContainExtensionMethods
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 11961, 11982);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 11967, 11980);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 11961, 11982);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 11879, 11997);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 11879, 11997);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public sealed override bool AreLocalsZeroed
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 12089, 12137);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 12095, 12135);

                        return f_10429_12102_12134(f_10429_12102_12118());
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 12089, 12137);

                        Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                        f_10429_12102_12118()
                        {
                            var return_v = ContainingModule;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10429, 12102, 12118);
                            return return_v;
                        }


                        bool
                        f_10429_12102_12134(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                        this_param)
                        {
                            var return_v = this_param.AreLocalsZeroed;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10429, 12102, 12134);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 12013, 12152);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 12013, 12152);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override ImmutableArray<NamedTypeSymbol> GetTypeMembers()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 12168, 12325);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 12265, 12310);

                    return ImmutableArray<NamedTypeSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 12168, 12325);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 12168, 12325);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 12168, 12325);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override ImmutableArray<NamedTypeSymbol> GetTypeMembers(string name)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 12341, 12509);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 12449, 12494);

                    return ImmutableArray<NamedTypeSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 12341, 12509);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 12341, 12509);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 12341, 12509);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override ImmutableArray<NamedTypeSymbol> GetTypeMembers(string name, int arity)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 12525, 12704);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 12644, 12689);

                    return ImmutableArray<NamedTypeSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 12525, 12704);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 12525, 12704);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 12525, 12704);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Accessibility DeclaredAccessibility
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 12804, 12842);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 12810, 12840);

                        return Accessibility.Internal;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 12804, 12842);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 12720, 12857);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 12720, 12857);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override ImmutableArray<NamedTypeSymbol> InterfacesNoUseSiteDiagnostics(ConsList<TypeSymbol> basesBeingResolved)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 12873, 13087);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 13027, 13072);

                    return ImmutableArray<NamedTypeSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 12873, 13087);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 12873, 13087);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 12873, 13087);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override ImmutableArray<NamedTypeSymbol> GetInterfacesToEmit()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 13103, 13267);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 13207, 13252);

                    return ImmutableArray<NamedTypeSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 13103, 13267);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 13103, 13267);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 13103, 13267);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override NamedTypeSymbol BaseTypeNoUseSiteDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 13346, 13375);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 13349, 13375);
                        return f_10429_13349_13375(this.Manager); DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 13346, 13375);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 13346, 13375);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 13346, 13375);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override TypeKind TypeKind
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 13458, 13488);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 13464, 13486);

                        return TypeKind.Class;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 13458, 13488);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 13392, 13503);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 13392, 13503);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override bool IsInterface
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 13586, 13607);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 13592, 13605);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 13586, 13607);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 13519, 13622);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 13519, 13622);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override ImmutableArray<Location> Locations
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 13721, 13767);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 13727, 13765);

                        return ImmutableArray<Location>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 13721, 13767);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 13638, 13782);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 13638, 13782);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override ImmutableArray<SyntaxReference> DeclaringSyntaxReferences
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 13904, 14012);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 13948, 13993);

                        return ImmutableArray<SyntaxReference>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 13904, 14012);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 13798, 14027);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 13798, 14027);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override bool IsStatic
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 14105, 14126);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 14111, 14124);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 14105, 14126);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 14043, 14141);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 14043, 14141);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override NamedTypeSymbol ConstructedFrom
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 14237, 14257);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 14243, 14255);

                        return this;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 14237, 14257);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 14157, 14272);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 14157, 14272);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override NamedTypeSymbol GetDeclaredBaseType(ConsList<TypeSymbol> basesBeingResolved)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 14288, 14464);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 14415, 14449);

                    return f_10429_14422_14448(this.Manager);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 14288, 14464);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10429_14422_14448(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                    this_param)
                    {
                        var return_v = this_param.System_Object;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10429, 14422, 14448);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 14288, 14464);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 14288, 14464);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override ImmutableArray<NamedTypeSymbol> GetDeclaredInterfaces(ConsList<TypeSymbol> basesBeingResolved)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 14480, 14685);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 14625, 14670);

                    return ImmutableArray<NamedTypeSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 14480, 14685);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 14480, 14685);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 14480, 14685);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override bool ShouldAddWinRTMembers
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 14778, 14799);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 14784, 14797);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 14778, 14799);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 14701, 14814);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 14701, 14814);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override bool IsWindowsRuntimeImport
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 14908, 14929);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 14914, 14927);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 14908, 14929);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 14830, 14944);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 14830, 14944);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override bool IsComImport
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 15027, 15048);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 15033, 15046);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 15027, 15048);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 14960, 15063);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 14960, 15063);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal sealed override ObsoleteAttributeData ObsoleteAttributeData
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 15180, 15200);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 15186, 15198);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 15180, 15200);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 15079, 15215);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 15079, 15215);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override TypeLayout Layout
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 15299, 15334);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 15305, 15332);

                        return default(TypeLayout);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 15299, 15334);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 15231, 15349);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 15231, 15349);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override CharSet MarshallingCharSet
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 15442, 15483);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 15448, 15481);

                        return f_10429_15455_15480();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 15442, 15483);

                        System.Runtime.InteropServices.CharSet
                        f_10429_15455_15480()
                        {
                            var return_v = DefaultMarshallingCharSet;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10429, 15455, 15480);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 15365, 15498);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 15365, 15498);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override bool IsSerializable
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 15582, 15603);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 15588, 15601);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 15582, 15603);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 15514, 15618);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 15514, 15618);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override bool HasDeclarativeSecurity
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 15712, 15733);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 15718, 15731);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 15712, 15733);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 15634, 15748);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 15634, 15748);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override IEnumerable<Microsoft.Cci.SecurityAttribute> GetSecurityInformation()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 15764, 15936);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 15884, 15921);

                    throw f_10429_15890_15920();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 15764, 15936);

                    System.Exception
                    f_10429_15890_15920()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10429, 15890, 15920);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 15764, 15936);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 15764, 15936);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override ImmutableArray<string> GetAppliedConditionalSymbols()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 15952, 16107);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 16056, 16092);

                    return ImmutableArray<string>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 15952, 16107);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 15952, 16107);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 15952, 16107);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override AttributeUsageInfo GetAttributeUsageInfo()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 16123, 16262);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 16216, 16247);

                    return AttributeUsageInfo.Null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 16123, 16262);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 16123, 16262);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 16123, 16262);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal sealed override NamedTypeSymbol AsNativeInteger()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 16337, 16376);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 16340, 16376);
                    throw f_10429_16346_16376(); DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 16337, 16376);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 16337, 16376);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 16337, 16376);
                }
                throw new System.Exception("Slicer error: unreachable code");

                System.Exception
                f_10429_16346_16376()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10429, 16346, 16376);
                    return return_v;
                }

            }

            internal sealed override NamedTypeSymbol NativeIntegerUnderlyingType
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 16462, 16469);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 16465, 16469);
                        return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 16462, 16469);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 16462, 16469);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 16462, 16469);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override bool IsRecord
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 16518, 16526);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 16521, 16526);
                        return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 16518, 16526);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 16518, 16526);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 16518, 16526);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override void AddSynthesizedAttributes(PEModuleBuilder moduleBuilder, ref ArrayBuilder<SynthesizedAttributeData> attributes)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 16543, 17231);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 16709, 16770);

                    // LAFHIS
                    //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AddSynthesizedAttributes(moduleBuilder, ref attributes), 10429, 16709, 16769);
                    base.AddSynthesizedAttributes(moduleBuilder, ref attributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 16709, 16769);

                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 16790, 16978);

                    f_10429_16790_16977(ref attributes, f_10429_16830_16976(f_10429_16830_16849(Manager), WellKnownMember.System_Runtime_CompilerServices_CompilerGeneratedAttribute__ctor));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 16998, 17216) || true) && (f_10429_17002_17047(f_10429_17002_17029(f_10429_17002_17021(Manager))) == OptimizationLevel.Debug)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10429, 16998, 17216);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 17116, 17197);

                        f_10429_17116_17196(ref attributes, f_10429_17156_17195(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10429, 16998, 17216);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 16543, 17231);

                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10429_16830_16849(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                    this_param)
                    {
                        var return_v = this_param.Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10429, 16830, 16849);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                    f_10429_16830_16976(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    constructor)
                    {
                        var return_v = this_param.TrySynthesizeAttribute(constructor);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 16830, 16976);
                        return return_v;
                    }


                    int
                    f_10429_16790_16977(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                    attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                    attribute)
                    {
                        AddSynthesizedAttribute(ref attributes, attribute);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 16790, 16977);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10429_17002_17021(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                    this_param)
                    {
                        var return_v = this_param.Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10429, 17002, 17021);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                    f_10429_17002_17029(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param)
                    {
                        var return_v = this_param.Options;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10429, 17002, 17029);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.OptimizationLevel
                    f_10429_17002_17047(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                    this_param)
                    {
                        var return_v = this_param.OptimizationLevel;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10429, 17002, 17047);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                    f_10429_17156_17195(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol
                    this_param)
                    {
                        var return_v = this_param.TrySynthesizeDebuggerDisplayAttribute();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 17156, 17195);
                        return return_v;
                    }


                    int
                    f_10429_17116_17196(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                    attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                    attribute)
                    {
                        AddSynthesizedAttribute(ref attributes, attribute);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 17116, 17196);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 16543, 17231);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 16543, 17231);
                }
            }

            private SynthesizedAttributeData TrySynthesizeDebuggerDisplayAttribute()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 17426, 19544);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 17625, 17646);

                    string
                    displayString
                    = default(string);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 17664, 18878) || true) && (this.Properties.Length == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10429, 17664, 18878);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 17737, 17761);

                        displayString = "\\{ }";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10429, 17664, 18878);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10429, 17664, 18878);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 17843, 17891);

                        var
                        builder = f_10429_17857_17890()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 17913, 17938);

                        var
                        sb = builder.Builder
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 17962, 17980);

                        f_10429_17962_17979(
                                            sb, "\\{ ");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 18002, 18058);

                        int
                        displayCount = f_10429_18021_18057(this.Properties.Length, 10)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 18091, 18105);

                            for (var
        fieldIndex = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 18082, 18599) || true) && (fieldIndex < displayCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 18134, 18146)
        , fieldIndex++, DynAbs.Tracing.TraceSender.TraceExitCondition(10429, 18082, 18599))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10429, 18082, 18599);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 18196, 18248);

                                string
                                fieldName = f_10429_18215_18247(this.Properties[fieldIndex])
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 18276, 18395) || true) && (fieldIndex > 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10429, 18276, 18395);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 18352, 18368);

                                    f_10429_18352_18367(sb, ", ");
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10429, 18276, 18395);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 18423, 18444);

                                f_10429_18423_18443(
                                                        sb, fieldName);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 18470, 18488);

                                f_10429_18470_18487(sb, " = {");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 18514, 18535);

                                f_10429_18514_18534(sb, fieldName);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 18561, 18576);

                                f_10429_18561_18575(sb, "}");
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10429, 1, 518);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10429, 1, 518);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 18623, 18755) || true) && (this.Properties.Length > displayCount)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10429, 18623, 18755);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 18714, 18732);

                            f_10429_18714_18731(sb, " ...");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10429, 18623, 18755);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 18779, 18795);

                        f_10429_18779_18794(
                                            sb, " }");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 18817, 18859);

                        displayString = f_10429_18833_18858(builder);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10429, 17664, 18878);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 18898, 19529);

                    return f_10429_18905_19528(f_10429_18905_18924(Manager), WellKnownMember.System_Diagnostics_DebuggerDisplayAttribute__ctor, arguments: f_10429_19069_19176(f_10429_19091_19175(f_10429_19109_19130(Manager), TypedConstantKind.Primitive, displayString)), namedArguments: f_10429_19215_19527(f_10429_19237_19526(WellKnownMember.System_Diagnostics_DebuggerDisplayAttribute__Type, f_10429_19436_19525(f_10429_19454_19475(Manager), TypedConstantKind.Primitive, "<Anonymous Type>"))));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 17426, 19544);

                    Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                    f_10429_17857_17890()
                    {
                        var return_v = PooledStringBuilder.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 17857, 17890);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10429_17962_17979(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 17962, 17979);
                        return return_v;
                    }


                    int
                    f_10429_18021_18057(int
                    val1, int
                    val2)
                    {
                        var return_v = Math.Min(val1, val2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 18021, 18057);
                        return return_v;
                    }


                    string
                    f_10429_18215_18247(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertySymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10429, 18215, 18247);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10429_18352_18367(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 18352, 18367);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10429_18423_18443(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 18423, 18443);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10429_18470_18487(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 18470, 18487);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10429_18514_18534(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 18514, 18534);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10429_18561_18575(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 18561, 18575);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10429_18714_18731(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 18714, 18731);
                        return return_v;
                    }


                    System.Text.StringBuilder
                    f_10429_18779_18794(System.Text.StringBuilder
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Append(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 18779, 18794);
                        return return_v;
                    }


                    string
                    f_10429_18833_18858(Microsoft.CodeAnalysis.PooledObjects.PooledStringBuilder
                    this_param)
                    {
                        var return_v = this_param.ToStringAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 18833, 18858);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10429_18905_18924(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                    this_param)
                    {
                        var return_v = this_param.Compilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10429, 18905, 18924);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10429_19109_19130(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                    this_param)
                    {
                        var return_v = this_param.System_String;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10429, 19109, 19130);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.TypedConstant
                    f_10429_19091_19175(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type, Microsoft.CodeAnalysis.TypedConstantKind
                    kind, string
                    value)
                    {
                        var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, kind, (object)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 19091, 19175);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                    f_10429_19069_19176(Microsoft.CodeAnalysis.TypedConstant
                    item)
                    {
                        var return_v = ImmutableArray.Create(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 19069, 19176);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10429_19454_19475(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                    this_param)
                    {
                        var return_v = this_param.System_String;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10429, 19454, 19475);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.TypedConstant
                    f_10429_19436_19525(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type, Microsoft.CodeAnalysis.TypedConstantKind
                    kind, string
                    value)
                    {
                        var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, kind, (object)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 19436, 19525);
                        return return_v;
                    }


                    System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.WellKnownMember, Microsoft.CodeAnalysis.TypedConstant>
                    f_10429_19237_19526(Microsoft.CodeAnalysis.WellKnownMember
                    key, Microsoft.CodeAnalysis.TypedConstant
                    value)
                    {
                        var return_v = new System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.WellKnownMember, Microsoft.CodeAnalysis.TypedConstant>(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 19237, 19526);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.WellKnownMember, Microsoft.CodeAnalysis.TypedConstant>>
                    f_10429_19215_19527(System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.WellKnownMember, Microsoft.CodeAnalysis.TypedConstant>
                    item)
                    {
                        var return_v = ImmutableArray.Create(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 19215, 19527);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                    f_10429_18905_19528(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param, Microsoft.CodeAnalysis.WellKnownMember
                    constructor, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                    arguments, System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.WellKnownMember, Microsoft.CodeAnalysis.TypedConstant>>
                    namedArguments)
                    {
                        var return_v = this_param.TrySynthesizeAttribute(constructor, arguments: arguments, namedArguments: namedArguments);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 18905, 19528);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 17426, 19544);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 17426, 19544);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override bool HasPossibleWellKnownCloneMethod()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10429, 19617, 19625);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10429, 19620, 19625);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10429, 19617, 19625);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10429, 19617, 19625);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 19617, 19625);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static AnonymousTypeTemplateSymbol()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10429, 1239, 19637);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10429, 1239, 19637);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10429, 1239, 19637);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10429, 1239, 19637);

            Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbol>
            f_10429_2165_2202()
            {
                var return_v = new Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbol>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 2165, 2202);
                return return_v;
            }


            Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
            f_10429_3454_3500(int
            capacity)
            {
                var return_v = ArrayBuilder<Symbol>.GetInstance(capacity);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 3454, 3500);
                return return_v;
            }


            Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertySymbol>
            f_10429_3543_3609(int
            capacity)
            {
                var return_v = ArrayBuilder<AnonymousTypePropertySymbol>.GetInstance(capacity);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 3543, 3609);
                return return_v;
            }


            Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
            f_10429_3656_3714(int
            capacity)
            {
                var return_v = ArrayBuilder<TypeParameterSymbol>.GetInstance(capacity);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 3656, 3714);
                return return_v;
            }


            string
            f_10429_4121_4178(string
            propertyName)
            {
                var return_v = GeneratedNames.MakeAnonymousTypeParameterName(propertyName);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 4121, 4178);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeParameterSymbol
            f_10429_4070_4179(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol
            container, int
            ordinal, string
            name)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeParameterSymbol((Microsoft.CodeAnalysis.CSharp.Symbol)container, ordinal, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 4070, 4179);
                return return_v;
            }


            int
            f_10429_4202_4242(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeParameterSymbol
            item)
            {
                this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol)item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 4202, 4242);
                return 0;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertySymbol
            f_10429_4345_4444(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol
            container, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeField
            field, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            fieldTypeWithAnnotations, int
            index)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertySymbol(container, field, fieldTypeWithAnnotations, index);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 4345, 4444);
                return return_v;
            }


            int
            f_10429_4467_4498(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertySymbol>
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertySymbol
            item)
            {
                this_param.Add(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 4467, 4498);
                return 0;
            }


            int
            f_10429_4572_4600(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertySymbol
            item)
            {
                this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 4572, 4600);
                return 0;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
            f_10429_4642_4663(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertySymbol
            this_param)
            {
                var return_v = this_param.BackingField;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10429, 4642, 4663);
                return return_v;
            }


            int
            f_10429_4623_4664(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
            item)
            {
                this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 4623, 4664);
                return 0;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            f_10429_4706_4724(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertySymbol
            this_param)
            {
                var return_v = this_param.GetMethod;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10429, 4706, 4724);
                return return_v;
            }


            int
            f_10429_4687_4725(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            item)
            {
                this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 4687, 4725);
                return 0;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
            f_10429_4783_4825(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
            this_param)
            {
                var return_v = this_param.ToImmutableAndFree();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 4783, 4825);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertySymbol>
            f_10429_4862_4900(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertySymbol>
            this_param)
            {
                var return_v = this_param.ToImmutableAndFree();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 4862, 4900);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeConstructorSymbol
            f_10429_4978_5035(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol
            container, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertySymbol>
            properties)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeConstructorSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)container, properties);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 4978, 5035);
                return return_v;
            }


            int
            f_10429_4959_5036(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeConstructorSymbol
            item)
            {
                this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 4959, 5036);
                return 0;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
            f_10429_5066_5101(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
            this_param)
            {
                var return_v = this_param.ToImmutableAndFree();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 5066, 5101);
                return return_v;
            }


            int
            f_10429_5120_5165(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 5120, 5165);
                return 0;
            }


            string
            f_10429_5321_5332(Microsoft.CodeAnalysis.CSharp.Symbol
            this_param)
            {
                var return_v = this_param.Name;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10429, 5321, 5332);
                return return_v;
            }


            bool
            f_10429_5302_5341(Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbol>
            this_param, string
            k, Microsoft.CodeAnalysis.CSharp.Symbol
            v)
            {
                var return_v = this_param.Add(k, v);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 5302, 5341);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
            f_10429_5252_5260_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 5252, 5260);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeEqualsMethodSymbol
            f_10429_5528_5569(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol
            container)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeEqualsMethodSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)container);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 5528, 5569);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeGetHashCodeMethodSymbol
            f_10429_5592_5638(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol
            container)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeGetHashCodeMethodSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)container);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 5592, 5638);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeToStringMethodSymbol
            f_10429_5661_5704(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol
            container)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeToStringMethodSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)container);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 5661, 5704);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
            f_10429_5470_5705(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeEqualsMethodSymbol
            item1, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeGetHashCodeMethodSymbol
            item2, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeToStringMethodSymbol
            item3)
            {
                var return_v = ImmutableArray.Create<MethodSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)item1, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)item2, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)item3);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10429, 5470, 5705);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10429_13349_13375(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
            this_param)
            {
                var return_v = this_param.System_Object;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10429, 13349, 13375);
                return return_v;
            }

        }
    }
}
