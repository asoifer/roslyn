// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract partial class FieldSymbol : Symbol, IFieldSymbolInternal
    {
        internal FieldSymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10110, 1070, 1114);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10187, 9904, 9916);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10110, 1070, 1114);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10110, 1070, 1114);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10110, 1070, 1114);
            }
        }

        public new virtual FieldSymbol OriginalDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10110, 1487, 1550);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 1523, 1535);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10110, 1487, 1550);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10110, 1413, 1561);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10110, 1413, 1561);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10110, 1655, 1737);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 1691, 1722);

                    return f_10110_1698_1721(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10110, 1655, 1737);

                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10110_1698_1721(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10110, 1698, 1721);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10110, 1573, 1748);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10110, 1573, 1748);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public TypeWithAnnotations TypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10110, 1947, 2047);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 1983, 2032);

                    return f_10110_1990_2031(this, ConsList<FieldSymbol>.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10110, 1947, 2047);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10110_1990_2031(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                    fieldsBeingBound)
                    {
                        var return_v = this_param.GetFieldType(fieldsBeingBound);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10110, 1990, 2031);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10110, 1876, 2058);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10110, 1876, 2058);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract FlowAnalysisAnnotations FlowAnalysisAnnotations { get; }

        public TypeSymbol Type
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10110, 2266, 2293);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 2269, 2293);
                    return f_10110_2269_2288().Type; DynAbs.Tracing.TraceSender.TraceExitMethod(10110, 2266, 2293);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10110, 2266, 2293);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10110, 2266, 2293);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract TypeWithAnnotations GetFieldType(ConsList<FieldSymbol> fieldsBeingBound);

        public abstract Symbol AssociatedSymbol { get; }

        public abstract bool IsReadOnly { get; }

        public abstract bool IsVolatile { get; }

        public virtual bool RequiresInstanceReceiver
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10110, 3421, 3433);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 3424, 3433);
                    return f_10110_3424_3433_M(!IsStatic); DynAbs.Tracing.TraceSender.TraceExitMethod(10110, 3421, 3433);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10110, 3421, 3433);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10110, 3421, 3433);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual bool IsFixedSizeBuffer
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10110, 3794, 3815);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 3800, 3813);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10110, 3794, 3815);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10110, 3754, 3817);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10110, 3754, 3817);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual int FixedSize
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10110, 4270, 4287);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 4276, 4285);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10110, 4270, 4287);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10110, 4239, 4289);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10110, 4239, 4289);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual NamedTypeSymbol FixedImplementationType(PEModuleBuilder emitModule)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10110, 4517, 4649);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 4626, 4638);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10110, 4517, 4649);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10110, 4517, 4649);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10110, 4517, 4649);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual bool IsCapturedFrame
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10110, 4853, 4874);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 4859, 4872);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10110, 4853, 4874);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10110, 4813, 4876);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10110, 4813, 4876);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract bool IsConst { get; }

        public bool IsMetadataConstant
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10110, 5427, 5512);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 5433, 5510);

                    return f_10110_5440_5452(this) && (DynAbs.Tracing.TraceSender.Expression_True(10110, 5440, 5509) && (f_10110_5457_5478(f_10110_5457_5466(this)) != SpecialType.System_Decimal));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10110, 5427, 5512);

                    bool
                    f_10110_5440_5452(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.IsConst;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10110, 5440, 5452);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10110_5457_5466(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10110, 5457, 5466);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SpecialType
                    f_10110_5457_5478(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.SpecialType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10110, 5457, 5478);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10110, 5372, 5523);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10110, 5372, 5523);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual bool HasConstantValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10110, 5784, 6165);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 5820, 5906) || true) && (f_10110_5824_5832_M(!IsConst))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10110, 5820, 5906);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 5874, 5887);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10110, 5820, 5906);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 5926, 6046);

                    ConstantValue
                    constantValue = f_10110_5956_6045(this, ConstantFieldsInProgress.Empty, earlyDecodingWellKnownAttributes: false)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 6064, 6117);

                    return constantValue != null && (DynAbs.Tracing.TraceSender.Expression_True(10110, 6071, 6116) && f_10110_6096_6116_M(!constantValue.IsBad));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10110, 5784, 6165);

                    bool
                    f_10110_5824_5832_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10110, 5824, 5832);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue
                    f_10110_5956_6045(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.ConstantFieldsInProgress
                    inProgress, bool
                    earlyDecodingWellKnownAttributes)
                    {
                        var return_v = this_param.GetConstantValue(inProgress, earlyDecodingWellKnownAttributes: earlyDecodingWellKnownAttributes);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10110, 5956, 6045);
                        return return_v;
                    }


                    bool
                    f_10110_6096_6116_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10110, 6096, 6116);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10110, 5723, 6176);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10110, 5723, 6176);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual object ConstantValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10110, 6452, 6837);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 6488, 6573) || true) && (f_10110_6492_6500_M(!IsConst))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10110, 6488, 6573);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 6542, 6554);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10110, 6488, 6573);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 6593, 6713);

                    ConstantValue
                    constantValue = f_10110_6623_6712(this, ConstantFieldsInProgress.Empty, earlyDecodingWellKnownAttributes: false)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 6731, 6789);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10110, 6738, 6759) || ((constantValue == null && DynAbs.Tracing.TraceSender.Conditional_F2(10110, 6762, 6766)) || DynAbs.Tracing.TraceSender.Conditional_F3(10110, 6769, 6788))) ? null : f_10110_6769_6788(constantValue);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10110, 6452, 6837);

                    bool
                    f_10110_6492_6500_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10110, 6492, 6500);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.ConstantValue
                    f_10110_6623_6712(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.ConstantFieldsInProgress
                    inProgress, bool
                    earlyDecodingWellKnownAttributes)
                    {
                        var return_v = this_param.GetConstantValue(inProgress, earlyDecodingWellKnownAttributes: earlyDecodingWellKnownAttributes);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10110, 6623, 6712);
                        return return_v;
                    }


                    object?
                    f_10110_6769_6788(Microsoft.CodeAnalysis.ConstantValue
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10110, 6769, 6788);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10110, 6392, 6848);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10110, 6392, 6848);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract ConstantValue GetConstantValue(ConstantFieldsInProgress inProgress, bool earlyDecodingWellKnownAttributes);

        public sealed override SymbolKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10110, 7150, 7225);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 7186, 7210);

                    return SymbolKind.Field;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10110, 7150, 7225);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10110, 7087, 7236);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10110, 7087, 7236);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override TResult Accept<TArgument, TResult>(CSharpSymbolVisitor<TArgument, TResult> visitor, TArgument argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10110, 7248, 7447);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 7394, 7436);

                return f_10110_7401_7435<TResult, TArgument>(visitor, this, argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10110, 7248, 7447);

                TResult
                f_10110_7401_7435<TResult, TArgument>(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TArgument, TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                symbol, TArgument
                argument)
                {
                    var return_v = this_param.VisitField(symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10110, 7401, 7435);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10110, 7248, 7447);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10110, 7248, 7447);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void Accept(CSharpSymbolVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10110, 7459, 7576);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 7540, 7565);

                f_10110_7540_7564(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10110, 7459, 7576);

                int
                f_10110_7540_7564(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                symbol)
                {
                    this_param.VisitField(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10110, 7540, 7564);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10110, 7459, 7576);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10110, 7459, 7576);
            }
        }

        public override TResult Accept<TResult>(CSharpSymbolVisitor<TResult> visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10110, 7588, 7733);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 7690, 7722);

                return f_10110_7697_7721<TResult>(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10110, 7588, 7733);

                TResult
                f_10110_7697_7721<TResult>(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                symbol)
                {
                    var return_v = this_param.VisitField(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10110, 7697, 7721);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10110, 7588, 7733);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10110, 7588, 7733);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override bool IsAbstract
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10110, 7915, 7979);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 7951, 7964);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10110, 7915, 7979);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10110, 7852, 7990);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10110, 7852, 7990);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsExtern
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10110, 8180, 8244);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 8216, 8229);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10110, 8180, 8244);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10110, 8119, 8255);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10110, 8119, 8255);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsOverride
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10110, 8439, 8503);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 8475, 8488);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10110, 8439, 8503);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10110, 8376, 8514);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10110, 8376, 8514);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10110, 8692, 8756);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 8728, 8741);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10110, 8692, 8756);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10110, 8631, 8767);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10110, 8631, 8767);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsVirtual
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10110, 8947, 9011);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 8983, 8996);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10110, 8947, 9011);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10110, 8885, 9022);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10110, 8885, 9022);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract bool HasSpecialName { get; }

        internal abstract bool HasRuntimeSpecialName { get; }

        internal abstract bool IsNotSerialized { get; }

        internal virtual bool HasPointerType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10110, 10265, 10362);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 10301, 10347);

                    return f_10110_10308_10346(f_10110_10308_10317(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10110, 10265, 10362);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10110_10308_10317(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10110, 10308, 10317);
                        return return_v;
                    }


                    bool
                    f_10110_10308_10346(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = type.IsPointerOrFunctionPointer();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10110, 10308, 10346);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10110, 10204, 10373);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10110, 10204, 10373);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract MarshalPseudoCustomAttributeData MarshallingInformation { get; }

        internal virtual UnmanagedType MarshallingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10110, 11385, 11533);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 11421, 11455);

                    var
                    info = f_10110_11432_11454()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 11473, 11518);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10110, 11480, 11492) || ((info != null && DynAbs.Tracing.TraceSender.Conditional_F2(10110, 11495, 11513)) || DynAbs.Tracing.TraceSender.Conditional_F3(10110, 11516, 11517))) ? f_10110_11495_11513(info) : 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10110, 11385, 11533);

                    Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
                    f_10110_11432_11454()
                    {
                        var return_v = MarshallingInformation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10110, 11432, 11454);
                        return return_v;
                    }


                    System.Runtime.InteropServices.UnmanagedType
                    f_10110_11495_11513(Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData
                    this_param)
                    {
                        var return_v = this_param.UnmanagedType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10110, 11495, 11513);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10110, 11314, 11544);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10110, 11314, 11544);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract int? TypeLayoutOffset { get; }

        internal virtual FieldSymbol AsMember(NamedTypeSymbol newOwner)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10110, 11787, 12158);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 11875, 11907);

                f_10110_11875_11906(f_10110_11888_11905(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 11921, 12022);

                f_10110_11921_12021(f_10110_11934_12020(f_10110_11950_11977(newOwner), f_10110_11979_12019(f_10110_11979_12000(this))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 12036, 12147);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10110, 12043, 12064) || ((f_10110_12043_12064(newOwner) && DynAbs.Tracing.TraceSender.Conditional_F2(10110, 12067, 12071)) || DynAbs.Tracing.TraceSender.Conditional_F3(10110, 12074, 12146))) ? this : f_10110_12074_12146(newOwner as SubstitutedNamedTypeSymbol, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10110, 11787, 12158);

                bool
                f_10110_11888_11905(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10110, 11888, 11905);
                    return return_v;
                }


                int
                f_10110_11875_11906(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10110, 11875, 11906);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10110_11950_11977(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10110, 11950, 11977);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10110_11979_12000(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10110, 11979, 12000);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10110_11979_12019(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10110, 11979, 12019);
                    return return_v;
                }


                bool
                f_10110_11934_12020(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10110, 11934, 12020);
                    return return_v;
                }


                int
                f_10110_11921_12021(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10110, 11921, 12021);
                    return 0;
                }


                bool
                f_10110_12043_12064(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10110, 12043, 12064);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedFieldSymbol
                f_10110_12074_12146(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                substitutedFrom)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedFieldSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedNamedTypeSymbol?)containingType, substitutedFrom);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10110, 12074, 12146);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10110, 11787, 12158);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10110, 11787, 12158);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override DiagnosticInfo GetUseSiteDiagnostic()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10110, 12210, 12476);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 12290, 12395) || true) && (f_10110_12294_12311(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10110, 12290, 12395);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 12345, 12380);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetUseSiteDiagnostic(), 10110, 12352, 12379);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10110, 12290, 12395);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 12411, 12465);

                return f_10110_12418_12464(f_10110_12418_12441(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10110, 12210, 12476);

                bool
                f_10110_12294_12311(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10110, 12294, 12311);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10110_12418_12441(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10110, 12418, 12441);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10110_12418_12464(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10110, 12418, 12464);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10110, 12210, 12476);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10110, 12210, 12476);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool CalculateUseSiteDiagnostic(ref DiagnosticInfo result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10110, 12488, 13442);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 12580, 12607);

                f_10110_12580_12606(f_10110_12593_12605());

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 12668, 12872) || true) && (f_10110_12672_12811(this, ref result, f_10110_12716_12740(this), AllowedRequiredModifierType.System_Runtime_CompilerServices_Volatile))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10110, 12668, 12872);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 12845, 12857);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10110, 12668, 12872);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 13049, 13402) || true) && (f_10110_13053_13095(f_10110_13053_13074(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10110, 13049, 13402);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 13129, 13180);

                    HashSet<TypeSymbol>
                    unificationCheckedTypes = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 13198, 13387) || true) && (this.TypeWithAnnotations.GetUnificationUseSiteDiagnosticRecursive(ref result, this, ref unificationCheckedTypes))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10110, 13198, 13387);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 13356, 13368);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10110, 13198, 13387);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10110, 13049, 13402);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 13418, 13431);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10110, 12488, 13442);

                bool
                f_10110_12593_12605()
                {
                    var return_v = IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10110, 12593, 12605);
                    return return_v;
                }


                int
                f_10110_12580_12606(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10110, 12580, 12606);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10110_12716_12740(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10110, 12716, 12740);
                    return return_v;
                }


                bool
                f_10110_12672_12811(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo
                result, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                type, Microsoft.CodeAnalysis.CSharp.Symbol.AllowedRequiredModifierType
                allowedRequiredModifierType)
                {
                    var return_v = this_param.DeriveUseSiteDiagnosticFromType(ref result, type, allowedRequiredModifierType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10110, 12672, 12811);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10110_13053_13074(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10110, 13053, 13074);
                    return return_v;
                }


                bool
                f_10110_13053_13095(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.HasUnifiedReferences;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10110, 13053, 13095);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10110, 12488, 13442);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10110, 12488, 13442);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override int HighestPriorityUseSiteError
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10110, 13684, 13773);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 13720, 13758);

                    return (int)ErrorCode.ERR_BindToBogus;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10110, 13684, 13773);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10110, 13609, 13784);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10110, 13609, 13784);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10110, 13871, 14060);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 13907, 13952);

                    DiagnosticInfo
                    info = f_10110_13929_13951(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 13970, 14045);

                    return (object)info != null && (DynAbs.Tracing.TraceSender.Expression_True(10110, 13977, 14044) && f_10110_14001_14010(info) == (int)ErrorCode.ERR_BindToBogus);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10110, 13871, 14060);

                    Microsoft.CodeAnalysis.DiagnosticInfo
                    f_10110_13929_13951(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    this_param)
                    {
                        var return_v = this_param.GetUseSiteDiagnostic();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10110, 13929, 13951);
                        return return_v;
                    }


                    int
                    f_10110_14001_14010(Microsoft.CodeAnalysis.DiagnosticInfo
                    this_param)
                    {
                        var return_v = this_param.Code;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10110, 14001, 14010);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10110, 13796, 14071);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10110, 13796, 14071);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual bool IsVirtualTupleField
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10110, 14326, 14390);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 14362, 14375);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10110, 14326, 14390);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10110, 14262, 14401);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10110, 14262, 14401);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual bool IsDefaultTupleElement
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10110, 14623, 14687);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 14659, 14672);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10110, 14623, 14687);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10110, 14557, 14698);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10110, 14557, 14698);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual FieldSymbol TupleUnderlyingField
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10110, 15113, 15212);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 15149, 15197);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10110, 15156, 15182) || ((f_10110_15156_15182(f_10110_15156_15170()) && DynAbs.Tracing.TraceSender.Conditional_F2(10110, 15185, 15189)) || DynAbs.Tracing.TraceSender.Conditional_F3(10110, 15192, 15196))) ? this : null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10110, 15113, 15212);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10110_15156_15170()
                    {
                        var return_v = ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10110, 15156, 15170);
                        return return_v;
                    }


                    bool
                    f_10110_15156_15182(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsTupleType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10110, 15156, 15182);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10110, 15041, 15223);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10110, 15041, 15223);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public virtual FieldSymbol CorrespondingTupleField
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10110, 15496, 15559);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 15532, 15544);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10110, 15496, 15559);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10110, 15421, 15570);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10110, 15421, 15570);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsTupleElement()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10110, 15691, 15803);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 15746, 15792);

                return f_10110_15753_15781(this) is object;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10110, 15691, 15803);

                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10110_15753_15781(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.CorrespondingTupleField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10110, 15753, 15781);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10110, 15691, 15803);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10110, 15691, 15803);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public virtual int TupleElementIndex
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10110, 16079, 16140);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 16115, 16125);

                    return -1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10110, 16079, 16140);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10110, 16018, 16151);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10110, 16018, 16151);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool IFieldSymbolInternal.IsVolatile
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10110, 16200, 16218);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 16203, 16218);
                    return f_10110_16203_16218(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10110, 16200, 16218);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10110, 16200, 16218);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10110, 16200, 16218);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override ISymbol CreateISymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10110, 16231, 16350);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 16298, 16339);

                return f_10110_16305_16338(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10110, 16231, 16350);

                Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.FieldSymbol
                f_10110_16305_16338(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                underlying)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.FieldSymbol(underlying);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10110, 16305, 16338);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10110, 16231, 16350);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10110, 16231, 16350);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool Equals(Symbol other, TypeCompareKind compareKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10110, 16362, 16648);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 16457, 16582) || true) && (other is SubstitutedFieldSymbol sfs)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10110, 16457, 16582);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 16530, 16567);

                    return f_10110_16537_16566(sfs, this, compareKind);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10110, 16457, 16582);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 16598, 16637);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Equals(other, compareKind), 10110, 16605, 16636);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10110, 16362, 16648);

                bool
                f_10110_16537_16566(Microsoft.CodeAnalysis.CSharp.Symbols.SubstitutedFieldSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                obj, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals((Microsoft.CodeAnalysis.CSharp.Symbol)obj, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10110, 16537, 16566);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10110, 16362, 16648);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10110, 16362, 16648);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10110, 16660, 16755);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10110, 16718, 16744);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetHashCode(), 10110, 16725, 16743);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10110, 16660, 16755);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10110, 16660, 16755);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10110, 16660, 16755);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
        f_10110_2269_2288()
        {
            var return_v = TypeWithAnnotations;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10110, 2269, 2288);
            return return_v;
        }


        bool
        f_10110_3424_3433_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10110, 3424, 3433);
            return return_v;
        }


        bool
        f_10110_16203_16218(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
        this_param)
        {
            var return_v = this_param.IsVolatile;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10110, 16203, 16218);
            return return_v;
        }

    }
}
