// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Threading;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal abstract partial class ConversionsBase
    {
        private const int
        MaximumRecursionDepth = 50
        ;

        protected readonly AssemblySymbol corLibrary;

        protected readonly int currentRecursionDepth;

        internal readonly bool IncludeNullability;

        private ConversionsBase _lazyOtherNullability;

        protected ConversionsBase(AssemblySymbol corLibrary, int currentRecursionDepth, bool includeNullability, ConversionsBase otherNullabilityOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10843, 1147, 1833);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 734, 744);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 778, 799);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 835, 853);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 1113, 1134);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 1313, 1354);

                f_10843_1313_1353((object)corLibrary != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 1368, 1474);

                f_10843_1368_1473(otherNullabilityOpt == null || (DynAbs.Tracing.TraceSender.Expression_False(10843, 1381, 1472) || includeNullability != otherNullabilityOpt.IncludeNullability));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 1488, 1600);

                f_10843_1488_1599(otherNullabilityOpt == null || (DynAbs.Tracing.TraceSender.Expression_False(10843, 1501, 1598) || currentRecursionDepth == otherNullabilityOpt.currentRecursionDepth));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 1616, 1645);

                this.corLibrary = corLibrary;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 1659, 1710);

                this.currentRecursionDepth = currentRecursionDepth;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 1724, 1764);

                IncludeNullability = includeNullability;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 1778, 1822);

                _lazyOtherNullability = otherNullabilityOpt;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10843, 1147, 1833);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 1147, 1833);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 1147, 1833);
            }
        }

        internal ConversionsBase WithNullability(bool includeNullability)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 2062, 2680);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 2152, 2257) || true) && (IncludeNullability == includeNullability)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 2152, 2257);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 2230, 2242);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 2152, 2257);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 2271, 2455) || true) && (_lazyOtherNullability == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 2271, 2455);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 2338, 2440);

                    f_10843_2338_2439(ref _lazyOtherNullability, f_10843_2393_2432(this, includeNullability), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 2271, 2455);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 2469, 2546);

                f_10843_2469_2545(_lazyOtherNullability.IncludeNullability == includeNullability);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 2560, 2626);

                f_10843_2560_2625(_lazyOtherNullability._lazyOtherNullability == this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 2640, 2669);

                return _lazyOtherNullability;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 2062, 2680);

                Microsoft.CodeAnalysis.CSharp.ConversionsBase
                f_10843_2393_2432(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, bool
                includeNullability)
                {
                    var return_v = this_param.WithNullabilityCore(includeNullability);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 2393, 2432);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionsBase?
                f_10843_2338_2439(ref Microsoft.CodeAnalysis.CSharp.ConversionsBase?
                location1, Microsoft.CodeAnalysis.CSharp.ConversionsBase
                value, Microsoft.CodeAnalysis.CSharp.ConversionsBase?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 2338, 2439);
                    return return_v;
                }


                int
                f_10843_2469_2545(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 2469, 2545);
                    return 0;
                }


                int
                f_10843_2560_2625(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 2560, 2625);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 2062, 2680);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 2062, 2680);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected abstract ConversionsBase WithNullabilityCore(bool includeNullability);

        public abstract Conversion GetMethodGroupDelegateConversion(BoundMethodGroup source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics);

        public abstract Conversion GetMethodGroupFunctionPointerConversion(BoundMethodGroup source, FunctionPointerTypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics);

        public abstract Conversion GetStackAllocConversion(BoundStackAllocArrayCreation sourceExpression, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics);

        protected abstract ConversionsBase CreateInstance(int currentRecursionDepth);

        protected abstract Conversion GetInterpolatedStringConversion(BoundInterpolatedString source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics);

        internal AssemblySymbol CorLibrary
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 3630, 3656);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 3636, 3654);

                    return corLibrary;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 3630, 3656);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 3593, 3658);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 3593, 3658);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Conversion ClassifyImplicitConversionFromExpression(BoundExpression sourceExpression, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 3872, 6646);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 4061, 4100);

                f_10843_4061_4099(sourceExpression != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 4114, 4156);

                f_10843_4114_4155((object)destination != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 4172, 4211);

                var
                sourceType = f_10843_4189_4210(sourceExpression)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 4336, 4500) || true) && ((object)sourceType != null && (DynAbs.Tracing.TraceSender.Expression_True(10843, 4340, 4424) && f_10843_4370_4424(this, sourceType, destination)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 4336, 4500);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 4458, 4485);

                    return Conversion.Identity;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 4336, 4500);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 4516, 4655);

                Conversion
                conversion = f_10843_4540_4654(this, sourceExpression, sourceType, destination, ref useSiteDiagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 4669, 4757) || true) && (conversion.Exists)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 4669, 4757);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 4724, 4742);

                    return conversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 4669, 4757);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 4773, 5544) || true) && ((object)sourceType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 4773, 5544);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 4909, 4985);

                    Conversion
                    fastConversion = f_10843_4937_4984(sourceType, destination)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 5003, 5529) || true) && (fastConversion.Exists)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 5003, 5529);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 5070, 5194) || true) && (fastConversion.IsImplicit)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 5070, 5194);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 5149, 5171);

                            return fastConversion;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 5070, 5194);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 5003, 5529);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 5003, 5529);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 5276, 5376);

                        conversion = f_10843_5289_5375(this, sourceType, destination, ref useSiteDiagnostics);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 5398, 5510) || true) && (conversion.Exists)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 5398, 5510);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 5469, 5487);

                            return conversion;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 5398, 5510);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 5003, 5529);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 4773, 5544);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 5560, 5673);

                conversion = f_10843_5573_5672(this, sourceExpression, sourceType, destination, ref useSiteDiagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 5687, 5775) || true) && (conversion.Exists)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 5687, 5775);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 5742, 5760);

                    return conversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 5687, 5775);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 6324, 6422);

                conversion = f_10843_6337_6421(this, sourceExpression, destination, ref useSiteDiagnostics);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 6436, 6524) || true) && (conversion.Exists)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 6436, 6524);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 6491, 6509);

                    return conversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 6436, 6524);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 6538, 6635);

                return f_10843_6545_6634(this, sourceExpression, destination, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 3872, 6646);

                int
                f_10843_4061_4099(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 4061, 4099);
                    return 0;
                }


                int
                f_10843_4114_4155(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 4114, 4155);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10843_4189_4210(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 4189, 4210);
                    return return_v;
                }


                bool
                f_10843_4370_4424(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type2)
                {
                    var return_v = this_param.HasIdentityConversionInternal(type1, type2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 4370, 4424);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_4540_4654(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyImplicitBuiltInConversionFromExpression(sourceExpression, source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 4540, 4654);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_4937_4984(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                target)
                {
                    var return_v = FastClassifyConversion(source, target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 4937, 4984);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_5289_5375(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyImplicitBuiltInConversionSlow(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 5289, 5375);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_5573_5672(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.GetImplicitUserDefinedConversion(sourceExpression, source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 5573, 5672);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_6337_6421(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.GetSwitchExpressionConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 6337, 6421);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_6545_6634(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.GetConditionalExpressionConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 6545, 6634);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 3872, 6646);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 3872, 6646);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Conversion ClassifyImplicitConversionFromType(TypeSymbol source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 6854, 8071);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 7022, 7059);

                f_10843_7022_7058((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 7073, 7115);

                f_10843_7073_7114((object)destination != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 7212, 7342) || true) && (f_10843_7216_7266(this, source, destination))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 7212, 7342);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 7300, 7327);

                    return Conversion.Identity;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 7212, 7342);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 7426, 7498);

                Conversion
                fastConversion = f_10843_7454_7497(source, destination)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 7512, 7953) || true) && (fastConversion.Exists)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 7512, 7953);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 7571, 7647);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10843, 7578, 7603) || ((fastConversion.IsImplicit && DynAbs.Tracing.TraceSender.Conditional_F2(10843, 7606, 7620)) || DynAbs.Tracing.TraceSender.Conditional_F3(10843, 7623, 7646))) ? fastConversion : Conversion.NoConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 7512, 7953);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 7512, 7953);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 7713, 7820);

                    Conversion
                    conversion = f_10843_7737_7819(this, source, destination, ref useSiteDiagnostics)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 7838, 7938) || true) && (conversion.Exists)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 7838, 7938);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 7901, 7919);

                        return conversion;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 7838, 7938);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 7512, 7953);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 7969, 8060);

                return f_10843_7976_8059(this, null, source, destination, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 6854, 8071);

                int
                f_10843_7022_7058(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 7022, 7058);
                    return 0;
                }


                int
                f_10843_7073_7114(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 7073, 7114);
                    return 0;
                }


                bool
                f_10843_7216_7266(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type2)
                {
                    var return_v = this_param.HasIdentityConversionInternal(type1, type2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 7216, 7266);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_7454_7497(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                target)
                {
                    var return_v = FastClassifyConversion(source, target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 7454, 7497);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_7737_7819(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyImplicitBuiltInConversionSlow(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 7737, 7819);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_7976_8059(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.GetImplicitUserDefinedConversion(sourceExpression, source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 7976, 8059);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 6854, 8071);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 6854, 8071);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Conversion ClassifyConversionFromExpressionType(TypeSymbol source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 8759, 9391);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 8929, 8966);

                f_10843_8929_8965((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 8980, 9022);

                f_10843_8980_9021((object)destination != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 9135, 9285) || true) && (f_10843_9139_9202(source, destination))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 9135, 9285);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 9236, 9270);

                    return Conversion.ImplicitDynamic;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 9135, 9285);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 9301, 9380);

                return f_10843_9308_9379(this, source, destination, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 8759, 9391);

                int
                f_10843_8929_8965(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 8929, 8965);
                    return 0;
                }


                int
                f_10843_8980_9021(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 8980, 9021);
                    return 0;
                }


                bool
                f_10843_9139_9202(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                expressionType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination)
                {
                    var return_v = HasImplicitDynamicConversionFromExpression(expressionType, destination);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 9139, 9202);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_9308_9379(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyConversionFromType(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 9308, 9379);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 8759, 9391);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 8759, 9391);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool TryGetVoidConversion(TypeSymbol source, TypeSymbol destination, out Conversion conversion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10843, 9403, 10550);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 9538, 9604);

                var
                sourceIsVoid = f_10843_9557_9576_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(source, 10843, 9557, 9576)?.SpecialType) == SpecialType.System_Void
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 9618, 9686);

                var
                destIsVoid = f_10843_9635_9658(destination) == SpecialType.System_Void
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 10067, 10209) || true) && (sourceIsVoid && (DynAbs.Tracing.TraceSender.Expression_True(10843, 10071, 10097) && destIsVoid))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 10067, 10209);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 10131, 10164);

                    conversion = Conversion.Identity;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 10182, 10194);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 10067, 10209);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 10329, 10475) || true) && (sourceIsVoid || (DynAbs.Tracing.TraceSender.Expression_False(10843, 10333, 10359) || destIsVoid))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 10329, 10475);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 10393, 10430);

                    conversion = Conversion.NoConversion;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 10448, 10460);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 10329, 10475);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 10491, 10512);

                conversion = default;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 10526, 10539);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10843, 9403, 10550);

                Microsoft.CodeAnalysis.SpecialType?
                f_10843_9557_9576_M(Microsoft.CodeAnalysis.SpecialType?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 9557, 9576);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10843_9635_9658(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 9635, 9658);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 9403, 10550);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 9403, 10550);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Conversion ClassifyConversionFromExpression(BoundExpression sourceExpression, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics, bool forCast = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 11152, 12160);
                Microsoft.CodeAnalysis.CSharp.Conversion conversion = default(Microsoft.CodeAnalysis.CSharp.Conversion);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 11355, 11394);

                f_10843_11355_11393(sourceExpression != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 11408, 11450);

                f_10843_11408_11449((object)destination != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 11466, 11613) || true) && (f_10843_11470_11546(f_10843_11491_11512(sourceExpression), destination, out conversion))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 11466, 11613);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 11580, 11598);

                    return conversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 11466, 11613);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 11629, 11791) || true) && (forCast)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 11629, 11791);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 11674, 11776);

                    return f_10843_11681_11775(this, sourceExpression, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 11629, 11791);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 11807, 11916);

                var
                result = f_10843_11820_11915(this, sourceExpression, destination, ref useSiteDiagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 11930, 12010) || true) && (result.Exists)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 11930, 12010);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 11981, 11995);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 11930, 12010);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 12026, 12149);

                return f_10843_12033_12148(this, sourceExpression, destination, ref useSiteDiagnostics, forCast: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 11152, 12160);

                int
                f_10843_11355_11393(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 11355, 11393);
                    return 0;
                }


                int
                f_10843_11408_11449(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 11408, 11449);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10843_11491_11512(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 11491, 11512);
                    return return_v;
                }


                bool
                f_10843_11470_11546(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, out Microsoft.CodeAnalysis.CSharp.Conversion
                conversion)
                {
                    var return_v = TryGetVoidConversion(source, destination, out conversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 11470, 11546);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_11681_11775(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyConversionFromExpressionForCast(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 11681, 11775);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_11820_11915(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyImplicitConversionFromExpression(sourceExpression, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 11820, 11915);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_12033_12148(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, bool
                forCast)
                {
                    var return_v = this_param.ClassifyExplicitOnlyConversionFromExpression(sourceExpression, destination, ref useSiteDiagnostics, forCast: forCast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 12033, 12148);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 11152, 12160);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 11152, 12160);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Conversion ClassifyConversionFromType(TypeSymbol source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics, bool forCast = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 12750, 14477);
                Microsoft.CodeAnalysis.CSharp.Conversion voidConversion = default(Microsoft.CodeAnalysis.CSharp.Conversion);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 12932, 12969);

                f_10843_12932_12968((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 12983, 13025);

                f_10843_12983_13024((object)destination != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 13041, 13181) || true) && (f_10843_13045_13110(source, destination, out voidConversion))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 13041, 13181);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 13144, 13166);

                    return voidConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 13041, 13181);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 13197, 13343) || true) && (forCast)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 13197, 13343);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 13242, 13328);

                    return f_10843_13249_13327(this, source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 13197, 13343);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 13427, 13499);

                Conversion
                fastConversion = f_10843_13455_13498(source, destination)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 13513, 13903) || true) && (fastConversion.Exists)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 13513, 13903);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 13572, 13594);

                    return fastConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 13513, 13903);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 13513, 13903);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 13660, 13768);

                    Conversion
                    conversion1 = f_10843_13685_13767(this, source, destination, ref useSiteDiagnostics)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 13786, 13888) || true) && (conversion1.Exists)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 13786, 13888);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 13850, 13869);

                        return conversion1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 13786, 13888);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 13513, 13903);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 13919, 14027);

                Conversion
                conversion = f_10843_13943_14026(this, null, source, destination, ref useSiteDiagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 14041, 14129) || true) && (conversion.Exists)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 14041, 14129);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 14096, 14114);

                    return conversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 14041, 14129);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 14145, 14257);

                conversion = f_10843_14158_14256(this, source, destination, ref useSiteDiagnostics, forCast: false);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 14271, 14359) || true) && (conversion.Exists)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 14271, 14359);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 14326, 14344);

                    return conversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 14271, 14359);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 14375, 14466);

                return f_10843_14382_14465(this, null, source, destination, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 12750, 14477);

                int
                f_10843_12932_12968(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 12932, 12968);
                    return 0;
                }


                int
                f_10843_12983_13024(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 12983, 13024);
                    return 0;
                }


                bool
                f_10843_13045_13110(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, out Microsoft.CodeAnalysis.CSharp.Conversion
                conversion)
                {
                    var return_v = TryGetVoidConversion(source, destination, out conversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 13045, 13110);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_13249_13327(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyConversionFromTypeForCast(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 13249, 13327);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_13455_13498(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                target)
                {
                    var return_v = FastClassifyConversion(source, target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 13455, 13498);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_13685_13767(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyImplicitBuiltInConversionSlow(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 13685, 13767);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_13943_14026(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.GetImplicitUserDefinedConversion(sourceExpression, source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 13943, 14026);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_14158_14256(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, bool
                forCast)
                {
                    var return_v = this_param.ClassifyExplicitBuiltInOnlyConversion(source, destination, ref useSiteDiagnostics, forCast: forCast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 14158, 14256);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_14382_14465(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.GetExplicitUserDefinedConversion(sourceExpression, source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 14382, 14465);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 12750, 14477);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 12750, 14477);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Conversion ClassifyConversionFromExpressionForCast(BoundExpression source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 15290, 17551);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 15469, 15498);

                f_10843_15469_15497(source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 15512, 15554);

                f_10843_15512_15553((object)destination != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 15570, 15688);

                Conversion
                implicitConversion = f_10843_15602_15687(this, source, destination, ref useSiteDiagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 15702, 15870) || true) && (implicitConversion.Exists && (DynAbs.Tracing.TraceSender.Expression_True(10843, 15706, 15795) && !f_10843_15736_15795(implicitConversion)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 15702, 15870);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 15829, 15855);

                    return implicitConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 15702, 15870);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 15886, 16023);

                Conversion
                explicitConversion = f_10843_15918_16022(this, source, destination, ref useSiteDiagnostics, forCast: true)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 16037, 16141) || true) && (explicitConversion.Exists)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 16037, 16141);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 16100, 16126);

                    return explicitConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 16037, 16141);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 17514, 17540);

                return implicitConversion;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 15290, 17551);

                int
                f_10843_15469_15497(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 15469, 15497);
                    return 0;
                }


                int
                f_10843_15512_15553(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 15512, 15553);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_15602_15687(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyImplicitConversionFromExpression(sourceExpression, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 15602, 15687);
                    return return_v;
                }


                bool
                f_10843_15736_15795(Microsoft.CodeAnalysis.CSharp.Conversion
                implicitConversion)
                {
                    var return_v = ExplicitConversionMayDifferFromImplicit(implicitConversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 15736, 15795);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_15918_16022(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, bool
                forCast)
                {
                    var return_v = this_param.ClassifyExplicitOnlyConversionFromExpression(sourceExpression, destination, ref useSiteDiagnostics, forCast: forCast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 15918, 16022);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 15290, 17551);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 15290, 17551);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Conversion ClassifyConversionFromTypeForCast(TypeSymbol source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 18107, 20459);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 18275, 18312);

                f_10843_18275_18311((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 18326, 18368);

                f_10843_18326_18367((object)destination != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 18452, 18524);

                Conversion
                fastConversion = f_10843_18480_18523(source, destination)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 18538, 18634) || true) && (fastConversion.Exists)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 18538, 18634);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 18597, 18619);

                    return fastConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 18538, 18634);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 18650, 18772);

                Conversion
                implicitBuiltInConversion = f_10843_18689_18771(this, source, destination, ref useSiteDiagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 18786, 18975) || true) && (implicitBuiltInConversion.Exists && (DynAbs.Tracing.TraceSender.Expression_True(10843, 18790, 18893) && !f_10843_18827_18893(implicitBuiltInConversion)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 18786, 18975);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 18927, 18960);

                    return implicitBuiltInConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 18786, 18975);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 18991, 19128);

                Conversion
                explicitBuiltInConversion = f_10843_19030_19127(this, source, destination, ref useSiteDiagnostics, forCast: true)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 19142, 19260) || true) && (explicitBuiltInConversion.Exists)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 19142, 19260);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 19212, 19245);

                    return explicitBuiltInConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 19142, 19260);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 19276, 19394) || true) && (implicitBuiltInConversion.Exists)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 19276, 19394);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 19346, 19379);

                    return implicitBuiltInConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 19276, 19394);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 20138, 20239);

                var
                conversion = f_10843_20155_20238(this, null, source, destination, ref useSiteDiagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 20253, 20341) || true) && (conversion.Exists)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 20253, 20341);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 20308, 20326);

                    return conversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 20253, 20341);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 20357, 20448);

                return f_10843_20364_20447(this, null, source, destination, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 18107, 20459);

                int
                f_10843_18275_18311(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 18275, 18311);
                    return 0;
                }


                int
                f_10843_18326_18367(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 18326, 18367);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_18480_18523(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                target)
                {
                    var return_v = FastClassifyConversion(source, target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 18480, 18523);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_18689_18771(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyImplicitBuiltInConversionSlow(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 18689, 18771);
                    return return_v;
                }


                bool
                f_10843_18827_18893(Microsoft.CodeAnalysis.CSharp.Conversion
                implicitConversion)
                {
                    var return_v = ExplicitConversionMayDifferFromImplicit(implicitConversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 18827, 18893);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_19030_19127(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, bool
                forCast)
                {
                    var return_v = this_param.ClassifyExplicitBuiltInOnlyConversion(source, destination, ref useSiteDiagnostics, forCast: forCast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 19030, 19127);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_20155_20238(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.GetExplicitUserDefinedConversion(sourceExpression, source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 20155, 20238);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_20364_20447(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.GetImplicitUserDefinedConversion(sourceExpression, source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 20364, 20447);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 18107, 20459);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 18107, 20459);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Conversion FastClassifyConversion(TypeSymbol source, TypeSymbol target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10843, 20778, 21321);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 20888, 20967);

                ConversionKind
                convKind = f_10843_20914_20966(source, target)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 20981, 21173) || true) && (convKind != ConversionKind.ImplicitNullable && (DynAbs.Tracing.TraceSender.Expression_True(10843, 20985, 21075) && convKind != ConversionKind.ExplicitNullable))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 20981, 21173);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 21109, 21158);

                    return Conversion.GetTrivialConversion(convKind);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 20981, 21173);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 21189, 21310);

                return Conversion.MakeNullableConversion(convKind, f_10843_21240_21308(f_10843_21263_21284(source), f_10843_21286_21307(target)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10843, 20778, 21321);

                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10843_20914_20966(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                target)
                {
                    var return_v = ConversionEasyOut.ClassifyConversion(source, target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 20914, 20966);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10843_21263_21284(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 21263, 21284);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10843_21286_21307(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 21286, 21307);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_21240_21308(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                target)
                {
                    var return_v = FastClassifyConversion(source, target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 21240, 21308);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 20778, 21321);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 20778, 21321);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Conversion ClassifyBuiltInConversion(TypeSymbol source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 21333, 22275);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 21492, 21529);

                f_10843_21492_21528((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 21543, 21585);

                f_10843_21543_21584((object)destination != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 21669, 21741);

                Conversion
                fastConversion = f_10843_21697_21740(source, destination)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 21755, 22142) || true) && (fastConversion.Exists)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 21755, 22142);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 21814, 21836);

                    return fastConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 21755, 22142);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 21755, 22142);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 21902, 22009);

                    Conversion
                    conversion = f_10843_21926_22008(this, source, destination, ref useSiteDiagnostics)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 22027, 22127) || true) && (conversion.Exists)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 22027, 22127);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 22090, 22108);

                        return conversion;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 22027, 22127);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 21755, 22142);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 22158, 22264);

                return f_10843_22165_22263(this, source, destination, ref useSiteDiagnostics, forCast: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 21333, 22275);

                int
                f_10843_21492_21528(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 21492, 21528);
                    return 0;
                }


                int
                f_10843_21543_21584(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 21543, 21584);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_21697_21740(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                target)
                {
                    var return_v = FastClassifyConversion(source, target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 21697, 21740);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_21926_22008(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyImplicitBuiltInConversionSlow(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 21926, 22008);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_22165_22263(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, bool
                forCast)
                {
                    var return_v = this_param.ClassifyExplicitBuiltInOnlyConversion(source, destination, ref useSiteDiagnostics, forCast: forCast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 22165, 22263);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 21333, 22275);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 21333, 22275);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Conversion ClassifyStandardConversion(BoundExpression sourceExpression, TypeSymbol source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 22621, 25230);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 22815, 22880);

                f_10843_22815_22879(sourceExpression != null || (DynAbs.Tracing.TraceSender.Expression_False(10843, 22828, 22878) || (object)source != null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 22894, 22936);

                f_10843_22894_22935((object)destination != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 24744, 24866);

                Conversion
                conversion = f_10843_24768_24865(this, sourceExpression, source, destination, ref useSiteDiagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 24880, 24968) || true) && (conversion.Exists)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 24880, 24968);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 24935, 24953);

                    return conversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 24880, 24968);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 24984, 25172) || true) && ((object)source != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 24984, 25172);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 25044, 25157);

                    return f_10843_25051_25156(this, source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 24984, 25172);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 25188, 25219);

                return Conversion.NoConversion;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 22621, 25230);

                int
                f_10843_22815_22879(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 22815, 22879);
                    return 0;
                }


                int
                f_10843_22894_22935(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 22894, 22935);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_24768_24865(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyStandardImplicitConversion(sourceExpression, source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 24768, 24865);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_25051_25156(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.DeriveStandardExplicitFromOppositeStandardImplicitConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 25051, 25156);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 22621, 25230);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 22621, 25230);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Conversion ClassifyStandardImplicitConversion(BoundExpression sourceExpression, TypeSymbol source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 25242, 27836);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 25445, 25510);

                f_10843_25445_25509(sourceExpression != null || (DynAbs.Tracing.TraceSender.Expression_False(10843, 25458, 25508) || (object)source != null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 25524, 25614);

                f_10843_25524_25613(sourceExpression == null || (DynAbs.Tracing.TraceSender.Expression_False(10843, 25537, 25612) || (object)f_10843_25573_25594(sourceExpression) == (object)source));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 25628, 25670);

                f_10843_25628_25669((object)destination != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 27363, 27498);

                Conversion
                conversion = f_10843_27387_27497(this, sourceExpression, source, destination, ref useSiteDiagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 27512, 27600) || true) && (conversion.Exists)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 27512, 27600);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 27567, 27585);

                    return conversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 27512, 27600);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 27616, 27778) || true) && ((object)source != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 27616, 27778);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 27676, 27763);

                    return f_10843_27683_27762(this, source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 27616, 27778);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 27794, 27825);

                return Conversion.NoConversion;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 25242, 27836);

                int
                f_10843_25445_25509(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 25445, 25509);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10843_25573_25594(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 25573, 25594);
                    return return_v;
                }


                int
                f_10843_25524_25613(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 25524, 25613);
                    return 0;
                }


                int
                f_10843_25628_25669(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 25628, 25669);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_27387_27497(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyImplicitBuiltInConversionFromExpression(sourceExpression, source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 27387, 27497);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_27683_27762(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyStandardImplicitConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 27683, 27762);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 25242, 27836);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 25242, 27836);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Conversion ClassifyStandardImplicitConversion(TypeSymbol source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 27848, 29602);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 28017, 28054);

                f_10843_28017_28053((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 28068, 28110);

                f_10843_28068_28109((object)destination != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 28126, 28256) || true) && (f_10843_28130_28180(this, source, destination))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 28126, 28256);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 28214, 28241);

                    return Conversion.Identity;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 28126, 28256);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 28272, 28408) || true) && (f_10843_28276_28325(source, destination))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 28272, 28408);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 28359, 28393);

                    return Conversion.ImplicitNumeric;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 28272, 28408);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 28424, 28529);

                var
                nullableConversion = f_10843_28449_28528(this, source, destination, ref useSiteDiagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 28543, 28647) || true) && (nullableConversion.Exists)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 28543, 28647);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 28606, 28632);

                    return nullableConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 28543, 28647);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 28663, 28827) || true) && (f_10843_28667_28742(this, source, destination, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 28663, 28827);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 28776, 28812);

                    return Conversion.ImplicitReference;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 28663, 28827);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 28843, 28985) || true) && (f_10843_28847_28911(this, source, destination, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 28843, 28985);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 28945, 28970);

                    return Conversion.Boxing;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 28843, 28985);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 29001, 29141) || true) && (f_10843_29005_29060(source, destination))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 29001, 29141);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 29094, 29126);

                    return Conversion.PointerToVoid;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 29001, 29141);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 29157, 29317) || true) && (f_10843_29161_29234(this, source, destination, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 29157, 29317);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 29268, 29302);

                    return Conversion.ImplicitPointer;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 29157, 29317);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 29333, 29432);

                var
                tupleConversion = f_10843_29355_29431(this, source, destination, ref useSiteDiagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 29446, 29544) || true) && (tupleConversion.Exists)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 29446, 29544);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 29506, 29529);

                    return tupleConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 29446, 29544);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 29560, 29591);

                return Conversion.NoConversion;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 27848, 29602);

                int
                f_10843_28017_28053(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 28017, 28053);
                    return 0;
                }


                int
                f_10843_28068_28109(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 28068, 28109);
                    return 0;
                }


                bool
                f_10843_28130_28180(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type2)
                {
                    var return_v = this_param.HasIdentityConversionInternal(type1, type2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 28130, 28180);
                    return return_v;
                }


                bool
                f_10843_28276_28325(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination)
                {
                    var return_v = HasImplicitNumericConversion(source, destination);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 28276, 28325);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_28449_28528(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyImplicitNullableConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 28449, 28528);
                    return return_v;
                }


                bool
                f_10843_28667_28742(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasImplicitReferenceConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 28667, 28742);
                    return return_v;
                }


                bool
                f_10843_28847_28911(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasBoxingConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 28847, 28911);
                    return return_v;
                }


                bool
                f_10843_29005_29060(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination)
                {
                    var return_v = HasImplicitPointerToVoidConversion(source, destination);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 29005, 29060);
                    return return_v;
                }


                bool
                f_10843_29161_29234(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasImplicitPointerConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 29161, 29234);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_29355_29431(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyImplicitTupleConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 29355, 29431);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 27848, 29602);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 27848, 29602);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Conversion ClassifyImplicitBuiltInConversionSlow(TypeSymbol source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 29614, 30306);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 29786, 29823);

                f_10843_29786_29822((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 29837, 29879);

                f_10843_29837_29878((object)destination != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 29895, 30026) || true) && (f_10843_29899_29918(source) || (DynAbs.Tracing.TraceSender.Expression_False(10843, 29899, 29946) || f_10843_29922_29946(destination)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 29895, 30026);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 29980, 30011);

                    return Conversion.NoConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 29895, 30026);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 30042, 30146);

                Conversion
                conversion = f_10843_30066_30145(this, source, destination, ref useSiteDiagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 30160, 30248) || true) && (conversion.Exists)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 30160, 30248);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 30215, 30233);

                    return conversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 30160, 30248);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 30264, 30295);

                return Conversion.NoConversion;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 29614, 30306);

                int
                f_10843_29786_29822(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 29786, 29822);
                    return 0;
                }


                int
                f_10843_29837_29878(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 29837, 29878);
                    return 0;
                }


                bool
                f_10843_29899_29918(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 29899, 29918);
                    return return_v;
                }


                bool
                f_10843_29922_29946(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 29922, 29946);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_30066_30145(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyStandardImplicitConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 30066, 30145);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 29614, 30306);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 29614, 30306);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Conversion GetImplicitUserDefinedConversion(BoundExpression sourceExpression, TypeSymbol source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 30318, 30726);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 30519, 30643);

                var
                conversionResult = f_10843_30542_30642(this, sourceExpression, source, destination, ref useSiteDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 30657, 30715);

                return f_10843_30664_30714(conversionResult, isImplicit: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 30318, 30726);

                Microsoft.CodeAnalysis.CSharp.UserDefinedConversionResult
                f_10843_30542_30642(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.AnalyzeImplicitUserDefinedConversions(sourceExpression, source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 30542, 30642);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_30664_30714(Microsoft.CodeAnalysis.CSharp.UserDefinedConversionResult
                conversionResult, bool
                isImplicit)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(conversionResult, isImplicit: isImplicit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 30664, 30714);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 30318, 30726);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 30318, 30726);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Conversion ClassifyExplicitBuiltInOnlyConversion(TypeSymbol source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics, bool forCast)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 30738, 33467);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 30924, 30961);

                f_10843_30924_30960((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 30975, 31017);

                f_10843_30975_31016((object)destination != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 31033, 31164) || true) && (f_10843_31037_31056(source) || (DynAbs.Tracing.TraceSender.Expression_False(10843, 31037, 31084) || f_10843_31060_31084(destination)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 31033, 31164);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 31118, 31149);

                    return Conversion.NoConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 31033, 31164);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 31336, 31401);

                f_10843_31336_31400(!f_10843_31350_31399(source, destination));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 31613, 31738) || true) && (f_10843_31617_31664(source, destination))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 31613, 31738);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 31698, 31723);

                    return Conversion.IntPtr;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 31613, 31738);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 31754, 31898) || true) && (f_10843_31758_31811(source, destination))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 31754, 31898);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 31845, 31883);

                    return Conversion.ExplicitEnumeration;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 31754, 31898);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 31914, 32028);

                var
                nullableConversion = f_10843_31939_32027(this, source, destination, ref useSiteDiagnostics, forCast)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 32042, 32146) || true) && (nullableConversion.Exists)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 32042, 32146);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 32105, 32131);

                    return nullableConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 32042, 32146);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 32162, 32397) || true) && (f_10843_32166_32241(this, source, destination, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 32162, 32397);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 32275, 32382);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10843, 32282, 32321) || (((f_10843_32283_32294(source) == SymbolKind.DynamicType) && DynAbs.Tracing.TraceSender.Conditional_F2(10843, 32324, 32350)) || DynAbs.Tracing.TraceSender.Conditional_F3(10843, 32353, 32381))) ? Conversion.ExplicitDynamic : Conversion.ExplicitReference;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 32162, 32397);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 32413, 32559) || true) && (f_10843_32417_32483(this, source, destination, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 32413, 32559);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 32517, 32544);

                    return Conversion.Unboxing;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 32413, 32559);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 32575, 32683);

                var
                tupleConversion = f_10843_32597_32682(this, source, destination, ref useSiteDiagnostics, forCast)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 32697, 32795) || true) && (tupleConversion.Exists)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 32697, 32795);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 32757, 32780);

                    return tupleConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 32697, 32795);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 32811, 32949) || true) && (f_10843_32815_32865(source, destination))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 32811, 32949);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 32899, 32934);

                    return Conversion.PointerToPointer;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 32811, 32949);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 32965, 33103) || true) && (f_10843_32969_33019(source, destination))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 32965, 33103);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 33053, 33088);

                    return Conversion.PointerToInteger;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 32965, 33103);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 33119, 33257) || true) && (f_10843_33123_33173(source, destination))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 33119, 33257);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 33207, 33242);

                    return Conversion.IntegerToPointer;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 33119, 33257);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 33273, 33409) || true) && (f_10843_33277_33326(source, destination))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 33273, 33409);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 33360, 33394);

                    return Conversion.ExplicitDynamic;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 33273, 33409);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 33425, 33456);

                return Conversion.NoConversion;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 30738, 33467);

                int
                f_10843_30924_30960(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 30924, 30960);
                    return 0;
                }


                int
                f_10843_30975_31016(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 30975, 31016);
                    return 0;
                }


                bool
                f_10843_31037_31056(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 31037, 31056);
                    return return_v;
                }


                bool
                f_10843_31060_31084(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsVoidType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 31060, 31084);
                    return return_v;
                }


                bool
                f_10843_31350_31399(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination)
                {
                    var return_v = HasExplicitNumericConversion(source, destination);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 31350, 31399);
                    return return_v;
                }


                int
                f_10843_31336_31400(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 31336, 31400);
                    return 0;
                }


                bool
                f_10843_31617_31664(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                target)
                {
                    var return_v = HasSpecialIntPtrConversion(source, target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 31617, 31664);
                    return return_v;
                }


                bool
                f_10843_31758_31811(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination)
                {
                    var return_v = HasExplicitEnumerationConversion(source, destination);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 31758, 31811);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_31939_32027(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, bool
                forCast)
                {
                    var return_v = this_param.ClassifyExplicitNullableConversion(source, destination, ref useSiteDiagnostics, forCast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 31939, 32027);
                    return return_v;
                }


                bool
                f_10843_32166_32241(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasExplicitReferenceConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 32166, 32241);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10843_32283_32294(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 32283, 32294);
                    return return_v;
                }


                bool
                f_10843_32417_32483(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasUnboxingConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 32417, 32483);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_32597_32682(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, bool
                forCast)
                {
                    var return_v = this_param.ClassifyExplicitTupleConversion(source, destination, ref useSiteDiagnostics, forCast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 32597, 32682);
                    return return_v;
                }


                bool
                f_10843_32815_32865(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination)
                {
                    var return_v = HasPointerToPointerConversion(source, destination);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 32815, 32865);
                    return return_v;
                }


                bool
                f_10843_32969_33019(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination)
                {
                    var return_v = HasPointerToIntegerConversion(source, destination);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 32969, 33019);
                    return return_v;
                }


                bool
                f_10843_33123_33173(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination)
                {
                    var return_v = HasIntegerToPointerConversion(source, destination);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 33123, 33173);
                    return return_v;
                }


                bool
                f_10843_33277_33326(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination)
                {
                    var return_v = HasExplicitDynamicConversion(source, destination);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 33277, 33326);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 30738, 33467);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 30738, 33467);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Conversion GetExplicitUserDefinedConversion(BoundExpression sourceExpression, TypeSymbol source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 33479, 33912);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 33680, 33828);

                UserDefinedConversionResult
                conversionResult = f_10843_33727_33827(this, sourceExpression, source, destination, ref useSiteDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 33842, 33901);

                return f_10843_33849_33900(conversionResult, isImplicit: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 33479, 33912);

                Microsoft.CodeAnalysis.CSharp.UserDefinedConversionResult
                f_10843_33727_33827(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                target, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.AnalyzeExplicitUserDefinedConversions(sourceExpression, source, target, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 33727, 33827);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_33849_33900(Microsoft.CodeAnalysis.CSharp.UserDefinedConversionResult
                conversionResult, bool
                isImplicit)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(conversionResult, isImplicit: isImplicit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 33849, 33900);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 33479, 33912);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 33479, 33912);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Conversion DeriveStandardExplicitFromOppositeStandardImplicitConversion(TypeSymbol source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 33924, 36589);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 34119, 34224);

                var
                oppositeConversion = f_10843_34144_34223(this, destination, source, ref useSiteDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 34238, 34275);

                Conversion
                impliedExplicitConversion
                = default(Conversion);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 34291, 36529);

                switch (oppositeConversion.Kind)
                {

                    case ConversionKind.Identity:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 34291, 36529);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 34407, 34455);

                        impliedExplicitConversion = Conversion.Identity;
                        DynAbs.Tracing.TraceSender.TraceBreak(10843, 34477, 34483);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 34291, 36529);

                    case ConversionKind.ImplicitNumeric:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 34291, 36529);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 34559, 34614);

                        impliedExplicitConversion = Conversion.ExplicitNumeric;
                        DynAbs.Tracing.TraceSender.TraceBreak(10843, 34636, 34642);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 34291, 36529);

                    case ConversionKind.ImplicitReference:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 34291, 36529);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 34720, 34777);

                        impliedExplicitConversion = Conversion.ExplicitReference;
                        DynAbs.Tracing.TraceSender.TraceBreak(10843, 34799, 34805);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 34291, 36529);

                    case ConversionKind.Boxing:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 34291, 36529);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 34872, 34920);

                        impliedExplicitConversion = Conversion.Unboxing;
                        DynAbs.Tracing.TraceSender.TraceBreak(10843, 34942, 34948);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 34291, 36529);

                    case ConversionKind.NoConversion:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 34291, 36529);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 35021, 35073);

                        impliedExplicitConversion = Conversion.NoConversion;
                        DynAbs.Tracing.TraceSender.TraceBreak(10843, 35095, 35101);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 34291, 36529);

                    case ConversionKind.ImplicitPointerToVoid:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 34291, 36529);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 35183, 35239);

                        impliedExplicitConversion = Conversion.PointerToPointer;
                        DynAbs.Tracing.TraceSender.TraceBreak(10843, 35261, 35267);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 34291, 36529);

                    case ConversionKind.ImplicitTuple:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 34291, 36529);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 35520, 35572);

                        impliedExplicitConversion = Conversion.NoConversion;
                        DynAbs.Tracing.TraceSender.TraceBreak(10843, 35594, 35600);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 34291, 36529);

                    case ConversionKind.ImplicitNullable:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 34291, 36529);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 35679, 35722);

                        var
                        strippedSource = f_10843_35700_35721(source)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 35744, 35797);

                        var
                        strippedDestination = f_10843_35770_35796(destination)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 35819, 35968);

                        var
                        underlyingConversion = f_10843_35846_35967(this, strippedSource, strippedDestination, ref useSiteDiagnostics)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 36145, 36368);

                        impliedExplicitConversion = (DynAbs.Tracing.TraceSender.Conditional_F1(10843, 36173, 36200) || ((underlyingConversion.Exists && DynAbs.Tracing.TraceSender.Conditional_F2(10843, 36228, 36316)) || DynAbs.Tracing.TraceSender.Conditional_F3(10843, 36344, 36367))) ? Conversion.MakeNullableConversion(ConversionKind.ExplicitNullable, underlyingConversion) : Conversion.NoConversion;
                        DynAbs.Tracing.TraceSender.TraceBreak(10843, 36392, 36398);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 34291, 36529);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 34291, 36529);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 36448, 36514);

                        throw f_10843_36454_36513(oppositeConversion.Kind);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 34291, 36529);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 36545, 36578);

                return impliedExplicitConversion;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 33924, 36589);

                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_34144_34223(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyStandardImplicitConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 34144, 34223);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10843_35700_35721(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 35700, 35721);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10843_35770_35796(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 35770, 35796);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_35846_35967(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.DeriveStandardExplicitFromOppositeStandardImplicitConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 35846, 35967);
                    return return_v;
                }


                System.Exception
                f_10843_36454_36513(Microsoft.CodeAnalysis.CSharp.ConversionKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 36454, 36513);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 33924, 36589);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 33924, 36589);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool IsBaseInterface(TypeSymbol baseType, TypeSymbol derivedType, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 37253, 38075);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 37398, 37437);

                f_10843_37398_37436((object)baseType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 37451, 37493);

                f_10843_37451_37492((object)derivedType != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 37509, 37602) || true) && (!f_10843_37514_37540(baseType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 37509, 37602);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 37574, 37587);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 37509, 37602);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 37618, 37657);

                var
                d = derivedType as NamedTypeSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 37671, 37754) || true) && ((object)d == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 37671, 37754);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 37726, 37739);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 37671, 37754);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 37770, 38035);
                    foreach (var iface in f_10843_37792_37863_I(f_10843_37792_37863(d, ref useSiteDiagnostics)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 37770, 38035);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 37897, 38020) || true) && (f_10843_37901_37947(this, iface, baseType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 37897, 38020);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 37989, 38001);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 37897, 38020);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 37770, 38035);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10843, 1, 266);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10843, 1, 266);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 38051, 38064);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 37253, 38075);

                int
                f_10843_37398_37436(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 37398, 37436);
                    return 0;
                }


                int
                f_10843_37451_37492(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 37451, 37492);
                    return 0;
                }


                bool
                f_10843_37514_37540(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 37514, 37540);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10843_37792_37863(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.AllInterfacesWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 37792, 37863);
                    return return_v;
                }


                bool
                f_10843_37901_37947(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type2)
                {
                    var return_v = this_param.HasIdentityConversionInternal((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type1, type2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 37901, 37947);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10843_37792_37863_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 37792, 37863);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 37253, 38075);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 37253, 38075);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool IsBaseClass(TypeSymbol derivedType, TypeSymbol baseType, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 38667, 39526);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 38808, 38850);

                f_10843_38808_38849((object)derivedType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 38864, 38903);

                f_10843_38864_38902((object)baseType != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 39026, 39115) || true) && (!f_10843_39031_39053(baseType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 39026, 39115);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 39087, 39100);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 39026, 39115);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 39147, 39227);

                    for (TypeSymbol
        b = f_10843_39151_39227(derivedType, ref useSiteDiagnostics)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 39131, 39486) || true) && ((object)b != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 39248, 39318)
        , b = f_10843_39252_39318(b, ref useSiteDiagnostics), DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 39131, 39486))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 39131, 39486);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 39352, 39471) || true) && (f_10843_39356_39398(this, b, baseType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 39352, 39471);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 39440, 39452);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 39352, 39471);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10843, 1, 356);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10843, 1, 356);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 39502, 39515);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 38667, 39526);

                int
                f_10843_38808_38849(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 38808, 38849);
                    return 0;
                }


                int
                f_10843_38864_38902(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 38864, 38902);
                    return 0;
                }


                bool
                f_10843_39031_39053(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsClassType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 39031, 39053);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10843_39151_39227(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.BaseTypeWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 39151, 39227);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10843_39252_39318(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.BaseTypeWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 39252, 39318);
                    return return_v;
                }


                bool
                f_10843_39356_39398(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type2)
                {
                    var return_v = this_param.HasIdentityConversionInternal(type1, type2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 39356, 39398);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 38667, 39526);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 38667, 39526);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool ExplicitConversionMayDifferFromImplicit(Conversion implicitConversion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10843, 39687, 40310);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 39802, 40299);

                switch (implicitConversion.Kind)
                {

                    case ConversionKind.ImplicitUserDefined:
                    case ConversionKind.ImplicitDynamic:
                    case ConversionKind.ImplicitTuple:
                    case ConversionKind.ImplicitTupleLiteral:
                    case ConversionKind.ImplicitNullable:
                    case ConversionKind.ConditionalExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 39802, 40299);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 40209, 40221);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 39802, 40299);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 39802, 40299);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 40271, 40284);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 39802, 40299);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10843, 39687, 40310);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 39687, 40310);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 39687, 40310);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Conversion ClassifyImplicitBuiltInConversionFromExpression(BoundExpression sourceExpression, TypeSymbol source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 40322, 45360);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 40538, 40603);

                f_10843_40538_40602(sourceExpression != null || (DynAbs.Tracing.TraceSender.Expression_False(10843, 40551, 40601) || (object)source != null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 40617, 40707);

                f_10843_40617_40706(sourceExpression == null || (DynAbs.Tracing.TraceSender.Expression_False(10843, 40630, 40705) || (object)f_10843_40666_40687(sourceExpression) == (object)source));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 40721, 40763);

                f_10843_40721_40762((object)destination != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 40779, 40929) || true) && (f_10843_40783_40846(source, destination))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 40779, 40929);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 40880, 40914);

                    return Conversion.ImplicitDynamic;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 40779, 40929);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 41101, 41209) || true) && (sourceExpression == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 41101, 41209);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 41163, 41194);

                    return Conversion.NoConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 41101, 41209);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 41225, 41379) || true) && (f_10843_41229_41292(sourceExpression, destination))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 41225, 41379);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 41326, 41364);

                    return Conversion.ImplicitEnumeration;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 41225, 41379);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 41395, 41496);

                var
                constantConversion = f_10843_41420_41495(sourceExpression, destination)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 41510, 41614) || true) && (constantConversion.Exists)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 41510, 41614);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 41573, 41599);

                    return constantConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 41510, 41614);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 41630, 45302);

                switch (f_10843_41638_41659(sourceExpression))
                {

                    case BoundKind.Literal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 41630, 45302);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 41738, 41827);

                        var
                        nullLiteralConversion = f_10843_41766_41826(sourceExpression, destination)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 41849, 41983) || true) && (nullLiteralConversion.Exists)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 41849, 41983);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 41931, 41960);

                            return nullLiteralConversion;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 41849, 41983);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10843, 42005, 42011);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 41630, 45302);

                    case BoundKind.DefaultLiteral:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 41630, 45302);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 42083, 42116);

                        return Conversion.DefaultLiteral;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 41630, 45302);

                    case BoundKind.ExpressionWithNullability:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 41630, 45302);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 42226, 42310);

                            var
                            innerExpression = f_10843_42248_42309(((BoundExpressionWithNullability)sourceExpression))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 42336, 42482);

                            var
                            innerConversion = f_10843_42358_42481(this, innerExpression, f_10843_42423_42443(innerExpression), destination, ref useSiteDiagnostics)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 42508, 42642) || true) && (innerConversion.Exists)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 42508, 42642);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 42592, 42615);

                                return innerConversion;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 42508, 42642);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10843, 42668, 42674);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 41630, 45302);

                    case BoundKind.TupleLiteral:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 41630, 45302);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 42765, 42900);

                        var
                        tupleConversion = f_10843_42787_42899(this, sourceExpression, destination, ref useSiteDiagnostics)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 42922, 43044) || true) && (tupleConversion.Exists)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 42922, 43044);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 42998, 43021);

                            return tupleConversion;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 42922, 43044);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10843, 43066, 43072);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 41630, 45302);

                    case BoundKind.UnboundLambda:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 41630, 45302);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 43143, 43317) || true) && (f_10843_43147_43208(sourceExpression, destination))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 43143, 43317);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 43258, 43294);

                            return Conversion.AnonymousFunction;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 43143, 43317);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10843, 43339, 43345);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 41630, 45302);

                    case BoundKind.MethodGroup:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 41630, 45302);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 43414, 43555);

                        Conversion
                        methodGroupConversion = f_10843_43449_43554(this, sourceExpression, destination, ref useSiteDiagnostics)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 43577, 43711) || true) && (methodGroupConversion.Exists)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 43577, 43711);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 43659, 43688);

                            return methodGroupConversion;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 43577, 43711);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10843, 43733, 43739);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 41630, 45302);

                    case BoundKind.InterpolatedString:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 41630, 45302);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 43815, 43969);

                        Conversion
                        interpolatedStringConversion = f_10843_43857_43968(this, sourceExpression, destination, ref useSiteDiagnostics)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 43991, 44139) || true) && (interpolatedStringConversion.Exists)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 43991, 44139);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 44080, 44116);

                            return interpolatedStringConversion;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 43991, 44139);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10843, 44161, 44167);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 41630, 45302);

                    case BoundKind.StackAllocArrayCreation:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 41630, 45302);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 44248, 44384);

                        var
                        stackAllocConversion = f_10843_44275_44383(this, sourceExpression, destination, ref useSiteDiagnostics)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 44406, 44538) || true) && (stackAllocConversion.Exists)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 44406, 44538);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 44487, 44515);

                            return stackAllocConversion;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 44406, 44538);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10843, 44560, 44566);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 41630, 45302);

                    case BoundKind.UnconvertedAddressOfOperator when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 44630, 44687) || true) && (destination is FunctionPointerTypeSymbol funcPtrType) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 44630, 44687) || true)
                :
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 41630, 45302);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 44710, 44876);

                        var
                        addressOfConversion = f_10843_44736_44875(this, f_10843_44776_44837(((BoundUnconvertedAddressOfOperator)sourceExpression)), funcPtrType, ref useSiteDiagnostics)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 44898, 45028) || true) && (addressOfConversion.Exists)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 44898, 45028);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 44978, 45005);

                            return addressOfConversion;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 44898, 45028);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10843, 45050, 45056);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 41630, 45302);

                    case BoundKind.ThrowExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 41630, 45302);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 45129, 45161);

                        return Conversion.ImplicitThrow;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 41630, 45302);

                    case BoundKind.UnconvertedObjectCreationExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 41630, 45302);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 45254, 45287);

                        return Conversion.ObjectCreation;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 41630, 45302);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 45318, 45349);

                return Conversion.NoConversion;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 40322, 45360);

                int
                f_10843_40538_40602(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 40538, 40602);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10843_40666_40687(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 40666, 40687);
                    return return_v;
                }


                int
                f_10843_40617_40706(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 40617, 40706);
                    return 0;
                }


                int
                f_10843_40721_40762(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 40721, 40762);
                    return 0;
                }


                bool
                f_10843_40783_40846(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                expressionType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination)
                {
                    var return_v = HasImplicitDynamicConversionFromExpression(expressionType, destination);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 40783, 40846);
                    return return_v;
                }


                bool
                f_10843_41229_41292(Microsoft.CodeAnalysis.CSharp.BoundExpression
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination)
                {
                    var return_v = HasImplicitEnumerationConversion(source, destination);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 41229, 41292);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_41420_41495(Microsoft.CodeAnalysis.CSharp.BoundExpression
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination)
                {
                    var return_v = ClassifyImplicitConstantExpressionConversion(source, destination);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 41420, 41495);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10843_41638_41659(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 41638, 41659);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_41766_41826(Microsoft.CodeAnalysis.CSharp.BoundExpression
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination)
                {
                    var return_v = ClassifyNullLiteralConversion(source, destination);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 41766, 41826);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10843_42248_42309(Microsoft.CodeAnalysis.CSharp.BoundExpressionWithNullability
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 42248, 42309);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10843_42423_42443(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 42423, 42443);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_42358_42481(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyImplicitBuiltInConversionFromExpression(sourceExpression, source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 42358, 42481);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_42787_42899(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyImplicitTupleLiteralConversion((Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral)source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 42787, 42899);
                    return return_v;
                }


                bool
                f_10843_43147_43208(Microsoft.CodeAnalysis.CSharp.BoundExpression
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination)
                {
                    var return_v = HasAnonymousFunctionConversion(source, destination);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 43147, 43208);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_43449_43554(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.GetMethodGroupDelegateConversion((Microsoft.CodeAnalysis.CSharp.BoundMethodGroup)source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 43449, 43554);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_43857_43968(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.GetInterpolatedStringConversion((Microsoft.CodeAnalysis.CSharp.BoundInterpolatedString)source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 43857, 43968);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_44275_44383(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.GetStackAllocConversion((Microsoft.CodeAnalysis.CSharp.BoundStackAllocArrayCreation)sourceExpression, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 44275, 44383);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                f_10843_44776_44837(Microsoft.CodeAnalysis.CSharp.BoundUnconvertedAddressOfOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 44776, 44837);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_44736_44875(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                source, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.GetMethodGroupFunctionPointerConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 44736, 44875);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 40322, 45360);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 40322, 45360);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Conversion GetSwitchExpressionConversion(BoundExpression source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 45372, 46717);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 45541, 46706);

                switch (source)
                {

                    case BoundConvertedSwitchExpression _:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 45541, 46706);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 45738, 45769);

                        return Conversion.NoConversion;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 45541, 46706);

                    case BoundUnconvertedSwitchExpression switchExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 45541, 46706);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 45864, 45960);

                        var
                        innerConversions = f_10843_45887_45959(switchExpression.SwitchArms.Length)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 45982, 46510);
                            foreach (var arm in f_10843_46002_46029_I(f_10843_46002_46029(switchExpression)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 45982, 46510);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 46079, 46196);

                                var
                                nestedConversion = f_10843_46102_46195(this, f_10843_46148_46157(arm), destination, ref useSiteDiagnostics)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 46222, 46420) || true) && (f_10843_46226_46250_M(!nestedConversion.Exists))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 46222, 46420);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 46308, 46332);

                                    f_10843_46308_46331(innerConversions);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 46362, 46393);

                                    return Conversion.NoConversion;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 46222, 46420);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 46448, 46487);

                                f_10843_46448_46486(
                                                        innerConversions, nestedConversion);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 45982, 46510);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10843, 1, 529);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10843, 1, 529);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 46534, 46612);

                        return Conversion.MakeSwitchExpression(f_10843_46573_46610(innerConversions));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 45541, 46706);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 45541, 46706);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 46660, 46691);

                        return Conversion.NoConversion;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 45541, 46706);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 45372, 46717);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Conversion>
                f_10843_45887_45959(int
                capacity)
                {
                    var return_v = ArrayBuilder<Conversion>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 45887, 45959);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm>
                f_10843_46002_46029(Microsoft.CodeAnalysis.CSharp.BoundUnconvertedSwitchExpression
                this_param)
                {
                    var return_v = this_param.SwitchArms;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 46002, 46029);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10843_46148_46157(Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 46148, 46157);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_46102_46195(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyImplicitConversionFromExpression(sourceExpression, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 46102, 46195);
                    return return_v;
                }


                bool
                f_10843_46226_46250_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 46226, 46250);
                    return return_v;
                }


                int
                f_10843_46308_46331(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Conversion>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 46308, 46331);
                    return 0;
                }


                int
                f_10843_46448_46486(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Conversion>
                this_param, Microsoft.CodeAnalysis.CSharp.Conversion
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 46448, 46486);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm>
                f_10843_46002_46029_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundSwitchExpressionArm>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 46002, 46029);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
                f_10843_46573_46610(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Conversion>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 46573, 46610);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 45372, 46717);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 45372, 46717);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Conversion GetConditionalExpressionConversion(BoundExpression source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 46729, 47640);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 46903, 47025) || true) && (!(source is BoundUnconvertedConditionalOperator conditionalOperator))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 46903, 47025);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 46994, 47025);

                    return Conversion.NoConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 46903, 47025);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 47041, 47178);

                var
                trueConversion = f_10843_47062_47177(this, f_10843_47108_47139(conditionalOperator), destination, ref useSiteDiagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 47192, 47268) || true) && (f_10843_47196_47218_M(!trueConversion.Exists))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 47192, 47268);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 47237, 47268);

                    return Conversion.NoConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 47192, 47268);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 47284, 47422);

                var
                falseConversion = f_10843_47306_47421(this, f_10843_47352_47383(conditionalOperator), destination, ref useSiteDiagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 47436, 47513) || true) && (f_10843_47440_47463_M(!falseConversion.Exists))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 47436, 47513);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 47482, 47513);

                    return Conversion.NoConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 47436, 47513);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 47529, 47629);

                return Conversion.MakeConditionalExpression(f_10843_47573_47627(trueConversion, falseConversion));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 46729, 47640);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10843_47108_47139(Microsoft.CodeAnalysis.CSharp.BoundUnconvertedConditionalOperator
                this_param)
                {
                    var return_v = this_param.Consequence;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 47108, 47139);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_47062_47177(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyImplicitConversionFromExpression(sourceExpression, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 47062, 47177);
                    return return_v;
                }


                bool
                f_10843_47196_47218_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 47196, 47218);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10843_47352_47383(Microsoft.CodeAnalysis.CSharp.BoundUnconvertedConditionalOperator
                this_param)
                {
                    var return_v = this_param.Alternative;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 47352, 47383);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_47306_47421(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyImplicitConversionFromExpression(sourceExpression, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 47306, 47421);
                    return return_v;
                }


                bool
                f_10843_47440_47463_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 47440, 47463);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
                f_10843_47573_47627(Microsoft.CodeAnalysis.CSharp.Conversion
                item1, Microsoft.CodeAnalysis.CSharp.Conversion
                item2)
                {
                    var return_v = ImmutableArray.Create(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 47573, 47627);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 46729, 47640);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 46729, 47640);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Conversion ClassifyNullLiteralConversion(BoundExpression source, TypeSymbol destination)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10843, 47652, 49201);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 47780, 47817);

                f_10843_47780_47816((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 47831, 47873);

                f_10843_47831_47872((object)destination != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 47889, 47996) || true) && (!f_10843_47894_47916(source))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 47889, 47996);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 47950, 47981);

                    return Conversion.NoConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 47889, 47996);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 48109, 48362) || true) && (f_10843_48113_48141(destination))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 48109, 48362);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 48317, 48347);

                    return Conversion.NullLiteral;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 48109, 48362);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 48735, 48851) || true) && (f_10843_48739_48766(destination))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 48735, 48851);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 48800, 48836);

                    return Conversion.ImplicitReference;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 48735, 48851);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 49018, 49143) || true) && (f_10843_49022_49062(destination))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 49018, 49143);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 49096, 49128);

                    return Conversion.NullToPointer;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 49018, 49143);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 49159, 49190);

                return Conversion.NoConversion;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10843, 47652, 49201);

                int
                f_10843_47780_47816(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 47780, 47816);
                    return 0;
                }


                int
                f_10843_47831_47872(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 47831, 47872);
                    return 0;
                }


                bool
                f_10843_47894_47916(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = node.IsLiteralNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 47894, 47916);
                    return return_v;
                }


                bool
                f_10843_48113_48141(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 48113, 48141);
                    return return_v;
                }


                bool
                f_10843_48739_48766(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 48739, 48766);
                    return return_v;
                }


                bool
                f_10843_49022_49062(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsPointerOrFunctionPointer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 49022, 49062);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 47652, 49201);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 47652, 49201);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Conversion ClassifyImplicitConstantExpressionConversion(BoundExpression source, TypeSymbol destination)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10843, 49213, 50276);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 49356, 49504) || true) && (f_10843_49360_49420(source, destination))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 49356, 49504);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 49454, 49489);

                    return Conversion.ImplicitConstant;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 49356, 49504);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 49702, 50218) || true) && (f_10843_49706_49722(destination) == SymbolKind.NamedType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 49702, 50218);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 49780, 49818);

                    var
                    nt = (NamedTypeSymbol)destination
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 49836, 50203) || true) && (f_10843_49840_49882(f_10843_49840_49861(nt)) == SpecialType.System_Nullable_T && (DynAbs.Tracing.TraceSender.Expression_True(10843, 49840, 50048) && f_10843_49940_50048(source, f_10843_49988_50039(nt)[0].Type)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 49836, 50203);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 50090, 50184);

                        return f_10843_50097_50183(ConversionKind.ImplicitNullable, Conversion.ImplicitConstantUnderlying);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 49836, 50203);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 49702, 50218);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 50234, 50265);

                return Conversion.NoConversion;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10843, 49213, 50276);

                bool
                f_10843_49360_49420(Microsoft.CodeAnalysis.CSharp.BoundExpression
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination)
                {
                    var return_v = HasImplicitConstantExpressionConversion(source, destination);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 49360, 49420);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10843_49706_49722(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 49706, 49722);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10843_49840_49861(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 49840, 49861);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10843_49840_49882(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.GetSpecialTypeSafe();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 49840, 49882);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10843_49988_50039(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 49988, 50039);
                    return return_v;
                }


                bool
                f_10843_49940_50048(Microsoft.CodeAnalysis.CSharp.BoundExpression
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination)
                {
                    var return_v = HasImplicitConstantExpressionConversion(source, destination);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 49940, 50048);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_50097_50183(Microsoft.CodeAnalysis.CSharp.ConversionKind
                kind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
                nestedConversions)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind, nestedConversions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 50097, 50183);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 49213, 50276);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 49213, 50276);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Conversion ClassifyImplicitTupleLiteralConversion(BoundTupleLiteral source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 50288, 51637);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 50468, 50569);

                var
                tupleConversion = f_10843_50490_50568(this, source, destination, ref useSiteDiagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 50583, 50681) || true) && (tupleConversion.Exists)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 50583, 50681);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 50643, 50666);

                    return tupleConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 50583, 50681);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 50893, 51579) || true) && (f_10843_50897_50913(destination) == SymbolKind.NamedType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 50893, 51579);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 50971, 51009);

                    var
                    nt = (NamedTypeSymbol)destination
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 51027, 51564) || true) && (f_10843_51031_51073(f_10843_51031_51052(nt)) == SpecialType.System_Nullable_T)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 51027, 51564);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 51148, 51307);

                        var
                        underlyingTupleConversion = f_10843_51180_51306(this, source, f_10843_51222_51273(nt)[0].Type, ref useSiteDiagnostics)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 51331, 51545) || true) && (underlyingTupleConversion.Exists)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 51331, 51545);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 51417, 51522);

                            return f_10843_51424_51521(ConversionKind.ImplicitNullable, f_10843_51472_51520(underlyingTupleConversion));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 51331, 51545);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 51027, 51564);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 50893, 51579);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 51595, 51626);

                return Conversion.NoConversion;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 50288, 51637);

                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_50490_50568(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.GetImplicitTupleLiteralConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 50490, 50568);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10843_50897_50913(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 50897, 50913);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10843_51031_51052(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 51031, 51052);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10843_51031_51073(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.GetSpecialTypeSafe();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 51031, 51073);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10843_51222_51273(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 51222, 51273);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_51180_51306(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.GetImplicitTupleLiteralConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 51180, 51306);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
                f_10843_51472_51520(Microsoft.CodeAnalysis.CSharp.Conversion
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 51472, 51520);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_51424_51521(Microsoft.CodeAnalysis.CSharp.ConversionKind
                kind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
                nestedConversions)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind, nestedConversions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 51424, 51521);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 50288, 51637);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 50288, 51637);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Conversion ClassifyExplicitTupleLiteralConversion(BoundTupleLiteral source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics, bool forCast)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 51649, 53039);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 51843, 51953);

                var
                tupleConversion = f_10843_51865_51952(this, source, destination, ref useSiteDiagnostics, forCast)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 51967, 52065) || true) && (tupleConversion.Exists)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 51967, 52065);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 52027, 52050);

                    return tupleConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 51967, 52065);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 52286, 52981) || true) && (f_10843_52290_52306(destination) == SymbolKind.NamedType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 52286, 52981);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 52364, 52402);

                    var
                    nt = (NamedTypeSymbol)destination
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 52420, 52966) || true) && (f_10843_52424_52466(f_10843_52424_52445(nt)) == SpecialType.System_Nullable_T)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 52420, 52966);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 52541, 52709);

                        var
                        underlyingTupleConversion = f_10843_52573_52708(this, source, f_10843_52615_52666(nt)[0].Type, ref useSiteDiagnostics, forCast)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 52733, 52947) || true) && (underlyingTupleConversion.Exists)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 52733, 52947);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 52819, 52924);

                            return f_10843_52826_52923(ConversionKind.ExplicitNullable, f_10843_52874_52922(underlyingTupleConversion));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 52733, 52947);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 52420, 52966);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 52286, 52981);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 52997, 53028);

                return Conversion.NoConversion;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 51649, 53039);

                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_51865_51952(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, bool
                forCast)
                {
                    var return_v = this_param.GetExplicitTupleLiteralConversion(source, destination, ref useSiteDiagnostics, forCast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 51865, 51952);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10843_52290_52306(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 52290, 52306);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10843_52424_52445(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 52424, 52445);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10843_52424_52466(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.GetSpecialTypeSafe();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 52424, 52466);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10843_52615_52666(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 52615, 52666);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_52573_52708(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, bool
                forCast)
                {
                    var return_v = this_param.GetExplicitTupleLiteralConversion(source, destination, ref useSiteDiagnostics, forCast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 52573, 52708);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
                f_10843_52874_52922(Microsoft.CodeAnalysis.CSharp.Conversion
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 52874, 52922);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_52826_52923(Microsoft.CodeAnalysis.CSharp.ConversionKind
                kind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
                nestedConversions)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind, nestedConversions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 52826, 52923);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 51649, 53039);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 51649, 53039);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool HasImplicitConstantExpressionConversion(BoundExpression source, TypeSymbol destination)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10843, 53051, 55663);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 53184, 53225);

                var
                constantValue = f_10843_53204_53224(source)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 53241, 53359) || true) && (constantValue == null || (DynAbs.Tracing.TraceSender.Expression_False(10843, 53245, 53297) || (object)f_10843_53278_53289(source) == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 53241, 53359);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 53331, 53344);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 53241, 53359);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 53714, 53767);

                var
                specialSource = f_10843_53734_53766(f_10843_53734_53745(source))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 53783, 55623) || true) && (specialSource == SpecialType.System_Int32)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 53783, 55623);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 53974, 54037);

                    int
                    value = (DynAbs.Tracing.TraceSender.Conditional_F1(10843, 53986, 54005) || ((f_10843_53986_54005(constantValue) && DynAbs.Tracing.TraceSender.Conditional_F2(10843, 54008, 54009)) || DynAbs.Tracing.TraceSender.Conditional_F3(10843, 54012, 54036))) ? 0 : f_10843_54012_54036(constantValue)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 54055, 55190);

                    switch (f_10843_54063_54095(destination))
                    {

                        case SpecialType.System_Byte:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 54055, 55190);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 54192, 54248);

                            return byte.MinValue <= value && (DynAbs.Tracing.TraceSender.Expression_True(10843, 54199, 54247) && value <= byte.MaxValue);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 54055, 55190);

                        case SpecialType.System_SByte:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 54055, 55190);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 54326, 54384);

                            return sbyte.MinValue <= value && (DynAbs.Tracing.TraceSender.Expression_True(10843, 54333, 54383) && value <= sbyte.MaxValue);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 54055, 55190);

                        case SpecialType.System_Int16:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 54055, 55190);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 54462, 54520);

                            return short.MinValue <= value && (DynAbs.Tracing.TraceSender.Expression_True(10843, 54469, 54519) && value <= short.MaxValue);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 54055, 55190);

                        case SpecialType.System_IntPtr when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 54573, 54609) || true) && (f_10843_54578_54609(destination)) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 54573, 54609) || true)
                    :
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 54055, 55190);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 54636, 54648);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 54055, 55190);

                        case SpecialType.System_UInt32:
                        case SpecialType.System_UIntPtr when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 54755, 54791) || true) && (f_10843_54760_54791(destination)) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 54755, 54791) || true)
                    :
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 54055, 55190);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 54818, 54848);

                            return uint.MinValue <= value;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 54055, 55190);

                        case SpecialType.System_UInt64:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 54055, 55190);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 54927, 54963);

                            return (int)ulong.MinValue <= value;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 54055, 55190);

                        case SpecialType.System_UInt16:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 54055, 55190);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 55042, 55102);

                            return ushort.MinValue <= value && (DynAbs.Tracing.TraceSender.Expression_True(10843, 55049, 55101) && value <= ushort.MaxValue);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 54055, 55190);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 54055, 55190);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 55158, 55171);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 54055, 55190);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 53783, 55623);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 53783, 55623);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 55224, 55623) || true) && (specialSource == SpecialType.System_Int64 && (DynAbs.Tracing.TraceSender.Expression_True(10843, 55228, 55334) && f_10843_55273_55305(destination) == SpecialType.System_UInt64) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 55228, 55392) && (f_10843_55339_55358(constantValue) || (DynAbs.Tracing.TraceSender.Expression_False(10843, 55339, 55391) || 0 <= f_10843_55367_55391(constantValue)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 55224, 55623);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 55596, 55608);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 55224, 55623);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 53783, 55623);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 55639, 55652);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10843, 53051, 55663);

                Microsoft.CodeAnalysis.ConstantValue?
                f_10843_53204_53224(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 53204, 53224);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10843_53278_53289(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 53278, 53289);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10843_53734_53745(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 53734, 53745);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10843_53734_53766(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetSpecialTypeSafe();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 53734, 53766);
                    return return_v;
                }


                bool
                f_10843_53986_54005(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.IsBad;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 53986, 54005);
                    return return_v;
                }


                int
                f_10843_54012_54036(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Int32Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 54012, 54036);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10843_54063_54095(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetSpecialTypeSafe();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 54063, 54095);
                    return return_v;
                }


                bool
                f_10843_54578_54609(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsNativeIntegerType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 54578, 54609);
                    return return_v;
                }


                bool
                f_10843_54760_54791(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsNativeIntegerType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 54760, 54791);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10843_55273_55305(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetSpecialTypeSafe();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 55273, 55305);
                    return return_v;
                }


                bool
                f_10843_55339_55358(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.IsBad;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 55339, 55358);
                    return return_v;
                }


                long
                f_10843_55367_55391(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Int64Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 55367, 55391);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 53051, 55663);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 53051, 55663);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Conversion ClassifyExplicitOnlyConversionFromExpression(BoundExpression sourceExpression, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics, bool forCast)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 55675, 57656);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 55883, 55922);

                f_10843_55883_55921(sourceExpression != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 55936, 55978);

                f_10843_55936_55977((object)destination != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 55994, 56033);

                var
                sourceType = f_10843_56011_56032(sourceExpression)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 56445, 56824) || true) && (f_10843_56449_56470(sourceExpression) == BoundKind.TupleLiteral)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 56445, 56824);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 56530, 56681);

                    Conversion
                    tupleConversion = f_10843_56559_56680(this, sourceExpression, destination, ref useSiteDiagnostics, forCast)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 56699, 56809) || true) && (tupleConversion.Exists)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 56699, 56809);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 56767, 56790);

                        return tupleConversion;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 56699, 56809);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 56445, 56824);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 56840, 57522) || true) && ((object)sourceType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 56840, 57522);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 56976, 57052);

                    Conversion
                    fastConversion = f_10843_57004_57051(sourceType, destination)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 57070, 57507) || true) && (fastConversion.Exists)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 57070, 57507);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 57137, 57159);

                        return fastConversion;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 57070, 57507);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 57070, 57507);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 57241, 57354);

                        var
                        conversion = f_10843_57258_57353(this, sourceType, destination, ref useSiteDiagnostics, forCast)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 57376, 57488) || true) && (conversion.Exists)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 57376, 57488);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 57447, 57465);

                            return conversion;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 57376, 57488);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 57070, 57507);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 56840, 57522);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 57538, 57645);

                return f_10843_57545_57644(this, sourceExpression, sourceType, destination, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 55675, 57656);

                int
                f_10843_55883_55921(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 55883, 55921);
                    return 0;
                }


                int
                f_10843_55936_55977(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 55936, 55977);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10843_56011_56032(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 56011, 56032);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10843_56449_56470(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 56449, 56470);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_56559_56680(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, bool
                forCast)
                {
                    var return_v = this_param.ClassifyExplicitTupleLiteralConversion((Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral)source, destination, ref useSiteDiagnostics, forCast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 56559, 56680);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_57004_57051(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                target)
                {
                    var return_v = FastClassifyConversion(source, target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 57004, 57051);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_57258_57353(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, bool
                forCast)
                {
                    var return_v = this_param.ClassifyExplicitBuiltInOnlyConversion(source, destination, ref useSiteDiagnostics, forCast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 57258, 57353);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_57545_57644(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.GetExplicitUserDefinedConversion(sourceExpression, source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 57545, 57644);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 55675, 57656);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 55675, 57656);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool HasImplicitEnumerationConversion(BoundExpression source, TypeSymbol destination)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10843, 57686, 58856);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 57811, 57848);

                f_10843_57811_57847((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 57862, 57904);

                f_10843_57862_57903((object)destination != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 58342, 58489);

                bool
                validType = f_10843_58359_58383(destination) || (DynAbs.Tracing.TraceSender.Expression_False(10843, 58359, 58488) || f_10843_58404_58432(destination) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 58404, 58488) && f_10843_58436_58488(f_10843_58436_58475(destination))))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 58505, 58581) || true) && (!validType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 58505, 58581);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 58553, 58566);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 58505, 58581);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 58597, 58644);

                var
                sourceConstantValue = f_10843_58623_58643(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 58658, 58845);

                return sourceConstantValue != null && (DynAbs.Tracing.TraceSender.Expression_True(10843, 58665, 58734) && f_10843_58713_58724(source) is object) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 58665, 58781) && f_10843_58755_58781(f_10843_58769_58780(source))) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 58665, 58844) && f_10843_58802_58844(sourceConstantValue));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10843, 57686, 58856);

                int
                f_10843_57811_57847(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 57811, 57847);
                    return 0;
                }


                int
                f_10843_57862_57903(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 57862, 57903);
                    return 0;
                }


                bool
                f_10843_58359_58383(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsEnumType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 58359, 58383);
                    return return_v;
                }


                bool
                f_10843_58404_58432(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 58404, 58432);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10843_58436_58475(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 58436, 58475);
                    return return_v;
                }


                bool
                f_10843_58436_58488(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsEnumType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 58436, 58488);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10843_58623_58643(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 58623, 58643);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10843_58713_58724(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 58713, 58724);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10843_58769_58780(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 58769, 58780);
                    return return_v;
                }


                bool
                f_10843_58755_58781(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = IsNumericType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 58755, 58781);
                    return return_v;
                }


                bool
                f_10843_58802_58844(Microsoft.CodeAnalysis.ConstantValue
                value)
                {
                    var return_v = IsConstantNumericZero(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 58802, 58844);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 57686, 58856);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 57686, 58856);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static LambdaConversionResult IsAnonymousFunctionCompatibleWithDelegate(UnboundLambda anonymousFunction, TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10843, 58887, 64783);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 59041, 59089);

                f_10843_59041_59088((object)anonymousFunction != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 59103, 59138);

                f_10843_59103_59137((object)type != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 59547, 59588);

                var
                delegateType = (NamedTypeSymbol)type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 59602, 59655);

                var
                invokeMethod = f_10843_59621_59654(delegateType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 59671, 59828) || true) && ((object)invokeMethod == null || (DynAbs.Tracing.TraceSender.Expression_False(10843, 59675, 59735) || f_10843_59707_59735(invokeMethod)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 59671, 59828);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 59769, 59813);

                    return LambdaConversionResult.BadTargetType;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 59671, 59828);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 59844, 59893);

                var
                delegateParameters = f_10843_59869_59892(invokeMethod)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 60243, 64405) || true) && (f_10843_60247_60277(anonymousFunction))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 60243, 64405);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 60311, 60487) || true) && (f_10843_60315_60347(anonymousFunction) != f_10843_60351_60378(invokeMethod))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 60311, 60487);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 60420, 60468);

                        return LambdaConversionResult.BadParameterCount;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 60311, 60487);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 60799, 64029) || true) && (f_10843_60803_60852(anonymousFunction))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 60799, 64029);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 60903, 60908);
                            for (int
        p = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 60894, 61358) || true) && (p < delegateParameters.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 60941, 60944)
        , ++p, DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 60894, 61358))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 60894, 61358);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 60994, 61335) || true) && (f_10843_60998_61027(delegateParameters[p]) != f_10843_61031_61059(anonymousFunction, p) || (DynAbs.Tracing.TraceSender.Expression_False(10843, 60998, 61196) || !f_10843_61093_61196(f_10843_61093_61119(delegateParameters[p]), f_10843_61127_61161(anonymousFunction, p), TypeCompareKind.AllIgnoreOptions)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 60994, 61335);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 61254, 61308);

                                    return LambdaConversionResult.MismatchedParameterType;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 60994, 61335);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10843, 1, 465);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10843, 1, 465);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 60799, 64029);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 60799, 64029);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 61449, 61454);
                            for (int
        p = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 61440, 61754) || true) && (p < delegateParameters.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 61487, 61490)
        , ++p, DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 61440, 61754))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 61440, 61754);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 61540, 61731) || true) && (f_10843_61544_61573(delegateParameters[p]) != RefKind.None)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 61540, 61731);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 61647, 61704);

                                    return LambdaConversionResult.RefInImplicitlyTypedLambda;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 61540, 61731);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10843, 1, 315);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10843, 1, 315);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 63693, 63698);

                            // In C# it is not possible to make a delegate type
                            // such that one of its parameter types is a static type. But static types are 
                            // in metadata just sealed abstract types; there is nothing stopping someone in
                            // another language from creating a delegate with a static type for a parameter,
                            // though the only argument you could pass for that parameter is null.
                            // 
                            // In the native compiler we forbid conversion of an anonymous function that has
                            // an implicitly-typed parameter list to a delegate type that has a static type
                            // for a formal parameter type. However, we do *not* forbid it for an explicitly-
                            // typed lambda (because we already require that the explicitly typed parameter not
                            // be static) and we do not forbid it for an anonymous method with the entire
                            // parameter list missing (because the body cannot possibly have a parameter that
                            // is of static type, even though this means that we will be generating a hidden
                            // method with a parameter of static type.)
                            //
                            // We also allow more exotic situations to work in the native compiler. For example,
                            // though it is not possible to convert x=>{} to Action<GC>, it is possible to convert
                            // it to Action<List<GC>> should there be a language that allows you to construct 
                            // a variable of that type.
                            //
                            // We might consider beefing up this rule to disallow a conversion of *any* anonymous
                            // function to *any* delegate that has a static type *anywhere* in the parameter list.

                            for (int
        p = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 63684, 64010) || true) && (p < delegateParameters.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 63731, 63734)
        , ++p, DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 63684, 64010))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 63684, 64010);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 63784, 63987) || true) && (delegateParameters[p].TypeWithAnnotations.IsStatic)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 63784, 63987);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 63896, 63960);

                                    return LambdaConversionResult.StaticTypeInImplicitlyTypedLambda;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 63784, 63987);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10843, 1, 327);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10843, 1, 327);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 60799, 64029);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 60243, 64405);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 60243, 64405);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 64104, 64109);
                        for (int
        p = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 64095, 64390) || true) && (p < delegateParameters.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 64142, 64145)
        , ++p, DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 64095, 64390))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 64095, 64390);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 64187, 64371) || true) && (f_10843_64191_64220(delegateParameters[p]) == RefKind.Out)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 64187, 64371);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 64285, 64348);

                                return LambdaConversionResult.MissingSignatureWithOutParameter;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 64187, 64371);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10843, 1, 296);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10843, 1, 296);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 60243, 64405);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 64492, 64541);

                var
                bound = f_10843_64504_64540(anonymousFunction, delegateType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 64555, 64718) || true) && (f_10843_64559_64625(f_10843_64607_64624(bound)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 64555, 64718);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 64659, 64703);

                    return LambdaConversionResult.BindingFailed;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 64555, 64718);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 64734, 64772);

                return LambdaConversionResult.Success;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10843, 58887, 64783);

                int
                f_10843_59041_59088(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 59041, 59088);
                    return 0;
                }


                int
                f_10843_59103_59137(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 59103, 59137);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10843_59621_59654(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DelegateInvokeMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 59621, 59654);
                    return return_v;
                }


                bool
                f_10843_59707_59735(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.HasUseSiteError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 59707, 59735);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10843_59869_59892(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 59869, 59892);
                    return return_v;
                }


                bool
                f_10843_60247_60277(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param)
                {
                    var return_v = this_param.HasSignature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 60247, 60277);
                    return return_v;
                }


                int
                f_10843_60315_60347(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 60315, 60347);
                    return return_v;
                }


                int
                f_10843_60351_60378(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 60351, 60378);
                    return return_v;
                }


                bool
                f_10843_60803_60852(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param)
                {
                    var return_v = this_param.HasExplicitlyTypedParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 60803, 60852);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10843_60998_61027(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 60998, 61027);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10843_61031_61059(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param, int
                index)
                {
                    var return_v = this_param.RefKind(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 61031, 61059);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10843_61093_61119(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 61093, 61119);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10843_61127_61161(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param, int
                index)
                {
                    var return_v = this_param.ParameterType(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 61127, 61161);
                    return return_v;
                }


                bool
                f_10843_61093_61196(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 61093, 61196);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10843_61544_61573(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 61544, 61573);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10843_64191_64220(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 64191, 64220);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLambda
                f_10843_64504_64540(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                delegateType)
                {
                    var return_v = this_param.Bind(delegateType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 64504, 64540);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                f_10843_64607_64624(Microsoft.CodeAnalysis.CSharp.BoundLambda
                this_param)
                {
                    var return_v = this_param.Diagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 64607, 64624);
                    return return_v;
                }


                bool
                f_10843_64559_64625(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Diagnostic>
                diagnostics)
                {
                    var return_v = ErrorFacts.PreventsSuccessfulDelegateConversion(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 64559, 64625);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 58887, 64783);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 58887, 64783);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static LambdaConversionResult IsAnonymousFunctionCompatibleWithExpressionTree(UnboundLambda anonymousFunction, NamedTypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10843, 64795, 66442);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 64960, 65008);

                f_10843_64960_65007((object)anonymousFunction != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 65022, 65057);

                f_10843_65022_65056((object)type != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 65071, 65109);

                f_10843_65071_65108(f_10843_65084_65107(type));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 65878, 65959);

                var
                delegateType = f_10843_65897_65950(type)[0].Type
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 65973, 66129) || true) && (!f_10843_65978_66007(delegateType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 65973, 66129);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 66041, 66114);

                    return LambdaConversionResult.ExpressionTreeMustHaveDelegateTypeArgument;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 65973, 66129);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 66145, 66333) || true) && (f_10843_66149_66180(anonymousFunction.Syntax) == SyntaxKind.AnonymousMethodExpression)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 66145, 66333);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 66254, 66318);

                    return LambdaConversionResult.ExpressionTreeFromAnonymousMethod;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 66145, 66333);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 66349, 66431);

                return f_10843_66356_66430(anonymousFunction, delegateType);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10843, 64795, 66442);

                int
                f_10843_64960_65007(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 64960, 65007);
                    return 0;
                }


                int
                f_10843_65022_65056(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 65022, 65056);
                    return 0;
                }


                bool
                f_10843_65084_65107(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                _type)
                {
                    var return_v = _type.IsExpressionTree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 65084, 65107);
                    return return_v;
                }


                int
                f_10843_65071_65108(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 65071, 65108);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10843_65897_65950(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 65897, 65950);
                    return return_v;
                }


                bool
                f_10843_65978_66007(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 65978, 66007);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10843_66149_66180(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 66149, 66180);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LambdaConversionResult
                f_10843_66356_66430(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                anonymousFunction, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = IsAnonymousFunctionCompatibleWithDelegate(anonymousFunction, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 66356, 66430);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 64795, 66442);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 64795, 66442);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static LambdaConversionResult IsAnonymousFunctionCompatibleWithType(UnboundLambda anonymousFunction, TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10843, 66454, 67127);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 66603, 66651);

                f_10843_66603_66650((object)anonymousFunction != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 66665, 66700);

                f_10843_66665_66699((object)type != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 66716, 67056) || true) && (f_10843_66720_66741(type))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 66716, 67056);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 66775, 66849);

                    return f_10843_66782_66848(anonymousFunction, type);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 66716, 67056);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 66716, 67056);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 66883, 67056) || true) && (f_10843_66887_66910(type))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 66883, 67056);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 66944, 67041);

                        return f_10843_66951_67040(anonymousFunction, type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 66883, 67056);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 66716, 67056);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 67072, 67116);

                return LambdaConversionResult.BadTargetType;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10843, 66454, 67127);

                int
                f_10843_66603_66650(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 66603, 66650);
                    return 0;
                }


                int
                f_10843_66665_66699(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 66665, 66699);
                    return 0;
                }


                bool
                f_10843_66720_66741(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 66720, 66741);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LambdaConversionResult
                f_10843_66782_66848(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                anonymousFunction, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = IsAnonymousFunctionCompatibleWithDelegate(anonymousFunction, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 66782, 66848);
                    return return_v;
                }


                bool
                f_10843_66887_66910(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                _type)
                {
                    var return_v = _type.IsExpressionTree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 66887, 66910);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LambdaConversionResult
                f_10843_66951_67040(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                anonymousFunction, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = IsAnonymousFunctionCompatibleWithExpressionTree(anonymousFunction, (Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 66951, 67040);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 66454, 67127);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 66454, 67127);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool HasAnonymousFunctionConversion(BoundExpression source, TypeSymbol destination)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10843, 67139, 67609);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 67262, 67291);

                f_10843_67262_67290(source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 67305, 67347);

                f_10843_67305_67346((object)destination != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 67363, 67467) || true) && (f_10843_67367_67378(source) != BoundKind.UnboundLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 67363, 67467);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 67439, 67452);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 67363, 67467);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 67483, 67598);

                return f_10843_67490_67563(source, destination) == LambdaConversionResult.Success;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10843, 67139, 67609);

                int
                f_10843_67262_67290(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 67262, 67290);
                    return 0;
                }


                int
                f_10843_67305_67346(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 67305, 67346);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10843_67367_67378(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 67367, 67378);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LambdaConversionResult
                f_10843_67490_67563(Microsoft.CodeAnalysis.CSharp.BoundExpression
                anonymousFunction, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = IsAnonymousFunctionCompatibleWithType((Microsoft.CodeAnalysis.CSharp.UnboundLambda)anonymousFunction, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 67490, 67563);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 67139, 67609);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 67139, 67609);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Conversion ClassifyImplicitUserDefinedConversionForV6SwitchGoverningType(TypeSymbol sourceType, out TypeSymbol switchGoverningType, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 67621, 69555);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 68761, 68802);

                f_10843_68761_68801((object)sourceType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 68816, 68873);

                f_10843_68816_68872(!f_10843_68830_68871(sourceType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 68889, 69023);

                UserDefinedConversionResult
                result = f_10843_68926_69022(this, sourceType, ref useSiteDiagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 69039, 69480) || true) && (result.Kind == UserDefinedConversionResultKind.Valid)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 69039, 69480);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 69129, 69198);

                    UserDefinedConversionAnalysis
                    analysis = result.Results[result.Best]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 69218, 69256);

                    switchGoverningType = analysis.ToType;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 69274, 69372);

                    f_10843_69274_69371(f_10843_69287_69370(switchGoverningType, isTargetTypeOfUserDefinedOp: true));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 69039, 69480);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 69039, 69480);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 69438, 69465);

                    switchGoverningType = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 69039, 69480);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 69496, 69544);

                return f_10843_69503_69543(result, isImplicit: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 67621, 69555);

                int
                f_10843_68761_68801(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 68761, 68801);
                    return 0;
                }


                bool
                f_10843_68830_68871(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsValidV6SwitchGoverningType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 68830, 68871);
                    return return_v;
                }


                int
                f_10843_68816_68872(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 68816, 68872);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.UserDefinedConversionResult
                f_10843_68926_69022(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.AnalyzeImplicitUserDefinedConversionForV6SwitchGoverningType(source, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 68926, 69022);
                    return return_v;
                }


                bool
                f_10843_69287_69370(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                isTargetTypeOfUserDefinedOp)
                {
                    var return_v = type.IsValidV6SwitchGoverningType(isTargetTypeOfUserDefinedOp: isTargetTypeOfUserDefinedOp);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 69287, 69370);
                    return return_v;
                }


                int
                f_10843_69274_69371(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 69274, 69371);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_69503_69543(Microsoft.CodeAnalysis.CSharp.UserDefinedConversionResult
                conversionResult, bool
                isImplicit)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(conversionResult, isImplicit: isImplicit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 69503, 69543);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 67621, 69555);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 67621, 69555);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Conversion GetCallerLineNumberConversion(TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 69567, 70352);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 69713, 69887);

                var
                greenNode = f_10843_69729_69886(SyntaxKind.NumericLiteralExpression, f_10843_69816_69885(SyntaxKind.NumericLiteralToken))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 69901, 69966);

                var
                syntaxNode = f_10843_69918_69965(greenNode, null, 0)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 69982, 70069);

                TypeSymbol
                expectedAttributeType = f_10843_70017_70068(corLibrary, SpecialType.System_Int32)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 70083, 70205);

                BoundLiteral
                intMaxValueLiteral = f_10843_70117_70204(syntaxNode, f_10843_70146_70180(int.MaxValue), expectedAttributeType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 70219, 70341);

                return f_10843_70226_70340(this, intMaxValueLiteral, expectedAttributeType, destination, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 69567, 70352);

                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                f_10843_69816_69885(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken(kind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 69816, 69885);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LiteralExpressionSyntax
                f_10843_69729_69886(Microsoft.CodeAnalysis.CSharp.SyntaxKind
                kind, Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.SyntaxToken
                token)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LiteralExpressionSyntax(kind, token);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 69729, 69886);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.LiteralExpressionSyntax
                f_10843_69918_69965(Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.LiteralExpressionSyntax
                green, Microsoft.CodeAnalysis.SyntaxNode?
                parent, int
                position)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Syntax.LiteralExpressionSyntax((Microsoft.CodeAnalysis.CSharp.Syntax.InternalSyntax.CSharpSyntaxNode)green, parent, position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 69918, 69965);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10843_70017_70068(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.SpecialType
                type)
                {
                    var return_v = this_param.GetSpecialType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 70017, 70068);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10843_70146_70180(int
                value)
                {
                    var return_v = ConstantValue.Create(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 70146, 70180);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10843_70117_70204(Microsoft.CodeAnalysis.CSharp.Syntax.LiteralExpressionSyntax
                syntax, Microsoft.CodeAnalysis.ConstantValue
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundLiteral((Microsoft.CodeAnalysis.SyntaxNode)syntax, constantValueOpt, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 70117, 70204);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_70226_70340(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyStandardImplicitConversion((Microsoft.CodeAnalysis.CSharp.BoundExpression)sourceExpression, source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 70226, 70340);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 69567, 70352);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 69567, 70352);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool HasCallerLineNumberConversion(TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 70364, 70596);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 70504, 70585);

                return f_10843_70511_70577(this, destination, ref useSiteDiagnostics).Exists;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 70364, 70596);

                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_70511_70577(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.GetCallerLineNumberConversion(destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 70511, 70577);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 70364, 70596);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 70364, 70596);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool HasCallerInfoStringConversion(TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 70608, 71019);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 70748, 70836);

                TypeSymbol
                expectedAttributeType = f_10843_70783_70835(corLibrary, SpecialType.System_String)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 70850, 70969);

                Conversion
                conversion = f_10843_70874_70968(this, expectedAttributeType, destination, ref useSiteDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 70983, 71008);

                return conversion.Exists;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 70608, 71019);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10843_70783_70835(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.SpecialType
                type)
                {
                    var return_v = this_param.GetSpecialType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 70783, 70835);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_70874_70968(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyStandardImplicitConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 70874, 70968);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 70608, 71019);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 70608, 71019);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool HasIdentityConversion(TypeSymbol type1, TypeSymbol type2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10843, 71031, 71221);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 71132, 71210);

                return f_10843_71139_71209(type1, type2, includeNullability: false);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10843, 71031, 71221);

                bool
                f_10843_71139_71209(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type2, bool
                includeNullability)
                {
                    var return_v = HasIdentityConversionInternal(type1, type2, includeNullability: includeNullability);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 71139, 71209);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 71031, 71221);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 71031, 71221);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool HasIdentityConversionInternal(TypeSymbol type1, TypeSymbol type2, bool includeNullability)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10843, 71233, 72453);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 71916, 71952);

                f_10843_71916_71951((object)type1 != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 71966, 72002);

                f_10843_71966_72001((object)type2 != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 72187, 72388);

                var
                compareKind = (DynAbs.Tracing.TraceSender.Conditional_F1(10843, 72205, 72223) || ((includeNullability && DynAbs.Tracing.TraceSender.Conditional_F2(10843, 72243, 72335)) || DynAbs.Tracing.TraceSender.Conditional_F3(10843, 72355, 72387))) ? TypeCompareKind.AllIgnoreOptions & ~TypeCompareKind.IgnoreNullableModifiersForReferenceTypes : TypeCompareKind.AllIgnoreOptions
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 72402, 72442);

                return f_10843_72409_72441(type1, type2, compareKind);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10843, 71233, 72453);

                int
                f_10843_71916_71951(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 71916, 71951);
                    return 0;
                }


                int
                f_10843_71966_72001(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 71966, 72001);
                    return 0;
                }


                bool
                f_10843_72409_72441(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 72409, 72441);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 71233, 72453);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 71233, 72453);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool HasIdentityConversionInternal(TypeSymbol type1, TypeSymbol type2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 72465, 72650);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 72568, 72639);

                return f_10843_72575_72638(type1, type2, IncludeNullability);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 72465, 72650);

                bool
                f_10843_72575_72638(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type2, bool
                includeNullability)
                {
                    var return_v = HasIdentityConversionInternal(type1, type2, includeNullability);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 72575, 72638);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 72465, 72650);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 72465, 72650);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool HasTopLevelNullabilityIdentityConversion(TypeWithAnnotations source, TypeWithAnnotations destination)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 73017, 74150);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 73157, 73241) || true) && (!IncludeNullability)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 73157, 73241);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 73214, 73226);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 73157, 73241);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 73257, 73409) || true) && (f_10843_73261_73300(source.NullableAnnotation) || (DynAbs.Tracing.TraceSender.Expression_False(10843, 73261, 73348) || f_10843_73304_73348(destination.NullableAnnotation)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 73257, 73409);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 73382, 73394);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 73257, 73409);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 73425, 73513);

                var
                sourceIsPossiblyNullableTypeParameter = f_10843_73469_73512(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 73527, 73625);

                var
                destinationIsPossiblyNullableTypeParameter = f_10843_73576_73624(destination)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 73639, 73828) || true) && (sourceIsPossiblyNullableTypeParameter && (DynAbs.Tracing.TraceSender.Expression_True(10843, 73643, 73727) && !destinationIsPossiblyNullableTypeParameter))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 73639, 73828);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 73761, 73813);

                    return f_10843_73768_73812(destination.NullableAnnotation);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 73639, 73828);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 73844, 74028) || true) && (destinationIsPossiblyNullableTypeParameter && (DynAbs.Tracing.TraceSender.Expression_True(10843, 73848, 73932) && !sourceIsPossiblyNullableTypeParameter))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 73844, 74028);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 73966, 74013);

                    return f_10843_73973_74012(source.NullableAnnotation);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 73844, 74028);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 74044, 74139);

                return f_10843_74051_74090(source.NullableAnnotation) == f_10843_74094_74138(destination.NullableAnnotation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 73017, 74150);

                bool
                f_10843_73261_73300(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                annotation)
                {
                    var return_v = annotation.IsOblivious();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 73261, 73300);
                    return return_v;
                }


                bool
                f_10843_73304_73348(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                annotation)
                {
                    var return_v = annotation.IsOblivious();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 73304, 73348);
                    return return_v;
                }


                bool
                f_10843_73469_73512(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                typeWithAnnotations)
                {
                    var return_v = IsPossiblyNullableTypeTypeParameter(typeWithAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 73469, 73512);
                    return return_v;
                }


                bool
                f_10843_73576_73624(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                typeWithAnnotations)
                {
                    var return_v = IsPossiblyNullableTypeTypeParameter(typeWithAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 73576, 73624);
                    return return_v;
                }


                bool
                f_10843_73768_73812(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                annotation)
                {
                    var return_v = annotation.IsAnnotated();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 73768, 73812);
                    return return_v;
                }


                bool
                f_10843_73973_74012(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                annotation)
                {
                    var return_v = annotation.IsAnnotated();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 73973, 74012);
                    return return_v;
                }


                bool
                f_10843_74051_74090(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                annotation)
                {
                    var return_v = annotation.IsAnnotated();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 74051, 74090);
                    return return_v;
                }


                bool
                f_10843_74094_74138(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                annotation)
                {
                    var return_v = annotation.IsAnnotated();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 74094, 74138);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 73017, 74150);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 73017, 74150);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool HasTopLevelNullabilityImplicitConversion(TypeWithAnnotations source, TypeWithAnnotations destination)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 74555, 75248);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 74695, 74779) || true) && (!IncludeNullability)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 74695, 74779);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 74752, 74764);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 74695, 74779);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 74795, 74995) || true) && (f_10843_74799_74838(source.NullableAnnotation) || (DynAbs.Tracing.TraceSender.Expression_False(10843, 74799, 74886) || f_10843_74842_74886(destination.NullableAnnotation)) || (DynAbs.Tracing.TraceSender.Expression_False(10843, 74799, 74934) || f_10843_74890_74934(destination.NullableAnnotation)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 74795, 74995);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 74968, 74980);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 74795, 74995);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 75011, 75173) || true) && (f_10843_75015_75058(source) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 75015, 75111) && !f_10843_75063_75111(destination)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 75011, 75173);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 75145, 75158);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 75011, 75173);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 75189, 75237);

                return !f_10843_75197_75236(source.NullableAnnotation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 74555, 75248);

                bool
                f_10843_74799_74838(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                annotation)
                {
                    var return_v = annotation.IsOblivious();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 74799, 74838);
                    return return_v;
                }


                bool
                f_10843_74842_74886(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                annotation)
                {
                    var return_v = annotation.IsOblivious();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 74842, 74886);
                    return return_v;
                }


                bool
                f_10843_74890_74934(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                annotation)
                {
                    var return_v = annotation.IsAnnotated();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 74890, 74934);
                    return return_v;
                }


                bool
                f_10843_75015_75058(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                typeWithAnnotations)
                {
                    var return_v = IsPossiblyNullableTypeTypeParameter(typeWithAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 75015, 75058);
                    return return_v;
                }


                bool
                f_10843_75063_75111(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                typeWithAnnotations)
                {
                    var return_v = IsPossiblyNullableTypeTypeParameter(typeWithAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 75063, 75111);
                    return return_v;
                }


                bool
                f_10843_75197_75236(Microsoft.CodeAnalysis.CSharp.NullableAnnotation
                annotation)
                {
                    var return_v = annotation.IsAnnotated();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 75197, 75236);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 74555, 75248);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 74555, 75248);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsPossiblyNullableTypeTypeParameter(in TypeWithAnnotations typeWithAnnotations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10843, 75260, 75581);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 75384, 75420);

                var
                type = typeWithAnnotations.Type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 75434, 75570);

                return type is object && (DynAbs.Tracing.TraceSender.Expression_True(10843, 75441, 75569) && (f_10843_75477_75528(type) || (DynAbs.Tracing.TraceSender.Expression_False(10843, 75477, 75568) || f_10843_75532_75568(type))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10843, 75260, 75581);

                bool
                f_10843_75477_75528(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsPossiblyNullableReferenceTypeTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 75477, 75528);
                    return return_v;
                }


                bool
                f_10843_75532_75568(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableTypeOrTypeParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 75532, 75568);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 75260, 75581);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 75260, 75581);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool HasAnyNullabilityImplicitConversion(TypeWithAnnotations source, TypeWithAnnotations destination)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 75814, 76288);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 75947, 75980);

                f_10843_75947_75979(IncludeNullability);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 75994, 76046);

                HashSet<DiagnosticInfo>
                discardedDiagnostics = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 76060, 76277);

                return f_10843_76067_76128(this, source, destination) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 76067, 76276) && f_10843_76149_76240(this, source.Type, destination.Type, ref discardedDiagnostics).Kind != ConversionKind.NoConversion);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 75814, 76288);

                int
                f_10843_75947_75979(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 75947, 75979);
                    return 0;
                }


                bool
                f_10843_76067_76128(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                destination)
                {
                    var return_v = this_param.HasTopLevelNullabilityImplicitConversion(source, destination);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 76067, 76128);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_76149_76240(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyImplicitConversionFromType(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 76149, 76240);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 75814, 76288);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 75814, 76288);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool HasIdentityConversionToAny<T>(T type, ArrayBuilder<T> targetTypes)
                    where T : TypeSymbol
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10843, 76300, 76722);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 76444, 76682);
                    foreach (var targetType in f_10843_76471_76482_I<T>(targetTypes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 76444, 76682);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 76516, 76667) || true) && (f_10843_76520_76594<T>(type, targetType, includeNullability: false))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 76516, 76667);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 76636, 76648);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 76516, 76667);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 76444, 76682);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10843, 1, 239);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10843, 1, 239);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 76698, 76711);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10843, 76300, 76722);

                bool
                f_10843_76520_76594<T>(T
                type1, T
                type2, bool
                includeNullability) where T : TypeSymbol

                {
                    var return_v = HasIdentityConversionInternal((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type1, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type2, includeNullability: includeNullability);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 76520, 76594);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                f_10843_76471_76482_I<T>(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<T>
                i) where T : TypeSymbol

                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 76471, 76482);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 76300, 76722);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 76300, 76722);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Conversion ConvertExtensionMethodThisArg(TypeSymbol parameterType, TypeSymbol thisType, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 76734, 77203);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 76901, 76940);

                f_10843_76901_76939((object)thisType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 76954, 77080);

                var
                conversion = f_10843_76971_77079(this, null, thisType, parameterType, ref useSiteDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 77094, 77192);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10843, 77101, 77152) || ((f_10843_77101_77152(conversion) && DynAbs.Tracing.TraceSender.Conditional_F2(10843, 77155, 77165)) || DynAbs.Tracing.TraceSender.Conditional_F3(10843, 77168, 77191))) ? conversion : Conversion.NoConversion;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 76734, 77203);

                int
                f_10843_76901_76939(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 76901, 76939);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_76971_77079(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceExpressionOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                sourceType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyImplicitExtensionMethodThisArgConversion(sourceExpressionOpt, sourceType, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 76971, 77079);
                    return return_v;
                }


                bool
                f_10843_77101_77152(Microsoft.CodeAnalysis.CSharp.Conversion
                conversion)
                {
                    var return_v = IsValidExtensionMethodThisArgConversion(conversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 77101, 77152);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 76734, 77203);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 76734, 77203);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Conversion ClassifyImplicitExtensionMethodThisArgConversion(BoundExpression sourceExpressionOpt, TypeSymbol sourceType, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 77406, 80456);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 77629, 77721);

                f_10843_77629_77720(sourceExpressionOpt == null || (DynAbs.Tracing.TraceSender.Expression_False(10843, 77642, 77719) || (object)f_10843_77681_77705(sourceExpressionOpt) == sourceType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 77735, 77777);

                f_10843_77735_77776((object)destination != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 77793, 78396) || true) && ((object)sourceType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 77793, 78396);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 77857, 78003) || true) && (f_10843_77861_77915(this, sourceType, destination))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 77857, 78003);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 77957, 77984);

                        return Conversion.Identity;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 77857, 78003);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 78023, 78181) || true) && (f_10843_78027_78095(this, sourceType, destination, ref useSiteDiagnostics))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 78023, 78181);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 78137, 78162);

                        return Conversion.Boxing;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 78023, 78181);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 78201, 78381) || true) && (f_10843_78205_78284(this, sourceType, destination, ref useSiteDiagnostics))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 78201, 78381);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 78326, 78362);

                        return Conversion.ImplicitReference;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 78201, 78381);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 77793, 78396);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 78412, 79418) || true) && (f_10843_78416_78441_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(sourceExpressionOpt, 10843, 78416, 78441)?.Kind) == BoundKind.TupleLiteral)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 78412, 79418);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 78695, 78729);

                    f_10843_78695_78728(!IncludeNullability);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 78747, 79275);

                    var
                    tupleConversion = f_10843_78769_79274(this, sourceExpressionOpt, destination, ref useSiteDiagnostics, ConversionKind.ImplicitTupleLiteral, (ConversionsBase conversions, BoundExpression s, TypeWithAnnotations d, ref HashSet<DiagnosticInfo> u, bool a) =>
                                            conversions.ClassifyImplicitExtensionMethodThisArgConversion(s, s.Type, d.Type, ref u), arg: false)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 79293, 79403) || true) && (tupleConversion.Exists)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 79293, 79403);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 79361, 79384);

                        return tupleConversion;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 79293, 79403);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 78412, 79418);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 79434, 80398) || true) && ((object)sourceType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 79434, 80398);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 79498, 80255);

                    var
                    tupleConversion = f_10843_79520_80254(this, sourceType, destination, ref useSiteDiagnostics, ConversionKind.ImplicitTuple, (ConversionsBase conversions, TypeWithAnnotations s, TypeWithAnnotations d, ref HashSet<DiagnosticInfo> u, bool a) =>
                                        {
                                            if (!conversions.HasTopLevelNullabilityImplicitConversion(s, d))
                                            {
                                                return Conversion.NoConversion;
                                            }
                                            return conversions.ClassifyImplicitExtensionMethodThisArgConversion(null, s.Type, d.Type, ref u);
                                        }, arg: false)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 80273, 80383) || true) && (tupleConversion.Exists)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 80273, 80383);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 80341, 80364);

                        return tupleConversion;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 80273, 80383);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 79434, 80398);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 80414, 80445);

                return Conversion.NoConversion;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 77406, 80456);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10843_77681_77705(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 77681, 77705);
                    return return_v;
                }


                int
                f_10843_77629_77720(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 77629, 77720);
                    return 0;
                }


                int
                f_10843_77735_77776(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 77735, 77776);
                    return 0;
                }


                bool
                f_10843_77861_77915(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type2)
                {
                    var return_v = this_param.HasIdentityConversionInternal(type1, type2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 77861, 77915);
                    return return_v;
                }


                bool
                f_10843_78027_78095(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasBoxingConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 78027, 78095);
                    return return_v;
                }


                bool
                f_10843_78205_78284(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasImplicitReferenceConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 78205, 78284);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind?
                f_10843_78416_78441_M(Microsoft.CodeAnalysis.CSharp.BoundKind?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 78416, 78441);
                    return return_v;
                }


                int
                f_10843_78695_78728(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 78695, 78728);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_78769_79274(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Microsoft.CodeAnalysis.CSharp.ConversionKind
                kind, Microsoft.CodeAnalysis.CSharp.ConversionsBase.ClassifyConversionFromExpressionDelegate
                classifyConversion, bool
                arg)
                {
                    var return_v = this_param.GetTupleLiteralConversion((Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral)source, destination, ref useSiteDiagnostics, kind, classifyConversion, arg: arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 78769, 79274);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_79520_80254(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Microsoft.CodeAnalysis.CSharp.ConversionKind
                kind, Microsoft.CodeAnalysis.CSharp.ConversionsBase.ClassifyConversionFromTypeDelegate
                classifyConversion, bool
                arg)
                {
                    var return_v = this_param.ClassifyTupleConversion(source, destination, ref useSiteDiagnostics, kind, classifyConversion, arg: arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 79520, 80254);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 77406, 80456);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 77406, 80456);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsValidExtensionMethodThisArgConversion(Conversion conversion)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10843, 80908, 82040);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 81014, 82029);

                switch (conversion.Kind)
                {

                    case ConversionKind.Identity:
                    case ConversionKind.Boxing:
                    case ConversionKind.ImplicitReference:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 81014, 82029);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 81223, 81235);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 81014, 82029);

                    case ConversionKind.ImplicitTuple:
                    case ConversionKind.ImplicitTupleLiteral:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 81014, 82029);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 81451, 81751);
                            foreach (var elementConversion in f_10843_81485_81517_I(conversion.UnderlyingConversions))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 81451, 81751);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 81567, 81728) || true) && (!f_10843_81572_81630(elementConversion))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 81567, 81728);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 81688, 81701);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 81567, 81728);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 81451, 81751);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10843, 1, 301);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10843, 1, 301);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 81773, 81785);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 81014, 82029);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 81014, 82029);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 81918, 81979);

                        f_10843_81918_81978(conversion.Kind == ConversionKind.NoConversion);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 82001, 82014);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 81014, 82029);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10843, 80908, 82040);

                bool
                f_10843_81572_81630(Microsoft.CodeAnalysis.CSharp.Conversion
                conversion)
                {
                    var return_v = IsValidExtensionMethodThisArgConversion(conversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 81572, 81630);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
                f_10843_81485_81517_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 81485, 81517);
                    return return_v;
                }


                int
                f_10843_81918_81978(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 81918, 81978);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 80908, 82040);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 80908, 82040);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private const bool
        F = false
        ;

        private const bool
        T = true
        ;

        private static readonly bool[,] s_implicitNumericConversions;

        private static readonly bool[,] s_explicitNumericConversions;

        private static int GetNumericTypeIndex(SpecialType specialType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10843, 84341, 85230);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 84429, 85219);

                switch (specialType)
                {

                    case SpecialType.System_SByte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 84429, 85219);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 84513, 84522);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 84429, 85219);

                    case SpecialType.System_Byte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 84429, 85219);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 84570, 84579);

                        return 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 84429, 85219);

                    case SpecialType.System_Int16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 84429, 85219);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 84628, 84637);

                        return 2;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 84429, 85219);

                    case SpecialType.System_UInt16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 84429, 85219);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 84687, 84696);

                        return 3;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 84429, 85219);

                    case SpecialType.System_Int32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 84429, 85219);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 84745, 84754);

                        return 4;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 84429, 85219);

                    case SpecialType.System_UInt32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 84429, 85219);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 84804, 84813);

                        return 5;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 84429, 85219);

                    case SpecialType.System_Int64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 84429, 85219);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 84862, 84871);

                        return 6;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 84429, 85219);

                    case SpecialType.System_UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 84429, 85219);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 84921, 84930);

                        return 7;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 84429, 85219);

                    case SpecialType.System_Char:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 84429, 85219);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 84978, 84987);

                        return 8;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 84429, 85219);

                    case SpecialType.System_Single:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 84429, 85219);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 85037, 85046);

                        return 9;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 84429, 85219);

                    case SpecialType.System_Double:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 84429, 85219);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 85096, 85106);

                        return 10;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 84429, 85219);

                    case SpecialType.System_Decimal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 84429, 85219);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 85157, 85167);

                        return 11;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 84429, 85219);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 84429, 85219);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 85194, 85204);

                        return -1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 84429, 85219);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10843, 84341, 85230);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 84341, 85230);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 84341, 85230);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool HasImplicitNumericConversion(TypeSymbol source, TypeSymbol destination)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10843, 85260, 85916);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 85376, 85413);

                f_10843_85376_85412((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 85427, 85469);

                f_10843_85427_85468((object)destination != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 85485, 85543);

                int
                sourceIndex = f_10843_85503_85542(f_10843_85523_85541(source))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 85557, 85638) || true) && (sourceIndex < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 85557, 85638);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 85610, 85623);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 85557, 85638);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 85654, 85722);

                int
                destinationIndex = f_10843_85677_85721(f_10843_85697_85720(destination))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 85736, 85822) || true) && (destinationIndex < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 85736, 85822);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 85794, 85807);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 85736, 85822);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 85838, 85905);

                return s_implicitNumericConversions[sourceIndex, destinationIndex];
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10843, 85260, 85916);

                int
                f_10843_85376_85412(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 85376, 85412);
                    return 0;
                }


                int
                f_10843_85427_85468(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 85427, 85468);
                    return 0;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10843_85523_85541(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 85523, 85541);
                    return return_v;
                }


                int
                f_10843_85503_85542(Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = GetNumericTypeIndex(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 85503, 85542);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10843_85697_85720(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 85697, 85720);
                    return return_v;
                }


                int
                f_10843_85677_85721(Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = GetNumericTypeIndex(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 85677, 85721);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 85260, 85916);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 85260, 85916);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool HasExplicitNumericConversion(TypeSymbol source, TypeSymbol destination)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10843, 85928, 86791);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 86251, 86288);

                f_10843_86251_86287((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 86302, 86344);

                f_10843_86302_86343((object)destination != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 86360, 86418);

                int
                sourceIndex = f_10843_86378_86417(f_10843_86398_86416(source))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 86432, 86513) || true) && (sourceIndex < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 86432, 86513);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 86485, 86498);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 86432, 86513);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 86529, 86597);

                int
                destinationIndex = f_10843_86552_86596(f_10843_86572_86595(destination))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 86611, 86697) || true) && (destinationIndex < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 86611, 86697);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 86669, 86682);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 86611, 86697);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 86713, 86780);

                return s_explicitNumericConversions[sourceIndex, destinationIndex];
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10843, 85928, 86791);

                int
                f_10843_86251_86287(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 86251, 86287);
                    return 0;
                }


                int
                f_10843_86302_86343(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 86302, 86343);
                    return 0;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10843_86398_86416(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 86398, 86416);
                    return return_v;
                }


                int
                f_10843_86378_86417(Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = GetNumericTypeIndex(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 86378, 86417);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10843_86572_86595(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 86572, 86595);
                    return return_v;
                }


                int
                f_10843_86552_86596(Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = GetNumericTypeIndex(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 86552, 86596);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 85928, 86791);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 85928, 86791);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsConstantNumericZero(ConstantValue value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10843, 86803, 88286);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 86890, 88248);

                switch (f_10843_86898_86917(value))
                {

                    case ConstantValueTypeDiscriminator.SByte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 86890, 88248);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 87015, 87044);

                        return f_10843_87022_87038(value) == 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 86890, 88248);

                    case ConstantValueTypeDiscriminator.Byte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 86890, 88248);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 87125, 87153);

                        return f_10843_87132_87147(value) == 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 86890, 88248);

                    case ConstantValueTypeDiscriminator.Int16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 86890, 88248);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 87235, 87264);

                        return f_10843_87242_87258(value) == 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 86890, 88248);

                    case ConstantValueTypeDiscriminator.Int32:
                    case ConstantValueTypeDiscriminator.NInt:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 86890, 88248);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 87405, 87434);

                        return f_10843_87412_87428(value) == 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 86890, 88248);

                    case ConstantValueTypeDiscriminator.Int64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 86890, 88248);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 87516, 87545);

                        return f_10843_87523_87539(value) == 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 86890, 88248);

                    case ConstantValueTypeDiscriminator.UInt16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 86890, 88248);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 87628, 87658);

                        return f_10843_87635_87652(value) == 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 86890, 88248);

                    case ConstantValueTypeDiscriminator.UInt32:
                    case ConstantValueTypeDiscriminator.NUInt:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 86890, 88248);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 87801, 87831);

                        return f_10843_87808_87825(value) == 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 86890, 88248);

                    case ConstantValueTypeDiscriminator.UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 86890, 88248);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 87914, 87944);

                        return f_10843_87921_87938(value) == 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 86890, 88248);

                    case ConstantValueTypeDiscriminator.Single:
                    case ConstantValueTypeDiscriminator.Double:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 86890, 88248);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 88088, 88118);

                        return f_10843_88095_88112(value) == 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 86890, 88248);

                    case ConstantValueTypeDiscriminator.Decimal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 86890, 88248);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 88202, 88233);

                        return f_10843_88209_88227(value) == 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 86890, 88248);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 88262, 88275);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10843, 86803, 88286);

                Microsoft.CodeAnalysis.ConstantValueTypeDiscriminator
                f_10843_86898_86917(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Discriminator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 86898, 86917);
                    return return_v;
                }


                sbyte
                f_10843_87022_87038(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.SByteValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 87022, 87038);
                    return return_v;
                }


                byte
                f_10843_87132_87147(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.ByteValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 87132, 87147);
                    return return_v;
                }


                short
                f_10843_87242_87258(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Int16Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 87242, 87258);
                    return return_v;
                }


                int
                f_10843_87412_87428(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Int32Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 87412, 87428);
                    return return_v;
                }


                long
                f_10843_87523_87539(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.Int64Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 87523, 87539);
                    return return_v;
                }


                ushort
                f_10843_87635_87652(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.UInt16Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 87635, 87652);
                    return return_v;
                }


                uint
                f_10843_87808_87825(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.UInt32Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 87808, 87825);
                    return return_v;
                }


                ulong
                f_10843_87921_87938(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.UInt64Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 87921, 87938);
                    return return_v;
                }


                double
                f_10843_88095_88112(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.DoubleValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 88095, 88112);
                    return return_v;
                }


                decimal
                f_10843_88209_88227(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.DecimalValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 88209, 88227);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 86803, 88286);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 86803, 88286);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsNumericType(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10843, 88298, 89274);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 88373, 89263);

                switch (f_10843_88381_88397(type))
                {

                    case SpecialType.System_Char:
                    case SpecialType.System_SByte:
                    case SpecialType.System_Byte:
                    case SpecialType.System_Int16:
                    case SpecialType.System_UInt16:
                    case SpecialType.System_Int32:
                    case SpecialType.System_UInt32:
                    case SpecialType.System_Int64:
                    case SpecialType.System_UInt64:
                    case SpecialType.System_Single:
                    case SpecialType.System_Double:
                    case SpecialType.System_Decimal:
                    case SpecialType.System_IntPtr when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 89043, 89072) || true) && (f_10843_89048_89072(type)) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 89043, 89072) || true)
                :
                    case SpecialType.System_UIntPtr when (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 89123, 89152) || true) && (f_10843_89128_89152(type)) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 89123, 89152) || true)
                :
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 88373, 89263);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 89175, 89187);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 88373, 89263);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 88373, 89263);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 89235, 89248);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 88373, 89263);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10843, 88298, 89274);

                Microsoft.CodeAnalysis.SpecialType
                f_10843_88381_88397(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 88381, 88397);
                    return return_v;
                }


                bool
                f_10843_89048_89072(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsNativeIntegerType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 89048, 89072);
                    return return_v;
                }


                bool
                f_10843_89128_89152(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsNativeIntegerType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 89128, 89152);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 88298, 89274);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 88298, 89274);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool HasSpecialIntPtrConversion(TypeSymbol source, TypeSymbol target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10843, 89286, 93010);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 89395, 89432);

                f_10843_89395_89431((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 89446, 89483);

                f_10843_89446_89482((object)target != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 91431, 91462);

                var
                s0 = f_10843_91440_91461(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 91476, 91507);

                var
                t0 = f_10843_91485_91506(target)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 91523, 91544);

                TypeSymbol
                otherType
                = default(TypeSymbol);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 91558, 91834) || true) && (f_10843_91562_91583(s0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 91558, 91834);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 91617, 91632);

                    otherType = t0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 91558, 91834);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 91558, 91834);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 91666, 91834) || true) && (f_10843_91670_91691(t0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 91666, 91834);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 91725, 91740);

                        otherType = s0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 91666, 91834);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 91666, 91834);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 91806, 91819);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 91666, 91834);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 91558, 91834);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 91850, 91953) || true) && (f_10843_91854_91892(otherType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 91850, 91953);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 91926, 91938);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 91850, 91953);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 91969, 92069) || true) && (f_10843_91973_91991(otherType) == TypeKind.Enum)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 91969, 92069);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 92042, 92054);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 91969, 92069);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 92085, 92760);

                switch (f_10843_92093_92114(otherType))
                {

                    case SpecialType.System_SByte:
                    case SpecialType.System_Byte:
                    case SpecialType.System_Int16:
                    case SpecialType.System_UInt16:
                    case SpecialType.System_Char:
                    case SpecialType.System_Int32:
                    case SpecialType.System_UInt32:
                    case SpecialType.System_Int64:
                    case SpecialType.System_UInt64:
                    case SpecialType.System_Double:
                    case SpecialType.System_Single:
                    case SpecialType.System_Decimal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 92085, 92760);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 92733, 92745);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 92085, 92760);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 92776, 92789);

                return false;

                static bool isIntPtrOrUIntPtr(TypeSymbol type)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 92852, 92998);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 92872, 92998);
                        return (f_10843_92873_92889(type) == SpecialType.System_IntPtr || (DynAbs.Tracing.TraceSender.Expression_False(10843, 92873, 92968) || f_10843_92922_92938(type) == SpecialType.System_UIntPtr)) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 92872, 92998) && f_10843_92973_92998_M(!type.IsNativeIntegerType)); DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 92852, 92998);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 92852, 92998);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 92852, 92998);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10843, 89286, 93010);

                int
                f_10843_89395_89431(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 89395, 89431);
                    return 0;
                }


                int
                f_10843_89446_89482(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 89446, 89482);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10843_91440_91461(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 91440, 91461);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10843_91485_91506(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 91485, 91506);
                    return return_v;
                }


                bool
                f_10843_91562_91583(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = isIntPtrOrUIntPtr(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 91562, 91583);
                    return return_v;
                }


                bool
                f_10843_91670_91691(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = isIntPtrOrUIntPtr(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 91670, 91691);
                    return return_v;
                }


                bool
                f_10843_91854_91892(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsPointerOrFunctionPointer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 91854, 91892);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10843_91973_91991(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 91973, 91991);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10843_92093_92114(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 92093, 92114);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.SpecialType
                f_10843_92873_92889(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 92873, 92889);
                    return return_v;
                }


                static Microsoft.CodeAnalysis.SpecialType
                f_10843_92922_92938(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 92922, 92938);
                    return return_v;
                }


                static bool
                f_10843_92973_92998_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 92973, 92998);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 89286, 93010);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 89286, 93010);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool HasExplicitEnumerationConversion(TypeSymbol source, TypeSymbol destination)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10843, 93022, 94078);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 93142, 93179);

                f_10843_93142_93178((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 93193, 93235);

                f_10843_93193_93234((object)destination != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 93666, 93780) || true) && (f_10843_93670_93691(source) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 93670, 93719) && f_10843_93695_93719(destination)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 93666, 93780);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 93753, 93765);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 93666, 93780);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 93796, 93910) || true) && (f_10843_93800_93826(destination) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 93800, 93849) && f_10843_93830_93849(source)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 93796, 93910);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 93883, 93895);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 93796, 93910);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 93926, 94038) || true) && (f_10843_93930_93949(source) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 93930, 93977) && f_10843_93953_93977(destination)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 93926, 94038);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 94011, 94023);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 93926, 94038);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 94054, 94067);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10843, 93022, 94078);

                int
                f_10843_93142_93178(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 93142, 93178);
                    return 0;
                }


                int
                f_10843_93193_93234(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 93193, 93234);
                    return 0;
                }


                bool
                f_10843_93670_93691(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = IsNumericType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 93670, 93691);
                    return return_v;
                }


                bool
                f_10843_93695_93719(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsEnumType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 93695, 93719);
                    return return_v;
                }


                bool
                f_10843_93800_93826(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = IsNumericType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 93800, 93826);
                    return return_v;
                }


                bool
                f_10843_93830_93849(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsEnumType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 93830, 93849);
                    return return_v;
                }


                bool
                f_10843_93930_93949(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsEnumType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 93930, 93949);
                    return return_v;
                }


                bool
                f_10843_93953_93977(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsEnumType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 93953, 93977);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 93022, 94078);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 93022, 94078);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Conversion ClassifyImplicitNullableConversion(TypeSymbol source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 94109, 96154);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 94278, 94315);

                f_10843_94278_94314((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 94329, 94371);

                f_10843_94329_94370((object)destination != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 94931, 95044) || true) && (!f_10843_94936_94964(destination))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 94931, 95044);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 94998, 95029);

                    return Conversion.NoConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 94931, 95044);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 95060, 95134);

                TypeSymbol
                unwrappedDestination = f_10843_95094_95133(destination)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 95148, 95199);

                TypeSymbol
                unwrappedSource = f_10843_95177_95198(source)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 95215, 95327) || true) && (f_10843_95219_95247_M(!unwrappedSource.IsValueType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 95215, 95327);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 95281, 95312);

                    return Conversion.NoConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 95215, 95327);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 95343, 95550) || true) && (f_10843_95347_95415(this, unwrappedSource, unwrappedDestination))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 95343, 95550);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 95449, 95535);

                    return f_10843_95456_95534(ConversionKind.ImplicitNullable, Conversion.IdentityUnderlying);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 95343, 95550);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 95566, 95779) || true) && (f_10843_95570_95637(unwrappedSource, unwrappedDestination))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 95566, 95779);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 95671, 95764);

                    return f_10843_95678_95763(ConversionKind.ImplicitNullable, Conversion.ImplicitNumericUnderlying);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 95566, 95779);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 95795, 95912);

                var
                tupleConversion = f_10843_95817_95911(this, unwrappedSource, unwrappedDestination, ref useSiteDiagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 95926, 96096) || true) && (tupleConversion.Exists)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 95926, 96096);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 95986, 96081);

                    return f_10843_95993_96080(ConversionKind.ImplicitNullable, f_10843_96041_96079(tupleConversion));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 95926, 96096);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 96112, 96143);

                return Conversion.NoConversion;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 94109, 96154);

                int
                f_10843_94278_94314(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 94278, 94314);
                    return 0;
                }


                int
                f_10843_94329_94370(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 94329, 94370);
                    return 0;
                }


                bool
                f_10843_94936_94964(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 94936, 94964);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10843_95094_95133(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 95094, 95133);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10843_95177_95198(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 95177, 95198);
                    return return_v;
                }


                bool
                f_10843_95219_95247_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 95219, 95247);
                    return return_v;
                }


                bool
                f_10843_95347_95415(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type2)
                {
                    var return_v = this_param.HasIdentityConversionInternal(type1, type2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 95347, 95415);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_95456_95534(Microsoft.CodeAnalysis.CSharp.ConversionKind
                kind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
                nestedConversions)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind, nestedConversions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 95456, 95534);
                    return return_v;
                }


                bool
                f_10843_95570_95637(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination)
                {
                    var return_v = HasImplicitNumericConversion(source, destination);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 95570, 95637);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_95678_95763(Microsoft.CodeAnalysis.CSharp.ConversionKind
                kind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
                nestedConversions)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind, nestedConversions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 95678, 95763);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_95817_95911(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.ClassifyImplicitTupleConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 95817, 95911);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
                f_10843_96041_96079(Microsoft.CodeAnalysis.CSharp.Conversion
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 96041, 96079);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_95993_96080(Microsoft.CodeAnalysis.CSharp.ConversionKind
                kind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
                nestedConversions)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind, nestedConversions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 95993, 96080);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 94109, 96154);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 94109, 96154);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private delegate Conversion ClassifyConversionFromExpressionDelegate(ConversionsBase conversions, BoundExpression sourceExpression, TypeWithAnnotations destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics, bool arg);
        private delegate Conversion ClassifyConversionFromTypeDelegate(ConversionsBase conversions, TypeWithAnnotations source, TypeWithAnnotations destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics, bool arg);

        private Conversion GetImplicitTupleLiteralConversion(BoundTupleLiteral source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 96622, 97479);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 96983, 97017);

                f_10843_96983_97016(!IncludeNullability);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 97031, 97468);

                return f_10843_97038_97467(this, source, destination, ref useSiteDiagnostics, ConversionKind.ImplicitTupleLiteral, (ConversionsBase conversions, BoundExpression s, TypeWithAnnotations d, ref HashSet<DiagnosticInfo> u, bool a)
                                    => conversions.ClassifyImplicitConversionFromExpression(s, d.Type, ref u), arg: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 96622, 97479);

                int
                f_10843_96983_97016(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 96983, 97016);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_97038_97467(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Microsoft.CodeAnalysis.CSharp.ConversionKind
                kind, Microsoft.CodeAnalysis.CSharp.ConversionsBase.ClassifyConversionFromExpressionDelegate
                classifyConversion, bool
                arg)
                {
                    var return_v = this_param.GetTupleLiteralConversion(source, destination, ref useSiteDiagnostics, kind, classifyConversion, arg: arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 97038, 97467);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 96622, 97479);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 96622, 97479);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Conversion GetExplicitTupleLiteralConversion(BoundTupleLiteral source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics, bool forCast)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 97491, 98333);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 97866, 97900);

                f_10843_97866_97899(!IncludeNullability);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 97914, 98322);

                return f_10843_97921_98321(this, source, destination, ref useSiteDiagnostics, ConversionKind.ExplicitTupleLiteral, (ConversionsBase conversions, BoundExpression s, TypeWithAnnotations d, ref HashSet<DiagnosticInfo> u, bool a) => conversions.ClassifyConversionFromExpression(s, d.Type, ref u, a), forCast);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 97491, 98333);

                int
                f_10843_97866_97899(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 97866, 97899);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_97921_98321(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Microsoft.CodeAnalysis.CSharp.ConversionKind
                kind, Microsoft.CodeAnalysis.CSharp.ConversionsBase.ClassifyConversionFromExpressionDelegate
                classifyConversion, bool
                arg)
                {
                    var return_v = this_param.GetTupleLiteralConversion(source, destination, ref useSiteDiagnostics, kind, classifyConversion, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 97921, 98321);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 97491, 98333);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 97491, 98333);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Conversion GetTupleLiteralConversion(
                    BoundTupleLiteral source,
                    TypeSymbol destination,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics,
                    ConversionKind kind,
                    ClassifyConversionFromExpressionDelegate classifyConversion,
                    bool arg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 98345, 99879);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 98683, 98716);

                var
                arguments = f_10843_98699_98715(source)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 98827, 98966) || true) && (!f_10843_98832_98886(destination, arguments.Length))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 98827, 98966);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 98920, 98951);

                    return Conversion.NoConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 98827, 98966);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 98982, 99052);

                var
                targetElementTypes = f_10843_99007_99051(destination)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 99066, 99126);

                f_10843_99066_99125(arguments.Length == targetElementTypes.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 99222, 99303);

                var
                argumentConversions = f_10843_99248_99302(arguments.Length)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 99326, 99331);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 99317, 99782) || true) && (i < arguments.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 99355, 99358)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 99317, 99782))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 99317, 99782);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 99392, 99420);

                        var
                        argument = arguments[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 99438, 99538);

                        var
                        result = f_10843_99451_99537(classifyConversion, this, argument, targetElementTypes[i], ref useSiteDiagnostics, arg)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 99556, 99715) || true) && (f_10843_99560_99574_M(!result.Exists))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 99556, 99715);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 99616, 99643);

                            f_10843_99616_99642(argumentConversions);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 99665, 99696);

                            return Conversion.NoConversion;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 99556, 99715);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 99735, 99767);

                        f_10843_99735_99766(
                                        argumentConversions, result);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10843, 1, 466);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10843, 1, 466);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 99798, 99868);

                return f_10843_99805_99867(kind, f_10843_99826_99866(argumentConversions));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 98345, 99879);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10843_98699_98715(Microsoft.CodeAnalysis.CSharp.BoundTupleLiteral
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 98699, 98715);
                    return return_v;
                }


                bool
                f_10843_98832_98886(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param, int
                targetCardinality)
                {
                    var return_v = this_param.IsTupleTypeOfCardinality(targetCardinality);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 98832, 98886);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10843_99007_99051(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TupleElementTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 99007, 99051);
                    return return_v;
                }


                int
                f_10843_99066_99125(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 99066, 99125);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Conversion>
                f_10843_99248_99302(int
                capacity)
                {
                    var return_v = ArrayBuilder<Conversion>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 99248, 99302);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_99451_99537(Microsoft.CodeAnalysis.CSharp.ConversionsBase.ClassifyConversionFromExpressionDelegate
                this_param, Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions, Microsoft.CodeAnalysis.CSharp.BoundExpression
                sourceExpression, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, bool
                arg)
                {
                    var return_v = this_param.Invoke(conversions, sourceExpression, destination, ref useSiteDiagnostics, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 99451, 99537);
                    return return_v;
                }


                bool
                f_10843_99560_99574_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 99560, 99574);
                    return return_v;
                }


                int
                f_10843_99616_99642(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Conversion>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 99616, 99642);
                    return 0;
                }


                int
                f_10843_99735_99766(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Conversion>
                this_param, Microsoft.CodeAnalysis.CSharp.Conversion
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 99735, 99766);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
                f_10843_99826_99866(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Conversion>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 99826, 99866);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_99805_99867(Microsoft.CodeAnalysis.CSharp.ConversionKind
                kind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
                nestedConversions)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind, nestedConversions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 99805, 99867);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 98345, 99879);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 98345, 99879);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Conversion ClassifyImplicitTupleConversion(TypeSymbol source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 99891, 100734);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 100057, 100723);

                return f_10843_100064_100722(this, source, destination, ref useSiteDiagnostics, ConversionKind.ImplicitTuple, (ConversionsBase conversions, TypeWithAnnotations s, TypeWithAnnotations d, ref HashSet<DiagnosticInfo> u, bool a) =>
                                {
                                    if (!conversions.HasTopLevelNullabilityImplicitConversion(s, d))
                                    {
                                        return Conversion.NoConversion;
                                    }
                                    return conversions.ClassifyImplicitConversionFromType(s.Type, d.Type, ref u);
                                }, arg: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 99891, 100734);

                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_100064_100722(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Microsoft.CodeAnalysis.CSharp.ConversionKind
                kind, Microsoft.CodeAnalysis.CSharp.ConversionsBase.ClassifyConversionFromTypeDelegate
                classifyConversion, bool
                arg)
                {
                    var return_v = this_param.ClassifyTupleConversion(source, destination, ref useSiteDiagnostics, kind, classifyConversion, arg: arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 100064, 100722);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 99891, 100734);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 99891, 100734);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Conversion ClassifyExplicitTupleConversion(TypeSymbol source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics, bool forCast)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 100746, 101595);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 100926, 101584);

                return f_10843_100933_101583(this, source, destination, ref useSiteDiagnostics, ConversionKind.ExplicitTuple, (ConversionsBase conversions, TypeWithAnnotations s, TypeWithAnnotations d, ref HashSet<DiagnosticInfo> u, bool a) =>
                                {
                                    if (!conversions.HasTopLevelNullabilityImplicitConversion(s, d))
                                    {
                                        return Conversion.NoConversion;
                                    }
                                    return conversions.ClassifyConversionFromType(s.Type, d.Type, ref u, a);
                                }, forCast);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 100746, 101595);

                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_100933_101583(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, Microsoft.CodeAnalysis.CSharp.ConversionKind
                kind, Microsoft.CodeAnalysis.CSharp.ConversionsBase.ClassifyConversionFromTypeDelegate
                classifyConversion, bool
                arg)
                {
                    var return_v = this_param.ClassifyTupleConversion(source, destination, ref useSiteDiagnostics, kind, classifyConversion, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 100933, 101583);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 100746, 101595);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 100746, 101595);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Conversion ClassifyTupleConversion(
                    TypeSymbol source,
                    TypeSymbol destination,
                    ref HashSet<DiagnosticInfo> useSiteDiagnostics,
                    ConversionKind kind,
                    ClassifyConversionFromTypeDelegate classifyConversion,
                    bool arg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 101607, 102991);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 101930, 101978);

                ImmutableArray<TypeWithAnnotations>
                sourceTypes
                = default(ImmutableArray<TypeWithAnnotations>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 101992, 102038);

                ImmutableArray<TypeWithAnnotations>
                destTypes
                = default(ImmutableArray<TypeWithAnnotations>);

                // LAFHIS
                bool f_temp_1(TypeSymbol t, out ImmutableArray<TypeWithAnnotations> s)
                {
                    var temp = t.TryGetElementTypesWithAnnotationsIfTupleType(out s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 102059, 102127);
                    return temp;
                }

                bool f_temp_2(TypeSymbol t, out ImmutableArray<TypeWithAnnotations> s)
                {
                    var temp = t.TryGetElementTypesWithAnnotationsIfTupleType(out s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 102149, 102220);
                    return temp;
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 102054, 102359) || true) && 
                    (!f_temp_1(source, out sourceTypes) /*source.TryGetElementTypesWithAnnotationsIfTupleType(out sourceTypes)*/ || 
                    (DynAbs.Tracing.TraceSender.Expression_False(10843, 102058, 102220) || 
                    !f_temp_2(destination, out destTypes) /*destination.TryGetElementTypesWithAnnotationsIfTupleType(out destTypes)*/) || 
                    (DynAbs.Tracing.TraceSender.Expression_False(10843, 102058, 102279) || 
                    sourceTypes.Length != destTypes.Length))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 102054, 102359);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 102313, 102344);

                    return Conversion.NoConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 102054, 102359);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 102375, 102456);

                var
                nestedConversions = f_10843_102399_102455(sourceTypes.Length)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 102479, 102484);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 102470, 102896) || true) && (i < sourceTypes.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 102510, 102513)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 102470, 102896))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 102470, 102896);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 102547, 102648);

                        var
                        conversion = f_10843_102564_102647(classifyConversion, this, sourceTypes[i], destTypes[i], ref useSiteDiagnostics, arg)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 102666, 102827) || true) && (f_10843_102670_102688_M(!conversion.Exists))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 102666, 102827);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 102730, 102755);

                            f_10843_102730_102754(nestedConversions);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 102777, 102808);

                            return Conversion.NoConversion;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 102666, 102827);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 102847, 102881);

                        f_10843_102847_102880(
                                        nestedConversions, conversion);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10843, 1, 427);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10843, 1, 427);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 102912, 102980);

                return f_10843_102919_102979(kind, f_10843_102940_102978(nestedConversions));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 101607, 102991);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Conversion>
                f_10843_102399_102455(int
                capacity)
                {
                    var return_v = ArrayBuilder<Conversion>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 102399, 102455);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_102564_102647(Microsoft.CodeAnalysis.CSharp.ConversionsBase.ClassifyConversionFromTypeDelegate
                this_param, Microsoft.CodeAnalysis.CSharp.ConversionsBase
                conversions, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, bool
                arg)
                {
                    var return_v = this_param.Invoke(conversions, source, destination, ref useSiteDiagnostics, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 102564, 102647);
                    return return_v;
                }


                bool
                f_10843_102670_102688_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 102670, 102688);
                    return return_v;
                }


                int
                f_10843_102730_102754(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Conversion>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 102730, 102754);
                    return 0;
                }


                int
                f_10843_102847_102880(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Conversion>
                this_param, Microsoft.CodeAnalysis.CSharp.Conversion
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 102847, 102880);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
                f_10843_102940_102978(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Conversion>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 102940, 102978);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_102919_102979(Microsoft.CodeAnalysis.CSharp.ConversionKind
                kind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
                nestedConversions)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind, nestedConversions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 102919, 102979);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 101607, 102991);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 101607, 102991);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Conversion ClassifyExplicitNullableConversion(TypeSymbol source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics, bool forCast)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 103003, 105712);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 103186, 103223);

                f_10843_103186_103222((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 103237, 103279);

                f_10843_103237_103278((object)destination != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 103896, 104037) || true) && (!f_10843_103901_103924(source) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 103900, 103957) && !f_10843_103929_103957(destination)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 103896, 104037);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 103991, 104022);

                    return Conversion.NoConversion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 103896, 104037);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 104053, 104104);

                TypeSymbol
                unwrappedSource = f_10843_104082_104103(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 104118, 104179);

                TypeSymbol
                unwrappedDestination = f_10843_104152_104178(destination)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 104195, 104402) || true) && (f_10843_104199_104267(this, unwrappedSource, unwrappedDestination))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 104195, 104402);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 104301, 104387);

                    return f_10843_104308_104386(ConversionKind.ExplicitNullable, Conversion.IdentityUnderlying);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 104195, 104402);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 104418, 104631) || true) && (f_10843_104422_104489(unwrappedSource, unwrappedDestination))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 104418, 104631);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 104523, 104616);

                    return f_10843_104530_104615(ConversionKind.ExplicitNullable, Conversion.ImplicitNumericUnderlying);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 104418, 104631);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 104647, 104860) || true) && (f_10843_104651_104718(unwrappedSource, unwrappedDestination))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 104647, 104860);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 104752, 104845);

                    return f_10843_104759_104844(ConversionKind.ExplicitNullable, Conversion.ExplicitNumericUnderlying);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 104647, 104860);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 104876, 105002);

                var
                tupleConversion = f_10843_104898_105001(this, unwrappedSource, unwrappedDestination, ref useSiteDiagnostics, forCast)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 105016, 105186) || true) && (tupleConversion.Exists)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 105016, 105186);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 105076, 105171);

                    return f_10843_105083_105170(ConversionKind.ExplicitNullable, f_10843_105131_105169(tupleConversion));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 105016, 105186);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 105202, 105423) || true) && (f_10843_105206_105277(unwrappedSource, unwrappedDestination))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 105202, 105423);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 105311, 105408);

                    return f_10843_105318_105407(ConversionKind.ExplicitNullable, Conversion.ExplicitEnumerationUnderlying);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 105202, 105423);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 105439, 105654) || true) && (f_10843_105443_105511(unwrappedSource, unwrappedDestination))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 105439, 105654);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 105545, 105639);

                    return f_10843_105552_105638(ConversionKind.ExplicitNullable, Conversion.PointerToIntegerUnderlying);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 105439, 105654);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 105670, 105701);

                return Conversion.NoConversion;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 103003, 105712);

                int
                f_10843_103186_103222(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 103186, 103222);
                    return 0;
                }


                int
                f_10843_103237_103278(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 103237, 103278);
                    return 0;
                }


                bool
                f_10843_103901_103924(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 103901, 103924);
                    return return_v;
                }


                bool
                f_10843_103929_103957(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 103929, 103957);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10843_104082_104103(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 104082, 104103);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10843_104152_104178(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 104152, 104178);
                    return return_v;
                }


                bool
                f_10843_104199_104267(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type2)
                {
                    var return_v = this_param.HasIdentityConversionInternal(type1, type2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 104199, 104267);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_104308_104386(Microsoft.CodeAnalysis.CSharp.ConversionKind
                kind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
                nestedConversions)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind, nestedConversions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 104308, 104386);
                    return return_v;
                }


                bool
                f_10843_104422_104489(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination)
                {
                    var return_v = HasImplicitNumericConversion(source, destination);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 104422, 104489);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_104530_104615(Microsoft.CodeAnalysis.CSharp.ConversionKind
                kind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
                nestedConversions)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind, nestedConversions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 104530, 104615);
                    return return_v;
                }


                bool
                f_10843_104651_104718(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination)
                {
                    var return_v = HasExplicitNumericConversion(source, destination);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 104651, 104718);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_104759_104844(Microsoft.CodeAnalysis.CSharp.ConversionKind
                kind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
                nestedConversions)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind, nestedConversions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 104759, 104844);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_104898_105001(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics, bool
                forCast)
                {
                    var return_v = this_param.ClassifyExplicitTupleConversion(source, destination, ref useSiteDiagnostics, forCast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 104898, 105001);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
                f_10843_105131_105169(Microsoft.CodeAnalysis.CSharp.Conversion
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 105131, 105169);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_105083_105170(Microsoft.CodeAnalysis.CSharp.ConversionKind
                kind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
                nestedConversions)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind, nestedConversions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 105083, 105170);
                    return return_v;
                }


                bool
                f_10843_105206_105277(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination)
                {
                    var return_v = HasExplicitEnumerationConversion(source, destination);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 105206, 105277);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_105318_105407(Microsoft.CodeAnalysis.CSharp.ConversionKind
                kind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
                nestedConversions)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind, nestedConversions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 105318, 105407);
                    return return_v;
                }


                bool
                f_10843_105443_105511(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination)
                {
                    var return_v = HasPointerToIntegerConversion(source, destination);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 105443, 105511);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10843_105552_105638(Microsoft.CodeAnalysis.CSharp.ConversionKind
                kind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Conversion>
                nestedConversions)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Conversion(kind, nestedConversions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 105552, 105638);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 103003, 105712);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 103003, 105712);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool HasCovariantArrayConversion(TypeSymbol source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 105724, 106685);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 105880, 105917);

                f_10843_105880_105916((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 105931, 105973);

                f_10843_105931_105972((object)destination != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 105987, 106021);

                var
                s = source as ArrayTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 106035, 106074);

                var
                d = destination as ArrayTypeSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 106088, 106192) || true) && ((object)s == null || (DynAbs.Tracing.TraceSender.Expression_False(10843, 106092, 106130) || (object)d == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 106088, 106192);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 106164, 106177);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 106088, 106192);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 106323, 106409) || true) && (!f_10843_106328_106347(s, d))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 106323, 106409);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 106381, 106394);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 106323, 106409);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 106552, 106674);

                return f_10843_106559_106673(this, f_10843_106590_106618(s), f_10843_106620_106648(d), ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 105724, 106685);

                int
                f_10843_105880_105916(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 105880, 105916);
                    return 0;
                }


                int
                f_10843_105931_105972(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 105931, 105972);
                    return 0;
                }


                bool
                f_10843_106328_106347(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                other)
                {
                    var return_v = this_param.HasSameShapeAs(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 106328, 106347);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10843_106590_106618(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 106590, 106618);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10843_106620_106648(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 106620, 106648);
                    return return_v;
                }


                bool
                f_10843_106559_106673(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasImplicitReferenceConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 106559, 106673);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 105724, 106685);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 105724, 106685);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool HasIdentityOrImplicitReferenceConversion(TypeSymbol source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 106697, 107199);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 106865, 106902);

                f_10843_106865_106901((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 106916, 106958);

                f_10843_106916_106957((object)destination != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 106974, 107089) || true) && (f_10843_106978_107028(this, source, destination))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 106974, 107089);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 107062, 107074);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 106974, 107089);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 107105, 107188);

                return f_10843_107112_107187(this, source, destination, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 106697, 107199);

                int
                f_10843_106865_106901(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 106865, 106901);
                    return 0;
                }


                int
                f_10843_106916_106957(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 106916, 106957);
                    return 0;
                }


                bool
                f_10843_106978_107028(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type2)
                {
                    var return_v = this_param.HasIdentityConversionInternal(type1, type2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 106978, 107028);
                    return return_v;
                }


                bool
                f_10843_107112_107187(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasImplicitReferenceConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 107112, 107187);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 106697, 107199);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 106697, 107199);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool HasImplicitDynamicConversionFromExpression(TypeSymbol expressionType, TypeSymbol destination)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10843, 107211, 107651);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 107485, 107527);

                f_10843_107485_107526((object)destination != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 107541, 107640);

                return f_10843_107548_107568_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(expressionType, 10843, 107548, 107568)?.Kind) == SymbolKind.DynamicType && (DynAbs.Tracing.TraceSender.Expression_True(10843, 107548, 107639) && !f_10843_107599_107639(destination));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10843, 107211, 107651);

                int
                f_10843_107485_107526(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 107485, 107526);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind?
                f_10843_107548_107568_M(Microsoft.CodeAnalysis.SymbolKind?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 107548, 107568);
                    return return_v;
                }


                bool
                f_10843_107599_107639(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsPointerOrFunctionPointer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 107599, 107639);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 107211, 107651);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 107211, 107651);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool HasExplicitDynamicConversion(TypeSymbol source, TypeSymbol destination)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10843, 107663, 108242);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 108034, 108071);

                f_10843_108034_108070((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 108085, 108127);

                f_10843_108085_108126((object)destination != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 108141, 108231);

                return f_10843_108148_108159(source) == SymbolKind.DynamicType && (DynAbs.Tracing.TraceSender.Expression_True(10843, 108148, 108230) && !f_10843_108190_108230(destination));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10843, 107663, 108242);

                int
                f_10843_108034_108070(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 108034, 108070);
                    return 0;
                }


                int
                f_10843_108085_108126(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 108085, 108126);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10843_108148_108159(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 108148, 108159);
                    return return_v;
                }


                bool
                f_10843_108190_108230(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsPointerOrFunctionPointer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 108190, 108230);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 107663, 108242);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 107663, 108242);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool HasArrayConversionToInterface(ArrayTypeSymbol source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 108254, 110454);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 108417, 108454);

                f_10843_108417_108453((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 108468, 108510);

                f_10843_108468_108509((object)destination != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 108526, 108609) || true) && (f_10843_108530_108547_M(!source.IsSZArray))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 108526, 108609);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 108581, 108594);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 108526, 108609);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 108625, 108721) || true) && (!f_10843_108630_108659(destination))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 108625, 108721);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 108693, 108706);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 108625, 108721);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 109468, 109602) || true) && (f_10843_109472_109495(destination) == SpecialType.System_Collections_IEnumerable)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 109468, 109602);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 109575, 109587);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 109468, 109602);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 109618, 109680);

                NamedTypeSymbol
                destinationAgg = (NamedTypeSymbol)destination
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 109696, 109804) || true) && (f_10843_109700_109737(destinationAgg) != 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 109696, 109804);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 109776, 109789);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 109696, 109804);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 109820, 109935) || true) && (!f_10843_109825_109873(destinationAgg))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 109820, 109935);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 109907, 109920);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 109820, 109935);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 109951, 110019);

                TypeWithAnnotations
                elementType = f_10843_109985_110018(source)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 110033, 110152);

                TypeWithAnnotations
                argument0 = f_10843_110065_110151(destinationAgg, 0, ref useSiteDiagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 110168, 110321) || true) && (IncludeNullability && (DynAbs.Tracing.TraceSender.Expression_True(10843, 110172, 110259) && !f_10843_110195_110259(this, elementType, argument0)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 110168, 110321);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 110293, 110306);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 110168, 110321);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 110337, 110443);

                return f_10843_110344_110442(this, elementType.Type, argument0.Type, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 108254, 110454);

                int
                f_10843_108417_108453(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 108417, 108453);
                    return 0;
                }


                int
                f_10843_108468_108509(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 108468, 108509);
                    return 0;
                }


                bool
                f_10843_108530_108547_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 108530, 108547);
                    return return_v;
                }


                bool
                f_10843_108630_108659(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 108630, 108659);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10843_109472_109495(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 109472, 109495);
                    return return_v;
                }


                int
                f_10843_109700_109737(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.AllTypeArgumentCount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 109700, 109737);
                    return return_v;
                }


                bool
                f_10843_109825_109873(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                _type)
                {
                    var return_v = _type.IsPossibleArrayGenericInterface();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 109825, 109873);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10843_109985_110018(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 109985, 110018);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10843_110065_110151(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, int
                index, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.TypeArgumentWithDefinitionUseSiteDiagnostics(index, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 110065, 110151);
                    return return_v;
                }


                bool
                f_10843_110195_110259(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                destination)
                {
                    var return_v = this_param.HasTopLevelNullabilityImplicitConversion(source, destination);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 110195, 110259);
                    return return_v;
                }


                bool
                f_10843_110344_110442(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasIdentityOrImplicitReferenceConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 110344, 110442);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 108254, 110454);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 108254, 110454);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool HasImplicitReferenceConversion(TypeWithAnnotations source, TypeWithAnnotations destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 110466, 111472);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 110643, 111354) || true) && (IncludeNullability)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 110643, 111354);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 110699, 110839) || true) && (!f_10843_110704_110765(this, source, destination))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 110699, 110839);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 110807, 110820);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 110699, 110839);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 111092, 111339) || true) && (source.NullableAnnotation != destination.NullableAnnotation && (DynAbs.Tracing.TraceSender.Expression_True(10843, 111096, 111266) && f_10843_111180_111266(source.Type, destination.Type, includeNullability: true)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 111092, 111339);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 111308, 111320);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 111092, 111339);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 110643, 111354);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 111368, 111461);

                return f_10843_111375_111460(this, source.Type, destination.Type, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 110466, 111472);

                bool
                f_10843_110704_110765(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                destination)
                {
                    var return_v = this_param.HasTopLevelNullabilityImplicitConversion(source, destination);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 110704, 110765);
                    return return_v;
                }


                bool
                f_10843_111180_111266(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type2, bool
                includeNullability)
                {
                    var return_v = HasIdentityConversionInternal(type1, type2, includeNullability: includeNullability);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 111180, 111266);
                    return return_v;
                }


                bool
                f_10843_111375_111460(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasImplicitReferenceConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 111375, 111460);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 110466, 111472);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 110466, 111472);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool HasImplicitReferenceConversion(TypeSymbol source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 111484, 114520);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 111644, 111681);

                f_10843_111644_111680((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 111695, 111737);

                f_10843_111695_111736((object)destination != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 111753, 111839) || true) && (f_10843_111757_111777(source))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 111753, 111839);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 111811, 111824);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 111753, 111839);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 111855, 111944) || true) && (f_10843_111859_111882_M(!source.IsReferenceType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 111855, 111944);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 111916, 111929);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 111855, 111944);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 112425, 112588) || true) && (f_10843_112429_112452(destination) == SpecialType.System_Object || (DynAbs.Tracing.TraceSender.Expression_False(10843, 112429, 112527) || f_10843_112485_112501(destination) == SymbolKind.DynamicType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 112425, 112588);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 112561, 112573);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 112425, 112588);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 112604, 114369);

                switch (f_10843_112612_112627(source))
                {

                    case TypeKind.Class:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 112604, 114369);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 112806, 112980) || true) && (f_10843_112810_112835(destination) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 112810, 112895) && f_10843_112839_112895(this, source, destination, ref useSiteDiagnostics)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 112806, 112980);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 112945, 112957);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 112806, 112980);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 113004, 113089);

                        return f_10843_113011_113088(this, source, destination, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 112604, 114369);

                    case TypeKind.Interface:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 112604, 114369);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 113330, 113415);

                        return f_10843_113337_113414(this, source, destination, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 112604, 114369);

                    case TypeKind.Delegate:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 112604, 114369);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 113651, 113737);

                        return f_10843_113658_113736(this, source, destination, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 112604, 114369);

                    case TypeKind.TypeParameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 112604, 114369);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 113807, 113924);

                        return f_10843_113814_113923(this, source, destination, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 112604, 114369);

                    case TypeKind.Array:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 112604, 114369);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 114271, 114354);

                        return f_10843_114278_114353(this, source, destination, ref useSiteDiagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 112604, 114369);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 114496, 114509);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 111484, 114520);

                int
                f_10843_111644_111680(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 111644, 111680);
                    return 0;
                }


                int
                f_10843_111695_111736(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 111695, 111736);
                    return 0;
                }


                bool
                f_10843_111757_111777(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 111757, 111777);
                    return return_v;
                }


                bool
                f_10843_111859_111882_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 111859, 111882);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10843_112429_112452(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 112429, 112452);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10843_112485_112501(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 112485, 112501);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10843_112612_112627(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 112612, 112627);
                    return return_v;
                }


                bool
                f_10843_112810_112835(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsClassType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 112810, 112835);
                    return return_v;
                }


                bool
                f_10843_112839_112895(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                derivedType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                baseType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.IsBaseClass(derivedType, baseType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 112839, 112895);
                    return return_v;
                }


                bool
                f_10843_113011_113088(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasImplicitConversionToInterface(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 113011, 113088);
                    return return_v;
                }


                bool
                f_10843_113337_113414(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasImplicitConversionToInterface(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 113337, 113414);
                    return return_v;
                }


                bool
                f_10843_113658_113736(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasImplicitConversionFromDelegate(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 113658, 113736);
                    return return_v;
                }


                bool
                f_10843_113814_113923(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasImplicitReferenceTypeParameterConversion((Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol)source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 113814, 113923);
                    return return_v;
                }


                bool
                f_10843_114278_114353(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasImplicitConversionFromArray(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 114278, 114353);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 111484, 114520);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 111484, 114520);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool HasImplicitConversionToInterface(TypeSymbol source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 114532, 115892);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 114693, 114789) || true) && (!f_10843_114698_114727(destination))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 114693, 114789);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 114761, 114774);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 114693, 114789);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 114940, 115095) || true) && (f_10843_114944_114964(source))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 114940, 115095);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 114998, 115080);

                    return f_10843_115005_115079(this, source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 114940, 115095);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 115397, 115852) || true) && (f_10843_115401_115425(source))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 115397, 115852);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 115459, 115610) || true) && (f_10843_115463_115537(this, source, destination, ref useSiteDiagnostics))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 115459, 115610);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 115579, 115591);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 115459, 115610);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 115630, 115837) || true) && (!f_10843_115635_115685(this, source, destination) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 115634, 115764) && f_10843_115689_115764(this, source, destination, ref useSiteDiagnostics)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 115630, 115837);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 115806, 115818);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 115630, 115837);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 115397, 115852);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 115868, 115881);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 114532, 115892);

                bool
                f_10843_114698_114727(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 114698, 114727);
                    return return_v;
                }


                bool
                f_10843_114944_114964(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsClassType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 114944, 114964);
                    return return_v;
                }


                bool
                f_10843_115005_115079(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                derivedType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                baseType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasAnyBaseInterfaceConversion(derivedType, baseType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 115005, 115079);
                    return return_v;
                }


                bool
                f_10843_115401_115425(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 115401, 115425);
                    return return_v;
                }


                bool
                f_10843_115463_115537(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                derivedType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                baseType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasAnyBaseInterfaceConversion(derivedType, baseType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 115463, 115537);
                    return return_v;
                }


                bool
                f_10843_115635_115685(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type2)
                {
                    var return_v = this_param.HasIdentityConversionInternal(type1, type2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 115635, 115685);
                    return return_v;
                }


                bool
                f_10843_115689_115764(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasInterfaceVarianceConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 115689, 115764);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 114532, 115892);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 114532, 115892);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool HasImplicitConversionFromArray(TypeSymbol source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 115904, 117618);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 116063, 116109);

                ArrayTypeSymbol
                s = source as ArrayTypeSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 116123, 116206) || true) && ((object)s == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 116123, 116206);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 116178, 116191);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 116123, 116206);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 116636, 116773) || true) && (f_10843_116640_116712(this, source, destination, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 116636, 116773);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 116746, 116758);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 116636, 116773);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 116889, 117014) || true) && (f_10843_116893_116925(destination) == SpecialType.System_Array)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 116889, 117014);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 116987, 116999);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 116889, 117014);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 117030, 117213) || true) && (f_10843_117034_117152(this, destination, f_10843_117063_117127(this.corLibrary, SpecialType.System_Array), ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 117030, 117213);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 117186, 117198);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 117030, 117213);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 117444, 117578) || true) && (f_10843_117448_117517(this, s, destination, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 117444, 117578);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 117551, 117563);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 117444, 117578);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 117594, 117607);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 115904, 117618);

                bool
                f_10843_116640_116712(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasCovariantArrayConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 116640, 116712);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10843_116893_116925(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetSpecialTypeSafe();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 116893, 116925);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10843_117063_117127(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.SpecialType
                type)
                {
                    var return_v = this_param.GetDeclaredSpecialType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 117063, 117127);
                    return return_v;
                }


                bool
                f_10843_117034_117152(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                baseType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                derivedType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.IsBaseInterface(baseType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)derivedType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 117034, 117152);
                    return return_v;
                }


                bool
                f_10843_117448_117517(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasArrayConversionToInterface(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 117448, 117517);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 115904, 117618);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 115904, 117618);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool HasImplicitConversionFromDelegate(TypeSymbol source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 117630, 119066);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 117792, 117882) || true) && (!f_10843_117797_117820(source))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 117792, 117882);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 117854, 117867);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 117792, 117882);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 118312, 118370);

                var
                specialDestination = f_10843_118337_118369(destination)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 118386, 118730) || true) && (specialDestination == SpecialType.System_MulticastDelegate || (DynAbs.Tracing.TraceSender.Expression_False(10843, 118390, 118518) || specialDestination == SpecialType.System_Delegate) || (DynAbs.Tracing.TraceSender.Expression_False(10843, 118390, 118669) || f_10843_118539_118669(this, destination, f_10843_118568_118644(this.corLibrary, SpecialType.System_MulticastDelegate), ref useSiteDiagnostics)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 118386, 118730);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 118703, 118715);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 118386, 118730);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 118887, 119026) || true) && (f_10843_118891_118965(this, source, destination, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 118887, 119026);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 118999, 119011);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 118887, 119026);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 119042, 119055);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 117630, 119066);

                bool
                f_10843_117797_117820(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 117797, 117820);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10843_118337_118369(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetSpecialTypeSafe();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 118337, 118369);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10843_118568_118644(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.SpecialType
                type)
                {
                    var return_v = this_param.GetDeclaredSpecialType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 118568, 118644);
                    return return_v;
                }


                bool
                f_10843_118539_118669(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                baseType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                derivedType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.IsBaseInterface(baseType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)derivedType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 118539, 118669);
                    return return_v;
                }


                bool
                f_10843_118891_118965(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasDelegateVarianceConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 118891, 118965);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 117630, 119066);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 117630, 119066);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool HasImplicitTypeParameterConversion(TypeParameterSymbol source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 119078, 119808);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 119249, 119402) || true) && (f_10843_119253_119341(this, source, destination, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 119249, 119402);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 119375, 119387);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 119249, 119402);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 119418, 119568) || true) && (f_10843_119422_119507(this, source, destination, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 119418, 119568);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 119541, 119553);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 119418, 119568);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 119584, 119768) || true) && ((f_10843_119589_119609(destination) == TypeKind.TypeParameter) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 119588, 119707) && f_10843_119657_119707(source, destination)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 119584, 119768);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 119741, 119753);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 119584, 119768);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 119784, 119797);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 119078, 119808);

                bool
                f_10843_119253_119341(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasImplicitReferenceTypeParameterConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 119253, 119341);
                    return return_v;
                }


                bool
                f_10843_119422_119507(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasImplicitBoxingTypeParameterConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 119422, 119507);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10843_119589_119609(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 119589, 119609);
                    return return_v;
                }


                bool
                f_10843_119657_119707(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeParameter2)
                {
                    var return_v = typeParameter1.DependsOn((Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol)typeParameter2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 119657, 119707);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 119078, 119808);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 119078, 119808);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool HasImplicitReferenceTypeParameterConversion(TypeParameterSymbol source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 119820, 121368);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 120001, 120038);

                f_10843_120001_120037((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 120052, 120094);

                f_10843_120052_120093((object)destination != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 120110, 120225) || true) && (f_10843_120114_120132(source))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 120110, 120225);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 120166, 120179);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 120110, 120225);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 120557, 120701) || true) && (f_10843_120561_120640(this, source, destination, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 120557, 120701);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 120674, 120686);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 120557, 120701);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 120903, 121055) || true) && (f_10843_120907_120994(this, source, destination, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 120903, 121055);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 121028, 121040);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 120903, 121055);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 121144, 121328) || true) && ((f_10843_121149_121169(destination) == TypeKind.TypeParameter) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 121148, 121267) && f_10843_121217_121267(source, destination)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 121144, 121328);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 121301, 121313);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 121144, 121328);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 121344, 121357);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 119820, 121368);

                int
                f_10843_120001_120037(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 120001, 120037);
                    return 0;
                }


                int
                f_10843_120052_120093(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 120052, 120093);
                    return 0;
                }


                bool
                f_10843_120114_120132(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 120114, 120132);
                    return return_v;
                }


                bool
                f_10843_120561_120640(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasImplicitEffectiveBaseConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 120561, 120640);
                    return return_v;
                }


                bool
                f_10843_120907_120994(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasImplicitEffectiveInterfaceSetConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 120907, 120994);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10843_121149_121169(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 121149, 121169);
                    return return_v;
                }


                bool
                f_10843_121217_121267(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeParameter2)
                {
                    var return_v = typeParameter1.DependsOn((Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol)typeParameter2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 121217, 121267);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 119820, 121368);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 119820, 121368);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool HasImplicitEffectiveBaseConversion(TypeParameterSymbol source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 121452, 122409);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 121680, 121755);

                var
                effectiveBaseClass = f_10843_121705_121754(source, ref useSiteDiagnostics)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 121769, 121896) || true) && (f_10843_121773_121835(this, effectiveBaseClass, destination))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 121769, 121896);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 121869, 121881);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 121769, 121896);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 121961, 122094) || true) && (f_10843_121965_122033(this, effectiveBaseClass, destination, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 121961, 122094);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 122067, 122079);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 121961, 122094);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 122218, 122369) || true) && (f_10843_122222_122308(this, effectiveBaseClass, destination, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 122218, 122369);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 122342, 122354);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 122218, 122369);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 122385, 122398);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 121452, 122409);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10843_121705_121754(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.EffectiveBaseClass(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 121705, 121754);
                    return return_v;
                }


                bool
                f_10843_121773_121835(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type2)
                {
                    var return_v = this_param.HasIdentityConversionInternal((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type1, type2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 121773, 121835);
                    return return_v;
                }


                bool
                f_10843_121965_122033(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                derivedType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                baseType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.IsBaseClass((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)derivedType, baseType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 121965, 122033);
                    return return_v;
                }


                bool
                f_10843_122222_122308(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                derivedType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                baseType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasAnyBaseInterfaceConversion((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)derivedType, baseType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 122222, 122308);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 121452, 122409);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 121452, 122409);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool HasImplicitEffectiveInterfaceSetConversion(TypeParameterSymbol source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 122421, 123238);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 122601, 122697) || true) && (!f_10843_122606_122635(destination))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 122601, 122697);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 122669, 122682);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 122601, 122697);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 122899, 123198);
                    foreach (var i in f_10843_122917_123002_I(f_10843_122917_123002(source, ref useSiteDiagnostics)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 122899, 123198);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 123036, 123183) || true) && (f_10843_123040_123110(this, i, destination, ref useSiteDiagnostics))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 123036, 123183);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 123152, 123164);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 123036, 123183);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 122899, 123198);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10843, 1, 300);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10843, 1, 300);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 123214, 123227);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 122421, 123238);

                bool
                f_10843_122606_122635(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 122606, 122635);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10843_122917_123002(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.AllEffectiveInterfacesWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 122917, 123002);
                    return return_v;
                }


                bool
                f_10843_123040_123110(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasInterfaceVarianceConversion((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 123040, 123110);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10843_122917_123002_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 122917, 123002);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 122421, 123238);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 122421, 123238);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool HasAnyBaseInterfaceConversion(TypeSymbol derivedType, TypeSymbol baseType, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 123250, 124102);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 123410, 123452);

                f_10843_123410_123451((object)derivedType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 123466, 123505);

                f_10843_123466_123504((object)baseType != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 123519, 123612) || true) && (!f_10843_123524_123550(baseType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 123519, 123612);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 123584, 123597);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 123519, 123612);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 123628, 123667);

                var
                d = derivedType as NamedTypeSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 123681, 123764) || true) && ((object)d == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 123681, 123764);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 123736, 123749);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 123681, 123764);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 123780, 124062);
                    foreach (var i in f_10843_123798_123869_I(f_10843_123798_123869(d, ref useSiteDiagnostics)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 123780, 124062);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 123903, 124047) || true) && (f_10843_123907_123974(this, i, baseType, ref useSiteDiagnostics))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 123903, 124047);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 124016, 124028);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 123903, 124047);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 123780, 124062);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10843, 1, 283);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10843, 1, 283);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 124078, 124091);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 123250, 124102);

                int
                f_10843_123410_123451(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 123410, 123451);
                    return 0;
                }


                int
                f_10843_123466_123504(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 123466, 123504);
                    return 0;
                }


                bool
                f_10843_123524_123550(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 123524, 123550);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10843_123798_123869(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.AllInterfacesWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 123798, 123869);
                    return return_v;
                }


                bool
                f_10843_123907_123974(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasInterfaceVarianceConversion((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 123907, 123974);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10843_123798_123869_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 123798, 123869);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 123250, 124102);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 123250, 124102);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool HasInterfaceVarianceConversion(TypeSymbol source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 124939, 125645);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 125098, 125135);

                f_10843_125098_125134((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 125149, 125191);

                f_10843_125149_125190((object)destination != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 125205, 125251);

                NamedTypeSymbol
                s = source as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 125265, 125316);

                NamedTypeSymbol
                d = destination as NamedTypeSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 125330, 125434) || true) && ((object)s == null || (DynAbs.Tracing.TraceSender.Expression_False(10843, 125334, 125372) || (object)d == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 125330, 125434);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 125406, 125419);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 125330, 125434);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 125450, 125560) || true) && (!f_10843_125455_125474(s) || (DynAbs.Tracing.TraceSender.Expression_False(10843, 125454, 125498) || !f_10843_125479_125498(d)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 125450, 125560);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 125532, 125545);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 125450, 125560);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 125576, 125634);

                return f_10843_125583_125633(this, s, d, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 124939, 125645);

                int
                f_10843_125098_125134(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 125098, 125134);
                    return 0;
                }


                int
                f_10843_125149_125190(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 125149, 125190);
                    return 0;
                }


                bool
                f_10843_125455_125474(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 125455, 125474);
                    return return_v;
                }


                bool
                f_10843_125479_125498(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 125479, 125498);
                    return return_v;
                }


                bool
                f_10843_125583_125633(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasVariantConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 125583, 125633);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 124939, 125645);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 124939, 125645);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool HasDelegateVarianceConversion(TypeSymbol source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 125657, 126360);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 125815, 125852);

                f_10843_125815_125851((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 125866, 125908);

                f_10843_125866_125907((object)destination != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 125922, 125968);

                NamedTypeSymbol
                s = source as NamedTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 125982, 126033);

                NamedTypeSymbol
                d = destination as NamedTypeSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 126047, 126151) || true) && ((object)s == null || (DynAbs.Tracing.TraceSender.Expression_False(10843, 126051, 126089) || (object)d == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 126047, 126151);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 126123, 126136);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 126047, 126151);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 126167, 126275) || true) && (!f_10843_126172_126190(s) || (DynAbs.Tracing.TraceSender.Expression_False(10843, 126171, 126213) || !f_10843_126195_126213(d)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 126167, 126275);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 126247, 126260);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 126167, 126275);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 126291, 126349);

                return f_10843_126298_126348(this, s, d, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 125657, 126360);

                int
                f_10843_125815_125851(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 125815, 125851);
                    return 0;
                }


                int
                f_10843_125866_125907(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 125866, 125907);
                    return 0;
                }


                bool
                f_10843_126172_126190(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 126172, 126190);
                    return return_v;
                }


                bool
                f_10843_126195_126213(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 126195, 126213);
                    return return_v;
                }


                bool
                f_10843_126298_126348(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasVariantConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 126298, 126348);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 125657, 126360);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 125657, 126360);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool HasVariantConversion(NamedTypeSymbol source, NamedTypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 126372, 128067);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 127184, 127573) || true) && (currentRecursionDepth >= MaximumRecursionDepth)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 127184, 127573);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 127545, 127558);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 127184, 127573);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 127709, 127774);

                var
                quickResult = f_10843_127727_127773(this, source, destination)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 127788, 127890) || true) && (f_10843_127792_127814(quickResult))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 127788, 127890);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 127848, 127875);

                    return f_10843_127855_127874(quickResult);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 127788, 127890);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 127906, 128056);

                return f_10843_127913_128055(f_10843_127913_127959(this, currentRecursionDepth + 1), source, destination, ref useSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 126372, 128067);

                Microsoft.CodeAnalysis.ThreeState
                f_10843_127727_127773(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                destination)
                {
                    var return_v = this_param.HasVariantConversionQuick(source, destination);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 127727, 127773);
                    return return_v;
                }


                bool
                f_10843_127792_127814(Microsoft.CodeAnalysis.ThreeState
                value)
                {
                    var return_v = value.HasValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 127792, 127814);
                    return return_v;
                }


                bool
                f_10843_127855_127874(Microsoft.CodeAnalysis.ThreeState
                value)
                {
                    var return_v = value.Value();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 127855, 127874);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionsBase
                f_10843_127913_127959(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, int
                currentRecursionDepth)
                {
                    var return_v = this_param.CreateInstance(currentRecursionDepth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 127913, 127959);
                    return return_v;
                }


                bool
                f_10843_127913_128055(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasVariantConversionNoCycleCheck(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 127913, 128055);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 126372, 128067);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 126372, 128067);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ThreeState HasVariantConversionQuick(NamedTypeSymbol source, NamedTypeSymbol destination)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 128079, 128750);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 128201, 128238);

                f_10843_128201_128237((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 128252, 128294);

                f_10843_128252_128293((object)destination != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 128310, 128436) || true) && (f_10843_128314_128364(this, source, destination))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 128310, 128436);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 128398, 128421);

                    return ThreeState.True;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 128310, 128436);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 128452, 128507);

                NamedTypeSymbol
                typeSymbol = f_10843_128481_128506(source)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 128521, 128697) || true) && (!f_10843_128526_128624(typeSymbol, f_10843_128556_128586(destination), TypeCompareKind.ConsiderEverything2))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 128521, 128697);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 128658, 128682);

                    return ThreeState.False;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 128521, 128697);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 128713, 128739);

                return ThreeState.Unknown;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 128079, 128750);

                int
                f_10843_128201_128237(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 128201, 128237);
                    return 0;
                }


                int
                f_10843_128252_128293(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 128252, 128293);
                    return 0;
                }


                bool
                f_10843_128314_128364(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type2)
                {
                    var return_v = this_param.HasIdentityConversionInternal((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type1, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 128314, 128364);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10843_128481_128506(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 128481, 128506);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10843_128556_128586(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 128556, 128586);
                    return return_v;
                }


                bool
                f_10843_128526_128624(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 128526, 128624);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 128079, 128750);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 128079, 128750);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool HasVariantConversionNoCycleCheck(NamedTypeSymbol source, NamedTypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 128762, 133727);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 128933, 128970);

                f_10843_128933_128969((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 128984, 129026);

                f_10843_128984_129025((object)destination != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 129042, 129111);

                var
                typeParameters = f_10843_129063_129110()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 129125, 129199);

                var
                sourceTypeArguments = f_10843_129151_129198()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 129213, 129292);

                var
                destinationTypeArguments = f_10843_129244_129291()
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 129344, 129430);

                    f_10843_129344_129429(f_10843_129344_129369(source), typeParameters, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 129448, 129520);

                    f_10843_129448_129519(source, sourceTypeArguments, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 129538, 129620);

                    f_10843_129538_129619(destination, destinationTypeArguments, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 129640, 129765);

                    f_10843_129640_129764(f_10843_129653_129763(f_10843_129671_129696(source), f_10843_129698_129728(destination), TypeCompareKind.AllIgnoreOptions));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 129783, 129847);

                    f_10843_129783_129846(f_10843_129796_129816(typeParameters) == f_10843_129820_129845(sourceTypeArguments));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 129865, 129934);

                    f_10843_129865_129933(f_10843_129878_129898(typeParameters) == f_10843_129902_129932(destinationTypeArguments));
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 129963, 129977);

                        for (int
        paramIndex = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 129954, 133005) || true) && (paramIndex < f_10843_129992_130012(typeParameters))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 130014, 130026)
        , ++paramIndex, DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 129954, 133005))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 129954, 133005);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 130068, 130125);

                            var
                            sourceTypeArgument = f_10843_130093_130124(sourceTypeArguments, paramIndex)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 130147, 130214);

                            var
                            destinationTypeArgument = f_10843_130177_130213(destinationTypeArguments, paramIndex)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 130332, 130616) || true) && (f_10843_130336_130420(this, sourceTypeArgument.Type, destinationTypeArgument.Type) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 130336, 130534) && f_10843_130449_130534(this, sourceTypeArgument, destinationTypeArgument)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 130332, 130616);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 130584, 130593);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 130332, 130616);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 130640, 130735);

                            TypeParameterSymbol
                            typeParameterSymbol = (TypeParameterSymbol)typeParameters[paramIndex].Type
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 130759, 132986);

                            switch (f_10843_130767_130795(typeParameterSymbol))
                            {

                                case VarianceKind.None:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 130759, 132986);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 131695, 132124) || true) && (f_10843_131699_131747(f_10843_131716_131746(destination)) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 131699, 131898) && f_10843_131784_131898(destinationTypeArgument.Type, sourceTypeArgument.Type, TypeCompareKind.AllNullableIgnoreOptions)) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 131699, 132015) && f_10843_131935_132015(this, destinationTypeArgument, sourceTypeArgument)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 131695, 132124);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 132081, 132093);

                                        return true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 131695, 132124);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 132154, 132167);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 130759, 132986);

                                case VarianceKind.Out:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 130759, 132986);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 132247, 132461) || true) && (!f_10843_132252_132351(this, sourceTypeArgument, destinationTypeArgument, ref useSiteDiagnostics))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 132247, 132461);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 132417, 132430);

                                        return false;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 132247, 132461);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10843, 132491, 132497);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 130759, 132986);

                                case VarianceKind.In:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 130759, 132986);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 132576, 132790) || true) && (!f_10843_132581_132680(this, destinationTypeArgument, sourceTypeArgument, ref useSiteDiagnostics))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 132576, 132790);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 132746, 132759);

                                        return false;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 132576, 132790);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(10843, 132820, 132826);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 130759, 132986);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 130759, 132986);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 132892, 132963);

                                    throw f_10843_132898_132962(f_10843_132933_132961(typeParameterSymbol));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 130759, 132986);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10843, 1, 3052);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10843, 1, 3052);
                    }
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(10843, 133034, 133206);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 133074, 133096);

                    f_10843_133074_133095(typeParameters);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 133114, 133141);

                    f_10843_133114_133140(sourceTypeArguments);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 133159, 133191);

                    f_10843_133159_133190(destinationTypeArguments);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(10843, 133034, 133206);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 133222, 133234);

                return true;

                static bool isTypeIEquatable(NamedTypeSymbol type)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10843, 133250, 133716);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 133333, 133701);

                        return type is
                        {
                            IsInterface: true,
                            Name: "IEquatable",
                            ContainingNamespace: { Name: "System", ContainingNamespace: { IsGlobalNamespace: true } },
                            ContainingSymbol: { Kind: SymbolKind.Namespace },
                            TypeParameters: { Length: 1 }
                        };
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10843, 133250, 133716);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 133250, 133716);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 133250, 133716);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 128762, 133727);

                int
                f_10843_128933_128969(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 128933, 128969);
                    return 0;
                }


                int
                f_10843_128984_129025(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 128984, 129025);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10843_129063_129110()
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 129063, 129110);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10843_129151_129198()
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 129151, 129198);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10843_129244_129291()
                {
                    var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 129244, 129291);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10843_129344_129369(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 129344, 129369);
                    return return_v;
                }


                int
                f_10843_129344_129429(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                builder, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.GetAllTypeArguments(builder, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 129344, 129429);
                    return 0;
                }


                int
                f_10843_129448_129519(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                builder, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.GetAllTypeArguments(builder, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 129448, 129519);
                    return 0;
                }


                int
                f_10843_129538_129619(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                builder, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.GetAllTypeArguments(builder, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 129538, 129619);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10843_129671_129696(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 129671, 129696);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10843_129698_129728(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 129698, 129728);
                    return return_v;
                }


                bool
                f_10843_129653_129763(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 129653, 129763);
                    return return_v;
                }


                int
                f_10843_129640_129764(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 129640, 129764);
                    return 0;
                }


                int
                f_10843_129796_129816(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 129796, 129816);
                    return return_v;
                }


                int
                f_10843_129820_129845(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 129820, 129845);
                    return return_v;
                }


                int
                f_10843_129783_129846(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 129783, 129846);
                    return 0;
                }


                int
                f_10843_129878_129898(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 129878, 129898);
                    return return_v;
                }


                int
                f_10843_129902_129932(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 129902, 129932);
                    return return_v;
                }


                int
                f_10843_129865_129933(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 129865, 129933);
                    return 0;
                }


                int
                f_10843_129992_130012(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 129992, 130012);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10843_130093_130124(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 130093, 130124);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10843_130177_130213(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 130177, 130213);
                    return return_v;
                }


                bool
                f_10843_130336_130420(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type2)
                {
                    var return_v = this_param.HasIdentityConversionInternal(type1, type2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 130336, 130420);
                    return return_v;
                }


                bool
                f_10843_130449_130534(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                destination)
                {
                    var return_v = this_param.HasTopLevelNullabilityIdentityConversion(source, destination);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 130449, 130534);
                    return return_v;
                }


                Microsoft.CodeAnalysis.VarianceKind
                f_10843_130767_130795(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Variance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 130767, 130795);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10843_131716_131746(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 131716, 131746);
                    return return_v;
                }


                bool
                f_10843_131699_131747(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = isTypeIEquatable(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 131699, 131747);
                    return return_v;
                }


                bool
                f_10843_131784_131898(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 131784, 131898);
                    return return_v;
                }


                bool
                f_10843_131935_132015(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                destination)
                {
                    var return_v = this_param.HasAnyNullabilityImplicitConversion(source, destination);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 131935, 132015);
                    return return_v;
                }


                bool
                f_10843_132252_132351(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasImplicitReferenceConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 132252, 132351);
                    return return_v;
                }


                bool
                f_10843_132581_132680(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasImplicitReferenceConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 132581, 132680);
                    return return_v;
                }


                Microsoft.CodeAnalysis.VarianceKind
                f_10843_132933_132961(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Variance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 132933, 132961);
                    return return_v;
                }


                System.Exception
                f_10843_132898_132962(Microsoft.CodeAnalysis.VarianceKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 132898, 132962);
                    return return_v;
                }


                int
                f_10843_133074_133095(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 133074, 133095);
                    return 0;
                }


                int
                f_10843_133114_133140(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 133114, 133140);
                    return 0;
                }


                int
                f_10843_133159_133190(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 133159, 133190);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 128762, 133727);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 128762, 133727);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool HasImplicitBoxingTypeParameterConversion(TypeParameterSymbol source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 133763, 135944);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 133941, 133978);

                f_10843_133941_133977((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 133992, 134034);

                f_10843_133992_134033((object)destination != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 134050, 134210) || true) && (f_10843_134054_134076(source))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 134050, 134210);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 134110, 134123);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 134050, 134210);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 134542, 134686) || true) && (f_10843_134546_134625(this, source, destination, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 134542, 134686);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 134659, 134671);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 134542, 134686);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 134888, 135040) || true) && (f_10843_134892_134979(this, source, destination, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 134888, 135040);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 135013, 135025);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 134888, 135040);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 135132, 135316) || true) && ((f_10843_135137_135157(destination) == TypeKind.TypeParameter) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 135136, 135255) && f_10843_135205_135255(source, destination)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 135132, 135316);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 135289, 135301);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 135132, 135316);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 135797, 135904) || true) && (f_10843_135801_135817(destination) == SymbolKind.DynamicType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 135797, 135904);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 135877, 135889);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 135797, 135904);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 135920, 135933);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 133763, 135944);

                int
                f_10843_133941_133977(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 133941, 133977);
                    return 0;
                }


                int
                f_10843_133992_134033(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 133992, 134033);
                    return 0;
                }


                bool
                f_10843_134054_134076(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 134054, 134076);
                    return return_v;
                }


                bool
                f_10843_134546_134625(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasImplicitEffectiveBaseConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 134546, 134625);
                    return return_v;
                }


                bool
                f_10843_134892_134979(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasImplicitEffectiveInterfaceSetConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 134892, 134979);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10843_135137_135157(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 135137, 135157);
                    return return_v;
                }


                bool
                f_10843_135205_135255(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeParameter2)
                {
                    var return_v = typeParameter1.DependsOn((Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol)typeParameter2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 135205, 135255);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10843_135801_135817(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 135801, 135817);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 133763, 135944);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 133763, 135944);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool HasBoxingConversion(TypeSymbol source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 135956, 138388);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 136103, 136140);

                f_10843_136103_136139((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 136154, 136196);

                f_10843_136154_136195((object)destination != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 136301, 136536) || true) && ((f_10843_136306_136321(source) == TypeKind.TypeParameter) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 136305, 136475) && f_10843_136369_136475(this, source, destination, ref useSiteDiagnostics)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 136301, 136536);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 136509, 136521);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 136301, 136536);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 136682, 136799) || true) && (f_10843_136686_136705_M(!source.IsValueType) || (DynAbs.Tracing.TraceSender.Expression_False(10843, 136686, 136737) || f_10843_136709_136737_M(!destination.IsReferenceType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 136682, 136799);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 136771, 136784);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 136682, 136799);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 136983, 137159) || true) && (f_10843_136987_137010(source))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 136983, 137159);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 137044, 137144);

                    return f_10843_137051_137143(this, f_10843_137071_137105(source), destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 136983, 137159);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 137810, 137901) || true) && (f_10843_137814_137839(source))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 137810, 137901);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 137873, 137886);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 137810, 137901);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 137917, 138056) || true) && (f_10843_137921_137937(destination) == SymbolKind.DynamicType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 137917, 138056);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 137997, 138041);

                    return !f_10843_138005_138040(source);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 137917, 138056);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 138072, 138193) || true) && (f_10843_138076_138132(this, source, destination, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 138072, 138193);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 138166, 138178);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 138072, 138193);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 138209, 138348) || true) && (f_10843_138213_138287(this, source, destination, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 138209, 138348);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 138321, 138333);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 138209, 138348);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 138364, 138377);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 135956, 138388);

                int
                f_10843_136103_136139(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 136103, 136139);
                    return 0;
                }


                int
                f_10843_136154_136195(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 136154, 136195);
                    return 0;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10843_136306_136321(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 136306, 136321);
                    return return_v;
                }


                bool
                f_10843_136369_136475(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasImplicitBoxingTypeParameterConversion((Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol)source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 136369, 136475);
                    return return_v;
                }


                bool
                f_10843_136686_136705_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 136686, 136705);
                    return return_v;
                }


                bool
                f_10843_136709_136737_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 136709, 136737);
                    return return_v;
                }


                bool
                f_10843_136987_137010(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 136987, 137010);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10843_137071_137105(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 137071, 137105);
                    return return_v;
                }


                bool
                f_10843_137051_137143(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasBoxingConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 137051, 137143);
                    return return_v;
                }


                bool
                f_10843_137814_137839(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsRestrictedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 137814, 137839);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10843_137921_137937(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 137921, 137937);
                    return return_v;
                }


                bool
                f_10843_138005_138040(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsPointerOrFunctionPointer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 138005, 138040);
                    return return_v;
                }


                bool
                f_10843_138076_138132(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                derivedType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                baseType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.IsBaseClass(derivedType, baseType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 138076, 138132);
                    return return_v;
                }


                bool
                f_10843_138213_138287(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                derivedType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                baseType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasAnyBaseInterfaceConversion(derivedType, baseType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 138213, 138287);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 135956, 138388);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 135956, 138388);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool HasImplicitPointerToVoidConversion(TypeSymbol source, TypeSymbol destination)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10843, 138400, 138931);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 138523, 138560);

                f_10843_138523_138559((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 138574, 138616);

                f_10843_138574_138615((object)destination != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 138781, 138920);

                return f_10843_138788_138823(source) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 138788, 138919) && destination is PointerTypeSymbol { PointedAtType: { SpecialType: SpecialType.System_Void } });
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10843, 138400, 138931);

                int
                f_10843_138523_138559(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 138523, 138559);
                    return 0;
                }


                int
                f_10843_138574_138615(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 138574, 138615);
                    return 0;
                }


                bool
                f_10843_138788_138823(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsPointerOrFunctionPointer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 138788, 138823);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 138400, 138931);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 138400, 138931);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool HasImplicitPointerConversion(TypeSymbol? source, TypeSymbol? destination, ref HashSet<DiagnosticInfo>? useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 138961, 141781);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 139122, 139353) || true) && (!(source is FunctionPointerTypeSymbol { Signature: { } sourceSig })
                || (DynAbs.Tracing.TraceSender.Expression_False(10843, 139126, 139291) || !(destination is FunctionPointerTypeSymbol { Signature: { } destinationSig })))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 139122, 139353);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 139325, 139338);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 139122, 139353);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 139369, 139576) || true) && (f_10843_139373_139397(sourceSig) != f_10843_139401_139430(destinationSig) || (DynAbs.Tracing.TraceSender.Expression_False(10843, 139373, 139514) || f_10843_139451_139478(sourceSig) != f_10843_139482_139514(destinationSig)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 139369, 139576);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 139548, 139561);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 139369, 139576);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 139592, 139841) || true) && (f_10843_139596_139623(sourceSig) == Cci.CallingConvention.Unmanaged && (DynAbs.Tracing.TraceSender.Expression_True(10843, 139596, 139779) && !f_10843_139680_139779(f_10843_139680_139721(sourceSig), f_10843_139732_139778(destinationSig))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 139592, 139841);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 139813, 139826);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 139592, 139841);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 139866, 139871);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 139857, 140464) || true) && (i < f_10843_139877_139901(sourceSig))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 139903, 139906)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 139857, 140464))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 139857, 140464);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 139940, 139982);

                        var
                        sourceParam = f_10843_139958_139978(sourceSig)[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 140000, 140052);

                        var
                        destinationParam = f_10843_140023_140048(destinationSig)[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 140072, 140197) || true) && (f_10843_140076_140095(sourceParam) != f_10843_140099_140123(destinationParam))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 140072, 140197);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 140165, 140178);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 140072, 140197);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 140217, 140449) || true) && (!f_10843_140222_140375(f_10843_140236_140255(sourceParam), f_10843_140257_140305(f_10843_140257_140282(destinationSig)[i]), f_10843_140307_140350(f_10843_140307_140327(sourceSig)[i]), ref useSiteDiagnostics))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 140217, 140449);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 140417, 140430);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 140217, 140449);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10843, 1, 608);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10843, 1, 608);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 140480, 140690);

                return f_10843_140487_140504(sourceSig) == f_10843_140508_140530(destinationSig) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 140487, 140689) && f_10843_140554_140689(f_10843_140568_140585(sourceSig), f_10843_140587_140622(sourceSig), f_10843_140624_140664(destinationSig), ref useSiteDiagnostics));

                bool hasConversion(RefKind refKind, TypeWithAnnotations sourceType, TypeWithAnnotations destinationType, ref HashSet<DiagnosticInfo>? useSiteDiagnostics)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 140706, 141770);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 140892, 141755);

                        switch (refKind)
                        {

                            case RefKind.None:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 140892, 141755);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 140993, 141480);

                                return (!IncludeNullability || (DynAbs.Tracing.TraceSender.Expression_False(10843, 141001, 141093) || f_10843_141024_141093(this, sourceType, destinationType)))
                                && (DynAbs.Tracing.TraceSender.Expression_True(10843, 141000, 141479) && (f_10843_141131_141234(this, sourceType.Type, destinationType.Type, ref useSiteDiagnostics) || (DynAbs.Tracing.TraceSender.Expression_False(10843, 141131, 141347) || f_10843_141274_141347(sourceType.Type, destinationType.Type)) || (DynAbs.Tracing.TraceSender.Expression_False(10843, 141131, 141478) || f_10843_141387_141478(this, sourceType.Type, destinationType.Type, ref useSiteDiagnostics))));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 140892, 141755);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 140892, 141755);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 141538, 141736);

                                return (!IncludeNullability || (DynAbs.Tracing.TraceSender.Expression_False(10843, 141546, 141638) || f_10843_141569_141638(this, sourceType, destinationType)))
                                && (DynAbs.Tracing.TraceSender.Expression_True(10843, 141545, 141735) && f_10843_141675_141735(sourceType.Type, destinationType.Type));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 140892, 141755);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 140706, 141770);

                        bool
                        f_10843_141024_141093(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        destination)
                        {
                            var return_v = this_param.HasTopLevelNullabilityImplicitConversion(source, destination);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 141024, 141093);
                            return return_v;
                        }


                        bool
                        f_10843_141131_141234(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                        useSiteDiagnostics)
                        {
                            var return_v = this_param.HasIdentityOrImplicitReferenceConversion(source, destination, ref useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 141131, 141234);
                            return return_v;
                        }


                        bool
                        f_10843_141274_141347(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        destination)
                        {
                            var return_v = HasImplicitPointerToVoidConversion(source, destination);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 141274, 141347);
                            return return_v;
                        }


                        bool
                        f_10843_141387_141478(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                        useSiteDiagnostics)
                        {
                            var return_v = this_param.HasImplicitPointerConversion(source, destination, ref useSiteDiagnostics);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 141387, 141478);
                            return return_v;
                        }


                        bool
                        f_10843_141569_141638(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        destination)
                        {
                            var return_v = this_param.HasTopLevelNullabilityIdentityConversion(source, destination);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 141569, 141638);
                            return return_v;
                        }


                        bool
                        f_10843_141675_141735(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                        type2)
                        {
                            var return_v = HasIdentityConversion(type1, type2);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 141675, 141735);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 140706, 141770);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 140706, 141770);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 138961, 141781);

                int
                f_10843_139373_139397(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 139373, 139397);
                    return return_v;
                }


                int
                f_10843_139401_139430(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 139401, 139430);
                    return return_v;
                }


                Microsoft.Cci.CallingConvention
                f_10843_139451_139478(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.CallingConvention;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 139451, 139478);
                    return return_v;
                }


                Microsoft.Cci.CallingConvention
                f_10843_139482_139514(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.CallingConvention;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 139482, 139514);
                    return return_v;
                }


                Microsoft.Cci.CallingConvention
                f_10843_139596_139623(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.CallingConvention;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 139596, 139623);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CustomModifier>
                f_10843_139680_139721(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.GetCallingConventionModifiers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 139680, 139721);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CustomModifier>
                f_10843_139732_139778(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.GetCallingConventionModifiers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 139732, 139778);
                    return return_v;
                }


                bool
                f_10843_139680_139779(System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CustomModifier>
                this_param, System.Collections.Immutable.ImmutableHashSet<Microsoft.CodeAnalysis.CustomModifier>
                other)
                {
                    var return_v = this_param.SetEquals((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CustomModifier>)other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 139680, 139779);
                    return return_v;
                }


                int
                f_10843_139877_139901(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 139877, 139901);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10843_139958_139978(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 139958, 139978);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10843_140023_140048(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 140023, 140048);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10843_140076_140095(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 140076, 140095);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10843_140099_140123(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 140099, 140123);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10843_140236_140255(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 140236, 140255);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10843_140257_140282(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 140257, 140282);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10843_140257_140305(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 140257, 140305);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10843_140307_140327(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 140307, 140327);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10843_140307_140350(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 140307, 140350);
                    return return_v;
                }


                bool
                f_10843_140222_140375(Microsoft.CodeAnalysis.RefKind
                refKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                sourceType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                destinationType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = hasConversion(refKind, sourceType, destinationType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 140222, 140375);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10843_140487_140504(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 140487, 140504);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10843_140508_140530(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 140508, 140530);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10843_140568_140585(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 140568, 140585);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10843_140587_140622(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 140587, 140622);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10843_140624_140664(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 140624, 140664);
                    return return_v;
                }


                bool
                f_10843_140554_140689(Microsoft.CodeAnalysis.RefKind
                refKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                sourceType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                destinationType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>?
                useSiteDiagnostics)
                {
                    var return_v = hasConversion(refKind, sourceType, destinationType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 140554, 140689);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 138961, 141781);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 138961, 141781);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool HasIdentityOrReferenceConversion(TypeSymbol source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 141812, 142549);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 141973, 142010);

                f_10843_141973_142009((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 142024, 142066);

                f_10843_142024_142065((object)destination != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 142082, 142197) || true) && (f_10843_142086_142136(this, source, destination))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 142082, 142197);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 142170, 142182);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 142082, 142197);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 142213, 142353) || true) && (f_10843_142217_142292(this, source, destination, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 142213, 142353);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 142326, 142338);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 142213, 142353);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 142369, 142509) || true) && (f_10843_142373_142448(this, source, destination, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 142369, 142509);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 142482, 142494);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 142369, 142509);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 142525, 142538);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 141812, 142549);

                int
                f_10843_141973_142009(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 141973, 142009);
                    return 0;
                }


                int
                f_10843_142024_142065(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 142024, 142065);
                    return 0;
                }


                bool
                f_10843_142086_142136(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type2)
                {
                    var return_v = this_param.HasIdentityConversionInternal(type1, type2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 142086, 142136);
                    return return_v;
                }


                bool
                f_10843_142217_142292(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasImplicitReferenceConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 142217, 142292);
                    return return_v;
                }


                bool
                f_10843_142373_142448(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasExplicitReferenceConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 142373, 142448);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 141812, 142549);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 141812, 142549);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool HasExplicitReferenceConversion(TypeSymbol source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 142561, 146359);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 142720, 142757);

                f_10843_142720_142756((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 142771, 142813);

                f_10843_142771_142812((object)destination != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 142968, 143324) || true) && (f_10843_142972_142990(source) == SpecialType.System_Object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 142968, 143324);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 143053, 143157) || true) && (f_10843_143057_143084(destination))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 143053, 143157);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 143126, 143138);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 143053, 143157);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 142968, 143324);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 142968, 143324);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 143191, 143324) || true) && (f_10843_143195_143206(source) == SymbolKind.DynamicType && (DynAbs.Tracing.TraceSender.Expression_True(10843, 143195, 143263) && f_10843_143236_143263(destination)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 143191, 143324);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 143297, 143309);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 143191, 143324);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 142968, 143324);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 143438, 143588) || true) && (f_10843_143442_143467(destination) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 143442, 143527) && f_10843_143471_143527(this, destination, source, ref useSiteDiagnostics)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 143438, 143588);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 143561, 143573);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 143438, 143588);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 143915, 144132) || true) && (f_10843_143919_143939(source) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 143919, 143972) && f_10843_143943_143972(destination)) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 143919, 143992) && f_10843_143976_143992_M(!source.IsSealed)) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 143919, 144071) && !f_10843_143997_144071(this, source, destination, ref useSiteDiagnostics)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 143915, 144132);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 144105, 144117);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 143915, 144132);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 144484, 144707) || true) && (f_10843_144488_144512(source) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 144488, 144541) && f_10843_144516_144541(destination)) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 144488, 144646) && (f_10843_144546_144567_M(!destination.IsSealed) || (DynAbs.Tracing.TraceSender.Expression_False(10843, 144546, 144645) || f_10843_144571_144645(this, destination, source, ref useSiteDiagnostics)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 144484, 144707);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 144680, 144692);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 144484, 144707);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 145202, 145406) || true) && (f_10843_145206_145230(source) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 145206, 145263) && f_10843_145234_145263(destination)) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 145206, 145345) && !f_10843_145268_145345(this, source, destination, ref useSiteDiagnostics)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 145202, 145406);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 145379, 145391);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 145202, 145406);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 145859, 145995) || true) && (f_10843_145863_145934(this, source, destination, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 145859, 145995);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 145968, 145980);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 145859, 145995);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 146011, 146150) || true) && (f_10843_146015_146089(this, source, destination, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 146011, 146150);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 146123, 146135);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 146011, 146150);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 146166, 146319) || true) && (f_10843_146170_146258(this, source, destination, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 146166, 146319);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 146292, 146304);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 146166, 146319);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 146335, 146348);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 142561, 146359);

                int
                f_10843_142720_142756(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 142720, 142756);
                    return 0;
                }


                int
                f_10843_142771_142812(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 142771, 142812);
                    return 0;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10843_142972_142990(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 142972, 142990);
                    return return_v;
                }


                bool
                f_10843_143057_143084(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 143057, 143084);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10843_143195_143206(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 143195, 143206);
                    return return_v;
                }


                bool
                f_10843_143236_143263(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 143236, 143263);
                    return return_v;
                }


                bool
                f_10843_143442_143467(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsClassType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 143442, 143467);
                    return return_v;
                }


                bool
                f_10843_143471_143527(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                derivedType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                baseType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.IsBaseClass(derivedType, baseType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 143471, 143527);
                    return return_v;
                }


                bool
                f_10843_143919_143939(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsClassType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 143919, 143939);
                    return return_v;
                }


                bool
                f_10843_143943_143972(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 143943, 143972);
                    return return_v;
                }


                bool
                f_10843_143976_143992_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 143976, 143992);
                    return return_v;
                }


                bool
                f_10843_143997_144071(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                derivedType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                baseType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasAnyBaseInterfaceConversion(derivedType, baseType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 143997, 144071);
                    return return_v;
                }


                bool
                f_10843_144488_144512(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 144488, 144512);
                    return return_v;
                }


                bool
                f_10843_144516_144541(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsClassType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 144516, 144541);
                    return return_v;
                }


                bool
                f_10843_144546_144567_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 144546, 144567);
                    return return_v;
                }


                bool
                f_10843_144571_144645(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                derivedType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                baseType, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasAnyBaseInterfaceConversion(derivedType, baseType, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 144571, 144645);
                    return return_v;
                }


                bool
                f_10843_145206_145230(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 145206, 145230);
                    return return_v;
                }


                bool
                f_10843_145234_145263(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 145234, 145263);
                    return return_v;
                }


                bool
                f_10843_145268_145345(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasImplicitConversionToInterface(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 145268, 145345);
                    return return_v;
                }


                bool
                f_10843_145863_145934(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasExplicitArrayConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 145863, 145934);
                    return return_v;
                }


                bool
                f_10843_146015_146089(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasExplicitDelegateConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 146015, 146089);
                    return return_v;
                }


                bool
                f_10843_146170_146258(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasExplicitReferenceTypeParameterConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 146170, 146258);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 142561, 146359);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 142561, 146359);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool HasExplicitReferenceTypeParameterConversion(TypeSymbol source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 146441, 148600);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 146613, 146650);

                f_10843_146613_146649((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 146664, 146706);

                f_10843_146664_146705((object)destination != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 146722, 146776);

                TypeParameterSymbol
                s = source as TypeParameterSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 146790, 146849);

                TypeParameterSymbol
                t = destination as TypeParameterSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 147312, 147756) || true) && ((object)t != null && (DynAbs.Tracing.TraceSender.Expression_True(10843, 147316, 147354) && f_10843_147337_147354(t)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 147312, 147756);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 147397, 147448);
                        for (var
        type = f_10843_147404_147448(t, ref useSiteDiagnostics)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 147388, 147741) || true) && ((object)type != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 147472, 147548)
        , type = f_10843_147479_147548(type, ref useSiteDiagnostics), DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 147388, 147741))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 147388, 147741);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 147590, 147722) || true) && (f_10843_147594_147637(this, type, source))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 147590, 147722);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 147687, 147699);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 147590, 147722);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10843, 1, 354);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10843, 1, 354);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 147312, 147756);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 147825, 147956) || true) && ((object)t != null && (DynAbs.Tracing.TraceSender.Expression_True(10843, 147829, 147874) && f_10843_147850_147874(source)) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 147829, 147895) && f_10843_147878_147895(t)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 147825, 147956);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 147929, 147941);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 147825, 147956);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 148091, 148315) || true) && ((object)s != null && (DynAbs.Tracing.TraceSender.Expression_True(10843, 148095, 148133) && f_10843_148116_148133(s)) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 148095, 148166) && f_10843_148137_148166(destination)) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 148095, 148254) && !f_10843_148171_148254(this, s, destination, ref useSiteDiagnostics)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 148091, 148315);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 148288, 148300);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 148091, 148315);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 148418, 148560) || true) && ((object)s != null && (DynAbs.Tracing.TraceSender.Expression_True(10843, 148422, 148460) && (object)t != null) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 148422, 148481) && f_10843_148464_148481(t)) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 148422, 148499) && f_10843_148485_148499(t, s)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 148418, 148560);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 148533, 148545);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 148418, 148560);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 148576, 148589);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 146441, 148600);

                int
                f_10843_146613_146649(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 146613, 146649);
                    return 0;
                }


                int
                f_10843_146664_146705(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 146664, 146705);
                    return 0;
                }


                bool
                f_10843_147337_147354(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 147337, 147354);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10843_147404_147448(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.EffectiveBaseClass(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 147404, 147448);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10843_147479_147548(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.BaseTypeWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 147479, 147548);
                    return return_v;
                }


                bool
                f_10843_147594_147637(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type2)
                {
                    var return_v = this_param.HasIdentityConversionInternal((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type1, type2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 147594, 147637);
                    return return_v;
                }


                bool
                f_10843_147850_147874(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 147850, 147874);
                    return return_v;
                }


                bool
                f_10843_147878_147895(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 147878, 147895);
                    return return_v;
                }


                bool
                f_10843_148116_148133(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 148116, 148133);
                    return return_v;
                }


                bool
                f_10843_148137_148166(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 148137, 148166);
                    return return_v;
                }


                bool
                f_10843_148171_148254(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasImplicitReferenceTypeParameterConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 148171, 148254);
                    return return_v;
                }


                bool
                f_10843_148464_148481(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 148464, 148481);
                    return return_v;
                }


                bool
                f_10843_148485_148499(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter2)
                {
                    var return_v = typeParameter1.DependsOn(typeParameter2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 148485, 148499);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 146441, 148600);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 146441, 148600);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool HasUnboxingTypeParameterConversion(TypeSymbol source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 148682, 150861);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 148845, 148882);

                f_10843_148845_148881((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 148896, 148938);

                f_10843_148896_148937((object)destination != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 148954, 149008);

                TypeParameterSymbol
                s = source as TypeParameterSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 149022, 149081);

                TypeParameterSymbol
                t = destination as TypeParameterSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 149544, 150014) || true) && ((object)t != null && (DynAbs.Tracing.TraceSender.Expression_True(10843, 149548, 149587) && f_10843_149569_149587_M(!t.IsReferenceType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 149544, 150014);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 149630, 149681);
                        for (var
        type = f_10843_149637_149681(t, ref useSiteDiagnostics)
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 149621, 149999) || true) && ((object)type != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 149705, 149781)
        , type = f_10843_149712_149781(type, ref useSiteDiagnostics), DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 149621, 149999))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 149621, 149999);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 149823, 149980) || true) && (f_10843_149827_149895(type, source, TypeCompareKind.ConsiderEverything2))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 149823, 149980);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 149945, 149957);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 149823, 149980);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10843, 1, 379);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10843, 1, 379);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 149544, 150014);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 150083, 150215) || true) && (f_10843_150087_150111(source) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 150087, 150132) && (object)t != null) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 150087, 150154) && f_10843_150136_150154_M(!t.IsReferenceType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 150083, 150215);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 150188, 150200);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 150083, 150215);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 150350, 150575) || true) && ((object)s != null && (DynAbs.Tracing.TraceSender.Expression_True(10843, 150354, 150393) && f_10843_150375_150393_M(!s.IsReferenceType)) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 150354, 150426) && f_10843_150397_150426(destination)) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 150354, 150514) && !f_10843_150431_150514(this, s, destination, ref useSiteDiagnostics)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 150350, 150575);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 150548, 150560);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 150350, 150575);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 150678, 150821) || true) && ((object)s != null && (DynAbs.Tracing.TraceSender.Expression_True(10843, 150682, 150720) && (object)t != null) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 150682, 150742) && f_10843_150724_150742_M(!t.IsReferenceType)) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 150682, 150760) && f_10843_150746_150760(t, s)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 150678, 150821);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 150794, 150806);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 150678, 150821);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 150837, 150850);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 148682, 150861);

                int
                f_10843_148845_148881(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 148845, 148881);
                    return 0;
                }


                int
                f_10843_148896_148937(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 148896, 148937);
                    return 0;
                }


                bool
                f_10843_149569_149587_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 149569, 149587);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10843_149637_149681(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.EffectiveBaseClass(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 149637, 149681);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10843_149712_149781(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.BaseTypeWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 149712, 149781);
                    return return_v;
                }


                bool
                f_10843_149827_149895(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 149827, 149895);
                    return return_v;
                }


                bool
                f_10843_150087_150111(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 150087, 150111);
                    return return_v;
                }


                bool
                f_10843_150136_150154_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 150136, 150154);
                    return return_v;
                }


                bool
                f_10843_150375_150393_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 150375, 150393);
                    return return_v;
                }


                bool
                f_10843_150397_150426(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 150397, 150426);
                    return return_v;
                }


                bool
                f_10843_150431_150514(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasImplicitReferenceTypeParameterConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 150431, 150514);
                    return return_v;
                }


                bool
                f_10843_150724_150742_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 150724, 150742);
                    return return_v;
                }


                bool
                f_10843_150746_150760(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                typeParameter2)
                {
                    var return_v = typeParameter1.DependsOn(typeParameter2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 150746, 150760);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 148682, 150861);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 148682, 150861);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool HasExplicitDelegateConversion(TypeSymbol source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 150873, 154879);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 151031, 151068);

                f_10843_151031_151067((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 151082, 151124);

                f_10843_151082_151123((object)destination != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 151366, 151865) || true) && (f_10843_151370_151398(destination))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 151366, 151865);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 151432, 151620) || true) && (f_10843_151436_151454(source) == SpecialType.System_Delegate || (DynAbs.Tracing.TraceSender.Expression_False(10843, 151436, 151547) || f_10843_151489_151507(source) == SpecialType.System_MulticastDelegate))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 151432, 151620);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 151589, 151601);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 151432, 151620);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 151640, 151850) || true) && (f_10843_151644_151777(this, f_10843_151677_151744(this.corLibrary, SpecialType.System_Delegate), source, ref useSiteDiagnostics))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 151640, 151850);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 151819, 151831);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 151640, 151850);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 151366, 151865);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 152429, 152552) || true) && (!f_10843_152434_152457(source) || (DynAbs.Tracing.TraceSender.Expression_False(10843, 152433, 152490) || !f_10843_152462_152490(destination)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 152429, 152552);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 152524, 152537);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 152429, 152552);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 152568, 152748) || true) && (!f_10843_152573_152686(f_10843_152591_152616(source), f_10843_152618_152648(destination), TypeCompareKind.ConsiderEverything2))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 152568, 152748);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 152720, 152733);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 152568, 152748);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 152764, 152805);

                var
                sourceType = (NamedTypeSymbol)source
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 152819, 152870);

                var
                destinationType = (NamedTypeSymbol)destination
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 152884, 152929);

                var
                original = f_10843_152899_152928(sourceType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 152945, 153061) || true) && (f_10843_152949_152999(this, source, destination))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 152945, 153061);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 153033, 153046);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 152945, 153061);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 153077, 153217) || true) && (f_10843_153081_153155(this, source, destination, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 153077, 153217);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 153189, 153202);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 153077, 153217);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 153233, 153340);

                var
                sourceTypeArguments = f_10843_153259_153339(sourceType, ref useSiteDiagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 153354, 153471);

                var
                destinationTypeArguments = f_10843_153385_153470(destinationType, ref useSiteDiagnostics)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 153496, 153501);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 153487, 154840) || true) && (i < sourceTypeArguments.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 153535, 153538)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 153487, 154840))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 153487, 154840);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 153572, 153616);

                        var
                        sourceArg = sourceTypeArguments[i].Type
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 153634, 153688);

                        var
                        destinationArg = destinationTypeArguments[i].Type
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 153708, 154825);

                        switch (f_10843_153716_153751(f_10843_153716_153739(original)[i]))
                        {

                            case VarianceKind.None:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 153708, 154825);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 153842, 154001) || true) && (!f_10843_153847_153903(this, sourceArg, destinationArg))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 153842, 154001);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 153961, 153974);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 153842, 154001);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10843, 154029, 154035);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 153708, 154825);

                            case VarianceKind.Out:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 153708, 154825);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 154105, 154291) || true) && (!f_10843_154110_154193(this, sourceArg, destinationArg, ref useSiteDiagnostics))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 154105, 154291);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 154251, 154264);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 154105, 154291);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10843, 154319, 154325);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 153708, 154825);

                            case VarianceKind.In:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 153708, 154825);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 154394, 154480);

                                bool
                                hasIdentityConversion = f_10843_154423_154479(this, sourceArg, destinationArg)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 154506, 154595);

                                bool
                                bothAreReferenceTypes = f_10843_154535_154560(sourceArg) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 154535, 154594) && f_10843_154564_154594(destinationArg))
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 154621, 154772) || true) && (!(hasIdentityConversion || (DynAbs.Tracing.TraceSender.Expression_False(10843, 154627, 154673) || bothAreReferenceTypes)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 154621, 154772);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 154732, 154745);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 154621, 154772);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10843, 154800, 154806);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 153708, 154825);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10843, 1, 1354);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10843, 1, 1354);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 154856, 154868);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 150873, 154879);

                int
                f_10843_151031_151067(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 151031, 151067);
                    return 0;
                }


                int
                f_10843_151082_151123(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 151082, 151123);
                    return 0;
                }


                bool
                f_10843_151370_151398(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 151370, 151398);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10843_151436_151454(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 151436, 151454);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10843_151489_151507(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 151489, 151507);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10843_151677_151744(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.SpecialType
                type)
                {
                    var return_v = this_param.GetDeclaredSpecialType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 151677, 151744);
                    return return_v;
                }


                bool
                f_10843_151644_151777(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasImplicitConversionToInterface((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 151644, 151777);
                    return return_v;
                }


                bool
                f_10843_152434_152457(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 152434, 152457);
                    return return_v;
                }


                bool
                f_10843_152462_152490(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDelegateType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 152462, 152490);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10843_152591_152616(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 152591, 152616);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10843_152618_152648(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 152618, 152648);
                    return return_v;
                }


                bool
                f_10843_152573_152686(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 152573, 152686);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10843_152899_152928(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 152899, 152928);
                    return return_v;
                }


                bool
                f_10843_152949_152999(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type2)
                {
                    var return_v = this_param.HasIdentityConversionInternal(type1, type2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 152949, 152999);
                    return return_v;
                }


                bool
                f_10843_153081_153155(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasDelegateVarianceConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 153081, 153155);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10843_153259_153339(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.TypeArgumentsWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 153259, 153339);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10843_153385_153470(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.TypeArgumentsWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 153385, 153470);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10843_153716_153739(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 153716, 153739);
                    return return_v;
                }


                Microsoft.CodeAnalysis.VarianceKind
                f_10843_153716_153751(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Variance;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 153716, 153751);
                    return return_v;
                }


                bool
                f_10843_153847_153903(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type2)
                {
                    var return_v = this_param.HasIdentityConversionInternal(type1, type2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 153847, 153903);
                    return return_v;
                }


                bool
                f_10843_154110_154193(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasIdentityOrReferenceConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 154110, 154193);
                    return return_v;
                }


                bool
                f_10843_154423_154479(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type2)
                {
                    var return_v = this_param.HasIdentityConversionInternal(type1, type2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 154423, 154479);
                    return return_v;
                }


                bool
                f_10843_154535_154560(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 154535, 154560);
                    return return_v;
                }


                bool
                f_10843_154564_154594(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 154564, 154594);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 150873, 154879);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 150873, 154879);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool HasExplicitArrayConversion(TypeSymbol source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 154891, 159938);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 155046, 155083);

                f_10843_155046_155082((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 155097, 155139);

                f_10843_155097_155138((object)destination != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 155155, 155199);

                var
                sourceArray = source as ArrayTypeSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 155213, 155267);

                var
                destinationArray = destination as ArrayTypeSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 155690, 156534) || true) && ((object)sourceArray != null && (DynAbs.Tracing.TraceSender.Expression_True(10843, 155694, 155757) && (object)destinationArray != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 155690, 156534);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 156333, 156519);

                    return f_10843_156340_156384(sourceArray, destinationArray) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 156340, 156518) && f_10843_156409_156518(this, f_10843_156440_156463(sourceArray), f_10843_156465_156493(destinationArray), ref useSiteDiagnostics));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 155690, 156534);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 156642, 157220) || true) && ((object)destinationArray != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 156642, 157220);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 156712, 156835) || true) && (f_10843_156716_156734(source) == SpecialType.System_Array)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 156712, 156835);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 156804, 156816);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 156712, 156835);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 156855, 157205);
                        foreach (var iface in f_10843_156877_157011_I(f_10843_156877_157011(f_10843_156877_156941(this.corLibrary, SpecialType.System_Array), ref useSiteDiagnostics)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 156855, 157205);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 157053, 157186) || true) && (f_10843_157057_157101(this, iface, source))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 157053, 157186);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 157151, 157163);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 157053, 157186);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 156855, 157205);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10843, 1, 351);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10843, 1, 351);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 156642, 157220);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 157614, 158033) || true) && ((object)sourceArray != null && (DynAbs.Tracing.TraceSender.Expression_True(10843, 157618, 157670) && f_10843_157649_157670(sourceArray)) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 157618, 157719) && f_10843_157674_157719(destination)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 157614, 158033);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 157753, 158018) || true) && (f_10843_157757_157945(this, f_10843_157788_157811(sourceArray), f_10843_157813_157915(((NamedTypeSymbol)destination), 0, ref useSiteDiagnostics).Type, ref useSiteDiagnostics))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 157753, 158018);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 157987, 157999);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 157753, 158018);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 157614, 158033);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 158373, 159898) || true) && ((object)destinationArray != null && (DynAbs.Tracing.TraceSender.Expression_True(10843, 158377, 158439) && f_10843_158413_158439(destinationArray)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 158373, 159898);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 158473, 158549);

                    var
                    specialDefinition = f_10843_158497_158548(((TypeSymbol)f_10843_158510_158535(source)))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 158569, 159883) || true) && (specialDefinition == SpecialType.System_Collections_Generic_IList_T || (DynAbs.Tracing.TraceSender.Expression_False(10843, 158573, 158738) || specialDefinition == SpecialType.System_Collections_Generic_ICollection_T) || (DynAbs.Tracing.TraceSender.Expression_False(10843, 158573, 158836) || specialDefinition == SpecialType.System_Collections_Generic_IEnumerable_T) || (DynAbs.Tracing.TraceSender.Expression_False(10843, 158573, 158936) || specialDefinition == SpecialType.System_Collections_Generic_IReadOnlyList_T) || (DynAbs.Tracing.TraceSender.Expression_False(10843, 158573, 159042) || specialDefinition == SpecialType.System_Collections_Generic_IReadOnlyCollection_T))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 158569, 159883);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 159084, 159207);

                        var
                        sourceElement = f_10843_159104_159201(((NamedTypeSymbol)source), 0, ref useSiteDiagnostics).Type
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 159229, 159283);

                        var
                        destinationElement = f_10843_159254_159282(destinationArray)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 159307, 159460) || true) && (f_10843_159311_159375(this, sourceElement, destinationElement))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 159307, 159460);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 159425, 159437);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 159307, 159460);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 159484, 159662) || true) && (f_10843_159488_159577(this, sourceElement, destinationElement, ref useSiteDiagnostics))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 159484, 159662);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 159627, 159639);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 159484, 159662);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 159686, 159864) || true) && (f_10843_159690_159779(this, sourceElement, destinationElement, ref useSiteDiagnostics))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 159686, 159864);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 159829, 159841);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 159686, 159864);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 158569, 159883);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 158373, 159898);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 159914, 159927);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 154891, 159938);

                int
                f_10843_155046_155082(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 155046, 155082);
                    return 0;
                }


                int
                f_10843_155097_155138(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 155097, 155138);
                    return 0;
                }


                bool
                f_10843_156340_156384(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                other)
                {
                    var return_v = this_param.HasSameShapeAs(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 156340, 156384);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10843_156440_156463(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 156440, 156463);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10843_156465_156493(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 156465, 156493);
                    return return_v;
                }


                bool
                f_10843_156409_156518(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasExplicitReferenceConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 156409, 156518);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10843_156716_156734(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 156716, 156734);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10843_156877_156941(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.SpecialType
                type)
                {
                    var return_v = this_param.GetDeclaredSpecialType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 156877, 156941);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10843_156877_157011(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.AllInterfacesWithDefinitionUseSiteDiagnostics(ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 156877, 157011);
                    return return_v;
                }


                bool
                f_10843_157057_157101(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type2)
                {
                    var return_v = this_param.HasIdentityConversionInternal((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type1, type2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 157057, 157101);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10843_156877_157011_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 156877, 157011);
                    return return_v;
                }


                bool
                f_10843_157649_157670(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsSZArray;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 157649, 157670);
                    return return_v;
                }


                bool
                f_10843_157674_157719(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                _type)
                {
                    var return_v = _type.IsPossibleArrayGenericInterface();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 157674, 157719);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10843_157788_157811(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 157788, 157811);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10843_157813_157915(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, int
                index, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.TypeArgumentWithDefinitionUseSiteDiagnostics(index, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 157813, 157915);
                    return return_v;
                }


                bool
                f_10843_157757_157945(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasExplicitReferenceConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 157757, 157945);
                    return return_v;
                }


                bool
                f_10843_158413_158439(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsSZArray;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 158413, 158439);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10843_158510_158535(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 158510, 158535);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10843_158497_158548(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 158497, 158548);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10843_159104_159201(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, int
                index, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.TypeArgumentWithDefinitionUseSiteDiagnostics(index, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 159104, 159201);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10843_159254_159282(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 159254, 159282);
                    return return_v;
                }


                bool
                f_10843_159311_159375(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type2)
                {
                    var return_v = this_param.HasIdentityConversionInternal(type1, type2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 159311, 159375);
                    return return_v;
                }


                bool
                f_10843_159488_159577(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasImplicitReferenceConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 159488, 159577);
                    return return_v;
                }


                bool
                f_10843_159690_159779(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasExplicitReferenceConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 159690, 159779);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 154891, 159938);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 154891, 159938);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool HasUnboxingConversion(TypeSymbol source, TypeSymbol destination, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10843, 159950, 162962);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 160100, 160137);

                f_10843_160100_160136((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 160151, 160193);

                f_10843_160151_160192((object)destination != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 160209, 160315) || true) && (f_10843_160213_160253(destination))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 160209, 160315);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 160287, 160300);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 160209, 160315);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 160389, 160485) || true) && (f_10843_160393_160423(destination))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 160389, 160485);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 160457, 160470);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 160389, 160485);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 160744, 160787);

                var
                specialTypeSource = f_10843_160768_160786(source)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 160803, 161088) || true) && (specialTypeSource == SpecialType.System_Object || (DynAbs.Tracing.TraceSender.Expression_False(10843, 160807, 160906) || specialTypeSource == SpecialType.System_ValueType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 160803, 161088);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 160940, 161073) || true) && (f_10843_160944_160967(destination) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 160944, 161000) && !f_10843_160972_161000(destination)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 160940, 161073);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 161042, 161054);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 160940, 161073);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 160803, 161088);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 161224, 161492) || true) && (f_10843_161228_161252(source) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 161228, 161296) && f_10843_161273_161296(destination)) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 161228, 161346) && !f_10843_161318_161346(destination)) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 161228, 161431) && f_10843_161367_161431(this, destination, source, ref useSiteDiagnostics)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 161224, 161492);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 161465, 161477);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 161224, 161492);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 161592, 161730) || true) && (f_10843_161596_161614(source) == SpecialType.System_Enum && (DynAbs.Tracing.TraceSender.Expression_True(10843, 161596, 161669) && f_10843_161645_161669(destination)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 161592, 161730);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 161703, 161715);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 161592, 161730);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 162006, 162257) || true) && (f_10843_162010_162032(source) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 162010, 162081) && f_10843_162053_162081(destination)) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 162010, 162196) && f_10843_162102_162196(this, source, f_10843_162132_162171(destination), ref useSiteDiagnostics)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 162006, 162257);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 162230, 162242);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 162006, 162257);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 162778, 162922) || true) && (f_10843_162782_162861(this, source, destination, ref useSiteDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 162778, 162922);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 162895, 162907);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 162778, 162922);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 162938, 162951);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10843, 159950, 162962);

                int
                f_10843_160100_160136(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 160100, 160136);
                    return 0;
                }


                int
                f_10843_160151_160192(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 160151, 160192);
                    return 0;
                }


                bool
                f_10843_160213_160253(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsPointerOrFunctionPointer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 160213, 160253);
                    return return_v;
                }


                bool
                f_10843_160393_160423(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsRestrictedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 160393, 160423);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10843_160768_160786(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 160768, 160786);
                    return return_v;
                }


                bool
                f_10843_160944_160967(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 160944, 160967);
                    return return_v;
                }


                bool
                f_10843_160972_161000(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 160972, 161000);
                    return return_v;
                }


                bool
                f_10843_161228_161252(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsInterfaceType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 161228, 161252);
                    return return_v;
                }


                bool
                f_10843_161273_161296(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 161273, 161296);
                    return return_v;
                }


                bool
                f_10843_161318_161346(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 161318, 161346);
                    return return_v;
                }


                bool
                f_10843_161367_161431(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasBoxingConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 161367, 161431);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10843_161596_161614(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 161596, 161614);
                    return return_v;
                }


                bool
                f_10843_161645_161669(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsEnumType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 161645, 161669);
                    return return_v;
                }


                bool
                f_10843_162010_162032(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 162010, 162032);
                    return return_v;
                }


                bool
                f_10843_162053_162081(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 162053, 162081);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10843_162132_162171(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 162132, 162171);
                    return return_v;
                }


                bool
                f_10843_162102_162196(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasUnboxingConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 162102, 162196);
                    return return_v;
                }


                bool
                f_10843_162782_162861(Microsoft.CodeAnalysis.CSharp.ConversionsBase
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                source, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                destination, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.HasUnboxingTypeParameterConversion(source, destination, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 162782, 162861);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 159950, 162962);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 159950, 162962);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool HasPointerToPointerConversion(TypeSymbol source, TypeSymbol destination)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10843, 162974, 163298);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 163091, 163128);

                f_10843_163091_163127((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 163142, 163184);

                f_10843_163142_163183((object)destination != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 163200, 163287);

                return f_10843_163207_163242(source) && (DynAbs.Tracing.TraceSender.Expression_True(10843, 163207, 163286) && f_10843_163246_163286(destination));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10843, 162974, 163298);

                int
                f_10843_163091_163127(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 163091, 163127);
                    return 0;
                }


                int
                f_10843_163142_163183(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 163142, 163183);
                    return 0;
                }


                bool
                f_10843_163207_163242(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsPointerOrFunctionPointer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 163207, 163242);
                    return return_v;
                }


                bool
                f_10843_163246_163286(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsPointerOrFunctionPointer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 163246, 163286);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 162974, 163298);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 162974, 163298);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool HasPointerToIntegerConversion(TypeSymbol source, TypeSymbol destination)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10843, 163310, 163945);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 163427, 163464);

                f_10843_163427_163463((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 163478, 163520);

                f_10843_163478_163519((object)destination != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 163536, 163638) || true) && (!f_10843_163541_163576(source))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 163536, 163638);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 163610, 163623);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 163536, 163638);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 163857, 163934);

                return f_10843_163864_163933(f_10843_163906_163932(destination));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10843, 163310, 163945);

                int
                f_10843_163427_163463(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 163427, 163463);
                    return 0;
                }


                int
                f_10843_163478_163519(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 163478, 163519);
                    return 0;
                }


                bool
                f_10843_163541_163576(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsPointerOrFunctionPointer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 163541, 163576);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10843_163906_163932(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.StrippedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 163906, 163932);
                    return return_v;
                }


                bool
                f_10843_163864_163933(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = IsIntegerTypeSupportingPointerConversions(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 163864, 163933);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 163310, 163945);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 163310, 163945);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool HasIntegerToPointerConversion(TypeSymbol source, TypeSymbol destination)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10843, 163957, 164468);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 164074, 164111);

                f_10843_164074_164110((object)source != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 164125, 164167);

                f_10843_164125_164166((object)destination != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 164183, 164290) || true) && (!f_10843_164188_164228(destination))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 164183, 164290);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 164262, 164275);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 164183, 164290);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 164400, 164457);

                return f_10843_164407_164456(source);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10843, 163957, 164468);

                int
                f_10843_164074_164110(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 164074, 164110);
                    return 0;
                }


                int
                f_10843_164125_164166(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 164125, 164166);
                    return 0;
                }


                bool
                f_10843_164188_164228(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsPointerOrFunctionPointer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 164188, 164228);
                    return return_v;
                }


                bool
                f_10843_164407_164456(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = IsIntegerTypeSupportingPointerConversions(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 164407, 164456);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 163957, 164468);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 163957, 164468);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsIntegerTypeSupportingPointerConversions(TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10843, 164480, 165251);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 164583, 165211);

                switch (f_10843_164591_164607(type))
                {

                    case SpecialType.System_SByte:
                    case SpecialType.System_Byte:
                    case SpecialType.System_Int16:
                    case SpecialType.System_UInt16:
                    case SpecialType.System_Int32:
                    case SpecialType.System_UInt32:
                    case SpecialType.System_Int64:
                    case SpecialType.System_UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 164583, 165211);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 165031, 165043);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 164583, 165211);

                    case SpecialType.System_IntPtr:
                    case SpecialType.System_UIntPtr:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10843, 164583, 165211);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 165164, 165196);

                        return f_10843_165171_165195(type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10843, 164583, 165211);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10843, 165227, 165240);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10843, 164480, 165251);

                Microsoft.CodeAnalysis.SpecialType
                f_10843_164591_164607(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 164591, 164607);
                    return return_v;
                }


                bool
                f_10843_165171_165195(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsNativeIntegerType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10843, 165171, 165195);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10843, 164480, 165251);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10843, 164480, 165251);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        int
        f_10843_1313_1353(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 1313, 1353);
            return 0;
        }


        int
        f_10843_1368_1473(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 1368, 1473);
            return 0;
        }


        int
        f_10843_1488_1599(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10843, 1488, 1599);
            return 0;
        }

    }
}
