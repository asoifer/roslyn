// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract partial class MethodSymbol : Symbol, IMethodSymbolInternal
    {
        internal const MethodSymbol
        None = null
        ;

        protected MethodSymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10119, 1285, 1331);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10194, 18623, 18635);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 36308, 36331);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10119, 1285, 1331);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 1285, 1331);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 1285, 1331);
            }
        }

        public new virtual MethodSymbol OriginalDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 1705, 1768);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 1741, 1753);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 1705, 1768);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 1630, 1779);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 1630, 1779);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected sealed override Symbol OriginalSymbolDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 1873, 1955);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 1909, 1940);

                    return f_10119_1916_1939(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 1873, 1955);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10119_1916_1939(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 1916, 1939);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 1791, 1966);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 1791, 1966);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract MethodKind MethodKind
        {
            get;
        }

        public abstract int Arity { get; }

        public virtual bool IsGenericMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 2813, 2887);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 2849, 2872);

                    return f_10119_2856_2866(this) != 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 2813, 2887);

                    int
                    f_10119_2856_2866(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 2856, 2866);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 2753, 2898);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 2753, 2898);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual bool RequiresInstanceReceiver
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 3178, 3190);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 3181, 3190);
                    return f_10119_3181_3190_M(!IsStatic); DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 3178, 3190);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 3178, 3190);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 3178, 3190);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual bool IsDirectlyExcludedFromCodeCoverage
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 3518, 3526);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 3521, 3526);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 3518, 3526);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 3455, 3529);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 3455, 3529);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual ImmutableArray<string> NotNullMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 3830, 3861);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 3833, 3861);
                    return ImmutableArray<string>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 3830, 3861);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 3830, 3861);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 3830, 3861);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual ImmutableArray<string> NotNullWhenTrueMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 3937, 3968);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 3940, 3968);
                    return ImmutableArray<string>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 3937, 3968);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 3937, 3968);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 3937, 3968);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual ImmutableArray<string> NotNullWhenFalseMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 4045, 4076);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 4048, 4076);
                    return ImmutableArray<string>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 4045, 4076);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 4045, 4076);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 4045, 4076);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract UnmanagedCallersOnlyAttributeData? GetUnmanagedCallersOnlyAttributeData(bool forceComplete);

        public abstract bool IsExtensionMethod { get; }

        internal abstract bool HasSpecialName { get; }

        internal abstract System.Reflection.MethodImplAttributes ImplementationAttributes { get; }

        internal abstract bool HasDeclarativeSecurity { get; }

        public abstract DllImportData? GetDllImportData();

        internal abstract IEnumerable<Microsoft.Cci.SecurityAttribute> GetSecurityInformation();

        internal abstract MarshalPseudoCustomAttributeData ReturnValueMarshallingInformation { get; }

        internal abstract bool RequiresSecurityObject { get; }

        public abstract bool HidesBaseMethodsByName { get; }

        public abstract bool IsVararg { get; }

        public virtual bool IsCheckedBuiltin
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 8252, 8316);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 8288, 8301);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 8252, 8316);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 8191, 8327);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 8191, 8327);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract bool ReturnsVoid { get; }

        public abstract bool IsAsync { get; }

        public bool ReturnsByRef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 8959, 9045);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 8995, 9030);

                    return f_10119_9002_9014(this) == RefKind.Ref;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 8959, 9045);

                    Microsoft.CodeAnalysis.RefKind
                    f_10119_9002_9014(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 9002, 9014);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 8910, 9056);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 8910, 9056);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool ReturnsByRefReadonly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 9245, 9399);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 9281, 9323);

                    f_10119_9281_9322(f_10119_9294_9306(this) != RefKind.Out);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 9341, 9384);

                    return f_10119_9348_9360(this) == RefKind.RefReadOnly;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 9245, 9399);

                    Microsoft.CodeAnalysis.RefKind
                    f_10119_9294_9306(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 9294, 9306);
                        return return_v;
                    }


                    int
                    f_10119_9281_9322(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 9281, 9322);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.RefKind
                    f_10119_9348_9360(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 9348, 9360);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 9188, 9410);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 9188, 9410);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract RefKind RefKind { get; }

        public abstract TypeWithAnnotations ReturnTypeWithAnnotations { get; }

        public TypeSymbol ReturnType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 9909, 9942);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 9912, 9942);
                    return f_10119_9912_9937().Type; DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 9909, 9942);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 9909, 9942);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 9909, 9942);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract FlowAnalysisAnnotations ReturnTypeFlowAnalysisAnnotations { get; }

        public abstract ImmutableHashSet<string> ReturnNotNullIfParameterNotNull { get; }

        public abstract FlowAnalysisAnnotations FlowAnalysisAnnotations { get; }

        public abstract ImmutableArray<TypeWithAnnotations> TypeArgumentsWithAnnotations { get; }

        public abstract ImmutableArray<TypeParameterSymbol> TypeParameters { get; }

        internal ImmutableArray<TypeWithAnnotations> GetTypeParametersAsTypeArguments()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 10995, 11184);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 11099, 11173);

                return f_10119_11106_11172(f_10119_11157_11171());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 10995, 11184);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10119_11157_11171()
                {
                    var return_v = TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 11157, 11171);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10119_11106_11172(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                typeParameters)
                {
                    var return_v = TypeMap.TypeParametersAsTypeSymbolsWithAnnotations(typeParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 11106, 11172);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 10995, 11184);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 10995, 11184);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ParameterSymbol ThisParameter
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 11389, 11668);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 11425, 11455);

                    ParameterSymbol
                    thisParameter
                    = default(ParameterSymbol);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 11473, 11614) || true) && (!f_10119_11478_11516(this, out thisParameter))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 11473, 11614);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 11558, 11595);

                        throw f_10119_11564_11594();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 11473, 11614);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 11632, 11653);

                    return thisParameter;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 11389, 11668);

                    bool
                    f_10119_11478_11516(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param, out Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    thisParameter)
                    {
                        var return_v = this_param.TryGetThisParameter(out thisParameter);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 11478, 11516);
                        return return_v;
                    }


                    System.Exception
                    f_10119_11564_11594()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 11564, 11594);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 11326, 11679);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 11326, 11679);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual bool TryGetThisParameter(out ParameterSymbol thisParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 12012, 12172);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 12113, 12134);

                thisParameter = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 12148, 12161);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 12012, 12172);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 12012, 12172);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 12012, 12172);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual int ParameterCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 12579, 12660);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 12615, 12645);

                    return this.Parameters.Length;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 12579, 12660);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 12519, 12671);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 12519, 12671);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract ImmutableArray<ParameterSymbol> Parameters { get; }

        public virtual MethodSymbol ConstructedFrom
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 13333, 13396);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 13369, 13381);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 13333, 13396);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 13265, 13407);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 13265, 13407);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual bool IsExplicitInterfaceImplementation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 13873, 13927);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 13879, 13925);

                    return f_10119_13886_13918().Any();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 13873, 13927);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    f_10119_13886_13918()
                    {
                        var return_v = ExplicitInterfaceImplementations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 13886, 13918);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 13793, 13938);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 13793, 13938);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract bool IsDeclaredReadOnly { get; }

        internal abstract bool IsInitOnly { get; }

        internal virtual bool IsEffectivelyReadOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 14675, 14761);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 14678, 14761);
                    return (f_10119_14679_14697() || (DynAbs.Tracing.TraceSender.Expression_False(10119, 14679, 14735) || f_10119_14701_14727_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10119_14701_14715(), 10119, 14701, 14727)?.IsReadOnly) == true)) && (DynAbs.Tracing.TraceSender.Expression_True(10119, 14678, 14761) && f_10119_14740_14761()); DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 14675, 14761);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 14675, 14761);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 14675, 14761);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected bool IsValidReadOnlyTarget
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 14811, 14911);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 14814, 14911);
                    return f_10119_14814_14823_M(!IsStatic) && (DynAbs.Tracing.TraceSender.Expression_True(10119, 14814, 14856) && f_10119_14827_14856(f_10119_14827_14841())) && (DynAbs.Tracing.TraceSender.Expression_True(10119, 14814, 14896) && f_10119_14860_14870() != MethodKind.Constructor) && (DynAbs.Tracing.TraceSender.Expression_True(10119, 14814, 14911) && f_10119_14900_14911_M(!IsInitOnly)); DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 14811, 14911);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 14811, 14911);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 14811, 14911);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract ImmutableArray<MethodSymbol> ExplicitInterfaceImplementations { get; }

        public abstract ImmutableArray<CustomModifier> RefCustomModifiers { get; }

        public virtual ImmutableArray<CSharpAttributeData> GetReturnTypeAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 15744, 16153);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 15845, 15893);

                f_10119_15845_15892(!(this is IAttributeTargetSymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 16093, 16142);

                return ImmutableArray<CSharpAttributeData>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 15744, 16153);

                int
                f_10119_15845_15892(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 15845, 15892);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 15744, 16153);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 15744, 16153);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public abstract Symbol AssociatedSymbol { get; }

        internal MethodSymbol GetLeastOverriddenMethod(NamedTypeSymbol accessingTypeOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 17079, 17279);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 17184, 17268);

                return f_10119_17191_17267(this, accessingTypeOpt, requireSameReturnType: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 17079, 17279);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10119_17191_17267(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                accessingTypeOpt, bool
                requireSameReturnType)
                {
                    var return_v = this_param.GetLeastOverriddenMethodCore(accessingTypeOpt, requireSameReturnType: requireSameReturnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 17191, 17267);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 17079, 17279);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 17079, 17279);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private MethodSymbol GetLeastOverriddenMethodCore(NamedTypeSymbol accessingTypeOpt, bool requireSameReturnType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 17721, 19526);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 17857, 17913);

                accessingTypeOpt = f_10119_17876_17912_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(accessingTypeOpt, 10119, 17876, 17912)?.OriginalDefinition);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 17927, 17949);

                MethodSymbol
                m = this
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 17963, 19490) || true) && (f_10119_17970_17982(m) && (DynAbs.Tracing.TraceSender.Expression_True(10119, 17970, 18011) && f_10119_17986_18011_M(!m.HidesBaseMethodsByName)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 17963, 19490);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 18941, 18986);

                        MethodSymbol
                        overridden = f_10119_18967_18985(m)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 19004, 19054);

                        HashSet<DiagnosticInfo>
                        useSiteDiagnostics = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 19072, 19440) || true) && ((object)overridden == null || (DynAbs.Tracing.TraceSender.Expression_False(10119, 19076, 19241) || (accessingTypeOpt is { } && (DynAbs.Tracing.TraceSender.Expression_True(10119, 19128, 19240) && !f_10119_19156_19240(overridden, accessingTypeOpt, ref useSiteDiagnostics)))) || (DynAbs.Tracing.TraceSender.Expression_False(10119, 19076, 19373) || (requireSameReturnType && (DynAbs.Tracing.TraceSender.Expression_True(10119, 19267, 19372) && !f_10119_19293_19372(f_10119_19293_19308(this), f_10119_19316_19337(overridden), TypeCompareKind.AllIgnoreOptions)))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 19072, 19440);
                            DynAbs.Tracing.TraceSender.TraceBreak(10119, 19415, 19421);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 19072, 19440);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 19460, 19475);

                        m = overridden;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 17963, 19490);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10119, 17963, 19490);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10119, 17963, 19490);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 19506, 19515);

                return m;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 17721, 19526);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10119_17876_17912_M(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 17876, 17912);
                    return return_v;
                }


                bool
                f_10119_17970_17982(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 17970, 17982);
                    return return_v;
                }


                bool
                f_10119_17986_18011_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 17986, 18011);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10119_18967_18985(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OverriddenMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 18967, 18985);
                    return return_v;
                }


                bool
                f_10119_19156_19240(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                within, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = AccessCheck.IsSymbolAccessible((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, within, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 19156, 19240);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10119_19293_19308(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 19293, 19308);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10119_19316_19337(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 19316, 19337);
                    return return_v;
                }


                bool
                f_10119_19293_19372(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 19293, 19372);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 17721, 19526);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 17721, 19526);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal MethodSymbol GetConstructedLeastOverriddenMethod(NamedTypeSymbol accessingTypeOpt, bool requireSameReturnType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 20043, 20389);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 20187, 20286);

                var
                m = f_10119_20195_20285(f_10119_20195_20215(this), accessingTypeOpt, requireSameReturnType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 20300, 20378);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10119, 20307, 20324) || ((f_10119_20307_20324(m) && DynAbs.Tracing.TraceSender.Conditional_F2(10119, 20327, 20373)) || DynAbs.Tracing.TraceSender.Conditional_F3(10119, 20376, 20377))) ? f_10119_20327_20373(m, f_10119_20339_20372(this)) : m;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 20043, 20389);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10119_20195_20215(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 20195, 20215);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10119_20195_20285(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                accessingTypeOpt, bool
                requireSameReturnType)
                {
                    var return_v = this_param.GetLeastOverriddenMethodCore(accessingTypeOpt, requireSameReturnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 20195, 20285);
                    return return_v;
                }


                bool
                f_10119_20307_20324(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsGenericMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 20307, 20324);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10119_20339_20372(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 20339, 20372);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10119_20327_20373(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 20327, 20373);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 20043, 20389);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 20043, 20389);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public MethodSymbol OverriddenMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 21005, 21513);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 21041, 21466) || true) && (f_10119_21045_21060(this) && (DynAbs.Tracing.TraceSender.Expression_True(10119, 21045, 21107) && f_10119_21064_21107(f_10119_21080_21100(this), this)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 21041, 21466);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 21149, 21307) || true) && (f_10119_21153_21165())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 21149, 21307);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 21215, 21284);

                            return (MethodSymbol)f_10119_21236_21283(f_10119_21236_21261());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 21149, 21307);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 21331, 21447);

                        return (MethodSymbol)f_10119_21352_21446(this, f_10119_21410_21445(f_10119_21410_21428()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 21041, 21466);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 21486, 21498);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 21005, 21513);

                    bool
                    f_10119_21045_21060(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsOverride;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 21045, 21060);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10119_21080_21100(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ConstructedFrom;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 21080, 21100);
                        return return_v;
                    }


                    bool
                    f_10119_21064_21107(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    objA, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 21064, 21107);
                        return return_v;
                    }


                    bool
                    f_10119_21153_21165()
                    {
                        var return_v = IsDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 21153, 21165);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                    f_10119_21236_21261()
                    {
                        var return_v = OverriddenOrHiddenMembers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 21236, 21261);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10119_21236_21283(Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                    this_param)
                    {
                        var return_v = this_param.GetOverriddenMember();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 21236, 21283);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10119_21410_21428()
                    {
                        var return_v = OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 21410, 21428);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10119_21410_21445(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.OverriddenMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 21410, 21445);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10119_21352_21446(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    substitutedOverridingMember, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    overriddenByDefinitionMember)
                    {
                        var return_v = OverriddenOrHiddenMembersResult.GetOverriddenMember((Microsoft.CodeAnalysis.CSharp.Symbol)substitutedOverridingMember, (Microsoft.CodeAnalysis.CSharp.Symbol)overriddenByDefinitionMember);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 21352, 21446);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 20944, 21524);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 20944, 21524);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual bool CallsAreOmitted(SyntaxTree syntaxTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 21932, 22103);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 22017, 22092);

                return syntaxTree != null && (DynAbs.Tracing.TraceSender.Expression_True(10119, 22024, 22091) && f_10119_22046_22091(this, syntaxTree));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 21932, 22103);

                bool
                f_10119_22046_22091(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.CallsAreConditionallyOmitted(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 22046, 22091);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 21932, 22103);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 21932, 22103);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool CallsAreConditionallyOmitted(SyntaxTree syntaxTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 22594, 23547);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 22683, 23536) || true) && (f_10119_22687_22705(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 22683, 23536);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 22739, 22819);

                    ImmutableArray<string>
                    conditionalSymbols = f_10119_22783_22818(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 22837, 22878);

                    f_10119_22837_22877(conditionalSymbols != null);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 22896, 23035) || true) && (syntaxTree.IsAnyPreprocessorSymbolDefined(conditionalSymbols))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 22896, 23035);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 23003, 23016);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 22896, 23035);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 23055, 23410) || true) && (f_10119_23059_23074(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 23055, 23410);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 23116, 23161);

                        var
                        overriddenMethod = f_10119_23139_23160(this)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 23183, 23391) || true) && ((object)overriddenMethod != null && (DynAbs.Tracing.TraceSender.Expression_True(10119, 23187, 23253) && f_10119_23223_23253(overriddenMethod)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 23183, 23391);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 23303, 23368);

                            return f_10119_23310_23367(overriddenMethod, syntaxTree);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 23183, 23391);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 23055, 23410);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 23430, 23442);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 22683, 23536);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 22683, 23536);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 23508, 23521);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 22683, 23536);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 22594, 23547);

                bool
                f_10119_22687_22705(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsConditional;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 22687, 22705);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_10119_22783_22818(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetAppliedConditionalSymbols();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 22783, 22818);
                    return return_v;
                }


                int
                f_10119_22837_22877(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 22837, 22877);
                    return 0;
                }


                bool
                f_10119_23059_23074(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 23059, 23074);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10119_23139_23160(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OverriddenMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 23139, 23160);
                    return return_v;
                }


                bool
                f_10119_23223_23253(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsConditional;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 23223, 23253);
                    return return_v;
                }


                bool
                f_10119_23310_23367(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.CallsAreConditionallyOmitted(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 23310, 23367);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 22594, 23547);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 22594, 23547);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract ImmutableArray<string> GetAppliedConditionalSymbols();

        public bool IsConditional
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 24162, 24758);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 24198, 24316) || true) && (f_10119_24202_24237(this).Any())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 24198, 24316);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 24285, 24297);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 24198, 24316);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 24416, 24710) || true) && (f_10119_24420_24435(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 24416, 24710);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 24477, 24522);

                        var
                        overriddenMethod = f_10119_24500_24521(this)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 24544, 24691) || true) && ((object)overriddenMethod != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 24544, 24691);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 24630, 24668);

                            return f_10119_24637_24667(overriddenMethod);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 24544, 24691);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 24416, 24710);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 24730, 24743);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 24162, 24758);

                    System.Collections.Immutable.ImmutableArray<string>
                    f_10119_24202_24237(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.GetAppliedConditionalSymbols();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 24202, 24237);
                        return return_v;
                    }


                    bool
                    f_10119_24420_24435(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsOverride;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 24420, 24435);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10119_24500_24521(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.OverriddenMethod;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 24500, 24521);
                        return return_v;
                    }


                    bool
                    f_10119_24637_24667(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.IsConditional;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 24637, 24667);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 24112, 24769);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 24112, 24769);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static bool CanOverrideOrHide(MethodKind kind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10119, 24920, 25950);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 25000, 25939);

                switch (kind)
                {

                    case MethodKind.AnonymousFunction:
                    case MethodKind.Constructor:
                    case MethodKind.Destructor:
                    case MethodKind.ExplicitInterfaceImplementation:
                    case MethodKind.StaticConstructor:
                    case MethodKind.ReducedExtension:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 25000, 25939);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 25362, 25375);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 25000, 25939);

                    case MethodKind.Conversion:
                    case MethodKind.DelegateInvoke:
                    case MethodKind.EventAdd:
                    case MethodKind.EventRemove:
                    case MethodKind.LocalFunction:
                    case MethodKind.UserDefinedOperator:
                    case MethodKind.Ordinary:
                    case MethodKind.PropertyGet:
                    case MethodKind.PropertySet:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 25000, 25939);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 25817, 25829);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 25000, 25939);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 25000, 25939);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 25877, 25924);

                        throw f_10119_25883_25923(kind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 25000, 25939);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10119, 24920, 25950);

                System.Exception
                f_10119_25883_25923(Microsoft.CodeAnalysis.MethodKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 25883, 25923);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 24920, 25950);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 24920, 25950);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual OverriddenOrHiddenMembersResult OverriddenOrHiddenMembers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 26061, 26483);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 26424, 26468);

                    return f_10119_26431_26467(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 26061, 26483);

                    Microsoft.CodeAnalysis.CSharp.Symbols.OverriddenOrHiddenMembersResult
                    f_10119_26431_26467(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    member)
                    {
                        var return_v = member.MakeOverriddenOrHiddenMembers();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 26431, 26467);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 25962, 26494);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 25962, 26494);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override SymbolKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 26684, 26760);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 26720, 26745);

                    return SymbolKind.Method;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 26684, 26760);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 26621, 26771);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 26621, 26771);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsScriptConstructor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 26973, 27100);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 27009, 27085);

                    return f_10119_27016_27026() == MethodKind.Constructor && (DynAbs.Tracing.TraceSender.Expression_True(10119, 27016, 27084) && f_10119_27056_27084(f_10119_27056_27070()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 26973, 27100);

                    Microsoft.CodeAnalysis.MethodKind
                    f_10119_27016_27026()
                    {
                        var return_v = MethodKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 27016, 27026);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10119_27056_27070()
                    {
                        var return_v = ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 27056, 27070);
                        return return_v;
                    }


                    bool
                    f_10119_27056_27084(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsScriptClass;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 27056, 27084);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 26915, 27111);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 26915, 27111);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual bool IsScriptInitializer
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 27189, 27210);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 27195, 27208);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 27189, 27210);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 27123, 27221);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 27123, 27221);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsImplicitConstructor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 27419, 27588);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 27455, 27573);

                    return ((f_10119_27464_27474() == MethodKind.Constructor || (DynAbs.Tracing.TraceSender.Expression_False(10119, 27464, 27546) || f_10119_27504_27514() == MethodKind.StaticConstructor)) && (DynAbs.Tracing.TraceSender.Expression_True(10119, 27463, 27571) && f_10119_27551_27571()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 27419, 27588);

                    Microsoft.CodeAnalysis.MethodKind
                    f_10119_27464_27474()
                    {
                        var return_v = MethodKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 27464, 27474);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.MethodKind
                    f_10119_27504_27514()
                    {
                        var return_v = MethodKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 27504, 27514);
                        return return_v;
                    }


                    bool
                    f_10119_27551_27571()
                    {
                        var return_v = IsImplicitlyDeclared;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 27551, 27571);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 27359, 27599);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 27359, 27599);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsImplicitInstanceConstructor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 27794, 27913);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 27830, 27898);

                    return f_10119_27837_27847() == MethodKind.Constructor && (DynAbs.Tracing.TraceSender.Expression_True(10119, 27837, 27897) && f_10119_27877_27897());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 27794, 27913);

                    Microsoft.CodeAnalysis.MethodKind
                    f_10119_27837_27847()
                    {
                        var return_v = MethodKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 27837, 27847);
                        return return_v;
                    }


                    bool
                    f_10119_27877_27897()
                    {
                        var return_v = IsImplicitlyDeclared;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 27877, 27897);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 27726, 27924);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 27726, 27924);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsSubmissionConstructor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 28147, 28261);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 28183, 28246);

                    return f_10119_28190_28209() && (DynAbs.Tracing.TraceSender.Expression_True(10119, 28190, 28245) && f_10119_28213_28245(f_10119_28213_28231()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 28147, 28261);

                    bool
                    f_10119_28190_28209()
                    {
                        var return_v = IsScriptConstructor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 28190, 28209);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10119_28213_28231()
                    {
                        var return_v = ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 28213, 28231);
                        return return_v;
                    }


                    bool
                    f_10119_28213_28245(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.IsInteractive;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 28213, 28245);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 28085, 28272);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 28085, 28272);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsSubmissionInitializer
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 28346, 28460);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 28382, 28445);

                    return f_10119_28389_28408() && (DynAbs.Tracing.TraceSender.Expression_True(10119, 28389, 28444) && f_10119_28412_28444(f_10119_28412_28430()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 28346, 28460);

                    bool
                    f_10119_28389_28408()
                    {
                        var return_v = IsScriptInitializer;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 28389, 28408);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10119_28412_28430()
                    {
                        var return_v = ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 28412, 28430);
                        return return_v;
                    }


                    bool
                    f_10119_28412_28444(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.IsInteractive;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 28412, 28444);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 28284, 28471);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 28284, 28471);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsEntryPointCandidate
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 28741, 29048);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 28777, 28944) || true) && (f_10119_28781_28807(this) && (DynAbs.Tracing.TraceSender.Expression_True(10119, 28781, 28870) && f_10119_28832_28862(this) is null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 28777, 28944);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 28912, 28925);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 28777, 28944);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 28964, 29033);

                    return f_10119_28971_28979() && (DynAbs.Tracing.TraceSender.Expression_True(10119, 28971, 29032) && f_10119_28983_28987() == WellKnownMemberNames.EntryPointMethodName);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 28741, 29048);

                    bool
                    f_10119_28781_28807(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    member)
                    {
                        var return_v = member.IsPartialDefinition();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 28781, 28807);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    f_10119_28832_28862(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.PartialImplementationPart;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 28832, 28862);
                        return return_v;
                    }


                    bool
                    f_10119_28971_28979()
                    {
                        var return_v = IsStatic;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 28971, 28979);
                        return return_v;
                    }


                    string
                    f_10119_28983_28987()
                    {
                        var return_v = Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 28983, 28987);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 28681, 29059);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 28681, 29059);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override TResult Accept<TArgument, TResult>(CSharpSymbolVisitor<TArgument, TResult> visitor, TArgument argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 29071, 29271);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 29217, 29260);

                return f_10119_29224_29259<TResult, TArgument>(visitor, this, argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 29071, 29271);

                TResult
                f_10119_29224_29259<TResult, TArgument>(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TArgument, TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, TArgument
                argument)
                {
                    var return_v = this_param.VisitMethod(symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 29224, 29259);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 29071, 29271);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 29071, 29271);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void Accept(CSharpSymbolVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 29283, 29401);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 29364, 29390);

                f_10119_29364_29389(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 29283, 29401);

                int
                f_10119_29364_29389(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    this_param.VisitMethod(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 29364, 29389);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 29283, 29401);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 29283, 29401);
            }
        }

        public override TResult Accept<TResult>(CSharpSymbolVisitor<TResult> visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 29413, 29559);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 29515, 29548);

                return f_10119_29522_29547<TResult>(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 29413, 29559);

                TResult
                f_10119_29522_29547<TResult>(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = this_param.VisitMethod(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 29522, 29547);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 29413, 29559);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 29413, 29559);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public MethodSymbol ReduceExtensionMethod(TypeSymbol receiverType, CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 30040, 30554);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 30162, 30297) || true) && ((object)receiverType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 30162, 30297);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 30228, 30282);

                    throw f_10119_30234_30281(nameof(receiverType));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 30162, 30297);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 30313, 30451) || true) && (f_10119_30317_30340_M(!this.IsExtensionMethod) || (DynAbs.Tracing.TraceSender.Expression_False(10119, 30317, 30390) || f_10119_30344_30359(this) == MethodKind.ReducedExtension))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 30313, 30451);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 30424, 30436);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 30313, 30451);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 30467, 30543);

                return f_10119_30474_30542(this, receiverType, compilation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 30040, 30554);

                System.ArgumentNullException
                f_10119_30234_30281(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 30234, 30281);
                    return return_v;
                }


                bool
                f_10119_30317_30340_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 30317, 30340);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10119_30344_30359(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 30344, 30359);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10119_30474_30542(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                receiverType, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = ReducedExtensionMethodSymbol.Create(method, receiverType, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 30474, 30542);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 30040, 30554);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 30040, 30554);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public MethodSymbol ReduceExtensionMethod()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 30763, 30975);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 30831, 30964);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10119, 30838, 30912) || (((f_10119_30839_30861(this) && (DynAbs.Tracing.TraceSender.Expression_True(10119, 30839, 30911) && f_10119_30865_30880(this) != MethodKind.ReducedExtension)) && DynAbs.Tracing.TraceSender.Conditional_F2(10119, 30915, 30956)) || DynAbs.Tracing.TraceSender.Conditional_F3(10119, 30959, 30963))) ? f_10119_30915_30956(this) : null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 30763, 30975);

                bool
                f_10119_30839_30861(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsExtensionMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 30839, 30861);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10119_30865_30880(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 30865, 30880);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10119_30915_30956(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = ReducedExtensionMethodSymbol.Create(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 30915, 30956);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 30763, 30975);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 30763, 30975);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual MethodSymbol CallsiteReducedFromMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 31287, 31307);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 31293, 31305);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 31287, 31307);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 31207, 31318);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 31207, 31318);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual MethodSymbol PartialImplementationPart
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 31668, 31688);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 31674, 31686);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 31668, 31688);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 31590, 31699);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 31590, 31699);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual MethodSymbol PartialDefinitionPart
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 31976, 31996);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 31982, 31994);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 31976, 31996);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 31902, 32007);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 31902, 32007);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual MethodSymbol ReducedFrom
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 32299, 32319);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 32305, 32317);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 32299, 32319);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 32235, 32330);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 32235, 32330);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual TypeSymbol ReceiverType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 32554, 32632);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 32590, 32617);

                    return f_10119_32597_32616(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 32554, 32632);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10119_32597_32616(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 32597, 32616);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 32491, 32643);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 32491, 32643);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual TypeSymbol GetTypeInferredDuringReduction(TypeParameterSymbol reducedFromTypeParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 33478, 33654);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 33605, 33643);

                throw f_10119_33611_33642();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 33478, 33654);

                System.InvalidOperationException
                f_10119_33611_33642()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 33611, 33642);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 33478, 33654);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 33478, 33654);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public MethodSymbol Construct(params TypeSymbol[] typeArguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 33920, 34080);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 34009, 34069);

                return f_10119_34016_34068(this, f_10119_34031_34067(typeArguments));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 33920, 34080);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                f_10119_34031_34067(params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                items)
                {
                    var return_v = ImmutableArray.Create(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 34031, 34067);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10119_34016_34068(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 34016, 34068);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 33920, 34080);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 33920, 34080);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public MethodSymbol Construct(ImmutableArray<TypeSymbol> typeArguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 34466, 34655);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 34562, 34644);

                return f_10119_34569_34643(this, typeArguments.SelectAsArray(a => TypeWithAnnotations.Create(a)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 34466, 34655);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10119_34569_34643(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 34569, 34643);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 34466, 34655);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 34466, 34655);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal MethodSymbol Construct(ImmutableArray<TypeWithAnnotations> typeArguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 34667, 35757);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 34774, 34923) || true) && (!f_10119_34779_34817(this, f_10119_34801_34816()) || (DynAbs.Tracing.TraceSender.Expression_False(10119, 34778, 34836) || f_10119_34821_34831(this) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 34774, 34923);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 34870, 34908);

                    throw f_10119_34876_34907();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 34774, 34923);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 34939, 35070) || true) && (typeArguments.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 34939, 35070);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 35000, 35055);

                    throw f_10119_35006_35054(nameof(typeArguments));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 34939, 35070);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 35086, 35300) || true) && (typeArguments.Any(NamedTypeSymbol.TypeWithAnnotationsIsNullFunction))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 35086, 35300);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 35192, 35285);

                    throw f_10119_35198_35284(f_10119_35220_35260(), nameof(typeArguments));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 35086, 35300);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 35316, 35498) || true) && (typeArguments.Length != f_10119_35344_35354(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 35316, 35498);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 35388, 35483);

                    throw f_10119_35394_35482(f_10119_35416_35458(), nameof(typeArguments));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 35316, 35498);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 35514, 35674) || true) && (f_10119_35518_35613(f_10119_35578_35597(this), typeArguments))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 35514, 35674);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 35647, 35659);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 35514, 35674);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 35690, 35746);

                return f_10119_35697_35745(this, typeArguments);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 34667, 35757);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10119_34801_34816()
                {
                    var return_v = ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 34801, 34816);
                    return return_v;
                }


                bool
                f_10119_34779_34817(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 34779, 34817);
                    return return_v;
                }


                int
                f_10119_34821_34831(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 34821, 34831);
                    return return_v;
                }


                System.InvalidOperationException
                f_10119_34876_34907()
                {
                    var return_v = new System.InvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 34876, 34907);
                    return return_v;
                }


                System.ArgumentNullException
                f_10119_35006_35054(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 35006, 35054);
                    return return_v;
                }


                string
                f_10119_35220_35260()
                {
                    var return_v = CSharpResources.TypeArgumentCannotBeNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 35220, 35260);
                    return return_v;
                }


                System.ArgumentException
                f_10119_35198_35284(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 35198, 35284);
                    return return_v;
                }


                int
                f_10119_35344_35354(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 35344, 35354);
                    return return_v;
                }


                string
                f_10119_35416_35458()
                {
                    var return_v = CSharpResources.WrongNumberOfTypeArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 35416, 35458);
                    return return_v;
                }


                System.ArgumentException
                f_10119_35394_35482(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 35394, 35482);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10119_35578_35597(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 35578, 35597);
                    return return_v;
                }


                bool
                f_10119_35518_35613(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                typeParameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArguments)
                {
                    var return_v = ConstructedNamedTypeSymbol.TypeParametersMatchTypeArguments(typeParameters, typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 35518, 35613);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ConstructedMethodSymbol
                f_10119_35697_35745(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                constructedFrom, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                typeArgumentsWithAnnotations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ConstructedMethodSymbol(constructedFrom, typeArgumentsWithAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 35697, 35745);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 34667, 35757);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 34667, 35757);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal MethodSymbol AsMember(NamedTypeSymbol newOwner)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 35769, 36104);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 35850, 35882);

                f_10119_35850_35881(f_10119_35863_35880(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 35896, 35997);

                f_10119_35896_35996(f_10119_35909_35995(f_10119_35925_35952(newOwner), f_10119_35954_35994(f_10119_35954_35975(this))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 36011, 36093);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10119, 36018, 36039) || ((f_10119_36018_36039(newOwner) && DynAbs.Tracing.TraceSender.Conditional_F2(10119, 36042, 36046)) || DynAbs.Tracing.TraceSender.Conditional_F3(10119, 36049, 36092))) ? this : f_10119_36049_36092(newOwner, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 35769, 36104);

                bool
                f_10119_35863_35880(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 35863, 35880);
                    return return_v;
                }


                int
                f_10119_35850_35881(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 35850, 35881);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10119_35925_35952(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 35925, 35952);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10119_35954_35975(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 35954, 35975);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10119_35954_35994(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 35954, 35994);
                    return return_v;
                }


                bool
                f_10119_35909_35995(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 35909, 35995);
                    return return_v;
                }


                int
                f_10119_35896_35996(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 35896, 35996);
                    return 0;
                }


                bool
                f_10119_36018_36039(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 36018, 36039);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedMethodSymbol
                f_10119_36049_36092(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                originalDefinition)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedMethodSymbol(containingSymbol, originalDefinition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 36049, 36092);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 35769, 36104);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 35769, 36104);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ParameterSignature _lazyParameterSignature;

        internal ImmutableArray<TypeWithAnnotations> ParameterTypesWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 36441, 36663);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 36477, 36569);

                    f_10119_36477_36568(f_10119_36523_36538(this), ref _lazyParameterSignature);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 36587, 36648);

                    return _lazyParameterSignature.parameterTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 36441, 36663);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10119_36523_36538(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 36523, 36538);
                        return return_v;
                    }


                    int
                    f_10119_36477_36568(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    parameters, ref Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSignature
                    lazySignature)
                    {
                        ParameterSignature.PopulateParameterSignature(parameters, ref lazySignature);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 36477, 36568);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 36342, 36674);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 36342, 36674);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal TypeSymbol GetParameterType(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 36732, 36776);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 36735, 36776);
                return f_10119_36735_36764()[index].Type; DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 36732, 36776);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 36732, 36776);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 36732, 36776);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
            f_10119_36735_36764()
            {
                var return_v = ParameterTypesWithAnnotations;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 36735, 36764);
                return return_v;
            }

        }

        internal ImmutableArray<RefKind> ParameterRefKinds
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 36999, 37209);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 37035, 37127);

                    f_10119_37035_37126(f_10119_37081_37096(this), ref _lazyParameterSignature);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 37145, 37194);

                    return _lazyParameterSignature.parameterRefKinds;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 36999, 37209);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10119_37081_37096(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 37081, 37096);
                        return return_v;
                    }


                    int
                    f_10119_37035_37126(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    parameters, ref Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSignature
                    lazySignature)
                    {
                        ParameterSignature.PopulateParameterSignature(parameters, ref lazySignature);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 37035, 37126);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 36924, 37220);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 36924, 37220);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract Microsoft.Cci.CallingConvention CallingConvention
        {
            get;
        }

        internal virtual ImmutableArray<NamedTypeSymbol> UnmanagedCallingConventionTypes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 37432, 37472);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 37435, 37472);
                    return ImmutableArray<NamedTypeSymbol>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 37432, 37472);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 37432, 37472);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 37432, 37472);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 37809, 37829);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 37815, 37827);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 37809, 37829);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 37743, 37840);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 37743, 37840);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override DiagnosticInfo GetUseSiteDiagnostic()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 37892, 38291);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 37972, 38077) || true) && (f_10119_37976_37993(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 37972, 38077);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 38027, 38062);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetUseSiteDiagnostic(), 10119, 38034, 38061);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 37972, 38077);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 38226, 38280);

                return f_10119_38233_38279(f_10119_38233_38256(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 37892, 38291);

                bool
                f_10119_37976_37993(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 37976, 37993);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10119_38233_38256(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 38233, 38256);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10119_38233_38279(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 38233, 38279);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 37892, 38291);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 37892, 38291);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool CalculateUseSiteDiagnostic(ref DiagnosticInfo result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 38303, 40170);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 38395, 38427);

                f_10119_38395_38426(f_10119_38408_38425(this));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 38507, 39185) || true) && (f_10119_38511_38865(this, ref result, f_10119_38555_38585(this), (DynAbs.Tracing.TraceSender.Conditional_F1(10119, 38636, 38646) || ((f_10119_38636_38646() && DynAbs.Tracing.TraceSender.Conditional_F2(10119, 38702, 38776)) || DynAbs.Tracing.TraceSender.Conditional_F3(10119, 38832, 38864))) ? AllowedRequiredModifierType.System_Runtime_CompilerServices_IsExternalInit : AllowedRequiredModifierType.None) || (DynAbs.Tracing.TraceSender.Expression_False(10119, 38511, 39037) || f_10119_38886_39037(this, ref result, f_10119_38941_38964(this), AllowedRequiredModifierType.System_Runtime_InteropServices_InAttribute)) || (DynAbs.Tracing.TraceSender.Expression_False(10119, 38511, 39124) || f_10119_39058_39124(this, ref result, f_10119_39108_39123(this))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 38507, 39185);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 39158, 39170);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 38507, 39185);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 39361, 40130) || true) && (f_10119_39365_39408_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10119_39365_39386(this), 10119, 39365, 39408)?.HasUnifiedReferences) == true)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 39361, 40130);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 39450, 39501);

                    HashSet<TypeSymbol>
                    unificationCheckedTypes = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 39521, 40115) || true) && (this.ReturnTypeWithAnnotations.GetUnificationUseSiteDiagnosticRecursive(ref result, this, ref unificationCheckedTypes) || (DynAbs.Tracing.TraceSender.Expression_False(10119, 39525, 39780) || f_10119_39668_39780(ref result, f_10119_39721_39744(this), this, ref unificationCheckedTypes)) || (DynAbs.Tracing.TraceSender.Expression_False(10119, 39525, 39909) || f_10119_39805_39909(ref result, f_10119_39858_39873(this), this, ref unificationCheckedTypes)) || (DynAbs.Tracing.TraceSender.Expression_False(10119, 39525, 40042) || f_10119_39934_40042(ref result, f_10119_39987_40006(this), this, ref unificationCheckedTypes)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 39521, 40115);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 40084, 40096);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 39521, 40115);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 39361, 40130);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 40146, 40159);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 38303, 40170);

                bool
                f_10119_38408_38425(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 38408, 38425);
                    return return_v;
                }


                int
                f_10119_38395_38426(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 38395, 38426);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10119_38555_38585(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 38555, 38585);
                    return return_v;
                }


                bool
                f_10119_38636_38646()
                {
                    var return_v = IsInitOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 38636, 38646);
                    return return_v;
                }


                bool
                f_10119_38511_38865(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo
                result, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, Microsoft.CodeAnalysis.CSharp.Symbol.AllowedRequiredModifierType
                allowedRequiredModifierType)
                {
                    var return_v = this_param.DeriveUseSiteDiagnosticFromType(ref result, type, allowedRequiredModifierType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 38511, 38865);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10119_38941_38964(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RefCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 38941, 38964);
                    return return_v;
                }


                bool
                f_10119_38886_39037(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo
                result, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                customModifiers, Microsoft.CodeAnalysis.CSharp.Symbol.AllowedRequiredModifierType
                allowedRequiredModifierType)
                {
                    var return_v = this_param.DeriveUseSiteDiagnosticFromCustomModifiers(ref result, customModifiers, allowedRequiredModifierType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 38886, 39037);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10119_39108_39123(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 39108, 39123);
                    return return_v;
                }


                bool
                f_10119_39058_39124(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo
                result, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters)
                {
                    var return_v = this_param.DeriveUseSiteDiagnosticFromParameters(ref result, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 39058, 39124);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10119_39365_39386(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 39365, 39386);
                    return return_v;
                }


                bool?
                f_10119_39365_39408_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 39365, 39408);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                f_10119_39721_39744(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RefCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 39721, 39744);
                    return return_v;
                }


                bool
                f_10119_39668_39780(ref Microsoft.CodeAnalysis.DiagnosticInfo
                result, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                modifiers, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                owner, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                checkedTypes)
                {
                    var return_v = GetUnificationUseSiteDiagnosticRecursive(ref result, modifiers, (Microsoft.CodeAnalysis.CSharp.Symbol)owner, ref checkedTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 39668, 39780);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10119_39858_39873(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 39858, 39873);
                    return return_v;
                }


                bool
                f_10119_39805_39909(ref Microsoft.CodeAnalysis.DiagnosticInfo
                result, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                parameters, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                owner, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                checkedTypes)
                {
                    var return_v = GetUnificationUseSiteDiagnosticRecursive(ref result, parameters, (Microsoft.CodeAnalysis.CSharp.Symbol)owner, ref checkedTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 39805, 39909);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10119_39987_40006(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 39987, 40006);
                    return return_v;
                }


                bool
                f_10119_39934_40042(ref Microsoft.CodeAnalysis.DiagnosticInfo
                result, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                typeParameters, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                owner, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                checkedTypes)
                {
                    var return_v = GetUnificationUseSiteDiagnosticRecursive(ref result, typeParameters, (Microsoft.CodeAnalysis.CSharp.Symbol)owner, ref checkedTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 39934, 40042);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 38303, 40170);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 38303, 40170);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static (bool IsCallConvs, ImmutableHashSet<INamedTypeSymbolInternal>? CallConvs) TryDecodeUnmanagedCallersOnlyCallConvsField(
                    string key,
                    TypedConstant value,
                    bool isField,
                    Location? location,
                    DiagnosticBag? diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10119, 40200, 42194);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 40519, 40593);

                ImmutableHashSet<INamedTypeSymbolInternal>?
                callingConventionTypes = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 40609, 40784) || true) && (!f_10119_40614_40696(key, isField, value))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 40609, 40784);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 40730, 40769);

                    return (false, callingConventionTypes);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 40609, 40784);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 40800, 41012) || true) && (value.Values.IsDefaultOrEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 40800, 41012);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 40867, 40941);

                    callingConventionTypes = ImmutableHashSet<INamedTypeSymbolInternal>.Empty;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 40959, 40997);

                    return (true, callingConventionTypes);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 40800, 41012);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 41028, 41096);

                var
                builder = f_10119_41042_41095()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 41110, 42032);
                    foreach (var callConvTypedConstant in f_10119_41148_41160_I(value.Values))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 41110, 42032);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 41194, 41261);

                        f_10119_41194_41260(callConvTypedConstant.Kind == TypedConstantKind.Type);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 41306, 42015) || true) && (!(callConvTypedConstant.ValueInternal is NamedTypeSymbol)
                        || (DynAbs.Tracing.TraceSender.Expression_False(10119, 41310, 41500) || !f_10119_41393_41500(callConvTypedConstant.ValueInternal)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 41306, 42015);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 41670, 41844) || true) && (diagnostics != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 41670, 41844);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 41720, 41844);

                                f_10119_41720_41843(diagnostics, ErrorCode.ERR_InvalidUnmanagedCallersOnlyCallConv, location, callConvTypedConstant.ValueInternal ?? (DynAbs.Tracing.TraceSender.Expression_Null<object?>(10119, 41797, 41842) ?? "null"));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 41670, 41844);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 41306, 42015);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 41306, 42015);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 41926, 41996);

                            _ = f_10119_41930_41995(builder, (NamedTypeSymbol)callConvTypedConstant.ValueInternal);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 41306, 42015);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 41110, 42032);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10119, 1, 923);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10119, 1, 923);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 42046, 42100);

                callingConventionTypes = f_10119_42071_42099(builder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 42114, 42129);

                f_10119_42114_42128(builder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 42145, 42183);

                return (true, callingConventionTypes);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10119, 40200, 42194);

                bool
                f_10119_40614_40696(string
                key, bool
                isField, Microsoft.CodeAnalysis.TypedConstant
                value)
                {
                    var return_v = UnmanagedCallersOnlyAttributeData.IsCallConvsTypedConstant(key, isField, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 40614, 40696);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.Symbols.INamedTypeSymbolInternal>
                f_10119_41042_41095()
                {
                    var return_v = PooledHashSet<INamedTypeSymbolInternal>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 41042, 41095);
                    return return_v;
                }


                int
                f_10119_41194_41260(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 41194, 41260);
                    return 0;
                }


                bool
                f_10119_41393_41500(object
                modifierType)
                {
                    var return_v = FunctionPointerTypeSymbol.IsCallingConventionModifier((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)modifierType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 41393, 41500);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10119_41720_41843(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location?
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 41720, 41843);
                    return return_v;
                }


                bool
                f_10119_41930_41995(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.Symbols.INamedTypeSymbolInternal>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                item)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.Symbols.INamedTypeSymbolInternal)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 41930, 41995);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10119_41148_41160_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 41148, 41160);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.Symbols.INamedTypeSymbolInternal>
                f_10119_42071_42099(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.Symbols.INamedTypeSymbolInternal>
                source)
                {
                    var return_v = source.ToImmutableHashSet<Microsoft.CodeAnalysis.Symbols.INamedTypeSymbolInternal>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 42071, 42099);
                    return return_v;
                }


                int
                f_10119_42114_42128(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.Symbols.INamedTypeSymbolInternal>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 42114, 42128);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 40200, 42194);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 40200, 42194);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool CheckAndReportValidUnmanagedCallersOnlyTarget(Location? location, DiagnosticBag? diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 42626, 44178);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 42758, 42816);

                f_10119_42758_42815((location == null) == (diagnostics == null));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 42956, 43389) || true) && (f_10119_42960_42969_M(!IsStatic) || (DynAbs.Tracing.TraceSender.Expression_False(10119, 42960, 43051) || !(f_10119_42975_42985() is MethodKind.Ordinary || (DynAbs.Tracing.TraceSender.Expression_False(10119, 42975, 43050) || f_10119_43012_43022() is MethodKind.LocalFunction))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 42956, 43389);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 43222, 43344) || true) && (diagnostics != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 43222, 43344);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 43268, 43344);

                        f_10119_43268_43343(diagnostics, ErrorCode.ERR_UnmanagedCallersOnlyRequiresStatic, location);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 43222, 43344);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 43362, 43374);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 42956, 43389);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 43405, 43703) || true) && (f_10119_43409_43430(this) || (DynAbs.Tracing.TraceSender.Expression_False(10119, 43409, 43462) || f_10119_43434_43462(f_10119_43434_43448())))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 43405, 43703);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 43523, 43658) || true) && (diagnostics != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 43523, 43658);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 43569, 43658);

                        f_10119_43569_43657(diagnostics, ErrorCode.ERR_UnmanagedCallersOnlyMethodOrTypeCannotBeGeneric, location);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 43523, 43658);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 43676, 43688);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 43405, 43703);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 43719, 43732);

                return false;

                static bool isGenericMethod([DisallowNull] MethodSymbol? method)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10119, 43748, 44167);
                        {
                            try
                            {
                                do

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 43845, 44119);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 43888, 43999) || true) && (f_10119_43892_43914(method))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 43888, 43999);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 43964, 43976);

                                        return true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 43888, 43999);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 44023, 44072);

                                    method = f_10119_44032_44055(method) as MethodSymbol;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 43845, 44119);
                                }
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 43845, 44119) || true) && (method is not null)
                                );
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10119, 43845, 44119);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10119, 43845, 44119);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 44139, 44152);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10119, 43748, 44167);

                        bool
                        f_10119_43892_43914(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.IsGenericMethod;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 43892, 43914);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbol
                        f_10119_44032_44055(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingSymbol;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 44032, 44055);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 43748, 44167);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 43748, 44167);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 42626, 44178);

                int
                f_10119_42758_42815(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 42758, 42815);
                    return 0;
                }


                bool
                f_10119_42960_42969_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 42960, 42969);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10119_42975_42985()
                {
                    var return_v = MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 42975, 42985);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10119_43012_43022()
                {
                    var return_v = MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 43012, 43022);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10119_43268_43343(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location?
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 43268, 43343);
                    return return_v;
                }


                bool
                f_10119_43409_43430(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = isGenericMethod(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 43409, 43430);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10119_43434_43448()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 43434, 43448);
                    return return_v;
                }


                bool
                f_10119_43434_43462(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 43434, 43462);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10119_43569_43657(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location?
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 43569, 43657);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 42626, 44178);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 42626, 44178);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override int HighestPriorityUseSiteError
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 44438, 44527);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 44474, 44512);

                    return (int)ErrorCode.ERR_BindToBogus;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 44438, 44527);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 44363, 44538);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 44363, 44538);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool HasUnsupportedMetadata
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 44625, 44874);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 44661, 44706);

                    DiagnosticInfo
                    info = f_10119_44683_44705(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 44724, 44859);

                    return (object)info != null && (DynAbs.Tracing.TraceSender.Expression_True(10119, 44731, 44858) && (f_10119_44756_44765(info) == (int)ErrorCode.ERR_BindToBogus || (DynAbs.Tracing.TraceSender.Expression_False(10119, 44756, 44857) || f_10119_44803_44812(info) == (int)ErrorCode.ERR_ByRefReturnUnsupported)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 44625, 44874);

                    Microsoft.CodeAnalysis.DiagnosticInfo
                    f_10119_44683_44705(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.GetUseSiteDiagnostic();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 44683, 44705);
                        return return_v;
                    }


                    int
                    f_10119_44756_44765(Microsoft.CodeAnalysis.DiagnosticInfo
                    this_param)
                    {
                        var return_v = this_param.Code;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 44756, 44765);
                        return return_v;
                    }


                    int
                    f_10119_44803_44812(Microsoft.CodeAnalysis.DiagnosticInfo
                    this_param)
                    {
                        var return_v = this_param.Code;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 44803, 44812);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 44550, 44885);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 44550, 44885);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual bool IsIterator
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 44976, 45040);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 45012, 45025);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 44976, 45040);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 44919, 45051);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 44919, 45051);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual TypeWithAnnotations IteratorElementTypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 45412, 45435);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 45418, 45433);

                    return default;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 45412, 45435);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 45316, 45505);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 45316, 45505);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 45449, 45494);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 45455, 45492);

                    throw f_10119_45461_45491();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 45449, 45494);

                    System.Exception
                    f_10119_45461_45491()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 45461, 45491);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 45316, 45505);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 45316, 45505);
                }
            }
        }

        internal virtual void GenerateMethodBody(TypeCompilationState compilationState, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 45859, 46038);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 45990, 46027);

                throw f_10119_45996_46026();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 45859, 46038);

                System.Exception
                f_10119_45996_46026()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 45996, 46026);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 45859, 46038);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 45859, 46038);
            }
        }

        internal virtual bool SynthesizesLoweredBoundBody
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 46269, 46333);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 46305, 46318);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 46269, 46333);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 46195, 46344);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 46195, 46344);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract bool GenerateDebugInfo { get; }

        internal abstract int CalculateLocalSyntaxOffset(int localPosition, SyntaxTree localTree);

        internal virtual CodeAnalysis.NullableAnnotation ReceiverNullableAnnotation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 47675, 47801);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 47691, 47801);
                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10119, 47691, 47715) || ((f_10119_47691_47715() && DynAbs.Tracing.TraceSender.Conditional_F2(10119, 47718, 47762)) || DynAbs.Tracing.TraceSender.Conditional_F3(10119, 47765, 47801))) ? CodeAnalysis.NullableAnnotation.NotAnnotated : CodeAnalysis.NullableAnnotation.None; DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 47675, 47801);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 47675, 47801);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 47675, 47801);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual void AddSynthesizedReturnTypeAttributes(PEModuleBuilder moduleBuilder, ref ArrayBuilder<SynthesizedAttributeData> attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 47947, 49402);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 48114, 48283) || true) && (f_10119_48118_48143(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 48114, 48283);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 48177, 48268);

                    f_10119_48177_48267(ref attributes, f_10119_48217_48266(moduleBuilder, this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 48114, 48283);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 48299, 48343);

                var
                compilation = f_10119_48317_48342(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 48357, 48399);

                var
                type = f_10119_48368_48398(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 48415, 48704) || true) && (f_10119_48419_48446(type.Type) && (DynAbs.Tracing.TraceSender.Expression_True(10119, 48419, 48488) && f_10119_48450_48488(compilation)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 48415, 48704);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 48522, 48689);

                    f_10119_48522_48688(ref attributes, f_10119_48562_48687(compilation, type.Type, type.CustomModifiers.Length + this.RefCustomModifiers.Length, f_10119_48674_48686(this)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 48415, 48704);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 48720, 48911) || true) && (f_10119_48724_48757(type.Type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 48720, 48911);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 48791, 48896);

                    f_10119_48791_48895(ref attributes, f_10119_48831_48894(moduleBuilder, this, type.Type));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 48720, 48911);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 48927, 49143) || true) && (f_10119_48931_48961(type.Type) && (DynAbs.Tracing.TraceSender.Expression_True(10119, 48931, 49000) && f_10119_48965_49000(compilation)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 48927, 49143);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 49034, 49128);

                    f_10119_49034_49127(ref attributes, f_10119_49074_49126(compilation, type.Type));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 48927, 49143);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 49159, 49391) || true) && (f_10119_49163_49209(compilation, this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 49159, 49391);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 49243, 49376);

                    f_10119_49243_49375(ref attributes, f_10119_49283_49374(moduleBuilder, this, f_10119_49342_49367(this), type));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 49159, 49391);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 47947, 49402);

                bool
                f_10119_48118_48143(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnsByRefReadonly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 48118, 48143);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10119_48217_48266(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = this_param.SynthesizeIsReadOnlyAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 48217, 48266);
                    return return_v;
                }


                int
                f_10119_48177_48267(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 48177, 48267);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10119_48317_48342(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 48317, 48342);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10119_48368_48398(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 48368, 48398);
                    return return_v;
                }


                bool
                f_10119_48419_48446(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 48419, 48446);
                    return return_v;
                }


                bool
                f_10119_48450_48488(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.HasDynamicEmitAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 48450, 48488);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10119_48674_48686(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 48674, 48686);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10119_48562_48687(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, int
                customModifiersCount, Microsoft.CodeAnalysis.RefKind
                refKindOpt)
                {
                    var return_v = this_param.SynthesizeDynamicAttribute(type, customModifiersCount, refKindOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 48562, 48687);
                    return return_v;
                }


                int
                f_10119_48522_48688(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 48522, 48688);
                    return 0;
                }


                bool
                f_10119_48724_48757(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsNativeInteger();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 48724, 48757);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10119_48831_48894(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.SynthesizeNativeIntegerAttribute((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 48831, 48894);
                    return return_v;
                }


                int
                f_10119_48791_48895(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 48791, 48895);
                    return 0;
                }


                bool
                f_10119_48931_48961(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsTupleNames();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 48931, 48961);
                    return return_v;
                }


                bool
                f_10119_48965_49000(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.HasTupleNamesAttributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 48965, 49000);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10119_49074_49126(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.SynthesizeTupleNamesAttribute(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 49074, 49126);
                    return return_v;
                }


                int
                f_10119_49034_49127(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 49034, 49127);
                    return 0;
                }


                bool
                f_10119_49163_49209(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = this_param.ShouldEmitNullableAttributes((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 49163, 49209);
                    return return_v;
                }


                byte?
                f_10119_49342_49367(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetNullableContextValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 49342, 49367);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10119_49283_49374(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol, byte?
                nullableContextValue, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type)
                {
                    var return_v = this_param.SynthesizeNullableAttributeIfNecessary((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, nullableContextValue, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 49283, 49374);
                    return return_v;
                }


                int
                f_10119_49243_49375(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                attribute)
                {
                    AddSynthesizedAttribute(ref attributes, attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 49243, 49375);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 47947, 49402);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 47947, 49402);
            }
        }

        public abstract bool AreLocalsZeroed { get; }

        internal abstract bool IsNullableAnalysisEnabled();

        bool IMethodSymbolInternal.IsIterator
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 49718, 49731);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 49721, 49731);
                    return f_10119_49721_49731(); DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 49718, 49731);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 49718, 49731);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 49718, 49731);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        int IMethodSymbolInternal.CalculateLocalSyntaxOffset(int localPosition, SyntaxTree localTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 49838, 49893);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 49841, 49893);
                return f_10119_49841_49893(this, localPosition, localTree); DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 49838, 49893);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 49838, 49893);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 49838, 49893);
            }
            throw new System.Exception("Slicer error: unreachable code");

            int
            f_10119_49841_49893(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            this_param, int
            localPosition, Microsoft.CodeAnalysis.SyntaxTree
            localTree)
            {
                var return_v = this_param.CalculateLocalSyntaxOffset(localPosition, localTree);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 49841, 49893);
                return return_v;
            }
        }

        IMethodSymbolInternal IMethodSymbolInternal.Construct(params ITypeSymbolInternal[] typeArguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 49906, 50085);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 50028, 50074);

                return f_10119_50035_50073(this, typeArguments);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 49906, 50085);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10119_50035_50073(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, params Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal[]
                typeArguments)
                {
                    var return_v = this_param.Construct((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[])typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 50035, 50073);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 49906, 50085);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 49906, 50085);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected sealed override ISymbol CreateISymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 50119, 50246);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 50193, 50235);

                return f_10119_50200_50234(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 50119, 50246);

                Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.MethodSymbol
                f_10119_50200_50234(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                underlying)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.MethodSymbol(underlying);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 50200, 50234);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 50119, 50246);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 50119, 50246);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(Symbol other, TypeCompareKind compareKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 50258, 50689);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 50353, 50479) || true) && (other is SubstitutedMethodSymbol sms)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 50353, 50479);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 50427, 50464);

                    return f_10119_50434_50463(sms, this, compareKind);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 50353, 50479);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 50495, 50623) || true) && (other is NativeIntegerMethodSymbol nms)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10119, 50495, 50623);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 50571, 50608);

                    return f_10119_50578_50607(nms, this, compareKind);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10119, 50495, 50623);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 50639, 50678);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Equals(other, compareKind), 10119, 50646, 50677);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 50258, 50689);

                bool
                f_10119_50434_50463(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedMethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                obj, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbol)obj, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 50434, 50463);
                    return return_v;
                }


                bool
                f_10119_50578_50607(Microsoft.CodeAnalysis.CSharp.Symbols.NativeIntegerMethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                other, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbol)other, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 50578, 50607);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 50258, 50689);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 50258, 50689);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10119, 50701, 50796);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10119, 50759, 50785);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetHashCode(), 10119, 50766, 50784);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10119, 50701, 50796);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10119, 50701, 50796);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10119, 50701, 50796);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        bool
        f_10119_3181_3190_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 3181, 3190);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        f_10119_9912_9937()
        {
            var return_v = ReturnTypeWithAnnotations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 9912, 9937);
            return return_v;
        }


        bool
        f_10119_14679_14697()
        {
            var return_v = IsDeclaredReadOnly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 14679, 14697);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10119_14701_14715()
        {
            var return_v = ContainingType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 14701, 14715);
            return return_v;
        }


        bool?
        f_10119_14701_14727_M(bool?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 14701, 14727);
            return return_v;
        }


        bool
        f_10119_14740_14761()
        {
            var return_v = IsValidReadOnlyTarget;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 14740, 14761);
            return return_v;
        }


        bool
        f_10119_14814_14823_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 14814, 14823);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10119_14827_14841()
        {
            var return_v = ContainingType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 14827, 14841);
            return return_v;
        }


        bool
        f_10119_14827_14856(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        type)
        {
            var return_v = type.IsStructType();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10119, 14827, 14856);
            return return_v;
        }


        Microsoft.CodeAnalysis.MethodKind
        f_10119_14860_14870()
        {
            var return_v = MethodKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 14860, 14870);
            return return_v;
        }


        bool
        f_10119_14900_14911_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 14900, 14911);
            return return_v;
        }


        bool
        f_10119_47691_47715()
        {
            var return_v = RequiresInstanceReceiver;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 47691, 47715);
            return return_v;
        }


        bool
        f_10119_49721_49731()
        {
            var return_v = IsIterator;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10119, 49721, 49731);
            return return_v;
        }

    }
}
