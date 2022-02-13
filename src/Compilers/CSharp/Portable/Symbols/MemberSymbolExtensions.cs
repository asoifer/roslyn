// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal static partial class SymbolExtensions
    {
        internal static bool HasParamsParameter(this Symbol member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 721, 918);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 805, 842);

                var
                @params = f_10057_819_841(member)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 856, 907);

                return f_10057_863_879_M(!@params.IsEmpty) && (DynAbs.Tracing.TraceSender.Expression_True(10057, 863, 906) && f_10057_883_906(@params.Last()));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 721, 918);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10057_819_841(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = member.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 819, 841);
                    return return_v;
                }


                bool
                f_10057_863_879_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 863, 879);
                    return return_v;
                }


                bool
                f_10057_883_906(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsParams;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 883, 906);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 721, 918);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 721, 918);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<ParameterSymbol> GetParameters(this Symbol member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 1070, 1658);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 1176, 1647);

                switch (f_10057_1184_1195(member))
                {

                    case SymbolKind.Method:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 1176, 1647);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 1274, 1315);

                        return f_10057_1281_1314(((MethodSymbol)member));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 1176, 1647);

                    case SymbolKind.Property:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 1176, 1647);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 1380, 1423);

                        return f_10057_1387_1422(((PropertySymbol)member));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 1176, 1647);

                    case SymbolKind.Event:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 1176, 1647);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 1485, 1530);

                        return ImmutableArray<ParameterSymbol>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 1176, 1647);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 1176, 1647);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 1578, 1632);

                        throw f_10057_1584_1631(f_10057_1619_1630(member));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 1176, 1647);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 1070, 1658);

                Microsoft.CodeAnalysis.SymbolKind
                f_10057_1184_1195(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 1184, 1195);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10057_1281_1314(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 1281, 1314);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10057_1387_1422(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 1387, 1422);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10057_1619_1630(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 1619, 1630);
                    return return_v;
                }


                System.Exception
                f_10057_1584_1631(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 1584, 1631);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 1070, 1658);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 1070, 1658);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<TypeWithAnnotations> GetParameterTypes(this Symbol member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 1823, 2461);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 1937, 2450);

                switch (f_10057_1945_1956(member))
                {

                    case SymbolKind.Method:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 1937, 2450);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 2035, 2095);

                        return f_10057_2042_2094(((MethodSymbol)member));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 1937, 2450);

                    case SymbolKind.Property:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 1937, 2450);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 2160, 2222);

                        return f_10057_2167_2221(((PropertySymbol)member));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 1937, 2450);

                    case SymbolKind.Event:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 1937, 2450);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 2284, 2333);

                        return ImmutableArray<TypeWithAnnotations>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 1937, 2450);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 1937, 2450);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 2381, 2435);

                        throw f_10057_2387_2434(f_10057_2422_2433(member));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 1937, 2450);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 1823, 2461);

                Microsoft.CodeAnalysis.SymbolKind
                f_10057_1945_1956(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 1945, 1956);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10057_2042_2094(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 2042, 2094);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10057_2167_2221(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.ParameterTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 2167, 2221);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10057_2422_2433(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 2422, 2433);
                    return return_v;
                }


                System.Exception
                f_10057_2387_2434(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 2387, 2434);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 1823, 2461);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 1823, 2461);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool GetIsVararg(this Symbol member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 2473, 2933);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 2550, 2922);

                switch (f_10057_2558_2569(member))
                {

                    case SymbolKind.Method:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 2550, 2922);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 2648, 2687);

                        return f_10057_2655_2686(((MethodSymbol)member));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 2550, 2922);

                    case SymbolKind.Property:
                    case SymbolKind.Event:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 2550, 2922);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 2792, 2805);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 2550, 2922);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 2550, 2922);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 2853, 2907);

                        throw f_10057_2859_2906(f_10057_2894_2905(member));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 2550, 2922);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 2473, 2933);

                Microsoft.CodeAnalysis.SymbolKind
                f_10057_2558_2569(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 2558, 2569);
                    return return_v;
                }


                bool
                f_10057_2655_2686(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsVararg;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 2655, 2686);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10057_2894_2905(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 2894, 2905);
                    return return_v;
                }


                System.Exception
                f_10057_2859_2906(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 2859, 2906);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 2473, 2933);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 2473, 2933);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<RefKind> GetParameterRefKinds(this Symbol member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 3102, 3698);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 3207, 3687);

                switch (f_10057_3215_3226(member))
                {

                    case SymbolKind.Method:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 3207, 3687);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 3305, 3353);

                        return f_10057_3312_3352(((MethodSymbol)member));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 3207, 3687);

                    case SymbolKind.Property:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 3207, 3687);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 3418, 3468);

                        return f_10057_3425_3467(((PropertySymbol)member));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 3207, 3687);

                    case SymbolKind.Event:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 3207, 3687);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 3530, 3570);

                        return default(ImmutableArray<RefKind>);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 3207, 3687);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 3207, 3687);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 3618, 3672);

                        throw f_10057_3624_3671(f_10057_3659_3670(member));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 3207, 3687);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 3102, 3698);

                Microsoft.CodeAnalysis.SymbolKind
                f_10057_3215_3226(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 3215, 3226);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10057_3312_3352(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterRefKinds;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 3312, 3352);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10057_3425_3467(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.ParameterRefKinds;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 3425, 3467);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10057_3659_3670(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 3659, 3670);
                    return return_v;
                }


                System.Exception
                f_10057_3624_3671(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 3624, 3671);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 3102, 3698);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 3102, 3698);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int GetParameterCount(this Symbol member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 3710, 4286);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 3792, 4275);

                switch (f_10057_3800_3811(member))
                {

                    case SymbolKind.Method:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 3792, 4275);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 3890, 3935);

                        return f_10057_3897_3934(((MethodSymbol)member));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 3792, 4275);

                    case SymbolKind.Property:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 3792, 4275);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 4000, 4047);

                        return f_10057_4007_4046(((PropertySymbol)member));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 3792, 4275);

                    case SymbolKind.Event:
                    case SymbolKind.Field:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 3792, 4275);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 4149, 4158);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 3792, 4275);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 3792, 4275);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 4206, 4260);

                        throw f_10057_4212_4259(f_10057_4247_4258(member));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 3792, 4275);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 3710, 4286);

                Microsoft.CodeAnalysis.SymbolKind
                f_10057_3800_3811(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 3800, 3811);
                    return return_v;
                }


                int
                f_10057_3897_3934(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 3897, 3934);
                    return return_v;
                }


                int
                f_10057_4007_4046(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 4007, 4046);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10057_4247_4258(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 4247, 4258);
                    return return_v;
                }


                System.Exception
                f_10057_4212_4259(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 4212, 4259);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 3710, 4286);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 3710, 4286);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool HasUnsafeParameter(this Symbol member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 4298, 4633);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 4382, 4593);
                    foreach (var parameterType in f_10057_4412_4438_I(f_10057_4412_4438(member)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 4382, 4593);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 4472, 4578) || true) && (f_10057_4476_4505(parameterType.Type))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 4472, 4578);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 4547, 4559);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 4472, 4578);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 4382, 4593);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10057, 1, 212);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10057, 1, 212);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 4609, 4622);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 4298, 4633);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10057_4412_4438(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = member.GetParameterTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 4412, 4438);
                    return return_v;
                }


                bool
                f_10057_4476_4505(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsUnsafe();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 4476, 4505);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10057_4412_4438_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 4412, 4438);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 4298, 4633);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 4298, 4633);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsEventOrPropertyWithImplementableNonPublicAccessor(this Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 4645, 5613);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 4760, 4808);

                f_10057_4760_4807(f_10057_4773_4806(f_10057_4773_4794(symbol)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 4824, 5362);

                switch (f_10057_4832_4843(symbol))
                {

                    case SymbolKind.Property:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 4824, 5362);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 4924, 4968);

                        var
                        propertySymbol = (PropertySymbol)symbol
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 4990, 5108);

                        return f_10057_4997_5050(f_10057_5025_5049(propertySymbol)) || (DynAbs.Tracing.TraceSender.Expression_False(10057, 4997, 5107) || f_10057_5054_5107(f_10057_5082_5106(propertySymbol)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 4824, 5362);

                    case SymbolKind.Event:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 4824, 5362);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 5172, 5210);

                        var
                        eventSymbol = (EventSymbol)symbol
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 5232, 5347);

                        return f_10057_5239_5289(f_10057_5267_5288(eventSymbol)) || (DynAbs.Tracing.TraceSender.Expression_False(10057, 5239, 5346) || f_10057_5293_5346(f_10057_5321_5345(eventSymbol)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 4824, 5362);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 5378, 5391);

                return false;

                bool isImplementableAndNotPublic(MethodSymbol accessor)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10057, 5407, 5602);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 5495, 5587);

                        return f_10057_5502_5528(accessor) && (DynAbs.Tracing.TraceSender.Expression_True(10057, 5502, 5586) && f_10057_5532_5562(accessor) != Accessibility.Public);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10057, 5407, 5602);

                        bool
                        f_10057_5502_5528(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        methodOpt)
                        {
                            var return_v = methodOpt.IsImplementable();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 5502, 5528);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.Accessibility
                        f_10057_5532_5562(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.DeclaredAccessibility;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 5532, 5562);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 5407, 5602);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 5407, 5602);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 4645, 5613);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10057_4773_4794(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 4773, 4794);
                    return return_v;
                }


                bool
                f_10057_4773_4806(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 4773, 4806);
                    return return_v;
                }


                int
                f_10057_4760_4807(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 4760, 4807);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10057_4832_4843(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 4832, 4843);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10057_5025_5049(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.GetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 5025, 5049);
                    return return_v;
                }


                bool
                f_10057_4997_5050(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                accessor)
                {
                    var return_v = isImplementableAndNotPublic(accessor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 4997, 5050);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10057_5082_5106(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.SetMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 5082, 5106);
                    return return_v;
                }


                bool
                f_10057_5054_5107(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                accessor)
                {
                    var return_v = isImplementableAndNotPublic(accessor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 5054, 5107);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10057_5267_5288(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.AddMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 5267, 5288);
                    return return_v;
                }


                bool
                f_10057_5239_5289(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                accessor)
                {
                    var return_v = isImplementableAndNotPublic(accessor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 5239, 5289);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10057_5321_5345(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.RemoveMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 5321, 5345);
                    return return_v;
                }


                bool
                f_10057_5293_5346(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                accessor)
                {
                    var return_v = isImplementableAndNotPublic(accessor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 5293, 5346);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 4645, 5613);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 4645, 5613);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsImplementable(this MethodSymbol methodOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 5625, 5829);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 5713, 5818);

                return (object)methodOpt != null && (DynAbs.Tracing.TraceSender.Expression_True(10057, 5720, 5768) && f_10057_5749_5768_M(!methodOpt.IsSealed)) && (DynAbs.Tracing.TraceSender.Expression_True(10057, 5720, 5817) && (f_10057_5773_5793(methodOpt) || (DynAbs.Tracing.TraceSender.Expression_False(10057, 5773, 5816) || f_10057_5797_5816(methodOpt))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 5625, 5829);

                bool
                f_10057_5749_5768_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 5749, 5768);
                    return return_v;
                }


                bool
                f_10057_5773_5793(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsAbstract;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 5773, 5793);
                    return return_v;
                }


                bool
                f_10057_5797_5816(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsVirtual;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 5797, 5816);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 5625, 5829);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 5625, 5829);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsAccessor(this MethodSymbol methodSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 5841, 5991);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 5927, 5980);

                return (object)f_10057_5942_5971(methodSymbol) != null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 5841, 5991);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10057_5942_5971(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 5942, 5971);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 5841, 5991);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 5841, 5991);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsAccessor(this Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 6003, 6164);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 6077, 6153);

                return f_10057_6084_6095(symbol) == SymbolKind.Method && (DynAbs.Tracing.TraceSender.Expression_True(10057, 6084, 6152) && f_10057_6120_6152(symbol));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 6003, 6164);

                Microsoft.CodeAnalysis.SymbolKind
                f_10057_6084_6095(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 6084, 6095);
                    return return_v;
                }


                bool
                f_10057_6120_6152(Microsoft.CodeAnalysis.CSharp.Symbol
                methodSymbol)
                {
                    var return_v = ((MethodSymbol)methodSymbol).IsAccessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 6120, 6152);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 6003, 6164);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 6003, 6164);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsIndexedPropertyAccessor(this MethodSymbol methodSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 6176, 6434);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 6277, 6329);

                var
                propertyOrEvent = f_10057_6299_6328(methodSymbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 6343, 6423);

                return ((object)propertyOrEvent != null) && (DynAbs.Tracing.TraceSender.Expression_True(10057, 6350, 6422) && f_10057_6387_6422(propertyOrEvent));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 6176, 6434);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10057_6299_6328(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 6299, 6328);
                    return return_v;
                }


                bool
                f_10057_6387_6422(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.IsIndexedProperty();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 6387, 6422);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 6176, 6434);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 6176, 6434);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsOperator(this MethodSymbol methodSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 6446, 6660);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 6532, 6649);

                return f_10057_6539_6562(methodSymbol) == MethodKind.UserDefinedOperator || (DynAbs.Tracing.TraceSender.Expression_False(10057, 6539, 6648) || f_10057_6600_6623(methodSymbol) == MethodKind.Conversion);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 6446, 6660);

                Microsoft.CodeAnalysis.MethodKind
                f_10057_6539_6562(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 6539, 6562);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10057_6600_6623(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 6600, 6623);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 6446, 6660);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 6446, 6660);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsOperator(this Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 6672, 6833);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 6746, 6822);

                return f_10057_6753_6764(symbol) == SymbolKind.Method && (DynAbs.Tracing.TraceSender.Expression_True(10057, 6753, 6821) && f_10057_6789_6821(symbol));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 6672, 6833);

                Microsoft.CodeAnalysis.SymbolKind
                f_10057_6753_6764(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 6753, 6764);
                    return return_v;
                }


                bool
                f_10057_6789_6821(Microsoft.CodeAnalysis.CSharp.Symbol
                methodSymbol)
                {
                    var return_v = ((MethodSymbol)methodSymbol).IsOperator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 6789, 6821);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 6672, 6833);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 6672, 6833);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsIndexer(this Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 6845, 7009);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 6918, 6998);

                return f_10057_6925_6936(symbol) == SymbolKind.Property && (DynAbs.Tracing.TraceSender.Expression_True(10057, 6925, 6997) && f_10057_6963_6997(((PropertySymbol)symbol)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 6845, 7009);

                Microsoft.CodeAnalysis.SymbolKind
                f_10057_6925_6936(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 6925, 6936);
                    return return_v;
                }


                bool
                f_10057_6963_6997(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.IsIndexer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 6963, 6997);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 6845, 7009);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 6845, 7009);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsIndexedProperty(this Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 7021, 7201);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 7102, 7190);

                return f_10057_7109_7120(symbol) == SymbolKind.Property && (DynAbs.Tracing.TraceSender.Expression_True(10057, 7109, 7189) && f_10057_7147_7189(((PropertySymbol)symbol)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 7021, 7201);

                Microsoft.CodeAnalysis.SymbolKind
                f_10057_7109_7120(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 7109, 7120);
                    return return_v;
                }


                bool
                f_10057_7147_7189(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.IsIndexedProperty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 7147, 7189);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 7021, 7201);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 7021, 7201);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static bool IsUserDefinedConversion(this Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 7213, 7413);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 7300, 7402);

                return f_10057_7307_7318(symbol) == SymbolKind.Method && (DynAbs.Tracing.TraceSender.Expression_True(10057, 7307, 7401) && f_10057_7343_7376(((MethodSymbol)symbol)) == MethodKind.Conversion);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 7213, 7413);

                Microsoft.CodeAnalysis.SymbolKind
                f_10057_7307_7318(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 7307, 7318);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10057_7343_7376(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 7343, 7376);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 7213, 7413);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 7213, 7413);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static int CustomModifierCount(this MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 7597, 8292);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 7685, 7699);

                int
                count = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 7715, 7771);

                var
                methodReturnType = f_10057_7738_7770(method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 7785, 7869);

                count += methodReturnType.CustomModifiers.Length + method.RefCustomModifiers.Length;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 7883, 7936);

                count += f_10057_7892_7935(methodReturnType.Type);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 7952, 8252);
                    foreach (ParameterSymbol param in f_10057_7986_8003_I(f_10057_7986_8003(method)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 7952, 8252);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 8037, 8079);

                        var
                        paramType = f_10057_8053_8078(param)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 8097, 8173);

                        count += paramType.CustomModifiers.Length + param.RefCustomModifiers.Length;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 8191, 8237);

                        count += f_10057_8200_8236(paramType.Type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 7952, 8252);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10057, 1, 301);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10057, 1, 301);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 8268, 8281);

                return count;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 7597, 8292);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10057_7738_7770(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 7738, 7770);
                    return return_v;
                }


                int
                f_10057_7892_7935(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.CustomModifierCount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 7892, 7935);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10057_7986_8003(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 7986, 8003);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10057_8053_8078(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 8053, 8078);
                    return return_v;
                }


                int
                f_10057_8200_8236(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.CustomModifierCount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 8200, 8236);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10057_7986_8003_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 7986, 8003);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 7597, 8292);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 7597, 8292);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static int CustomModifierCount(this Symbol m)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 8304, 9213);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 8381, 9202);

                switch (f_10057_8389_8395(m))
                {

                    case SymbolKind.ArrayType:
                    case SymbolKind.ErrorType:
                    case SymbolKind.NamedType:
                    case SymbolKind.PointerType:
                    case SymbolKind.TypeParameter:
                    case SymbolKind.FunctionPointerType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 8381, 9202);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 8713, 8758);

                        return f_10057_8720_8757(((TypeSymbol)m));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 8381, 9202);

                    case SymbolKind.Event:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 8381, 9202);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 8820, 8866);

                        return f_10057_8827_8865(((EventSymbol)m));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 8381, 9202);

                    case SymbolKind.Method:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 8381, 9202);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 8929, 8976);

                        return f_10057_8936_8975(((MethodSymbol)m));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 8381, 9202);

                    case SymbolKind.Property:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 8381, 9202);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 9041, 9090);

                        return f_10057_9048_9089(((PropertySymbol)m));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 8381, 9202);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 8381, 9202);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 9138, 9187);

                        throw f_10057_9144_9186(f_10057_9179_9185(m));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 8381, 9202);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 8304, 9213);

                Microsoft.CodeAnalysis.SymbolKind
                f_10057_8389_8395(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 8389, 8395);
                    return return_v;
                }


                int
                f_10057_8720_8757(Microsoft.CodeAnalysis.CSharp.Symbol
                type)
                {
                    var return_v = type.CustomModifierCount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 8720, 8757);
                    return return_v;
                }


                int
                f_10057_8827_8865(Microsoft.CodeAnalysis.CSharp.Symbol
                e)
                {
                    var return_v = e.CustomModifierCount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 8827, 8865);
                    return return_v;
                }


                int
                f_10057_8936_8975(Microsoft.CodeAnalysis.CSharp.Symbol
                method)
                {
                    var return_v = method.CustomModifierCount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 8936, 8975);
                    return return_v;
                }


                int
                f_10057_9048_9089(Microsoft.CodeAnalysis.CSharp.Symbol
                property)
                {
                    var return_v = property.CustomModifierCount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 9048, 9089);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10057_9179_9185(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 9179, 9185);
                    return return_v;
                }


                System.Exception
                f_10057_9144_9186(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 9144, 9186);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 8304, 9213);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 8304, 9213);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static int CustomModifierCount(this EventSymbol e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 9225, 9354);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 9307, 9343);

                return f_10057_9314_9342(f_10057_9314_9320(e));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 9225, 9354);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10057_9314_9320(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 9314, 9320);
                    return return_v;
                }


                int
                f_10057_9314_9342(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.CustomModifierCount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 9314, 9342);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 9225, 9354);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 9225, 9354);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static int CustomModifierCount(this PropertySymbol property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 9548, 10211);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 9640, 9654);

                int
                count = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 9670, 9710);

                var
                type = f_10057_9681_9709(property)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 9724, 9798);

                count += type.CustomModifiers.Length + property.RefCustomModifiers.Length;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 9812, 9853);

                count += f_10057_9821_9852(type.Type);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 9869, 10171);
                    foreach (ParameterSymbol param in f_10057_9903_9922_I(f_10057_9903_9922(property)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 9869, 10171);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 9956, 9998);

                        var
                        paramType = f_10057_9972_9997(param)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 10016, 10092);

                        count += paramType.CustomModifiers.Length + param.RefCustomModifiers.Length;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 10110, 10156);

                        count += f_10057_10119_10155(paramType.Type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 9869, 10171);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10057, 1, 303);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10057, 1, 303);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 10187, 10200);

                return count;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 9548, 10211);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10057_9681_9709(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 9681, 9709);
                    return return_v;
                }


                int
                f_10057_9821_9852(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.CustomModifierCount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 9821, 9852);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10057_9903_9922(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 9903, 9922);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10057_9972_9997(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.TypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 9972, 9997);
                    return return_v;
                }


                int
                f_10057_10119_10155(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.CustomModifierCount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 10119, 10155);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10057_9903_9922_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 9903, 9922);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 9548, 10211);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 9548, 10211);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Symbol SymbolAsMember(this Symbol s, NamedTypeSymbol newOwner)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 10223, 11020);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 10326, 11009);

                switch (f_10057_10334_10340(s))
                {

                    case SymbolKind.Field:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 10326, 11009);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 10418, 10461);

                        return f_10057_10425_10460(((FieldSymbol)s), newOwner);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 10326, 11009);

                    case SymbolKind.Method:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 10326, 11009);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 10524, 10568);

                        return f_10057_10531_10567(((MethodSymbol)s), newOwner);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 10326, 11009);

                    case SymbolKind.NamedType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 10326, 11009);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 10634, 10681);

                        return f_10057_10641_10680(((NamedTypeSymbol)s), newOwner);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 10326, 11009);

                    case SymbolKind.Property:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 10326, 11009);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 10746, 10792);

                        return f_10057_10753_10791(((PropertySymbol)s), newOwner);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 10326, 11009);

                    case SymbolKind.Event:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 10326, 11009);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 10854, 10897);

                        return f_10057_10861_10896(((EventSymbol)s), newOwner);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 10326, 11009);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 10326, 11009);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 10945, 10994);

                        throw f_10057_10951_10993(f_10057_10986_10992(s));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 10326, 11009);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 10223, 11020);

                Microsoft.CodeAnalysis.SymbolKind
                f_10057_10334_10340(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 10334, 10340);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10057_10425_10460(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 10425, 10460);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10057_10531_10567(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 10531, 10567);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10057_10641_10680(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 10641, 10680);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10057_10753_10791(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 10753, 10791);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                f_10057_10861_10896(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                newOwner)
                {
                    var return_v = this_param.AsMember(newOwner);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 10861, 10896);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10057_10986_10992(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 10986, 10992);
                    return return_v;
                }


                System.Exception
                f_10057_10951_10993(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 10951, 10993);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 10223, 11020);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 10223, 11020);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int GetMemberArity(this Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 11122, 11571);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 11201, 11560);

                switch (f_10057_11209_11220(symbol))
                {

                    case SymbolKind.Method:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 11201, 11560);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 11299, 11335);

                        return f_10057_11306_11334(((MethodSymbol)symbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 11201, 11560);

                    case SymbolKind.NamedType:
                    case SymbolKind.ErrorType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 11201, 11560);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 11447, 11486);

                        return f_10057_11454_11485(((NamedTypeSymbol)symbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 11201, 11560);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 11201, 11560);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 11536, 11545);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 11201, 11560);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 11122, 11571);

                Microsoft.CodeAnalysis.SymbolKind
                f_10057_11209_11220(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 11209, 11220);
                    return return_v;
                }


                int
                f_10057_11306_11334(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 11306, 11334);
                    return return_v;
                }


                int
                f_10057_11454_11485(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 11454, 11485);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 11122, 11571);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 11122, 11571);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static NamespaceOrTypeSymbol OfMinimalArity(this IEnumerable<NamespaceOrTypeSymbol> symbols)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 11583, 12136);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 11709, 11753);

                NamespaceOrTypeSymbol
                minAritySymbol = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 11767, 11797);

                int
                minArity = Int32.MaxValue
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 11811, 12087);
                    foreach (var symbol in f_10057_11834_11841_I(symbols))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 11811, 12087);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 11875, 11910);

                        int
                        arity = f_10057_11887_11909(symbol)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 11928, 12072) || true) && (arity < minArity)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 11928, 12072);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 11990, 12007);

                            minArity = arity;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 12029, 12053);

                            minAritySymbol = symbol;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 11928, 12072);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 11811, 12087);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10057, 1, 277);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10057, 1, 277);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 12103, 12125);

                return minAritySymbol;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 11583, 12136);

                int
                f_10057_11887_11909(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                symbol)
                {
                    var return_v = symbol.GetMemberArity();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 11887, 11909);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                f_10057_11834_11841_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 11834, 11841);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 11583, 12136);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 11583, 12136);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<TypeParameterSymbol> GetMemberTypeParameters(this Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 12148, 12891);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 12268, 12880);

                switch (f_10057_12276_12287(symbol))
                {

                    case SymbolKind.Method:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 12268, 12880);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 12366, 12411);

                        return f_10057_12373_12410(((MethodSymbol)symbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 12268, 12880);

                    case SymbolKind.NamedType:
                    case SymbolKind.ErrorType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 12268, 12880);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 12521, 12569);

                        return f_10057_12528_12568(((NamedTypeSymbol)symbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 12268, 12880);

                    case SymbolKind.Field:
                    case SymbolKind.Property:
                    case SymbolKind.Event:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 12268, 12880);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 12714, 12763);

                        return ImmutableArray<TypeParameterSymbol>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 12268, 12880);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 12268, 12880);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 12811, 12865);

                        throw f_10057_12817_12864(f_10057_12852_12863(symbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 12268, 12880);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 12148, 12891);

                Microsoft.CodeAnalysis.SymbolKind
                f_10057_12276_12287(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 12276, 12287);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10057_12373_12410(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 12373, 12410);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10057_12528_12568(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 12528, 12568);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10057_12852_12863(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 12852, 12863);
                    return return_v;
                }


                System.Exception
                f_10057_12817_12864(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 12817, 12864);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 12148, 12891);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 12148, 12891);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<TypeSymbol> GetMemberTypeArgumentsNoUseSiteDiagnostics(this Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 12903, 13767);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 13033, 13756);

                switch (f_10057_13041_13052(symbol))
                {

                    case SymbolKind.Method:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 13033, 13756);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 13131, 13226);

                        return ((MethodSymbol)symbol).TypeArgumentsWithAnnotations.SelectAsArray(TypeMap.AsTypeSymbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 13033, 13756);

                    case SymbolKind.NamedType:
                    case SymbolKind.ErrorType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 13033, 13756);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 13336, 13454);

                        return ((NamedTypeSymbol)symbol).TypeArgumentsWithAnnotationsNoUseSiteDiagnostics.SelectAsArray(TypeMap.AsTypeSymbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 13033, 13756);

                    case SymbolKind.Field:
                    case SymbolKind.Property:
                    case SymbolKind.Event:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 13033, 13756);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 13599, 13639);

                        return ImmutableArray<TypeSymbol>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 13033, 13756);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 13033, 13756);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 13687, 13741);

                        throw f_10057_13693_13740(f_10057_13728_13739(symbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 13033, 13756);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 12903, 13767);

                Microsoft.CodeAnalysis.SymbolKind
                f_10057_13041_13052(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 13041, 13052);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10057_13728_13739(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 13728, 13739);
                    return return_v;
                }


                System.Exception
                f_10057_13693_13740(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 13693, 13740);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 12903, 13767);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 12903, 13767);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsConstructor(this MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 13779, 14124);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 13864, 14113);

                switch (f_10057_13872_13889(method))
                {

                    case MethodKind.Constructor:
                    case MethodKind.StaticConstructor:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 13864, 14113);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 14025, 14037);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 13864, 14113);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 13864, 14113);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 14085, 14098);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 13864, 14113);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 13779, 14124);

                Microsoft.CodeAnalysis.MethodKind
                f_10057_13872_13889(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 13872, 13889);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 13779, 14124);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 13779, 14124);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool HasThisConstructorInitializer(this MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 14282, 15252);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 14383, 15212) || true) && ((object)method != null && (DynAbs.Tracing.TraceSender.Expression_True(10057, 14387, 14456) && f_10057_14413_14430(method) == MethodKind.Constructor))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 14383, 15212);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 14490, 14565);

                    SourceMemberMethodSymbol
                    sourceMethod = method as SourceMemberMethodSymbol
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 14583, 15197) || true) && ((object)sourceMethod != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 14583, 15197);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 14657, 14762);

                        ConstructorDeclarationSyntax
                        constructorSyntax = f_10057_14706_14729(sourceMethod) as ConstructorDeclarationSyntax
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 14784, 15178) || true) && (constructorSyntax != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 14784, 15178);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 14863, 14942);

                            ConstructorInitializerSyntax
                            initializerSyntax = f_10057_14912_14941(constructorSyntax)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 14968, 15155) || true) && (initializerSyntax != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 14968, 15155);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 15055, 15128);

                                return f_10057_15062_15086(initializerSyntax) == SyntaxKind.ThisConstructorInitializer;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 14968, 15155);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 14784, 15178);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 14583, 15197);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 14383, 15212);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 15228, 15241);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 14282, 15252);

                Microsoft.CodeAnalysis.MethodKind
                f_10057_14413_14430(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 14413, 14430);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10057_14706_14729(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberMethodSymbol
                this_param)
                {
                    var return_v = this_param.SyntaxNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 14706, 14729);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax?
                f_10057_14912_14941(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 14912, 14941);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10057_15062_15086(Microsoft.CodeAnalysis.CSharp.Syntax.ConstructorInitializerSyntax
                this_param)
                {
                    var return_v = this_param.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 15062, 15086);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 14282, 15252);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 14282, 15252);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IncludeFieldInitializersInBody(this MethodSymbol methodSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 15264, 15728);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 15372, 15717);

                return f_10057_15379_15407(methodSymbol) && (DynAbs.Tracing.TraceSender.Expression_True(10057, 15379, 15473) && !f_10057_15429_15473(methodSymbol)) && (DynAbs.Tracing.TraceSender.Expression_True(10057, 15379, 15538) && !(methodSymbol is SynthesizedRecordCopyCtor) // A record copy constructor is special, regular initializers are not supposed to be executed by it.
                ) && (DynAbs.Tracing.TraceSender.Expression_True(10057, 15379, 15716) && !f_10057_15661_15716(methodSymbol));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 15264, 15728);

                bool
                f_10057_15379_15407(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = method.IsConstructor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 15379, 15407);
                    return return_v;
                }


                bool
                f_10057_15429_15473(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = method.HasThisConstructorInitializer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 15429, 15473);
                    return return_v;
                }


                bool
                f_10057_15661_15716(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                constructor)
                {
                    var return_v = Binder.IsUserDefinedRecordCopyConstructor(constructor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 15661, 15716);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 15264, 15728);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 15264, 15728);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsParameterlessConstructor(this MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 15893, 16083);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 15991, 16072);

                return f_10057_15998_16015(method) == MethodKind.Constructor && (DynAbs.Tracing.TraceSender.Expression_True(10057, 15998, 16071) && f_10057_16045_16066(method) == 0);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 15893, 16083);

                Microsoft.CodeAnalysis.MethodKind
                f_10057_15998_16015(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 15998, 16015);
                    return return_v;
                }


                int
                f_10057_16045_16066(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 16045, 16066);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 15893, 16083);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 15893, 16083);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsDefaultValueTypeConstructor(this MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 16358, 16621);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 16459, 16610);

                return f_10057_16466_16493(method) && (DynAbs.Tracing.TraceSender.Expression_True(10057, 16466, 16550) && f_10057_16517_16550(f_10057_16517_16538(method))) && (DynAbs.Tracing.TraceSender.Expression_True(10057, 16466, 16609) && f_10057_16574_16609(method));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 16358, 16621);

                bool
                f_10057_16466_16493(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsImplicitlyDeclared;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 16466, 16493);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10057_16517_16538(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 16517, 16538);
                    return return_v;
                }


                bool
                f_10057_16517_16550(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 16517, 16550);
                    return return_v;
                }


                bool
                f_10057_16574_16609(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = method.IsParameterlessConstructor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 16574, 16609);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 16358, 16621);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 16358, 16621);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool ShouldEmit(this MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 16741, 17429);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 16912, 17016) || true) && (f_10057_16916_16954(method))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 16912, 17016);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 16988, 17001);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 16912, 17016);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 17032, 17165) || true) && (method is SynthesizedStaticConstructor cctor && (DynAbs.Tracing.TraceSender.Expression_True(10057, 17036, 17103) && !f_10057_17085_17103(cctor)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 17032, 17165);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 17137, 17150);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 17032, 17165);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 17256, 17390) || true) && (f_10057_17260_17284(method) && (DynAbs.Tracing.TraceSender.Expression_True(10057, 17260, 17328) && f_10057_17288_17320(method) is null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 17256, 17390);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 17362, 17375);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 17256, 17390);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 17406, 17418);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 16741, 17429);

                bool
                f_10057_16916_16954(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = method.IsDefaultValueTypeConstructor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 16916, 16954);
                    return return_v;
                }


                bool
                f_10057_17085_17103(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedStaticConstructor
                this_param)
                {
                    var return_v = this_param.ShouldEmit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 17085, 17103);
                    return return_v;
                }


                bool
                f_10057_17260_17284(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                member)
                {
                    var return_v = member.IsPartialMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 17260, 17284);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10057_17288_17320(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.PartialImplementationPart;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 17288, 17320);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 16741, 17429);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 16741, 17429);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static MethodSymbol GetOwnOrInheritedAddMethod(this EventSymbol @event)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 17857, 18325);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 17962, 18286) || true) && ((object)@event != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 17962, 18286);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 18025, 18067);

                        MethodSymbol
                        addMethod = f_10057_18050_18066(@event)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 18085, 18192) || true) && ((object)addMethod != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 18085, 18192);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 18156, 18173);

                            return addMethod;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 18085, 18192);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 18212, 18271);

                        @event = (DynAbs.Tracing.TraceSender.Conditional_F1(10057, 18221, 18238) || ((f_10057_18221_18238(@event) && DynAbs.Tracing.TraceSender.Conditional_F2(10057, 18241, 18263)) || DynAbs.Tracing.TraceSender.Conditional_F3(10057, 18266, 18270))) ? f_10057_18241_18263(@event) : null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 17962, 18286);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10057, 17962, 18286);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10057, 17962, 18286);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 18302, 18314);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 17857, 18325);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10057_18050_18066(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.AddMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 18050, 18066);
                    return return_v;
                }


                bool
                f_10057_18221_18238(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 18221, 18238);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol?
                f_10057_18241_18263(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.OverriddenEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 18241, 18263);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 17857, 18325);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 17857, 18325);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static MethodSymbol GetOwnOrInheritedRemoveMethod(this EventSymbol @event)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 18756, 19239);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 18864, 19200) || true) && ((object)@event != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 18864, 19200);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 18927, 18975);

                        MethodSymbol
                        removeMethod = f_10057_18955_18974(@event)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 18993, 19106) || true) && ((object)removeMethod != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 18993, 19106);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 19067, 19087);

                            return removeMethod;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 18993, 19106);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 19126, 19185);

                        @event = (DynAbs.Tracing.TraceSender.Conditional_F1(10057, 19135, 19152) || ((f_10057_19135_19152(@event) && DynAbs.Tracing.TraceSender.Conditional_F2(10057, 19155, 19177)) || DynAbs.Tracing.TraceSender.Conditional_F3(10057, 19180, 19184))) ? f_10057_19155_19177(@event) : null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 18864, 19200);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10057, 18864, 19200);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10057, 18864, 19200);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 19216, 19228);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 18756, 19239);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10057_18955_18974(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.RemoveMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 18955, 18974);
                    return return_v;
                }


                bool
                f_10057_19135_19152(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.IsOverride;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 19135, 19152);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol?
                f_10057_19155_19177(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.OverriddenEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 19155, 19177);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 18756, 19239);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 18756, 19239);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsExplicitInterfaceImplementation(this Symbol member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 19251, 19855);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 19350, 19844);

                switch (f_10057_19358_19369(member))
                {

                    case SymbolKind.Method:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 19350, 19844);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 19448, 19512);

                        return f_10057_19455_19511(((MethodSymbol)member));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 19350, 19844);

                    case SymbolKind.Property:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 19350, 19844);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 19577, 19643);

                        return f_10057_19584_19642(((PropertySymbol)member));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 19350, 19844);

                    case SymbolKind.Event:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 19350, 19844);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 19705, 19768);

                        return f_10057_19712_19767(((EventSymbol)member));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 19350, 19844);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 19350, 19844);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 19816, 19829);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 19350, 19844);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 19251, 19855);

                Microsoft.CodeAnalysis.SymbolKind
                f_10057_19358_19369(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 19358, 19369);
                    return return_v;
                }


                bool
                f_10057_19455_19511(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsExplicitInterfaceImplementation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 19455, 19511);
                    return return_v;
                }


                bool
                f_10057_19584_19642(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.IsExplicitInterfaceImplementation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 19584, 19642);
                    return return_v;
                }


                bool
                f_10057_19712_19767(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.IsExplicitInterfaceImplementation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 19712, 19767);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 19251, 19855);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 19251, 19855);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsPartialMethod(this Symbol member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 19867, 20048);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 19948, 19993);

                var
                sms = member as SourceMemberMethodSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 20007, 20037);

                return f_10057_20014_20028_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(sms, 10057, 20014, 20028)?.IsPartial) == true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 19867, 20048);

                bool?
                f_10057_20014_20028_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 20014, 20028);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 19867, 20048);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 19867, 20048);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsPartialImplementation(this Symbol member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 20060, 20265);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 20149, 20196);

                var
                sms = member as SourceOrdinaryMethodSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 20210, 20254);

                return f_10057_20217_20245_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(sms, 10057, 20217, 20245)?.IsPartialImplementation) == true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 20060, 20265);

                bool?
                f_10057_20217_20245_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 20217, 20245);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 20060, 20265);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 20060, 20265);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsPartialDefinition(this Symbol member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 20277, 20474);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 20362, 20409);

                var
                sms = member as SourceOrdinaryMethodSymbol
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 20423, 20463);

                return f_10057_20430_20454_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(sms, 10057, 20430, 20454)?.IsPartialDefinition) == true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 20277, 20474);

                bool?
                f_10057_20430_20454_M(bool?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 20430, 20454);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 20277, 20474);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 20277, 20474);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool ContainsTupleNames(this Symbol member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 20486, 21285);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 20570, 21274);

                switch (f_10057_20578_20589(member))
                {

                    case SymbolKind.Method:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 20570, 21274);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 20668, 20702);

                        var
                        method = (MethodSymbol)member
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 20724, 20829);

                        return f_10057_20731_20769(f_10057_20731_20748(method)) || (DynAbs.Tracing.TraceSender.Expression_False(10057, 20731, 20828) || method.Parameters.Any(p => p.Type.ContainsTupleNames()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 20570, 21274);

                    case SymbolKind.Property:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 20570, 21274);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 20894, 20952);

                        return f_10057_20901_20951(f_10057_20901_20930(((PropertySymbol)member)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 20570, 21274);

                    case SymbolKind.Event:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 20570, 21274);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 21014, 21069);

                        return f_10057_21021_21068(f_10057_21021_21047(((EventSymbol)member)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 20570, 21274);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 20570, 21274);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 21205, 21259);

                        throw f_10057_21211_21258(f_10057_21246_21257(member));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 20570, 21274);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 20486, 21285);

                Microsoft.CodeAnalysis.SymbolKind
                f_10057_20578_20589(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 20578, 20589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10057_20731_20748(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 20731, 20748);
                    return return_v;
                }


                bool
                f_10057_20731_20769(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsTupleNames();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 20731, 20769);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10057_20901_20930(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 20901, 20930);
                    return return_v;
                }


                bool
                f_10057_20901_20951(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsTupleNames();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 20901, 20951);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10057_21021_21047(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 21021, 21047);
                    return return_v;
                }


                bool
                f_10057_21021_21068(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsTupleNames();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 21021, 21068);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10057_21246_21257(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 21246, 21257);
                    return return_v;
                }


                System.Exception
                f_10057_21211_21258(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 21211, 21258);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 20486, 21285);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 20486, 21285);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static ImmutableArray<Symbol> GetExplicitInterfaceImplementations(this Symbol member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 21297, 22029);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 21416, 22018);

                switch (f_10057_21424_21435(member))
                {

                    case SymbolKind.Method:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 21416, 22018);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 21514, 21606);

                        return ((MethodSymbol)member).ExplicitInterfaceImplementations.Cast<MethodSymbol, Symbol>();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 21416, 22018);

                    case SymbolKind.Property:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 21416, 22018);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 21671, 21767);

                        return ((PropertySymbol)member).ExplicitInterfaceImplementations.Cast<PropertySymbol, Symbol>();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 21416, 22018);

                    case SymbolKind.Event:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 21416, 22018);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 21829, 21919);

                        return ((EventSymbol)member).ExplicitInterfaceImplementations.Cast<EventSymbol, Symbol>();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 21416, 22018);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 21416, 22018);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 21967, 22003);

                        return ImmutableArray<Symbol>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 21416, 22018);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 21297, 22029);

                Microsoft.CodeAnalysis.SymbolKind
                f_10057_21424_21435(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 21424, 21435);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 21297, 22029);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 21297, 22029);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Symbol GetOverriddenMember(this Symbol member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 22041, 22624);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 22128, 22613);

                switch (f_10057_22136_22147(member))
                {

                    case SymbolKind.Method:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 22128, 22613);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 22226, 22273);

                        return f_10057_22233_22272(((MethodSymbol)member));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 22128, 22613);

                    case SymbolKind.Property:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 22128, 22613);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 22338, 22389);

                        return f_10057_22345_22388(((PropertySymbol)member));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 22128, 22613);

                    case SymbolKind.Event:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 22128, 22613);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 22451, 22496);

                        return f_10057_22458_22495(((EventSymbol)member));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 22128, 22613);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 22128, 22613);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 22544, 22598);

                        throw f_10057_22550_22597(f_10057_22585_22596(member));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 22128, 22613);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 22041, 22624);

                Microsoft.CodeAnalysis.SymbolKind
                f_10057_22136_22147(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 22136, 22147);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10057_22233_22272(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OverriddenMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 22233, 22272);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10057_22345_22388(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param)
                {
                    var return_v = this_param.OverriddenProperty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 22345, 22388);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol?
                f_10057_22458_22495(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.OverriddenEvent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 22458, 22495);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10057_22585_22596(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 22585, 22596);
                    return return_v;
                }


                System.Exception
                f_10057_22550_22597(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 22550, 22597);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 22041, 22624);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 22041, 22624);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Symbol GetLeastOverriddenMember(this Symbol member, NamedTypeSymbol accessingTypeOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 22636, 23463);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 22762, 23452);

                switch (f_10057_22770_22781(member))
                {

                    case SymbolKind.Method:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 22762, 23452);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 22860, 22894);

                        var
                        method = (MethodSymbol)member
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 22916, 23014);

                        return f_10057_22923_23013(method, accessingTypeOpt, requireSameReturnType: false);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 22762, 23452);

                    case SymbolKind.Property:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 22762, 23452);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 23081, 23119);

                        var
                        property = (PropertySymbol)member
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 23141, 23202);

                        return f_10057_23148_23201(property, accessingTypeOpt);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 22762, 23452);

                    case SymbolKind.Event:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 22762, 23452);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 23266, 23297);

                        var
                        evnt = (EventSymbol)member
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 23319, 23373);

                        return f_10057_23326_23372(evnt, accessingTypeOpt);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 22762, 23452);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 22762, 23452);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 23423, 23437);

                        return member;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 22762, 23452);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 22636, 23463);

                Microsoft.CodeAnalysis.SymbolKind
                f_10057_22770_22781(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 22770, 22781);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10057_22923_23013(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                accessingTypeOpt, bool
                requireSameReturnType)
                {
                    var return_v = this_param.GetConstructedLeastOverriddenMethod(accessingTypeOpt, requireSameReturnType: requireSameReturnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 22923, 23013);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                f_10057_23148_23201(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                accessingTypeOpt)
                {
                    var return_v = this_param.GetLeastOverriddenProperty(accessingTypeOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 23148, 23201);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                f_10057_23326_23372(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                accessingTypeOpt)
                {
                    var return_v = this_param.GetLeastOverriddenEvent(accessingTypeOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 23326, 23372);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 22636, 23463);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 22636, 23463);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsFieldOrFieldLikeEvent(this Symbol member, out FieldSymbol field)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 23475, 24027);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 23587, 24016);

                switch (f_10057_23595_23606(member))
                {

                    case SymbolKind.Field:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 23587, 24016);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 23684, 23712);

                        field = (FieldSymbol)member;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 23734, 23746);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 23587, 24016);

                    case SymbolKind.Event:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 23587, 24016);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 23808, 23854);

                        field = f_10057_23816_23853(((EventSymbol)member));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 23876, 23905);

                        return (object)field != null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 23587, 24016);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 23587, 24016);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 23953, 23966);

                        field = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 23988, 24001);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 23587, 24016);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 23475, 24027);

                Microsoft.CodeAnalysis.SymbolKind
                f_10057_23595_23606(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 23595, 23606);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                f_10057_23816_23853(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 23816, 23853);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 23475, 24027);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 23475, 24027);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetMemberCallerName(this Symbol member)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10057, 24039, 24512);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 24126, 24270) || true) && (f_10057_24130_24141(member) == SymbolKind.Method)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10057, 24126, 24270);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 24196, 24255);

                    member = f_10057_24205_24244(((MethodSymbol)member)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbol>(10057, 24205, 24254) ?? member);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10057, 24126, 24270);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10057, 24286, 24501);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10057, 24293, 24311) || ((f_10057_24293_24311(member) && DynAbs.Tracing.TraceSender.Conditional_F2(10057, 24314, 24333)) || DynAbs.Tracing.TraceSender.Conditional_F3(10057, 24353, 24500))) ? f_10057_24314_24333(member) : (DynAbs.Tracing.TraceSender.Conditional_F1(10057, 24353, 24395) || ((f_10057_24353_24395(member) && DynAbs.Tracing.TraceSender.Conditional_F2(10057, 24398, 24469)) || DynAbs.Tracing.TraceSender.Conditional_F3(10057, 24489, 24500))) ? f_10057_24398_24469(f_10057_24457_24468(member)) : f_10057_24489_24500(member);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10057, 24039, 24512);

                Microsoft.CodeAnalysis.SymbolKind
                f_10057_24130_24141(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 24130, 24141);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10057_24205_24244(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 24205, 24244);
                    return return_v;
                }


                bool
                f_10057_24293_24311(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.IsIndexer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 24293, 24311);
                    return return_v;
                }


                string
                f_10057_24314_24333(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.MetadataName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 24314, 24333);
                    return return_v;
                }


                bool
                f_10057_24353_24395(Microsoft.CodeAnalysis.CSharp.Symbol
                member)
                {
                    var return_v = member.IsExplicitInterfaceImplementation();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 24353, 24395);
                    return return_v;
                }


                string
                f_10057_24457_24468(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 24457, 24468);
                    return return_v;
                }


                string
                f_10057_24398_24469(string
                fullName)
                {
                    var return_v = ExplicitInterfaceHelpers.GetMemberNameWithoutInterfaceName(fullName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10057, 24398, 24469);
                    return return_v;
                }


                string
                f_10057_24489_24500(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10057, 24489, 24500);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10057, 24039, 24512);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 24039, 24512);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SymbolExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10057, 658, 24519);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10049, 9763, 9891);
            s_hasInvalidTypeParameterFunc = (type, containingSymbol, unused) => HasInvalidTypeParameter(type, containingSymbol); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10057, 658, 24519);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10057, 658, 24519);
        }

    }
}
