// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal static partial class TypeSymbolExtensions
    {
        public static int CustomModifierCount(this TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10063, 712, 3098);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 796, 878) || true) && ((object)type == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10063, 796, 878);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 854, 863);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10063, 796, 878);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 985, 2840);

                switch (f_10063_993_1002(type))
                {

                    case SymbolKind.ArrayType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10063, 985, 2840);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 1111, 1145);

                            var
                            array = (ArrayTypeSymbol)type
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 1171, 1254);

                            return f_10063_1178_1253(f_10063_1220_1252(array));
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10063, 985, 2840);

                    case SymbolKind.PointerType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10063, 985, 2840);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 1372, 1410);

                            var
                            pointer = (PointerTypeSymbol)type
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 1436, 1523);

                            return f_10063_1443_1522(f_10063_1485_1521(pointer));
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10063, 985, 2840);

                    case SymbolKind.FunctionPointerType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10063, 985, 2840);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 1649, 1722);

                            return f_10063_1656_1721(f_10063_1656_1699(((FunctionPointerTypeSymbol)type)));
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10063, 985, 2840);

                    case SymbolKind.ErrorType:
                    case SymbolKind.NamedType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10063, 985, 2840);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 1882, 1920);

                            bool
                            isDefinition = f_10063_1902_1919(type)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 1948, 2770) || true) && (!isDefinition)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10063, 1948, 2770);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 2023, 2061);

                                var
                                namedType = (NamedTypeSymbol)type
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 2091, 2105);

                                int
                                count = 0
                                ;
                                try
                                {
                                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 2137, 2698) || true) && ((object)namedType != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10063, 2137, 2698);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 2235, 2341);

                                        ImmutableArray<TypeWithAnnotations>
                                        typeArgs = f_10063_2282_2340(namedType)
                                        ;
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 2377, 2594);
                                            foreach (TypeWithAnnotations typeArg in f_10063_2417_2425_I(typeArgs))
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10063, 2377, 2594);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 2499, 2559);

                                                count += f_10063_2508_2558(typeArg);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10063, 2377, 2594);
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10063, 1, 218);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(10063, 1, 218);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 2630, 2667);

                                        namedType = f_10063_2642_2666(namedType);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10063, 2137, 2698);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10063, 2137, 2698);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10063, 2137, 2698);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 2730, 2743);

                                return count;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10063, 1948, 2770);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10063, 2796, 2802);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10063, 985, 2840);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 2856, 2865);

                return 0;

                int customModifierCountForTypeWithAnnotations(TypeWithAnnotations typeWithAnnotations)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10063, 2992, 3086);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 2995, 3086);
                        return typeWithAnnotations.CustomModifiers.Length + f_10063_3040_3086(typeWithAnnotations.Type); DynAbs.Tracing.TraceSender.TraceExitMethod(10063, 2992, 3086);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10063, 2992, 3086);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10063, 2992, 3086);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10063, 712, 3098);

                Microsoft.CodeAnalysis.SymbolKind
                f_10063_993_1002(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10063, 993, 1002);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10063_1220_1252(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10063, 1220, 1252);
                    return return_v;
                }


                int
                f_10063_1178_1253(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                typeWithAnnotations)
                {
                    var return_v = customModifierCountForTypeWithAnnotations(typeWithAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10063, 1178, 1253);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10063_1485_1521(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.PointedAtTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10063, 1485, 1521);
                    return return_v;
                }


                int
                f_10063_1443_1522(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                typeWithAnnotations)
                {
                    var return_v = customModifierCountForTypeWithAnnotations(typeWithAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10063, 1443, 1522);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10063_1656_1699(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10063, 1656, 1699);
                    return return_v;
                }


                int
                f_10063_1656_1721(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                method)
                {
                    var return_v = method.CustomModifierCount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10063, 1656, 1721);
                    return return_v;
                }


                bool
                f_10063_1902_1919(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10063, 1902, 1919);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10063_2282_2340(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10063, 2282, 2340);
                    return return_v;
                }


                int
                f_10063_2508_2558(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                typeWithAnnotations)
                {
                    var return_v = customModifierCountForTypeWithAnnotations(typeWithAnnotations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10063, 2508, 2558);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10063_2417_2425_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10063, 2417, 2425);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10063_2642_2666(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10063, 2642, 2666);
                    return return_v;
                }


                int
                f_10063_3040_3086(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.CustomModifierCount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10063, 3040, 3086);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10063, 712, 3098);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10063, 712, 3098);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool HasCustomModifiers(this TypeSymbol type, bool flagNonDefaultArraySizesOrLowerBounds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10063, 3522, 7090);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 3650, 3736) || true) && ((object)type == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10063, 3650, 3736);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 3708, 3721);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10063, 3650, 3736);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 3843, 6764);

                switch (f_10063_3851_3860(type))
                {

                    case SymbolKind.ArrayType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10063, 3843, 6764);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 3969, 4003);

                            var
                            array = (ArrayTypeSymbol)type
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 4029, 4096);

                            TypeWithAnnotations
                            elementType = f_10063_4063_4095(array)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 4122, 4321);

                            return f_10063_4129_4205(elementType, flagNonDefaultArraySizesOrLowerBounds) || (DynAbs.Tracing.TraceSender.Expression_False(10063, 4129, 4320) || (flagNonDefaultArraySizesOrLowerBounds && (DynAbs.Tracing.TraceSender.Expression_True(10063, 4242, 4319) && f_10063_4283_4319_M(!array.HasDefaultSizesAndLowerBounds))));
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10063, 3843, 6764);

                    case SymbolKind.PointerType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10063, 3843, 6764);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 4439, 4477);

                            var
                            pointer = (PointerTypeSymbol)type
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 4503, 4576);

                            TypeWithAnnotations
                            pointedAtType = f_10063_4539_4575(pointer)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 4602, 4688);

                            return f_10063_4609_4687(pointedAtType, flagNonDefaultArraySizesOrLowerBounds);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10063, 3843, 6764);

                    case SymbolKind.FunctionPointerType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10063, 3843, 6764);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 4814, 4860);

                            var
                            funcPtr = (FunctionPointerTypeSymbol)type
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 4886, 5144) || true) && (f_10063_4890_4935_M(!f_10063_4891_4908(funcPtr).RefCustomModifiers.IsEmpty) || (DynAbs.Tracing.TraceSender.Expression_False(10063, 4890, 5047) || f_10063_4939_5047(f_10063_4964_5007(f_10063_4964_4981(funcPtr)), flagNonDefaultArraySizesOrLowerBounds)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10063, 4886, 5144);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 5105, 5117);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10063, 4886, 5144);
                            }
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 5172, 5547);
                                foreach (var param in f_10063_5194_5222_I(f_10063_5194_5222(f_10063_5194_5211(funcPtr))))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10063, 5172, 5547);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 5280, 5520) || true) && (f_10063_5284_5317_M(!param.RefCustomModifiers.IsEmpty) || (DynAbs.Tracing.TraceSender.Expression_False(10063, 5284, 5411) || f_10063_5321_5411(f_10063_5346_5371(param), flagNonDefaultArraySizesOrLowerBounds)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10063, 5280, 5520);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 5477, 5489);

                                        return true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10063, 5280, 5520);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10063, 5172, 5547);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10063, 1, 376);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10063, 1, 376);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 5575, 5588);

                            return false;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10063, 3843, 6764);

                    case SymbolKind.ErrorType:
                    case SymbolKind.NamedType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10063, 3843, 6764);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 5748, 5786);

                            bool
                            isDefinition = f_10063_5768_5785(type)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 5814, 6694) || true) && (!isDefinition)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10063, 5814, 6694);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 5889, 5927);

                                var
                                namedType = (NamedTypeSymbol)type
                                ;
                                try
                                {
                                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 5957, 6667) || true) && ((object)namedType != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10063, 5957, 6667);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 6055, 6161);

                                        ImmutableArray<TypeWithAnnotations>
                                        typeArgs = f_10063_6102_6160(namedType)
                                        ;
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 6197, 6563);
                                            foreach (TypeWithAnnotations typeArg in f_10063_6237_6245_I(typeArgs))
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10063, 6197, 6563);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 6319, 6528) || true) && (f_10063_6323_6395(typeArg, flagNonDefaultArraySizesOrLowerBounds))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10063, 6319, 6528);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 6477, 6489);

                                                    return true;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10063, 6319, 6528);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10063, 6197, 6563);
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10063, 1, 367);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(10063, 1, 367);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 6599, 6636);

                                        namedType = f_10063_6611_6635(namedType);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10063, 5957, 6667);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10063, 5957, 6667);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10063, 5957, 6667);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10063, 5814, 6694);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(10063, 6720, 6726);

                            break;
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10063, 3843, 6764);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 6780, 6793);

                return false;

                bool checkTypeWithAnnotations(TypeWithAnnotations typeWithAnnotations, bool flagNonDefaultArraySizesOrLowerBounds)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10063, 6948, 7078);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 6951, 7078);
                        return typeWithAnnotations.CustomModifiers.Any() || (DynAbs.Tracing.TraceSender.Expression_False(10063, 6951, 7078) || f_10063_6996_7078(typeWithAnnotations.Type, flagNonDefaultArraySizesOrLowerBounds)); DynAbs.Tracing.TraceSender.TraceExitMethod(10063, 6948, 7078);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10063, 6948, 7078);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10063, 6948, 7078);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10063, 3522, 7090);

                Microsoft.CodeAnalysis.SymbolKind
                f_10063_3851_3860(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10063, 3851, 3860);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10063_4063_4095(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                this_param)
                {
                    var return_v = this_param.ElementTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10063, 4063, 4095);
                    return return_v;
                }


                bool
                f_10063_4129_4205(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                typeWithAnnotations, bool
                flagNonDefaultArraySizesOrLowerBounds)
                {
                    var return_v = checkTypeWithAnnotations(typeWithAnnotations, flagNonDefaultArraySizesOrLowerBounds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10063, 4129, 4205);
                    return return_v;
                }


                bool
                f_10063_4283_4319_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10063, 4283, 4319);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10063_4539_4575(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.PointedAtTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10063, 4539, 4575);
                    return return_v;
                }


                bool
                f_10063_4609_4687(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                typeWithAnnotations, bool
                flagNonDefaultArraySizesOrLowerBounds)
                {
                    var return_v = checkTypeWithAnnotations(typeWithAnnotations, flagNonDefaultArraySizesOrLowerBounds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10063, 4609, 4687);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10063_4891_4908(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10063, 4891, 4908);
                    return return_v;
                }


                bool
                f_10063_4890_4935_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10063, 4890, 4935);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10063_4964_4981(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10063, 4964, 4981);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10063_4964_5007(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10063, 4964, 5007);
                    return return_v;
                }


                bool
                f_10063_4939_5047(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                typeWithAnnotations, bool
                flagNonDefaultArraySizesOrLowerBounds)
                {
                    var return_v = checkTypeWithAnnotations(typeWithAnnotations, flagNonDefaultArraySizesOrLowerBounds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10063, 4939, 5047);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10063_5194_5211(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10063, 5194, 5211);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10063_5194_5222(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10063, 5194, 5222);
                    return return_v;
                }


                bool
                f_10063_5284_5317_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10063, 5284, 5317);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10063_5346_5371(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10063, 5346, 5371);
                    return return_v;
                }


                bool
                f_10063_5321_5411(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                typeWithAnnotations, bool
                flagNonDefaultArraySizesOrLowerBounds)
                {
                    var return_v = checkTypeWithAnnotations(typeWithAnnotations, flagNonDefaultArraySizesOrLowerBounds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10063, 5321, 5411);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10063_5194_5222_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10063, 5194, 5222);
                    return return_v;
                }


                bool
                f_10063_5768_5785(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10063, 5768, 5785);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10063_6102_6160(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10063, 6102, 6160);
                    return return_v;
                }


                bool
                f_10063_6323_6395(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                typeWithAnnotations, bool
                flagNonDefaultArraySizesOrLowerBounds)
                {
                    var return_v = checkTypeWithAnnotations(typeWithAnnotations, flagNonDefaultArraySizesOrLowerBounds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10063, 6323, 6395);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10063_6237_6245_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10063, 6237, 6245);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10063_6611_6635(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10063, 6611, 6635);
                    return return_v;
                }


                bool
                f_10063_6996_7078(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, bool
                flagNonDefaultArraySizesOrLowerBounds)
                {
                    var return_v = type.HasCustomModifiers(flagNonDefaultArraySizesOrLowerBounds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10063, 6996, 7078);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10063, 3522, 7090);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10063, 3522, 7090);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool CanUnifyWith(this TypeSymbol thisType, TypeSymbol otherType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10063, 7295, 7463);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 7399, 7452);

                return f_10063_7406_7451(thisType, otherType);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10063, 7295, 7463);

                bool
                f_10063_7406_7451(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2)
                {
                    var return_v = TypeUnification.CanUnify(t1, t2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10063, 7406, 7451);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10063, 7295, 7463);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10063, 7295, 7463);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static TypeSymbol GetNextBaseTypeNoUseSiteDiagnostics(this TypeSymbol type, ConsList<TypeSymbol> basesBeingResolved, CSharpCompilation compilation, ref PooledHashSet<NamedTypeSymbol> visited)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10063, 7948, 8954);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 8173, 8943);

                switch (f_10063_8181_8194(type))
                {

                    case TypeKind.TypeParameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10063, 8173, 8943);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 8278, 8352);

                        return f_10063_8285_8351(((TypeParameterSymbol)type));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10063, 8173, 8943);

                    case TypeKind.Class:
                    case TypeKind.Struct:
                    case TypeKind.Error:
                    case TypeKind.Interface:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10063, 8173, 8943);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 8533, 8629);

                        return f_10063_8540_8628(type, basesBeingResolved, compilation, ref visited);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10063, 8173, 8943);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10063, 8173, 8943);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 8887, 8928);

                        return f_10063_8894_8927(type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10063, 8173, 8943);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10063, 7948, 8954);

                Microsoft.CodeAnalysis.TypeKind
                f_10063_8181_8194(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10063, 8181, 8194);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10063_8285_8351(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.EffectiveBaseClassNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10063, 8285, 8351);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10063_8540_8628(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, ref Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                visited)
                {
                    var return_v = GetNextDeclaredBase((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)type, basesBeingResolved, compilation, ref visited);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10063, 8540, 8628);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10063_8894_8927(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10063, 8894, 8927);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10063, 7948, 8954);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10063, 7948, 8954);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static TypeSymbol GetNextDeclaredBase(NamedTypeSymbol type, ConsList<TypeSymbol> basesBeingResolved, CSharpCompilation compilation, ref PooledHashSet<NamedTypeSymbol> visited)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10063, 8966, 10726);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 9235, 9311);

                f_10063_9235_9310(visited == null || (DynAbs.Tracing.TraceSender.Expression_False(10063, 9248, 9309) || !f_10063_9268_9309(visited, f_10063_9285_9308(type))));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 9327, 9483) || true) && (basesBeingResolved != null && (DynAbs.Tracing.TraceSender.Expression_True(10063, 9331, 9422) && f_10063_9361_9422(basesBeingResolved, f_10063_9398_9421(type))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10063, 9327, 9483);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 9456, 9468);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10063, 9327, 9483);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 9499, 9669) || true) && (f_10063_9503_9519(type) == SpecialType.System_Object)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10063, 9499, 9669);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 9582, 9624);

                    f_10063_9582_9623(type);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 9642, 9654);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10063, 9499, 9669);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 9685, 9745);

                var
                nextType = f_10063_9700_9744(type, basesBeingResolved)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 9831, 10021) || true) && ((object)nextType == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10063, 9831, 10021);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 9893, 9941);

                    f_10063_9893_9940(ref visited);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 9959, 10006);

                    return f_10063_9966_10005(type, compilation);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10063, 9831, 10021);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 10037, 10076);

                var
                origType = f_10063_10052_10075(type)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 10090, 10683) || true) && (f_10063_10094_10134(nextType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10063, 10090, 10683);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 10168, 10214);

                    f_10063_10168_10213(origType);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 10232, 10280);

                    f_10063_10232_10279(ref visited);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10063, 10090, 10683);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10063, 10090, 10683);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 10387, 10453);

                    visited = visited ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>?>(10063, 10397, 10452) ?? f_10063_10408_10452());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 10471, 10493);

                    f_10063_10471_10492(visited, origType);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 10511, 10668) || true) && (f_10063_10515_10560(visited, f_10063_10532_10559(nextType)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10063, 10511, 10668);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 10602, 10649);

                        return f_10063_10609_10648(type, compilation);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10063, 10511, 10668);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10063, 10090, 10683);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 10699, 10715);

                return nextType;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10063, 8966, 10726);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10063_9285_9308(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10063, 9285, 9308);
                    return return_v;
                }


                bool
                f_10063_9268_9309(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10063, 9268, 9309);
                    return return_v;
                }


                int
                f_10063_9235_9310(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10063, 9235, 9310);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10063_9398_9421(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10063, 9398, 9421);
                    return return_v;
                }


                bool
                f_10063_9361_9422(Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                list, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                element)
                {
                    var return_v = list.ContainsReference<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)element);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10063, 9361, 9422);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10063_9503_9519(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10063, 9503, 9519);
                    return return_v;
                }


                int
                f_10063_9582_9623(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    this_param.SetKnownToHaveNoDeclaredBaseCycles();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10063, 9582, 9623);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10063_9700_9744(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>?
                basesBeingResolved)
                {
                    var return_v = this_param.GetDeclaredBaseType(basesBeingResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10063, 9700, 9744);
                    return return_v;
                }


                int
                f_10063_9893_9940(ref Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>?
                visited)
                {
                    SetKnownToHaveNoDeclaredBaseCycles(ref visited);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10063, 9893, 9940);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10063_9966_10005(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = GetDefaultBaseOrNull(type, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10063, 9966, 10005);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10063_10052_10075(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10063, 10052, 10075);
                    return return_v;
                }


                bool
                f_10063_10094_10134(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.KnownToHaveNoDeclaredBaseCycles;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10063, 10094, 10134);
                    return return_v;
                }


                int
                f_10063_10168_10213(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    this_param.SetKnownToHaveNoDeclaredBaseCycles();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10063, 10168, 10213);
                    return 0;
                }


                int
                f_10063_10232_10279(ref Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>?
                visited)
                {
                    SetKnownToHaveNoDeclaredBaseCycles(ref visited);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10063, 10232, 10279);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10063_10408_10452()
                {
                    var return_v = PooledHashSet<NamedTypeSymbol>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10063, 10408, 10452);
                    return return_v;
                }


                bool
                f_10063_10471_10492(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10063, 10471, 10492);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10063_10532_10559(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10063, 10532, 10559);
                    return return_v;
                }


                bool
                f_10063_10515_10560(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10063, 10515, 10560);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10063_10609_10648(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = GetDefaultBaseOrNull(type, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10063, 10609, 10648);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10063, 8966, 10726);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10063, 8966, 10726);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void SetKnownToHaveNoDeclaredBaseCycles(ref PooledHashSet<NamedTypeSymbol> visited)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10063, 10738, 11133);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 10861, 11122) || true) && (visited != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10063, 10861, 11122);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 10914, 11039);
                        foreach (var v in f_10063_10932_10939_I(visited))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10063, 10914, 11039);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 10981, 11020);

                            f_10063_10981_11019(v);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10063, 10914, 11039);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10063, 1, 126);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10063, 1, 126);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 11059, 11074);

                    f_10063_11059_11073(
                                    visited);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 11092, 11107);

                    visited = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10063, 10861, 11122);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10063, 10738, 11133);

                int
                f_10063_10981_11019(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    this_param.SetKnownToHaveNoDeclaredBaseCycles();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10063, 10981, 11019);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10063_10932_10939_I(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10063, 10932, 10939);
                    return return_v;
                }


                int
                f_10063_11059_11073(Microsoft.CodeAnalysis.PooledObjects.PooledHashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10063, 11059, 11073);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10063, 10738, 11133);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10063, 10738, 11133);
            }
        }

        private static NamedTypeSymbol GetDefaultBaseOrNull(NamedTypeSymbol type, CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10063, 11145, 11919);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 11274, 11358) || true) && (compilation == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10063, 11274, 11358);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 11331, 11343);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10063, 11274, 11358);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 11374, 11908);

                switch (f_10063_11382_11395(type))
                {

                    case TypeKind.Class:
                    case TypeKind.Error:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10063, 11374, 11908);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 11509, 11579);

                        return f_10063_11516_11578(f_10063_11516_11536(compilation), SpecialType.System_Object);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10063, 11374, 11908);

                    case TypeKind.Interface:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10063, 11374, 11908);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 11643, 11655);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10063, 11374, 11908);

                    case TypeKind.Struct:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10063, 11374, 11908);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 11716, 11789);

                        return f_10063_11723_11788(f_10063_11723_11743(compilation), SpecialType.System_ValueType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10063, 11374, 11908);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10063, 11374, 11908);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10063, 11837, 11893);

                        throw f_10063_11843_11892(f_10063_11878_11891(type));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10063, 11374, 11908);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10063, 11145, 11919);

                Microsoft.CodeAnalysis.TypeKind
                f_10063_11382_11395(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10063, 11382, 11395);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10063_11516_11536(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10063, 11516, 11536);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10063_11516_11578(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.SpecialType
                type)
                {
                    var return_v = this_param.GetSpecialType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10063, 11516, 11578);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10063_11723_11743(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10063, 11723, 11743);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10063_11723_11788(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.SpecialType
                type)
                {
                    var return_v = this_param.GetSpecialType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10063, 11723, 11788);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10063_11878_11891(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10063, 11878, 11891);
                    return return_v;
                }


                System.Exception
                f_10063_11843_11892(Microsoft.CodeAnalysis.TypeKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10063, 11843, 11892);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10063, 11145, 11919);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10063, 11145, 11919);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
