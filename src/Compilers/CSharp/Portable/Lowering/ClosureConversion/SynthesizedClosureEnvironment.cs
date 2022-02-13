// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class SynthesizedClosureEnvironment : SynthesizedContainer, ISynthesizedMethodBodyImplementationSymbol
    {
        private readonly MethodSymbol _topLevelMethod;

        internal readonly SyntaxNode ScopeSyntaxOpt;

        internal readonly int ClosureOrdinal;

        internal readonly MethodSymbol OriginalContainingMethodOpt;

        internal readonly FieldSymbol SingletonCache;

        internal readonly MethodSymbol StaticConstructor;

        private ArrayBuilder<Symbol> _membersBuilder;

        private ImmutableArray<Symbol> _members;

        public override TypeKind TypeKind { get; }

        internal override MethodSymbol Constructor { get; }

        internal SynthesizedClosureEnvironment(
                    MethodSymbol topLevelMethod,
                    MethodSymbol containingMethod,
                    bool isStruct,
                    SyntaxNode scopeSyntaxOpt,
                    DebugId methodId,
                    DebugId closureId)
        : base(f_10457_2041_2086_C(f_10457_2041_2086(scopeSyntaxOpt, methodId, closureId)), containingMethod)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10457, 1764, 3054);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 906, 921);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 961, 975);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 1008, 1022);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 1351, 1378);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 1419, 1433);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 1475, 1492);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 1534, 1586);
                this._membersBuilder = f_10457_1552_1586(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 1649, 1691);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 1701, 1752);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 2130, 2185);

                TypeKind = (DynAbs.Tracing.TraceSender.Conditional_F1(10457, 2141, 2149) || ((isStruct && DynAbs.Tracing.TraceSender.Conditional_F2(10457, 2152, 2167)) || DynAbs.Tracing.TraceSender.Conditional_F3(10457, 2170, 2184))) ? TypeKind.Struct : TypeKind.Class;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 2199, 2232);

                _topLevelMethod = topLevelMethod;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 2246, 2293);

                OriginalContainingMethodOpt = containingMethod;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 2307, 2390);

                Constructor = (DynAbs.Tracing.TraceSender.Conditional_F1(10457, 2321, 2329) || ((isStruct && DynAbs.Tracing.TraceSender.Conditional_F2(10457, 2332, 2336)) || DynAbs.Tracing.TraceSender.Conditional_F3(10457, 2339, 2389))) ? null : f_10457_2339_2389(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 2404, 2444);

                this.ClosureOrdinal = closureId.Ordinal;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 2553, 2933) || true) && (scopeSyntaxOpt == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10457, 2553, 2933);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 2613, 2672);

                    StaticConstructor = f_10457_2633_2671(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 2690, 2764);

                    var
                    cacheVariableName = f_10457_2714_2763()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 2782, 2918);

                    SingletonCache = f_10457_2799_2917(this, this, cacheVariableName, topLevelMethod, isReadOnly: true, isStatic: true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10457, 2553, 2933);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 2949, 2992);

                f_10457_2949_2991(scopeSyntaxOpt);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 3006, 3043);

                this.ScopeSyntaxOpt = scopeSyntaxOpt;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10457, 1764, 3054);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10457, 1764, 3054);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10457, 1764, 3054);
            }
        }

        internal void AddHoistedField(LambdaCapturedVariable captured)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10457, 3129, 3161);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 3132, 3161);
                f_10457_3132_3161(_membersBuilder, captured); DynAbs.Tracing.TraceSender.TraceExitMethod(10457, 3129, 3161);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10457, 3129, 3161);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10457, 3129, 3161);
            }

            int
            f_10457_3132_3161(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
            this_param, Microsoft.CodeAnalysis.CSharp.LambdaCapturedVariable
            item)
            {
                this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10457, 3132, 3161);
                return 0;
            }

        }

        private static string MakeName(SyntaxNode scopeSyntaxOpt, DebugId methodId, DebugId closureId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10457, 3174, 3915);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 3293, 3709) || true) && (scopeSyntaxOpt == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10457, 3293, 3709);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 3600, 3694);

                    return f_10457_3607_3693(methodId.Ordinal, methodId.Generation);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10457, 3293, 3709);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 3725, 3761);

                f_10457_3725_3760(methodId.Ordinal >= 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 3775, 3904);

                return f_10457_3782_3903(methodId.Ordinal, methodId.Generation, closureId.Ordinal, closureId.Generation);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10457, 3174, 3915);

                string
                f_10457_3607_3693(int
                methodOrdinal, int
                generation)
                {
                    var return_v = GeneratedNames.MakeStaticLambdaDisplayClassName(methodOrdinal, generation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10457, 3607, 3693);
                    return return_v;
                }


                int
                f_10457_3725_3760(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10457, 3725, 3760);
                    return 0;
                }


                string
                f_10457_3782_3903(int
                methodOrdinal, int
                generation, int
                closureOrdinal, int
                closureGeneration)
                {
                    var return_v = GeneratedNames.MakeLambdaDisplayClassName(methodOrdinal, generation, closureOrdinal, closureGeneration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10457, 3782, 3903);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10457, 3174, 3915);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10457, 3174, 3915);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [Conditional("DEBUG")]
        private static void AssertIsClosureScopeSyntax(SyntaxNode syntaxOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10457, 3927, 4485);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 4205, 4282) || true) && (syntaxOpt == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10457, 4205, 4282);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 4260, 4267);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10457, 4205, 4282);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 4298, 4399) || true) && (f_10457_4302_4343(syntaxOpt))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10457, 4298, 4399);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 4377, 4384);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10457, 4298, 4399);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 4415, 4474);

                throw f_10457_4421_4473(f_10457_4456_4472(syntaxOpt));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10457, 3927, 4485);

                bool
                f_10457_4302_4343(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = LambdaUtilities.IsClosureScope(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10457, 4302, 4343);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10457_4456_4472(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10457, 4456, 4472);
                    return return_v;
                }


                System.Exception
                f_10457_4421_4473(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10457, 4421, 4473);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10457, 3927, 4485);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10457, 3927, 4485);
            }
        }

        public override ImmutableArray<Symbol> GetMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10457, 4497, 5067);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 4573, 5024) || true) && (_members.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10457, 4573, 5024);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 4629, 4659);

                    var
                    builder = _membersBuilder
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 4677, 4856) || true) && ((object)StaticConstructor != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10457, 4677, 4856);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 4756, 4787);

                        f_10457_4756_4786(builder, StaticConstructor);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 4809, 4837);

                        f_10457_4809_4836(builder, SingletonCache);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10457, 4677, 4856);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 4874, 4910);

                    f_10457_4874_4909(builder, DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetMembers(), 10457, 4891, 4908));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 4928, 4968);

                    _members = f_10457_4939_4967(builder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 4986, 5009);

                    _membersBuilder = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10457, 4573, 5024);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 5040, 5056);

                return _members;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10457, 4497, 5067);

                int
                f_10457_4756_4786(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10457, 4756, 4786);
                    return 0;
                }


                int
                f_10457_4809_4836(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10457, 4809, 4836);
                    return 0;
                }


                int
                f_10457_4874_4909(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10457, 4874, 4909);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10457_4939_4967(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10457, 4939, 4967);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10457, 4497, 5067);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10457, 4497, 5067);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override IEnumerable<FieldSymbol> GetFieldsToEmit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10457, 5377, 5553);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 5380, 5553);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(10457, 5380, 5410) || (((object)SingletonCache != null
                && DynAbs.Tracing.TraceSender.Conditional_F2(10457, 5426, 5484)) || DynAbs.Tracing.TraceSender.Conditional_F3(10457, 5500, 5553))) ? f_10457_5426_5484(SingletonCache) : f_10457_5500_5553(); DynAbs.Tracing.TraceSender.TraceExitMethod(10457, 5377, 5553);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10457, 5377, 5553);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10457, 5377, 5553);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
            f_10457_5426_5484(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
            value)
            {
                var return_v = SpecializedCollections.SingletonEnumerable(value);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10457, 5426, 5484);
                return return_v;
            }


            System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
            f_10457_5500_5553()
            {
                var return_v = SpecializedCollections.EmptyEnumerable<FieldSymbol>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10457, 5500, 5553);
                return return_v;
            }

        }

        public override bool IsSerializable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10457, 5693, 5726);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 5696, 5726);
                    return (object)SingletonCache != null; DynAbs.Tracing.TraceSender.TraceExitMethod(10457, 5693, 5726);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10457, 5693, 5726);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10457, 5693, 5726);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10457, 5779, 5814);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 5782, 5814);
                    return f_10457_5782_5814(_topLevelMethod); DynAbs.Tracing.TraceSender.TraceExitMethod(10457, 5779, 5814);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10457, 5779, 5814);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10457, 5779, 5814);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10457, 6092, 6099);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 6095, 6099);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(10457, 6092, 6099);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10457, 6092, 6099);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10457, 6092, 6099);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool ISynthesizedMethodBodyImplementationSymbol.HasMethodBodyDependency
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10457, 6249, 6256);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 6252, 6256);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(10457, 6249, 6256);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10457, 6249, 6256);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10457, 6249, 6256);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IMethodSymbolInternal ISynthesizedMethodBodyImplementationSymbol.Method
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10457, 6341, 6359);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 6344, 6359);
                    return _topLevelMethod; DynAbs.Tracing.TraceSender.TraceExitMethod(10457, 6341, 6359);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10457, 6341, 6359);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10457, 6341, 6359);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10457, 6404, 6412);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 6407, 6412);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10457, 6404, 6412);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10457, 6404, 6412);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10457, 6404, 6412);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasPossibleWellKnownCloneMethod()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10457, 6480, 6488);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10457, 6483, 6488);
                return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10457, 6480, 6488);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10457, 6480, 6488);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10457, 6480, 6488);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SynthesizedClosureEnvironment()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10457, 741, 6496);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10457, 741, 6496);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10457, 741, 6496);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10457, 741, 6496);

        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
        f_10457_1552_1586()
        {
            var return_v = ArrayBuilder<Symbol>.GetInstance();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10457, 1552, 1586);
            return return_v;
        }


        static string
        f_10457_2041_2086(Microsoft.CodeAnalysis.SyntaxNode
        scopeSyntaxOpt, Microsoft.CodeAnalysis.CodeGen.DebugId
        methodId, Microsoft.CodeAnalysis.CodeGen.DebugId
        closureId)
        {
            var return_v = MakeName(scopeSyntaxOpt, methodId, closureId);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10457, 2041, 2086);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironmentConstructor
        f_10457_2339_2389(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment
        frame)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironmentConstructor(frame);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10457, 2339, 2389);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedStaticConstructor
        f_10457_2633_2671(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment
        containingType)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedStaticConstructor((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)containingType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10457, 2633, 2671);
            return return_v;
        }


        string
        f_10457_2714_2763()
        {
            var return_v = GeneratedNames.MakeCachedFrameInstanceFieldName();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10457, 2714, 2763);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLambdaCacheFieldSymbol
        f_10457_2799_2917(Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment
        containingType, Microsoft.CodeAnalysis.CSharp.SynthesizedClosureEnvironment
        type, string
        name, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        topLevelMethod, bool
        isReadOnly, bool
        isStatic)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLambdaCacheFieldSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)containingType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, name, topLevelMethod, isReadOnly: isReadOnly, isStatic: isStatic);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10457, 2799, 2917);
            return return_v;
        }


        int
        f_10457_2949_2991(Microsoft.CodeAnalysis.SyntaxNode?
        syntaxOpt)
        {
            AssertIsClosureScopeSyntax(syntaxOpt);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10457, 2949, 2991);
            return 0;
        }


        static string
        f_10457_2041_2086_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10457, 1764, 3054);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbol
        f_10457_5782_5814(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ContainingSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10457, 5782, 5814);
            return return_v;
        }

    }
}
