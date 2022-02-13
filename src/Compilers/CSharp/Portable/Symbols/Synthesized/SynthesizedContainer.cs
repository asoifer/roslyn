// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class SynthesizedContainer : NamedTypeSymbol
    {
        private readonly ImmutableArray<TypeParameterSymbol> _typeParameters;

        private readonly ImmutableArray<TypeParameterSymbol> _constructedFromTypeParameters;

        protected SynthesizedContainer(string name, int parameterCount, bool returnsVoid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10666, 942, 1324);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 2993, 3026);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 4785, 4828);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 1048, 1075);

                f_10666_1048_1074(name != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 1089, 1101);

                Name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 1115, 1139);

                TypeMap = f_10666_1125_1138();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 1153, 1221);

                _typeParameters = f_10666_1171_1220(this, parameterCount, returnsVoid);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 1235, 1313);

                _constructedFromTypeParameters = default(ImmutableArray<TypeParameterSymbol>);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10666, 942, 1324);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 942, 1324);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 942, 1324);
            }
        }

        protected SynthesizedContainer(string name, MethodSymbol containingMethod)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10666, 1336, 1885);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 2993, 3026);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 4785, 4828);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 1435, 1462);

                f_10666_1435_1461(name != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 1476, 1488);

                Name = name;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 1502, 1874) || true) && (containingMethod == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10666, 1502, 1874);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 1564, 1588);

                    TypeMap = f_10666_1574_1587();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 1606, 1666);

                    _typeParameters = ImmutableArray<TypeParameterSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10666, 1502, 1874);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10666, 1502, 1874);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 1732, 1859);

                    TypeMap = f_10666_1742_1858(f_10666_1742_1755(), containingMethod, this, out _typeParameters, out _constructedFromTypeParameters);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10666, 1502, 1874);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10666, 1336, 1885);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 1336, 1885);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 1336, 1885);
            }
        }

        protected SynthesizedContainer(string name, ImmutableArray<TypeParameterSymbol> typeParameters, TypeMap typeMap)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10666, 1897, 2277);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 2993, 3026);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 4785, 4828);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 2034, 2061);

                f_10666_2034_2060(name != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 2075, 2115);

                f_10666_2075_2114(f_10666_2088_2113_M(!typeParameters.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 2129, 2159);

                f_10666_2129_2158(typeMap != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 2175, 2187);

                Name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 2201, 2234);

                _typeParameters = typeParameters;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 2248, 2266);

                TypeMap = typeMap;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10666, 1897, 2277);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 1897, 2277);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 1897, 2277);
            }
        }

        private ImmutableArray<TypeParameterSymbol> CreateTypeParameters(int parameterCount, bool returnsVoid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 2289, 2981);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 2416, 2523);

                var
                typeParameters = f_10666_2437_2522(parameterCount + ((DynAbs.Tracing.TraceSender.Conditional_F1(10666, 2501, 2512) || ((returnsVoid && DynAbs.Tracing.TraceSender.Conditional_F2(10666, 2515, 2516)) || DynAbs.Tracing.TraceSender.Conditional_F3(10666, 2519, 2520))) ? 0 : 1))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 2546, 2551);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 2537, 2723) || true) && (i < parameterCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 2573, 2576)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10666, 2537, 2723))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10666, 2537, 2723);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 2610, 2708);

                        f_10666_2610_2707(typeParameters, f_10666_2629_2706(this, i, "T" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => ((i + 1)).ToString(), 10666, 2698, 2705)));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10666, 1, 187);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10666, 1, 187);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 2739, 2911) || true) && (!returnsVoid)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10666, 2739, 2911);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 2789, 2896);

                    f_10666_2789_2895(typeParameters, f_10666_2808_2894(this, parameterCount, "TResult"));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10666, 2739, 2911);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 2927, 2970);

                return f_10666_2934_2969(typeParameters);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 2289, 2981);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10666_2437_2522(int
                capacity)
                {
                    var return_v = ArrayBuilder<TypeParameterSymbol>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10666, 2437, 2522);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeParameterSymbol
                f_10666_2629_2706(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedContainer
                container, int
                ordinal, string
                name)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeParameterSymbol((Microsoft.CodeAnalysis.CSharp.Symbol)container, ordinal, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10666, 2629, 2706);
                    return return_v;
                }


                int
                f_10666_2610_2707(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeParameterSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10666, 2610, 2707);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeParameterSymbol
                f_10666_2808_2894(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedContainer
                container, int
                ordinal, string
                name)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeParameterSymbol((Microsoft.CodeAnalysis.CSharp.Symbol)container, ordinal, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10666, 2808, 2894);
                    return return_v;
                }


                int
                f_10666_2789_2895(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeParameterSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10666, 2789, 2895);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10666_2934_2969(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10666, 2934, 2969);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 2289, 2981);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 2289, 2981);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal TypeMap TypeMap { get; }

        internal virtual MethodSymbol Constructor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 3080, 3087);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 3083, 3087);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 3080, 3087);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 3080, 3087);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 3080, 3087);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool IsInterface
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 3142, 3180);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 3145, 3180);
                    return f_10666_3145_3158(this) == TypeKind.Interface; DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 3142, 3180);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 3142, 3180);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 3142, 3180);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override void AddSynthesizedAttributes(PEModuleBuilder moduleBuilder, ref ArrayBuilder<SynthesizedAttributeData> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 3193, 4220);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 3351, 3412);

                // LAFHIS
                //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AddSynthesizedAttributes(moduleBuilder, ref attributes), 10666, 3351, 3411);
                base.AddSynthesizedAttributes(moduleBuilder, ref attributes);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10666, 3351, 3411);
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 3428, 3628) || true) && (f_10666_3432_3453(f_10666_3432_3448()) == SymbolKind.NamedType && (DynAbs.Tracing.TraceSender.Expression_True(10666, 3432, 3572) && (f_10666_3482_3519(f_10666_3482_3498()) || (DynAbs.Tracing.TraceSender.Expression_False(10666, 3482, 3571) || f_10666_3523_3539() is SimpleProgramNamedTypeSymbol))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10666, 3428, 3628);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 3606, 3613);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10666, 3428, 3628);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 3644, 3700);

                var
                compilation = f_10666_3662_3699(f_10666_3662_3678())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 3926, 4017);

                f_10666_3926_4016(compilation != null, "SynthesizedClass is not contained in a source module?");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 4033, 4209);

                f_10666_4033_4208(ref attributes, f_10666_4073_4207(compilation, WellKnownMember.System_Runtime_CompilerServices_CompilerGeneratedAttribute__ctor));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 3193, 4220);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10666_3432_3448()
                {
                    var return_v = ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10666, 3432, 3448);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10666_3432_3453(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10666, 3432, 3453);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10666_3482_3498()
                {
                    var return_v = ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10666, 3482, 3498);
                    return return_v;
                }


                bool
                f_10666_3482_3519(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.IsImplicitlyDeclared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10666, 3482, 3519);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10666_3523_3539()
                {
                    var return_v = ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10666, 3523, 3539);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10666_3662_3678()
                {
                    var return_v = ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10666, 3662, 3678);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10666_3662_3699(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10666, 3662, 3699);
                    return return_v;
                }


                int
                f_10666_3926_4016(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10666, 3926, 4016);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10666_4073_4207(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10666, 4073, 4207);
                    return return_v;
                }


                int
                f_10666_4033_4208(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10666, 4033, 4208);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 3193, 4220);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 3193, 4220);
            }
        }

        protected override NamedTypeSymbol WithTupleDataCore(TupleExtraData newData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 4322, 4361);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 4325, 4361);
                throw f_10666_4331_4361(); DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 4322, 4361);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 4322, 4361);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 4322, 4361);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Exception
            f_10666_4331_4361()
            {
                var return_v = ExceptionUtilities.Unreachable;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10666, 4331, 4361);
                return return_v;
            }

        }

        internal ImmutableArray<TypeParameterSymbol> ConstructedFromTypeParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 4634, 4667);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 4637, 4667);
                    return _constructedFromTypeParameters; DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 4634, 4667);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 4634, 4667);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 4634, 4667);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<TypeParameterSymbol> TypeParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 4754, 4772);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 4757, 4772);
                    return _typeParameters; DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 4754, 4772);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 4754, 4772);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 4754, 4772);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override string Name { get; }

        public override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 4891, 4924);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 4894, 4924);
                    return ImmutableArray<Location>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 4891, 4924);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 4891, 4924);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 4891, 4924);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 5011, 5051);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 5014, 5051);
                    return ImmutableArray<SyntaxReference>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 5011, 5051);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 5011, 5051);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 5011, 5051);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override IEnumerable<string> MemberNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 5112, 5163);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 5115, 5163);
                    return f_10666_5115_5163(); DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 5112, 5163);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 5112, 5163);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 5112, 5163);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 5224, 5231);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 5227, 5231);
                    return this; DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 5224, 5231);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 5224, 5231);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 5224, 5231);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 5274, 5281);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 5277, 5281);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 5274, 5281);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 5274, 5281);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 5274, 5281);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 5326, 5392);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 5329, 5392);
                    return (object)f_10666_5337_5348() == null && (DynAbs.Tracing.TraceSender.Expression_True(10666, 5329, 5392) && f_10666_5360_5373(this) != TypeKind.Struct); DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 5326, 5392);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 5326, 5392);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 5326, 5392);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 5532, 5582);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 5538, 5580);

                    return f_10666_5545_5579(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 5532, 5582);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10666_5545_5579(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedContainer
                    this_param)
                    {
                        var return_v = this_param.GetTypeParametersAsTypeArguments();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10666, 5545, 5579);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 5405, 5593);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 5405, 5593);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 5661, 5669);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 5664, 5669);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 5661, 5669);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 5661, 5669);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 5661, 5669);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<Symbol> GetMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 5682, 5924);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 5758, 5796);

                Symbol
                constructor = f_10666_5779_5795(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 5810, 5913);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10666, 5817, 5844) || (((object)constructor == null && DynAbs.Tracing.TraceSender.Conditional_F2(10666, 5847, 5875)) || DynAbs.Tracing.TraceSender.Conditional_F3(10666, 5878, 5912))) ? ImmutableArray<Symbol>.Empty : f_10666_5878_5912(constructor);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 5682, 5924);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10666_5779_5795(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedContainer
                this_param)
                {
                    var return_v = this_param.Constructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10666, 5779, 5795);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10666_5878_5912(Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10666, 5878, 5912);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 5682, 5924);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 5682, 5924);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<Symbol> GetMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 5936, 6191);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 6023, 6046);

                var
                ctor = f_10666_6034_6045()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 6060, 6180);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10666, 6067, 6110) || ((((object)ctor != null && (DynAbs.Tracing.TraceSender.Expression_True(10666, 6068, 6109) && name == f_10666_6100_6109(ctor))) && DynAbs.Tracing.TraceSender.Conditional_F2(10666, 6113, 6148)) || DynAbs.Tracing.TraceSender.Conditional_F3(10666, 6151, 6179))) ? f_10666_6113_6148(ctor) : ImmutableArray<Symbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 5936, 6191);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10666_6034_6045()
                {
                    var return_v = Constructor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10666, 6034, 6045);
                    return return_v;
                }


                string
                f_10666_6100_6109(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10666, 6100, 6109);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10666_6113_6148(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                item)
                {
                    var return_v = ImmutableArray.Create<Symbol>((Microsoft.CodeAnalysis.CSharp.Symbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10666, 6113, 6148);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 5936, 6191);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 5936, 6191);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override IEnumerable<FieldSymbol> GetFieldsToEmit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 6203, 6566);

                var listYield = new List<FieldSymbol>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 6288, 6555);
                    foreach (var m in f_10666_6306_6323_I(f_10666_6306_6323(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10666, 6288, 6555);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 6357, 6540);

                        switch (f_10666_6365_6371(m))
                        {

                            case SymbolKind.Field:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10666, 6357, 6540);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 6461, 6489);

                                listYield.Add((FieldSymbol)m);
                                DynAbs.Tracing.TraceSender.TraceBreak(10666, 6515, 6521);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10666, 6357, 6540);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10666, 6288, 6555);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10666, 1, 268);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10666, 1, 268);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 6203, 6566);

                return listYield;

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10666_6306_6323(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedContainer
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10666, 6306, 6323);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10666_6365_6371(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10666, 6365, 6371);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10666_6306_6323_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10666, 6306, 6323);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 6203, 6566);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 6203, 6566);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<Symbol> GetEarlyAttributeDecodingMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 6654, 6683);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 6657, 6683);
                return f_10666_6657_6683(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 6654, 6683);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 6654, 6683);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 6654, 6683);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
            f_10666_6657_6683(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedContainer
            this_param)
            {
                var return_v = this_param.GetMembersUnordered();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10666, 6657, 6683);
                return return_v;
            }

        }

        internal override ImmutableArray<Symbol> GetEarlyAttributeDecodingMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 6783, 6807);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 6786, 6807);
                return f_10666_6786_6807(this, name); DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 6783, 6807);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 6783, 6807);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 6783, 6807);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
            f_10666_6786_6807(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedContainer
            this_param, string
            name)
            {
                var return_v = this_param.GetMembers(name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10666, 6786, 6807);
                return return_v;
            }

        }

        public override ImmutableArray<NamedTypeSymbol> GetTypeMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 6885, 6925);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 6888, 6925);
                return ImmutableArray<NamedTypeSymbol>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 6885, 6925);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 6885, 6925);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 6885, 6925);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<NamedTypeSymbol> GetTypeMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 7014, 7054);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 7017, 7054);
                return ImmutableArray<NamedTypeSymbol>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 7014, 7054);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 7014, 7054);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 7014, 7054);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<NamedTypeSymbol> GetTypeMembers(string name, int arity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 7154, 7194);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 7157, 7194);
                return ImmutableArray<NamedTypeSymbol>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 7154, 7194);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 7154, 7194);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 7154, 7194);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Accessibility DeclaredAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 7259, 7283);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 7262, 7283);
                    return Accessibility.Private; DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 7259, 7283);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 7259, 7283);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 7259, 7283);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 7326, 7334);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 7329, 7334);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 7326, 7334);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 7326, 7334);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 7326, 7334);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 7389, 7397);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 7392, 7397);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 7389, 7397);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 7389, 7397);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 7389, 7397);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 7449, 7457);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 7452, 7457);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 7449, 7457);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 7449, 7457);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 7449, 7457);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<NamedTypeSymbol> InterfacesNoUseSiteDiagnostics(ConsList<TypeSymbol> basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 7592, 7632);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 7595, 7632);
                return ImmutableArray<NamedTypeSymbol>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 7592, 7632);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 7592, 7632);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 7592, 7632);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<NamedTypeSymbol> GetInterfacesToEmit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 7717, 7747);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 7720, 7747);
                return f_10666_7720_7747(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 7717, 7747);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 7717, 7747);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 7717, 7747);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
            f_10666_7720_7747(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedContainer
            this_param)
            {
                var return_v = this_param.CalculateInterfacesToEmit();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10666, 7720, 7747);
                return return_v;
            }

        }

        internal override NamedTypeSymbol BaseTypeNoUseSiteDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 7823, 7952);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 7826, 7952);
                    return f_10666_7826_7952(f_10666_7826_7844(), (DynAbs.Tracing.TraceSender.Conditional_F1(10666, 7860, 7892) || ((f_10666_7860_7873(this) == TypeKind.Struct && DynAbs.Tracing.TraceSender.Conditional_F2(10666, 7895, 7923)) || DynAbs.Tracing.TraceSender.Conditional_F3(10666, 7926, 7951))) ? SpecialType.System_ValueType : SpecialType.System_Object); DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 7823, 7952);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 7823, 7952);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 7823, 7952);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override NamedTypeSymbol GetDeclaredBaseType(ConsList<TypeSymbol> basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 8060, 8091);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 8063, 8091);
                return f_10666_8063_8091(); DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 8060, 8091);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 8060, 8091);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 8060, 8091);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10666_8063_8091()
            {
                var return_v = BaseTypeNoUseSiteDiagnostics;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10666, 8063, 8091);
                return return_v;
            }

        }

        internal override ImmutableArray<NamedTypeSymbol> GetDeclaredInterfaces(ConsList<TypeSymbol> basesBeingResolved)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 8217, 8270);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 8220, 8270);
                return f_10666_8220_8270(this, basesBeingResolved); DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 8217, 8270);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 8217, 8270);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 8217, 8270);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
            f_10666_8220_8270(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedContainer
            this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
            basesBeingResolved)
            {
                var return_v = this_param.InterfacesNoUseSiteDiagnostics(basesBeingResolved);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10666, 8220, 8270);
                return return_v;
            }

        }

        public override bool MightContainExtensionMethods
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 8333, 8341);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 8336, 8341);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 8333, 8341);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 8333, 8341);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 8333, 8341);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 8380, 8404);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 8383, 8404);
                    return f_10666_8383_8397().Length; DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 8380, 8404);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 8380, 8404);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 8380, 8404);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 8451, 8463);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 8454, 8463);
                    return f_10666_8454_8459() > 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 8451, 8463);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 8451, 8463);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 8451, 8463);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 8518, 8525);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 8521, 8525);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 8518, 8525);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 8518, 8525);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 8518, 8525);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 8583, 8591);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 8586, 8591);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 8583, 8591);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 8583, 8591);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 8583, 8591);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 8650, 8658);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 8653, 8658);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 8650, 8658);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 8650, 8658);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 8650, 8658);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 8706, 8714);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 8709, 8714);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 8706, 8714);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 8706, 8714);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 8706, 8714);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 8796, 8803);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 8799, 8803);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 8796, 8803);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 8796, 8803);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 8796, 8803);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override ImmutableArray<string> GetAppliedConditionalSymbols()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 8895, 8926);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 8898, 8926);
                return ImmutableArray<string>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 8895, 8926);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 8895, 8926);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 8895, 8926);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool HasDeclarativeSecurity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 8985, 8993);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 8988, 8993);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 8985, 8993);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 8985, 8993);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 8985, 8993);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 9051, 9079);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 9054, 9079);
                    return f_10666_9054_9079(); DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 9051, 9079);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 9051, 9079);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 9051, 9079);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 9128, 9136);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 9131, 9136);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 9128, 9136);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 9128, 9136);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 9128, 9136);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override IEnumerable<Cci.SecurityAttribute> GetSecurityInformation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 9149, 9299);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 9251, 9288);

                throw f_10666_9257_9287();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 9149, 9299);

                System.Exception
                f_10666_9257_9287()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10666, 9257, 9287);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 9149, 9299);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 9149, 9299);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override AttributeUsageInfo GetAttributeUsageInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 9372, 9402);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 9375, 9402);
                return default(AttributeUsageInfo); DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 9372, 9402);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 9372, 9402);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 9372, 9402);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override TypeLayout Layout
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 9451, 9473);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 9454, 9473);
                    return default(TypeLayout); DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 9451, 9473);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 9451, 9473);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 9451, 9473);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 9524, 9532);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 9527, 9532);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 9524, 9532);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 9524, 9532);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 9524, 9532);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override NamedTypeSymbol AsNativeInteger()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 9604, 9643);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 9607, 9643);
                throw f_10666_9613_9643(); DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 9604, 9643);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 9604, 9643);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 9604, 9643);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Exception
            f_10666_9613_9643()
            {
                var return_v = ExceptionUtilities.Unreachable;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10666, 9613, 9643);
                return return_v;
            }

        }

        internal sealed override NamedTypeSymbol NativeIntegerUnderlyingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10666, 9725, 9732);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10666, 9728, 9732);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10666, 9725, 9732);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10666, 9725, 9732);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 9725, 9732);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static SynthesizedContainer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10666, 688, 9740);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10666, 688, 9740);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10666, 688, 9740);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10666, 688, 9740);

        int
        f_10666_1048_1074(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10666, 1048, 1074);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
        f_10666_1125_1138()
        {
            var return_v = TypeMap.Empty;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10666, 1125, 1138);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
        f_10666_1171_1220(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedContainer
        this_param, int
        parameterCount, bool
        returnsVoid)
        {
            var return_v = this_param.CreateTypeParameters(parameterCount, returnsVoid);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10666, 1171, 1220);
            return return_v;
        }


        int
        f_10666_1435_1461(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10666, 1435, 1461);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
        f_10666_1574_1587()
        {
            var return_v = TypeMap.Empty;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10666, 1574, 1587);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
        f_10666_1742_1755()
        {
            var return_v = TypeMap.Empty;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10666, 1742, 1755);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
        f_10666_1742_1858(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        oldOwner, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedContainer
        newOwner, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
        newTypeParameters, out System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
        oldTypeParameters)
        {
            var return_v = this_param.WithConcatAlphaRename(oldOwner, (Microsoft.CodeAnalysis.CSharp.Symbol)newOwner, out newTypeParameters, out oldTypeParameters);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10666, 1742, 1858);
            return return_v;
        }


        int
        f_10666_2034_2060(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10666, 2034, 2060);
            return 0;
        }


        bool
        f_10666_2088_2113_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10666, 2088, 2113);
            return return_v;
        }


        int
        f_10666_2075_2114(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10666, 2075, 2114);
            return 0;
        }


        int
        f_10666_2129_2158(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10666, 2129, 2158);
            return 0;
        }


        Microsoft.CodeAnalysis.TypeKind
        f_10666_3145_3158(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedContainer
        this_param)
        {
            var return_v = this_param.TypeKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10666, 3145, 3158);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<string>
        f_10666_5115_5163()
        {
            var return_v = SpecializedCollections.EmptyEnumerable<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10666, 5115, 5163);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        f_10666_5337_5348()
        {
            var return_v = Constructor;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10666, 5337, 5348);
            return return_v;
        }


        Microsoft.CodeAnalysis.TypeKind
        f_10666_5360_5373(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedContainer
        this_param)
        {
            var return_v = this_param.TypeKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10666, 5360, 5373);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        f_10666_7826_7844()
        {
            var return_v = ContainingAssembly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10666, 7826, 7844);
            return return_v;
        }


        Microsoft.CodeAnalysis.TypeKind
        f_10666_7860_7873(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedContainer
        this_param)
        {
            var return_v = this_param.TypeKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10666, 7860, 7873);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10666_7826_7952(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        this_param, Microsoft.CodeAnalysis.SpecialType
        type)
        {
            var return_v = this_param.GetSpecialType(type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10666, 7826, 7952);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
        f_10666_8383_8397()
        {
            var return_v = TypeParameters;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10666, 8383, 8397);
            return return_v;
        }


        int
        f_10666_8454_8459()
        {
            var return_v = Arity;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10666, 8454, 8459);
            return return_v;
        }


        System.Runtime.InteropServices.CharSet
        f_10666_9054_9079()
        {
            var return_v = DefaultMarshallingCharSet;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10666, 9054, 9079);
            return return_v;
        }

    }
}
