// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp
{

    internal struct MethodGroupResolution
    {

        public readonly MethodGroup MethodGroup;

        public readonly Symbol OtherSymbol;

        public readonly OverloadResolutionResult<MethodSymbol> OverloadResolutionResult;

        public readonly AnalyzedArguments AnalyzedArguments;

        public readonly ImmutableArray<Diagnostic> Diagnostics;

        public readonly LookupResultKind ResultKind;

        public MethodGroupResolution(MethodGroup methodGroup, ImmutableArray<Diagnostic> diagnostics)
        : this(f_10359_1125_1136_C(methodGroup), otherSymbol: null, overloadResolutionResult: null, analyzedArguments: null, f_10359_1214_1236(methodGroup), diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10359, 1011, 1272);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10359, 1011, 1272);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10359, 1011, 1272);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10359, 1011, 1272);
            }
        }

        public MethodGroupResolution(Symbol otherSymbol, LookupResultKind resultKind, ImmutableArray<Diagnostic> diagnostics)
        : this(methodGroup: f_10359_1422_1439_C(null), otherSymbol, overloadResolutionResult: null, analyzedArguments: null, resultKind, diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10359, 1284, 1557);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10359, 1284, 1557);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10359, 1284, 1557);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10359, 1284, 1557);
            }
        }

        public MethodGroupResolution(
                    MethodGroup methodGroup,
                    Symbol otherSymbol,
                    OverloadResolutionResult<MethodSymbol> overloadResolutionResult,
                    AnalyzedArguments analyzedArguments,
                    LookupResultKind resultKind,
                    ImmutableArray<Diagnostic> diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10359, 1569, 2733);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10359, 1917, 1988);

                f_10359_1917_1987((methodGroup == null) || (DynAbs.Tracing.TraceSender.Expression_False(10359, 1930, 1986) || (f_10359_1956_1981(f_10359_1956_1975(methodGroup)) > 0)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10359, 2002, 2071);

                f_10359_2002_2070((methodGroup == null) || (DynAbs.Tracing.TraceSender.Expression_False(10359, 2015, 2069) || ((object)otherSymbol == null)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10359, 2152, 2239);

                f_10359_2152_2238(((object)otherSymbol == null) || (DynAbs.Tracing.TraceSender.Expression_False(10359, 2165, 2237) || (f_10359_2199_2215(otherSymbol) != SymbolKind.Method)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10359, 2253, 2308);

                f_10359_2253_2307(resultKind != LookupResultKind.Ambiguous);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10359, 2377, 2414);

                f_10359_2377_2413(f_10359_2390_2412_M(!diagnostics.IsDefault));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10359, 2430, 2461);

                this.MethodGroup = methodGroup;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10359, 2475, 2506);

                this.OtherSymbol = otherSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10359, 2520, 2577);

                this.OverloadResolutionResult = overloadResolutionResult;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10359, 2591, 2634);

                this.AnalyzedArguments = analyzedArguments;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10359, 2648, 2677);

                this.ResultKind = resultKind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10359, 2691, 2722);

                this.Diagnostics = diagnostics;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10359, 1569, 2733);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10359, 1569, 2733);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10359, 1569, 2733);
            }
        }

        public bool IsEmpty
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10359, 2789, 2869);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10359, 2795, 2867);

                    return (this.MethodGroup == null) && (DynAbs.Tracing.TraceSender.Expression_True(10359, 2802, 2866) && ((object)this.OtherSymbol == null));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10359, 2789, 2869);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10359, 2745, 2880);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10359, 2745, 2880);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool HasAnyErrors
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10359, 2941, 2988);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10359, 2947, 2986);

                    return this.Diagnostics.HasAnyErrors();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10359, 2941, 2988);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10359, 2892, 2999);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10359, 2892, 2999);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool HasAnyApplicableMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10359, 3070, 3346);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10359, 3106, 3331);

                    return (this.MethodGroup != null) && (DynAbs.Tracing.TraceSender.Expression_True(10359, 3113, 3208) && (this.ResultKind == LookupResultKind.Viable)) && (DynAbs.Tracing.TraceSender.Expression_True(10359, 3113, 3330) && ((this.OverloadResolutionResult == null) || (DynAbs.Tracing.TraceSender.Expression_False(10359, 3234, 3329) || f_10359_3277_3329(this.OverloadResolutionResult))));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10359, 3070, 3346);

                    bool
                    f_10359_3277_3329(Microsoft.CodeAnalysis.CSharp.OverloadResolutionResult<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    this_param)
                    {
                        var return_v = this_param.HasAnyApplicableMember;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10359, 3277, 3329);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10359, 3011, 3357);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10359, 3011, 3357);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsExtensionMethodGroup
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10359, 3428, 3513);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10359, 3434, 3511);

                    return (this.MethodGroup != null) && (DynAbs.Tracing.TraceSender.Expression_True(10359, 3441, 3510) && f_10359_3471_3510(this.MethodGroup));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10359, 3428, 3513);

                    bool
                    f_10359_3471_3510(Microsoft.CodeAnalysis.CSharp.MethodGroup
                    this_param)
                    {
                        var return_v = this_param.IsExtensionMethodGroup;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10359, 3471, 3510);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10359, 3369, 3524);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10359, 3369, 3524);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsLocalFunctionInvocation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10359, 3574, 3797);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10359, 3613, 3797);
                    return MethodGroup != null && (DynAbs.Tracing.TraceSender.Expression_True(10359, 3613, 3679) && f_10359_3649_3674(f_10359_3649_3668(MethodGroup)) == 1) && (DynAbs.Tracing.TraceSender.Expression_True(10359, 3613, 3797) && f_10359_3736_3769(f_10359_3736_3758(f_10359_3736_3755(MethodGroup), 0)) == MethodKind.LocalFunction); DynAbs.Tracing.TraceSender.TraceExitMethod(10359, 3574, 3797);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10359, 3574, 3797);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10359, 3574, 3797);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public void Free()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10359, 3810, 3986);

                // LAFHIS
                //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(this.AnalyzedArguments, 10359, 3853, 3883).Free(), 10359, 3876, 3883);
                
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10359, 3853, 3884);
                var temp1 = DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(this.AnalyzedArguments, 10359, 3853, 3883);
                if (temp1 != null)
                { 
                    temp1.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10359, 3876, 3883);
                }

                //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(this.MethodGroup, 10359, 3898, 3922).Free(), 10359, 3915, 3922);

                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10359, 3898, 3923);
                var temp2 = DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(this.MethodGroup, 10359, 3898, 3922);
                if (temp2 != null)
                {
                    temp2.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10359, 3915, 3922);
                }

                //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(this.OverloadResolutionResult, 10359, 3937, 3974).Free(), 10359, 3967, 3974);
                
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10359, 3937, 3975);
                var temp3 = DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(this.OverloadResolutionResult, 10359, 3937, 3974);
                if (temp3 != null)
                {
                    temp3.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10359, 3967, 3974);
                }

                DynAbs.Tracing.TraceSender.TraceExitMethod(10359, 3810, 3986);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10359, 3810, 3986);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10359, 3810, 3986);
            }
        }
        static MethodGroupResolution()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10359, 589, 3993);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10359, 589, 3993);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10359, 589, 3993);
        }

        static Microsoft.CodeAnalysis.CSharp.LookupResultKind
        f_10359_1214_1236(Microsoft.CodeAnalysis.CSharp.MethodGroup
        this_param)
        {
            var return_v = this_param.ResultKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10359, 1214, 1236);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.MethodGroup
        f_10359_1125_1136_C(Microsoft.CodeAnalysis.CSharp.MethodGroup
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10359, 1011, 1272);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.MethodGroup?
        f_10359_1422_1439_C(Microsoft.CodeAnalysis.CSharp.MethodGroup?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10359, 1284, 1557);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
        f_10359_1956_1975(Microsoft.CodeAnalysis.CSharp.MethodGroup
        this_param)
        {
            var return_v = this_param.Methods;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10359, 1956, 1975);
            return return_v;
        }


        static int
        f_10359_1956_1981(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10359, 1956, 1981);
            return return_v;
        }


        static int
        f_10359_1917_1987(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10359, 1917, 1987);
            return 0;
        }


        static int
        f_10359_2002_2070(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10359, 2002, 2070);
            return 0;
        }


        static Microsoft.CodeAnalysis.SymbolKind
        f_10359_2199_2215(Microsoft.CodeAnalysis.CSharp.Symbol
        this_param)
        {
            var return_v = this_param.Kind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10359, 2199, 2215);
            return return_v;
        }


        static int
        f_10359_2152_2238(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10359, 2152, 2238);
            return 0;
        }


        static int
        f_10359_2253_2307(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10359, 2253, 2307);
            return 0;
        }


        static bool
        f_10359_2390_2412_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10359, 2390, 2412);
            return return_v;
        }


        static int
        f_10359_2377_2413(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10359, 2377, 2413);
            return 0;
        }


        static Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
        f_10359_3649_3668(Microsoft.CodeAnalysis.CSharp.MethodGroup
        this_param)
        {
            var return_v = this_param.Methods;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10359, 3649, 3668);
            return return_v;
        }


        int
        f_10359_3649_3674(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10359, 3649, 3674);
            return return_v;
        }


        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
        f_10359_3736_3755(Microsoft.CodeAnalysis.CSharp.MethodGroup
        this_param)
        {
            var return_v = this_param.Methods;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10359, 3736, 3755);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        f_10359_3736_3758(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
        this_param, int
        i0)
        {
            var return_v = this_param[i0];
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10359, 3736, 3758);
            return return_v;
        }


        Microsoft.CodeAnalysis.MethodKind
        f_10359_3736_3769(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.MethodKind;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10359, 3736, 3769);
            return return_v;
        }

    }
}
