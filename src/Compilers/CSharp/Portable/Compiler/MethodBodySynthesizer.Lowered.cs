// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed partial class SynthesizedStringSwitchHashMethod : SynthesizedGlobalMethodSymbol
    {        /// <summary>
             /// Compute the hashcode of a sub string using FNV-1a
             /// See http://en.wikipedia.org/wiki/Fowler%E2%80%93Noll%E2%80%93Vo_hash_function
             /// </summary>
             /// <remarks>
             /// This method should be kept consistent with MethodBodySynthesizer.ConstructStringSwitchHashFunctionBody
             /// The control flow in this method mimics lowered "for" loop. It is exactly what we want to emit
             /// to ensure that JIT can do range check hoisting.
             /// </remarks>
        internal static uint ComputeStringHash(string text)
        {
            uint hashCode = 0;
            if (text != null)
            {
                hashCode = unchecked((uint)2166136261);

                int i = 0;
                goto start;

again:
                hashCode = unchecked((text[i] ^ hashCode) * 16777619);
                i = i + 1;

start:
                if (i < text.Length)
                    goto again;
            }
            return hashCode;
        }

        internal override void GenerateMethodBody(TypeCompilationState compilationState, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10625, 1559, 5595);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 1691, 1817);

                SyntheticBoundNodeFactory
                F = f_10625_1721_1816(this, f_10625_1757_1784(this), compilationState, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 1831, 1856);

                F.CurrentFunction = this;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 1908, 1984);

                    LocalSymbol
                    i = f_10625_1924_1983(F, f_10625_1943_1982(F, SpecialType.System_Int32))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 2002, 2086);

                    LocalSymbol
                    hashCode = f_10625_2025_2085(F, f_10625_2044_2084(F, SpecialType.System_UInt32))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 2106, 2151);

                    LabelSymbol
                    again = f_10625_2126_2150(F, "again")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 2169, 2214);

                    LabelSymbol
                    start = f_10625_2189_2213(F, "start")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 2234, 2276);

                    ParameterSymbol
                    text = f_10625_2257_2272(this)[0]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 2911, 5228);

                    var
                    body = f_10625_2922_5227(F, f_10625_2956_3003(hashCode, i), f_10625_3030_5150(F, f_10625_3065_3255(F, BinaryOperatorKind.ObjectNotEqual, f_10625_3109_3150(F, SpecialType.System_Boolean), f_10625_3185_3202(F, text), f_10625_3237_3254(F, f_10625_3244_3253(text))), f_10625_3286_5149(F, f_10625_3328_3388(F, f_10625_3341_3358(F, hashCode), f_10625_3360_3387(F, 2166136261)), f_10625_3423_3461(F, f_10625_3436_3446(F, i), f_10625_3448_3460(F, 0)), f_10625_3496_3509(F, start), f_10625_3544_3558(F, again), f_10625_3593_4424(F, f_10625_3644_3661(F, hashCode), f_10625_3700_4423(F, BinaryOperatorKind.Multiplication, f_10625_3744_3757(hashCode), f_10625_3800_4360(F, BinaryOperatorKind.Xor, f_10625_3833_3846(hashCode), f_10625_3893_4295(F, f_10625_3903_3916(hashCode), f_10625_3967_4217(F, f_10625_4028_4045(F, text), f_10625_4100_4151(F, SpecialMember.System_String__Chars), f_10625_4206_4216(F, i)), Conversion.ImplicitNumeric), f_10625_4342_4359(F, hashCode)), f_10625_4403_4422(F, 16777619))), f_10625_4459_4713(F, f_10625_4510_4520(F, i), f_10625_4559_4712(F, BinaryOperatorKind.Addition, f_10625_4597_4603(i), f_10625_4646_4656(F, i), f_10625_4699_4711(F, 1))), f_10625_4748_4762(F, start), f_10625_4797_5148(F, f_10625_4840_5095(F, BinaryOperatorKind.LessThan, f_10625_4878_4919(F, SpecialType.System_Boolean), f_10625_4962_4972(F, i), f_10625_5015_5094(F, f_10625_5022_5039(F, text), f_10625_5041_5093(F, SpecialMember.System_String__Length))), f_10625_5134_5147(F, again)))), f_10625_5177_5204(F, f_10625_5186_5203(F, hashCode)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 5349, 5369);

                    f_10625_5349_5368(
                                    // NOTE: we created this block in its most-lowered form, so analysis is unnecessary
                                    F, body);
                }
                catch (SyntheticBoundNodeFactory.MissingPredefinedMember ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10625, 5398, 5584);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 5491, 5522);

                    f_10625_5491_5521(diagnostics, f_10625_5507_5520(ex));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 5540, 5569);

                    f_10625_5540_5568(F, f_10625_5554_5567(F));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10625, 5398, 5584);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10625, 1559, 5595);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10625_1757_1784(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedStringSwitchHashMethod
                symbol)
                {
                    var return_v = symbol.GetNonNullSyntaxNode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 1757, 1784);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                f_10625_1721_1816(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedStringSwitchHashMethod
                topLevelMethod, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)topLevelMethod, (Microsoft.CodeAnalysis.SyntaxNode)node, compilationState, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 1721, 1816);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10625_1943_1982(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 1943, 1982);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10625_1924_1983(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = this_param.SynthesizedLocal((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 1924, 1983);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10625_2044_2084(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 2044, 2084);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10625_2025_2085(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = this_param.SynthesizedLocal((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 2025, 2085);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10625_2126_2150(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, string
                prefix)
                {
                    var return_v = this_param.GenerateLabel(prefix);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 2126, 2150);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.GeneratedLabelSymbol
                f_10625_2189_2213(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, string
                prefix)
                {
                    var return_v = this_param.GenerateLabel(prefix);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 2189, 2213);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10625_2257_2272(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedStringSwitchHashMethod
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10625, 2257, 2272);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                f_10625_2956_3003(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item1, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                item2)
                {
                    var return_v = ImmutableArray.Create<LocalSymbol>(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 2956, 3003);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10625_3109_3150(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 3109, 3150);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundParameter
                f_10625_3185_3202(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                p)
                {
                    var return_v = this_param.Parameter(p);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 3185, 3202);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10625_3244_3253(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10625, 3244, 3253);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10625_3237_3254(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = this_param.Null(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 3237, 3254);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10625_3065_3255(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundParameter
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.Binary(kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, (Microsoft.CodeAnalysis.CSharp.BoundExpression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 3065, 3255);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10625_3341_3358(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 3341, 3358);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10625_3360_3387(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, uint
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 3360, 3387);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10625_3328_3388(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 3328, 3388);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10625_3436_3446(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 3436, 3446);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10625_3448_3460(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, int
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 3448, 3460);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10625_3423_3461(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 3423, 3461);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                f_10625_3496_3509(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = this_param.Goto(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 3496, 3509);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                f_10625_3544_3558(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = this_param.Label(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 3544, 3558);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10625_3644_3661(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 3644, 3661);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10625_3744_3757(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10625, 3744, 3757);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10625_3833_3846(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10625, 3833, 3846);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10625_3903_3916(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10625, 3903, 3916);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundParameter
                f_10625_4028_4045(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                p)
                {
                    var return_v = this_param.Parameter(p);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 4028, 4045);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10625_4100_4151(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialMember
                sm)
                {
                    var return_v = this_param.SpecialMethod(sm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 4100, 4151);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10625_4206_4216(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 4206, 4216);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10625_3967_4217(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundParameter
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundLocal
                arg0)
                {
                    var return_v = this_param.Call((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 3967, 4217);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10625_3893_4295(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundCall
                arg, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion)
                {
                    var return_v = this_param.Convert(type, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg, conversion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 3893, 4295);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10625_4342_4359(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 4342, 4359);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10625_3800_4360(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundLocal
                right)
                {
                    var return_v = this_param.Binary(kind, type, left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 3800, 4360);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10625_4403_4422(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, int
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 4403, 4422);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10625_3700_4423(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                left, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                right)
                {
                    var return_v = this_param.Binary(kind, type, (Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 3700, 4423);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10625_3593_4424(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 3593, 4424);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10625_4510_4520(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 4510, 4520);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10625_4597_4603(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10625, 4597, 4603);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10625_4646_4656(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 4646, 4656);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10625_4699_4711(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, int
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 4699, 4711);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10625_4559_4712(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                right)
                {
                    var return_v = this_param.Binary(kind, type, (Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 4559, 4712);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10625_4459_4713(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                right)
                {
                    var return_v = this_param.Assignment((Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 4459, 4713);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLabelStatement
                f_10625_4748_4762(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = this_param.Label(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 4748, 4762);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10625_4878_4919(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialType
                st)
                {
                    var return_v = this_param.SpecialType(st);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 4878, 4919);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10625_4962_4972(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 4962, 4972);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundParameter
                f_10625_5022_5039(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                p)
                {
                    var return_v = this_param.Parameter(p);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 5022, 5039);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10625_5041_5093(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.SpecialMember
                sm)
                {
                    var return_v = this_param.SpecialMethod(sm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 5041, 5093);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10625_5015_5094(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundParameter
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = this_param.Call((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 5015, 5094);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10625_4840_5095(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundLocal
                left, Microsoft.CodeAnalysis.CSharp.BoundCall
                right)
                {
                    var return_v = this_param.Binary(kind, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)type, (Microsoft.CodeAnalysis.CSharp.BoundExpression)left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 4840, 5095);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                f_10625_5134_5147(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LabelSymbol
                label)
                {
                    var return_v = this_param.Goto(label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 5134, 5147);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10625_4797_5148(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                condition, Microsoft.CodeAnalysis.CSharp.BoundGotoStatement
                thenClause)
                {
                    var return_v = this_param.If((Microsoft.CodeAnalysis.CSharp.BoundExpression)condition, (Microsoft.CodeAnalysis.CSharp.BoundStatement)thenClause);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 4797, 5148);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10625_3286_5149(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 3286, 5149);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10625_3030_5150(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                condition, Microsoft.CodeAnalysis.CSharp.BoundBlock
                thenClause)
                {
                    var return_v = this_param.If((Microsoft.CodeAnalysis.CSharp.BoundExpression)condition, (Microsoft.CodeAnalysis.CSharp.BoundStatement)thenClause);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 3030, 5150);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLocal
                f_10625_5186_5203(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                local)
                {
                    var return_v = this_param.Local(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 5186, 5203);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10625_5177_5204(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                expression)
                {
                    var return_v = this_param.Return((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 5177, 5204);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10625_2922_5227(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                locals, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(locals, statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 2922, 5227);
                    return return_v;
                }


                int
                f_10625_5349_5368(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                body)
                {
                    this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 5349, 5368);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_10625_5507_5520(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.MissingPredefinedMember
                this_param)
                {
                    var return_v = this_param.Diagnostic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10625, 5507, 5520);
                    return return_v;
                }


                int
                f_10625_5491_5521(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 5491, 5521);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10625_5554_5567(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.ThrowNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 5554, 5567);
                    return return_v;
                }


                int
                f_10625_5540_5568(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body)
                {
                    this_param.CloseMethod(body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 5540, 5568);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10625, 1559, 5595);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10625, 1559, 5595);
            }
        }

        static SynthesizedStringSwitchHashMethod()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10625, 400, 5602);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10625, 400, 5602);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10625, 400, 5602);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10625, 400, 5602);
    }
    internal sealed partial class SynthesizedExplicitImplementationForwardingMethod : SynthesizedImplementationMethod
    {
        internal override bool SynthesizesLoweredBoundBody
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10625, 5815, 5835);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 5821, 5833);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10625, 5815, 5835);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10625, 5740, 5846);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10625, 5740, 5846);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override void GenerateMethodBody(TypeCompilationState compilationState, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10625, 6431, 7421);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 6563, 6689);

                SyntheticBoundNodeFactory
                F = f_10625_6593_6688(this, f_10625_6629_6656(this), compilationState, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 6703, 6761);

                F.CurrentFunction = (MethodSymbol)f_10625_6737_6760(this);

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 6813, 7058);

                    MethodSymbol
                    methodToInvoke =
                    (DynAbs.Tracing.TraceSender.Conditional_F1(10625, 6864, 6884) || ((f_10625_6864_6884(this) && DynAbs.Tracing.TraceSender.Conditional_F2(10625, 6912, 7006)) || DynAbs.Tracing.TraceSender.Conditional_F3(10625, 7034, 7057))) ? f_10625_6912_7006(f_10625_6912_6935(this), this.TypeParameters.Cast<TypeParameterSymbol, TypeSymbol>()) : f_10625_7034_7057(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 7078, 7195);

                    f_10625_7078_7194(
                                    F, f_10625_7092_7193(F, methodToInvoke, useBaseReference: false));
                }
                catch (SyntheticBoundNodeFactory.MissingPredefinedMember ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10625, 7224, 7410);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 7317, 7348);

                    f_10625_7317_7347(diagnostics, f_10625_7333_7346(ex));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 7366, 7395);

                    f_10625_7366_7394(F, f_10625_7380_7393(F));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10625, 7224, 7410);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10625, 6431, 7421);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10625_6629_6656(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedExplicitImplementationForwardingMethod
                symbol)
                {
                    var return_v = symbol.GetNonNullSyntaxNode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 6629, 6656);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                f_10625_6593_6688(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedExplicitImplementationForwardingMethod
                topLevelMethod, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)topLevelMethod, (Microsoft.CodeAnalysis.SyntaxNode)node, compilationState, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 6593, 6688);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10625_6737_6760(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedExplicitImplementationForwardingMethod
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10625, 6737, 6760);
                    return return_v;
                }


                bool
                f_10625_6864_6884(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedExplicitImplementationForwardingMethod
                this_param)
                {
                    var return_v = this_param.IsGenericMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10625, 6864, 6884);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10625_6912_6935(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedExplicitImplementationForwardingMethod
                this_param)
                {
                    var return_v = this_param.ImplementingMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10625, 6912, 6935);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10625_6912_7006(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 6912, 7006);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10625_7034_7057(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedExplicitImplementationForwardingMethod
                this_param)
                {
                    var return_v = this_param.ImplementingMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10625, 7034, 7057);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10625_7092_7193(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                F, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodToInvoke, bool
                useBaseReference)
                {
                    var return_v = MethodBodySynthesizer.ConstructSingleInvocationMethodBody(F, methodToInvoke, useBaseReference: useBaseReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 7092, 7193);
                    return return_v;
                }


                int
                f_10625_7078_7194(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                body)
                {
                    this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 7078, 7194);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_10625_7333_7346(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.MissingPredefinedMember
                this_param)
                {
                    var return_v = this_param.Diagnostic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10625, 7333, 7346);
                    return return_v;
                }


                int
                f_10625_7317_7347(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 7317, 7347);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10625_7380_7393(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.ThrowNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 7380, 7393);
                    return return_v;
                }


                int
                f_10625_7366_7394(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body)
                {
                    this_param.CloseMethod(body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 7366, 7394);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10625, 6431, 7421);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10625, 6431, 7421);
            }
        }

        static SynthesizedExplicitImplementationForwardingMethod()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10625, 5610, 7428);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10625, 5610, 7428);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10625, 5610, 7428);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10625, 5610, 7428);
    }
    internal sealed partial class SynthesizedSealedPropertyAccessor : SynthesizedInstanceMethodSymbol
    {
        internal override bool SynthesizesLoweredBoundBody
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10625, 7625, 7645);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 7631, 7643);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10625, 7625, 7645);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10625, 7550, 7656);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10625, 7550, 7656);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool GenerateDebugInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10625, 7733, 7754);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 7739, 7752);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10625, 7733, 7754);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10625, 7668, 7765);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10625, 7668, 7765);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override void GenerateMethodBody(TypeCompilationState compilationState, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10625, 7982, 8715);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 8114, 8240);

                SyntheticBoundNodeFactory
                F = f_10625_8144_8239(this, f_10625_8180_8207(this), compilationState, diagnostics)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 8254, 8312);

                F.CurrentFunction = (MethodSymbol)f_10625_8288_8311(this);

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 8364, 8489);

                    f_10625_8364_8488(F, f_10625_8378_8487(F, f_10625_8439_8462(this), useBaseReference: true));
                }
                catch (SyntheticBoundNodeFactory.MissingPredefinedMember ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(10625, 8518, 8704);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 8611, 8642);

                    f_10625_8611_8641(diagnostics, f_10625_8627_8640(ex));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 8660, 8689);

                    f_10625_8660_8688(F, f_10625_8674_8687(F));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(10625, 8518, 8704);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10625, 7982, 8715);

                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10625_8180_8207(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSealedPropertyAccessor
                symbol)
                {
                    var return_v = symbol.GetNonNullSyntaxNode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 8180, 8207);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                f_10625_8144_8239(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSealedPropertyAccessor
                topLevelMethod, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)topLevelMethod, (Microsoft.CodeAnalysis.SyntaxNode)node, compilationState, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 8144, 8239);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10625_8288_8311(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSealedPropertyAccessor
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10625, 8288, 8311);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10625_8439_8462(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedSealedPropertyAccessor
                this_param)
                {
                    var return_v = this_param.OverriddenAccessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10625, 8439, 8462);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10625_8378_8487(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                F, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodToInvoke, bool
                useBaseReference)
                {
                    var return_v = MethodBodySynthesizer.ConstructSingleInvocationMethodBody(F, methodToInvoke, useBaseReference: useBaseReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 8378, 8487);
                    return return_v;
                }


                int
                f_10625_8364_8488(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBlock
                body)
                {
                    this_param.CloseMethod((Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 8364, 8488);
                    return 0;
                }


                Microsoft.CodeAnalysis.Diagnostic
                f_10625_8627_8640(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.MissingPredefinedMember
                this_param)
                {
                    var return_v = this_param.Diagnostic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10625, 8627, 8640);
                    return return_v;
                }


                int
                f_10625_8611_8641(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.Diagnostic
                diag)
                {
                    this_param.Add(diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 8611, 8641);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundStatement
                f_10625_8674_8687(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.ThrowNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 8674, 8687);
                    return return_v;
                }


                int
                f_10625_8660_8688(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundStatement
                body)
                {
                    this_param.CloseMethod(body);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 8660, 8688);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10625, 7982, 8715);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10625, 7982, 8715);
            }
        }

        static SynthesizedSealedPropertyAccessor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10625, 7436, 8722);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10625, 7436, 8722);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10625, 7436, 8722);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10625, 7436, 8722);
    }
    internal abstract partial class MethodToClassRewriter
    {
        private sealed partial class BaseMethodWrapperSymbol : SynthesizedMethodBaseSymbol
        {
            internal sealed override bool GenerateDebugInfo
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10625, 8987, 9008);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 8993, 9006);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10625, 8987, 9008);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10625, 8907, 9023);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10625, 8907, 9023);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override bool SynthesizesLoweredBoundBody
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10625, 9122, 9142);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 9128, 9140);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10625, 9122, 9142);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10625, 9039, 9157);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10625, 9039, 9157);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override void GenerateMethodBody(TypeCompilationState compilationState, DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10625, 9394, 10663);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 9534, 9660);

                    SyntheticBoundNodeFactory
                    F = f_10625_9564_9659(this, f_10625_9600_9627(this), compilationState, diagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 9678, 9722);

                    F.CurrentFunction = f_10625_9698_9721(this);

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 9786, 9836);

                        MethodSymbol
                        methodBeingWrapped = this.BaseMethod
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 9860, 10146) || true) && (f_10625_9864_9874(this) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10625, 9860, 10146);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 9928, 9981);

                            f_10625_9928_9980(f_10625_9941_9951(this) == f_10625_9955_9979(methodBeingWrapped));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 10007, 10123);

                            methodBeingWrapped = f_10625_10028_10122(f_10625_10028_10062(methodBeingWrapped), f_10625_10073_10121(f_10625_10101_10120(this)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10625, 9860, 10146);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 10170, 10293);

                        BoundBlock
                        body = f_10625_10188_10292(F, methodBeingWrapped, useBaseReference: true)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 10315, 10370) || true) && (f_10625_10319_10328(body) != BoundKind.Block)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10625, 10315, 10370);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 10349, 10370);

                            body = f_10625_10356_10369(F, body);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10625, 10315, 10370);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 10392, 10460);

                        f_10625_10392_10459(f_10625_10392_10410(F), methodBeingWrapped, this, body);
                    }
                    catch (SyntheticBoundNodeFactory.MissingPredefinedMember ex)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(10625, 10497, 10648);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 10598, 10629);

                        f_10625_10598_10628(diagnostics, f_10625_10614_10627(ex));
                        DynAbs.Tracing.TraceSender.TraceExitCatch(10625, 10497, 10648);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10625, 9394, 10663);

                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    f_10625_9600_9627(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter.BaseMethodWrapperSymbol
                    symbol)
                    {
                        var return_v = symbol.GetNonNullSyntaxNode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 9600, 9627);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    f_10625_9564_9659(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter.BaseMethodWrapperSymbol
                    topLevelMethod, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    node, Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                    compilationState, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)topLevelMethod, (Microsoft.CodeAnalysis.SyntaxNode)node, compilationState, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 9564, 9659);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10625_9698_9721(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter.BaseMethodWrapperSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10625, 9698, 9721);
                        return return_v;
                    }


                    int
                    f_10625_9864_9874(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter.BaseMethodWrapperSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10625, 9864, 9874);
                        return return_v;
                    }


                    int
                    f_10625_9941_9951(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter.BaseMethodWrapperSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10625, 9941, 9951);
                        return return_v;
                    }


                    int
                    f_10625_9955_9979(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10625, 9955, 9979);
                        return return_v;
                    }


                    int
                    f_10625_9928_9980(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 9928, 9980);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10625_10028_10062(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ConstructedFrom;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10625, 10028, 10062);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10625_10101_10120(Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter.BaseMethodWrapperSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10625, 10101, 10120);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                    f_10625_10073_10121(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    from)
                    {
                        var return_v = StaticCast<TypeSymbol>.From(from);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 10073, 10121);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10625_10028_10122(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                    typeArguments)
                    {
                        var return_v = this_param.Construct(typeArguments);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 10028, 10122);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundBlock
                    f_10625_10188_10292(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    F, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    methodToInvoke, bool
                    useBaseReference)
                    {
                        var return_v = MethodBodySynthesizer.ConstructSingleInvocationMethodBody(F, methodToInvoke, useBaseReference: useBaseReference);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 10188, 10292);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundKind
                    f_10625_10319_10328(Microsoft.CodeAnalysis.CSharp.BoundBlock
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10625, 10319, 10328);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundBlock
                    f_10625_10356_10369(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                    statements)
                    {
                        var return_v = this_param.Block(statements);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 10356, 10369);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                    f_10625_10392_10410(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                    this_param)
                    {
                        var return_v = this_param.CompilationState;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10625, 10392, 10410);
                        return return_v;
                    }


                    int
                    f_10625_10392_10459(Microsoft.CodeAnalysis.CSharp.TypeCompilationState
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    method, Microsoft.CodeAnalysis.CSharp.Symbols.MethodToClassRewriter.BaseMethodWrapperSymbol
                    wrapper, Microsoft.CodeAnalysis.CSharp.BoundBlock
                    body)
                    {
                        this_param.AddMethodWrapper(method, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)wrapper, (Microsoft.CodeAnalysis.CSharp.BoundStatement)body);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 10392, 10459);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.Diagnostic
                    f_10625_10614_10627(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory.MissingPredefinedMember
                    this_param)
                    {
                        var return_v = this_param.Diagnostic;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10625, 10614, 10627);
                        return return_v;
                    }


                    int
                    f_10625_10598_10628(Microsoft.CodeAnalysis.DiagnosticBag
                    this_param, Microsoft.CodeAnalysis.Diagnostic
                    diag)
                    {
                        this_param.Add(diag);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 10598, 10628);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10625, 9394, 10663);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10625, 9394, 10663);
                }
            }
        }
    }
    internal static class MethodBodySynthesizer
    {
        public const int
        HASH_FACTOR = -1521134295
        ;

        public static BoundExpression GenerateHashCombine(
                    BoundExpression currentHashValue,
                    MethodSymbol system_Collections_Generic_EqualityComparer_T__GetHashCode,
                    MethodSymbol system_Collections_Generic_EqualityComparer_T__get_Default,
                    ref BoundLiteral? boundHashFactor,
                    BoundExpression valueToHash,
                    SyntheticBoundNodeFactory F)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10625, 11010, 12435);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 11436, 11485);

                TypeSymbol
                system_Int32 = currentHashValue.Type!
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 11499, 11566);

                f_10625_11499_11565(f_10625_11512_11536(system_Int32) == SpecialType.System_Int32);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 11617, 11660);

                if (boundHashFactor is null)
                    DynAbs.Tracing.TraceSender.TraceEnterExpression(10625, 11617, 11660);

                boundHashFactor ??= f_10625_11637_11659(F, HASH_FACTOR);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 11756, 11871);

                currentHashValue = f_10625_11775_11870(F, BinaryOperatorKind.IntMultiplication, system_Int32, currentHashValue, boundHashFactor);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 12023, 12386);

                currentHashValue = f_10625_12042_12385(F, BinaryOperatorKind.IntAddition, system_Int32, currentHashValue, f_10625_12229_12384(system_Collections_Generic_EqualityComparer_T__GetHashCode, system_Collections_Generic_EqualityComparer_T__get_Default, valueToHash, F));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 12400, 12424);

                return currentHashValue;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10625, 11010, 12435);

                Microsoft.CodeAnalysis.SpecialType
                f_10625_11512_11536(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10625, 11512, 11536);
                    return return_v;
                }


                int
                f_10625_11499_11565(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 11499, 11565);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundLiteral
                f_10625_11637_11659(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, int
                value)
                {
                    var return_v = this_param.Literal(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 11637, 11659);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10625_11775_11870(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundLiteral
                right)
                {
                    var return_v = this_param.Binary(kind, type, left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 11775, 11870);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10625_12229_12384(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                system_Collections_Generic_EqualityComparer_T__GetHashCode, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                system_Collections_Generic_EqualityComparer_T__get_Default, Microsoft.CodeAnalysis.CSharp.BoundExpression
                valueToHash, Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                F)
                {
                    var return_v = GenerateGetHashCode(system_Collections_Generic_EqualityComparer_T__GetHashCode, system_Collections_Generic_EqualityComparer_T__get_Default, valueToHash, F);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 12229, 12384);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10625_12042_12385(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundCall
                right)
                {
                    var return_v = this_param.Binary(kind, type, left, (Microsoft.CodeAnalysis.CSharp.BoundExpression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 12042, 12385);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10625, 11010, 12435);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10625, 11010, 12435);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static BoundCall GenerateGetHashCode(
                    MethodSymbol system_Collections_Generic_EqualityComparer_T__GetHashCode,
                    MethodSymbol system_Collections_Generic_EqualityComparer_T__get_Default,
                    BoundExpression valueToHash,
                    SyntheticBoundNodeFactory F)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10625, 12447, 13425);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 12816, 12929);

                NamedTypeSymbol
                equalityComparerType = f_10625_12855_12928(system_Collections_Generic_EqualityComparer_T__GetHashCode)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 12943, 13038);

                NamedTypeSymbol
                constructedEqualityComparer = f_10625_12989_13037(equalityComparerType, f_10625_13020_13036(valueToHash))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 13054, 13414);

                return f_10625_13061_13413(F, f_10625_13068_13247(F, constructedEqualityComparer, f_10625_13150_13246(system_Collections_Generic_EqualityComparer_T__get_Default, constructedEqualityComparer)), f_10625_13276_13372(system_Collections_Generic_EqualityComparer_T__GetHashCode, constructedEqualityComparer), valueToHash);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10625, 12447, 13425);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10625_12855_12928(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10625, 12855, 12928);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10625_13020_13036(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10625, 13020, 13036);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10625_12989_13037(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 12989, 13037);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10625_13150_13246(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 13150, 13246);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10625_13068_13247(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                args)
                {
                    var return_v = this_param.StaticCall((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)receiver, method, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 13068, 13247);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10625_13276_13372(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 13276, 13372);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10625_13061_13413(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundExpression
                arg0)
                {
                    var return_v = this_param.Call(receiver, method, arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 13061, 13413);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10625, 12447, 13425);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10625, 12447, 13425);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static BoundExpression GenerateFieldEquals(
                    BoundExpression? initialExpression,
                    BoundExpression otherReceiver,
                    ArrayBuilder<FieldSymbol> fields,
                    SyntheticBoundNodeFactory F)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10625, 13724, 15995);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 13981, 14012);

                f_10625_13981_14011(f_10625_13994_14006(fields) > 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 14384, 14531);

                var
                equalityComparer_get_Default = f_10625_14419_14530(F, WellKnownMember.System_Collections_Generic_EqualityComparer_T__get_Default)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 14545, 14682);

                var
                equalityComparer_Equals = f_10625_14575_14681(F, WellKnownMember.System_Collections_Generic_EqualityComparer_T__Equals)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 14698, 14776);

                NamedTypeSymbol
                equalityComparerType = f_10625_14737_14775(equalityComparer_Equals)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 14792, 14843);

                BoundExpression?
                retExpression = initialExpression
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 14890, 15890);
                    foreach (var field in f_10625_14912_14918_I(fields))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10625, 14890, 15890);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 15001, 15078);

                        var
                        constructedEqualityComparer = f_10625_15035_15077(equalityComparerType, f_10625_15066_15076(field))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 15257, 15643);

                        BoundExpression
                        nextEquals = f_10625_15286_15642(F, f_10625_15315_15458(F, constructedEqualityComparer, f_10625_15391_15457(equalityComparer_get_Default, constructedEqualityComparer)), f_10625_15481_15542(equalityComparer_Equals, constructedEqualityComparer), f_10625_15565_15589(F, f_10625_15573_15581(F), field), f_10625_15612_15641(F, otherReceiver, field))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 15740, 15875);

                        retExpression = (DynAbs.Tracing.TraceSender.Conditional_F1(10625, 15756, 15777) || ((retExpression is null
                        && DynAbs.Tracing.TraceSender.Conditional_F2(10625, 15801, 15811)) || DynAbs.Tracing.TraceSender.Conditional_F3(10625, 15835, 15874))) ? nextEquals
                        : f_10625_15835_15874(F, retExpression, nextEquals);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10625, 14890, 15890);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10625, 1, 1001);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10625, 1, 1001);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 15906, 15947);

                f_10625_15906_15946(retExpression);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 15963, 15984);

                return retExpression;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10625, 13724, 15995);

                int
                f_10625_13994_14006(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10625, 13994, 14006);
                    return return_v;
                }


                int
                f_10625_13981_14011(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 13981, 14011);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10625_14419_14530(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                wm)
                {
                    var return_v = this_param.WellKnownMethod(wm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 14419, 14530);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10625_14575_14681(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                wm)
                {
                    var return_v = this_param.WellKnownMethod(wm);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 14575, 14681);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10625_14737_14775(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10625, 14737, 14775);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10625_15066_15076(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10625, 15066, 15076);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10625_15035_15077(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 15035, 15077);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10625_15391_15457(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 15391, 15457);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10625_15315_15458(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, params Microsoft.CodeAnalysis.CSharp.BoundExpression[]
                args)
                {
                    var return_v = this_param.StaticCall((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)receiver, method, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 15315, 15458);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10625_15481_15542(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 15481, 15542);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10625_15573_15581(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 15573, 15581);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10625_15565_15589(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundThisReference
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field((Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 15565, 15589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                f_10625_15612_15641(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f)
                {
                    var return_v = this_param.Field(receiver, f);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 15612, 15641);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10625_15286_15642(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                arg0, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                arg1)
                {
                    var return_v = this_param.Call(receiver, method, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg0, (Microsoft.CodeAnalysis.CSharp.BoundExpression)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 15286, 15642);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                f_10625_15835_15874(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                left, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    var return_v = this_param.LogicalAnd(left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 15835, 15874);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                f_10625_14912_14918_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 14912, 14918);
                    return return_v;
                }


                int
                f_10625_15906_15946(Microsoft.CodeAnalysis.CSharp.BoundExpression?
                value)
                {
                    RoslynDebug.AssertNotNull(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 15906, 15946);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10625, 13724, 15995);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10625, 13724, 15995);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static BoundBlock ConstructSingleInvocationMethodBody(SyntheticBoundNodeFactory F, MethodSymbol methodToInvoke, bool useBaseReference)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10625, 16473, 17409);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 16641, 16702);

                var
                argBuilder = f_10625_16658_16701()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 16718, 16763);

                f_10625_16718_16762(f_10625_16744_16761(F));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 16777, 16911);
                    foreach (var param in f_10625_16799_16827_I(f_10625_16799_16827(f_10625_16799_16816(F))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10625, 16777, 16911);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 16861, 16896);

                        f_10625_16861_16895(argBuilder, f_10625_16876_16894(F, param));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10625, 16777, 16911);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10625, 1, 135);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10625, 1, 135);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 16927, 17206);

                BoundExpression
                invocation = f_10625_16956_17205(F, (DynAbs.Tracing.TraceSender.Conditional_F1(10625, 16963, 16979) || ((useBaseReference && DynAbs.Tracing.TraceSender.Conditional_F2(10625, 16982, 17046)) || DynAbs.Tracing.TraceSender.Conditional_F3(10625, 17049, 17057))) ? (BoundExpression)f_10625_16999_17046(F, baseType: f_10625_17016_17045(methodToInvoke)) : f_10625_17049_17057(F), methodToInvoke, f_10625_17173_17204(argBuilder))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 17222, 17398);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10625, 17229, 17258) || ((f_10625_17229_17258(f_10625_17229_17246(F)) && DynAbs.Tracing.TraceSender.Conditional_F2(10625, 17286, 17340)) || DynAbs.Tracing.TraceSender.Conditional_F3(10625, 17368, 17397))) ? f_10625_17286_17340(F, f_10625_17294_17327(F, invocation), f_10625_17329_17339(F)) : f_10625_17368_17397(F, f_10625_17376_17396(F, invocation));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10625, 16473, 17409);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10625_16658_16701()
                {
                    var return_v = ArrayBuilder<BoundExpression>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 16658, 16701);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10625_16744_16761(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CurrentFunction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10625, 16744, 16761);
                    return return_v;
                }


                int
                f_10625_16718_16762(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                value)
                {
                    RoslynDebug.AssertNotNull(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 16718, 16762);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10625_16799_16816(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CurrentFunction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10625, 16799, 16816);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10625_16799_16827(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10625, 16799, 16827);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundParameter
                f_10625_16876_16894(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                p)
                {
                    var return_v = this_param.Parameter(p);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 16876, 16894);
                    return return_v;
                }


                int
                f_10625_16861_16895(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param, Microsoft.CodeAnalysis.CSharp.BoundParameter
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 16861, 16895);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10625_16799_16827_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 16799, 16827);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10625_17016_17045(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10625, 17016, 17045);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBaseReference
                f_10625_16999_17046(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                baseType)
                {
                    var return_v = this_param.Base(baseType: baseType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 16999, 17046);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundThisReference
                f_10625_17049_17057(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.This();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 17049, 17057);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10625_17173_17204(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 17173, 17204);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundCall
                f_10625_16956_17205(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiver, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                args)
                {
                    var return_v = this_param.Call(receiver, method, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 16956, 17205);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10625_17229_17246(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.CurrentFunction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10625, 17229, 17246);
                    return return_v;
                }


                bool
                f_10625_17229_17258(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnsVoid
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10625, 17229, 17258);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                f_10625_17294_17327(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = this_param.ExpressionStatement(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 17294, 17327);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10625_17329_17339(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param)
                {
                    var return_v = this_param.Return();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 17329, 17339);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10625_17286_17340(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 17286, 17340);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                f_10625_17376_17396(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expression)
                {
                    var return_v = this_param.Return(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 17376, 17396);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundBlock
                f_10625_17368_17397(Microsoft.CodeAnalysis.CSharp.SyntheticBoundNodeFactory
                this_param, params Microsoft.CodeAnalysis.CSharp.BoundStatement[]
                statements)
                {
                    var return_v = this_param.Block(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10625, 17368, 17397);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10625, 16473, 17409);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10625, 16473, 17409);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static MethodBodySynthesizer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10625, 10876, 17416);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10625, 10953, 10978);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10625, 10876, 17416);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10625, 10876, 17416);
        }

    }
}
