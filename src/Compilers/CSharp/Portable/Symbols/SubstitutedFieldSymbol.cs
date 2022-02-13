// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using System.Threading;
using Roslyn.Utilities;
using Microsoft.CodeAnalysis.CSharp.Emit;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SubstitutedFieldSymbol : WrappedFieldSymbol
    {
        private readonly SubstitutedNamedTypeSymbol _containingType;

        private TypeWithAnnotations.Boxed _lazyType;

        internal SubstitutedFieldSymbol(SubstitutedNamedTypeSymbol containingType, FieldSymbol substitutedFrom)
        : base(f_10157_766_813_C((FieldSymbol)f_10157_779_813(substitutedFrom)))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10157, 642, 883);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10157, 558, 573);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10157, 620, 629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10157, 839, 872);

                _containingType = containingType;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10157, 642, 883);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10157, 642, 883);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10157, 642, 883);
            }
        }

        internal override TypeWithAnnotations GetFieldType(ConsList<FieldSymbol> fieldsBeingBound)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10157, 895, 1344);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10157, 1010, 1294) || true) && (_lazyType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10157, 1010, 1294);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10157, 1065, 1175);

                    var
                    type = f_10157_1076_1174(f_10157_1076_1108(_containingType), f_10157_1124_1173(f_10157_1124_1142(), fieldsBeingBound))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10157, 1193, 1279);

                    f_10157_1193_1278(ref _lazyType, f_10157_1236_1271(type), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10157, 1010, 1294);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10157, 1310, 1333);

                return _lazyType.Value;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10157, 895, 1344);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10157_1076_1108(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeSubstitution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10157, 1076, 1108);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10157_1124_1142()
                {
                    var return_v = OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10157, 1124, 1142);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10157_1124_1173(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                fieldsBeingBound)
                {
                    var return_v = this_param.GetFieldType(fieldsBeingBound);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10157, 1124, 1173);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10157_1076_1174(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                previous)
                {
                    var return_v = this_param.SubstituteType(previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10157, 1076, 1174);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed
                f_10157_1236_1271(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10157, 1236, 1271);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed?
                f_10157_1193_1278(ref Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed?
                location1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed
                value, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations.Boxed?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10157, 1193, 1278);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10157, 895, 1344);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10157, 895, 1344);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10157, 1420, 1494);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10157, 1456, 1479);

                    return _containingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10157, 1420, 1494);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10157, 1356, 1505);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10157, 1356, 1505);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override NamedTypeSymbol ContainingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10157, 1588, 1662);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10157, 1624, 1647);

                    return _containingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10157, 1588, 1662);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10157, 1517, 1673);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10157, 1517, 1673);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10157, 1756, 1831);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10157, 1792, 1816);

                    return _underlyingField;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10157, 1756, 1831);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10157, 1685, 1842);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10157, 1685, 1842);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10157, 1920, 2379);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10157, 1956, 2311) || true) && (f_10157_1960_1991(f_10157_1960_1979(this)) && (DynAbs.Tracing.TraceSender.Expression_True(10157, 1960, 2021) && f_10157_1995_2021(this)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10157, 1956, 2311);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10157, 2280, 2292);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10157, 1956, 2311);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10157, 2331, 2364);

                    return DynAbs.Tracing.TraceSender.TraceMemberAccessWrapper(() => base.IsImplicitlyDeclared, 10157, 2338, 2363);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10157, 1920, 2379);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10157_1960_1979(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedFieldSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10157, 1960, 1979);
                        return return_v;
                    }


                    bool
                    f_10157_1960_1991(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsTupleType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10157, 1960, 1991);
                        return return_v;
                    }


                    bool
                    f_10157_1995_2021(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedFieldSymbol
                    this_param)
                    {
                        var return_v = this_param.IsDefaultTupleElement;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10157, 1995, 2021);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10157, 1854, 2390);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10157, 1854, 2390);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10157, 2402, 2547);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10157, 2494, 2536);

                return f_10157_2501_2535(f_10157_2501_2519());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10157, 2402, 2547);

                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10157_2501_2519()
                {
                    var return_v = OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10157, 2501, 2519);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10157_2501_2535(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10157, 2501, 2535);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10157, 2402, 2547);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10157, 2402, 2547);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Symbol AssociatedSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10157, 2623, 2922);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10157, 2659, 2715);

                    Symbol
                    underlying = f_10157_2679_2714(f_10157_2679_2697())
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10157, 2735, 2838) || true) && ((object)underlying == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10157, 2735, 2838);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10157, 2807, 2819);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10157, 2735, 2838);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10157, 2858, 2907);

                    return f_10157_2865_2906(underlying, f_10157_2891_2905());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10157, 2623, 2922);

                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10157_2679_2697()
                    {
                        var return_v = OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10157, 2679, 2697);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10157_2679_2714(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.AssociatedSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10157, 2679, 2714);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10157_2891_2905()
                    {
                        var return_v = ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10157, 2891, 2905);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10157_2865_2906(Microsoft.CodeAnalysis.CSharp.Symbol
                    s, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    newOwner)
                    {
                        var return_v = s.SymbolAsMember(newOwner);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10157, 2865, 2906);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10157, 2559, 2933);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10157, 2559, 2933);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override NamedTypeSymbol FixedImplementationType(PEModuleBuilder emitModule)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10157, 2945, 3499);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10157, 3355, 3488);

                return (NamedTypeSymbol)f_10157_3379_3482(f_10157_3379_3411(_containingType), f_10157_3427_3481(f_10157_3427_3445(), emitModule)).Type;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10157, 2945, 3499);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10157_3379_3411(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeSubstitution;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10157, 3379, 3411);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10157_3427_3445()
                {
                    var return_v = OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10157, 3427, 3445);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10157_3427_3481(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                emitModule)
                {
                    var return_v = this_param.FixedImplementationType(emitModule);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10157, 3427, 3481);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10157_3379_3482(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                previous)
                {
                    var return_v = this_param.SubstituteType((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10157, 3379, 3482);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10157, 2945, 3499);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10157, 2945, 3499);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(Symbol obj, TypeCompareKind compareKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10157, 3511, 3912);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10157, 3604, 3688) || true) && ((object)this == obj)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10157, 3604, 3688);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10157, 3661, 3673);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10157, 3604, 3688);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10157, 3704, 3735);

                var
                other = obj as FieldSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10157, 3749, 3901);

                return (object)other != null && (DynAbs.Tracing.TraceSender.Expression_True(10157, 3756, 3850) && f_10157_3781_3850(_containingType, f_10157_3816_3836(other), compareKind)) && (DynAbs.Tracing.TraceSender.Expression_True(10157, 3756, 3900) && f_10157_3854_3872() == f_10157_3876_3900(other));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10157, 3511, 3912);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10157_3816_3836(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10157, 3816, 3836);
                    return return_v;
                }


                bool
                f_10157_3781_3850(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10157, 3781, 3850);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10157_3854_3872()
                {
                    var return_v = OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10157, 3854, 3872);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10157_3876_3900(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10157, 3876, 3900);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10157, 3511, 3912);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10157, 3511, 3912);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10157, 3924, 4733);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10157, 3982, 4031);

                var
                code = f_10157_3993_4030(f_10157_3993_4016(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10157, 4452, 4507);

                var
                containingHashCode = f_10157_4477_4506(_containingType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10157, 4521, 4694) || true) && (containingHashCode != f_10157_4547_4599(f_10157_4547_4585(f_10157_4547_4570(this))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10157, 4521, 4694);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10157, 4633, 4679);

                    code = f_10157_4640_4678(containingHashCode, code);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10157, 4521, 4694);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10157, 4710, 4722);

                return code;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10157, 3924, 4733);

                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10157_3993_4016(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedFieldSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10157, 3993, 4016);
                    return return_v;
                }


                int
                f_10157_3993_4030(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10157, 3993, 4030);
                    return return_v;
                }


                int
                f_10157_4477_4506(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10157, 4477, 4506);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10157_4547_4570(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedFieldSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10157, 4547, 4570);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10157_4547_4585(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10157, 4547, 4585);
                    return return_v;
                }


                int
                f_10157_4547_4599(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10157, 4547, 4599);
                    return return_v;
                }


                int
                f_10157_4640_4678(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10157, 4640, 4678);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10157, 3924, 4733);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10157, 3924, 4733);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SubstitutedFieldSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10157, 432, 4740);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10157, 432, 4740);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10157, 432, 4740);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10157, 432, 4740);

        static Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
        f_10157_779_813(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
        this_param)
        {
            var return_v = this_param.OriginalDefinition;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10157, 779, 813);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
        f_10157_766_813_C(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10157, 642, 883);
            return return_v;
        }

    }
}
