// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SubstitutedNestedTypeSymbol : SubstitutedNamedTypeSymbol
    {
        internal SubstitutedNestedTypeSymbol(SubstitutedNamedTypeSymbol newContainer, NamedTypeSymbol originalDefinition)
        : base(
                        newContainer: f_10096_808_834_C(newContainer), map: f_10096_858_887(newContainer), originalDefinition: originalDefinition,                // An Arity-0 member of an unbound type, e.g. A<>.B, is unbound.
                        unbound: f_10096_1054_1087(newContainer) && (DynAbs.Tracing.TraceSender.Expression_True(10096, 1054, 1120) && f_10096_1091_1115(originalDefinition) == 0))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10096, 656, 1143);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10096, 656, 1143);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10096, 656, 1143);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10096, 656, 1143);
            }
        }

        internal override ImmutableArray<TypeWithAnnotations> TypeArgumentsWithAnnotationsNoUseSiteDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10096, 1282, 1332);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10096, 1288, 1330);

                    return f_10096_1295_1329(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10096, 1282, 1332);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10096_1295_1329(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNestedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetTypeParametersAsTypeArguments();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10096, 1295, 1329);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10096, 1155, 1343);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10096, 1155, 1343);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10096, 1427, 1447);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10096, 1433, 1445);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10096, 1427, 1447);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10096, 1355, 1458);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10096, 1355, 1458);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10096, 1538, 1583);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10096, 1544, 1581);

                    throw f_10096_1550_1580();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10096, 1538, 1583);

                    System.Exception
                    f_10096_1550_1580()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10096, 1550, 1580);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10096, 1470, 1594);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10096, 1470, 1594);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override NamedTypeSymbol WithTupleDataCore(TupleExtraData newData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10096, 1606, 1755);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10096, 1707, 1744);

                throw f_10096_1713_1743();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10096, 1606, 1755);

                System.Exception
                f_10096_1713_1743()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10096, 1713, 1743);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10096, 1606, 1755);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10096, 1606, 1755);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SubstitutedNestedTypeSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10096, 561, 1762);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10096, 561, 1762);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10096, 561, 1762);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10096, 561, 1762);

        static Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
        f_10096_858_887(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNamedTypeSymbol
        this_param)
        {
            var return_v = this_param.TypeSubstitution;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10096, 858, 887);
            return return_v;
        }


        static bool
        f_10096_1054_1087(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNamedTypeSymbol
        this_param)
        {
            var return_v = this_param.IsUnboundGenericType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10096, 1054, 1087);
            return return_v;
        }


        static int
        f_10096_1091_1115(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.Arity;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10096, 1091, 1115);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbol
        f_10096_808_834_C(Microsoft.CodeAnalysis.CSharp.Symbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10096, 656, 1143);
            return return_v;
        }

    }
    internal sealed class ConstructedNamedTypeSymbol : SubstitutedNamedTypeSymbol
    {
        private readonly ImmutableArray<TypeWithAnnotations> _typeArgumentsWithAnnotations;

        private readonly NamedTypeSymbol _constructedFrom;

        internal ConstructedNamedTypeSymbol(NamedTypeSymbol constructedFrom, ImmutableArray<TypeWithAnnotations> typeArgumentsWithAnnotations, bool unbound = false, TupleExtraData tupleData = null)
        : base(newContainer: f_10096_2390_2436_C(f_10096_2404_2436(constructedFrom)), map: f_10096_2463_2587(f_10096_2475_2505(constructedFrom), f_10096_2507_2556(f_10096_2507_2541(constructedFrom)), typeArgumentsWithAnnotations), originalDefinition: f_10096_2629_2663(constructedFrom), constructedFrom: constructedFrom, unbound: unbound, tupleData: tupleData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10096, 2180, 3050);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10096, 2151, 2167);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10096, 2783, 2844);

                _typeArgumentsWithAnnotations = typeArgumentsWithAnnotations;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10096, 2858, 2893);

                _constructedFrom = constructedFrom;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10096, 2909, 2984);

                f_10096_2909_2983(f_10096_2922_2943(constructedFrom) == typeArgumentsWithAnnotations.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10096, 2998, 3039);

                f_10096_2998_3038(f_10096_3011_3032(constructedFrom) != 0);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10096, 2180, 3050);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10096, 2180, 3050);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10096, 2180, 3050);
            }
        }

        protected override NamedTypeSymbol WithTupleDataCore(TupleExtraData newData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10096, 3062, 3303);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10096, 3163, 3292);

                return f_10096_3170_3291(_constructedFrom, _typeArgumentsWithAnnotations, f_10096_3250_3270(), tupleData: newData);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10096, 3062, 3303);

                bool
                f_10096_3250_3270()
                {
                    var return_v = IsUnboundGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10096, 3250, 3270);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ConstructedNamedTypeSymbol
                f_10096_3170_3291(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                constructedFrom, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArgumentsWithAnnotations, bool
                unbound, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol.TupleExtraData
                tupleData)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ConstructedNamedTypeSymbol(constructedFrom, typeArgumentsWithAnnotations, unbound, tupleData: tupleData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10096, 3170, 3291);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10096, 3062, 3303);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10096, 3062, 3303);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override NamedTypeSymbol ConstructedFrom
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10096, 3387, 3462);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10096, 3423, 3447);

                    return _constructedFrom;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10096, 3387, 3462);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10096, 3315, 3473);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10096, 3315, 3473);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10096, 3612, 3700);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10096, 3648, 3685);

                    return _typeArgumentsWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10096, 3612, 3700);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10096, 3485, 3711);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10096, 3485, 3711);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static bool TypeParametersMatchTypeArguments(ImmutableArray<TypeParameterSymbol> typeParameters, ImmutableArray<TypeWithAnnotations> typeArguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10096, 3723, 4288);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10096, 3904, 3934);

                int
                n = typeParameters.Length
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10096, 3948, 3988);

                f_10096_3948_3987(typeArguments.Length == n);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10096, 4002, 4041);

                f_10096_4002_4040(typeArguments.Length > 0);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10096, 4066, 4071);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10096, 4057, 4249) || true) && (i < n)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10096, 4080, 4083)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10096, 4057, 4249))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10096, 4057, 4249);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10096, 4117, 4234) || true) && (!typeArguments[i].Is(typeParameters[i]))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10096, 4117, 4234);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10096, 4202, 4215);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10096, 4117, 4234);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10096, 1, 193);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10096, 1, 193);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10096, 4265, 4277);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10096, 3723, 4288);

                int
                f_10096_3948_3987(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10096, 3948, 3987);
                    return 0;
                }


                int
                f_10096_4002_4040(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10096, 4002, 4040);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10096, 3723, 4288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10096, 3723, 4288);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override bool GetUnificationUseSiteDiagnosticRecursive(ref DiagnosticInfo result, Symbol owner, ref HashSet<TypeSymbol> checkedTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10096, 4300, 5170);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10096, 4474, 4761) || true) && (f_10096_4478_4571(f_10096_4478_4493(), ref result, owner, ref checkedTypes) || (DynAbs.Tracing.TraceSender.Expression_False(10096, 4478, 4700) || f_10096_4592_4700(ref result, _typeArgumentsWithAnnotations, owner, ref checkedTypes)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10096, 4474, 4761);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10096, 4734, 4746);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10096, 4474, 4761);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10096, 4777, 4851);

                var
                typeArguments = f_10096_4797_4850(this)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10096, 4865, 5130);
                    foreach (var typeArg in f_10096_4889_4902_I(typeArguments))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10096, 4865, 5130);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10096, 4936, 5115) || true) && (f_10096_4940_5042(ref result, typeArg.CustomModifiers, owner, ref checkedTypes))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10096, 4936, 5115);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10096, 5084, 5096);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10096, 4936, 5115);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10096, 4865, 5130);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10096, 1, 266);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10096, 1, 266);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10096, 5146, 5159);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10096, 4300, 5170);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10096_4478_4493()
                {
                    var return_v = ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10096, 4478, 4493);
                    return return_v;
                }


                bool
                f_10096_4478_4571(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo
                result, Microsoft.CodeAnalysis.CSharp.Symbol
                owner, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                checkedTypes)
                {
                    var return_v = this_param.GetUnificationUseSiteDiagnosticRecursive(ref result, owner, ref checkedTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10096, 4478, 4571);
                    return return_v;
                }


                bool
                f_10096_4592_4700(ref Microsoft.CodeAnalysis.DiagnosticInfo
                result, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                types, Microsoft.CodeAnalysis.CSharp.Symbol
                owner, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                checkedTypes)
                {
                    var return_v = GetUnificationUseSiteDiagnosticRecursive(ref result, types, owner, ref checkedTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10096, 4592, 4700);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10096_4797_4850(Microsoft.CodeAnalysis.CSharp.Symbols.ConstructedNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10096, 4797, 4850);
                    return return_v;
                }


                bool
                f_10096_4940_5042(ref Microsoft.CodeAnalysis.DiagnosticInfo
                result, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                modifiers, Microsoft.CodeAnalysis.CSharp.Symbol
                owner, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                checkedTypes)
                {
                    var return_v = GetUnificationUseSiteDiagnosticRecursive(ref result, modifiers, owner, ref checkedTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10096, 4940, 5042);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10096_4889_4902_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10096, 4889, 4902);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10096, 4300, 5170);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10096, 4300, 5170);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override bool AreLocalsZeroed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10096, 5250, 5295);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10096, 5256, 5293);

                    throw f_10096_5262_5292();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10096, 5250, 5295);

                    System.Exception
                    f_10096_5262_5292()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10096, 5262, 5292);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10096, 5182, 5306);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10096, 5182, 5306);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static ConstructedNamedTypeSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10096, 1931, 5313);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10096, 1931, 5313);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10096, 1931, 5313);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10096, 1931, 5313);

        static Microsoft.CodeAnalysis.CSharp.Symbol
        f_10096_2404_2436(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.ContainingSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10096, 2404, 2436);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10096_2475_2505(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.ContainingType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10096, 2475, 2505);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10096_2507_2541(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.OriginalDefinition;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10096, 2507, 2541);
            return return_v;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
        f_10096_2507_2556(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.TypeParameters;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10096, 2507, 2556);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
        f_10096_2463_2587(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        containingType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
        typeParameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
        typeArguments)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap(containingType, typeParameters, typeArguments);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10096, 2463, 2587);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10096_2629_2663(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.OriginalDefinition;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10096, 2629, 2663);
            return return_v;
        }


        int
        f_10096_2922_2943(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.Arity;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10096, 2922, 2943);
            return return_v;
        }


        int
        f_10096_2909_2983(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10096, 2909, 2983);
            return 0;
        }


        int
        f_10096_3011_3032(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.Arity;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10096, 3011, 3032);
            return return_v;
        }


        int
        f_10096_2998_3038(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10096, 2998, 3038);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbol
        f_10096_2390_2436_C(Microsoft.CodeAnalysis.CSharp.Symbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10096, 2180, 3050);
            return return_v;
        }

    }
}
