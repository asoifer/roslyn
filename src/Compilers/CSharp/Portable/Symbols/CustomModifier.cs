// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract partial class CSharpCustomModifier : CustomModifier
    {
        protected readonly NamedTypeSymbol modifier;

        private CSharpCustomModifier(NamedTypeSymbol modifier)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10098, 587, 755);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10098, 566, 574);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10098, 666, 705);

                f_10098_666_704((object)modifier != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10098, 719, 744);

                this.modifier = modifier;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10098, 587, 755);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10098, 587, 755);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10098, 587, 755);
            }
        }

        public override INamedTypeSymbol Modifier
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10098, 965, 1050);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10098, 1001, 1035);

                    return f_10098_1008_1034(modifier);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10098, 965, 1050);

                    Microsoft.CodeAnalysis.INamedTypeSymbol?
                    f_10098_1008_1034(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    symbol)
                    {
                        var return_v = symbol.GetPublicSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10098, 1008, 1034);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10098, 899, 1061);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10098, 899, 1061);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public NamedTypeSymbol ModifierSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10098, 1135, 1202);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10098, 1171, 1187);

                    return modifier;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10098, 1135, 1202);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10098, 1073, 1213);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10098, 1073, 1213);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract override int GetHashCode();

        public abstract override bool Equals(object obj);

        internal static CustomModifier CreateOptional(NamedTypeSymbol modifier)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10098, 1341, 1492);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10098, 1437, 1481);

                return f_10098_1444_1480(modifier);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10098, 1341, 1492);

                Microsoft.CodeAnalysis.CSharp.Symbols.CSharpCustomModifier.OptionalCustomModifier
                f_10098_1444_1480(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                modifier)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.CSharpCustomModifier.OptionalCustomModifier(modifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10098, 1444, 1480);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10098, 1341, 1492);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10098, 1341, 1492);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static CustomModifier CreateRequired(NamedTypeSymbol modifier)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10098, 1504, 1655);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10098, 1600, 1644);

                return f_10098_1607_1643(modifier);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10098, 1504, 1655);

                Microsoft.CodeAnalysis.CSharp.Symbols.CSharpCustomModifier.RequiredCustomModifier
                f_10098_1607_1643(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                modifier)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.CSharpCustomModifier.RequiredCustomModifier(modifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10098, 1607, 1643);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10098, 1504, 1655);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10098, 1504, 1655);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<CustomModifier> Convert(ImmutableArray<ModifierInfo<TypeSymbol>> customModifiers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10098, 1667, 1997);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10098, 1804, 1926) || true) && (customModifiers.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10098, 1804, 1926);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10098, 1867, 1911);

                    return ImmutableArray<CustomModifier>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10098, 1804, 1926);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10098, 1940, 1986);

                return customModifiers.SelectAsArray(Convert);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10098, 1667, 1997);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10098, 1667, 1997);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10098, 1667, 1997);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static CustomModifier Convert(ModifierInfo<TypeSymbol> customModifier)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10098, 2009, 2280);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10098, 2112, 2168);

                var
                modifier = (NamedTypeSymbol)customModifier.Modifier
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10098, 2182, 2269);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10098, 2189, 2214) || ((customModifier.IsOptional && DynAbs.Tracing.TraceSender.Conditional_F2(10098, 2217, 2241)) || DynAbs.Tracing.TraceSender.Conditional_F3(10098, 2244, 2268))) ? f_10098_2217_2241(modifier) : f_10098_2244_2268(modifier);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10098, 2009, 2280);

                Microsoft.CodeAnalysis.CustomModifier
                f_10098_2217_2241(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                modifier)
                {
                    var return_v = CreateOptional(modifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10098, 2217, 2241);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CustomModifier
                f_10098_2244_2268(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                modifier)
                {
                    var return_v = CreateRequired(modifier);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10098, 2244, 2268);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10098, 2009, 2280);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10098, 2009, 2280);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private class OptionalCustomModifier : CSharpCustomModifier
        {
            public OptionalCustomModifier(NamedTypeSymbol modifier)
            : base(f_10098_2456_2464_C(modifier))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10098, 2376, 2482);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10098, 2376, 2482);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10098, 2376, 2482);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10098, 2376, 2482);
                }
            }

            public override bool IsOptional
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10098, 2562, 2637);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10098, 2606, 2618);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10098, 2562, 2637);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10098, 2498, 2652);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10098, 2498, 2652);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10098, 2668, 2779);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10098, 2734, 2764);

                    return f_10098_2741_2763(modifier);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10098, 2668, 2779);

                    int
                    f_10098_2741_2763(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10098, 2741, 2763);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10098, 2668, 2779);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10098, 2668, 2779);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool Equals(object obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10098, 2795, 3147);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10098, 2867, 2970) || true) && (f_10098_2871_2897(this, obj))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10098, 2867, 2970);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10098, 2939, 2951);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10098, 2867, 2970);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10098, 2990, 3051);

                    OptionalCustomModifier
                    other = obj as OptionalCustomModifier
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10098, 3071, 3132);

                    return other != null && (DynAbs.Tracing.TraceSender.Expression_True(10098, 3078, 3131) && f_10098_3095_3131(other.modifier, this.modifier));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10098, 2795, 3147);

                    bool
                    f_10098_2871_2897(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpCustomModifier.OptionalCustomModifier
                    objA, object
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10098, 2871, 2897);
                        return return_v;
                    }


                    bool
                    f_10098_3095_3131(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    obj)
                    {
                        var return_v = this_param.Equals((object)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10098, 3095, 3131);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10098, 2795, 3147);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10098, 2795, 3147);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static OptionalCustomModifier()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10098, 2292, 3158);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10098, 2292, 3158);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10098, 2292, 3158);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10098, 2292, 3158);

            static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10098_2456_2464_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10098, 2376, 2482);
                return return_v;
            }

        }
        private class RequiredCustomModifier : CSharpCustomModifier
        {
            public RequiredCustomModifier(NamedTypeSymbol modifier)
            : base(f_10098_3334_3342_C(modifier))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10098, 3254, 3360);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10098, 3254, 3360);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10098, 3254, 3360);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10098, 3254, 3360);
                }
            }

            public override bool IsOptional
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10098, 3440, 3516);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10098, 3484, 3497);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10098, 3440, 3516);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10098, 3376, 3531);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10098, 3376, 3531);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public override int GetHashCode()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10098, 3547, 3658);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10098, 3613, 3643);

                    return f_10098_3620_3642(modifier);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10098, 3547, 3658);

                    int
                    f_10098_3620_3642(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetHashCode();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10098, 3620, 3642);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10098, 3547, 3658);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10098, 3547, 3658);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override bool Equals(object obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10098, 3674, 4026);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10098, 3746, 3849) || true) && (f_10098_3750_3776(this, obj))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10098, 3746, 3849);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10098, 3818, 3830);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10098, 3746, 3849);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10098, 3869, 3930);

                    RequiredCustomModifier
                    other = obj as RequiredCustomModifier
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10098, 3950, 4011);

                    return other != null && (DynAbs.Tracing.TraceSender.Expression_True(10098, 3957, 4010) && f_10098_3974_4010(other.modifier, this.modifier));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10098, 3674, 4026);

                    bool
                    f_10098_3750_3776(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpCustomModifier.RequiredCustomModifier
                    objA, object
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10098, 3750, 3776);
                        return return_v;
                    }


                    bool
                    f_10098_3974_4010(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    obj)
                    {
                        var return_v = this_param.Equals((object)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10098, 3974, 4010);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10098, 3674, 4026);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10098, 3674, 4026);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static RequiredCustomModifier()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10098, 3170, 4037);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10098, 3170, 4037);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10098, 3170, 4037);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10098, 3170, 4037);

            static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10098_3334_3342_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10098, 3254, 3360);
                return return_v;
            }

        }

        int
        f_10098_666_704(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10098, 666, 704);
            return 0;
        }

    }
}
