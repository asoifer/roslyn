// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class TupleErrorFieldSymbol : SynthesizedFieldSymbolBase
    {
        private readonly TypeWithAnnotations _type;

        private readonly int _tupleElementIndex;

        private readonly ImmutableArray<Location> _locations;

        private readonly DiagnosticInfo _useSiteDiagnosticInfo;

        private readonly TupleErrorFieldSymbol _correspondingDefaultField;

        private readonly bool _isImplicitlyDeclared;

        public TupleErrorFieldSymbol(
                    NamedTypeSymbol container,
                    string name,
                    int tupleElementIndex,
                    Location location,
                    TypeWithAnnotations type,
                    DiagnosticInfo useSiteDiagnosticInfo,
                    bool isImplicitlyDeclared,
                    TupleErrorFieldSymbol correspondingDefaultFieldOpt)
        : base(f_10695_1922_1931_C(container), name, isPublic: true, isReadOnly: false, isStatic: false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10695, 1541, 2747);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10695, 1105, 1123);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10695, 1231, 1253);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10695, 1303, 1329);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10695, 1507, 1528);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10695, 2015, 2042);

                f_10695_2015_2041(name != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10695, 2056, 2069);

                _type = type;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10695, 2083, 2180);

                _locations = (DynAbs.Tracing.TraceSender.Conditional_F1(10695, 2096, 2112) || ((location == null && DynAbs.Tracing.TraceSender.Conditional_F2(10695, 2115, 2145)) || DynAbs.Tracing.TraceSender.Conditional_F3(10695, 2148, 2179))) ? ImmutableArray<Location>.Empty : f_10695_2148_2179(location);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10695, 2194, 2241);

                _useSiteDiagnosticInfo = useSiteDiagnosticInfo;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10695, 2255, 2377);

                _tupleElementIndex = (DynAbs.Tracing.TraceSender.Conditional_F1(10695, 2276, 2320) || (((object)correspondingDefaultFieldOpt == null && DynAbs.Tracing.TraceSender.Conditional_F2(10695, 2323, 2345)) || DynAbs.Tracing.TraceSender.Conditional_F3(10695, 2348, 2376))) ? tupleElementIndex << 1 : (tupleElementIndex << 1) + 1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10695, 2391, 2436);

                _isImplicitlyDeclared = isImplicitlyDeclared;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10695, 2452, 2535);

                f_10695_2452_2534((correspondingDefaultFieldOpt == null) == f_10695_2507_2533(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10695, 2549, 2654);

                f_10695_2549_2653(correspondingDefaultFieldOpt == null || (DynAbs.Tracing.TraceSender.Expression_False(10695, 2562, 2652) || f_10695_2602_2652(correspondingDefaultFieldOpt)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10695, 2670, 2736);

                _correspondingDefaultField = correspondingDefaultFieldOpt ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TupleErrorFieldSymbol?>(10695, 2699, 2735) ?? this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10695, 1541, 2747);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10695, 1541, 2747);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10695, 1541, 2747);
            }
        }

        public override int TupleElementIndex
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10695, 3024, 3223);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10695, 3060, 3157) || true) && (_tupleElementIndex < 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10695, 3060, 3157);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10695, 3128, 3138);

                        return -1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10695, 3060, 3157);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10695, 3177, 3208);

                    return _tupleElementIndex >> 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10695, 3024, 3223);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10695, 2962, 3234);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10695, 2962, 3234);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10695, 3313, 3457);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10695, 3391, 3442);

                    return (_tupleElementIndex & ((1 << 31) | 1)) == 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10695, 3313, 3457);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10695, 3246, 3468);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10695, 3246, 3468);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override FieldSymbol TupleUnderlyingField
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10695, 3553, 3655);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10695, 3628, 3640);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10695, 3553, 3655);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10695, 3480, 3666);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10695, 3480, 3666);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10695, 3749, 3812);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10695, 3785, 3797);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10695, 3749, 3812);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10695, 3678, 3823);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10695, 3678, 3823);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10695, 3910, 3979);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10695, 3946, 3964);

                    return _locations;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10695, 3910, 3979);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10695, 3835, 3990);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10695, 3835, 3990);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10695, 4100, 4328);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10695, 4136, 4313);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10695, 4143, 4164) || ((_isImplicitlyDeclared && DynAbs.Tracing.TraceSender.Conditional_F2(10695, 4188, 4225)) || DynAbs.Tracing.TraceSender.Conditional_F3(10695, 4249, 4312))) ? ImmutableArray<SyntaxReference>.Empty : f_10695_4249_4312(_locations);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10695, 4100, 4328);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                    f_10695_4249_4312(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    locations)
                    {
                        var return_v = GetDeclaringSyntaxReferenceHelper<CSharpSyntaxNode>(locations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10695, 4249, 4312);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10695, 4002, 4339);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10695, 4002, 4339);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10695, 4417, 4497);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10695, 4453, 4482);

                    return _isImplicitlyDeclared;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10695, 4417, 4497);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10695, 4351, 4508);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10695, 4351, 4508);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override FieldSymbol CorrespondingTupleField
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10695, 4596, 4681);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10695, 4632, 4666);

                    return _correspondingDefaultField;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10695, 4596, 4681);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10695, 4520, 4692);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10695, 4520, 4692);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool SuppressDynamicAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10695, 4776, 4839);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10695, 4812, 4824);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10695, 4776, 4839);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10695, 4704, 4850);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10695, 4704, 4850);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override TypeWithAnnotations GetFieldType(ConsList<FieldSymbol> fieldsBeingBound)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10695, 4862, 5001);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10695, 4977, 4990);

                return _type;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10695, 4862, 5001);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10695, 4862, 5001);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10695, 4862, 5001);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override DiagnosticInfo GetUseSiteDiagnostic()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10695, 5013, 5134);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10695, 5093, 5123);

                return _useSiteDiagnosticInfo;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10695, 5013, 5134);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10695, 5013, 5134);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10695, 5013, 5134);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10695, 5146, 5306);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10695, 5211, 5295);

                return f_10695_5218_5294(f_10695_5231_5259(f_10695_5231_5245()), f_10695_5261_5293(_tupleElementIndex));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10695, 5146, 5306);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10695_5231_5245()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10695, 5231, 5245);
                    return return_v;
                }


                int
                f_10695_5231_5259(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10695, 5231, 5259);
                    return return_v;
                }


                int
                f_10695_5261_5293(int
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10695, 5261, 5293);
                    return return_v;
                }


                int
                f_10695_5218_5294(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10695, 5218, 5294);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10695, 5146, 5306);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10695, 5146, 5306);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(Symbol obj, TypeCompareKind compareKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10695, 5318, 5479);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10695, 5411, 5468);

                return f_10695_5418_5467(this, obj as TupleErrorFieldSymbol, compareKind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10695, 5318, 5479);

                bool
                f_10695_5418_5467(Microsoft.CodeAnalysis.CSharp.Symbols.TupleErrorFieldSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                other, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TupleErrorFieldSymbol?)other, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10695, 5418, 5467);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10695, 5318, 5479);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10695, 5318, 5479);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Equals(TupleErrorFieldSymbol other, TypeCompareKind compareKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10695, 5491, 5890);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10695, 5592, 5678) || true) && ((object)other == this)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10695, 5592, 5678);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10695, 5651, 5663);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10695, 5592, 5678);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10695, 5694, 5879);

                return (object)other != null && (DynAbs.Tracing.TraceSender.Expression_True(10695, 5701, 5789) && _tupleElementIndex == other._tupleElementIndex) && (DynAbs.Tracing.TraceSender.Expression_True(10695, 5701, 5878) && f_10695_5810_5878(f_10695_5828_5842(), f_10695_5844_5864(other), compareKind));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10695, 5491, 5890);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10695_5828_5842()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10695, 5828, 5842);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10695_5844_5864(Microsoft.CodeAnalysis.CSharp.Symbols.TupleErrorFieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10695, 5844, 5864);
                    return return_v;
                }


                bool
                f_10695_5810_5878(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10695, 5810, 5878);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10695, 5491, 5890);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10695, 5491, 5890);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override FieldSymbol AsMember(NamedTypeSymbol newOwner)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10695, 5902, 6901);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10695, 5991, 6098);

                f_10695_5991_6097(f_10695_6004_6024(newOwner) && (DynAbs.Tracing.TraceSender.Expression_True(10695, 6004, 6096) && newOwner.TupleElementTypesWithAnnotations.Length > f_10695_6079_6096()));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10695, 6112, 6218) || true) && (f_10695_6116_6157(newOwner, f_10695_6142_6156()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10695, 6112, 6218);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10695, 6191, 6203);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10695, 6112, 6218);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10695, 6234, 6285);

                TupleErrorFieldSymbol
                newCorrespondingField = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10695, 6299, 6495) || true) && (!f_10695_6304_6353(_correspondingDefaultField, this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10695, 6299, 6495);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10695, 6387, 6480);

                    newCorrespondingField = (TupleErrorFieldSymbol)f_10695_6434_6479(_correspondingDefaultField, newOwner);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10695, 6299, 6495);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10695, 6511, 6890);

                return f_10695_6518_6889(newOwner, f_10695_6589_6593(), f_10695_6612_6629(), (DynAbs.Tracing.TraceSender.Conditional_F1(10695, 6648, 6666) || ((_locations.IsEmpty && DynAbs.Tracing.TraceSender.Conditional_F2(10695, 6669, 6673)) || DynAbs.Tracing.TraceSender.Conditional_F3(10695, 6676, 6688))) ? null : f_10695_6676_6685()[0], f_10695_6707_6748(newOwner)[f_10695_6749_6766()], _useSiteDiagnosticInfo, _isImplicitlyDeclared, newCorrespondingField);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10695, 5902, 6901);

                bool
                f_10695_6004_6024(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsTupleType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10695, 6004, 6024);
                    return return_v;
                }


                int
                f_10695_6079_6096()
                {
                    var return_v = TupleElementIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10695, 6079, 6096);
                    return return_v;
                }


                int
                f_10695_5991_6097(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10695, 5991, 6097);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10695_6142_6156()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10695, 6142, 6156);
                    return return_v;
                }


                bool
                f_10695_6116_6157(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10695, 6116, 6157);
                    return return_v;
                }


                bool
                f_10695_6304_6353(Microsoft.CodeAnalysis.CSharp.Symbols.TupleErrorFieldSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.TupleErrorFieldSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10695, 6304, 6353);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10695_6434_6479(Microsoft.CodeAnalysis.CSharp.Symbols.TupleErrorFieldSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10695, 6434, 6479);
                    return return_v;
                }


                string
                f_10695_6589_6593()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10695, 6589, 6593);
                    return return_v;
                }


                int
                f_10695_6612_6629()
                {
                    var return_v = TupleElementIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10695, 6612, 6629);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10695_6676_6685()
                {
                    var return_v = Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10695, 6676, 6685);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10695_6707_6748(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TupleElementTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10695, 6707, 6748);
                    return return_v;
                }


                int
                f_10695_6749_6766()
                {
                    var return_v = TupleElementIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10695, 6749, 6766);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TupleErrorFieldSymbol
                f_10695_6518_6889(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                container, string
                name, int
                tupleElementIndex, Microsoft.CodeAnalysis.Location?
                location, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, Microsoft.CodeAnalysis.DiagnosticInfo
                useSiteDiagnosticInfo, bool
                isImplicitlyDeclared, Microsoft.CodeAnalysis.CSharp.Symbols.TupleErrorFieldSymbol?
                correspondingDefaultFieldOpt)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TupleErrorFieldSymbol(container, name, tupleElementIndex, location, type, useSiteDiagnosticInfo, isImplicitlyDeclared, correspondingDefaultFieldOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10695, 6518, 6889);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10695, 5902, 6901);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10695, 5902, 6901);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TupleErrorFieldSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10695, 630, 6908);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10695, 630, 6908);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10695, 630, 6908);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10695, 630, 6908);

        int
        f_10695_2015_2041(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10695, 2015, 2041);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
        f_10695_2148_2179(Microsoft.CodeAnalysis.Location
        item)
        {
            var return_v = ImmutableArray.Create(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10695, 2148, 2179);
            return return_v;
        }


        bool
        f_10695_2507_2533(Microsoft.CodeAnalysis.CSharp.Symbols.TupleErrorFieldSymbol
        this_param)
        {
            var return_v = this_param.IsDefaultTupleElement;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10695, 2507, 2533);
            return return_v;
        }


        int
        f_10695_2452_2534(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10695, 2452, 2534);
            return 0;
        }


        bool
        f_10695_2602_2652(Microsoft.CodeAnalysis.CSharp.Symbols.TupleErrorFieldSymbol
        this_param)
        {
            var return_v = this_param.IsDefaultTupleElement;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10695, 2602, 2652);
            return return_v;
        }


        int
        f_10695_2549_2653(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10695, 2549, 2653);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10695_1922_1931_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10695, 1541, 2747);
            return return_v;
        }

    }
}
