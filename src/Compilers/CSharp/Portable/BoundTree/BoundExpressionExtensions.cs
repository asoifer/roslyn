// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal static partial class BoundExpressionExtensions
    {
        public static RefKind GetRefKind(this BoundExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10555, 659, 1332);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10555, 743, 1321);

                switch (f_10555_751_760(node))
                {

                    case BoundKind.Local:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10555, 743, 1321);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10555, 837, 883);

                        return f_10555_844_882(f_10555_844_874(((BoundLocal)node)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10555, 743, 1321);

                    case BoundKind.Parameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10555, 743, 1321);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10555, 950, 1004);

                        return f_10555_957_1003(f_10555_957_995(((BoundParameter)node)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10555, 743, 1321);

                    case BoundKind.Call:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10555, 743, 1321);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10555, 1066, 1106);

                        return f_10555_1073_1105(f_10555_1073_1097(((BoundCall)node)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10555, 743, 1321);

                    case BoundKind.PropertyAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10555, 743, 1321);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10555, 1178, 1236);

                        return f_10555_1185_1235(f_10555_1185_1227(((BoundPropertyAccess)node)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10555, 743, 1321);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10555, 743, 1321);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10555, 1286, 1306);

                        return RefKind.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10555, 743, 1321);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10555, 659, 1332);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10555_751_760(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10555, 751, 760);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10555_844_874(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10555, 844, 874);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10555_844_882(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10555, 844, 882);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10555_957_995(Microsoft.CodeAnalysis.CSharp.BoundParameter
                this_param)
                {
                    var return_v = this_param.ParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10555, 957, 995);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10555_957_1003(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10555, 957, 1003);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10555_1073_1097(Microsoft.CodeAnalysis.CSharp.BoundCall
                this_param)
                {
                    var return_v = this_param.Method;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10555, 1073, 1097);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10555_1073_1105(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10555, 1073, 1105);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10555_1185_1227(Microsoft.CodeAnalysis.CSharp.BoundPropertyAccess
                this_param)
                {
                    var return_v = this_param.PropertySymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10555, 1185, 1227);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10555_1185_1235(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10555, 1185, 1235);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10555, 659, 1332);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10555, 659, 1332);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsLiteralNull(this BoundExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10555, 1344, 1553);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10555, 1428, 1542);

                return node is { Kind: BoundKind.Literal, ConstantValue: { Discriminator: ConstantValueTypeDiscriminator.Null } };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10555, 1344, 1553);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10555, 1344, 1553);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10555, 1344, 1553);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsLiteralDefault(this BoundExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10555, 1565, 1708);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10555, 1652, 1697);

                return f_10555_1659_1668(node) == BoundKind.DefaultLiteral;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10555, 1565, 1708);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10555_1659_1668(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10555, 1659, 1668);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10555, 1565, 1708);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10555, 1565, 1708);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsImplicitObjectCreation(this BoundExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10555, 1720, 1892);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10555, 1815, 1881);

                return f_10555_1822_1831(node) == BoundKind.UnconvertedObjectCreationExpression;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10555, 1720, 1892);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10555_1822_1831(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10555, 1822, 1831);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10555, 1720, 1892);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10555, 1720, 1892);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsLiteralDefaultOrImplicitObjectCreation(this BoundExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10555, 1904, 2092);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10555, 2015, 2081);

                return f_10555_2022_2045(node) || (DynAbs.Tracing.TraceSender.Expression_False(10555, 2022, 2080) || f_10555_2049_2080(node));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10555, 1904, 2092);

                bool
                f_10555_2022_2045(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = node.IsLiteralDefault();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10555, 2022, 2045);
                    return return_v;
                }


                bool
                f_10555_2049_2080(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = node.IsImplicitObjectCreation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10555, 2049, 2080);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10555, 1904, 2092);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10555, 1904, 2092);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsDefaultValue(this BoundExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10555, 2469, 2910);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10555, 2554, 2700) || true) && (f_10555_2558_2567(node) == BoundKind.DefaultExpression || (DynAbs.Tracing.TraceSender.Expression_False(10555, 2558, 2639) || f_10555_2602_2611(node) == BoundKind.DefaultLiteral))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10555, 2554, 2700);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10555, 2673, 2685);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10555, 2554, 2700);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10555, 2716, 2752);

                var
                constValue = f_10555_2733_2751(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10555, 2766, 2870) || true) && (constValue != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10555, 2766, 2870);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10555, 2822, 2855);

                    return f_10555_2829_2854(constValue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10555, 2766, 2870);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10555, 2886, 2899);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10555, 2469, 2910);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10555_2558_2567(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10555, 2558, 2567);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10555_2602_2611(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10555, 2602, 2611);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10555_2733_2751(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10555, 2733, 2751);
                    return return_v;
                }


                bool
                f_10555_2829_2854(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.IsDefaultValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10555, 2829, 2854);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10555, 2469, 2910);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10555, 2469, 2910);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool HasExpressionType(this BoundExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10555, 2922, 3138);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10555, 3103, 3127);

                return f_10555_3110_3119(node) is { };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10555, 2922, 3138);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10555_3110_3119(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10555, 3110, 3119);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10555, 2922, 3138);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10555, 2922, 3138);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool HasDynamicType(this BoundExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10555, 3150, 3320);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10555, 3235, 3256);

                var
                type = f_10555_3246_3255(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10555, 3270, 3309);

                return type is { } && (DynAbs.Tracing.TraceSender.Expression_True(10555, 3277, 3308) && f_10555_3292_3308(type));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10555, 3150, 3320);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10555_3246_3255(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10555, 3246, 3255);
                    return return_v;
                }


                bool
                f_10555_3292_3308(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10555, 3292, 3308);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10555, 3150, 3320);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10555, 3150, 3320);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool MethodGroupReceiverIsDynamic(this BoundMethodGroup node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10555, 3332, 3512);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10555, 3432, 3501);

                return f_10555_3439_3455(node) != null && (DynAbs.Tracing.TraceSender.Expression_True(10555, 3439, 3500) && f_10555_3467_3500(f_10555_3467_3483(node)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10555, 3332, 3512);

                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10555_3439_3455(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.InstanceOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10555, 3439, 3455);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10555_3467_3483(Microsoft.CodeAnalysis.CSharp.BoundMethodGroup
                this_param)
                {
                    var return_v = this_param.InstanceOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10555, 3467, 3483);
                    return return_v;
                }


                bool
                f_10555_3467_3500(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = node.HasDynamicType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10555, 3467, 3500);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10555, 3332, 3512);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10555, 3332, 3512);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool HasExpressionSymbols(this BoundExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10555, 3524, 4357);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10555, 3615, 4346);

                switch (f_10555_3623_3632(node))
                {

                    case BoundKind.Call:
                    case BoundKind.Local:
                    case BoundKind.FieldAccess:
                    case BoundKind.PropertyAccess:
                    case BoundKind.IndexerAccess:
                    case BoundKind.EventAccess:
                    case BoundKind.MethodGroup:
                    case BoundKind.ObjectCreationExpression:
                    case BoundKind.TypeExpression:
                    case BoundKind.NamespaceExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10555, 3615, 4346);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10555, 4136, 4148);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10555, 3615, 4346);

                    case BoundKind.BadExpression:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10555, 3615, 4346);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10555, 4217, 4270);

                        return ((BoundBadExpression)node).Symbols.Length > 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10555, 3615, 4346);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10555, 3615, 4346);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10555, 4318, 4331);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10555, 3615, 4346);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10555, 3524, 4357);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10555_3623_3632(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10555, 3623, 3632);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10555, 3524, 4357);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10555, 3524, 4357);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static void GetExpressionSymbols(this BoundExpression node, ArrayBuilder<Symbol> symbols, BoundNode parent, Binder binder)
        {
            switch (node.Kind)
            {
                case BoundKind.MethodGroup:
                    // Special case: if we are looking for info on "M" in "new Action(M)" in the context of a parent 
                    // then we want to get the symbol that overload resolution chose for M, not on the whole method group M.
                    var delegateCreation = parent as BoundDelegateCreationExpression;
                    if (delegateCreation != null && delegateCreation.MethodOpt is { })
                    {
                        symbols.Add(delegateCreation.MethodOpt);
                    }
                    else
                    {
                        symbols.AddRange(CSharpSemanticModel.GetReducedAndFilteredMethodGroupSymbols(binder, (BoundMethodGroup)node));
                    }
                    break;

                case BoundKind.BadExpression:
                    foreach (var s in ((BoundBadExpression)node).Symbols)
                    {
                        if (s is { })
                            symbols.Add(s);
                    }
                    break;

                case BoundKind.DelegateCreationExpression:
                    var expr = (BoundDelegateCreationExpression)node;
                    var ctor = expr.Type.GetMembers(WellKnownMemberNames.InstanceConstructorName).FirstOrDefault();
                    if (ctor is { })
                    {
                        symbols.Add(ctor);
                    }
                    break;

                case BoundKind.Call:
                    // Either overload resolution succeeded for this call or it did not. If it did not
                    // succeed then we've stashed the original method symbols from the method group,
                    // and we should use those as the symbols displayed for the call. If it did succeed
                    // then we did not stash any symbols; just fall through to the default case.

                    var originalMethods = ((BoundCall)node).OriginalMethodsOpt;
                    if (originalMethods.IsDefault)
                    {
                        goto default;
                    }
                    symbols.AddRange(originalMethods);
                    break;

                case BoundKind.IndexerAccess:
                    // Same behavior as for a BoundCall: if overload resolution failed, pull out stashed candidates;
                    // otherwise use the default behavior.

                    var originalIndexers = ((BoundIndexerAccess)node).OriginalIndexersOpt;
                    if (originalIndexers.IsDefault)
                    {
                        goto default;
                    }
                    symbols.AddRange(originalIndexers);
                    break;

                default:
                    var symbol = node.ExpressionSymbol;
                    if (symbol is { })
                    {
                        symbols.Add(symbol);
                    }
                    break;
            }
        }

        public static Conversion GetConversion(this BoundExpression boundNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10555, 7716, 8133);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10555, 7811, 8122);

                switch (f_10555_7819_7833(boundNode))
                {

                    case BoundKind.Conversion:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10555, 7811, 8122);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10555, 7915, 7975);

                        BoundConversion
                        conversionNode = (BoundConversion)boundNode
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10555, 7997, 8030);

                        return f_10555_8004_8029(conversionNode);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10555, 7811, 8122);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10555, 7811, 8122);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10555, 8080, 8107);

                        return Conversion.Identity;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10555, 7811, 8122);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10555, 7716, 8133);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10555_7819_7833(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10555, 7819, 7833);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10555_8004_8029(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Conversion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10555, 8004, 8029);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10555, 7716, 8133);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10555, 7716, 8133);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsExpressionOfComImportType([NotNullWhen(true)] this BoundExpression? expressionOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10555, 8145, 9099);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10555, 8866, 8923) || true) && (expressionOpt == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10555, 8866, 8923);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10555, 8910, 8923);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10555, 8866, 8923);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10555, 8939, 8985);

                TypeSymbol?
                receiverType = f_10555_8966_8984(expressionOpt)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10555, 8999, 9088);

                return receiverType is NamedTypeSymbol { Kind: SymbolKind.NamedType, IsComImport: true };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10555, 8145, 9099);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10555_8966_8984(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10555, 8966, 8984);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10555, 8145, 9099);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10555, 8145, 9099);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static BoundExpressionExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10555, 409, 9106);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10555, 409, 9106);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10555, 409, 9106);
        }

    }
}
