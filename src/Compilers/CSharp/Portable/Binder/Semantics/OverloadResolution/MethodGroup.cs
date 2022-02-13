// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class MethodGroup
    {
        internal BoundExpression Receiver { get; private set; }

        internal ArrayBuilder<MethodSymbol> Methods { get; }

        internal ArrayBuilder<TypeWithAnnotations> TypeArguments { get; }

        internal bool IsExtensionMethodGroup { get; private set; }

        internal DiagnosticInfo Error { get; private set; }

        internal LookupResultKind ResultKind { get; private set; }

        private MethodGroup()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10872, 969, 1149);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 568, 623);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 633, 685);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 695, 760);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 770, 828);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 838, 889);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 899, 957);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 1015, 1063);

                this.Methods = f_10872_1030_1062();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 1077, 1138);

                this.TypeArguments = f_10872_1098_1137();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10872, 969, 1149);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10872, 969, 1149);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10872, 969, 1149);
            }
        }

        internal void PopulateWithSingleMethod(
                    BoundExpression receiverOpt,
                    MethodSymbol method,
                    LookupResultKind resultKind = LookupResultKind.Viable,
                    DiagnosticInfo error = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10872, 1161, 1513);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 1411, 1463);

                f_10872_1411_1462(this, receiverOpt, resultKind, error);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 1477, 1502);

                f_10872_1477_1501(f_10872_1477_1489(this), method);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10872, 1161, 1513);

                int
                f_10872_1411_1462(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiverOpt, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.DiagnosticInfo?
                error)
                {
                    this_param.PopulateHelper(receiverOpt, resultKind, error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10872, 1411, 1462);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10872_1477_1489(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    var return_v = this_param.Methods;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10872, 1477, 1489);
                    return return_v;
                }


                int
                f_10872_1477_1501(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10872, 1477, 1501);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10872, 1161, 1513);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10872, 1161, 1513);
            }
        }

        internal void PopulateWithExtensionMethods(
                    BoundExpression receiverOpt,
                    ArrayBuilder<Symbol> members,
                    ImmutableArray<TypeWithAnnotations> typeArguments,
                    LookupResultKind resultKind = LookupResultKind.Viable,
                    DiagnosticInfo error = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10872, 1525, 2230);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 1852, 1904);

                f_10872_1852_1903(this, receiverOpt, resultKind, error);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 1918, 1953);

                this.IsExtensionMethodGroup = true;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 1967, 2085);
                    foreach (var member in f_10872_1990_1997_I(members))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10872, 1967, 2085);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 2031, 2070);

                        f_10872_2031_2069(f_10872_2031_2043(this), member);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10872, 1967, 2085);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10872, 1, 119);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10872, 1, 119);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 2099, 2219) || true) && (f_10872_2103_2127_M(!typeArguments.IsDefault))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10872, 2099, 2219);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 2161, 2204);

                    f_10872_2161_2203(f_10872_2161_2179(this), typeArguments);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10872, 2099, 2219);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10872, 1525, 2230);

                int
                f_10872_1852_1903(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiverOpt, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.DiagnosticInfo?
                error)
                {
                    this_param.PopulateHelper(receiverOpt, resultKind, error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10872, 1852, 1903);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10872_2031_2043(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    var return_v = this_param.Methods;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10872, 2031, 2043);
                    return return_v;
                }


                int
                f_10872_2031_2069(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10872, 2031, 2069);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10872_1990_1997_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10872, 1990, 1997);
                    return return_v;
                }


                bool
                f_10872_2103_2127_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10872, 2103, 2127);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10872_2161_2179(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    var return_v = this_param.TypeArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10872, 2161, 2179);
                    return return_v;
                }


                int
                f_10872_2161_2203(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10872, 2161, 2203);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10872, 1525, 2230);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10872, 1525, 2230);
            }
        }

        internal void PopulateWithNonExtensionMethods(
                    BoundExpression receiverOpt,
                    ImmutableArray<MethodSymbol> methods,
                    ImmutableArray<TypeWithAnnotations> typeArguments,
                    LookupResultKind resultKind = LookupResultKind.Viable,
                    DiagnosticInfo error = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10872, 2242, 2822);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 2580, 2632);

                f_10872_2580_2631(this, receiverOpt, resultKind, error);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 2646, 2677);

                f_10872_2646_2676(f_10872_2646_2658(this), methods);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 2691, 2811) || true) && (f_10872_2695_2719_M(!typeArguments.IsDefault))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10872, 2691, 2811);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 2753, 2796);

                    f_10872_2753_2795(f_10872_2753_2771(this), typeArguments);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10872, 2691, 2811);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10872, 2242, 2822);

                int
                f_10872_2580_2631(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                receiverOpt, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                resultKind, Microsoft.CodeAnalysis.DiagnosticInfo?
                error)
                {
                    this_param.PopulateHelper(receiverOpt, resultKind, error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10872, 2580, 2631);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10872_2646_2658(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    var return_v = this_param.Methods;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10872, 2646, 2658);
                    return return_v;
                }


                int
                f_10872_2646_2676(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10872, 2646, 2676);
                    return 0;
                }


                bool
                f_10872_2695_2719_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10872, 2695, 2719);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10872_2753_2771(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    var return_v = this_param.TypeArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10872, 2753, 2771);
                    return return_v;
                }


                int
                f_10872_2753_2795(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10872, 2753, 2795);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10872, 2242, 2822);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10872, 2242, 2822);
            }
        }

        private void PopulateHelper(BoundExpression receiverOpt, LookupResultKind resultKind, DiagnosticInfo error)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10872, 2834, 3109);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 2966, 2980);

                f_10872_2966_2979(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 2994, 3022);

                this.Receiver = receiverOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 3036, 3055);

                this.Error = error;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 3069, 3098);

                this.ResultKind = resultKind;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10872, 2834, 3109);

                int
                f_10872_2966_2979(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    this_param.VerifyClear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10872, 2966, 2979);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10872, 2834, 3109);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10872, 2834, 3109);
            }
        }

        public void Clear()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10872, 3121, 3440);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 3165, 3186);

                this.Receiver = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 3200, 3221);

                f_10872_3200_3220(f_10872_3200_3212(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 3235, 3262);

                f_10872_3235_3261(f_10872_3235_3253(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 3276, 3312);

                this.IsExtensionMethodGroup = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 3326, 3344);

                this.Error = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 3358, 3399);

                this.ResultKind = LookupResultKind.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 3415, 3429);

                f_10872_3415_3428(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10872, 3121, 3440);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10872_3200_3212(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    var return_v = this_param.Methods;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10872, 3200, 3212);
                    return return_v;
                }


                int
                f_10872_3200_3220(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10872, 3200, 3220);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10872_3235_3253(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    var return_v = this_param.TypeArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10872, 3235, 3253);
                    return return_v;
                }


                int
                f_10872_3235_3261(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10872, 3235, 3261);
                    return 0;
                }


                int
                f_10872_3415_3428(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    this_param.VerifyClear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10872, 3415, 3428);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10872, 3121, 3440);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10872, 3121, 3440);
            }
        }

        public string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10872, 3495, 3606);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 3531, 3591);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10872, 3538, 3560) || ((f_10872_3538_3556(f_10872_3538_3550(this)) > 0 && DynAbs.Tracing.TraceSender.Conditional_F2(10872, 3563, 3583)) || DynAbs.Tracing.TraceSender.Conditional_F3(10872, 3586, 3590))) ? f_10872_3563_3583(f_10872_3563_3578(f_10872_3563_3575(this), 0)) : null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10872, 3495, 3606);

                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    f_10872_3538_3550(Microsoft.CodeAnalysis.CSharp.MethodGroup
                    this_param)
                    {
                        var return_v = this_param.Methods;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10872, 3538, 3550);
                        return return_v;
                    }


                    int
                    f_10872_3538_3556(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10872, 3538, 3556);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    f_10872_3563_3575(Microsoft.CodeAnalysis.CSharp.MethodGroup
                    this_param)
                    {
                        var return_v = this_param.Methods;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10872, 3563, 3575);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10872_3563_3578(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10872, 3563, 3578);
                        return return_v;
                    }


                    string
                    f_10872_3563_3583(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10872, 3563, 3583);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10872, 3452, 3617);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10872, 3452, 3617);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public BoundExpression InstanceOpt
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10872, 3688, 4021);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 3724, 3822) || true) && (f_10872_3728_3741(this) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10872, 3724, 3822);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 3791, 3803);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10872, 3724, 3822);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 3842, 3965) || true) && (f_10872_3846_3864(f_10872_3846_3859(this)) == BoundKind.TypeExpression)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10872, 3842, 3965);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 3934, 3946);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10872, 3842, 3965);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 3985, 4006);

                    return f_10872_3992_4005(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10872, 3688, 4021);

                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10872_3728_3741(Microsoft.CodeAnalysis.CSharp.MethodGroup
                    this_param)
                    {
                        var return_v = this_param.Receiver;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10872, 3728, 3741);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10872_3846_3859(Microsoft.CodeAnalysis.CSharp.MethodGroup
                    this_param)
                    {
                        var return_v = this_param.Receiver;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10872, 3846, 3859);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundKind
                    f_10872_3846_3864(Microsoft.CodeAnalysis.CSharp.BoundExpression
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10872, 3846, 3864);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundExpression
                    f_10872_3992_4005(Microsoft.CodeAnalysis.CSharp.MethodGroup
                    this_param)
                    {
                        var return_v = this_param.Receiver;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10872, 3992, 4005);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10872, 3629, 4032);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10872, 3629, 4032);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        [Conditional("DEBUG")]
        private void VerifyClear()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10872, 4044, 4458);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 4127, 4163);

                f_10872_4127_4162(f_10872_4140_4153(this) == null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 4177, 4215);

                f_10872_4177_4214(f_10872_4190_4208(f_10872_4190_4202(this)) == 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 4229, 4273);

                f_10872_4229_4272(f_10872_4242_4266(f_10872_4242_4260(this)) == 0);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 4287, 4330);

                f_10872_4287_4329(f_10872_4300_4328_M(!this.IsExtensionMethodGroup));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 4344, 4377);

                f_10872_4344_4376(f_10872_4357_4367(this) == null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 4391, 4447);

                f_10872_4391_4446(f_10872_4404_4419(this) == LookupResultKind.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10872, 4044, 4458);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10872_4140_4153(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    var return_v = this_param.Receiver;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10872, 4140, 4153);
                    return return_v;
                }


                int
                f_10872_4127_4162(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10872, 4127, 4162);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                f_10872_4190_4202(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    var return_v = this_param.Methods;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10872, 4190, 4202);
                    return return_v;
                }


                int
                f_10872_4190_4208(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10872, 4190, 4208);
                    return return_v;
                }


                int
                f_10872_4177_4214(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10872, 4177, 4214);
                    return 0;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10872_4242_4260(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    var return_v = this_param.TypeArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10872, 4242, 4260);
                    return return_v;
                }


                int
                f_10872_4242_4266(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10872, 4242, 4266);
                    return return_v;
                }


                int
                f_10872_4229_4272(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10872, 4229, 4272);
                    return 0;
                }


                bool
                f_10872_4300_4328_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10872, 4300, 4328);
                    return return_v;
                }


                int
                f_10872_4287_4329(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10872, 4287, 4329);
                    return 0;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10872_4357_4367(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    var return_v = this_param.Error;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10872, 4357, 4367);
                    return return_v;
                }


                int
                f_10872_4344_4376(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10872, 4344, 4376);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10872_4404_4419(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    var return_v = this_param.ResultKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10872, 4404, 4419);
                    return return_v;
                }


                int
                f_10872_4391_4446(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10872, 4391, 4446);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10872, 4044, 4458);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10872, 4044, 4458);
            }
        }

        public static MethodGroup GetInstance()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10872, 4500, 4598);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 4564, 4587);

                return f_10872_4571_4586(Pool);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10872, 4500, 4598);

                Microsoft.CodeAnalysis.CSharp.MethodGroup
                f_10872_4571_4586(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.MethodGroup>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10872, 4571, 4586);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10872, 4500, 4598);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10872, 4500, 4598);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Free()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10872, 4610, 4707);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 4653, 4666);

                f_10872_4653_4665(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 4680, 4696);

                f_10872_4680_4695(Pool, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10872, 4610, 4707);

                int
                f_10872_4653_4665(Microsoft.CodeAnalysis.CSharp.MethodGroup
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10872, 4653, 4665);
                    return 0;
                }


                int
                f_10872_4680_4695(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.MethodGroup>
                this_param, Microsoft.CodeAnalysis.CSharp.MethodGroup
                obj)
                {
                    this_param.Free(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10872, 4680, 4695);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10872, 4610, 4707);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10872, 4610, 4707);
            }
        }

        public static readonly ObjectPool<MethodGroup> Pool;

        private static ObjectPool<MethodGroup> CreatePool()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10872, 4967, 5194);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 5043, 5079);

                ObjectPool<MethodGroup>
                pool = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 5093, 5157);

                pool = f_10872_5100_5156(() => new MethodGroup(), 10);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 5171, 5183);

                return pool;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10872, 4967, 5194);

                Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.MethodGroup>
                f_10872_5100_5156(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.MethodGroup>.Factory
                factory, int
                size)
                {
                    var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.MethodGroup>(factory, size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10872, 5100, 5156);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10872, 4967, 5194);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10872, 4967, 5194);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static MethodGroup()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10872, 518, 5223);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10872, 4935, 4954);
            Pool = f_10872_4942_4954(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10872, 518, 5223);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10872, 518, 5223);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10872, 518, 5223);

        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
        f_10872_1030_1062()
        {
            var return_v = new Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10872, 1030, 1062);
            return return_v;
        }


        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
        f_10872_1098_1137()
        {
            var return_v = new Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10872, 1098, 1137);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.MethodGroup>
        f_10872_4942_4954()
        {
            var return_v = CreatePool();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10872, 4942, 4954);
            return return_v;
        }

    }
}
