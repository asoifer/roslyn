// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract partial class TypeParameterSymbol : TypeSymbol, ITypeParameterSymbolInternal
    {
        public new virtual TypeParameterSymbol OriginalDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 1103, 1166);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 1139, 1151);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 1103, 1166);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 1021, 1177);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 1021, 1177);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 1279, 1361);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 1315, 1346);

                    return f_10172_1322_1345(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 1279, 1361);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    f_10172_1322_1345(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10172, 1322, 1345);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 1189, 1372);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 1189, 1372);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual TypeParameterSymbol ReducedFrom
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 1693, 1756);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 1729, 1741);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 1693, 1756);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 1622, 1767);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 1622, 1767);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract int Ordinal
        {            // This is needed to determine hiding in C#: 
            //
            // interface IB { void M<T>(C<T> x); }
            // interface ID : IB { new void M<U>(C<U> x); }
            //
            // ID.M<U> hides IB.M<T> even though their formal parameters have different
            // types. When comparing formal parameter types for hiding purposes we must
            // compare method type parameters by ordinal, not by identity.
            get;
        }

        internal virtual DiagnosticInfo GetConstraintsUseSiteErrorInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 2516, 2628);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 2605, 2617);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 2516, 2628);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 2516, 2628);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 2516, 2628);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ImmutableArray<TypeWithAnnotations> ConstraintTypesNoUseSiteDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 3049, 3225);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 3085, 3124);

                    f_10172_3085_3123(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 3142, 3210);

                    return f_10172_3149_3209(this, ConsList<TypeParameterSymbol>.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 3049, 3225);

                    int
                    f_10172_3085_3123(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        this_param.EnsureAllConstraintsAreResolved();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 3085, 3123);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10172_3149_3209(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    inProgress)
                    {
                        var return_v = this_param.GetConstraintTypes(inProgress);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 3149, 3209);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 2944, 3236);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 2944, 3236);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ImmutableArray<TypeWithAnnotations> ConstraintTypesWithDefinitionUseSiteDiagnostics(ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 3248, 3770);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 3413, 3462);

                var
                result = f_10172_3426_3461()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 3478, 3536);

                f_10172_3478_3535(this, ref useSiteDiagnostics);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 3552, 3729);
                    foreach (var constraint in f_10172_3579_3585_I(result))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10172, 3552, 3729);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 3619, 3714);

                        f_10172_3619_3713(((TypeSymbol)f_10172_3632_3666(constraint.Type)), ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10172, 3552, 3729);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10172, 1, 178);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10172, 1, 178);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 3745, 3759);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 3248, 3770);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10172_3426_3461()
                {
                    var return_v = ConstraintTypesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10172, 3426, 3461);
                    return return_v;
                }


                int
                f_10172_3478_3535(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.AppendConstraintsUseSiteErrorInfo(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 3478, 3535);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10172_3632_3666(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10172, 3632, 3666);
                    return return_v;
                }


                int
                f_10172_3619_3713(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    type.AddUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 3619, 3713);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10172_3579_3585_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 3579, 3585);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 3248, 3770);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 3248, 3770);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void AppendConstraintsUseSiteErrorInfo(ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 3782, 4267);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 3901, 3966);

                DiagnosticInfo
                errorInfo = f_10172_3928_3965(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 3982, 4256) || true) && ((object)errorInfo != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10172, 3982, 4256);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 4045, 4187) || true) && (useSiteDiagnostics == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10172, 4045, 4187);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 4117, 4168);

                        useSiteDiagnostics = f_10172_4138_4167();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10172, 4045, 4187);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 4207, 4241);

                    f_10172_4207_4240(
                                    useSiteDiagnostics, errorInfo);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10172, 3982, 4256);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 3782, 4267);

                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10172_3928_3965(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.GetConstraintsUseSiteErrorInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 3928, 3965);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                f_10172_4138_4167()
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 4138, 4167);
                    return return_v;
                }


                bool
                f_10172_4207_4240(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                this_param, Microsoft.CodeAnalysis.DiagnosticInfo
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 4207, 4240);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 3782, 4267);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 3782, 4267);
            }
        }

        public abstract bool HasConstructorConstraint { get; }

        public abstract TypeParameterKind TypeParameterKind { get; }

        public MethodSymbol DeclaringMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 4847, 4943);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 4883, 4928);

                    return f_10172_4890_4911(this) as MethodSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 4847, 4943);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10172_4890_4911(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10172, 4890, 4911);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 4787, 4954);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 4787, 4954);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public NamedTypeSymbol DeclaringType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 5140, 5239);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 5176, 5224);

                    return f_10172_5183_5204(this) as NamedTypeSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 5140, 5239);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10172_5183_5204(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10172, 5183, 5204);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 5079, 5250);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 5079, 5250);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<Symbol> GetMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 5310, 5440);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 5393, 5429);

                return ImmutableArray<Symbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 5310, 5440);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 5310, 5440);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 5310, 5440);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override ImmutableArray<Symbol> GetMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 5500, 5641);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 5594, 5630);

                return ImmutableArray<Symbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 5500, 5641);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 5500, 5641);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 5500, 5641);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override ImmutableArray<NamedTypeSymbol> GetTypeMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 5701, 5853);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 5797, 5842);

                return ImmutableArray<NamedTypeSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 5701, 5853);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 5701, 5853);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 5701, 5853);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override ImmutableArray<NamedTypeSymbol> GetTypeMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 5913, 6076);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 6020, 6065);

                return ImmutableArray<NamedTypeSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 5913, 6076);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 5913, 6076);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 5913, 6076);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override ImmutableArray<NamedTypeSymbol> GetTypeMembers(string name, int arity)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 6136, 6310);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 6254, 6299);

                return ImmutableArray<NamedTypeSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 6136, 6310);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 6136, 6310);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 6136, 6310);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override TResult Accept<TArgument, TResult>(CSharpSymbolVisitor<TArgument, TResult> visitor, TArgument argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 6322, 6529);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 6468, 6518);

                return f_10172_6475_6517<TResult, TArgument>(visitor, this, argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 6322, 6529);

                TResult
                f_10172_6475_6517<TResult, TArgument>(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TArgument, TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                symbol, TArgument
                argument)
                {
                    var return_v = this_param.VisitTypeParameter(symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 6475, 6517);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 6322, 6529);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 6322, 6529);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void Accept(CSharpSymbolVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 6541, 6666);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 6622, 6655);

                f_10172_6622_6654(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 6541, 6666);

                int
                f_10172_6622_6654(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                symbol)
                {
                    this_param.VisitTypeParameter(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 6622, 6654);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 6541, 6666);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 6541, 6666);
            }
        }

        public override TResult Accept<TResult>(CSharpSymbolVisitor<TResult> visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 6678, 6831);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 6780, 6820);

                return f_10172_6787_6819<TResult>(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 6678, 6831);

                TResult
                f_10172_6787_6819<TResult>(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                symbol)
                {
                    var return_v = this_param.VisitTypeParameter(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 6787, 6819);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 6678, 6831);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 6678, 6831);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override SymbolKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 6906, 6989);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 6942, 6974);

                    return SymbolKind.TypeParameter;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 6906, 6989);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 6843, 7000);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 6843, 7000);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override TypeKind TypeKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 7077, 7158);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 7113, 7143);

                    return TypeKind.TypeParameter;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 7077, 7158);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 7012, 7169);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 7012, 7169);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal TypeParameterSymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10172, 7244, 7296);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10216, 12188, 12200);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10172, 7244, 7296);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 7244, 7296);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 7244, 7296);
            }
        }

        public sealed override Accessibility DeclaredAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 7391, 7477);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 7427, 7462);

                    return Accessibility.NotApplicable;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 7391, 7477);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 7308, 7488);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 7308, 7488);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsStatic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 7561, 7625);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 7597, 7610);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 7561, 7625);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 7500, 7636);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 7500, 7636);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsAbstract
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 7711, 7775);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 7747, 7760);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 7711, 7775);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 7648, 7786);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 7648, 7786);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsSealed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 7859, 7923);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 7895, 7908);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 7859, 7923);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 7798, 7934);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 7798, 7934);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override NamedTypeSymbol BaseTypeNoUseSiteDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 8016, 8023);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 8019, 8023);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 8016, 8023);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 8016, 8023);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 8016, 8023);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override ImmutableArray<NamedTypeSymbol> InterfacesNoUseSiteDiagnostics(ConsList<TypeSymbol> basesBeingResolved = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 8036, 8252);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 8196, 8241);

                return ImmutableArray<NamedTypeSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 8036, 8252);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 8036, 8252);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 8036, 8252);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override ImmutableArray<NamedTypeSymbol> GetAllInterfaces()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 8264, 8414);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 8358, 8403);

                return ImmutableArray<NamedTypeSymbol>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 8264, 8414);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 8264, 8414);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 8264, 8414);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal NamedTypeSymbol EffectiveBaseClassNoUseSiteDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 8958, 9137);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 8994, 9033);

                    f_10172_8994_9032(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 9051, 9122);

                    return f_10172_9058_9121(this, ConsList<TypeParameterSymbol>.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 8958, 9137);

                    int
                    f_10172_8994_9032(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        this_param.EnsureAllConstraintsAreResolved();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 8994, 9032);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10172_9058_9121(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    inProgress)
                    {
                        var return_v = this_param.GetEffectiveBaseClass(inProgress);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 9058, 9121);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 8870, 9148);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 8870, 9148);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal NamedTypeSymbol EffectiveBaseClass(ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 9160, 9604);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 9276, 9334);

                f_10172_9276_9333(this, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 9348, 9400);

                var
                result = f_10172_9361_9399()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 9416, 9563) || true) && ((object)result != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10172, 9416, 9563);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 9476, 9548);

                    f_10172_9476_9547(f_10172_9476_9501(result), ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10172, 9416, 9563);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 9579, 9593);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 9160, 9604);

                int
                f_10172_9276_9333(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.AppendConstraintsUseSiteErrorInfo(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 9276, 9333);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10172_9361_9399()
                {
                    var return_v = EffectiveBaseClassNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10172, 9361, 9399);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10172_9476_9501(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10172, 9476, 9501);
                    return return_v;
                }


                int
                f_10172_9476_9547(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    type.AddUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 9476, 9547);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 9160, 9604);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 9160, 9604);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ImmutableArray<NamedTypeSymbol> EffectiveInterfacesNoUseSiteDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 9824, 9995);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 9860, 9899);

                    f_10172_9860_9898(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 9917, 9980);

                    return f_10172_9924_9979(this, ConsList<TypeParameterSymbol>.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 9824, 9995);

                    int
                    f_10172_9860_9898(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        this_param.EnsureAllConstraintsAreResolved();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 9860, 9898);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    f_10172_9924_9979(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    inProgress)
                    {
                        var return_v = this_param.GetInterfaces(inProgress);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 9924, 9979);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 9719, 10006);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 9719, 10006);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal TypeSymbol DeducedBaseTypeNoUseSiteDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 10219, 10395);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 10255, 10294);

                    f_10172_10255_10293(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 10312, 10380);

                    return f_10172_10319_10379(this, ConsList<TypeParameterSymbol>.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 10219, 10395);

                    int
                    f_10172_10255_10293(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        this_param.EnsureAllConstraintsAreResolved();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 10255, 10293);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10172_10319_10379(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    inProgress)
                    {
                        var return_v = this_param.GetDeducedBaseType(inProgress);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 10319, 10379);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 10139, 10406);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 10139, 10406);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal TypeSymbol DeducedBaseType(ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 10418, 10865);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 10526, 10584);

                f_10172_10526_10583(this, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 10598, 10647);

                var
                result = f_10172_10611_10646()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 10663, 10824) || true) && ((object)result != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10172, 10663, 10824);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 10723, 10809);

                    f_10172_10723_10808(((TypeSymbol)f_10172_10736_10761(result)), ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10172, 10663, 10824);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 10840, 10854);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 10418, 10865);

                int
                f_10172_10526_10583(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.AppendConstraintsUseSiteErrorInfo(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 10526, 10583);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10172_10611_10646()
                {
                    var return_v = DeducedBaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10172, 10611, 10646);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10172_10736_10761(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10172, 10736, 10761);
                    return return_v;
                }


                int
                f_10172_10723_10808(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    type.AddUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 10723, 10808);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 10418, 10865);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 10418, 10865);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ImmutableArray<NamedTypeSymbol> AllEffectiveInterfacesNoUseSiteDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 11241, 11323);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 11277, 11308);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetAllInterfaces(), 10172, 11284, 11307);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 11241, 11323);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 11133, 11334);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 11133, 11334);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ImmutableArray<NamedTypeSymbol> AllEffectiveInterfacesWithDefinitionUseSiteDiagnostics(ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 11346, 12128);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 11514, 11570);

                var
                result = f_10172_11527_11569()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 11691, 11745);

                var
                current = f_10172_11705_11744(this, ref useSiteDiagnostics)
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 11761, 11923) || true) && ((object)current != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10172, 11761, 11923);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 11825, 11908);

                        current = f_10172_11835_11907(current, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10172, 11761, 11923);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10172, 11761, 11923);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10172, 11761, 11923);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 11939, 12087);
                    foreach (var iface in f_10172_11961_11967_I(result))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10172, 11939, 12087);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 12001, 12072);

                        f_10172_12001_12071(f_10172_12001_12025(iface), ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10172, 11939, 12087);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10172, 1, 149);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10172, 1, 149);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 12103, 12117);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 11346, 12128);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10172_11527_11569()
                {
                    var return_v = AllEffectiveInterfacesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10172, 11527, 11569);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10172_11705_11744(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.DeducedBaseType(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 11705, 11744);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10172_11835_11907(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.BaseTypeWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 11835, 11907);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10172_12001_12025(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10172, 12001, 12025);
                    return return_v;
                }


                int
                f_10172_12001_12071(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    type.AddUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 12001, 12071);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10172_11961_11967_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 11961, 11967);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 11346, 12128);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 11346, 12128);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract void EnsureAllConstraintsAreResolved();

        protected static void EnsureAllConstraintsAreResolved(ImmutableArray<TypeParameterSymbol> typeParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10172, 12800, 13195);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 12930, 13184);
                    foreach (var typeParameter in f_10172_12960_12974_I(typeParameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10172, 12930, 13184);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 13086, 13169);

                        var
                        unused = f_10172_13099_13168(typeParameter, ConsList<TypeParameterSymbol>.Empty)
                        ;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10172, 12930, 13184);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10172, 1, 255);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10172, 1, 255);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10172, 12800, 13195);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10172_13099_13168(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                inProgress)
                {
                    var return_v = this_param.GetConstraintTypes(inProgress);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 13099, 13168);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10172_12960_12974_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 12960, 12974);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 12800, 13195);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 12800, 13195);
            }
        }

        internal abstract ImmutableArray<TypeWithAnnotations> GetConstraintTypes(ConsList<TypeParameterSymbol> inProgress);

        internal abstract ImmutableArray<NamedTypeSymbol> GetInterfaces(ConsList<TypeParameterSymbol> inProgress);

        internal abstract NamedTypeSymbol GetEffectiveBaseClass(ConsList<TypeParameterSymbol> inProgress);

        internal abstract TypeSymbol GetDeducedBaseType(ConsList<TypeParameterSymbol> inProgress);

        private static bool ConstraintImpliesReferenceType(TypeSymbol constraint)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10172, 13664, 14029);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 13762, 13936) || true) && (f_10172_13766_13785(constraint) == TypeKind.TypeParameter)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10172, 13762, 13936);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 13845, 13921);

                    return f_10172_13852_13920(((TypeParameterSymbol)constraint));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10172, 13762, 13936);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 13952, 14018);

                return f_10172_13959_14017(constraint);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10172, 13664, 14029);

                Microsoft.CodeAnalysis.TypeKind
                f_10172_13766_13785(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10172, 13766, 13785);
                    return return_v;
                }


                bool
                f_10172_13852_13920(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceTypeFromConstraintTypes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10172, 13852, 13920);
                    return return_v;
                }


                bool
                f_10172_13959_14017(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                constraint)
                {
                    var return_v = NonTypeParameterConstraintImpliesReferenceType(constraint);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 13959, 14017);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 13664, 14029);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 13664, 14029);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool NonTypeParameterConstraintImpliesReferenceType(TypeSymbol constraint)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10172, 14041, 15024);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 14156, 14216);

                f_10172_14156_14215(f_10172_14169_14188(constraint) != TypeKind.TypeParameter);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 14232, 15013) || true) && (f_10172_14236_14263_M(!constraint.IsReferenceType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10172, 14232, 15013);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 14297, 14310);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10172, 14232, 15013);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10172, 14232, 15013);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 14376, 14643);

                    switch (f_10172_14384_14403(constraint))
                    {

                        case TypeKind.Interface:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10172, 14376, 14643);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 14495, 14508);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10172, 14376, 14643);

                        case TypeKind.Error:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10172, 14376, 14643);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 14611, 14624);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10172, 14376, 14643);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 14663, 14966);

                    switch (f_10172_14671_14693(constraint))
                    {

                        case SpecialType.System_Object:
                        case SpecialType.System_ValueType:
                        case SpecialType.System_Enum:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10172, 14663, 14966);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 14899, 14912);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10172, 14663, 14966);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 14986, 14998);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10172, 14232, 15013);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10172, 14041, 15024);

                Microsoft.CodeAnalysis.TypeKind
                f_10172_14169_14188(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10172, 14169, 14188);
                    return return_v;
                }


                int
                f_10172_14156_14215(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 14156, 14215);
                    return 0;
                }


                bool
                f_10172_14236_14263_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10172, 14236, 14263);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10172_14384_14403(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10172, 14384, 14403);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10172_14671_14693(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10172, 14671, 14693);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 14041, 15024);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 14041, 15024);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool CalculateIsReferenceTypeFromConstraintTypes(ImmutableArray<TypeWithAnnotations> constraintTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10172, 15459, 15862);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 15601, 15824);
                    foreach (var constraintType in f_10172_15632_15647_I(constraintTypes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10172, 15601, 15824);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 15681, 15809) || true) && (f_10172_15685_15736(constraintType.Type))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10172, 15681, 15809);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 15778, 15790);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10172, 15681, 15809);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10172, 15601, 15824);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10172, 1, 224);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10172, 1, 224);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 15838, 15851);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10172, 15459, 15862);

                bool
                f_10172_15685_15736(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                constraint)
                {
                    var return_v = ConstraintImpliesReferenceType(constraint);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 15685, 15736);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10172_15632_15647_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 15632, 15647);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 15459, 15862);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 15459, 15862);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool? IsNotNullableFromConstraintTypes(ImmutableArray<TypeWithAnnotations> constraintTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10172, 15874, 16558);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 16006, 16054);

                f_10172_16006_16053(f_10172_16019_16052_M(!constraintTypes.IsDefaultOrEmpty));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 16070, 16091);

                bool?
                result = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 16105, 16517);
                    foreach (TypeWithAnnotations constraintType in f_10172_16152_16167_I(constraintTypes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10172, 16105, 16517);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 16201, 16273);

                        bool?
                        fromType = f_10172_16218_16272(constraintType, out _)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 16291, 16502) || true) && (fromType == true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10172, 16291, 16502);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 16353, 16365);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10172, 16291, 16502);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10172, 16291, 16502);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 16407, 16502) || true) && (fromType == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10172, 16407, 16502);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 16469, 16483);

                                result = null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10172, 16407, 16502);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10172, 16291, 16502);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10172, 16105, 16517);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10172, 1, 413);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10172, 1, 413);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 16533, 16547);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10172, 15874, 16558);

                bool
                f_10172_16019_16052_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10172, 16019, 16052);
                    return return_v;
                }


                int
                f_10172_16006_16053(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 16006, 16053);
                    return 0;
                }


                bool?
                f_10172_16218_16272(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                constraintType, out bool
                isNonNullableValueType)
                {
                    var return_v = IsNotNullableFromConstraintType(constraintType, out isNonNullableValueType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 16218, 16272);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10172_16152_16167_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 16152, 16167);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 15874, 16558);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 15874, 16558);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool? IsNotNullableFromConstraintType(TypeWithAnnotations constraintType, out bool isNonNullableValueType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10172, 16570, 17655);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 16717, 16874) || true) && (f_10172_16721_16765(constraintType.Type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10172, 16717, 16874);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 16799, 16829);

                    isNonNullableValueType = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 16847, 16859);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10172, 16717, 16874);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 16890, 16921);

                isNonNullableValueType = false;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 16937, 17050) || true) && (f_10172_16941_16988(constraintType.NullableAnnotation))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10172, 16937, 17050);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 17022, 17035);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10172, 16937, 17050);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 17066, 17488) || true) && (constraintType.TypeKind == TypeKind.TypeParameter)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10172, 17066, 17488);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 17153, 17232);

                    bool?
                    isNotNullable = f_10172_17175_17231(((TypeParameterSymbol)constraintType.Type))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 17252, 17473) || true) && (isNotNullable == false)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10172, 17252, 17473);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 17320, 17333);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10172, 17252, 17473);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10172, 17252, 17473);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 17375, 17473) || true) && (isNotNullable == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10172, 17375, 17473);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 17442, 17454);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10172, 17375, 17473);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10172, 17252, 17473);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10172, 17066, 17488);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 17504, 17616) || true) && (f_10172_17508_17555(constraintType.NullableAnnotation))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10172, 17504, 17616);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 17589, 17601);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10172, 17504, 17616);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 17632, 17644);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10172, 16570, 17655);

                bool
                f_10172_16721_16765(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeArgument)
                {
                    var return_v = typeArgument.IsNonNullableValueType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 16721, 16765);
                    return return_v;
                }


                bool
                f_10172_16941_16988(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                annotation)
                {
                    var return_v = annotation.IsAnnotated();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 16941, 16988);
                    return return_v;
                }


                bool?
                f_10172_17175_17231(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsNotNullable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10172, 17175, 17231);
                    return return_v;
                }


                bool
                f_10172_17508_17555(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                annotation)
                {
                    var return_v = annotation.IsOblivious();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 17508, 17555);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 16570, 17655);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 16570, 17655);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool CalculateIsValueTypeFromConstraintTypes(ImmutableArray<TypeWithAnnotations> constraintTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10172, 17667, 18046);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 17805, 18008);
                    foreach (var constraintType in f_10172_17836_17851_I(constraintTypes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10172, 17805, 18008);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 17885, 17993) || true) && (f_10172_17889_17920(constraintType.Type))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10172, 17885, 17993);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 17962, 17974);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10172, 17885, 17993);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10172, 17805, 18008);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10172, 1, 204);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10172, 1, 204);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 18022, 18035);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10172, 17667, 18046);

                bool
                f_10172_17889_17920(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10172, 17889, 17920);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10172_17836_17851_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 17836, 17851);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 17667, 18046);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 17667, 18046);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override bool IsReferenceType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 18126, 18347);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 18162, 18270) || true) && (f_10172_18166_18197(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10172, 18162, 18270);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 18239, 18251);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10172, 18162, 18270);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 18290, 18332);

                    return f_10172_18297_18331();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 18126, 18347);

                    bool
                    f_10172_18166_18197(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.HasReferenceTypeConstraint;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10172, 18166, 18197);
                        return return_v;
                    }


                    bool
                    f_10172_18297_18331()
                    {
                        var return_v = IsReferenceTypeFromConstraintTypes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10172, 18297, 18331);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 18058, 18358);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 18058, 18358);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected bool? CalculateIsNotNullableFromNonTypeConstraints()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 18370, 18765);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 18457, 18578) || true) && (f_10172_18461_18486(this) || (DynAbs.Tracing.TraceSender.Expression_False(10172, 18461, 18517) || f_10172_18490_18517(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10172, 18457, 18578);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 18551, 18563);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10172, 18457, 18578);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 18594, 18725) || true) && (f_10172_18598_18629(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10172, 18594, 18725);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 18663, 18710);

                    return f_10172_18670_18709_M(!this.ReferenceTypeConstraintIsNullable);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10172, 18594, 18725);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 18741, 18754);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 18370, 18765);

                bool
                f_10172_18461_18486(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasNotNullConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10172, 18461, 18486);
                    return return_v;
                }


                bool
                f_10172_18490_18517(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasValueTypeConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10172, 18490, 18517);
                    return return_v;
                }


                bool
                f_10172_18598_18629(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.HasReferenceTypeConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10172, 18598, 18629);
                    return return_v;
                }


                bool?
                f_10172_18670_18709_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10172, 18670, 18709);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 18370, 18765);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 18370, 18765);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected bool? CalculateIsNotNullable()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 18777, 19648);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 18842, 18920);

                bool?
                fromNonTypeConstraints = f_10172_18873_18919(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 18936, 19049) || true) && (fromNonTypeConstraints == true)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10172, 18936, 19049);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 19004, 19034);

                    return fromNonTypeConstraints;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10172, 18936, 19049);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 19065, 19160);

                ImmutableArray<TypeWithAnnotations>
                constraintTypes = f_10172_19119_19159(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 19176, 19282) || true) && (constraintTypes.IsEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10172, 19176, 19282);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 19237, 19267);

                    return fromNonTypeConstraints;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10172, 19176, 19282);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 19298, 19366);

                bool?
                fromTypes = f_10172_19316_19365(constraintTypes)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 19382, 19504) || true) && (fromTypes == true || (DynAbs.Tracing.TraceSender.Expression_False(10172, 19386, 19438) || fromNonTypeConstraints == false))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10172, 19382, 19504);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 19472, 19489);

                    return fromTypes;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10172, 19382, 19504);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 19520, 19565);

                f_10172_19520_19564(fromNonTypeConstraints == null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 19579, 19611);

                f_10172_19579_19610(fromTypes != true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 19625, 19637);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 18777, 19648);

                bool?
                f_10172_18873_18919(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.CalculateIsNotNullableFromNonTypeConstraints();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 18873, 18919);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10172_19119_19159(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ConstraintTypesNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10172, 19119, 19159);
                    return return_v;
                }


                bool?
                f_10172_19316_19365(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                constraintTypes)
                {
                    var return_v = IsNotNullableFromConstraintTypes(constraintTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 19316, 19365);
                    return return_v;
                }


                int
                f_10172_19520_19564(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 19520, 19564);
                    return 0;
                }


                int
                f_10172_19579_19610(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 19579, 19610);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 18777, 19648);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 18777, 19648);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract bool? IsNotNullable { get; }

        public sealed override bool IsValueType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 19782, 19995);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 19818, 19922) || true) && (f_10172_19822_19849(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10172, 19818, 19922);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 19891, 19903);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10172, 19818, 19922);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 19942, 19980);

                    return f_10172_19949_19979();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 19782, 19995);

                    bool
                    f_10172_19822_19849(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.HasValueTypeConstraint;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10172, 19822, 19849);
                        return return_v;
                    }


                    bool
                    f_10172_19949_19979()
                    {
                        var return_v = IsValueTypeFromConstraintTypes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10172, 19949, 19979);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 19718, 20006);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 19718, 20006);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override ManagedKind GetManagedKind(ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 20018, 20233);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 20142, 20222);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10172, 20149, 20175) || ((f_10172_20149_20175() && DynAbs.Tracing.TraceSender.Conditional_F2(10172, 20178, 20199)) || DynAbs.Tracing.TraceSender.Conditional_F3(10172, 20202, 20221))) ? ManagedKind.Unmanaged : ManagedKind.Managed;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 20018, 20233);

                bool
                f_10172_20149_20175()
                {
                    var return_v = HasUnmanagedTypeConstraint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10172, 20149, 20175);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 20018, 20233);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 20018, 20233);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override bool IsRefLikeType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 20311, 20375);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 20347, 20360);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 20311, 20375);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 20245, 20386);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 20245, 20386);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 20461, 20693);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 20665, 20678);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 20461, 20693);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 20398, 20704);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 20398, 20704);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 20809, 20829);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 20815, 20827);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 20809, 20829);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 20716, 20840);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 20716, 20840);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract bool HasReferenceTypeConstraint { get; }

        public abstract bool IsReferenceTypeFromConstraintTypes { get; }

        internal abstract bool? ReferenceTypeConstraintIsNullable { get; }

        public abstract bool HasNotNullConstraint { get; }

        public abstract bool HasValueTypeConstraint { get; }

        public abstract bool IsValueTypeFromConstraintTypes { get; }

        public abstract bool HasUnmanagedTypeConstraint { get; }

        public abstract VarianceKind Variance { get; }

        internal sealed override bool GetUnificationUseSiteDiagnosticRecursive(ref DiagnosticInfo result, Symbol owner, ref HashSet<TypeSymbol> checkedTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 21855, 22053);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 22029, 22042);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 21855, 22053);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 21855, 22053);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 21855, 22053);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool Equals(TypeSymbol t2, TypeCompareKind comparison)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 22065, 22231);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 22162, 22220);

                return f_10172_22169_22219(this, t2 as TypeParameterSymbol, comparison);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 22065, 22231);

                bool
                f_10172_22169_22219(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                other, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol?)other, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 22169, 22219);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 22065, 22231);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 22065, 22231);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool Equals(TypeParameterSymbol other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 22243, 22383);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 22315, 22372);

                return f_10172_22322_22371(this, other, TypeCompareKind.ConsiderEverything);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 22243, 22383);

                bool
                f_10172_22322_22371(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                other, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = this_param.Equals(other, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 22322, 22371);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 22243, 22383);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 22243, 22383);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool Equals(TypeParameterSymbol other, TypeCompareKind comparison)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 22395, 22995);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 22494, 22587) || true) && (f_10172_22498_22526(this, other))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10172, 22494, 22587);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 22560, 22572);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10172, 22494, 22587);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 22603, 22761) || true) && ((object)other == null || (DynAbs.Tracing.TraceSender.Expression_False(10172, 22607, 22699) || !f_10172_22633_22699(f_10172_22649_22673(other), f_10172_22675_22698(this))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10172, 22603, 22761);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 22733, 22746);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10172, 22603, 22761);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 22882, 22984);

                return f_10172_22889_22983(f_10172_22889_22926(f_10172_22889_22911(other)), f_10172_22934_22970(f_10172_22934_22955(this)), comparison);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 22395, 22995);

                bool
                f_10172_22498_22526(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 22498, 22526);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                f_10172_22649_22673(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10172, 22649, 22673);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                f_10172_22675_22698(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10172, 22675, 22698);
                    return return_v;
                }


                bool
                f_10172_22633_22699(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 22633, 22699);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10172_22889_22911(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10172, 22889, 22911);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10172_22889_22926(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10172, 22889, 22926);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10172_22934_22955(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10172, 22934, 22955);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10172_22934_22970(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10172, 22934, 22970);
                    return return_v;
                }


                bool
                f_10172_22889_22983(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)t2, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 22889, 22983);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 22395, 22995);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 22395, 22995);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 23007, 23123);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 23065, 23112);

                return f_10172_23072_23111(f_10172_23085_23101(), f_10172_23103_23110());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 23007, 23123);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10172_23085_23101()
                {
                    var return_v = ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10172, 23085, 23101);
                    return return_v;
                }


                int
                f_10172_23103_23110()
                {
                    var return_v = Ordinal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10172, 23103, 23110);
                    return return_v;
                }


                int
                f_10172_23072_23111(Microsoft.CodeAnalysis.CSharp.Symbol
                newKeyPart, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKeyPart, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 23072, 23111);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 23007, 23123);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 23007, 23123);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void AddNullableTransforms(ArrayBuilder<byte> transforms)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 23135, 23232);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 23135, 23232);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 23135, 23232);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 23135, 23232);
            }
        }

        internal override bool ApplyNullableTransforms(byte defaultTransformFlag, ImmutableArray<byte> transforms, ref int position, out TypeSymbol result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 23244, 23467);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 23416, 23430);

                result = this;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 23444, 23456);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 23244, 23467);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 23244, 23467);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 23244, 23467);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override TypeSymbol SetNullabilityForReferenceTypes(Func<TypeWithAnnotations, TypeWithAnnotations> transform)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 23479, 23645);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 23622, 23634);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 23479, 23645);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 23479, 23645);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 23479, 23645);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override TypeSymbol MergeEquivalentTypes(TypeSymbol other, VarianceKind variance)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 23657, 23945);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 23772, 23908);

                f_10172_23772_23907(f_10172_23785_23906(this, other, TypeCompareKind.IgnoreDynamicAndTupleNames | TypeCompareKind.IgnoreNullableModifiersForReferenceTypes));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 23922, 23934);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 23657, 23945);

                bool
                f_10172_23785_23906(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = this_param.Equals(t2, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 23785, 23906);
                    return return_v;
                }


                int
                f_10172_23772_23907(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 23772, 23907);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 23657, 23945);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 23657, 23945);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected sealed override ISymbol CreateISymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 23957, 24118);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 24031, 24107);

                return f_10172_24038_24106(this, f_10172_24080_24105());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 23957, 24118);

                Microsoft.CodeAnalysis.NullableAnnotation
                f_10172_24080_24105()
                {
                    var return_v = DefaultNullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10172, 24080, 24105);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.TypeParameterSymbol
                f_10172_24038_24106(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                underlying, Microsoft.CodeAnalysis.NullableAnnotation
                nullableAnnotation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.TypeParameterSymbol(underlying, nullableAnnotation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 24038, 24106);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 23957, 24118);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 23957, 24118);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected sealed override ITypeSymbol CreateITypeSymbol(CodeAnalysis.NullableAnnotation nullableAnnotation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 24130, 24418);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 24262, 24324);

                f_10172_24262_24323(nullableAnnotation != f_10172_24297_24322());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 24338, 24407);

                return f_10172_24345_24406(this, nullableAnnotation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 24130, 24418);

                Microsoft.CodeAnalysis.NullableAnnotation
                f_10172_24297_24322()
                {
                    var return_v = DefaultNullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10172, 24297, 24322);
                    return return_v;
                }


                int
                f_10172_24262_24323(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 24262, 24323);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.TypeParameterSymbol
                f_10172_24345_24406(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                underlying, Microsoft.CodeAnalysis.NullableAnnotation
                nullableAnnotation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.TypeParameterSymbol(underlying, nullableAnnotation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10172, 24345, 24406);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 24130, 24418);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 24130, 24418);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsRecord
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10172, 24462, 24470);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10172, 24465, 24470);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10172, 24462, 24470);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10172, 24462, 24470);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10172, 24462, 24470);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
    }
}
