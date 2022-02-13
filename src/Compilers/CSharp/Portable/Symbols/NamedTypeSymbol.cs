// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract partial class NamedTypeSymbol : TypeSymbol, INamedTypeSymbolInternal
    {
        private bool _hasNoBaseCycles;

        internal NamedTypeSymbol(TupleExtraData tupleData = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10052, 942, 1062);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10198, 33554, 33566);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 854, 870);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10697, 898, 912);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 1024, 1051);

                _lazyTupleData = tupleData;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10052, 942, 1062);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 942, 1062);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 942, 1062);
            }
        }

        public abstract int Arity { get; }

        public abstract ImmutableArray<TypeParameterSymbol> TypeParameters { get; }

        internal abstract ImmutableArray<TypeWithAnnotations> TypeArgumentsWithAnnotationsNoUseSiteDiagnostics { get; }

        internal ImmutableArray<TypeWithAnnotations> TypeArgumentsWithDefinitionUseSiteDiagnostics(ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 2576, 3025);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 2739, 2801);

                var
                result = f_10052_2752_2800()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 2817, 2984);
                    foreach (var typeArgument in f_10052_2846_2852_I(result))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 2817, 2984);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 2886, 2969);

                        f_10052_2886_2968(f_10052_2886_2922(typeArgument.Type), ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 2817, 2984);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10052, 1, 168);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10052, 1, 168);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 3000, 3014);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 2576, 3025);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10052_2752_2800()
                {
                    var return_v = TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 2752, 2800);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10052_2886_2922(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 2886, 2922);
                    return return_v;
                }


                int
                f_10052_2886_2968(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    type.AddUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 2886, 2968);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10052_2846_2852_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 2846, 2852);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 2576, 3025);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 2576, 3025);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal TypeWithAnnotations TypeArgumentWithDefinitionUseSiteDiagnostics(int index, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 3037, 3393);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 3194, 3263);

                var
                result = f_10052_3207_3255()[index]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 3277, 3354);

                f_10052_3277_3353(f_10052_3277_3307(result.Type), ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 3368, 3382);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 3037, 3393);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10052_3207_3255()
                {
                    var return_v = TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 3207, 3255);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10052_3277_3307(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 3277, 3307);
                    return return_v;
                }


                int
                f_10052_3277_3353(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    type.AddUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 3277, 3353);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 3037, 3393);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 3037, 3393);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public abstract NamedTypeSymbol ConstructedFrom { get; }

        public virtual NamedTypeSymbol EnumUnderlyingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 4013, 4076);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 4049, 4061);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 4013, 4076);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 3939, 4087);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 3939, 4087);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 4170, 4586);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 4523, 4571);

                    return f_10052_4530_4551(this) as NamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 4170, 4586);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10052_4530_4551(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 4530, 4551);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 4099, 4597);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 4099, 4597);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual bool KnownCircularStruct
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 4908, 4972);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 4944, 4957);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 4908, 4972);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 4842, 4983);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 4842, 4983);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool KnownToHaveNoDeclaredBaseCycles
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 5065, 5140);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 5101, 5125);

                    return _hasNoBaseCycles;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 5065, 5140);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 4995, 5151);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 4995, 5151);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal void SetKnownToHaveNoDeclaredBaseCycles()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 5163, 5273);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 5238, 5262);

                _hasNoBaseCycles = true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 5163, 5273);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 5163, 5273);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 5163, 5273);
            }
        }

        internal virtual bool IsExplicitDefinitionOfNoPiaLocalType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 5558, 5622);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 5594, 5607);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 5558, 5622);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 5475, 5633);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 5475, 5633);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual bool GetGuidString(out string guidString)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 5919, 6071);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 6002, 6060);

                return f_10052_6009_6059(this, out guidString);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 5919, 6071);

                bool
                f_10052_6009_6059(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, out string
                guidString)
                {
                    var return_v = this_param.GetGuidStringDefaultImplementation(out guidString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 6009, 6059);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 5919, 6071);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 5919, 6071);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public MethodSymbol DelegateInvokeMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 6570, 7675);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 6606, 6712) || true) && (f_10052_6610_6618() != TypeKind.Delegate)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 6606, 6712);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 6681, 6693);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 6606, 6712);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 6732, 6798);

                    var
                    methods = f_10052_6746_6797(this, WellKnownMemberNames.DelegateInvokeName)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 6816, 6912) || true) && (methods.Length != 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 6816, 6912);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 6881, 6893);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 6816, 6912);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 6932, 6972);

                    var
                    method = methods[0] as MethodSymbol
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 7646, 7660);

                    return method;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 6570, 7675);

                    Microsoft.CodeAnalysis.TypeKind
                    f_10052_6610_6618()
                    {
                        var return_v = TypeKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 6610, 6618);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10052_6746_6797(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param, string
                    name)
                    {
                        var return_v = this_param.GetMembers(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 6746, 6797);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 6505, 7686);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 6505, 7686);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ImmutableArray<MethodSymbol> GetOperators(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 7813, 8579);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 7901, 7967);

                ImmutableArray<Symbol>
                candidates = f_10052_7937_7966(this, name)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 7981, 8094) || true) && (candidates.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 7981, 8094);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 8037, 8079);

                    return ImmutableArray<MethodSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 7981, 8094);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 8110, 8190);

                ArrayBuilder<MethodSymbol>
                operators = f_10052_8149_8189()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 8204, 8514);
                    foreach (MethodSymbol candidate in f_10052_8239_8272_I(candidates.OfType<MethodSymbol>()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 8204, 8514);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 8306, 8499) || true) && (f_10052_8310_8330(candidate) == MethodKind.UserDefinedOperator || (DynAbs.Tracing.TraceSender.Expression_False(10052, 8310, 8413) || f_10052_8368_8388(candidate) == MethodKind.Conversion))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 8306, 8499);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 8455, 8480);

                            f_10052_8455_8479(operators, candidate);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 8306, 8499);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 8204, 8514);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10052, 1, 311);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10052, 1, 311);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 8530, 8568);

                return f_10052_8537_8567(operators);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 7813, 8579);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10052_7937_7966(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetSimpleNonTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 7937, 7966);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10052_8149_8189()
                {
                    var return_v = ArrayBuilder<MethodSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 8149, 8189);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10052_8310_8330(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 8310, 8330);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10052_8368_8388(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 8368, 8388);
                    return return_v;
                }


                int
                f_10052_8455_8479(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 8455, 8479);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10052_8239_8272_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 8239, 8272);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10052_8537_8567(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 8537, 8567);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 7813, 8579);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 7813, 8579);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ImmutableArray<MethodSymbol> InstanceConstructors
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 8777, 8896);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 8813, 8881);

                    return f_10052_8820_8880(this, includeInstance: true, includeStatic: false);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 8777, 8896);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    f_10052_8820_8880(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param, bool
                    includeInstance, bool
                    includeStatic)
                    {
                        var return_v = this_param.GetConstructors(includeInstance: includeInstance, includeStatic: includeStatic);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 8820, 8880);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 8696, 8907);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 8696, 8907);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<MethodSymbol> StaticConstructors
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 9101, 9220);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 9137, 9205);

                    return f_10052_9144_9204(this, includeInstance: false, includeStatic: true);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 9101, 9220);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    f_10052_9144_9204(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param, bool
                    includeInstance, bool
                    includeStatic)
                    {
                        var return_v = this_param.GetConstructors(includeInstance: includeInstance, includeStatic: includeStatic);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 9144, 9204);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 9022, 9231);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 9022, 9231);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<MethodSymbol> Constructors
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 9432, 9550);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 9468, 9535);

                    return f_10052_9475_9534(this, includeInstance: true, includeStatic: true);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 9432, 9550);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    f_10052_9475_9534(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param, bool
                    includeInstance, bool
                    includeStatic)
                    {
                        var return_v = this_param.GetConstructors(includeInstance: includeInstance, includeStatic: includeStatic);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 9475, 9534);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 9359, 9561);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 9359, 9561);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ImmutableArray<MethodSymbol> GetConstructors(bool includeInstance, bool includeStatic)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 9573, 11089);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 9692, 9739);

                f_10052_9692_9738(includeInstance || (DynAbs.Tracing.TraceSender.Expression_False(10052, 9705, 9737) || includeStatic));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 9755, 9939);

                ImmutableArray<Symbol>
                instanceCandidates = (DynAbs.Tracing.TraceSender.Conditional_F1(10052, 9799, 9814) || ((includeInstance
                && DynAbs.Tracing.TraceSender.Conditional_F2(10052, 9834, 9890)) || DynAbs.Tracing.TraceSender.Conditional_F3(10052, 9910, 9938))) ? f_10052_9834_9890(this, WellKnownMemberNames.InstanceConstructorName) : ImmutableArray<Symbol>.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 9953, 10131);

                ImmutableArray<Symbol>
                staticCandidates = (DynAbs.Tracing.TraceSender.Conditional_F1(10052, 9995, 10008) || ((includeStatic
                && DynAbs.Tracing.TraceSender.Conditional_F2(10052, 10028, 10082)) || DynAbs.Tracing.TraceSender.Conditional_F3(10052, 10102, 10130))) ? f_10052_10028_10082(this, WellKnownMemberNames.StaticConstructorName) : ImmutableArray<Symbol>.Empty
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 10147, 10296) || true) && (instanceCandidates.IsEmpty && (DynAbs.Tracing.TraceSender.Expression_True(10052, 10151, 10205) && staticCandidates.IsEmpty))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 10147, 10296);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 10239, 10281);

                    return ImmutableArray<MethodSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 10147, 10296);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 10312, 10395);

                ArrayBuilder<MethodSymbol>
                constructors = f_10052_10354_10394()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 10409, 10707);
                    foreach (Symbol candidate in f_10052_10438_10456_I(instanceCandidates))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 10409, 10707);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 10490, 10692) || true) && (candidate is MethodSymbol method)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 10490, 10692);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 10568, 10626);

                            f_10052_10568_10625(f_10052_10581_10598(method) == MethodKind.Constructor);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 10648, 10673);

                            f_10052_10648_10672(constructors, method);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 10490, 10692);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 10409, 10707);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10052, 1, 299);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10052, 1, 299);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 10721, 11023);
                    foreach (Symbol candidate in f_10052_10750_10766_I(staticCandidates))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 10721, 11023);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 10800, 11008) || true) && (candidate is MethodSymbol method)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 10800, 11008);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 10878, 10942);

                            f_10052_10878_10941(f_10052_10891_10908(method) == MethodKind.StaticConstructor);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 10964, 10989);

                            f_10052_10964_10988(constructors, method);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 10800, 11008);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 10721, 11023);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10052, 1, 303);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10052, 1, 303);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 11037, 11078);

                return f_10052_11044_11077(constructors);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 9573, 11089);

                int
                f_10052_9692_9738(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 9692, 9738);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10052_9834_9890(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 9834, 9890);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10052_10028_10082(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 10028, 10082);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10052_10354_10394()
                {
                    var return_v = ArrayBuilder<MethodSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 10354, 10394);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10052_10581_10598(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 10581, 10598);
                    return return_v;
                }


                int
                f_10052_10568_10625(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 10568, 10625);
                    return 0;
                }


                int
                f_10052_10648_10672(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 10648, 10672);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10052_10438_10456_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 10438, 10456);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10052_10891_10908(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 10891, 10908);
                    return return_v;
                }


                int
                f_10052_10878_10941(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 10878, 10941);
                    return 0;
                }


                int
                f_10052_10964_10988(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 10964, 10988);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10052_10750_10766_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 10750, 10766);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10052_11044_11077(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 11044, 11077);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 9573, 11089);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 9573, 11089);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ImmutableArray<PropertySymbol> Indexers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 11392, 12391);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 11428, 11518);

                    ImmutableArray<Symbol>
                    candidates = f_10052_11464_11517(this, WellKnownMemberNames.Indexer)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 11538, 11665) || true) && (candidates.IsEmpty)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 11538, 11665);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 11602, 11646);

                        return ImmutableArray<PropertySymbol>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 11538, 11665);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 11888, 11971);

                    ArrayBuilder<PropertySymbol>
                    indexers = f_10052_11928_11970()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 11989, 12321);
                        foreach (Symbol candidate in f_10052_12018_12028_I(candidates))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 11989, 12321);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 12070, 12302) || true) && (f_10052_12074_12088(candidate) == SymbolKind.Property)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 12070, 12302);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 12161, 12213);

                                f_10052_12161_12212(f_10052_12174_12211(((PropertySymbol)candidate)));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 12239, 12279);

                                f_10052_12239_12278(indexers, candidate);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 12070, 12302);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 11989, 12321);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10052, 1, 333);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10052, 1, 333);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 12339, 12376);

                    return f_10052_12346_12375(indexers);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 11392, 12391);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10052_11464_11517(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param, string
                    name)
                    {
                        var return_v = this_param.GetSimpleNonTypeMembers(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 11464, 11517);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                    f_10052_11928_11970()
                    {
                        var return_v = ArrayBuilder<PropertySymbol>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 11928, 11970);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10052_12074_12088(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 12074, 12088);
                        return return_v;
                    }


                    bool
                    f_10052_12174_12211(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.IsIndexer;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 12174, 12211);
                        return return_v;
                    }


                    int
                    f_10052_12161_12212(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 12161, 12212);
                        return 0;
                    }


                    int
                    f_10052_12239_12278(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 12239, 12278);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10052_12018_12028_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 12018, 12028);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                    f_10052_12346_12375(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 12346, 12375);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 11321, 12402);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 11321, 12402);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract bool MightContainExtensionMethods { get; }

        internal void GetExtensionMethods(ArrayBuilder<MethodSymbol> methods, string nameOpt, int arity, LookupOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 12831, 13128);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 12975, 13117) || true) && (f_10052_12979_13012(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 12975, 13117);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 13046, 13102);

                    f_10052_13046_13101(this, methods, nameOpt, arity, options);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 12975, 13117);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 12831, 13128);

                bool
                f_10052_12979_13012(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.MightContainExtensionMethods;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 12979, 13012);
                    return return_v;
                }


                int
                f_10052_13046_13101(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                methods, string
                nameOpt, int
                arity, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options)
                {
                    this_param.DoGetExtensionMethods(methods, nameOpt, arity, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 13046, 13101);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 12831, 13128);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 12831, 13128);
            }
        }

        internal void DoGetExtensionMethods(ArrayBuilder<MethodSymbol> methods, string nameOpt, int arity, LookupOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 13140, 14514);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 13286, 13419);

                var
                members = (DynAbs.Tracing.TraceSender.Conditional_F1(10052, 13300, 13315) || ((nameOpt == null
                && DynAbs.Tracing.TraceSender.Conditional_F2(10052, 13335, 13361)) || DynAbs.Tracing.TraceSender.Conditional_F3(10052, 13381, 13418))) ? f_10052_13335_13361(this) : f_10052_13381_13418(this, nameOpt)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 13435, 14503);
                    foreach (var member in f_10052_13458_13465_I(members))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 13435, 14503);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 13499, 14488) || true) && (f_10052_13503_13514(member) == SymbolKind.Method)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 13499, 14488);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 13577, 13611);

                            var
                            method = (MethodSymbol)member
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 13633, 14469) || true) && (f_10052_13637_13661(method) && (DynAbs.Tracing.TraceSender.Expression_True(10052, 13637, 13769) && ((options & LookupOptions.AllMethodsOnArityZero) != 0 || (DynAbs.Tracing.TraceSender.Expression_False(10052, 13691, 13768) || arity == f_10052_13756_13768(method)))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 13633, 14469);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 13819, 13861);

                                var
                                thisParam = method.Parameters.First()
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 13889, 14309) || true) && ((f_10052_13894_13911(thisParam) == RefKind.Ref && (DynAbs.Tracing.TraceSender.Expression_True(10052, 13894, 13957) && f_10052_13930_13957_M(!f_10052_13931_13945(thisParam).IsValueType))) || (DynAbs.Tracing.TraceSender.Expression_False(10052, 13893, 14070) || (f_10052_13992_14009(thisParam) == RefKind.In && (DynAbs.Tracing.TraceSender.Expression_True(10052, 13992, 14069) && f_10052_14027_14050(f_10052_14027_14041(thisParam)) != TypeKind.Struct))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 13889, 14309);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 14273, 14282);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 13889, 14309);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 14337, 14400);

                                f_10052_14337_14399(f_10052_14350_14367(method) != MethodKind.ReducedExtension);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 14426, 14446);

                                f_10052_14426_14445(methods, method);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 13633, 14469);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 13499, 14488);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 13435, 14503);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10052, 1, 1069);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10052, 1, 1069);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 13140, 14514);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10052_13335_13361(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembersUnordered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 13335, 13361);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10052_13381_13418(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetSimpleNonTypeMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 13381, 13418);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10052_13503_13514(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 13503, 13514);
                    return return_v;
                }


                bool
                f_10052_13637_13661(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsExtensionMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 13637, 13661);
                    return return_v;
                }


                int
                f_10052_13756_13768(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 13756, 13768);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10052_13894_13911(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 13894, 13911);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10052_13931_13945(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 13931, 13945);
                    return return_v;
                }


                bool
                f_10052_13930_13957_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 13930, 13957);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10052_13992_14009(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 13992, 14009);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10052_14027_14041(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 14027, 14041);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10052_14027_14050(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 14027, 14050);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10052_14350_14367(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 14350, 14367);
                    return return_v;
                }


                int
                f_10052_14337_14399(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 14337, 14399);
                    return 0;
                }


                int
                f_10052_14426_14445(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 14426, 14445);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10052_13458_13465_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 13458, 13465);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 13140, 14514);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 13140, 14514);
            }
        }

        public override bool IsReferenceType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 15051, 15222);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 15087, 15107);

                    var
                    kind = f_10052_15098_15106()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 15125, 15207);

                    return kind != TypeKind.Enum && (DynAbs.Tracing.TraceSender.Expression_True(10052, 15132, 15180) && kind != TypeKind.Struct) && (DynAbs.Tracing.TraceSender.Expression_True(10052, 15132, 15206) && kind != TypeKind.Error);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 15051, 15222);

                    Microsoft.CodeAnalysis.TypeKind
                    f_10052_15098_15106()
                    {
                        var return_v = TypeKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 15098, 15106);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 14990, 15233);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 14990, 15233);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 15621, 15766);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 15657, 15677);

                    var
                    kind = f_10052_15668_15676()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 15695, 15751);

                    return kind == TypeKind.Struct || (DynAbs.Tracing.TraceSender.Expression_False(10052, 15702, 15750) || kind == TypeKind.Enum);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 15621, 15766);

                    Microsoft.CodeAnalysis.TypeKind
                    f_10052_15668_15676()
                    {
                        var return_v = TypeKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 15668, 15676);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 15564, 15777);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 15564, 15777);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ManagedKind GetManagedKind(ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 15789, 16237);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 16157, 16226);

                return f_10052_16164_16225(this, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 15789, 16237);

                Microsoft.CodeAnalysis.ManagedKind
                f_10052_16164_16225(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = BaseTypeAnalysis.GetManagedKind(type, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 16164, 16225);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 15789, 16237);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 15789, 16237);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract AttributeUsageInfo GetAttributeUsageInfo();

        public virtual bool IsScriptClass
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 16699, 16763);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 16735, 16748);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 16699, 16763);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 16641, 16774);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 16641, 16774);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsSubmissionClass
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 16842, 16932);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 16878, 16917);

                    return f_10052_16885_16893() == TypeKind.Submission;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 16842, 16932);

                    Microsoft.CodeAnalysis.TypeKind
                    f_10052_16885_16893()
                    {
                        var return_v = TypeKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 16885, 16893);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 16786, 16943);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 16786, 16943);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal SynthesizedInstanceConstructor GetScriptConstructor()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 16955, 17164);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 17042, 17070);

                f_10052_17042_17069(f_10052_17055_17068());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 17084, 17153);

                return (SynthesizedInstanceConstructor)f_10052_17123_17143().Single();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 16955, 17164);

                bool
                f_10052_17055_17068()
                {
                    var return_v = IsScriptClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 17055, 17068);
                    return return_v;
                }


                int
                f_10052_17042_17069(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 17042, 17069);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10052_17123_17143()
                {
                    var return_v = InstanceConstructors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 17123, 17143);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 16955, 17164);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 16955, 17164);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SynthesizedInteractiveInitializerMethod GetScriptInitializer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 17176, 17450);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 17272, 17300);

                f_10052_17272_17299(f_10052_17285_17298());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 17314, 17439);

                return (SynthesizedInteractiveInitializerMethod)f_10052_17362_17429(this, SynthesizedInteractiveInitializerMethod.InitializerName).Single();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 17176, 17450);

                bool
                f_10052_17285_17298()
                {
                    var return_v = IsScriptClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 17285, 17298);
                    return return_v;
                }


                int
                f_10052_17272_17299(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 17272, 17299);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10052_17362_17429(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 17362, 17429);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 17176, 17450);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 17176, 17450);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SynthesizedEntryPointSymbol GetScriptEntryPoint()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 17462, 17800);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 17545, 17573);

                f_10052_17545_17572(f_10052_17558_17571());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 17587, 17713);

                var
                name = (DynAbs.Tracing.TraceSender.Conditional_F1(10052, 17598, 17631) || (((f_10052_17599_17607() == TypeKind.Submission) && DynAbs.Tracing.TraceSender.Conditional_F2(10052, 17634, 17673)) || DynAbs.Tracing.TraceSender.Conditional_F3(10052, 17676, 17712))) ? SynthesizedEntryPointSymbol.FactoryName : SynthesizedEntryPointSymbol.MainName
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 17727, 17789);

                return (SynthesizedEntryPointSymbol)f_10052_17763_17779(this, name).Single();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 17462, 17800);

                bool
                f_10052_17558_17571()
                {
                    var return_v = IsScriptClass;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 17558, 17571);
                    return return_v;
                }


                int
                f_10052_17545_17572(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 17545, 17572);
                    return 0;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10052_17599_17607()
                {
                    var return_v = TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 17599, 17607);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10052_17763_17779(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 17763, 17779);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 17462, 17800);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 17462, 17800);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual bool IsImplicitClass
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 18082, 18146);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 18118, 18131);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 18082, 18146);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 18022, 18157);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 18022, 18157);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract override string Name { get; }

        public override string MetadataName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 18574, 18714);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 18610, 18699);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10052, 18617, 18627) || ((f_10052_18617_18627() && DynAbs.Tracing.TraceSender.Conditional_F2(10052, 18630, 18691)) || DynAbs.Tracing.TraceSender.Conditional_F3(10052, 18694, 18698))) ? f_10052_18630_18691(f_10052_18679_18683(), f_10052_18685_18690()) : f_10052_18694_18698();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 18574, 18714);

                    bool
                    f_10052_18617_18627()
                    {
                        var return_v = MangleName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 18617, 18627);
                        return return_v;
                    }


                    string
                    f_10052_18679_18683()
                    {
                        var return_v = Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 18679, 18683);
                        return return_v;
                    }


                    int
                    f_10052_18685_18690()
                    {
                        var return_v = Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 18685, 18690);
                        return return_v;
                    }


                    string
                    f_10052_18630_18691(string
                    name, int
                    arity)
                    {
                        var return_v = MetadataHelpers.ComposeAritySuffixedMetadataName(name, arity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 18630, 18691);
                        return return_v;
                    }


                    string
                    f_10052_18694_18698()
                    {
                        var return_v = Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 18694, 18698);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 18514, 18725);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 18514, 18725);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract bool MangleName
        {            // Intentionally no default implementation to force consideration of appropriate implementation for each new subclass
            get;
        }

        public abstract IEnumerable<string> MemberNames { get; }

        public abstract override ImmutableArray<Symbol> GetMembers();

        public abstract override ImmutableArray<Symbol> GetMembers(string name);

        internal abstract bool HasPossibleWellKnownCloneMethod();

        internal virtual ImmutableArray<Symbol> GetSimpleNonTypeMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 20588, 20724);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 20689, 20713);

                return f_10052_20696_20712(this, name);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 20588, 20724);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10052_20696_20712(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 20696, 20712);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 20588, 20724);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 20588, 20724);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public abstract override ImmutableArray<NamedTypeSymbol> GetTypeMembers();

        public abstract override ImmutableArray<NamedTypeSymbol> GetTypeMembers(string name);

        public abstract override ImmutableArray<NamedTypeSymbol> GetTypeMembers(string name, int arity);

        internal virtual IEnumerable<Symbol> GetInstanceFieldsAndEvents()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 22468, 22628);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 22558, 22617);

                return f_10052_22565_22586(this).Where(IsInstanceFieldOrEvent);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 22468, 22628);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10052_22565_22586(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembersUnordered();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 22565, 22586);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 22468, 22628);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 22468, 22628);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected static Func<Symbol, bool> IsInstanceFieldOrEvent;

        public abstract override Accessibility DeclaredAccessibility { get; }

        internal override TResult Accept<TArgument, TResult>(CSharpSymbolVisitor<TArgument, TResult> visitor, TArgument argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 23429, 23632);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 23575, 23621);

                return f_10052_23582_23620<TResult, TArgument>(visitor, this, argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 23429, 23632);

                TResult
                f_10052_23582_23620<TResult, TArgument>(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TArgument, TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol, TArgument
                argument)
                {
                    var return_v = this_param.VisitNamedType(symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 23582, 23620);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 23429, 23632);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 23429, 23632);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void Accept(CSharpSymbolVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 23644, 23765);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 23725, 23754);

                f_10052_23725_23753(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 23644, 23765);

                int
                f_10052_23725_23753(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    this_param.VisitNamedType(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 23725, 23753);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 23644, 23765);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 23644, 23765);
            }
        }

        public override TResult Accept<TResult>(CSharpSymbolVisitor<TResult> visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 23777, 23926);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 23879, 23915);

                return f_10052_23886_23914<TResult>(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 23777, 23926);

                TResult
                f_10052_23886_23914<TResult>(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = this_param.VisitNamedType(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 23886, 23914);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 23777, 23926);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 23777, 23926);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract ImmutableArray<Symbol> GetEarlyAttributeDecodingMembers();

        internal abstract ImmutableArray<Symbol> GetEarlyAttributeDecodingMembers(string name);

        public override SymbolKind Kind // Cannot seal this method because of the ErrorSymbol.
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 25232, 25311);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 25268, 25296);

                    return SymbolKind.NamedType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 25232, 25311);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 25121, 25322);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 25121, 25322);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract NamedTypeSymbol GetDeclaredBaseType(ConsList<TypeSymbol> basesBeingResolved);

        internal abstract ImmutableArray<NamedTypeSymbol> GetDeclaredInterfaces(ConsList<TypeSymbol> basesBeingResolved);

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 25566, 26156);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 25877, 26013) || true) && (f_10052_25881_25897(this) == SpecialType.System_Object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 25877, 26013);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 25960, 25998);

                    return (int)SpecialType.System_Object;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 25877, 26013);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 26091, 26145);

                return f_10052_26098_26144(f_10052_26125_26143());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 25566, 26156);

                Microsoft.CodeAnalysis.SpecialType
                f_10052_25881_25897(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 25881, 25897);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10052_26125_26143()
                {
                    var return_v = OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 26125, 26143);
                    return return_v;
                }


                int
                f_10052_26098_26144(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                o)
                {
                    var return_v = RuntimeHelpers.GetHashCode((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 26098, 26144);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 25566, 26156);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 25566, 26156);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool Equals(TypeSymbol t2, TypeCompareKind comparison)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 26264, 28719);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 26361, 26397) || true) && ((object)t2 == this)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 26361, 26397);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 26385, 26397);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 26361, 26397);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 26411, 26448) || true) && ((object)t2 == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 26411, 26448);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 26435, 26448);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 26411, 26448);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 26464, 26890) || true) && ((comparison & TypeCompareKind.IgnoreDynamic) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 26464, 26890);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 26551, 26875) || true) && (f_10052_26555_26566(t2) == TypeKind.Dynamic)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 26551, 26875);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 26722, 26856) || true) && (f_10052_26726_26742(this) == SpecialType.System_Object)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 26722, 26856);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 26821, 26833);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 26722, 26856);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 26551, 26875);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 26464, 26890);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 26906, 26952);

                NamedTypeSymbol
                other = t2 as NamedTypeSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 26966, 27006) || true) && ((object)other == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 26966, 27006);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 26993, 27006);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 26966, 27006);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 27067, 27120);

                var
                thisOriginalDefinition = f_10052_27096_27119(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 27134, 27189);

                var
                otherOriginalDefinition = f_10052_27164_27188(other)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 27205, 27286);

                bool
                thisIsOriginalDefinition = ((object)this == (object)thisOriginalDefinition)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 27300, 27384);

                bool
                otherIsOriginalDefinition = ((object)other == (object)otherOriginalDefinition)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 27400, 27600) || true) && (thisIsOriginalDefinition && (DynAbs.Tracing.TraceSender.Expression_True(10052, 27404, 27457) && otherIsOriginalDefinition))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 27400, 27600);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 27572, 27585);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 27400, 27600);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 27616, 27922) || true) && ((thisIsOriginalDefinition || (DynAbs.Tracing.TraceSender.Expression_False(10052, 27621, 27674) || otherIsOriginalDefinition)) && (DynAbs.Tracing.TraceSender.Expression_True(10052, 27620, 27860) && (comparison & (TypeCompareKind.IgnoreCustomModifiersAndArraySizesAndLowerBounds | TypeCompareKind.AllNullableIgnoreOptions | TypeCompareKind.IgnoreTupleNames)) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 27616, 27922);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 27894, 27907);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 27616, 27922);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 28270, 28404) || true) && (!f_10052_28275_28342(thisOriginalDefinition, otherOriginalDefinition, comparison))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 28270, 28404);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 28376, 28389);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 28270, 28404);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 28659, 28708);

                return f_10052_28666_28707(this, other, comparison);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 26264, 28719);

                Microsoft.CodeAnalysis.TypeKind
                f_10052_26555_26566(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 26555, 26566);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10052_26726_26742(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 26726, 26742);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10052_27096_27119(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 27096, 27119);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10052_27164_27188(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 27164, 27188);
                    return return_v;
                }


                bool
                f_10052_28275_28342(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 28275, 28342);
                    return return_v;
                }


                bool
                f_10052_28666_28707(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                other, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = this_param.EqualsComplicatedCases(other, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 28666, 28707);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 26264, 28719);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 26264, 28719);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool EqualsComplicatedCases(NamedTypeSymbol other, TypeCompareKind comparison)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 28905, 31946);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 29016, 29199) || true) && ((object)f_10052_29028_29047(this) != null && (DynAbs.Tracing.TraceSender.Expression_True(10052, 29020, 29137) && !f_10052_29077_29137(f_10052_29077_29096(this), f_10052_29104_29124(other), comparison)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 29016, 29199);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 29171, 29184);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 29016, 29199);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 29215, 29281);

                var
                thisIsNotConstructed = f_10052_29242_29280(f_10052_29258_29273(), this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 29295, 29369);

                var
                otherIsNotConstructed = f_10052_29323_29368(f_10052_29339_29360(other), other)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 29385, 29965) || true) && (thisIsNotConstructed && (DynAbs.Tracing.TraceSender.Expression_True(10052, 29389, 29434) && otherIsNotConstructed))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 29385, 29965);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 29938, 29950);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 29385, 29965);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 29981, 30102) || true) && (f_10052_29985_30010(this) != f_10052_30014_30040(other))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 29981, 30102);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 30074, 30087);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 29981, 30102);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 30118, 30417) || true) && ((thisIsNotConstructed || (DynAbs.Tracing.TraceSender.Expression_False(10052, 30123, 30168) || otherIsNotConstructed)) && (DynAbs.Tracing.TraceSender.Expression_True(10052, 30122, 30355) && (comparison & (TypeCompareKind.IgnoreCustomModifiersAndArraySizesAndLowerBounds | TypeCompareKind.AllNullableIgnoreOptions | TypeCompareKind.IgnoreTupleNames)) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 30118, 30417);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 30389, 30402);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 30118, 30417);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 30433, 30507);

                var
                typeArguments = f_10052_30453_30506(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 30521, 30601);

                var
                otherTypeArguments = f_10052_30546_30600(other)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 30615, 30648);

                int
                count = typeArguments.Length
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 30768, 30817);

                f_10052_30768_30816(count == otherTypeArguments.Length);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 30842, 30847);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 30833, 31159) || true) && (i < count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 30860, 30863)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 30833, 31159))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 30833, 31159);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 30897, 30933);

                        var
                        typeArgument = typeArguments[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 30951, 30997);

                        var
                        otherTypeArgument = otherTypeArguments[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 31015, 31144) || true) && (!typeArgument.Equals(otherTypeArgument, comparison))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 31015, 31144);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 31112, 31125);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 31015, 31144);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10052, 1, 327);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10052, 1, 327);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 31175, 31297) || true) && (f_10052_31179_31195(this) && (DynAbs.Tracing.TraceSender.Expression_True(10052, 31179, 31235) && !f_10052_31200_31235(other, comparison)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 31175, 31297);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 31269, 31282);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 31175, 31297);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 31313, 31325);

                return true;

                bool tupleNamesEquals(NamedTypeSymbol other, TypeCompareKind comparison)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 31341, 31935);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 31502, 31888) || true) && ((comparison & TypeCompareKind.IgnoreTupleNames) == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 31502, 31888);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 31600, 31637);

                            var
                            elementNames = f_10052_31619_31636()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 31659, 31707);

                            var
                            otherElementNames = f_10052_31683_31706(other)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 31729, 31869);

                            return (DynAbs.Tracing.TraceSender.Conditional_F1(10052, 31736, 31758) || ((elementNames.IsDefault && DynAbs.Tracing.TraceSender.Conditional_F2(10052, 31761, 31788)) || DynAbs.Tracing.TraceSender.Conditional_F3(10052, 31791, 31868))) ? otherElementNames.IsDefault : f_10052_31791_31819_M(!otherElementNames.IsDefault) && (DynAbs.Tracing.TraceSender.Expression_True(10052, 31791, 31868) && elementNames.SequenceEqual(otherElementNames));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 31502, 31888);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 31908, 31920);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 31341, 31935);

                        System.Collections.Immutable.ImmutableArray<string?>
                        f_10052_31619_31636()
                        {
                            var return_v = TupleElementNames;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 31619, 31636);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<string?>
                        f_10052_31683_31706(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        this_param)
                        {
                            var return_v = this_param.TupleElementNames;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 31683, 31706);
                            return return_v;
                        }


                        bool
                        f_10052_31791_31819_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 31791, 31819);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 31341, 31935);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 31341, 31935);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 28905, 31946);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10052_29028_29047(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 29028, 29047);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10052_29077_29096(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 29077, 29096);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10052_29104_29124(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 29104, 29124);
                    return return_v;
                }


                bool
                f_10052_29077_29137(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 29077, 29137);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10052_29258_29273()
                {
                    var return_v = ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 29258, 29273);
                    return return_v;
                }


                bool
                f_10052_29242_29280(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 29242, 29280);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10052_29339_29360(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 29339, 29360);
                    return return_v;
                }


                bool
                f_10052_29323_29368(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 29323, 29368);
                    return return_v;
                }


                bool
                f_10052_29985_30010(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsUnboundGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 29985, 30010);
                    return return_v;
                }


                bool
                f_10052_30014_30040(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsUnboundGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 30014, 30040);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10052_30453_30506(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 30453, 30506);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10052_30546_30600(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 30546, 30600);
                    return return_v;
                }


                int
                f_10052_30768_30816(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 30768, 30816);
                    return 0;
                }


                bool
                f_10052_31179_31195(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsTupleType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 31179, 31195);
                    return return_v;
                }


                bool
                f_10052_31200_31235(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                other, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = tupleNamesEquals(other, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 31200, 31235);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 28905, 31946);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 28905, 31946);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void AddNullableTransforms(ArrayBuilder<byte> transforms)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 31958, 32311);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 32058, 32108);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10052_32058_32072(), 10052, 32058, 32107)?.AddNullableTransforms(transforms), 10052, 32073, 32107);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 32124, 32300);
                    foreach (TypeWithAnnotations arg in f_10052_32160_32213_I(f_10052_32160_32213(this)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 32124, 32300);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 32247, 32285);

                        arg.AddNullableTransforms(transforms);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 32124, 32300);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10052, 1, 177);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10052, 1, 177);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 31958, 32311);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10052_32058_32072()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 32058, 32072);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10052_32160_32213(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 32160, 32213);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10052_32160_32213_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 32160, 32213);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 31958, 32311);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 31958, 32311);
            }
        }

        internal override bool ApplyNullableTransforms(byte defaultTransformFlag, ImmutableArray<byte> transforms, ref int position, out TypeSymbol result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 32323, 33700);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 32495, 32606) || true) && (f_10052_32499_32513_M(!IsGenericType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 32495, 32606);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 32547, 32561);

                    result = this;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 32579, 32591);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 32495, 32606);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 32622, 32693);

                var
                allTypeArguments = f_10052_32645_32692()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 32707, 32765);

                f_10052_32707_32764(this, allTypeArguments);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 32781, 32806);

                bool
                haveChanges = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 32829, 32834);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 32820, 33524) || true) && (i < f_10052_32840_32862(allTypeArguments))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 32864, 32867)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 32820, 33524))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 32820, 33524);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 32901, 32959);

                        TypeWithAnnotations
                        oldTypeArgument = f_10052_32939_32958(allTypeArguments, i)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 32977, 33013);

                        TypeWithAnnotations
                        newTypeArgument
                        = default(TypeWithAnnotations);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 33031, 33509) || true) && (!oldTypeArgument.ApplyNullableTransforms(defaultTransformFlag, transforms, ref position, out newTypeArgument))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 33031, 33509);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 33186, 33210);

                            f_10052_33186_33209(allTypeArguments);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 33232, 33246);

                            result = this;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 33268, 33281);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 33031, 33509);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 33031, 33509);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 33323, 33509) || true) && (!oldTypeArgument.IsSameAs(newTypeArgument))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 33323, 33509);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 33411, 33449);

                                allTypeArguments[i] = newTypeArgument;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 33471, 33490);

                                haveChanges = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 33323, 33509);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 33031, 33509);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10052, 1, 705);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10052, 1, 705);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 33540, 33625);

                result = (DynAbs.Tracing.TraceSender.Conditional_F1(10052, 33549, 33560) || ((haveChanges && DynAbs.Tracing.TraceSender.Conditional_F2(10052, 33563, 33617)) || DynAbs.Tracing.TraceSender.Conditional_F3(10052, 33620, 33624))) ? f_10052_33563_33617(this, f_10052_33586_33616(allTypeArguments)) : this;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 33639, 33663);

                f_10052_33639_33662(allTypeArguments);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 33677, 33689);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 32323, 33700);

                bool
                f_10052_32499_32513_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 32499, 32513);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10052_32645_32692()
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 32645, 32692);
                    return return_v;
                }


                int
                f_10052_32707_32764(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                builder)
                {
                    this_param.GetAllTypeArgumentsNoUseSiteDiagnostics(builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 32707, 32764);
                    return 0;
                }


                int
                f_10052_32840_32862(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 32840, 32862);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10052_32939_32958(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 32939, 32958);
                    return return_v;
                }


                int
                f_10052_33186_33209(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 33186, 33209);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10052_33586_33616(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 33586, 33616);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10052_33563_33617(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                allTypeArguments)
                {
                    var return_v = this_param.WithTypeArguments(allTypeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 33563, 33617);
                    return return_v;
                }


                int
                f_10052_33639_33662(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 33639, 33662);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 32323, 33700);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 32323, 33700);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override TypeSymbol SetNullabilityForReferenceTypes(Func<TypeWithAnnotations, TypeWithAnnotations> transform)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 33712, 34783);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 33855, 33934) || true) && (f_10052_33859_33873_M(!IsGenericType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 33855, 33934);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 33907, 33919);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 33855, 33934);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 33950, 34021);

                var
                allTypeArguments = f_10052_33973_34020()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 34035, 34093);

                f_10052_34035_34092(this, allTypeArguments);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 34109, 34134);

                bool
                haveChanges = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 34157, 34162);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 34148, 34589) || true) && (i < f_10052_34168_34190(allTypeArguments))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 34192, 34195)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 34148, 34589))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 34148, 34589);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 34229, 34287);

                        TypeWithAnnotations
                        oldTypeArgument = f_10052_34267_34286(allTypeArguments, i)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 34305, 34370);

                        TypeWithAnnotations
                        newTypeArgument = f_10052_34343_34369(transform, oldTypeArgument)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 34388, 34574) || true) && (!oldTypeArgument.IsSameAs(newTypeArgument))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 34388, 34574);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 34476, 34514);

                            allTypeArguments[i] = newTypeArgument;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 34536, 34555);

                            haveChanges = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 34388, 34574);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10052, 1, 442);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10052, 1, 442);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 34605, 34706);

                NamedTypeSymbol
                result = (DynAbs.Tracing.TraceSender.Conditional_F1(10052, 34630, 34641) || ((haveChanges && DynAbs.Tracing.TraceSender.Conditional_F2(10052, 34644, 34698)) || DynAbs.Tracing.TraceSender.Conditional_F3(10052, 34701, 34705))) ? f_10052_34644_34698(this, f_10052_34667_34697(allTypeArguments)) : this
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 34720, 34744);

                f_10052_34720_34743(allTypeArguments);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 34758, 34772);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 33712, 34783);

                bool
                f_10052_33859_33873_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 33859, 33873);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10052_33973_34020()
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 33973, 34020);
                    return return_v;
                }


                int
                f_10052_34035_34092(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                builder)
                {
                    this_param.GetAllTypeArgumentsNoUseSiteDiagnostics(builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 34035, 34092);
                    return 0;
                }


                int
                f_10052_34168_34190(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 34168, 34190);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10052_34267_34286(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 34267, 34286);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10052_34343_34369(System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 34343, 34369);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10052_34667_34697(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 34667, 34697);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10052_34644_34698(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                allTypeArguments)
                {
                    var return_v = this_param.WithTypeArguments(allTypeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 34644, 34698);
                    return return_v;
                }


                int
                f_10052_34720_34743(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 34720, 34743);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 33712, 34783);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 33712, 34783);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal NamedTypeSymbol WithTypeArguments(ImmutableArray<TypeWithAnnotations> allTypeArguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 34795, 35160);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 34916, 34957);

                var
                definition = f_10052_34933_34956(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 34971, 35059);

                TypeMap
                substitution = f_10052_34994_35058(f_10052_35006_35039(definition), allTypeArguments)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 35073, 35149);

                return f_10052_35080_35148(f_10052_35080_35124(substitution, definition), this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 34795, 35160);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10052_34933_34956(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 34933, 34956);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10052_35006_35039(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.GetAllTypeParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 35006, 35039);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10052_34994_35058(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                from, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                to)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap(from, to);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 34994, 35058);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10052_35080_35124(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                previous)
                {
                    var return_v = this_param.SubstituteNamedType(previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 35080, 35124);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10052_35080_35148(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                original)
                {
                    var return_v = this_param.WithTupleDataFrom(original);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 35080, 35148);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 34795, 35160);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 34795, 35160);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override TypeSymbol MergeEquivalentTypes(TypeSymbol other, VarianceKind variance)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 35172, 36424);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 35287, 35423);

                f_10052_35287_35422(f_10052_35300_35421(this, other, TypeCompareKind.IgnoreDynamicAndTupleNames | TypeCompareKind.IgnoreNullableModifiersForReferenceTypes));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 35439, 35546) || true) && (f_10052_35443_35457_M(!IsGenericType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 35439, 35546);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 35491, 35531);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10052, 35498, 35515) || ((f_10052_35498_35515(other) && DynAbs.Tracing.TraceSender.Conditional_F2(10052, 35518, 35523)) || DynAbs.Tracing.TraceSender.Conditional_F3(10052, 35526, 35530))) ? other : this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 35439, 35546);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 35562, 35634);

                var
                allTypeParameters = f_10052_35586_35633()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 35648, 35719);

                var
                allTypeArguments = f_10052_35671_35718()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 35733, 35858);

                bool
                haveChanges = f_10052_35752_35857(this, other, variance, allTypeParameters, allTypeArguments)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 35874, 35897);

                NamedTypeSymbol
                result
                = default(NamedTypeSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 35911, 36240) || true) && (haveChanges)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 35911, 36240);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 35960, 36060);

                    TypeMap
                    substitution = f_10052_35983_36059(f_10052_35995_36026(allTypeParameters), f_10052_36028_36058(allTypeArguments))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 36078, 36145);

                    result = f_10052_36087_36144(substitution, f_10052_36120_36143(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 35911, 36240);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 35911, 36240);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 36211, 36225);

                    result = this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 35911, 36240);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 36256, 36280);

                f_10052_36256_36279(
                            allTypeArguments);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 36294, 36319);

                f_10052_36294_36318(allTypeParameters);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 36335, 36413);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10052, 36342, 36353) || ((f_10052_36342_36353() && DynAbs.Tracing.TraceSender.Conditional_F2(10052, 36356, 36403)) || DynAbs.Tracing.TraceSender.Conditional_F3(10052, 36406, 36412))) ? f_10052_36356_36403(this, other, result) : result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 35172, 36424);

                bool
                f_10052_35300_35421(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = this_param.Equals(t2, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 35300, 35421);
                    return return_v;
                }


                int
                f_10052_35287_35422(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 35287, 35422);
                    return 0;
                }


                bool
                f_10052_35443_35457_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 35443, 35457);
                    return return_v;
                }


                bool
                f_10052_35498_35515(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 35498, 35515);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10052_35586_35633()
                {
                    var return_v = ArrayBuilder<TypeParameterSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 35586, 35633);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10052_35671_35718()
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 35671, 35718);
                    return return_v;
                }


                bool
                f_10052_35752_35857(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                typeA, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeB, Microsoft.CodeAnalysis.VarianceKind
                variance, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                allTypeParameters, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                allTypeArguments)
                {
                    var return_v = MergeEquivalentTypeArguments(typeA, (Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)typeB, variance, allTypeParameters, allTypeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 35752, 35857);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10052_35995_36026(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 35995, 36026);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10052_36028_36058(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 36028, 36058);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                f_10052_35983_36059(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                from, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                to)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap(from, to);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 35983, 36059);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10052_36120_36143(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 36120, 36143);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10052_36087_36144(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                previous)
                {
                    var return_v = this_param.SubstituteNamedType(previous);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 36087, 36144);
                    return return_v;
                }


                int
                f_10052_36256_36279(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 36256, 36279);
                    return 0;
                }


                int
                f_10052_36294_36318(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 36294, 36318);
                    return 0;
                }


                bool
                f_10052_36342_36353()
                {
                    var return_v = IsTupleType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 36342, 36353);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10052_36356_36403(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                other, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                mergedType)
                {
                    var return_v = this_param.MergeTupleNames((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)other, mergedType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 36356, 36403);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 35172, 36424);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 35172, 36424);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool MergeEquivalentTypeArguments(
                    NamedTypeSymbol typeA,
                    NamedTypeSymbol typeB,
                    VarianceKind variance,
                    ArrayBuilder<TypeParameterSymbol> allTypeParameters,
                    ArrayBuilder<TypeWithAnnotations> allTypeArguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10052, 36796, 39112);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 37109, 37143);

                f_10052_37109_37142(f_10052_37122_37141(typeA));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 37157, 37294);

                f_10052_37157_37293(f_10052_37170_37292(typeA, typeB, TypeCompareKind.IgnoreDynamicAndTupleNames | TypeCompareKind.IgnoreNullableModifiersForReferenceTypes));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 37386, 37419);

                bool
                isTuple = f_10052_37401_37418(typeA)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 37435, 37477);

                var
                definition = f_10052_37452_37476(typeA)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 37491, 37516);

                bool
                haveChanges = false
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 37532, 39066) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 37532, 39066);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 37577, 37624);

                        var
                        typeParameters = f_10052_37598_37623(definition)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 37642, 38746) || true) && (typeParameters.Length > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 37642, 38746);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 37713, 37789);

                            var
                            typeArgumentsA = f_10052_37734_37788(typeA)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 37811, 37887);

                            var
                            typeArgumentsB = f_10052_37832_37886(typeB)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 37909, 37952);

                            f_10052_37909_37951(allTypeParameters, typeParameters);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 37983, 37988);
                                for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 37974, 38727) || true) && (i < typeArgumentsA.Length)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 38017, 38020)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 37974, 38727))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 37974, 38727);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 38070, 38124);

                                    TypeWithAnnotations
                                    typeArgumentA = typeArgumentsA[i]
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 38150, 38204);

                                    TypeWithAnnotations
                                    typeArgumentB = typeArgumentsB[i]
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 38230, 38357);

                                    VarianceKind
                                    typeArgumentVariance = f_10052_38266_38356(variance, (DynAbs.Tracing.TraceSender.Conditional_F1(10052, 38300, 38307) || ((isTuple && DynAbs.Tracing.TraceSender.Conditional_F2(10052, 38310, 38326)) || DynAbs.Tracing.TraceSender.Conditional_F3(10052, 38329, 38355))) ? VarianceKind.Out : f_10052_38329_38355(typeParameters[i]))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 38383, 38484);

                                    TypeWithAnnotations
                                    merged = typeArgumentA.MergeEquivalentTypes(typeArgumentB, typeArgumentVariance)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 38510, 38539);

                                    f_10052_38510_38538(allTypeArguments, merged);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 38565, 38704) || true) && (!typeArgumentA.IsSameAs(merged))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 38565, 38704);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 38658, 38677);

                                        haveChanges = true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 38565, 38704);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10052, 1, 754);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10052, 1, 754);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 37642, 38746);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 38764, 38803);

                        definition = f_10052_38777_38802(definition);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 38821, 38910) || true) && (definition is null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 38821, 38910);
                            DynAbs.Tracing.TraceSender.TraceBreak(10052, 38885, 38891);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 38821, 38910);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 38928, 38957);

                        typeA = f_10052_38936_38956(typeA);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 38975, 39004);

                        typeB = f_10052_38983_39003(typeB);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 39022, 39051);

                        variance = VarianceKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 37532, 39066);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10052, 37532, 39066);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10052, 37532, 39066);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 39082, 39101);

                return haveChanges;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10052, 36796, 39112);

                bool
                f_10052_37122_37141(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 37122, 37141);
                    return return_v;
                }


                int
                f_10052_37109_37142(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 37109, 37142);
                    return 0;
                }


                bool
                f_10052_37170_37292(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 37170, 37292);
                    return return_v;
                }


                int
                f_10052_37157_37293(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 37157, 37293);
                    return 0;
                }


                bool
                f_10052_37401_37418(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsTupleType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 37401, 37418);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10052_37452_37476(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 37452, 37476);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10052_37598_37623(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 37598, 37623);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10052_37734_37788(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 37734, 37788);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10052_37832_37886(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 37832, 37886);
                    return return_v;
                }


                int
                f_10052_37909_37951(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 37909, 37951);
                    return 0;
                }


                Microsoft.CodeAnalysis.VarianceKind
                f_10052_38329_38355(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Variance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 38329, 38355);
                    return return_v;
                }


                Microsoft.CodeAnalysis.VarianceKind
                f_10052_38266_38356(Microsoft.CodeAnalysis.VarianceKind
                typeVariance, Microsoft.CodeAnalysis.VarianceKind
                typeParameterVariance)
                {
                    var return_v = GetTypeArgumentVariance(typeVariance, typeParameterVariance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 38266, 38356);
                    return return_v;
                }


                int
                f_10052_38510_38538(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 38510, 38538);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10052_38777_38802(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 38777, 38802);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10052_38936_38956(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 38936, 38956);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10052_38983_39003(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 38983, 39003);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 36796, 39112);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 36796, 39112);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static VarianceKind GetTypeArgumentVariance(VarianceKind typeVariance, VarianceKind typeParameterVariance)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10052, 39124, 39917);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 39263, 39906);

                switch (typeVariance)
                {

                    case VarianceKind.In:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 39263, 39906);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 39360, 39727);

                        switch (typeParameterVariance)
                        {

                            case VarianceKind.In:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 39360, 39727);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 39490, 39514);

                                return VarianceKind.Out;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 39360, 39727);

                            case VarianceKind.Out:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 39360, 39727);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 39592, 39615);

                                return VarianceKind.In;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 39360, 39727);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 39360, 39727);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 39679, 39704);

                                return VarianceKind.None;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 39360, 39727);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 39263, 39906);

                    case VarianceKind.Out:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 39263, 39906);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 39789, 39818);

                        return typeParameterVariance;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 39263, 39906);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 39263, 39906);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 39866, 39891);

                        return VarianceKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 39263, 39906);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10052, 39124, 39917);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 39124, 39917);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 39124, 39917);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public NamedTypeSymbol Construct(params TypeSymbol[] typeArguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 40181, 40503);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 40417, 40492);

                return f_10052_40424_40491(this, f_10052_40450_40483(typeArguments), false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 40181, 40503);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                f_10052_40450_40483(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                items)
                {
                    var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 40450, 40483);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10052_40424_40491(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                typeArguments, bool
                unbound)
                {
                    var return_v = this_param.ConstructWithoutModifiers(typeArguments, unbound);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 40424, 40491);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 40181, 40503);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 40181, 40503);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public NamedTypeSymbol Construct(ImmutableArray<TypeSymbol> typeArguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 40767, 41104);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 41038, 41093);

                return f_10052_41045_41092(this, typeArguments, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 40767, 41104);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10052_41045_41092(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                typeArguments, bool
                unbound)
                {
                    var return_v = this_param.ConstructWithoutModifiers(typeArguments, unbound);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 41045, 41092);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 40767, 41104);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 40767, 41104);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public NamedTypeSymbol Construct(IEnumerable<TypeSymbol> typeArguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 41279, 41627);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 41541, 41616);

                return f_10052_41548_41615(this, f_10052_41574_41607(typeArguments), false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 41279, 41627);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                f_10052_41574_41607(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                items)
                {
                    var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 41574, 41607);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10052_41548_41615(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                typeArguments, bool
                unbound)
                {
                    var return_v = this_param.ConstructWithoutModifiers(typeArguments, unbound);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 41548, 41615);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 41279, 41627);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 41279, 41627);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public NamedTypeSymbol ConstructUnboundGenericType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 41751, 41888);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 41828, 41877);

                return f_10052_41835_41876(f_10052_41835_41853());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 41751, 41888);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10052_41835_41853()
                {
                    var return_v = OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 41835, 41853);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10052_41835_41876(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.AsUnboundGenericType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 41835, 41876);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 41751, 41888);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 41751, 41888);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal NamedTypeSymbol GetUnboundGenericTypeOrSelf()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 41900, 42132);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 41979, 42063) || true) && (f_10052_41983_42002_M(!this.IsGenericType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 41979, 42063);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 42036, 42048);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 41979, 42063);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 42079, 42121);

                return f_10052_42086_42120(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 41900, 42132);

                bool
                f_10052_41983_42002_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 41983, 42002);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10052_42086_42120(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ConstructUnboundGenericType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 42086, 42120);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 41900, 42132);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 41900, 42132);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract bool HasCodeAnalysisEmbeddedAttribute { get; }

        internal static readonly Func<TypeWithAnnotations, bool> TypeWithAnnotationsIsNullFunction;

        internal static readonly Func<TypeWithAnnotations, bool> TypeWithAnnotationsIsErrorType;

        private NamedTypeSymbol ConstructWithoutModifiers(ImmutableArray<TypeSymbol> typeArguments, bool unbound)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 42632, 43195);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 42762, 42816);

                ImmutableArray<TypeWithAnnotations>
                modifiedArguments
                = default(ImmutableArray<TypeWithAnnotations>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 42832, 43123) || true) && (typeArguments.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 42832, 43123);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 42893, 42958);

                    modifiedArguments = default(ImmutableArray<TypeWithAnnotations>);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 42832, 43123);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 42832, 43123);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 43024, 43108);

                    modifiedArguments = typeArguments.SelectAsArray(t => TypeWithAnnotations.Create(t));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 42832, 43123);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 43139, 43184);

                return f_10052_43146_43183(this, modifiedArguments, unbound);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 42632, 43195);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10052_43146_43183(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments, bool
                unbound)
                {
                    var return_v = this_param.Construct(typeArguments, unbound);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 43146, 43183);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 42632, 43195);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 42632, 43195);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal NamedTypeSymbol Construct(ImmutableArray<TypeWithAnnotations> typeArguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 43207, 43376);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 43317, 43365);

                return f_10052_43324_43364(this, typeArguments, unbound: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 43207, 43376);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10052_43324_43364(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments, bool
                unbound)
                {
                    var return_v = this_param.Construct(typeArguments, unbound: unbound);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 43324, 43364);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 43207, 43376);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 43207, 43376);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal NamedTypeSymbol Construct(ImmutableArray<TypeWithAnnotations> typeArguments, bool unbound)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 43388, 44775);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 43512, 43696) || true) && (!f_10052_43517_43555(this, f_10052_43539_43554()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 43512, 43696);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 43589, 43681);

                    throw f_10052_43595_43680(f_10052_43625_43679());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 43512, 43696);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 43712, 43871) || true) && (f_10052_43716_43726(this) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 43712, 43871);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 43765, 43856);

                    throw f_10052_43771_43855(f_10052_43801_43854());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 43712, 43871);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 43887, 44018) || true) && (typeArguments.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 43887, 44018);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 43948, 44003);

                    throw f_10052_43954_44002(nameof(typeArguments));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 43887, 44018);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 44034, 44232) || true) && (typeArguments.Any(TypeWithAnnotationsIsNullFunction))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 44034, 44232);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 44124, 44217);

                    throw f_10052_44130_44216(f_10052_44152_44192(), nameof(typeArguments));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 44034, 44232);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 44248, 44430) || true) && (typeArguments.Length != f_10052_44276_44286(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 44248, 44430);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 44320, 44415);

                    throw f_10052_44326_44414(f_10052_44348_44390(), nameof(typeArguments));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 44248, 44430);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 44446, 44522);

                f_10052_44446_44521(!unbound || (DynAbs.Tracing.TraceSender.Expression_False(10052, 44459, 44520) || typeArguments.All(TypeWithAnnotationsIsErrorType)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 44538, 44698) || true) && (f_10052_44542_44637(f_10052_44602_44621(this), typeArguments))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 44538, 44698);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 44671, 44683);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 44538, 44698);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 44714, 44764);

                return f_10052_44721_44763(this, typeArguments, unbound);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 43388, 44775);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10052_43539_43554()
                {
                    var return_v = ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 43539, 43554);
                    return return_v;
                }


                bool
                f_10052_43517_43555(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 43517, 43555);
                    return return_v;
                }


                string
                f_10052_43625_43679()
                {
                    var return_v = CSharpResources.CannotCreateConstructedFromConstructed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 43625, 43679);
                    return return_v;
                }


                System.InvalidOperationException
                f_10052_43595_43680(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 43595, 43680);
                    return return_v;
                }


                int
                f_10052_43716_43726(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 43716, 43726);
                    return return_v;
                }


                string
                f_10052_43801_43854()
                {
                    var return_v = CSharpResources.CannotCreateConstructedFromNongeneric;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 43801, 43854);
                    return return_v;
                }


                System.InvalidOperationException
                f_10052_43771_43855(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 43771, 43855);
                    return return_v;
                }


                System.ArgumentNullException
                f_10052_43954_44002(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 43954, 44002);
                    return return_v;
                }


                string
                f_10052_44152_44192()
                {
                    var return_v = CSharpResources.TypeArgumentCannotBeNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 44152, 44192);
                    return return_v;
                }


                System.ArgumentException
                f_10052_44130_44216(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 44130, 44216);
                    return return_v;
                }


                int
                f_10052_44276_44286(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 44276, 44286);
                    return return_v;
                }


                string
                f_10052_44348_44390()
                {
                    var return_v = CSharpResources.WrongNumberOfTypeArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 44348, 44390);
                    return return_v;
                }


                System.ArgumentException
                f_10052_44326_44414(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 44326, 44414);
                    return return_v;
                }


                int
                f_10052_44446_44521(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 44446, 44521);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10052_44602_44621(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 44602, 44621);
                    return return_v;
                }


                bool
                f_10052_44542_44637(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                typeParameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments)
                {
                    var return_v = ConstructedNamedTypeSymbol.TypeParametersMatchTypeArguments(typeParameters, typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 44542, 44637);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10052_44721_44763(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments, bool
                unbound)
                {
                    var return_v = this_param.ConstructCore(typeArguments, unbound);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 44721, 44763);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 43388, 44775);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 43388, 44775);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual NamedTypeSymbol ConstructCore(ImmutableArray<TypeWithAnnotations> typeArguments, bool unbound)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 44787, 45003);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 44924, 44992);

                return f_10052_44931_44991(this, typeArguments, unbound);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 44787, 45003);

                Microsoft.CodeAnalysis.CSharp.Symbols.ConstructedNamedTypeSymbol
                f_10052_44931_44991(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                constructedFrom, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArgumentsWithAnnotations, bool
                unbound)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ConstructedNamedTypeSymbol(constructedFrom, typeArgumentsWithAnnotations, unbound);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 44931, 44991);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 44787, 45003);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 44787, 45003);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool IsGenericType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 45188, 45580);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 45233, 45247);
                        for (var
        current = this
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 45224, 45532) || true) && (!f_10052_45250_45280(current, null))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 45282, 45314)
        , current = f_10052_45292_45314(current), DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 45224, 45532))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 45224, 45532);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 45356, 45513) || true) && (current.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics.Length != 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 45356, 45513);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 45478, 45490);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 45356, 45513);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10052, 1, 309);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10052, 1, 309);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 45552, 45565);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 45188, 45580);

                    bool
                    f_10052_45250_45280(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    objA, object?
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 45250, 45280);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10052_45292_45314(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 45292, 45314);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 45138, 45591);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 45138, 45591);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual bool IsUnboundGenericType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 46261, 46325);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 46297, 46310);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 46261, 46325);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 46196, 46336);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 46196, 46336);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal void GetAllTypeArguments(ArrayBuilder<TypeSymbol> builder, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 46423, 46942);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 46563, 46590);

                var
                outer = f_10052_46575_46589()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 46604, 46745) || true) && (!f_10052_46609_46637(outer, null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 46604, 46745);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 46671, 46730);

                    f_10052_46671_46729(outer, builder, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 46604, 46745);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 46761, 46931);
                    foreach (var argument in f_10052_46786_46855_I(f_10052_46786_46855(this, ref useSiteDiagnostics)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 46761, 46931);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 46889, 46916);

                        f_10052_46889_46915(builder, argument.Type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 46761, 46931);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10052, 1, 171);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10052, 1, 171);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 46423, 46942);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10052_46575_46589()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 46575, 46589);
                    return return_v;
                }


                bool
                f_10052_46609_46637(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                objA, object?
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 46609, 46637);
                    return return_v;
                }


                int
                f_10052_46671_46729(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                builder, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.GetAllTypeArguments(builder, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 46671, 46729);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10052_46786_46855(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.TypeArgumentsWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 46786, 46855);
                    return return_v;
                }


                int
                f_10052_46889_46915(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 46889, 46915);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10052_46786_46855_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 46786, 46855);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 46423, 46942);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 46423, 46942);
            }
        }

        internal ImmutableArray<TypeWithAnnotations> GetAllTypeArguments(ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 46954, 47311);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 47091, 47183);

                ArrayBuilder<TypeWithAnnotations>
                builder = f_10052_47135_47182()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 47197, 47250);

                f_10052_47197_47249(this, builder, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 47264, 47300);

                return f_10052_47271_47299(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 46954, 47311);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10052_47135_47182()
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 47135, 47182);
                    return return_v;
                }


                int
                f_10052_47197_47249(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                builder, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.GetAllTypeArguments(builder, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 47197, 47249);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10052_47271_47299(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 47271, 47299);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 46954, 47311);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 46954, 47311);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void GetAllTypeArguments(ArrayBuilder<TypeWithAnnotations> builder, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 47323, 47769);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 47472, 47499);

                var
                outer = f_10052_47484_47498()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 47513, 47654) || true) && (!f_10052_47518_47546(outer, null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 47513, 47654);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 47580, 47639);

                    f_10052_47580_47638(outer, builder, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 47513, 47654);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 47670, 47758);

                f_10052_47670_47757(
                            builder, f_10052_47687_47756(this, ref useSiteDiagnostics));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 47323, 47769);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10052_47484_47498()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 47484, 47498);
                    return return_v;
                }


                bool
                f_10052_47518_47546(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                objA, object?
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 47518, 47546);
                    return return_v;
                }


                int
                f_10052_47580_47638(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                builder, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.GetAllTypeArguments(builder, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 47580, 47638);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10052_47687_47756(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.TypeArgumentsWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 47687, 47756);
                    return return_v;
                }


                int
                f_10052_47670_47757(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 47670, 47757);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 47323, 47769);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 47323, 47769);
            }
        }

        internal void GetAllTypeArgumentsNoUseSiteDiagnostics(ArrayBuilder<TypeWithAnnotations> builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 47781, 48059);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 47902, 47967);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10052_47902_47916(), 10052, 47902, 47966)?.GetAllTypeArgumentsNoUseSiteDiagnostics(builder), 10052, 47917, 47966);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 47981, 48048);

                f_10052_47981_48047(builder, f_10052_47998_48046());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 47781, 48059);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10052_47902_47916()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 47902, 47916);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10052_47998_48046()
                {
                    var return_v = TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 47998, 48046);
                    return return_v;
                }


                int
                f_10052_47981_48047(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 47981, 48047);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 47781, 48059);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 47781, 48059);
            }
        }

        internal int AllTypeArgumentCount()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 48071, 48416);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 48131, 48199);

                int
                count = f_10052_48143_48191().Length
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 48215, 48242);

                var
                outer = f_10052_48227_48241()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 48256, 48376) || true) && (!f_10052_48261_48289(outer, null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 48256, 48376);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 48323, 48361);

                    count += f_10052_48332_48360(outer);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 48256, 48376);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 48392, 48405);

                return count;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 48071, 48416);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10052_48143_48191()
                {
                    var return_v = TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 48143, 48191);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10052_48227_48241()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 48227, 48241);
                    return return_v;
                }


                bool
                f_10052_48261_48289(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                objA, object?
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 48261, 48289);
                    return return_v;
                }


                int
                f_10052_48332_48360(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.AllTypeArgumentCount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 48332, 48360);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 48071, 48416);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 48071, 48416);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ImmutableArray<TypeWithAnnotations> GetTypeParametersAsTypeArguments()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 48428, 48622);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 48532, 48611);

                return f_10052_48539_48610(f_10052_48590_48609(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 48428, 48622);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10052_48590_48609(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 48590, 48609);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10052_48539_48610(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                typeParameters)
                {
                    var return_v = TypeMap.TypeParametersAsTypeSymbolsWithAnnotations(typeParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 48539, 48610);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 48428, 48622);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 48428, 48622);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public new virtual NamedTypeSymbol OriginalDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 48999, 49062);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 49035, 49047);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 48999, 49062);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 48921, 49073);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 48921, 49073);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected sealed override TypeSymbol OriginalTypeSymbolDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 49175, 49257);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 49211, 49242);

                    return f_10052_49218_49241(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 49175, 49257);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10052_49218_49241(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 49218, 49241);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 49085, 49268);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 49085, 49268);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual TypeMap TypeSubstitution
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 49600, 49620);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 49606, 49618);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 49600, 49620);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 49534, 49631);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 49534, 49631);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual NamedTypeSymbol AsMember(NamedTypeSymbol newOwner)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 49643, 50021);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 49735, 49767);

                f_10052_49735_49766(f_10052_49748_49765(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 49781, 49882);

                f_10052_49781_49881(f_10052_49794_49880(f_10052_49810_49837(newOwner), f_10052_49839_49879(f_10052_49839_49860(this))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 49896, 50010);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10052, 49903, 49924) || ((f_10052_49903_49924(newOwner) && DynAbs.Tracing.TraceSender.Conditional_F2(10052, 49927, 49931)) || DynAbs.Tracing.TraceSender.Conditional_F3(10052, 49934, 50009))) ? this : f_10052_49934_50009((SubstitutedNamedTypeSymbol)newOwner, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 49643, 50021);

                bool
                f_10052_49748_49765(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 49748, 49765);
                    return return_v;
                }


                int
                f_10052_49735_49766(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 49735, 49766);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10052_49810_49837(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 49810, 49837);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10052_49839_49860(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 49839, 49860);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10052_49839_49879(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 49839, 49879);
                    return return_v;
                }


                bool
                f_10052_49794_49880(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 49794, 49880);
                    return return_v;
                }


                int
                f_10052_49781_49881(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 49781, 49881);
                    return 0;
                }


                bool
                f_10052_49903_49924(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 49903, 49924);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNestedTypeSymbol
                f_10052_49934_50009(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newContainer, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                originalDefinition)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNestedTypeSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNamedTypeSymbol)newContainer, originalDefinition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 49934, 50009);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 49643, 50021);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 49643, 50021);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override DiagnosticInfo GetUseSiteDiagnostic()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 50073, 50618);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 50153, 50258) || true) && (f_10052_50157_50174(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 50153, 50258);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 50208, 50243);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetUseSiteDiagnostic(), 10052, 50215, 50242);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 50153, 50258);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 50274, 50303);

                DiagnosticInfo
                result = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 50369, 50577) || true) && (f_10052_50373_50441(this, ref result, f_10052_50417_50440(this)) || (DynAbs.Tracing.TraceSender.Expression_False(10052, 50373, 50514) || f_10052_50462_50514(this, ref result)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 50369, 50577);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 50548, 50562);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 50369, 50577);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 50593, 50607);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 50073, 50618);

                bool
                f_10052_50157_50174(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 50157, 50174);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10052_50417_50440(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 50417, 50440);
                    return return_v;
                }


                bool
                f_10052_50373_50441(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo?
                result, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = this_param.DeriveUseSiteDiagnosticFromType(ref result, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 50373, 50441);
                    return return_v;
                }


                bool
                f_10052_50462_50514(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo
                result)
                {
                    var return_v = this_param.DeriveUseSiteDiagnosticFromTypeArguments(ref result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 50462, 50514);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 50073, 50618);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 50073, 50618);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool DeriveUseSiteDiagnosticFromTypeArguments(ref DiagnosticInfo result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 50630, 51322);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 50735, 50770);

                NamedTypeSymbol
                currentType = this
                ;
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 50786, 51282);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 50821, 51149);
                                foreach (TypeWithAnnotations arg in f_10052_50857_50917_I(f_10052_50857_50917(currentType)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 50821, 51149);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 50959, 51130) || true) && (f_10052_50963_51045(this, ref result, arg, AllowedRequiredModifierType.None))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 50959, 51130);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 51095, 51107);

                                        return true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 50959, 51130);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 50821, 51149);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10052, 1, 329);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10052, 1, 329);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 51169, 51210);

                            currentType = f_10052_51183_51209(currentType);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 50786, 51282);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 50786, 51282) || true) && (f_10052_51246_51271_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(currentType, 10052, 51246, 51271)?.IsDefinition) == false)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10052, 50786, 51282);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10052, 50786, 51282);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 51298, 51311);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 50630, 51322);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10052_50857_50917(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 50857, 50917);
                    return return_v;
                }


                bool
                f_10052_50963_51045(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo
                result, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, Microsoft.CodeAnalysis.CSharp.Symbol.AllowedRequiredModifierType
                allowedRequiredModifierType)
                {
                    var return_v = this_param.DeriveUseSiteDiagnosticFromType(ref result, type, allowedRequiredModifierType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 50963, 51045);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10052_50857_50917_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 50857, 50917);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10052_51183_51209(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 51183, 51209);
                    return return_v;
                }


                bool?
                f_10052_51246_51271_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 51246, 51271);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 50630, 51322);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 50630, 51322);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal DiagnosticInfo CalculateUseSiteDiagnostic()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 51334, 52195);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 51411, 51440);

                DiagnosticInfo
                result = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 51489, 51626) || true) && (f_10052_51493_51563(this, ref result, f_10052_51529_51562(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 51489, 51626);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 51597, 51611);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 51489, 51626);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 51824, 52154) || true) && (f_10052_51828_51870(f_10052_51828_51849(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 51824, 52154);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 51904, 51955);

                    HashSet<TypeSymbol>
                    unificationCheckedTypes = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 51973, 52139) || true) && (f_10052_51977_52064(this, ref result, this, ref unificationCheckedTypes))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 51973, 52139);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 52106, 52120);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 51973, 52139);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 51824, 52154);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 52170, 52184);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 51334, 52195);

                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10052_51529_51562(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeriveUseSiteDiagnosticFromBase();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 51529, 51562);
                    return return_v;
                }


                bool
                f_10052_51493_51563(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo?
                result, Microsoft.CodeAnalysis.DiagnosticInfo
                info)
                {
                    var return_v = this_param.MergeUseSiteDiagnostics(ref result, info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 51493, 51563);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10052_51828_51849(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 51828, 51849);
                    return return_v;
                }


                bool
                f_10052_51828_51870(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.HasUnifiedReferences;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 51828, 51870);
                    return return_v;
                }


                bool
                f_10052_51977_52064(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo
                result, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                owner, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                checkedTypes)
                {
                    var return_v = this_param.GetUnificationUseSiteDiagnosticRecursive(ref result, (Microsoft.CodeAnalysis.CSharp.Symbol)owner, ref checkedTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 51977, 52064);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 51334, 52195);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 51334, 52195);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private DiagnosticInfo DeriveUseSiteDiagnosticFromBase()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 52207, 52712);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 52288, 52346);

                NamedTypeSymbol
                @base = f_10052_52312_52345(this)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 52362, 52673) || true) && ((object)@base != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 52362, 52673);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 52424, 52595) || true) && (f_10052_52428_52447(@base) && (DynAbs.Tracing.TraceSender.Expression_True(10052, 52428, 52498) && @base is NoPiaIllegalGenericInstantiationSymbol))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 52424, 52595);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 52540, 52576);

                            return f_10052_52547_52575(@base);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 52424, 52595);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 52615, 52658);

                        @base = f_10052_52623_52657(@base);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 52362, 52673);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10052, 52362, 52673);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10052, 52362, 52673);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 52689, 52701);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 52207, 52712);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10052_52312_52345(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 52312, 52345);
                    return return_v;
                }


                bool
                f_10052_52428_52447(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 52428, 52447);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10052_52547_52575(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 52547, 52575);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10052_52623_52657(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 52623, 52657);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 52207, 52712);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 52207, 52712);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool GetUnificationUseSiteDiagnosticRecursive(ref DiagnosticInfo result, Symbol owner, ref HashSet<TypeSymbol> checkedTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 52724, 54319);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 52891, 53003) || true) && (!f_10052_52896_52941(this, ref checkedTypes))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 52891, 53003);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 52975, 52988);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 52891, 53003);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 53019, 53077);

                f_10052_53019_53076(f_10052_53032_53075(f_10052_53032_53054(owner)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 53091, 53228) || true) && (f_10052_53095_53167(f_10052_53095_53117(owner), ref result, this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 53091, 53228);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 53201, 53213);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 53091, 53228);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 53813, 53859);

                var
                @base = f_10052_53825_53858(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 53873, 54046) || true) && ((object)@base != null && (DynAbs.Tracing.TraceSender.Expression_True(10052, 53877, 53985) && f_10052_53902_53985(@base, ref result, owner, ref checkedTypes)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 53873, 54046);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 54019, 54031);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 53873, 54046);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 54062, 54308);

                return f_10052_54069_54185(ref result, f_10052_54122_54159(this), owner, ref checkedTypes) || (DynAbs.Tracing.TraceSender.Expression_False(10052, 54069, 54307) || f_10052_54209_54307(ref result, f_10052_54262_54281(this), owner, ref checkedTypes));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 52724, 54319);

                bool
                f_10052_52896_52941(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                checkedTypes)
                {
                    var return_v = type.MarkCheckedIfNecessary(ref checkedTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 52896, 52941);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10052_53032_53054(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 53032, 53054);
                    return return_v;
                }


                bool
                f_10052_53032_53075(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.HasUnifiedReferences;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 53032, 53075);
                    return return_v;
                }


                int
                f_10052_53019_53076(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 53019, 53076);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10052_53095_53117(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 53095, 53117);
                    return return_v;
                }


                bool
                f_10052_53095_53167(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo
                result, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                dependentType)
                {
                    var return_v = this_param.GetUnificationUseSiteDiagnostic(ref result, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)dependentType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 53095, 53167);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10052_53825_53858(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 53825, 53858);
                    return return_v;
                }


                bool
                f_10052_53902_53985(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo
                result, Microsoft.CodeAnalysis.CSharp.Symbol
                owner, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                checkedTypes)
                {
                    var return_v = this_param.GetUnificationUseSiteDiagnosticRecursive(ref result, owner, ref checkedTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 53902, 53985);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10052_54122_54159(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.InterfacesNoUseSiteDiagnostics();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 54122, 54159);
                    return return_v;
                }


                bool
                f_10052_54069_54185(ref Microsoft.CodeAnalysis.DiagnosticInfo
                result, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                types, Microsoft.CodeAnalysis.CSharp.Symbol
                owner, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                checkedTypes)
                {
                    var return_v = GetUnificationUseSiteDiagnosticRecursive(ref result, types, owner, ref checkedTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 54069, 54185);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10052_54262_54281(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 54262, 54281);
                    return return_v;
                }


                bool
                f_10052_54209_54307(ref Microsoft.CodeAnalysis.DiagnosticInfo
                result, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                typeParameters, Microsoft.CodeAnalysis.CSharp.Symbol
                owner, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                checkedTypes)
                {
                    var return_v = GetUnificationUseSiteDiagnosticRecursive(ref result, typeParameters, owner, ref checkedTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 54209, 54307);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 52724, 54319);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 52724, 54319);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual bool IsDirectlyExcludedFromCodeCoverage
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 54664, 54672);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 54667, 54672);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 54664, 54672);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 54601, 54675);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 54601, 54675);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract bool HasSpecialName { get; }

        internal abstract bool IsComImport { get; }

        internal abstract bool IsWindowsRuntimeImport { get; }

        internal abstract bool ShouldAddWinRTMembers { get; }

        internal bool IsConditional
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 56559, 56955);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 56595, 56713) || true) && (f_10052_56599_56634(this).Any())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 56595, 56713);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 56682, 56694);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 56595, 56713);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 56808, 56857);

                    var
                    baseType = f_10052_56823_56856(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 56875, 56940);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10052, 56882, 56906) || (((object)baseType != null && DynAbs.Tracing.TraceSender.Conditional_F2(10052, 56909, 56931)) || DynAbs.Tracing.TraceSender.Conditional_F3(10052, 56934, 56939))) ? f_10052_56909_56931(baseType) : false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 56559, 56955);

                    System.Collections.Immutable.ImmutableArray<string>
                    f_10052_56599_56634(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetAppliedConditionalSymbols();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 56599, 56634);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10052_56823_56856(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 56823, 56856);
                        return return_v;
                    }


                    bool
                    f_10052_56909_56931(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsConditional;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 56909, 56931);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 56507, 56966);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 56507, 56966);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract bool IsSerializable { get; }

        public abstract bool AreLocalsZeroed { get; }

        internal abstract TypeLayout Layout { get; }

        protected CharSet DefaultMarshallingCharSet
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 57789, 57908);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 57825, 57893);

                    return f_10052_57832_57876(this) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Runtime.InteropServices.CharSet?>(10052, 57832, 57892) ?? CharSet.Ansi);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 57789, 57908);

                    System.Runtime.InteropServices.CharSet?
                    f_10052_57832_57876(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetEffectiveDefaultMarshallingCharSet();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 57832, 57876);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 57721, 57919);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 57721, 57919);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract CharSet MarshallingCharSet { get; }

        internal abstract bool HasDeclarativeSecurity { get; }

        internal abstract IEnumerable<Cci.SecurityAttribute> GetSecurityInformation();

        internal abstract ImmutableArray<string> GetAppliedConditionalSymbols();

        internal virtual NamedTypeSymbol ComImportCoClass
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 59992, 60055);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 60028, 60040);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 59992, 60055);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 59918, 60066);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 59918, 60066);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual FieldSymbol FixedElementField
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 60287, 60350);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 60323, 60335);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 60287, 60350);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 60216, 60361);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 60216, 60361);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract bool IsInterface { get; }

        internal bool IsTupleTypeOfCardinality(out int tupleCardinality)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 61257, 63278);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 61432, 63203) || true) && (f_10052_61436_61457_M(!IsUnboundGenericType) && (DynAbs.Tracing.TraceSender.Expression_True(10052, 61436, 61524) && f_10052_61478_61500_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10052_61478_61494(), 10052, 61478, 61500)?.Kind) == SymbolKind.Namespace) && (DynAbs.Tracing.TraceSender.Expression_True(10052, 61436, 61611) && f_10052_61545_61603_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10052_61545_61584(f_10052_61545_61564()), 10052, 61545, 61603)?.IsGlobalNamespace) == true) && (DynAbs.Tracing.TraceSender.Expression_True(10052, 61436, 61658) && f_10052_61632_61636() == ValueTupleTypeName) && (DynAbs.Tracing.TraceSender.Expression_True(10052, 61436, 61735) && f_10052_61679_61703(f_10052_61679_61698()) == MetadataHelpers.SystemString))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 61432, 63203);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 61769, 61787);

                    int
                    arity = f_10052_61781_61786()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 61807, 63188) || true) && (arity >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(10052, 61811, 61855) && arity < ValueTupleRestPosition))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 61807, 63188);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 61897, 61922);

                        tupleCardinality = arity;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 61944, 61956);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 61807, 63188);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 61807, 63188);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 61998, 63188) || true) && (arity == ValueTupleRestPosition && (DynAbs.Tracing.TraceSender.Expression_True(10052, 62002, 62050) && f_10052_62037_62050_M(!IsDefinition)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 61998, 63188);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 62147, 62177);

                            TypeSymbol
                            typeToCheck = this
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 62199, 62223);

                            int
                            levelsOfNesting = 0
                            ;
                            {
                                try
                                {
                                    do

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 62247, 62651);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 62298, 62316);

                                        levelsOfNesting++;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 62342, 62469);

                                        typeToCheck = f_10052_62356_62435(((NamedTypeSymbol)typeToCheck))[ValueTupleRestPosition - 1].Type;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 62247, 62651);
                                    }
                                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 62247, 62651) || true) && (f_10052_62521_62620(f_10052_62528_62558(typeToCheck), f_10052_62560_62583(this), TypeCompareKind.ConsiderEverything) && (DynAbs.Tracing.TraceSender.Expression_True(10052, 62521, 62649) && f_10052_62624_62649_M(!typeToCheck.IsDefinition)))
                                    );
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10052, 62247, 62651);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10052, 62247, 62651);
                                }
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 62675, 62757);

                            arity = (DynAbs.Tracing.TraceSender.Conditional_F1(10052, 62683, 62713) || ((typeToCheck is NamedTypeSymbol && DynAbs.Tracing.TraceSender.Conditional_F2(10052, 62716, 62752)) || DynAbs.Tracing.TraceSender.Conditional_F3(10052, 62755, 62756))) ? f_10052_62716_62752(((NamedTypeSymbol)typeToCheck)) : 0;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 62781, 63169) || true) && (arity > 0 && (DynAbs.Tracing.TraceSender.Expression_True(10052, 62785, 62828) && arity < ValueTupleRestPosition) && (DynAbs.Tracing.TraceSender.Expression_True(10052, 62785, 62909) && f_10052_62832_62909(((NamedTypeSymbol)typeToCheck), out tupleCardinality)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10052, 62781, 63169);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 62959, 63015);

                                f_10052_62959_63014(tupleCardinality < ValueTupleRestPosition);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 63041, 63108);

                                tupleCardinality += (ValueTupleRestPosition - 1) * levelsOfNesting;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 63134, 63146);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 62781, 63169);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 61998, 63188);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 61807, 63188);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10052, 61432, 63203);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 63219, 63240);

                tupleCardinality = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 63254, 63267);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 61257, 63278);

                bool
                f_10052_61436_61457_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 61436, 61457);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10052_61478_61494()
                {
                    var return_v = ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 61478, 61494);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind?
                f_10052_61478_61500_M(Microsoft.CodeAnalysis.SymbolKind?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 61478, 61500);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10052_61545_61564()
                {
                    var return_v = ContainingNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 61545, 61564);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10052_61545_61584(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.ContainingNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 61545, 61584);
                    return return_v;
                }


                bool?
                f_10052_61545_61603_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 61545, 61603);
                    return return_v;
                }


                string
                f_10052_61632_61636()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 61632, 61636);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10052_61679_61698()
                {
                    var return_v = ContainingNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 61679, 61698);
                    return return_v;
                }


                string
                f_10052_61679_61703(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 61679, 61703);
                    return return_v;
                }


                int
                f_10052_61781_61786()
                {
                    var return_v = Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 61781, 61786);
                    return return_v;
                }


                bool
                f_10052_62037_62050_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 62037, 62050);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10052_62356_62435(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 62356, 62435);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10052_62528_62558(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 62528, 62558);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10052_62560_62583(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 62560, 62583);
                    return return_v;
                }


                bool
                f_10052_62521_62620(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = Equals(left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 62521, 62620);
                    return return_v;
                }


                bool
                f_10052_62624_62649_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 62624, 62649);
                    return return_v;
                }


                int
                f_10052_62716_62752(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 62716, 62752);
                    return return_v;
                }


                bool
                f_10052_62832_62909(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, out int
                tupleCardinality)
                {
                    var return_v = this_param.IsTupleTypeOfCardinality(out tupleCardinality);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 62832, 62909);
                    return return_v;
                }


                int
                f_10052_62959_63014(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 62959, 63014);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 61257, 63278);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 61257, 63278);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract NamedTypeSymbol AsNativeInteger();

        internal abstract NamedTypeSymbol NativeIntegerUnderlyingType { get; }

        protected override ISymbol CreateISymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 63983, 64141);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 64050, 64130);

                return f_10052_64057_64129(this, f_10052_64103_64128());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 63983, 64141);

                Microsoft.CodeAnalysis.NullableAnnotation
                f_10052_64103_64128()
                {
                    var return_v = DefaultNullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 64103, 64128);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.NonErrorNamedTypeSymbol
                f_10052_64057_64129(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                underlying, Microsoft.CodeAnalysis.NullableAnnotation
                nullableAnnotation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.NonErrorNamedTypeSymbol(underlying, nullableAnnotation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 64057, 64129);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 63983, 64141);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 63983, 64141);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override ITypeSymbol CreateITypeSymbol(CodeAnalysis.NullableAnnotation nullableAnnotation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 64153, 64438);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 64278, 64340);

                f_10052_64278_64339(nullableAnnotation != f_10052_64313_64338());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 64354, 64427);

                return f_10052_64361_64426(this, nullableAnnotation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 64153, 64438);

                Microsoft.CodeAnalysis.NullableAnnotation
                f_10052_64313_64338()
                {
                    var return_v = DefaultNullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 64313, 64338);
                    return return_v;
                }


                int
                f_10052_64278_64339(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 64278, 64339);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.NonErrorNamedTypeSymbol
                f_10052_64361_64426(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                underlying, Microsoft.CodeAnalysis.NullableAnnotation
                nullableAnnotation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.NonErrorNamedTypeSymbol(underlying, nullableAnnotation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10052, 64361, 64426);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 64153, 64438);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 64153, 64438);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        INamedTypeSymbolInternal INamedTypeSymbolInternal.EnumUnderlyingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10052, 64543, 64625);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10052, 64579, 64610);

                    return f_10052_64586_64609(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10052, 64543, 64625);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10052_64586_64609(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.EnumUnderlyingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10052, 64586, 64609);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10052, 64450, 64636);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10052, 64450, 64636);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
    }
}
