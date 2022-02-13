// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal enum TupleBinaryOperatorInfoKind
    {
        Single,
        NullNull,
        Multiple
    }
    internal abstract class TupleBinaryOperatorInfo
    {
        internal abstract TupleBinaryOperatorInfoKind InfoKind { get; }

        internal readonly TypeSymbol? LeftConvertedTypeOpt;

        internal readonly TypeSymbol? RightConvertedTypeOpt;

        internal abstract TreeDumperNode DumpCore();

        internal string Dump()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10590, 1324, 1361);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10590, 1327, 1361);
                return f_10590_1327_1361(f_10590_1350_1360(this)); DynAbs.Tracing.TraceSender.TraceExitMethod(10590, 1324, 1361);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10590, 1324, 1361);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10590, 1324, 1361);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.TreeDumperNode
            f_10590_1350_1360(Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo
            this_param)
            {
                var return_v = this_param.DumpCore();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10590, 1350, 1360);
                return return_v;
            }


            string
            f_10590_1327_1361(Microsoft.CodeAnalysis.TreeDumperNode
            root)
            {
                var return_v = TreeDumper.DumpCompact(root);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10590, 1327, 1361);
                return return_v;
            }

        }

        private TupleBinaryOperatorInfo(TypeSymbol? leftConvertedTypeOpt, TypeSymbol? rightConvertedTypeOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10590, 1382, 1622);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10590, 1143, 1163);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10590, 1204, 1225);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10590, 1507, 1551);

                LeftConvertedTypeOpt = leftConvertedTypeOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10590, 1565, 1611);

                RightConvertedTypeOpt = rightConvertedTypeOpt;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10590, 1382, 1622);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10590, 1382, 1622);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10590, 1382, 1622);
            }
        }
        internal class Single : TupleBinaryOperatorInfo
        {
            internal readonly BinaryOperatorKind Kind;

            internal readonly MethodSymbol? MethodSymbolOpt;

            internal readonly Conversion ConversionForBool;

            internal readonly UnaryOperatorSignature BoolOperator;

            internal Single(
                            TypeSymbol? leftConvertedTypeOpt,
                            TypeSymbol? rightConvertedTypeOpt,
                            BinaryOperatorKind kind,
                            MethodSymbol? methodSymbolOpt,
                            Conversion conversionForBool, UnaryOperatorSignature boolOperator) : base(f_10590_2661_2681_C(leftConvertedTypeOpt), rightConvertedTypeOpt)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10590, 2360, 3002);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10590, 1916, 1920);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10590, 1967, 1982);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10590, 2738, 2750);

                    Kind = kind;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10590, 2768, 2802);

                    MethodSymbolOpt = methodSymbolOpt;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10590, 2820, 2858);

                    ConversionForBool = conversionForBool;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10590, 2876, 2904);

                    BoolOperator = boolOperator;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10590, 2924, 2987);

                    f_10590_2924_2986(f_10590_2937_2957(Kind) == (MethodSymbolOpt is { }));
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10590, 2360, 3002);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10590, 2360, 3002);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10590, 2360, 3002);
                }
            }

            internal override TupleBinaryOperatorInfoKind InfoKind
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10590, 3090, 3127);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10590, 3093, 3127);
                        return TupleBinaryOperatorInfoKind.Single; DynAbs.Tracing.TraceSender.TraceExitMethod(10590, 3090, 3127);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10590, 3090, 3127);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10590, 3090, 3127);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override string ToString()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10590, 3195, 3227);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10590, 3198, 3227);
                    return $"binaryOperatorKind: {Kind}"; DynAbs.Tracing.TraceSender.TraceExitMethod(10590, 3195, 3227);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10590, 3195, 3227);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10590, 3195, 3227);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override TreeDumperNode DumpCore()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10590, 3255, 3867);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10590, 3331, 3368);

                    var
                    sub = f_10590_3341_3367()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10590, 3386, 3561) || true) && (MethodSymbolOpt is { })
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10590, 3386, 3561);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10590, 3454, 3542);

                        f_10590_3454_3541(sub, f_10590_3462_3540("methodSymbolOpt", f_10590_3500_3533(MethodSymbolOpt), null));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10590, 3386, 3561);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10590, 3579, 3672);

                    f_10590_3579_3671(sub, f_10590_3587_3670("leftConversion", f_10590_3624_3663_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(LeftConvertedTypeOpt, 10590, 3624, 3663)?.ToDisplayString()), null));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10590, 3690, 3785);

                    f_10590_3690_3784(sub, f_10590_3698_3783("rightConversion", f_10590_3736_3776_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(RightConvertedTypeOpt, 10590, 3736, 3776)?.ToDisplayString()), null));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10590, 3805, 3852);

                    return f_10590_3812_3851("nested", Kind, sub);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10590, 3255, 3867);

                    System.Collections.Generic.List<Microsoft.CodeAnalysis.TreeDumperNode>
                    f_10590_3341_3367()
                    {
                        var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.TreeDumperNode>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10590, 3341, 3367);
                        return return_v;
                    }


                    string
                    f_10590_3500_3533(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ToDisplayString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10590, 3500, 3533);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.TreeDumperNode
                    f_10590_3462_3540(string
                    text, string
                    value, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TreeDumperNode>?
                    children)
                    {
                        var return_v = new Microsoft.CodeAnalysis.TreeDumperNode(text, (object)value, children);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10590, 3462, 3540);
                        return return_v;
                    }


                    int
                    f_10590_3454_3541(System.Collections.Generic.List<Microsoft.CodeAnalysis.TreeDumperNode>
                    this_param, Microsoft.CodeAnalysis.TreeDumperNode
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10590, 3454, 3541);
                        return 0;
                    }


                    string?
                    f_10590_3624_3663_I(string?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10590, 3624, 3663);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.TreeDumperNode
                    f_10590_3587_3670(string
                    text, string?
                    value, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TreeDumperNode>?
                    children)
                    {
                        var return_v = new Microsoft.CodeAnalysis.TreeDumperNode(text, (object?)value, children);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10590, 3587, 3670);
                        return return_v;
                    }


                    int
                    f_10590_3579_3671(System.Collections.Generic.List<Microsoft.CodeAnalysis.TreeDumperNode>
                    this_param, Microsoft.CodeAnalysis.TreeDumperNode
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10590, 3579, 3671);
                        return 0;
                    }


                    string?
                    f_10590_3736_3776_I(string?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10590, 3736, 3776);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.TreeDumperNode
                    f_10590_3698_3783(string
                    text, string?
                    value, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TreeDumperNode>?
                    children)
                    {
                        var return_v = new Microsoft.CodeAnalysis.TreeDumperNode(text, (object?)value, children);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10590, 3698, 3783);
                        return return_v;
                    }


                    int
                    f_10590_3690_3784(System.Collections.Generic.List<Microsoft.CodeAnalysis.TreeDumperNode>
                    this_param, Microsoft.CodeAnalysis.TreeDumperNode
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10590, 3690, 3784);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.TreeDumperNode
                    f_10590_3812_3851(string
                    text, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                    value, System.Collections.Generic.List<Microsoft.CodeAnalysis.TreeDumperNode>
                    children)
                    {
                        var return_v = new Microsoft.CodeAnalysis.TreeDumperNode(text, (object)value, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TreeDumperNode>)children);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10590, 3812, 3851);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10590, 3255, 3867);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10590, 3255, 3867);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static Single()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10590, 1807, 3886);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10590, 1807, 3886);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10590, 1807, 3886);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10590, 1807, 3886);

            bool
            f_10590_2937_2957(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
            kind)
            {
                var return_v = kind.IsUserDefined();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10590, 2937, 2957);
                return return_v;
            }


            int
            f_10590_2924_2986(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10590, 2924, 2986);
                return 0;
            }


            static Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
            f_10590_2661_2681_C(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10590, 2360, 3002);
                return return_v;
            }

        }
        internal class Multiple : TupleBinaryOperatorInfo
        {
            internal readonly ImmutableArray<TupleBinaryOperatorInfo> Operators;

            internal static readonly Multiple ErrorInstance;

            internal Multiple(ImmutableArray<TupleBinaryOperatorInfo> operators, TypeSymbol? leftConvertedTypeOpt, TypeSymbol? rightConvertedTypeOpt)
            : base(f_10590_4640_4660_C(leftConvertedTypeOpt), rightConvertedTypeOpt)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10590, 4478, 5195);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10590, 4717, 4811);

                    f_10590_4717_4810(leftConvertedTypeOpt is null || (DynAbs.Tracing.TraceSender.Expression_False(10590, 4730, 4809) || f_10590_4762_4809(f_10590_4762_4797(leftConvertedTypeOpt))));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10590, 4829, 4925);

                    f_10590_4829_4924(rightConvertedTypeOpt is null || (DynAbs.Tracing.TraceSender.Expression_False(10590, 4842, 4923) || f_10590_4875_4923(f_10590_4875_4911(rightConvertedTypeOpt))));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10590, 4943, 4978);

                    f_10590_4943_4977(f_10590_4956_4976_M(!operators.IsDefault));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10590, 4996, 5052);

                    f_10590_4996_5051(operators.IsEmpty || (DynAbs.Tracing.TraceSender.Expression_False(10590, 5009, 5050) || operators.Length > 1));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10590, 5158, 5180);

                    Operators = operators;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10590, 4478, 5195);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10590, 4478, 5195);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10590, 4478, 5195);
                }
            }

            internal override TupleBinaryOperatorInfoKind InfoKind
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10590, 5283, 5322);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10590, 5286, 5322);
                        return TupleBinaryOperatorInfoKind.Multiple; DynAbs.Tracing.TraceSender.TraceExitMethod(10590, 5283, 5322);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10590, 5283, 5322);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10590, 5283, 5322);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override TreeDumperNode DumpCore()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10590, 5350, 5702);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10590, 5426, 5463);

                    var
                    sub = f_10590_5436_5462()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10590, 5481, 5620);

                    f_10590_5481_5619(sub, f_10590_5489_5618($"nestedOperators[{Operators.Length}]", null, Operators.SelectAsArray(c => c.DumpCore())));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10590, 5640, 5687);

                    return f_10590_5647_5686("nested", null, sub);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10590, 5350, 5702);

                    System.Collections.Generic.List<Microsoft.CodeAnalysis.TreeDumperNode>
                    f_10590_5436_5462()
                    {
                        var return_v = new System.Collections.Generic.List<Microsoft.CodeAnalysis.TreeDumperNode>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10590, 5436, 5462);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.TreeDumperNode
                    f_10590_5489_5618(string
                    text, object?
                    value, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TreeDumperNode>
                    children)
                    {
                        var return_v = new Microsoft.CodeAnalysis.TreeDumperNode(text, value, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TreeDumperNode>)children);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10590, 5489, 5618);
                        return return_v;
                    }


                    int
                    f_10590_5481_5619(System.Collections.Generic.List<Microsoft.CodeAnalysis.TreeDumperNode>
                    this_param, Microsoft.CodeAnalysis.TreeDumperNode
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10590, 5481, 5619);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.TreeDumperNode
                    f_10590_5647_5686(string
                    text, object?
                    value, System.Collections.Generic.List<Microsoft.CodeAnalysis.TreeDumperNode>
                    children)
                    {
                        var return_v = new Microsoft.CodeAnalysis.TreeDumperNode(text, value, (System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TreeDumperNode>)children);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10590, 5647, 5686);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10590, 5350, 5702);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10590, 5350, 5702);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static Multiple()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10590, 4109, 5721);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10590, 4301, 4461);
                ErrorInstance = f_10590_4334_4461(operators: ImmutableArray<TupleBinaryOperatorInfo>.Empty, leftConvertedTypeOpt: null, rightConvertedTypeOpt: null); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10590, 4109, 5721);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10590, 4109, 5721);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10590, 4109, 5721);

            static Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo.Multiple
            f_10590_4334_4461(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo>
            operators, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
            leftConvertedTypeOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
            rightConvertedTypeOpt)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.TupleBinaryOperatorInfo.Multiple(operators: operators, leftConvertedTypeOpt: leftConvertedTypeOpt, rightConvertedTypeOpt: rightConvertedTypeOpt);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10590, 4334, 4461);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            f_10590_4762_4797(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            type)
            {
                var return_v = type.StrippedType();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10590, 4762, 4797);
                return return_v;
            }


            bool
            f_10590_4762_4809(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            this_param)
            {
                var return_v = this_param.IsTupleType;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10590, 4762, 4809);
                return return_v;
            }


            int
            f_10590_4717_4810(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10590, 4717, 4810);
                return 0;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            f_10590_4875_4911(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            type)
            {
                var return_v = type.StrippedType();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10590, 4875, 4911);
                return return_v;
            }


            bool
            f_10590_4875_4923(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            this_param)
            {
                var return_v = this_param.IsTupleType;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10590, 4875, 4923);
                return return_v;
            }


            int
            f_10590_4829_4924(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10590, 4829, 4924);
                return 0;
            }


            bool
            f_10590_4956_4976_M(bool
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10590, 4956, 4976);
                return return_v;
            }


            int
            f_10590_4943_4977(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10590, 4943, 4977);
                return 0;
            }


            int
            f_10590_4996_5051(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10590, 4996, 5051);
                return 0;
            }


            static Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
            f_10590_4640_4660_C(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10590, 4478, 5195);
                return return_v;
            }

        }
        internal class NullNull : TupleBinaryOperatorInfo
        {
            internal readonly BinaryOperatorKind Kind;

            internal NullNull(BinaryOperatorKind kind)
            : base(leftConvertedTypeOpt: f_10590_6103_6129_C(null), rightConvertedTypeOpt: null)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10590, 6036, 6219);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10590, 6015, 6019);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10590, 6192, 6204);

                    Kind = kind;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10590, 6036, 6219);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10590, 6036, 6219);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10590, 6036, 6219);
                }
            }

            internal override TupleBinaryOperatorInfoKind InfoKind
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10590, 6307, 6346);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10590, 6310, 6346);
                        return TupleBinaryOperatorInfoKind.NullNull; DynAbs.Tracing.TraceSender.TraceExitMethod(10590, 6307, 6346);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10590, 6307, 6346);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10590, 6307, 6346);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override TreeDumperNode DumpCore()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10590, 6374, 6532);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10590, 6450, 6517);

                    return f_10590_6457_6516("nullnull", value: Kind, children: null);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10590, 6374, 6532);

                    Microsoft.CodeAnalysis.TreeDumperNode
                    f_10590_6457_6516(string
                    text, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                    value, System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.TreeDumperNode>?
                    children)
                    {
                        var return_v = new Microsoft.CodeAnalysis.TreeDumperNode(text, value: (object)value, children: children);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10590, 6457, 6516);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10590, 6374, 6532);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10590, 6374, 6532);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static NullNull()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10590, 5904, 6551);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10590, 5904, 6551);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10590, 5904, 6551);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10590, 5904, 6551);

            static Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
            f_10590_6103_6129_C(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10590, 6036, 6219);
                return return_v;
            }

        }

        static TupleBinaryOperatorInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10590, 976, 6558);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10590, 976, 6558);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10590, 976, 6558);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10590, 976, 6558);
    }
}
