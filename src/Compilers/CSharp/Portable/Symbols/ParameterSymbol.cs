// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Symbols;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract partial class ParameterSymbol : Symbol, IParameterSymbolInternal
    {
        internal const string
        ValueParameterName = "value"
        ;

        internal ParameterSymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10143, 888, 936);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10200, 6793, 6805);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10143, 888, 936);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10143, 888, 936);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10143, 888, 936);
            }
        }

        public new virtual ParameterSymbol OriginalDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10143, 1313, 1376);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10143, 1349, 1361);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10143, 1313, 1376);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10143, 1235, 1387);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10143, 1235, 1387);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10143, 1481, 1563);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10143, 1517, 1548);

                    return f_10143_1524_1547(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10143, 1481, 1563);

                    Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    f_10143_1524_1547(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10143, 1524, 1547);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10143, 1399, 1574);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10143, 1399, 1574);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract TypeWithAnnotations TypeWithAnnotations { get; }

        public TypeSymbol Type
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10143, 1896, 1923);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10143, 1899, 1923);
                    return f_10143_1899_1918().Type; DynAbs.Tracing.TraceSender.TraceExitMethod(10143, 1896, 1923);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10143, 1896, 1923);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10143, 1896, 1923);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract RefKind RefKind { get; }

        public abstract bool IsDiscard { get; }

        public abstract ImmutableArray<CustomModifier> RefCustomModifiers { get; }

        internal abstract MarshalPseudoCustomAttributeData MarshallingInformation { get; }

        internal virtual UnmanagedType MarshallingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10143, 3508, 3656);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10143, 3544, 3578);

                    var
                    info = f_10143_3555_3577()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10143, 3596, 3641);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10143, 3603, 3615) || ((info != null && DynAbs.Tracing.TraceSender.Conditional_F2(10143, 3618, 3636)) || DynAbs.Tracing.TraceSender.Conditional_F3(10143, 3639, 3640))) ? f_10143_3618_3636(info) : 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10143, 3508, 3656);

                    Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
                    f_10143_3555_3577()
                    {
                        var return_v = MarshallingInformation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10143, 3555, 3577);
                        return return_v;
                    }


                    System.Runtime.InteropServices.UnmanagedType
                    f_10143_3618_3636(Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
                    this_param)
                    {
                        var return_v = this_param.UnmanagedType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10143, 3618, 3636);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10143, 3437, 3667);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10143, 3437, 3667);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsMarshalAsObject
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10143, 3735, 4090);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10143, 3771, 4042);

                    switch (f_10143_3779_3799(this))
                    {

                        case UnmanagedType.Interface:
                        case UnmanagedType.IUnknown:
                        case Cci.Constants.UnmanagedType_IDispatch:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10143, 3771, 4042);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10143, 4011, 4023);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10143, 3771, 4042);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10143, 4062, 4075);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10143, 3735, 4090);

                    System.Runtime.InteropServices.UnmanagedType
                    f_10143_3779_3799(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.MarshallingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10143, 3779, 3799);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10143, 3679, 4101);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10143, 3679, 4101);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract int Ordinal { get; }

        public abstract bool IsParams { get; }

        public bool IsOptional
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10143, 5078, 6479);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10143, 6174, 6190);

                    RefKind
                    refKind
                    = default(RefKind);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10143, 6208, 6464);

                    return f_10143_6215_6224_M(!IsParams) && (DynAbs.Tracing.TraceSender.Expression_True(10143, 6215, 6246) && f_10143_6228_6246()) && (DynAbs.Tracing.TraceSender.Expression_True(10143, 6215, 6463) && ((refKind = f_10143_6286_6293()) == RefKind.None || (DynAbs.Tracing.TraceSender.Expression_False(10143, 6275, 6362) || (refKind == RefKind.In)) || (DynAbs.Tracing.TraceSender.Expression_False(10143, 6275, 6462) || (refKind == RefKind.Ref && (DynAbs.Tracing.TraceSender.Expression_True(10143, 6392, 6461) && f_10143_6418_6461(f_10143_6418_6449(f_10143_6418_6434())))))));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10143, 5078, 6479);

                    bool
                    f_10143_6215_6224_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10143, 6215, 6224);
                        return return_v;
                    }


                    bool
                    f_10143_6228_6246()
                    {
                        var return_v = IsMetadataOptional;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10143, 6228, 6246);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.RefKind
                    f_10143_6286_6293()
                    {
                        var return_v = RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10143, 6286, 6293);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10143_6418_6434()
                    {
                        var return_v = ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10143, 6418, 6434);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10143_6418_6449(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10143, 6418, 6449);
                        return return_v;
                    }


                    bool
                    f_10143_6418_6461(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsComImport;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10143, 6418, 6461);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10143, 5031, 6490);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10143, 5031, 6490);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract bool IsMetadataOptional { get; }

        internal abstract bool IsMetadataIn { get; }

        internal abstract bool IsMetadataOut { get; }

        public bool HasExplicitDefaultValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10143, 7791, 8718);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10143, 8645, 8703);

                    return f_10143_8652_8662() && (DynAbs.Tracing.TraceSender.Expression_True(10143, 8652, 8702) && f_10143_8666_8694() != null);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10143, 7791, 8718);

                    bool
                    f_10143_8652_8662()
                    {
                        var return_v = IsOptional;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10143, 8652, 8662);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue?
                    f_10143_8666_8694()
                    {
                        var return_v = ExplicitDefaultConstantValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10143, 8666, 8694);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10143, 7731, 8729);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10143, 7731, 8729);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public object ExplicitDefaultValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10143, 9498, 9737);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10143, 9534, 9664) || true) && (f_10143_9538_9561())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10143, 9534, 9664);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10143, 9603, 9645);

                        return f_10143_9610_9644(f_10143_9610_9638());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10143, 9534, 9664);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10143, 9684, 9722);

                    throw f_10143_9690_9721();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10143, 9498, 9737);

                    bool
                    f_10143_9538_9561()
                    {
                        var return_v = HasExplicitDefaultValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10143, 9538, 9561);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue?
                    f_10143_9610_9638()
                    {
                        var return_v = ExplicitDefaultConstantValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10143, 9610, 9638);
                        return return_v;
                    }


                    object?
                    f_10143_9610_9644(Microsoft.CodeAnalysis.ConstantValue?
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10143, 9610, 9644);
                        return return_v;
                    }


                    System.InvalidOperationException
                    f_10143_9690_9721()
                    {
                        var return_v = new System.InvalidOperationException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10143, 9690, 9721);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10143, 9380, 9748);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10143, 9380, 9748);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract ConstantValue? ExplicitDefaultConstantValue { get; }

        public sealed override SymbolKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10143, 10642, 10721);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10143, 10678, 10706);

                    return SymbolKind.Parameter;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10143, 10642, 10721);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10143, 10579, 10732);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10143, 10579, 10732);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override TResult Accept<TArgument, TResult>(CSharpSymbolVisitor<TArgument, TResult> visitor, TArgument argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10143, 10833, 11036);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10143, 10979, 11025);

                return f_10143_10986_11024<TResult, TArgument>(visitor, this, argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10143, 10833, 11036);

                TResult
                f_10143_10986_11024<TResult, TArgument>(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TArgument, TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                symbol, TArgument
                argument)
                {
                    var return_v = this_param.VisitParameter(symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10143, 10986, 11024);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10143, 10833, 11036);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10143, 10833, 11036);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void Accept(CSharpSymbolVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10143, 11048, 11169);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10143, 11129, 11158);

                f_10143_11129_11157(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10143, 11048, 11169);

                int
                f_10143_11129_11157(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                symbol)
                {
                    this_param.VisitParameter(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10143, 11129, 11157);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10143, 11048, 11169);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10143, 11048, 11169);
            }
        }

        public override TResult Accept<TResult>(CSharpSymbolVisitor<TResult> visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10143, 11181, 11330);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10143, 11283, 11319);

                return f_10143_11290_11318<TResult>(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10143, 11181, 11330);

                TResult
                f_10143_11290_11318<TResult>(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                symbol)
                {
                    var return_v = this_param.VisitParameter(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10143, 11290, 11318);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10143, 11181, 11330);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10143, 11181, 11330);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Accessibility DeclaredAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10143, 11632, 11718);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10143, 11668, 11703);

                    return Accessibility.NotApplicable;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10143, 11632, 11718);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10143, 11556, 11729);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10143, 11556, 11729);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10143, 12100, 12164);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10143, 12136, 12149);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10143, 12100, 12164);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10143, 12044, 12175);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10143, 12044, 12175);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10143, 12629, 12693);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10143, 12665, 12678);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10143, 12629, 12693);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10143, 12575, 12704);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10143, 12575, 12704);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsVirtual
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10143, 13076, 13140);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10143, 13112, 13125);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10143, 13076, 13140);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10143, 13021, 13151);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10143, 13021, 13151);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsOverride
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10143, 13537, 13601);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10143, 13573, 13586);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10143, 13537, 13601);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10143, 13481, 13612);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10143, 13481, 13612);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10143, 13856, 13920);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10143, 13892, 13905);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10143, 13856, 13920);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10143, 13802, 13931);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10143, 13802, 13931);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsExtern
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10143, 14172, 14236);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10143, 14208, 14221);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10143, 14172, 14236);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10143, 14118, 14247);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10143, 14118, 14247);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual bool IsThis
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10143, 14432, 14496);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10143, 14468, 14481);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10143, 14432, 14496);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10143, 14381, 14507);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10143, 14381, 14507);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10143, 14880, 14900);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10143, 14886, 14898);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10143, 14880, 14900);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10143, 14787, 14911);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10143, 14787, 14911);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract bool IsIDispatchConstant { get; }

        internal abstract bool IsIUnknownConstant { get; }

        internal abstract bool IsCallerFilePath { get; }

        internal abstract bool IsCallerLineNumber { get; }

        internal abstract bool IsCallerMemberName { get; }

        internal abstract FlowAnalysisAnnotations FlowAnalysisAnnotations { get; }

        internal abstract ImmutableHashSet<string> NotNullIfParameterNotNull { get; }

        protected sealed override int HighestPriorityUseSiteError
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10143, 15489, 15576);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10143, 15525, 15561);

                    return (int)ErrorCode.ERR_BogusType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10143, 15489, 15576);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10143, 15407, 15587);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10143, 15407, 15587);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10143, 15674, 15914);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10143, 15710, 15737);

                    DiagnosticInfo
                    info = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10143, 15755, 15808);

                    f_10143_15755_15807(this, ref info, this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10143, 15826, 15899);

                    return (object)info != null && (DynAbs.Tracing.TraceSender.Expression_True(10143, 15833, 15898) && f_10143_15857_15866(info) == (int)ErrorCode.ERR_BogusType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10143, 15674, 15914);

                    bool
                    f_10143_15755_15807(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo?
                    result, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    param)
                    {
                        var return_v = this_param.DeriveUseSiteDiagnosticFromParameter(ref result, param);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10143, 15755, 15807);
                        return return_v;
                    }


                    int
                    f_10143_15857_15866(Microsoft.CodeAnalysis.DiagnosticInfo
                    this_param)
                    {
                        var return_v = this_param.Code;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10143, 15857, 15866);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10143, 15599, 15925);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10143, 15599, 15925);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override ISymbol CreateISymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10143, 15937, 16060);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10143, 16004, 16049);

                return f_10143_16011_16048(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10143, 15937, 16060);

                Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.ParameterSymbol
                f_10143_16011_16048(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                underlying)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.ParameterSymbol(underlying);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10143, 16011, 16048);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10143, 15937, 16060);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10143, 15937, 16060);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        f_10143_1899_1918()
        {
            var return_v = TypeWithAnnotations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10143, 1899, 1918);
            return return_v;
        }

    }
}
