// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class SourceMethodSymbol : MethodSymbol
    {
        public abstract ImmutableArray<ImmutableArray<TypeWithAnnotations>> GetTypeParameterConstraintTypes();

        public abstract ImmutableArray<TypeParameterConstraintKind> GetTypeParameterConstraintKinds();

        protected static void ReportBadRefToken(TypeSyntax returnTypeSyntax, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10260, 1437, 1812);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10260, 1557, 1801) || true) && (f_10260_1561_1588_M(!returnTypeSyntax.HasErrors))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10260, 1557, 1801);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10260, 1622, 1672);

                    var
                    refKeyword = f_10260_1639_1671(returnTypeSyntax)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10260, 1690, 1786);

                    f_10260_1690_1785(diagnostics, ErrorCode.ERR_UnexpectedToken, refKeyword.GetLocation(), refKeyword.ToString());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10260, 1557, 1801);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10260, 1437, 1812);

                bool
                f_10260_1561_1588_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10260, 1561, 1588);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxToken
                f_10260_1639_1671(Microsoft.CodeAnalysis.CSharp.Syntax.TypeSyntax
                this_param)
                {
                    var return_v = this_param.GetFirstToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10260, 1639, 1671);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10260_1690_1785(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10260, 1690, 1785);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10260, 1437, 1812);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10260, 1437, 1812);
            }
        }

        protected bool AreContainingSymbolLocalsZeroed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10260, 1895, 2557);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10260, 1931, 2542) || true) && (f_10260_1935_1951() is SourceMethodSymbol method)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10260, 1931, 2542);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10260, 2022, 2052);

                        return f_10260_2029_2051(method);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10260, 1931, 2542);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10260, 1931, 2542);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10260, 2094, 2542) || true) && (f_10260_2098_2112() is SourceMemberContainerTypeSymbol type)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10260, 2094, 2542);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10260, 2194, 2222);

                            return f_10260_2201_2221(type);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10260, 2094, 2542);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10260, 2094, 2542);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10260, 2511, 2523);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10260, 2094, 2542);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10260, 1931, 2542);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10260, 1895, 2557);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10260_1935_1951()
                    {
                        var return_v = ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10260, 1935, 1951);
                        return return_v;
                    }


                    bool
                    f_10260_2029_2051(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.AreLocalsZeroed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10260, 2029, 2051);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10260_2098_2112()
                    {
                        var return_v = ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10260, 2098, 2112);
                        return return_v;
                    }


                    bool
                    f_10260_2201_2221(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.AreLocalsZeroed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10260, 2201, 2221);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10260, 1824, 2568);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10260, 1824, 2568);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal void ReportAsyncParameterErrors(DiagnosticBag diagnostics, Location location)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10260, 2580, 3545);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10260, 2691, 3375);
                    foreach (var parameter in f_10260_2717_2727_I(f_10260_2717_2727()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10260, 2691, 3375);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10260, 2761, 3360) || true) && (f_10260_2765_2782(parameter) != RefKind.None)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10260, 2761, 3360);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10260, 2840, 2921);

                            f_10260_2840_2920(diagnostics, ErrorCode.ERR_BadAsyncArgType, f_10260_2887_2919(parameter, location));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10260, 2761, 3360);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10260, 2761, 3360);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10260, 2963, 3360) || true) && (f_10260_2967_2992(f_10260_2967_2981(parameter)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10260, 2963, 3360);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10260, 3034, 3118);

                                f_10260_3034_3117(diagnostics, ErrorCode.ERR_UnsafeAsyncArgType, f_10260_3084_3116(parameter, location));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10260, 2963, 3360);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10260, 2963, 3360);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10260, 3160, 3360) || true) && (f_10260_3164_3197(f_10260_3164_3178(parameter)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10260, 3160, 3360);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10260, 3239, 3341);

                                    f_10260_3239_3340(diagnostics, ErrorCode.ERR_BadSpecialByRefLocal, f_10260_3291_3323(parameter, location), f_10260_3325_3339(parameter));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10260, 3160, 3360);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10260, 2963, 3360);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10260, 2761, 3360);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10260, 2691, 3375);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10260, 1, 685);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10260, 1, 685);
                }
                static Location getLocation(ParameterSymbol parameter, Location location)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10260, 3482, 3533);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10260, 3485, 3533);
                        return parameter.Locations.FirstOrDefault() ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.Location?>(10260, 3485, 3533) ?? location); DynAbs.Tracing.TraceSender.TraceExitMethod(10260, 3482, 3533);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10260, 3482, 3533);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10260, 3482, 3533);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10260, 2580, 3545);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10260_2717_2727()
                {
                    var return_v = Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10260, 2717, 2727);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10260_2765_2782(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10260, 2765, 2782);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10260_2887_2919(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameter, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = getLocation(parameter, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10260, 2887, 2919);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10260_2840_2920(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10260, 2840, 2920);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10260_2967_2981(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10260, 2967, 2981);
                    return return_v;
                }


                bool
                f_10260_2967_2992(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsUnsafe();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10260, 2967, 2992);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10260_3084_3116(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameter, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = getLocation(parameter, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10260, 3084, 3116);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10260_3034_3117(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = diagnostics.Add(code, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10260, 3034, 3117);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10260_3164_3178(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10260, 3164, 3178);
                    return return_v;
                }


                bool
                f_10260_3164_3197(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsRestrictedType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10260, 3164, 3197);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10260_3291_3323(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                parameter, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = getLocation(parameter, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10260, 3291, 3323);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10260_3325_3339(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10260, 3325, 3339);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10260_3239_3340(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10260, 3239, 3340);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10260_2717_2727_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10260, 2717, 2727);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10260, 2580, 3545);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10260, 2580, 3545);
            }
        }

        public SourceMethodSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(10260, 599, 3552);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(10260, 599, 3552);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10260, 599, 3552);
        }


        static SourceMethodSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10260, 599, 3552);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10260, 599, 3552);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10260, 599, 3552);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10260, 599, 3552);
    }
}
