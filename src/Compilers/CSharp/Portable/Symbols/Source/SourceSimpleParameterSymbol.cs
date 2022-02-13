// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SourceSimpleParameterSymbol : SourceParameterSymbol
    {
        public SourceSimpleParameterSymbol(
                   Symbol owner,
                   TypeWithAnnotations parameterType,
                   int ordinal,
                   RefKind refKind,
                   string name,
                   bool isDiscard,
                   ImmutableArray<Location> locations)
        : base(f_10275_879_884_C(owner), parameterType, ordinal, refKind, name, locations)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10275, 596, 993);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10275, 1005, 1044);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10275, 960, 982);

                IsDiscard = isDiscard;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10275, 596, 993);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10275, 596, 993);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10275, 596, 993);
            }
        }

        public override bool IsDiscard { get; }

        internal override ConstantValue ExplicitDefaultConstantValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10275, 1141, 1161);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10275, 1147, 1159);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10275, 1141, 1161);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10275, 1056, 1172);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10275, 1056, 1172);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsMetadataOptional
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10275, 1250, 1271);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10275, 1256, 1269);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10275, 1250, 1271);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10275, 1184, 1282);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10275, 1184, 1282);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsParams
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10275, 1348, 1369);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10275, 1354, 1367);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10275, 1348, 1369);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10275, 1294, 1380);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10275, 1294, 1380);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasDefaultArgumentSyntax
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10275, 1464, 1485);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10275, 1470, 1483);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10275, 1464, 1485);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10275, 1392, 1496);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10275, 1392, 1496);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<CustomModifier> RefCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10275, 1598, 1650);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10275, 1604, 1648);

                    return ImmutableArray<CustomModifier>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10275, 1598, 1650);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10275, 1508, 1661);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10275, 1508, 1661);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override SyntaxReference SyntaxReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10275, 1747, 1767);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10275, 1753, 1765);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10275, 1747, 1767);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10275, 1673, 1778);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10275, 1673, 1778);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsExtensionMethodThis
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10275, 1859, 1880);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10275, 1865, 1878);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10275, 1859, 1880);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10275, 1790, 1891);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10275, 1790, 1891);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsIDispatchConstant
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10275, 1970, 1991);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10275, 1976, 1989);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10275, 1970, 1991);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10275, 1903, 2002);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10275, 1903, 2002);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsIUnknownConstant
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10275, 2080, 2101);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10275, 2086, 2099);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10275, 2080, 2101);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10275, 2014, 2112);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10275, 2014, 2112);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsCallerFilePath
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10275, 2188, 2209);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10275, 2194, 2207);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10275, 2188, 2209);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10275, 2124, 2220);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10275, 2124, 2220);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsCallerLineNumber
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10275, 2298, 2319);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10275, 2304, 2317);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10275, 2298, 2319);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10275, 2232, 2330);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10275, 2232, 2330);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsCallerMemberName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10275, 2408, 2429);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10275, 2414, 2427);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10275, 2408, 2429);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10275, 2342, 2440);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10275, 2342, 2440);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override FlowAnalysisAnnotations FlowAnalysisAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10275, 2542, 2586);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10275, 2548, 2584);

                    return FlowAnalysisAnnotations.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10275, 2542, 2586);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10275, 2452, 2597);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10275, 2452, 2597);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableHashSet<string> NotNullIfParameterNotNull
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10275, 2678, 2711);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10275, 2681, 2711);
                    return ImmutableHashSet<string>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10275, 2678, 2711);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10275, 2678, 2711);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10275, 2678, 2711);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override MarshalPseudoCustomAttributeData MarshallingInformation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10275, 2822, 2842);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10275, 2828, 2840);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10275, 2822, 2842);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10275, 2724, 2853);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10275, 2724, 2853);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasOptionalAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10275, 2933, 2954);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10275, 2939, 2952);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10275, 2933, 2954);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10275, 2865, 2965);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10275, 2865, 2965);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override SyntaxList<AttributeListSyntax> AttributeDeclarationList
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10275, 3076, 3132);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10275, 3082, 3130);

                    return default(SyntaxList<AttributeListSyntax>);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10275, 3076, 3132);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10275, 2977, 3143);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10275, 2977, 3143);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override CustomAttributesBag<CSharpAttributeData> GetAttributesBag()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10275, 3155, 3386);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10275, 3257, 3307);

                state.NotePartComplete(CompletionPart.Attributes);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10275, 3321, 3375);

                return CustomAttributesBag<CSharpAttributeData>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10275, 3155, 3386);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10275, 3155, 3386);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10275, 3155, 3386);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ConstantValue DefaultValueFromAttributes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10275, 3481, 3523);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10275, 3487, 3521);

                    return ConstantValue.NotAvailable;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10275, 3481, 3523);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10275, 3398, 3534);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10275, 3398, 3534);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static SourceSimpleParameterSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10275, 506, 3541);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10275, 506, 3541);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10275, 506, 3541);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10275, 506, 3541);

        static Microsoft.CodeAnalysis.CSharp.Symbol
        f_10275_879_884_C(Microsoft.CodeAnalysis.CSharp.Symbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10275, 596, 993);
            return return_v;
        }

    }
}
