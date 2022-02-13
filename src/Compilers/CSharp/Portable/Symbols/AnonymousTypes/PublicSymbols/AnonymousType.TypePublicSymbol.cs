// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed partial class AnonymousTypeManager
    {
        internal sealed class AnonymousTypePublicSymbol : NamedTypeSymbol
        {
            private readonly ImmutableArray<Symbol> _members;

            internal readonly ImmutableArray<AnonymousTypePropertySymbol> Properties;

            private readonly MultiDictionary<string, Symbol> _nameToSymbols;

            internal readonly AnonymousTypeManager Manager;

            internal readonly AnonymousTypeDescriptor TypeDescriptor;

            internal AnonymousTypePublicSymbol(AnonymousTypeManager manager, AnonymousTypeDescriptor typeDescr)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10421, 1629, 2976);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 1276, 1330);
                    this._nameToSymbols = f_10421_1293_1330(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 1468, 1475);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 1761, 1786);

                    typeDescr.AssertIsGood();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 1806, 1829);

                    this.Manager = manager;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 1847, 1879);

                    this.TypeDescriptor = typeDescr;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 1899, 1929);

                    var
                    fields = typeDescr.Fields
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 1947, 2060);

                    var
                    properties = fields.SelectAsArray((field, i, type) => new AnonymousTypePropertySymbol(type, field, i), this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 2109, 2150);

                    int
                    membersCount = fields.Length * 2 + 1
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 2168, 2229);

                    var
                    members = f_10421_2182_2228(membersCount)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 2249, 2470);
                        foreach (var property in f_10421_2274_2284_I(properties))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10421, 2249, 2470);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 2375, 2397);

                            f_10421_2375_2396(                    // Property related symbols
                                                members, property);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 2419, 2451);

                            f_10421_2419_2450(members, f_10421_2431_2449(property));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10421, 2249, 2470);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10421, 1, 222);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10421, 1, 222);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 2490, 2519);

                    this.Properties = properties;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 2577, 2643);

                    f_10421_2577_2642(
                                    // Add a constructor
                                    members, f_10421_2589_2641(this, properties));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 2661, 2701);

                    _members = f_10421_2672_2700(members);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 2719, 2765);

                    f_10421_2719_2764(membersCount == _members.Length);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 2829, 2961);
                        foreach (var symbol in f_10421_2852_2860_I(_members))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10421, 2829, 2961);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 2902, 2942);

                            f_10421_2902_2941(_nameToSymbols, f_10421_2921_2932(symbol), symbol);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10421, 2829, 2961);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10421, 1, 133);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10421, 1, 133);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10421, 1629, 2976);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 1629, 2976);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 1629, 2976);
                }
            }

            protected override NamedTypeSymbol WithTupleDataCore(TupleExtraData newData)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 3086, 3125);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 3089, 3125);
                    throw f_10421_3095_3125(); DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 3086, 3125);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 3086, 3125);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 3086, 3125);
                }
                throw new System.Exception("Slicer error: unreachable code");

                System.Exception
                f_10421_3095_3125()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10421, 3095, 3125);
                    return return_v;
                }

            }

            public override ImmutableArray<Symbol> GetMembers()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 3142, 3257);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 3226, 3242);

                    return _members;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 3142, 3257);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 3142, 3257);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 3142, 3257);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override IEnumerable<FieldSymbol> GetFieldsToEmit()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 3273, 3418);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 3366, 3403);

                    throw f_10421_3372_3402();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 3273, 3418);

                    System.Exception
                    f_10421_3372_3402()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10421, 3372, 3402);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 3273, 3418);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 3273, 3418);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override ImmutableArray<TypeWithAnnotations> TypeArgumentsWithAnnotationsNoUseSiteDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 3569, 3626);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 3575, 3624);

                        return ImmutableArray<TypeWithAnnotations>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 3569, 3626);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 3434, 3641);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 3434, 3641);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override bool HasCodeAnalysisEmbeddedAttribute
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 3713, 3721);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 3716, 3721);
                        return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 3713, 3721);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 3713, 3721);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 3713, 3721);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override ImmutableArray<Symbol> GetMembers(string name)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 3738, 4148);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 3833, 3868);

                    var
                    symbols = f_10421_3847_3867(_nameToSymbols, name)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 3886, 3948);

                    var
                    builder = f_10421_3900_3947(symbols.Count)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 3966, 4077);
                        foreach (var symbol in f_10421_3989_3996_I(symbols))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10421, 3966, 4077);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 4038, 4058);

                            f_10421_4038_4057(builder, symbol);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10421, 3966, 4077);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10421, 1, 112);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10421, 1, 112);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 4097, 4133);

                    return f_10421_4104_4132(builder);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 3738, 4148);

                    Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet
                    f_10421_3847_3867(Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbol>
                    this_param, string
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10421, 3847, 3867);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10421_3900_3947(int
                    capacity)
                    {
                        var return_v = ArrayBuilder<Symbol>.GetInstance(capacity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10421, 3900, 3947);
                        return return_v;
                    }


                    int
                    f_10421_4038_4057(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10421, 4038, 4057);
                        return 0;
                    }


                    Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet
                    f_10421_3989_3996_I(Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10421, 3989, 3996);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10421_4104_4132(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10421, 4104, 4132);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 3738, 4148);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 3738, 4148);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override ImmutableArray<Symbol> GetEarlyAttributeDecodingMembers()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 4164, 4321);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 4272, 4306);

                    return f_10421_4279_4305(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 4164, 4321);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10421_4279_4305(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePublicSymbol
                    this_param)
                    {
                        var return_v = this_param.GetMembersUnordered();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10421, 4279, 4305);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 4164, 4321);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 4164, 4321);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override ImmutableArray<Symbol> GetEarlyAttributeDecodingMembers(string name)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 4337, 4500);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 4456, 4485);

                    return f_10421_4463_4484(this, name);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 4337, 4500);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10421_4463_4484(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePublicSymbol
                    this_param, string
                    name)
                    {
                        var return_v = this_param.GetMembers(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10421, 4463, 4484);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 4337, 4500);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 4337, 4500);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override IEnumerable<string> MemberNames
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 4596, 4631);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 4602, 4629);

                        return f_10421_4609_4628(_nameToSymbols);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 4596, 4631);

                        System.Collections.Generic.Dictionary<string, Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbol>.ValueSet>.KeyCollection
                        f_10421_4609_4628(Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbol>
                        this_param)
                        {
                            var return_v = this_param.Keys;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10421, 4609, 4628);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 4516, 4646);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 4516, 4646);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 4734, 4803);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 4740, 4801);

                        return f_10421_4747_4800(f_10421_4747_4784(f_10421_4747_4771(this.Manager)));
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 4734, 4803);

                        Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        f_10421_4747_4771(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                        this_param)
                        {
                            var return_v = this_param.Compilation;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10421, 4747, 4771);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                        f_10421_4747_4784(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                        this_param)
                        {
                            var return_v = this_param.SourceModule;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10421, 4747, 4784);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                        f_10421_4747_4800(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                        this_param)
                        {
                            var return_v = this_param.GlobalNamespace;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10421, 4747, 4800);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 4662, 4818);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 4662, 4818);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 4894, 4922);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 4900, 4920);

                        return string.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 4894, 4922);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 4834, 4937);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 4834, 4937);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override string MetadataName
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 5021, 5049);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 5027, 5047);

                        return string.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 5021, 5049);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 4953, 5064);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 4953, 5064);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 5146, 5167);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 5152, 5165);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 5146, 5167);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 5080, 5182);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 5080, 5182);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 5256, 5273);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 5262, 5271);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 5256, 5273);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 5198, 5288);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 5198, 5288);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 5378, 5399);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 5384, 5397);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 5378, 5399);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 5304, 5414);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 5304, 5414);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 5529, 5586);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 5535, 5584);

                        return ImmutableArray<TypeParameterSymbol>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 5529, 5586);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 5430, 5601);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 5430, 5601);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 5681, 5702);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 5687, 5700);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 5681, 5702);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 5617, 5717);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 5617, 5717);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 5807, 5828);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 5813, 5826);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 5807, 5828);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 5733, 5843);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 5733, 5843);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 5930, 5951);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 5936, 5949);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 5930, 5951);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 5859, 5966);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 5859, 5966);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 6044, 6064);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 6050, 6062);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 6044, 6064);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 5982, 6079);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 5982, 6079);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 6177, 6198);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 6183, 6196);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 6177, 6198);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 6095, 6213);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 6095, 6213);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 6299, 6320);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 6305, 6318);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 6299, 6320);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 6229, 6335);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 6229, 6335);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override ImmutableArray<NamedTypeSymbol> GetTypeMembers()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 6351, 6508);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 6448, 6493);

                    return ImmutableArray<NamedTypeSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 6351, 6508);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 6351, 6508);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 6351, 6508);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override ImmutableArray<NamedTypeSymbol> GetTypeMembers(string name)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 6524, 6692);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 6632, 6677);

                    return ImmutableArray<NamedTypeSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 6524, 6692);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 6524, 6692);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 6524, 6692);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override ImmutableArray<NamedTypeSymbol> GetTypeMembers(string name, int arity)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 6708, 6887);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 6827, 6872);

                    return ImmutableArray<NamedTypeSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 6708, 6887);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 6708, 6887);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 6708, 6887);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Accessibility DeclaredAccessibility
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 6987, 7025);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 6993, 7023);

                        return Accessibility.Internal;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 6987, 7025);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 6903, 7040);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 6903, 7040);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override ImmutableArray<NamedTypeSymbol> InterfacesNoUseSiteDiagnostics(ConsList<TypeSymbol> basesBeingResolved)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 7056, 7270);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 7210, 7255);

                    return ImmutableArray<NamedTypeSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 7056, 7270);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 7056, 7270);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 7056, 7270);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override ImmutableArray<NamedTypeSymbol> GetInterfacesToEmit()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 7286, 7442);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 7390, 7427);

                    throw f_10421_7396_7426();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 7286, 7442);

                    System.Exception
                    f_10421_7396_7426()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10421, 7396, 7426);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 7286, 7442);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 7286, 7442);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override NamedTypeSymbol BaseTypeNoUseSiteDiagnostics
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 7521, 7550);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 7524, 7550);
                        return f_10421_7524_7550(this.Manager); DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 7521, 7550);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 7521, 7550);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 7521, 7550);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 7633, 7663);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 7639, 7661);

                        return TypeKind.Class;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 7633, 7663);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 7567, 7678);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 7567, 7678);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 7761, 7782);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 7767, 7780);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 7761, 7782);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 7694, 7797);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 7694, 7797);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 7896, 7973);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 7902, 7971);

                        return f_10421_7909_7970(this.TypeDescriptor.Location);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 7896, 7973);

                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                        f_10421_7909_7970(Microsoft.CodeAnalysis.Location
                        item)
                        {
                            var return_v = ImmutableArray.Create<Location>(item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10421, 7909, 7970);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 7813, 7988);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 7813, 7988);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 8110, 8271);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 8154, 8252);

                        return f_10421_8161_8251(f_10421_8236_8250(this));
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 8110, 8271);

                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                        f_10421_8236_8250(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePublicSymbol
                        this_param)
                        {
                            var return_v = this_param.Locations;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10421, 8236, 8250);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                        f_10421_8161_8251(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                        locations)
                        {
                            var return_v = GetDeclaringSyntaxReferenceHelper<AnonymousObjectCreationExpressionSyntax>(locations);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10421, 8161, 8251);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 8004, 8286);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 8004, 8286);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 8364, 8385);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 8370, 8383);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 8364, 8385);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 8302, 8400);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 8302, 8400);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override bool IsAnonymousType
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 8485, 8505);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 8491, 8503);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 8485, 8505);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 8416, 8520);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 8416, 8520);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 8616, 8636);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 8622, 8634);

                        return this;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 8616, 8636);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 8536, 8651);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 8536, 8651);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override bool ShouldAddWinRTMembers
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 8744, 8765);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 8750, 8763);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 8744, 8765);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 8667, 8780);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 8667, 8780);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 8874, 8895);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 8880, 8893);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 8874, 8895);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 8796, 8910);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 8796, 8910);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 8993, 9014);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 8999, 9012);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 8993, 9014);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 8926, 9029);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 8926, 9029);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 9146, 9166);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 9152, 9164);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 9146, 9166);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 9045, 9181);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 9045, 9181);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 9265, 9300);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 9271, 9298);

                        return default(TypeLayout);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 9265, 9300);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 9197, 9315);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 9197, 9315);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 9408, 9449);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 9414, 9447);

                        return f_10421_9421_9446();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 9408, 9449);

                        System.Runtime.InteropServices.CharSet
                        f_10421_9421_9446()
                        {
                            var return_v = DefaultMarshallingCharSet;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10421, 9421, 9446);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 9331, 9464);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 9331, 9464);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 9548, 9569);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 9554, 9567);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 9548, 9569);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 9480, 9584);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 9480, 9584);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 9676, 9721);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 9682, 9719);

                        throw f_10421_9688_9718();
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 9676, 9721);

                        System.Exception
                        f_10421_9688_9718()
                        {
                            var return_v = ExceptionUtilities.Unreachable;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10421, 9688, 9718);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 9600, 9736);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 9600, 9736);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 9830, 9851);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 9836, 9849);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 9830, 9851);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 9752, 9866);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 9752, 9866);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override IEnumerable<Microsoft.Cci.SecurityAttribute> GetSecurityInformation()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 9882, 10054);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 10002, 10039);

                    throw f_10421_10008_10038();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 9882, 10054);

                    System.Exception
                    f_10421_10008_10038()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10421, 10008, 10038);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 9882, 10054);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 9882, 10054);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override ImmutableArray<string> GetAppliedConditionalSymbols()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 10070, 10225);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 10174, 10210);

                    return ImmutableArray<string>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 10070, 10225);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 10070, 10225);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 10070, 10225);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override AttributeUsageInfo GetAttributeUsageInfo()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 10241, 10380);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 10334, 10365);

                    return AttributeUsageInfo.Null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 10241, 10380);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 10241, 10380);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 10241, 10380);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override NamedTypeSymbol GetDeclaredBaseType(ConsList<TypeSymbol> basesBeingResolved)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 10396, 10572);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 10523, 10557);

                    return f_10421_10530_10556(this.Manager);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 10396, 10572);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10421_10530_10556(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                    this_param)
                    {
                        var return_v = this_param.System_Object;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10421, 10530, 10556);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 10396, 10572);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 10396, 10572);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override ImmutableArray<NamedTypeSymbol> GetDeclaredInterfaces(ConsList<TypeSymbol> basesBeingResolved)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 10588, 10793);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 10733, 10778);

                    return ImmutableArray<NamedTypeSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 10588, 10793);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 10588, 10793);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 10588, 10793);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal sealed override NamedTypeSymbol AsNativeInteger()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 10868, 10907);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 10871, 10907);
                    throw f_10421_10877_10907(); DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 10868, 10907);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 10868, 10907);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 10868, 10907);
                }
                throw new System.Exception("Slicer error: unreachable code");

                System.Exception
                f_10421_10877_10907()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10421, 10877, 10907);
                    return return_v;
                }

            }

            internal sealed override NamedTypeSymbol NativeIntegerUnderlyingType
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 10993, 11000);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 10996, 11000);
                        return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 10993, 11000);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 10993, 11000);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 10993, 11000);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 11049, 11057);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 11052, 11057);
                        return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 11049, 11057);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 11049, 11057);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 11049, 11057);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override bool Equals(TypeSymbol t2, TypeCompareKind comparison)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 11074, 11471);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 11179, 11281) || true) && (f_10421_11183_11208(this, t2))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10421, 11179, 11281);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 11250, 11262);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10421, 11179, 11281);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 11301, 11345);

                    var
                    other = t2 as AnonymousTypePublicSymbol
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 11363, 11456);

                    return (object)other != null && (DynAbs.Tracing.TraceSender.Expression_True(10421, 11370, 11455) && this.TypeDescriptor.Equals(other.TypeDescriptor, comparison));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 11074, 11471);

                    bool
                    f_10421_11183_11208(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePublicSymbol
                    objA, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10421, 11183, 11208);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 11074, 11471);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 11074, 11471);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 11487, 11609);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 11553, 11594);

                    return this.TypeDescriptor.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 11487, 11609);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 11487, 11609);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 11487, 11609);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override bool HasPossibleWellKnownCloneMethod()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10421, 11682, 11690);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10421, 11685, 11690);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10421, 11682, 11690);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10421, 11682, 11690);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 11682, 11690);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static AnonymousTypePublicSymbol()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10421, 845, 11702);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10421, 845, 11702);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10421, 845, 11702);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10421, 845, 11702);

            Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbol>
            f_10421_1293_1330()
            {
                var return_v = new Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbol>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10421, 1293, 1330);
                return return_v;
            }


            Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
            f_10421_2182_2228(int
            capacity)
            {
                var return_v = ArrayBuilder<Symbol>.GetInstance(capacity);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10421, 2182, 2228);
                return return_v;
            }


            int
            f_10421_2375_2396(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertySymbol
            item)
            {
                this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10421, 2375, 2396);
                return 0;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            f_10421_2431_2449(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertySymbol
            this_param)
            {
                var return_v = this_param.GetMethod;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10421, 2431, 2449);
                return return_v;
            }


            int
            f_10421_2419_2450(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            item)
            {
                this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10421, 2419, 2450);
                return 0;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertySymbol>
            f_10421_2274_2284_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertySymbol>
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10421, 2274, 2284);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeConstructorSymbol
            f_10421_2589_2641(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePublicSymbol
            container, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypePropertySymbol>
            properties)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeConstructorSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)container, properties);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10421, 2589, 2641);
                return return_v;
            }


            int
            f_10421_2577_2642(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeConstructorSymbol
            item)
            {
                this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10421, 2577, 2642);
                return 0;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
            f_10421_2672_2700(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
            this_param)
            {
                var return_v = this_param.ToImmutableAndFree();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10421, 2672, 2700);
                return return_v;
            }


            int
            f_10421_2719_2764(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10421, 2719, 2764);
                return 0;
            }


            string
            f_10421_2921_2932(Microsoft.CodeAnalysis.CSharp.Symbol
            this_param)
            {
                var return_v = this_param.Name;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10421, 2921, 2932);
                return return_v;
            }


            bool
            f_10421_2902_2941(Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbol>
            this_param, string
            k, Microsoft.CodeAnalysis.CSharp.Symbol
            v)
            {
                var return_v = this_param.Add(k, v);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10421, 2902, 2941);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
            f_10421_2852_2860_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10421, 2852, 2860);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10421_7524_7550(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
            this_param)
            {
                var return_v = this_param.System_Object;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10421, 7524, 7550);
                return return_v;
            }

        }
    }
}
