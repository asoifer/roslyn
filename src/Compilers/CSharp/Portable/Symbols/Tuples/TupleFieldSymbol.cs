// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Roslyn.Utilities;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Threading;
namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal class TupleFieldSymbol : WrappedFieldSymbol
    {
        protected readonly NamedTypeSymbol _containingTuple;

        private readonly int _tupleElementIndex;

        public TupleFieldSymbol(NamedTypeSymbol container, FieldSymbol underlyingField, int tupleElementIndex)
        : base(f_10696_1192_1207_C(underlyingField))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10696, 1069, 1671);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 678, 694);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 1038, 1056);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 1233, 1269);

                f_10696_1233_1268(f_10696_1246_1267(container));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 1283, 1562);

                f_10696_1283_1561(f_10696_1296_1388(container, f_10696_1313_1343(underlyingField), TypeCompareKind.IgnoreDynamicAndTupleNames) || (DynAbs.Tracing.TraceSender.Expression_False(10696, 1296, 1430) || this is TupleVirtualElementFieldSymbol), "virtual fields should be represented by " + nameof(TupleVirtualElementFieldSymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 1578, 1607);

                _containingTuple = container;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 1621, 1660);

                _tupleElementIndex = tupleElementIndex;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10696, 1069, 1671);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10696, 1069, 1671);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10696, 1069, 1671);
            }
        }

        public override int TupleElementIndex
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10696, 1948, 2147);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 1984, 2081) || true) && (_tupleElementIndex < 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10696, 1984, 2081);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 2052, 2062);

                        return -1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10696, 1984, 2081);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 2101, 2132);

                    return _tupleElementIndex >> 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10696, 1948, 2147);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10696, 1886, 2158);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10696, 1886, 2158);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsDefaultTupleElement
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10696, 2237, 2381);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 2315, 2366);

                    return (_tupleElementIndex & ((1 << 31) | 1)) == 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10696, 2237, 2381);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10696, 2170, 2392);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10696, 2170, 2392);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override FieldSymbol TupleUnderlyingField
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10696, 2484, 2559);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 2520, 2544);

                    return _underlyingField;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10696, 2484, 2559);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10696, 2404, 2570);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10696, 2404, 2570);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol? AssociatedSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10696, 2647, 2797);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 2683, 2782);

                    return f_10696_2690_2781(_containingTuple, f_10696_2747_2780(_underlyingField));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10696, 2647, 2797);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10696_2747_2780(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.AssociatedSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10696, 2747, 2780);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol?
                    f_10696_2690_2781(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    underlyingMemberOpt)
                    {
                        var return_v = this_param.GetTupleMemberSymbolForUnderlyingMember<Microsoft.CodeAnalysis.CSharp.Symbol>(underlyingMemberOpt);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10696, 2690, 2781);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10696, 2582, 2808);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10696, 2582, 2808);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override FieldSymbol OriginalDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10696, 2891, 3289);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 2927, 2997);

                    NamedTypeSymbol
                    originalContainer = f_10696_2963_2996(f_10696_2963_2977())
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 3015, 3153) || true) && (f_10696_3019_3049_M(!originalContainer.IsTupleType) || (DynAbs.Tracing.TraceSender.Expression_False(10696, 3019, 3080) || f_10696_3053_3080(f_10696_3053_3067())))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10696, 3015, 3153);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 3122, 3134);

                        return this;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10696, 3015, 3153);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 3171, 3274);

                    return f_10696_3178_3272(originalContainer, f_10696_3236_3271(_underlyingField))!;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10696, 2891, 3289);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10696_2963_2977()
                    {
                        var return_v = ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10696, 2963, 2977);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10696_2963_2996(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10696, 2963, 2996);
                        return return_v;
                    }


                    bool
                    f_10696_3019_3049_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10696, 3019, 3049);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10696_3053_3067()
                    {
                        var return_v = ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10696, 3053, 3067);
                        return return_v;
                    }


                    bool
                    f_10696_3053_3080(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10696, 3053, 3080);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10696_3236_3271(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10696, 3236, 3271);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                    f_10696_3178_3272(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    underlyingMemberOpt)
                    {
                        var return_v = this_param.GetTupleMemberSymbolForUnderlyingMember<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>(underlyingMemberOpt);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10696, 3178, 3272);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10696, 2820, 3300);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10696, 2820, 3300);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10696, 3376, 3451);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 3412, 3436);

                    return _containingTuple;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10696, 3376, 3451);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10696, 3312, 3462);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10696, 3312, 3462);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override TypeWithAnnotations GetFieldType(ConsList<FieldSymbol> fieldsBeingBound)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10696, 3474, 3655);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 3589, 3644);

                return f_10696_3596_3643(_underlyingField, fieldsBeingBound);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10696, 3474, 3655);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10696_3596_3643(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                fieldsBeingBound)
                {
                    var return_v = this_param.GetFieldType(fieldsBeingBound);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10696, 3596, 3643);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10696, 3474, 3655);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10696, 3474, 3655);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10696, 3667, 3810);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 3759, 3799);

                return f_10696_3766_3798(_underlyingField);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10696, 3667, 3810);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10696_3766_3798(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10696, 3766, 3798);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10696, 3667, 3810);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10696, 3667, 3810);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override DiagnosticInfo GetUseSiteDiagnostic()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10696, 3822, 3960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 3902, 3949);

                return f_10696_3909_3948(_underlyingField);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10696, 3822, 3960);

                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10696_3909_3948(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10696, 3909, 3948);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10696, 3822, 3960);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10696, 3822, 3960);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool RequiresCompletion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10696, 4014, 4052);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 4017, 4052);
                    return f_10696_4017_4052(_underlyingField); DynAbs.Tracing.TraceSender.TraceExitMethod(10696, 4014, 4052);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10696, 4014, 4052);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10696, 4014, 4052);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasComplete(CompletionPart part)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10696, 4121, 4158);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 4124, 4158);
                return f_10696_4124_4158(_underlyingField, part); DynAbs.Tracing.TraceSender.TraceExitMethod(10696, 4121, 4158);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10696, 4121, 4158);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10696, 4121, 4158);
            }
            throw new System.Exception("Slicer error: unreachable code");

            bool
            f_10696_4124_4158(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.CompletionPart
            part)
            {
                var return_v = this_param.HasComplete(part);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10696, 4124, 4158);
                return return_v;
            }

        }

        internal override void ForceComplete(SourceLocation locationOpt, CancellationToken cancellationToken)
        {
            _underlyingField.ForceComplete(locationOpt, cancellationToken);
        }

        public sealed override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10696, 4383, 4545);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 4448, 4534);

                return f_10696_4455_4533(f_10696_4468_4498(_containingTuple), f_10696_4500_4532(_tupleElementIndex));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10696, 4383, 4545);

                int
                f_10696_4468_4498(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10696, 4468, 4498);
                    return return_v;
                }


                int
                f_10696_4500_4532(int
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10696, 4500, 4532);
                    return return_v;
                }


                int
                f_10696_4455_4533(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10696, 4455, 4533);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10696, 4383, 4545);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10696, 4383, 4545);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override bool Equals(Symbol obj, TypeCompareKind compareKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10696, 4557, 5246);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 4657, 4693);

                var
                other = obj as TupleFieldSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 4709, 4796) || true) && ((object?)other == this)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10696, 4709, 4796);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 4769, 4781);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10696, 4709, 4796);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 5045, 5235);

                return (object?)other != null && (DynAbs.Tracing.TraceSender.Expression_True(10696, 5052, 5141) && _tupleElementIndex == other._tupleElementIndex) && (DynAbs.Tracing.TraceSender.Expression_True(10696, 5052, 5234) && f_10696_5162_5234(_containingTuple, other._containingTuple, compareKind));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10696, 4557, 5246);

                bool
                f_10696_5162_5234(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10696, 5162, 5234);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10696, 4557, 5246);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10696, 4557, 5246);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TupleFieldSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10696, 574, 5253);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10696, 574, 5253);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10696, 574, 5253);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10696, 574, 5253);

        bool
        f_10696_1246_1267(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.IsTupleType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10696, 1246, 1267);
            return return_v;
        }


        int
        f_10696_1233_1268(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10696, 1233, 1268);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10696_1313_1343(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
        this_param)
        {
            var return_v = this_param.ContainingType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10696, 1313, 1343);
            return return_v;
        }


        bool
        f_10696_1296_1388(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        t2, Microsoft.CodeAnalysis.TypeCompareKind
        comparison)
        {
            var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, comparison);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10696, 1296, 1388);
            return return_v;
        }


        int
        f_10696_1283_1561(bool
        condition, string
        message)
        {
            Debug.Assert(condition, message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10696, 1283, 1561);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
        f_10696_1192_1207_C(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10696, 1069, 1671);
            return return_v;
        }


        bool
        f_10696_4017_4052(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
        this_param)
        {
            var return_v = this_param.RequiresCompletion;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10696, 4017, 4052);
            return return_v;
        }

    }
    internal class TupleElementFieldSymbol : TupleFieldSymbol
    {
        private readonly ImmutableArray<Location> _locations;

        protected readonly TupleElementFieldSymbol _correspondingDefaultField;

        private readonly bool _isImplicitlyDeclared;

        public TupleElementFieldSymbol(
                    NamedTypeSymbol container,
                    FieldSymbol underlyingField,
                    int tupleElementIndex,
                    ImmutableArray<Location> locations,
                    bool isImplicitlyDeclared,
                    TupleElementFieldSymbol? correspondingDefaultFieldOpt)
        : base(f_10696_6219_6228_C(container), underlyingField, (DynAbs.Tracing.TraceSender.Conditional_F1(10696, 6247, 6283) || ((correspondingDefaultFieldOpt is null && DynAbs.Tracing.TraceSender.Conditional_F2(10696, 6286, 6308)) || DynAbs.Tracing.TraceSender.Conditional_F3(10696, 6311, 6339))) ? tupleElementIndex << 1 : (tupleElementIndex << 1) + 1)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10696, 5892, 6637);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 5654, 5680);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 5858, 5879);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 6365, 6401);

                f_10696_6365_6400(f_10696_6378_6399(container));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 6415, 6450);

                f_10696_6415_6449(f_10696_6428_6448_M(!locations.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 6464, 6487);

                _locations = locations;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 6501, 6546);

                _isImplicitlyDeclared = isImplicitlyDeclared;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 6560, 6626);

                _correspondingDefaultField = correspondingDefaultFieldOpt ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TupleElementFieldSymbol?>(10696, 6589, 6625) ?? this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10696, 5892, 6637);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10696, 5892, 6637);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10696, 5892, 6637);
            }
        }

        public sealed override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10696, 6731, 6800);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 6767, 6785);

                    return _locations;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10696, 6731, 6800);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10696, 6649, 6811);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10696, 6649, 6811);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<SyntaxReference> DeclaringSyntaxReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10696, 6928, 7156);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 6964, 7141);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10696, 6971, 6992) || ((_isImplicitlyDeclared && DynAbs.Tracing.TraceSender.Conditional_F2(10696, 7016, 7053)) || DynAbs.Tracing.TraceSender.Conditional_F3(10696, 7077, 7140))) ? ImmutableArray<SyntaxReference>.Empty : f_10696_7077_7140(_locations);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10696, 6928, 7156);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                    f_10696_7077_7140(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    locations)
                    {
                        var return_v = GetDeclaringSyntaxReferenceHelper<CSharpSyntaxNode>(locations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10696, 7077, 7140);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10696, 6823, 7167);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10696, 6823, 7167);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsImplicitlyDeclared
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10696, 7252, 7332);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 7288, 7317);

                    return _isImplicitlyDeclared;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10696, 7252, 7332);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10696, 7179, 7343);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10696, 7179, 7343);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol? AssociatedSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10696, 7420, 7722);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 7456, 7658) || true) && (!f_10696_7461_7585(f_10696_7479_7510(_underlyingField), f_10696_7512_7548(_containingTuple), TypeCompareKind.ConsiderEverything))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10696, 7456, 7658);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 7627, 7639);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10696, 7456, 7658);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 7678, 7707);

                    return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.AssociatedSymbol, 10696, 7685, 7706);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10696, 7420, 7722);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10696_7479_7510(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10696, 7479, 7510);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                    f_10696_7512_7548(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TupleUnderlyingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10696, 7512, 7548);
                        return return_v;
                    }


                    bool
                    f_10696_7461_7585(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                    right, Microsoft.CodeAnalysis.TypeCompareKind
                    comparison)
                    {
                        var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?)right, comparison);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10696, 7461, 7585);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10696, 7355, 7733);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10696, 7355, 7733);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override FieldSymbol CorrespondingTupleField
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10696, 7828, 7913);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 7864, 7898);

                    return _correspondingDefaultField;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10696, 7828, 7913);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10696, 7745, 7924);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10696, 7745, 7924);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override FieldSymbol AsMember(NamedTypeSymbol newOwner)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10696, 7936, 8369);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 8025, 8060);

                f_10696_8025_8059(f_10696_8038_8058(newOwner));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 8076, 8145);

                NamedTypeSymbol
                newUnderlyingOwner = f_10696_8113_8144(this, newOwner)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 8159, 8358);

                return f_10696_8166_8357(newOwner, f_10696_8204_8268(f_10696_8204_8239(_underlyingField), newUnderlyingOwner), f_10696_8270_8287(), f_10696_8289_8298(), f_10696_8300_8320(), correspondingDefaultFieldOpt: null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10696, 7936, 8369);

                bool
                f_10696_8038_8058(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsTupleType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10696, 8038, 8058);
                    return return_v;
                }


                int
                f_10696_8025_8059(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10696, 8025, 8059);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10696_8113_8144(Microsoft.CodeAnalysis.CSharp.Symbols.TupleElementFieldSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner)
                {
                    var return_v = this_param.GetNewUnderlyingOwner(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10696, 8113, 8144);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10696_8204_8239(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10696, 8204, 8239);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10696_8204_8268(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10696, 8204, 8268);
                    return return_v;
                }


                int
                f_10696_8270_8287()
                {
                    var return_v = TupleElementIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10696, 8270, 8287);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10696_8289_8298()
                {
                    var return_v = Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10696, 8289, 8298);
                    return return_v;
                }


                bool
                f_10696_8300_8320()
                {
                    var return_v = IsImplicitlyDeclared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10696, 8300, 8320);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TupleElementFieldSymbol
                f_10696_8166_8357(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                container, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                underlyingField, int
                tupleElementIndex, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                locations, bool
                isImplicitlyDeclared, Microsoft.CodeAnalysis.CSharp.Symbols.TupleElementFieldSymbol?
                correspondingDefaultFieldOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TupleElementFieldSymbol(container, underlyingField, tupleElementIndex, locations, isImplicitlyDeclared, correspondingDefaultFieldOpt: correspondingDefaultFieldOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10696, 8166, 8357);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10696, 7936, 8369);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10696, 7936, 8369);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected NamedTypeSymbol GetNewUnderlyingOwner(NamedTypeSymbol newOwner)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10696, 8381, 8968);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 8479, 8516);

                int
                currentIndex = f_10696_8498_8515()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 8530, 8576);

                NamedTypeSymbol
                newUnderlyingOwner = newOwner
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 8590, 8915) || true) && (currentIndex >= NamedTypeSymbol.ValueTupleRestIndex)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10696, 8590, 8915);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 8682, 8830);

                        newUnderlyingOwner = (NamedTypeSymbol)f_10696_8720_8787(newUnderlyingOwner)[NamedTypeSymbol.ValueTupleRestIndex].Type;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 8848, 8900);

                        currentIndex -= NamedTypeSymbol.ValueTupleRestIndex;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10696, 8590, 8915);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10696, 8590, 8915);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10696, 8590, 8915);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 8931, 8957);

                return newUnderlyingOwner;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10696, 8381, 8968);

                int
                f_10696_8498_8515()
                {
                    var return_v = TupleElementIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10696, 8498, 8515);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10696_8720_8787(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10696, 8720, 8787);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10696, 8381, 8968);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10696, 8381, 8968);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TupleElementFieldSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10696, 5474, 8975);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10696, 5474, 8975);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10696, 5474, 8975);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10696, 5474, 8975);

        bool
        f_10696_6378_6399(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.IsTupleType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10696, 6378, 6399);
            return return_v;
        }


        int
        f_10696_6365_6400(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10696, 6365, 6400);
            return 0;
        }


        bool
        f_10696_6428_6448_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10696, 6428, 6448);
            return return_v;
        }


        int
        f_10696_6415_6449(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10696, 6415, 6449);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10696_6219_6228_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10696, 5892, 6637);
            return return_v;
        }

    }
    internal sealed class TupleVirtualElementFieldSymbol : TupleElementFieldSymbol
    {
        private readonly string _name;

        private readonly bool _cannotUse;

        public TupleVirtualElementFieldSymbol(
                    NamedTypeSymbol container,
                    FieldSymbol underlyingField,
                    string name,
                    int tupleElementIndex,
                    ImmutableArray<Location> locations,
                    bool cannotUse,
                    bool isImplicitlyDeclared,
                    TupleElementFieldSymbol? correspondingDefaultFieldOpt)
        : base(f_10696_10442_10451_C(container), underlyingField, tupleElementIndex, locations, isImplicitlyDeclared, correspondingDefaultFieldOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10696, 10053, 11242);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 9910, 9915);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 9948, 9958);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 10711, 10747);

                f_10696_10711_10746(f_10696_10724_10745(container));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 10761, 10818);

                f_10696_10761_10817(f_10696_10774_10816(f_10696_10774_10804(underlyingField)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 10832, 10865);

                f_10696_10832_10864(name != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 10879, 11165);

                f_10696_10879_11164(name != f_10696_10900_10920(underlyingField) || (DynAbs.Tracing.TraceSender.Expression_False(10696, 10892, 11017) || !f_10696_10925_11017(container, f_10696_10942_10972(underlyingField), TypeCompareKind.IgnoreDynamicAndTupleNames)), "fields that map directly to underlying should not be represented by " + nameof(TupleVirtualElementFieldSymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 11181, 11194);

                _name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 11208, 11231);

                _cannotUse = cannotUse;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10696, 10053, 11242);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10696, 10053, 11242);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10696, 10053, 11242);
            }
        }

        internal override DiagnosticInfo GetUseSiteDiagnostic()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10696, 11254, 11655);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 11334, 11593) || true) && (_cannotUse)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10696, 11334, 11593);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 11382, 11578);

                    return f_10696_11389_11577(ErrorCode.ERR_TupleInferredNamesNotAvailable, _name, f_10696_11484_11576(f_10696_11518_11575(MessageID.IDS_FeatureInferredTupleNames)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10696, 11334, 11593);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 11609, 11644);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetUseSiteDiagnostic(), 10696, 11616, 11643);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10696, 11254, 11655);

                Microsoft.CodeAnalysis.CSharp.LanguageVersion
                f_10696_11518_11575(Microsoft.CodeAnalysis.CSharp.MessageID
                feature)
                {
                    var return_v = feature.RequiredVersion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10696, 11518, 11575);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpRequiredLanguageVersion
                f_10696_11484_11576(Microsoft.CodeAnalysis.CSharp.LanguageVersion
                version)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSharpRequiredLanguageVersion(version);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10696, 11484, 11576);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10696_11389_11577(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10696, 11389, 11577);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10696, 11254, 11655);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10696, 11254, 11655);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10696, 11719, 11783);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 11755, 11768);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10696, 11719, 11783);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10696, 11667, 11794);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10696, 11667, 11794);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override int? TypeLayoutOffset
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10696, 11870, 11933);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 11906, 11918);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10696, 11870, 11933);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10696, 11806, 11944);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10696, 11806, 11944);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol? AssociatedSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10696, 12021, 12084);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 12057, 12069);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10696, 12021, 12084);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10696, 11956, 12095);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10696, 11956, 12095);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override FieldSymbol OriginalDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10696, 12178, 12241);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 12214, 12226);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10696, 12178, 12241);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10696, 12107, 12252);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10696, 12107, 12252);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsVirtualTupleField
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10696, 12329, 12392);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 12365, 12377);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10696, 12329, 12392);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10696, 12264, 12403);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10696, 12264, 12403);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override TypeWithAnnotations GetFieldType(ConsList<FieldSymbol> fieldsBeingBound)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10696, 12519, 12569);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 12522, 12569);
                return f_10696_12522_12569(_underlyingField, fieldsBeingBound); DynAbs.Tracing.TraceSender.TraceExitMethod(10696, 12519, 12569);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10696, 12519, 12569);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10696, 12519, 12569);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            f_10696_12522_12569(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
            this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
            fieldsBeingBound)
            {
                var return_v = this_param.GetFieldType(fieldsBeingBound);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10696, 12522, 12569);
                return return_v;
            }

        }

        public override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10696, 12582, 12725);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 12674, 12714);

                return f_10696_12681_12713(_underlyingField);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10696, 12582, 12725);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10696_12681_12713(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10696, 12681, 12713);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10696, 12582, 12725);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10696, 12582, 12725);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override FieldSymbol AsMember(NamedTypeSymbol newOwner)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10696, 12737, 13593);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 12826, 12861);

                f_10696_12826_12860(f_10696_12839_12859(newOwner));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 12875, 12965);

                f_10696_12875_12964(newOwner.TupleElements.Length == this._containingTuple.TupleElements.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 12981, 13050);

                NamedTypeSymbol
                newUnderlyingOwner = f_10696_13018_13049(this, newOwner)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 13066, 13130);

                TupleElementFieldSymbol?
                newCorrespondingDefaultFieldOpt = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 13144, 13344) || true) && ((object)_correspondingDefaultField != this)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10696, 13144, 13344);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 13224, 13329);

                    newCorrespondingDefaultFieldOpt = (TupleElementFieldSymbol)f_10696_13283_13328(_correspondingDefaultField, newOwner);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10696, 13144, 13344);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10696, 13360, 13582);

                return f_10696_13367_13581(newOwner, f_10696_13412_13476(f_10696_13412_13447(_underlyingField), newUnderlyingOwner), _name, f_10696_13485_13502(), f_10696_13504_13513(), _cannotUse, f_10696_13527_13547(), newCorrespondingDefaultFieldOpt);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10696, 12737, 13593);

                bool
                f_10696_12839_12859(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsTupleType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10696, 12839, 12859);
                    return return_v;
                }


                int
                f_10696_12826_12860(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10696, 12826, 12860);
                    return 0;
                }


                int
                f_10696_12875_12964(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10696, 12875, 12964);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10696_13018_13049(Microsoft.CodeAnalysis.CSharp.Symbols.TupleVirtualElementFieldSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner)
                {
                    var return_v = this_param.GetNewUnderlyingOwner(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10696, 13018, 13049);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10696_13283_13328(Microsoft.CodeAnalysis.CSharp.Symbols.TupleElementFieldSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10696, 13283, 13328);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10696_13412_13447(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10696, 13412, 13447);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10696_13412_13476(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10696, 13412, 13476);
                    return return_v;
                }


                int
                f_10696_13485_13502()
                {
                    var return_v = TupleElementIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10696, 13485, 13502);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10696_13504_13513()
                {
                    var return_v = Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10696, 13504, 13513);
                    return return_v;
                }


                bool
                f_10696_13527_13547()
                {
                    var return_v = IsImplicitlyDeclared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10696, 13527, 13547);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TupleVirtualElementFieldSymbol
                f_10696_13367_13581(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                container, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                underlyingField, string
                name, int
                tupleElementIndex, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                locations, bool
                cannotUse, bool
                isImplicitlyDeclared, Microsoft.CodeAnalysis.CSharp.Symbols.TupleElementFieldSymbol?
                correspondingDefaultFieldOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TupleVirtualElementFieldSymbol(container, underlyingField, name, tupleElementIndex, locations, cannotUse, isImplicitlyDeclared, correspondingDefaultFieldOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10696, 13367, 13581);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10696, 12737, 13593);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10696, 12737, 13593);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TupleVirtualElementFieldSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10696, 9791, 13600);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10696, 9791, 13600);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10696, 9791, 13600);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10696, 9791, 13600);

        bool
        f_10696_10724_10745(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.IsTupleType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10696, 10724, 10745);
            return return_v;
        }


        int
        f_10696_10711_10746(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10696, 10711, 10746);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10696_10774_10804(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
        this_param)
        {
            var return_v = this_param.ContainingType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10696, 10774, 10804);
            return return_v;
        }


        bool
        f_10696_10774_10816(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.IsTupleType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10696, 10774, 10816);
            return return_v;
        }


        int
        f_10696_10761_10817(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10696, 10761, 10817);
            return 0;
        }


        int
        f_10696_10832_10864(bool
        b)
        {
            RoslynDebug.Assert(b);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10696, 10832, 10864);
            return 0;
        }


        string
        f_10696_10900_10920(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10696, 10900, 10920);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10696_10942_10972(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
        this_param)
        {
            var return_v = this_param.ContainingType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10696, 10942, 10972);
            return return_v;
        }


        bool
        f_10696_10925_11017(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        t2, Microsoft.CodeAnalysis.TypeCompareKind
        comparison)
        {
            var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, comparison);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10696, 10925, 11017);
            return return_v;
        }


        int
        f_10696_10879_11164(bool
        condition, string
        message)
        {
            Debug.Assert(condition, message);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10696, 10879, 11164);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10696_10442_10451_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10696, 10053, 11242);
            return return_v;
        }

    }
}
