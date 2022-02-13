// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using System.Reflection;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class SymbolDisplayVisitor
    {
        private void AddConstantValue(ITypeSymbol type, object constantValue, bool preferNumericValueOrExpandedFlagsForEnum = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10958, 392, 1368);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10958, 541, 1357) || true) && (constantValue != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10958, 541, 1357);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10958, 600, 687);

                    f_10958_600_686(this, type, constantValue, preferNumericValueOrExpandedFlagsForEnum);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10958, 541, 1357);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10958, 541, 1357);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10958, 721, 1357) || true) && (f_10958_725_745(type) || (DynAbs.Tracing.TraceSender.Expression_False(10958, 725, 782) || f_10958_749_762(type) == TypeKind.Pointer) || (DynAbs.Tracing.TraceSender.Expression_False(10958, 725, 825) || f_10958_786_825(type)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10958, 721, 1357);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10958, 859, 894);

                        f_10958_859_893(this, SyntaxKind.NullKeyword);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10958, 721, 1357);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10958, 721, 1357);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10958, 960, 998);

                        f_10958_960_997(this, SyntaxKind.DefaultKeyword);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10958, 1016, 1342) || true) && (!f_10958_1021_1118(f_10958_1021_1048(format), SymbolDisplayMiscellaneousOptions.AllowDefaultLiteral))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10958, 1016, 1342);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10958, 1160, 1202);

                            f_10958_1160_1201(this, SyntaxKind.OpenParenToken);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10958, 1224, 1258);

                            f_10958_1224_1257(type, f_10958_1236_1256(this));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10958, 1280, 1323);

                            f_10958_1280_1322(this, SyntaxKind.CloseParenToken);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10958, 1016, 1342);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10958, 721, 1357);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10958, 541, 1357);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10958, 392, 1368);

                int
                f_10958_600_686(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.ITypeSymbol
                type, object
                constantValue, bool
                preferNumericValueOrExpandedFlagsForEnum)
                {
                    this_param.AddNonNullConstantValue(type, constantValue, preferNumericValueOrExpandedFlagsForEnum);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10958, 600, 686);
                    return 0;
                }


                bool
                f_10958_725_745(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.IsReferenceType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10958, 725, 745);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10958_749_762(Microsoft.CodeAnalysis.ITypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10958, 749, 762);
                    return return_v;
                }


                bool
                f_10958_786_825(Microsoft.CodeAnalysis.ITypeSymbol
                typeOpt)
                {
                    var return_v = ITypeSymbolHelpers.IsNullableType(typeOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10958, 786, 825);
                    return return_v;
                }


                int
                f_10958_859_893(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10958, 859, 893);
                    return 0;
                }


                int
                f_10958_960_997(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                keywordKind)
                {
                    this_param.AddKeyword(keywordKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10958, 960, 997);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                f_10958_1021_1048(Microsoft.CodeAnalysis.SymbolDisplayFormat
                this_param)
                {
                    var return_v = this_param.MiscellaneousOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10958, 1021, 1048);
                    return return_v;
                }


                bool
                f_10958_1021_1118(Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                options, Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
                flag)
                {
                    var return_v = options.IncludesOption(flag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10958, 1021, 1118);
                    return return_v;
                }


                int
                f_10958_1160_1201(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10958, 1160, 1201);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                f_10958_1236_1256(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    var return_v = this_param.NotFirstVisitor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10958, 1236, 1256);
                    return return_v;
                }


                int
                f_10958_1224_1257(Microsoft.CodeAnalysis.ITypeSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                visitor)
                {
                    this_param.Accept((Microsoft.CodeAnalysis.SymbolVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10958, 1224, 1257);
                    return 0;
                }


                int
                f_10958_1280_1322(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10958, 1280, 1322);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10958, 392, 1368);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10958, 392, 1368);
            }
        }

        protected override void AddExplicitlyCastedLiteralValue(INamedTypeSymbol namedType, SpecialType type, object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10958, 1380, 1726);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10958, 1520, 1562);

                f_10958_1520_1561(this, SyntaxKind.OpenParenToken);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10958, 1576, 1615);

                f_10958_1576_1614(namedType, f_10958_1593_1613(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10958, 1629, 1672);

                f_10958_1629_1671(this, SyntaxKind.CloseParenToken);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10958, 1686, 1715);

                f_10958_1686_1714(this, type, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10958, 1380, 1726);

                int
                f_10958_1520_1561(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10958, 1520, 1561);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                f_10958_1593_1613(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param)
                {
                    var return_v = this_param.NotFirstVisitor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10958, 1593, 1613);
                    return return_v;
                }


                int
                f_10958_1576_1614(Microsoft.CodeAnalysis.INamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplay.AbstractSymbolDisplayVisitor
                visitor)
                {
                    this_param.Accept((Microsoft.CodeAnalysis.SymbolVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10958, 1576, 1614);
                    return 0;
                }


                int
                f_10958_1629_1671(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10958, 1629, 1671);
                    return 0;
                }


                int
                f_10958_1686_1714(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.SpecialType
                type, object
                value)
                {
                    this_param.AddLiteralValue(type, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10958, 1686, 1714);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10958, 1380, 1726);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10958, 1380, 1726);
            }
        }

        protected override void AddLiteralValue(SpecialType type, object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10958, 1738, 2626);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10958, 1834, 1929);

                f_10958_1834_1928(f_10958_1847_1888(f_10958_1847_1876(f_10958_1847_1862(value))) || (DynAbs.Tracing.TraceSender.Expression_False(10958, 1847, 1907) || value is string) || (DynAbs.Tracing.TraceSender.Expression_False(10958, 1847, 1927) || value is decimal));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10958, 1943, 2048);

                var
                valueString = f_10958_1961_2047(value, quoteStrings: true, useHexadecimalNumbers: false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10958, 2062, 2096);

                f_10958_2062_2095(valueString != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10958, 2112, 2160);

                var
                kind = SymbolDisplayPartKind.NumericLiteral
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10958, 2174, 2545);

                switch (type)
                {

                    case SpecialType.System_Boolean:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10958, 2174, 2545);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10958, 2274, 2311);

                        kind = SymbolDisplayPartKind.Keyword;
                        DynAbs.Tracing.TraceSender.TraceBreak(10958, 2333, 2339);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10958, 2174, 2545);

                    case SpecialType.System_String:
                    case SpecialType.System_Char:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10958, 2174, 2545);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10958, 2459, 2502);

                        kind = SymbolDisplayPartKind.StringLiteral;
                        DynAbs.Tracing.TraceSender.TraceBreak(10958, 2524, 2530);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10958, 2174, 2545);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10958, 2561, 2615);

                f_10958_2561_2614(
                            this.builder, f_10958_2578_2613(this, kind, null, valueString));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10958, 1738, 2626);

                System.Type
                f_10958_1847_1862(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10958, 1847, 1862);
                    return return_v;
                }


                System.Reflection.TypeInfo
                f_10958_1847_1876(System.Type
                type)
                {
                    var return_v = type.GetTypeInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10958, 1847, 1876);
                    return return_v;
                }


                bool
                f_10958_1847_1888(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.IsPrimitive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10958, 1847, 1888);
                    return return_v;
                }


                int
                f_10958_1834_1928(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10958, 1834, 1928);
                    return 0;
                }


                string
                f_10958_1961_2047(object
                obj, bool
                quoteStrings, bool
                useHexadecimalNumbers)
                {
                    var return_v = SymbolDisplay.FormatPrimitive(obj, quoteStrings: quoteStrings, useHexadecimalNumbers: useHexadecimalNumbers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10958, 1961, 2047);
                    return return_v;
                }


                int
                f_10958_2062_2095(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10958, 2062, 2095);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolDisplayPart
                f_10958_2578_2613(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPartKind
                kind, Microsoft.CodeAnalysis.ISymbol
                symbol, string
                text)
                {
                    var return_v = this_param.CreatePart(kind, symbol, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10958, 2578, 2613);
                    return return_v;
                }


                int
                f_10958_2561_2614(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.SymbolDisplayPart>
                this_param, Microsoft.CodeAnalysis.SymbolDisplayPart
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10958, 2561, 2614);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10958, 1738, 2626);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10958, 1738, 2626);
            }
        }

        protected override void AddBitwiseOr()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10958, 2638, 2748);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10958, 2701, 2737);

                f_10958_2701_2736(this, SyntaxKind.BarToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10958, 2638, 2748);

                int
                f_10958_2701_2736(Microsoft.CodeAnalysis.CSharp.SymbolDisplayVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.SyntaxKind
                punctuationKind)
                {
                    this_param.AddPunctuation(punctuationKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10958, 2701, 2736);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10958, 2638, 2748);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10958, 2638, 2748);
            }
        }
    }
}
