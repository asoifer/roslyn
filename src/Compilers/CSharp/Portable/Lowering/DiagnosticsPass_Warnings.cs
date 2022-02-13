// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed partial class DiagnosticsPass : BoundTreeWalkerWithStackGuard
    {
        private void CheckArguments(ImmutableArray<RefKind> argumentRefKindsOpt, ImmutableArray<BoundExpression> arguments, Symbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10433, 740, 2171);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 895, 2160) || true) && (f_10433_899_929_M(!argumentRefKindsOpt.IsDefault))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 895, 2160);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 963, 1024);

                    f_10433_963_1023(arguments.Length == argumentRefKindsOpt.Length);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 1051, 1056);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 1042, 2145) || true) && (i < arguments.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 1080, 1083)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 1042, 2145))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 1042, 2145);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 1125, 2126) || true) && (argumentRefKindsOpt[i] != RefKind.None)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 1125, 2126);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 1217, 1245);

                                var
                                argument = arguments[i]
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 1271, 2103);

                                switch (f_10433_1279_1292(argument))
                                {

                                    case BoundKind.FieldAccess:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 1271, 2103);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 1411, 1465);

                                        f_10433_1411_1464(this, argument, method);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10433, 1499, 1505);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 1271, 2103);

                                    case BoundKind.Local:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 1271, 2103);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 1590, 1623);

                                        var
                                        local = (BoundLocal)argument
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 1657, 1852) || true) && (f_10433_1661_1680(local.Syntax) == SyntaxKind.DeclarationExpression)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 1657, 1852);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 1790, 1817);

                                            f_10433_1790_1816(this, local);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 1657, 1852);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceBreak(10433, 1886, 1892);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 1271, 2103);

                                    case BoundKind.DiscardExpression:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 1271, 2103);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 1989, 2036);

                                        f_10433_1989_2035(this, argument);
                                        DynAbs.Tracing.TraceSender.TraceBreak(10433, 2070, 2076);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 1271, 2103);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 1125, 2126);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10433, 1, 1104);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10433, 1, 1104);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 895, 2160);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10433, 740, 2171);

                bool
                f_10433_899_929_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 899, 929);
                    return return_v;
                }


                int
                f_10433_963_1023(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 963, 1023);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10433_1279_1292(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 1279, 1292);
                    return return_v;
                }


                int
                f_10433_1411_1464(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                fieldAccess, Microsoft.CodeAnalysis.CSharp.Symbol
                consumerOpt)
                {
                    this_param.CheckFieldAddress((Microsoft.CodeAnalysis.CSharp.BoundFieldAccess)fieldAccess, consumerOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 1411, 1464);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10433_1661_1680(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 1661, 1680);
                    return return_v;
                }


                int
                f_10433_1790_1816(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundLocal
                local)
                {
                    this_param.CheckOutDeclaration(local);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 1790, 1816);
                    return 0;
                }


                int
                f_10433_1989_2035(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                argument)
                {
                    this_param.CheckDiscard((Microsoft.CodeAnalysis.CSharp.BoundDiscardExpression)argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 1989, 2035);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10433, 740, 2171);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10433, 740, 2171);
            }
        }

        private void CheckFieldAddress(BoundFieldAccess fieldAccess, Symbol consumerOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10433, 2364, 3016);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 2469, 2519);

                FieldSymbol
                fieldSymbol = f_10433_2495_2518(fieldAccess)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 2619, 2822) || true) && (f_10433_2623_2645(fieldSymbol) && (DynAbs.Tracing.TraceSender.Expression_True(10433, 2623, 2712) && ((object)consumerOpt == null || (DynAbs.Tracing.TraceSender.Expression_False(10433, 2650, 2711) || !f_10433_2682_2711(this, consumerOpt)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 2619, 2822);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 2746, 2807);

                    f_10433_2746_2806(this, ErrorCode.WRN_VolatileByRef, fieldAccess, fieldSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 2619, 2822);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 2838, 3005) || true) && (f_10433_2842_2890(fieldAccess, _compilation))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 2838, 3005);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 2924, 2990);

                    f_10433_2924_2989(this, ErrorCode.WRN_ByRefNonAgileField, fieldAccess, fieldSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 2838, 3005);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10433, 2364, 3016);

                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10433_2495_2518(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 2495, 2518);
                    return return_v;
                }


                bool
                f_10433_2623_2645(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsVolatile;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 2623, 2645);
                    return return_v;
                }


                bool
                f_10433_2682_2711(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                method)
                {
                    var return_v = this_param.IsInterlockedAPI(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 2682, 2711);
                    return return_v;
                }


                int
                f_10433_2746_2806(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 2746, 2806);
                    return 0;
                }


                bool
                f_10433_2842_2890(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                fieldAccess, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = IsNonAgileFieldAccess(fieldAccess, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 2842, 2890);
                    return return_v;
                }


                int
                f_10433_2924_2989(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 2924, 2989);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10433, 2364, 3016);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10433, 2364, 3016);
            }
        }

        private void CheckFieldAsReceiver(BoundFieldAccess fieldAccess)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10433, 3455, 4138);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 3856, 3906);

                FieldSymbol
                fieldSymbol = f_10433_3882_3905(fieldAccess)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 3922, 4127) || true) && (f_10433_3926_3974(fieldAccess, _compilation) && (DynAbs.Tracing.TraceSender.Expression_True(10433, 3926, 4011) && f_10433_3978_4011_M(!f_10433_3979_3995(fieldSymbol).IsReferenceType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 3922, 4127);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 4045, 4112);

                    f_10433_4045_4111(this, ErrorCode.WRN_CallOnNonAgileField, fieldAccess, fieldSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 3922, 4127);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10433, 3455, 4138);

                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10433_3882_3905(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 3882, 3905);
                    return return_v;
                }


                bool
                f_10433_3926_3974(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                fieldAccess, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation)
                {
                    var return_v = IsNonAgileFieldAccess(fieldAccess, compilation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 3926, 3974);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10433_3979_3995(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 3979, 3995);
                    return return_v;
                }


                bool
                f_10433_3978_4011_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 3978, 4011);
                    return return_v;
                }


                int
                f_10433_4045_4111(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 4045, 4111);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10433, 3455, 4138);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10433, 3455, 4138);
            }
        }

        private void CheckReceiverIfField(BoundExpression receiverOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10433, 4150, 4417);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 4237, 4406) || true) && (receiverOpt != null && (DynAbs.Tracing.TraceSender.Expression_True(10433, 4241, 4305) && f_10433_4264_4280(receiverOpt) == BoundKind.FieldAccess))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 4237, 4406);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 4339, 4391);

                    f_10433_4339_4390(this, receiverOpt);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 4237, 4406);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10433, 4150, 4417);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10433_4264_4280(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 4264, 4280);
                    return return_v;
                }


                int
                f_10433_4339_4390(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                fieldAccess)
                {
                    this_param.CheckFieldAsReceiver((Microsoft.CodeAnalysis.CSharp.BoundFieldAccess)fieldAccess);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 4339, 4390);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10433, 4150, 4417);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10433, 4150, 4417);
            }
        }

        internal static bool IsNonAgileFieldAccess(BoundFieldAccess fieldAccess, CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10433, 4530, 5908);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 4844, 5868) || true) && (f_10433_4848_4901(fieldAccess))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 4844, 5868);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 5120, 5225);

                    NamedTypeSymbol
                    marshalByRefType = f_10433_5155_5224(compilation, WellKnownType.System_MarshalByRefObject)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 5245, 5306);

                    TypeSymbol
                    baseType = f_10433_5267_5305(f_10433_5267_5290(fieldAccess))
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 5324, 5853) || true) && ((object)baseType != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 5324, 5853);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 5397, 5567) || true) && (f_10433_5401_5482(baseType, marshalByRefType, TypeCompareKind.ConsiderEverything))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 5397, 5567);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 5532, 5544);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 5397, 5567);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 5785, 5834);

                            baseType = f_10433_5796_5833(baseType);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 5324, 5853);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10433, 5324, 5853);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10433, 5324, 5853);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 4844, 5868);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 5884, 5897);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10433, 4530, 5908);

                bool
                f_10433_4848_4901(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                fieldAccess)
                {
                    var return_v = IsInstanceFieldAccessWithNonThisReceiver(fieldAccess);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 4848, 4901);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10433_5155_5224(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 5155, 5224);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10433_5267_5290(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 5267, 5290);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10433_5267_5305(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 5267, 5305);
                    return return_v;
                }


                bool
                f_10433_5401_5482(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 5401, 5482);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10433_5796_5833(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 5796, 5833);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10433, 4530, 5908);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10433, 4530, 5908);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsInstanceFieldAccessWithNonThisReceiver(BoundFieldAccess fieldAccess)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10433, 5920, 6608);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 6035, 6086);

                BoundExpression
                receiver = f_10433_6062_6085(fieldAccess)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 6100, 6218) || true) && (receiver == null || (DynAbs.Tracing.TraceSender.Expression_False(10433, 6104, 6156) || f_10433_6124_6156(f_10433_6124_6147(fieldAccess))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 6100, 6218);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 6190, 6203);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 6100, 6218);
                }
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 6234, 6489) || true) && (f_10433_6241_6254(receiver) == BoundKind.Conversion)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 6234, 6489);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 6312, 6367);

                        BoundConversion
                        conversion = (BoundConversion)receiver
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 6385, 6426) || true) && (f_10433_6389_6418(conversion))
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 6385, 6426);
                            DynAbs.Tracing.TraceSender.TraceBreak(10433, 6420, 6426);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 6385, 6426);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 6444, 6474);

                        receiver = f_10433_6455_6473(conversion);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 6234, 6489);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10433, 6234, 6489);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10433, 6234, 6489);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 6505, 6597);

                return f_10433_6512_6525(receiver) != BoundKind.ThisReference && (DynAbs.Tracing.TraceSender.Expression_True(10433, 6512, 6596) && f_10433_6556_6569(receiver) != BoundKind.BaseReference);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10433, 5920, 6608);

                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10433_6062_6085(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 6062, 6085);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10433_6124_6147(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 6124, 6147);
                    return return_v;
                }


                bool
                f_10433_6124_6156(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 6124, 6156);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10433_6241_6254(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 6241, 6254);
                    return return_v;
                }


                bool
                f_10433_6389_6418(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ExplicitCastInCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 6389, 6418);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_6455_6473(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 6455, 6473);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10433_6512_6525(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 6512, 6525);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10433_6556_6569(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 6556, 6569);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10433, 5920, 6608);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10433, 5920, 6608);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsInterlockedAPI(Symbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10433, 6620, 6991);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 6689, 6781);

                var
                interlocked = f_10433_6707_6780(_compilation, WellKnownType.System_Threading_Interlocked)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 6795, 6951) || true) && ((object)interlocked != null && (DynAbs.Tracing.TraceSender.Expression_True(10433, 6799, 6920) && f_10433_6830_6920(interlocked, f_10433_6861_6882(method), TypeCompareKind.ConsiderEverything2)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 6795, 6951);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 6939, 6951);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 6795, 6951);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 6967, 6980);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10433, 6620, 6991);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10433_6707_6780(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 6707, 6780);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10433_6861_6882(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 6861, 6882);
                    return return_v;
                }


                bool
                f_10433_6830_6920(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 6830, 6920);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10433, 6620, 6991);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10433, 6620, 6991);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static BoundExpression StripImplicitCasts(BoundExpression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10433, 7003, 7571);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 7099, 7130);

                BoundExpression
                current = expr
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 7144, 7560) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 7144, 7560);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 7271, 7327);

                        BoundConversion
                        conversion = current as BoundConversion
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 7345, 7496) || true) && (conversion == null || (DynAbs.Tracing.TraceSender.Expression_False(10433, 7349, 7420) || !f_10433_7372_7420(f_10433_7372_7397(conversion))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 7345, 7496);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 7462, 7477);

                            return current;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 7345, 7496);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 7516, 7545);

                        current = f_10433_7526_7544(conversion);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 7144, 7560);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10433, 7144, 7560);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10433, 7144, 7560);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10433, 7003, 7571);

                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10433_7372_7397(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 7372, 7397);
                    return return_v;
                }


                bool
                f_10433_7372_7420(Microsoft.CodeAnalysis.CSharp.ConversionKind
                conversionKind)
                {
                    var return_v = conversionKind.IsImplicitConversion();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 7372, 7420);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_7526_7544(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 7526, 7544);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10433, 7003, 7571);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10433, 7003, 7571);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsSameLocalOrField(BoundExpression expr1, BoundExpression expr2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10433, 7583, 10101);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 7692, 7787) || true) && (expr1 == null && (DynAbs.Tracing.TraceSender.Expression_True(10433, 7696, 7726) && expr2 == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 7692, 7787);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 7760, 7772);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 7692, 7787);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 7803, 7899) || true) && (expr1 == null || (DynAbs.Tracing.TraceSender.Expression_False(10433, 7807, 7837) || expr2 == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 7803, 7899);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 7871, 7884);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 7803, 7899);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 7915, 8021) || true) && (f_10433_7919_7937(expr1) || (DynAbs.Tracing.TraceSender.Expression_False(10433, 7919, 7959) || f_10433_7941_7959(expr2)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 7915, 8021);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 7993, 8006);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 7915, 8021);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 8037, 8071);

                expr1 = f_10433_8045_8070(expr1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 8085, 8119);

                expr2 = f_10433_8093_8118(expr2);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 8135, 8225) || true) && (f_10433_8139_8149(expr1) != f_10433_8153_8163(expr2))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 8135, 8225);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 8197, 8210);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 8135, 8225);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 8241, 10090);

                switch (f_10433_8249_8259(expr1))
                {

                    case BoundKind.Local:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 8241, 10090);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 8336, 8367);

                        var
                        local1 = (BoundLocal)expr1
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 8389, 8420);

                        var
                        local2 = (BoundLocal)expr2
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 8442, 8490);

                        return f_10433_8449_8467(local1) == f_10433_8471_8489(local2);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 8241, 10090);

                    case BoundKind.FieldAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 8241, 10090);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 8557, 8594);

                        var
                        field1 = (BoundFieldAccess)expr1
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 8616, 8653);

                        var
                        field2 = (BoundFieldAccess)expr2
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 8675, 8843);

                        return f_10433_8682_8700(field1) == f_10433_8704_8722(field2) && (DynAbs.Tracing.TraceSender.Expression_True(10433, 8682, 8842) && (f_10433_8752_8779(f_10433_8752_8770(field1)) || (DynAbs.Tracing.TraceSender.Expression_False(10433, 8752, 8841) || f_10433_8783_8841(f_10433_8802_8820(field1), f_10433_8822_8840(field2)))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 8241, 10090);

                    case BoundKind.EventAccess:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 8241, 10090);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 8910, 8947);

                        var
                        event1 = (BoundEventAccess)expr1
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 8969, 9006);

                        var
                        event2 = (BoundEventAccess)expr2
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 9028, 9196);

                        return f_10433_9035_9053(event1) == f_10433_9057_9075(event2) && (DynAbs.Tracing.TraceSender.Expression_True(10433, 9035, 9195) && (f_10433_9105_9132(f_10433_9105_9123(event1)) || (DynAbs.Tracing.TraceSender.Expression_False(10433, 9105, 9194) || f_10433_9136_9194(f_10433_9155_9173(event1), f_10433_9175_9193(event2)))));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 8241, 10090);

                    case BoundKind.Parameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 8241, 10090);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 9261, 9296);

                        var
                        param1 = (BoundParameter)expr1
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 9318, 9353);

                        var
                        param2 = (BoundParameter)expr2
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 9375, 9431);

                        return f_10433_9382_9404(param1) == f_10433_9408_9430(param2);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 8241, 10090);

                    case BoundKind.RangeVariable:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 8241, 10090);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 9500, 9542);

                        var
                        rangeVar1 = (BoundRangeVariable)expr1
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 9564, 9606);

                        var
                        rangeVar2 = (BoundRangeVariable)expr2
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 9628, 9698);

                        return f_10433_9635_9664(rangeVar1) == f_10433_9668_9697(rangeVar2);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 8241, 10090);

                    case BoundKind.ThisReference:
                    case BoundKind.PreviousSubmissionReference:
                    case BoundKind.HostObjectMemberReference:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 8241, 10090);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 9887, 9980);

                        f_10433_9887_9979(f_10433_9900_9978(f_10433_9918_9928(expr1), f_10433_9930_9940(expr2), TypeCompareKind.ConsiderEverything2));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 10002, 10014);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 8241, 10090);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 8241, 10090);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 10062, 10075);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 8241, 10090);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10433, 7583, 10101);

                bool
                f_10433_7919_7937(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.HasAnyErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 7919, 7937);
                    return return_v;
                }


                bool
                f_10433_7941_7959(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.HasAnyErrors;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 7941, 7959);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_8045_8070(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = StripImplicitCasts(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 8045, 8070);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_8093_8118(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = StripImplicitCasts(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 8093, 8118);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10433_8139_8149(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 8139, 8149);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10433_8153_8163(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 8153, 8163);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10433_8249_8259(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 8249, 8259);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10433_8449_8467(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 8449, 8467);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                f_10433_8471_8489(Microsoft.CodeAnalysis.CSharp.BoundLocal
                this_param)
                {
                    var return_v = this_param.LocalSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 8471, 8489);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10433_8682_8700(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 8682, 8700);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10433_8704_8722(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 8704, 8722);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10433_8752_8770(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.FieldSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 8752, 8770);
                    return return_v;
                }


                bool
                f_10433_8752_8779(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 8752, 8779);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10433_8802_8820(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 8802, 8820);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10433_8822_8840(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 8822, 8840);
                    return return_v;
                }


                bool
                f_10433_8783_8841(Microsoft.CodeAnalysis.CSharp.BoundExpression?
                expr1, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                expr2)
                {
                    var return_v = IsSameLocalOrField(expr1, expr2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 8783, 8841);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                f_10433_9035_9053(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
                this_param)
                {
                    var return_v = this_param.EventSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 9035, 9053);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                f_10433_9057_9075(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
                this_param)
                {
                    var return_v = this_param.EventSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 9057, 9075);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                f_10433_9105_9123(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
                this_param)
                {
                    var return_v = this_param.EventSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 9105, 9123);
                    return return_v;
                }


                bool
                f_10433_9105_9132(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 9105, 9132);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10433_9155_9173(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 9155, 9173);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10433_9175_9193(Microsoft.CodeAnalysis.CSharp.BoundEventAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 9175, 9193);
                    return return_v;
                }


                bool
                f_10433_9136_9194(Microsoft.CodeAnalysis.CSharp.BoundExpression?
                expr1, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                expr2)
                {
                    var return_v = IsSameLocalOrField(expr1, expr2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 9136, 9194);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10433_9382_9404(Microsoft.CodeAnalysis.CSharp.BoundParameter
                this_param)
                {
                    var return_v = this_param.ParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 9382, 9404);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                f_10433_9408_9430(Microsoft.CodeAnalysis.CSharp.BoundParameter
                this_param)
                {
                    var return_v = this_param.ParameterSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 9408, 9430);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                f_10433_9635_9664(Microsoft.CodeAnalysis.CSharp.BoundRangeVariable
                this_param)
                {
                    var return_v = this_param.RangeVariableSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 9635, 9664);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.RangeVariableSymbol
                f_10433_9668_9697(Microsoft.CodeAnalysis.CSharp.BoundRangeVariable
                this_param)
                {
                    var return_v = this_param.RangeVariableSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 9668, 9697);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10433_9918_9928(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 9918, 9928);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10433_9930_9940(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 9930, 9940);
                    return return_v;
                }


                bool
                f_10433_9900_9978(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 9900, 9978);
                    return return_v;
                }


                int
                f_10433_9887_9979(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 9887, 9979);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10433, 7583, 10101);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10433, 7583, 10101);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsComCallWithRefOmitted(MethodSymbol method, ImmutableArray<BoundExpression> arguments, ImmutableArray<RefKind> argumentRefKindsOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10433, 10113, 10765);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 10290, 10480) || true) && (f_10433_10294_10315(method) != arguments.Length || (DynAbs.Tracing.TraceSender.Expression_False(10433, 10294, 10393) || (object)f_10433_10364_10385(method) == null) || (DynAbs.Tracing.TraceSender.Expression_False(10433, 10294, 10448) || f_10433_10414_10448_M(!f_10433_10415_10436(method).IsComImport)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 10290, 10480);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 10467, 10480);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 10290, 10480);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 10505, 10510);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 10496, 10725) || true) && (i < arguments.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 10534, 10537)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 10496, 10725))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 10496, 10725);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 10571, 10710) || true) && (f_10433_10575_10603(f_10433_10575_10592(method)[i]) != RefKind.None && (DynAbs.Tracing.TraceSender.Expression_True(10433, 10575, 10696) && (argumentRefKindsOpt.IsDefault || (DynAbs.Tracing.TraceSender.Expression_False(10433, 10624, 10695) || argumentRefKindsOpt[i] == RefKind.None))))
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 10571, 10710);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 10698, 10710);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 10571, 10710);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10433, 1, 230);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10433, 1, 230);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 10741, 10754);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10433, 10113, 10765);

                int
                f_10433_10294_10315(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 10294, 10315);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10433_10364_10385(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 10364, 10385);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10433_10415_10436(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 10415, 10436);
                    return return_v;
                }


                bool
                f_10433_10414_10448_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 10414, 10448);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10433_10575_10592(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 10575, 10592);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10433_10575_10603(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.RefKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 10575, 10603);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10433, 10113, 10765);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10433, 10113, 10765);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CheckBinaryOperator(BoundBinaryOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10433, 10777, 11269);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 10860, 11016) || true) && ((object)f_10433_10872_10886(node) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 10860, 11016);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 10928, 10955);

                    f_10433_10928_10954(this, f_10433_10944_10953(node));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 10973, 11001);

                    f_10433_10973_11000(this, f_10433_10989_10999(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 10860, 11016);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 11032, 11108);

                f_10433_11032_11107(this, node, f_10433_11066_11083(node), f_10433_11085_11094(node), f_10433_11096_11106(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 11122, 11151);

                f_10433_11122_11150(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 11165, 11188);

                f_10433_11165_11187(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 11202, 11225);

                f_10433_11202_11224(this, node);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 11239, 11258);

                f_10433_11239_11257(this, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10433, 10777, 11269);

                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10433_10872_10886(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.MethodOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 10872, 10886);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_10944_10953(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 10944, 10953);
                    return return_v;
                }


                int
                f_10433_10928_10954(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                e)
                {
                    this_param.CheckUnsafeType(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 10928, 10954);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_10989_10999(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 10989, 10999);
                    return return_v;
                }


                int
                f_10433_10973_11000(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression
                e)
                {
                    this_param.CheckUnsafeType(e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 10973, 11000);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10433_11066_11083(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 11066, 11083);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_11085_11094(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 11085, 11094);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_11096_11106(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 11096, 11106);
                    return return_v;
                }


                int
                f_10433_11032_11107(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                node, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                operatorKind, Microsoft.CodeAnalysis.CSharp.BoundExpression
                leftOperand, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rightOperand)
                {
                    this_param.CheckForBitwiseOrSignExtend((Microsoft.CodeAnalysis.CSharp.BoundExpression)node, operatorKind, leftOperand, rightOperand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 11032, 11107);
                    return 0;
                }


                int
                f_10433_11122_11150(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                node)
                {
                    this_param.CheckNullableNullBinOp(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 11122, 11150);
                    return 0;
                }


                int
                f_10433_11165_11187(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                node)
                {
                    this_param.CheckLiftedBinOp(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 11165, 11187);
                    return 0;
                }


                int
                f_10433_11202_11224(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                node)
                {
                    this_param.CheckRelationals(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 11202, 11224);
                    return 0;
                }


                int
                f_10433_11239_11257(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                node)
                {
                    this_param.CheckDynamic(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 11239, 11257);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10433, 10777, 11269);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10433, 10777, 11269);
            }
        }

        private void CheckCompoundAssignmentOperator(BoundCompoundAssignmentOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10433, 11281, 12257);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 11388, 11421);

                BoundExpression
                left = f_10433_11411_11420(node)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 11437, 11960) || true) && (!f_10433_11442_11472(node.Operator.Kind) && (DynAbs.Tracing.TraceSender.Expression_True(10433, 11441, 11507) && f_10433_11476_11507_M(!node.LeftConversion.IsIdentity)) && (DynAbs.Tracing.TraceSender.Expression_True(10433, 11441, 11537) && node.LeftConversion.Exists))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 11437, 11960);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 11695, 11945);

                    left = f_10433_11702_11944(left.Syntax, left, f_10433_11741_11760(node), f_10433_11762_11792(node.Operator.Kind), explicitCastInCode: false, conversionGroupOpt: null, constantValueOpt: null, type: node.Operator.LeftType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 11437, 11960);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 11976, 12048);

                f_10433_11976_12047(this, node, node.Operator.Kind, left, f_10433_12036_12046(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 12062, 12098);

                f_10433_12062_12097(this, node);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 12114, 12246) || true) && (_inExpressionLambda)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 12114, 12246);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 12171, 12231);

                    f_10433_12171_12230(this, ErrorCode.ERR_ExpressionTreeContainsAssignment, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 12114, 12246);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10433, 11281, 12257);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_11411_11420(Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 11411, 11420);
                    return return_v;
                }


                bool
                f_10433_11442_11472(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.IsDynamic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 11442, 11472);
                    return return_v;
                }


                bool
                f_10433_11476_11507_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 11476, 11507);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Conversion
                f_10433_11741_11760(Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.LeftConversion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 11741, 11760);
                    return return_v;
                }


                bool
                f_10433_11762_11792(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.IsChecked();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 11762, 11792);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundConversion
                f_10433_11702_11944(Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand, Microsoft.CodeAnalysis.CSharp.Conversion
                conversion, bool
                @checked, bool
                explicitCastInCode, Microsoft.CodeAnalysis.CSharp.ConversionGroup?
                conversionGroupOpt, Microsoft.CodeAnalysis.ConstantValue?
                constantValueOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.BoundConversion(syntax, operand, conversion, @checked, explicitCastInCode: explicitCastInCode, conversionGroupOpt: conversionGroupOpt, constantValueOpt: constantValueOpt, type: type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 11702, 11944);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_12036_12046(Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 12036, 12046);
                    return return_v;
                }


                int
                f_10433_11976_12047(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
                node, Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                operatorKind, Microsoft.CodeAnalysis.CSharp.BoundExpression
                leftOperand, Microsoft.CodeAnalysis.CSharp.BoundExpression
                rightOperand)
                {
                    this_param.CheckForBitwiseOrSignExtend((Microsoft.CodeAnalysis.CSharp.BoundExpression)node, operatorKind, leftOperand, rightOperand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 11976, 12047);
                    return 0;
                }


                int
                f_10433_12062_12097(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
                node)
                {
                    this_param.CheckLiftedCompoundAssignment(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 12062, 12097);
                    return 0;
                }


                int
                f_10433_12171_12230(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 12171, 12230);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10433, 11281, 12257);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10433, 11281, 12257);
            }
        }

        private void CheckRelationals(BoundBinaryOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10433, 12269, 14482);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 12349, 12376);

                f_10433_12349_12375(node != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 12392, 12485) || true) && (!f_10433_12397_12429(f_10433_12397_12414(node)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 12392, 12485);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 12463, 12470);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 12392, 12485);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 12742, 12972) || true) && (f_10433_12746_12769(f_10433_12746_12755(node)) != null && (DynAbs.Tracing.TraceSender.Expression_True(10433, 12746, 12813) && f_10433_12781_12805(f_10433_12781_12791(node)) == null) && (DynAbs.Tracing.TraceSender.Expression_True(10433, 12746, 12856) && f_10433_12817_12832(f_10433_12817_12827(node)) == BoundKind.Conversion))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 12742, 12972);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 12890, 12957);

                    f_10433_12890_12956(this, node, f_10433_12920_12943(f_10433_12920_12929(node)), f_10433_12945_12955(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 12742, 12972);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 12988, 13217) || true) && (f_10433_12992_13016(f_10433_12992_13002(node)) != null && (DynAbs.Tracing.TraceSender.Expression_True(10433, 12992, 13059) && f_10433_13028_13051(f_10433_13028_13037(node)) == null) && (DynAbs.Tracing.TraceSender.Expression_True(10433, 12992, 13101) && f_10433_13063_13077(f_10433_13063_13072(node)) == BoundKind.Conversion))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 12988, 13217);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 13135, 13202);

                    f_10433_13135_13201(this, node, f_10433_13165_13189(f_10433_13165_13175(node)), f_10433_13191_13200(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 12988, 13217);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 13233, 14428) || true) && (f_10433_13237_13254(node) == BinaryOperatorKind.ObjectEqual || (DynAbs.Tracing.TraceSender.Expression_False(10433, 13237, 13346) || f_10433_13292_13309(node) == BinaryOperatorKind.ObjectNotEqual))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 13233, 14428);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 13380, 13393);

                    TypeSymbol
                    t
                    = default(TypeSymbol);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 13411, 14413) || true) && (f_10433_13415_13441(f_10433_13415_13429(f_10433_13415_13424(node))) == SpecialType.System_Object && (DynAbs.Tracing.TraceSender.Expression_True(10433, 13415, 13500) && !f_10433_13475_13500(f_10433_13490_13499(node))) && (DynAbs.Tracing.TraceSender.Expression_True(10433, 13415, 13572) && !(f_10433_13506_13529(f_10433_13506_13515(node)) != null && (DynAbs.Tracing.TraceSender.Expression_True(10433, 13506, 13571) && f_10433_13541_13571(f_10433_13541_13564(f_10433_13541_13550(node)))))) && (DynAbs.Tracing.TraceSender.Expression_True(10433, 13415, 13631) && f_10433_13576_13631(f_10433_13594_13611(node), f_10433_13613_13623(node), out t)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 13411, 14413);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 13804, 13879);

                        f_10433_13804_13878(                    // Possible unintended reference comparison; to get a value comparison, cast the left hand side to type '{0}'
                                            _diagnostics, ErrorCode.WRN_BadRefCompareLeft, f_10433_13854_13874(node.Syntax), t);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 13411, 14413);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 13411, 14413);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 13921, 14413) || true) && (f_10433_13925_13952(f_10433_13925_13940(f_10433_13925_13935(node))) == SpecialType.System_Object && (DynAbs.Tracing.TraceSender.Expression_True(10433, 13925, 14012) && !f_10433_13986_14012(f_10433_14001_14011(node))) && (DynAbs.Tracing.TraceSender.Expression_True(10433, 13925, 14086) && !(f_10433_14018_14042(f_10433_14018_14028(node)) != null && (DynAbs.Tracing.TraceSender.Expression_True(10433, 14018, 14085) && f_10433_14054_14085(f_10433_14054_14078(f_10433_14054_14064(node)))))) && (DynAbs.Tracing.TraceSender.Expression_True(10433, 13925, 14144) && f_10433_14090_14144(f_10433_14108_14125(node), f_10433_14127_14136(node), out t)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 13921, 14413);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 14318, 14394);

                            f_10433_14318_14393(                    // Possible unintended reference comparison; to get a value comparison, cast the right hand side to type '{0}'
                                                _diagnostics, ErrorCode.WRN_BadRefCompareRight, f_10433_14369_14389(node.Syntax), t);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 13921, 14413);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 13411, 14413);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 13233, 14428);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 14444, 14471);

                f_10433_14444_14470(this, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10433, 12269, 14482);

                int
                f_10433_12349_12375(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 12349, 12375);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10433_12397_12414(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 12397, 12414);
                    return return_v;
                }


                bool
                f_10433_12397_12429(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.IsComparison();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 12397, 12429);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_12746_12755(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 12746, 12755);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10433_12746_12769(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 12746, 12769);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_12781_12791(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 12781, 12791);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10433_12781_12805(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 12781, 12805);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_12817_12827(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 12817, 12827);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10433_12817_12832(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 12817, 12832);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_12920_12929(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 12920, 12929);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10433_12920_12943(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 12920, 12943);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_12945_12955(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 12945, 12955);
                    return return_v;
                }


                int
                f_10433_12890_12956(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                tree, Microsoft.CodeAnalysis.ConstantValue
                constantValue, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand)
                {
                    this_param.CheckVacuousComparisons(tree, constantValue, (Microsoft.CodeAnalysis.CSharp.BoundNode)operand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 12890, 12956);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_12992_13002(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 12992, 13002);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10433_12992_13016(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 12992, 13016);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_13028_13037(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 13028, 13037);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10433_13028_13051(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 13028, 13051);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_13063_13072(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 13063, 13072);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10433_13063_13077(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 13063, 13077);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_13165_13175(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 13165, 13175);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10433_13165_13189(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 13165, 13189);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_13191_13200(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 13191, 13200);
                    return return_v;
                }


                int
                f_10433_13135_13201(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                tree, Microsoft.CodeAnalysis.ConstantValue
                constantValue, Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand)
                {
                    this_param.CheckVacuousComparisons(tree, constantValue, (Microsoft.CodeAnalysis.CSharp.BoundNode)operand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 13135, 13201);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10433_13237_13254(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 13237, 13254);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10433_13292_13309(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 13292, 13309);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_13415_13424(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 13415, 13424);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10433_13415_13429(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 13415, 13429);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10433_13415_13441(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 13415, 13441);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_13490_13499(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 13490, 13499);
                    return return_v;
                }


                bool
                f_10433_13475_13500(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = IsExplicitCast(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 13475, 13500);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_13506_13515(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 13506, 13515);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10433_13506_13529(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 13506, 13529);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_13541_13550(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 13541, 13550);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10433_13541_13564(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 13541, 13564);
                    return return_v;
                }


                bool
                f_10433_13541_13571(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.IsNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 13541, 13571);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10433_13594_13611(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 13594, 13611);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_13613_13623(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 13613, 13623);
                    return return_v;
                }


                bool
                f_10433_13576_13631(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                oldOperatorKind, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, out Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = ConvertedHasEqual(oldOperatorKind, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, out type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 13576, 13631);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10433_13854_13874(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 13854, 13874);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10433_13804_13878(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 13804, 13878);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_13925_13935(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 13925, 13935);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10433_13925_13940(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 13925, 13940);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10433_13925_13952(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 13925, 13952);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_14001_14011(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 14001, 14011);
                    return return_v;
                }


                bool
                f_10433_13986_14012(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = IsExplicitCast(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 13986, 14012);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_14018_14028(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 14018, 14028);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10433_14018_14042(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 14018, 14042);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_14054_14064(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 14054, 14064);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10433_14054_14078(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 14054, 14078);
                    return return_v;
                }


                bool
                f_10433_14054_14085(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.IsNull;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 14054, 14085);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10433_14108_14125(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 14108, 14125);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_14127_14136(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 14127, 14136);
                    return return_v;
                }


                bool
                f_10433_14090_14144(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                oldOperatorKind, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, out Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = ConvertedHasEqual(oldOperatorKind, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, out type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 14090, 14144);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10433_14369_14389(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 14369, 14389);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10433_14318_14393(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 14318, 14393);
                    return return_v;
                }


                int
                f_10433_14444_14470(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                node)
                {
                    this_param.CheckSelfComparisons(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 14444, 14470);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10433, 12269, 14482);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10433, 12269, 14482);
            }
        }

        private static bool IsExplicitCast(BoundExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10433, 14494, 14673);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 14575, 14662);

                return f_10433_14582_14591(node) == BoundKind.Conversion && (DynAbs.Tracing.TraceSender.Expression_True(10433, 14582, 14661) && f_10433_14619_14661(((BoundConversion)node)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10433, 14494, 14673);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10433_14582_14591(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 14582, 14591);
                    return return_v;
                }


                bool
                f_10433_14619_14661(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ExplicitCastInCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 14619, 14661);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10433, 14494, 14673);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10433, 14494, 14673);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool ConvertedHasEqual(BinaryOperatorKind oldOperatorKind, BoundNode node, out TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10433, 14685, 16192);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 14820, 14832);

                type = null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 14846, 14898) || true) && (f_10433_14850_14859(node) != BoundKind.Conversion)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 14846, 14898);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 14885, 14898);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 14846, 14898);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 14912, 14945);

                var
                conv = (BoundConversion)node
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 14959, 15001) || true) && (f_10433_14963_14986(conv))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 14959, 15001);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 14988, 15001);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 14959, 15001);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 15015, 15073);

                NamedTypeSymbol
                nt = f_10433_15036_15053(f_10433_15036_15048(conv)) as NamedTypeSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 15087, 15212) || true) && ((object)nt == null || (DynAbs.Tracing.TraceSender.Expression_False(10433, 15091, 15132) || f_10433_15113_15132_M(!nt.IsReferenceType)) || (DynAbs.Tracing.TraceSender.Expression_False(10433, 15091, 15150) || f_10433_15136_15150(nt)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 15087, 15212);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 15184, 15197);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 15087, 15212);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 15228, 15386);

                string
                opName = (DynAbs.Tracing.TraceSender.Conditional_F1(10433, 15244, 15295) || (((oldOperatorKind == BinaryOperatorKind.ObjectEqual) && DynAbs.Tracing.TraceSender.Conditional_F2(10433, 15298, 15339)) || DynAbs.Tracing.TraceSender.Conditional_F3(10433, 15342, 15385))) ? WellKnownMemberNames.EqualityOperatorName : WellKnownMemberNames.InequalityOperatorName
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 15409, 15415);
                    for (var
        t = nt
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 15400, 16152) || true) && ((object)t != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 15436, 15470)
        , t = f_10433_15440_15470(t), DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 15400, 16152))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 15400, 16152);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 15504, 16137);
                            foreach (var sym in f_10433_15524_15544_I(f_10433_15524_15544(t, opName)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 15504, 16137);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 15586, 15624);

                                MethodSymbol
                                op = sym as MethodSymbol
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 15646, 15730) || true) && ((object)op == null || (DynAbs.Tracing.TraceSender.Expression_False(10433, 15650, 15719) || f_10433_15672_15685(op) != MethodKind.UserDefinedOperator))
                                )
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 15646, 15730);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 15721, 15730);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 15646, 15730);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 15752, 15788);

                                var
                                parameters = f_10433_15769_15787(op)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 15810, 16118) || true) && (parameters.Length == 2 && (DynAbs.Tracing.TraceSender.Expression_True(10433, 15814, 15917) && f_10433_15840_15917(f_10433_15858_15876(parameters[0]), t, TypeCompareKind.ConsiderEverything2)) && (DynAbs.Tracing.TraceSender.Expression_True(10433, 15814, 15998) && f_10433_15921_15998(f_10433_15939_15957(parameters[1]), t, TypeCompareKind.ConsiderEverything2)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 15810, 16118);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 16048, 16057);

                                    type = t;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 16083, 16095);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 15810, 16118);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 15504, 16137);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10433, 1, 634);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10433, 1, 634);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10433, 1, 753);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10433, 1, 753);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 16168, 16181);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10433, 14685, 16192);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10433_14850_14859(Microsoft.CodeAnalysis.CSharp.BoundNode
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 14850, 14859);
                    return return_v;
                }


                bool
                f_10433_14963_14986(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ExplicitCastInCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 14963, 14986);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_15036_15048(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 15036, 15048);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10433_15036_15053(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 15036, 15053);
                    return return_v;
                }


                bool
                f_10433_15113_15132_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 15113, 15132);
                    return return_v;
                }


                bool
                f_10433_15136_15150(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 15136, 15150);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10433_15440_15470(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 15440, 15470);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10433_15524_15544(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetMembers(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 15524, 15544);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_10433_15672_15685(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 15672, 15685);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10433_15769_15787(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                member)
                {
                    var return_v = member.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 15769, 15787);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10433_15858_15876(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 15858, 15876);
                    return return_v;
                }


                bool
                f_10433_15840_15917(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 15840, 15917);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10433_15939_15957(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 15939, 15957);
                    return return_v;
                }


                bool
                f_10433_15921_15998(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 15921, 15998);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10433_15524_15544_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 15524, 15544);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10433, 14685, 16192);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10433, 14685, 16192);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CheckSelfComparisons(BoundBinaryOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10433, 16204, 16563);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 16288, 16315);

                f_10433_16288_16314(node != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 16329, 16376);

                f_10433_16329_16375(f_10433_16342_16374(f_10433_16342_16359(node)));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 16392, 16552) || true) && (f_10433_16396_16414_M(!node.HasAnyErrors) && (DynAbs.Tracing.TraceSender.Expression_True(10433, 16396, 16459) && f_10433_16418_16459(f_10433_16437_16446(node), f_10433_16448_16458(node))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 16392, 16552);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 16493, 16537);

                    f_10433_16493_16536(this, ErrorCode.WRN_ComparisonToSelf, node);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 16392, 16552);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10433, 16204, 16563);

                int
                f_10433_16288_16314(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 16288, 16314);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10433_16342_16359(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 16342, 16359);
                    return return_v;
                }


                bool
                f_10433_16342_16374(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.IsComparison();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 16342, 16374);
                    return return_v;
                }


                int
                f_10433_16329_16375(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 16329, 16375);
                    return 0;
                }


                bool
                f_10433_16396_16414_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 16396, 16414);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_16437_16446(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 16437, 16446);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_16448_16458(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 16448, 16458);
                    return return_v;
                }


                bool
                f_10433_16418_16459(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr1, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr2)
                {
                    var return_v = IsSameLocalOrField(expr1, expr2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 16418, 16459);
                    return return_v;
                }


                int
                f_10433_16493_16536(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 16493, 16536);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10433, 16204, 16563);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10433, 16204, 16563);
            }
        }

        private void CheckVacuousComparisons(BoundBinaryOperator tree, ConstantValue constantValue, BoundNode operand)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10433, 16575, 19968);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 16710, 16737);

                f_10433_16710_16736(tree != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 16751, 16787);

                f_10433_16751_16786(constantValue != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 16801, 16831);

                f_10433_16801_16830(operand != null);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 18842, 18881);

                    // We wish to detect comparisons between integers and constants which are likely to be wrong
                    // because we know at compile time whether they will be true or false. For example:
                    // 
                    // const short s = 1000;
                    // byte b = whatever;
                    // if (b < s)
                    //
                    // We know that this will always be true because when b and s are both converted to int for
                    // the comparison, the left side will always be less than the right side. 
                    //
                    // We only give the warning if there is no explicit conversion involved on the operand. 
                    // For example, if we had:
                    //
                    // const uint s = 1000;
                    // sbyte b = whatever; 
                    // if ((byte)b < s)
                    //
                    // Then we do not give a warning.
                    //
                    // Note that the native compiler has what looks to be some dead code. It checks to see
                    // if the conversion on the operand is from an enum type. But this is unnecessary if
                    // we are rejecting cases with explicit conversions. The only possible cases are:
                    //
                    // enum == enumConstant           -- enum types must be the same, so it must be in range.
                    // enum == integralConstant       -- not legal unless the constant is zero, which is in range.
                    // enum == (ENUM)anyConstant      -- if the constant is out of range then this is not legal in the first place
                    //                                   unless we're in an unchecked context, in which case, the user probably does 
                    //                                   not want the warning.
                    // integral == enumConstant       -- never legal in the first place
                    //
                    // Since it seems pointless to try to check enums, we simply look for vacuous comparisons of
                    // integral types here.

                    for (BoundConversion
        conversion = operand as BoundConversion
        ;
        (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 18821, 19957) || true) && (conversion != null)
        ;
        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 18937, 18987)
        , conversion = f_10433_18950_18968(conversion) as BoundConversion, DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 18821, 19957))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 18821, 19957);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 19021, 19237) || true) && (f_10433_19025_19050(conversion) != ConversionKind.ImplicitNumeric && (DynAbs.Tracing.TraceSender.Expression_True(10433, 19025, 19169) && f_10433_19109_19134(conversion) != ConversionKind.ImplicitConstant))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 19021, 19237);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 19211, 19218);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 19021, 19237);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 19375, 19476) || true) && (f_10433_19379_19408(conversion))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 19375, 19476);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 19450, 19457);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 19375, 19476);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 19496, 19670) || true) && (!f_10433_19501_19553(f_10433_19501_19536(f_10433_19501_19524(f_10433_19501_19519(conversion)))) || (DynAbs.Tracing.TraceSender.Expression_False(10433, 19500, 19602) || !f_10433_19558_19602(f_10433_19558_19585(f_10433_19558_19573(conversion)))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 19496, 19670);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 19644, 19651);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 19496, 19670);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 19690, 19942) || true) && (!f_10433_19695_19780(f_10433_19722_19757(f_10433_19722_19745(f_10433_19722_19740(conversion))), constantValue, out _))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 19690, 19942);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 19822, 19894);

                            f_10433_19822_19893(this, ErrorCode.WRN_VacuousIntegralComp, tree, f_10433_19869_19892(f_10433_19869_19887(conversion)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 19916, 19923);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 19690, 19942);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10433, 1, 1137);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10433, 1, 1137);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10433, 16575, 19968);

                int
                f_10433_16710_16736(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 16710, 16736);
                    return 0;
                }


                int
                f_10433_16751_16786(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 16751, 16786);
                    return 0;
                }


                int
                f_10433_16801_16830(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 16801, 16830);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_18950_18968(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 18950, 18968);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10433_19025_19050(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 19025, 19050);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10433_19109_19134(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 19109, 19134);
                    return return_v;
                }


                bool
                f_10433_19379_19408(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ExplicitCastInCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 19379, 19408);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_19501_19519(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 19501, 19519);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10433_19501_19524(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 19501, 19524);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10433_19501_19536(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 19501, 19536);
                    return return_v;
                }


                bool
                f_10433_19501_19553(Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = specialType.IsIntegralType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 19501, 19553);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10433_19558_19573(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 19558, 19573);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10433_19558_19585(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 19558, 19585);
                    return return_v;
                }


                bool
                f_10433_19558_19602(Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = specialType.IsIntegralType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 19558, 19602);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_19722_19740(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 19722, 19740);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10433_19722_19745(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 19722, 19745);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10433_19722_19757(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 19722, 19757);
                    return return_v;
                }


                bool
                f_10433_19695_19780(Microsoft.CodeAnalysis.SpecialType
                destinationType, Microsoft.CodeAnalysis.ConstantValue
                value, out bool
                maySucceedAtRuntime)
                {
                    var return_v = Binder.CheckConstantBounds(destinationType, value, out maySucceedAtRuntime);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 19695, 19780);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_19869_19887(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 19869, 19887);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10433_19869_19892(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 19869, 19892);
                    return return_v;
                }


                int
                f_10433_19822_19893(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 19822, 19893);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10433, 16575, 19968);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10433, 16575, 19968);
            }
        }

        private void CheckForBitwiseOrSignExtend(BoundExpression node, BinaryOperatorKind operatorKind, BoundExpression leftOperand, BoundExpression rightOperand)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10433, 19980, 25529);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 23050, 23600);

                switch (operatorKind)
                {

                    case BinaryOperatorKind.LiftedUIntOr:
                    case BinaryOperatorKind.LiftedIntOr:
                    case BinaryOperatorKind.LiftedULongOr:
                    case BinaryOperatorKind.LiftedLongOr:
                    case BinaryOperatorKind.UIntOr:
                    case BinaryOperatorKind.IntOr:
                    case BinaryOperatorKind.ULongOr:
                    case BinaryOperatorKind.LongOr:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 23050, 23600);
                        DynAbs.Tracing.TraceSender.TraceBreak(10433, 23524, 23530);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 23050, 23600);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 23050, 23600);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 23578, 23585);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 23050, 23600);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 23978, 24064) || true) && (f_10433_23982_24000(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 23978, 24064);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 24042, 24049);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 23978, 24064);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 24185, 24243);

                ulong
                left = f_10433_24198_24242(leftOperand)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 24257, 24317);

                ulong
                right = f_10433_24271_24316(rightOperand)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 24409, 24482) || true) && (left == right)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 24409, 24482);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 24460, 24467);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 24409, 24482);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 24675, 24747);

                ConstantValue
                constVal = f_10433_24700_24746(leftOperand)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 24761, 25002) || true) && (constVal != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 24761, 25002);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 24815, 24848);

                    ulong
                    val = f_10433_24827_24847(constVal)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 24866, 24987) || true) && ((val & right) == right || (DynAbs.Tracing.TraceSender.Expression_False(10433, 24870, 24919) || (~val & right) == right))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 24866, 24987);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 24961, 24968);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 24866, 24987);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 24761, 25002);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 25018, 25077);

                constVal = f_10433_25029_25076(rightOperand);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 25091, 25328) || true) && (constVal != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 25091, 25328);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 25145, 25178);

                    ulong
                    val = f_10433_25157_25177(constVal)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 25196, 25313) || true) && ((val & left) == left || (DynAbs.Tracing.TraceSender.Expression_False(10433, 25200, 25245) || (~val & left) == left))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 25196, 25313);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 25287, 25294);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 25196, 25313);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 25091, 25328);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 25471, 25518);

                f_10433_25471_25517(this, ErrorCode.WRN_BitwiseOrSignExtend, node);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10433, 19980, 25529);

                Microsoft.CodeAnalysis.ConstantValue?
                f_10433_23982_24000(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 23982, 24000);
                    return return_v;
                }


                ulong
                f_10433_24198_24242(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = FindSurprisingSignExtensionBits(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 24198, 24242);
                    return return_v;
                }


                ulong
                f_10433_24271_24316(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = FindSurprisingSignExtensionBits(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 24271, 24316);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10433_24700_24746(Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand)
                {
                    var return_v = GetConstantValueForBitwiseOrCheck(operand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 24700, 24746);
                    return return_v;
                }


                ulong
                f_10433_24827_24847(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.UInt64Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 24827, 24847);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue
                f_10433_25029_25076(Microsoft.CodeAnalysis.CSharp.BoundExpression
                operand)
                {
                    var return_v = GetConstantValueForBitwiseOrCheck(operand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 25029, 25076);
                    return return_v;
                }


                ulong
                f_10433_25157_25177(Microsoft.CodeAnalysis.ConstantValue
                this_param)
                {
                    var return_v = this_param.UInt64Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 25157, 25177);
                    return return_v;
                }


                int
                f_10433_25471_25517(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 25471, 25517);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10433, 19980, 25529);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10433, 19980, 25529);
            }
        }

        private static ConstantValue GetConstantValueForBitwiseOrCheck(BoundExpression operand)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10433, 25541, 26306);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 25782, 26079) || true) && (f_10433_25786_25798(operand) == BoundKind.Conversion)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 25782, 26079);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 25856, 25904);

                    BoundConversion
                    conv = (BoundConversion)operand
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 25922, 26064) || true) && (f_10433_25926_25945(conv) == ConversionKind.ImplicitNullable)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 25922, 26064);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 26022, 26045);

                        operand = f_10433_26032_26044(conv);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 25922, 26064);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 25782, 26079);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 26095, 26142);

                ConstantValue
                constVal = f_10433_26120_26141(operand)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 26158, 26263) || true) && (constVal == null || (DynAbs.Tracing.TraceSender.Expression_False(10433, 26162, 26202) || f_10433_26182_26202_M(!constVal.IsIntegral)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 26158, 26263);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 26236, 26248);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 26158, 26263);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 26279, 26295);

                return constVal;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10433, 25541, 26306);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10433_25786_25798(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 25786, 25798);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10433_25926_25945(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 25926, 25945);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_26032_26044(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 26032, 26044);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ConstantValue?
                f_10433_26120_26141(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.ConstantValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 26120, 26141);
                    return return_v;
                }


                bool
                f_10433_26182_26202_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 26182, 26202);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10433, 25541, 26306);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10433, 25541, 26306);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ulong FindSurprisingSignExtensionBits(BoundExpression expr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10433, 26653, 31073);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 26752, 26847) || true) && (f_10433_26756_26765(expr) != BoundKind.Conversion)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 26752, 26847);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 26823, 26832);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 26752, 26847);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 26863, 26908);

                BoundConversion
                conv = (BoundConversion)expr
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 26922, 26958);

                TypeSymbol
                from = f_10433_26940_26957(f_10433_26940_26952(conv))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 26972, 26998);

                TypeSymbol
                to = f_10433_26988_26997(conv)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 27014, 27118) || true) && ((object)from == null || (DynAbs.Tracing.TraceSender.Expression_False(10433, 27018, 27060) || (object)to == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 27014, 27118);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 27094, 27103);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 27014, 27118);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 27134, 27248) || true) && (f_10433_27138_27159(from))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 27134, 27248);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 27193, 27233);

                    from = f_10433_27200_27232(from);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 27134, 27248);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 27264, 27372) || true) && (f_10433_27268_27287(to))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 27264, 27372);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 27321, 27357);

                    to = f_10433_27326_27356(to);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 27264, 27372);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 27388, 27435);

                SpecialType
                fromSpecialType = f_10433_27418_27434(from)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 27449, 27492);

                SpecialType
                toSpecialType = f_10433_27477_27491(to)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 27508, 27638) || true) && (!f_10433_27513_27545(fromSpecialType) || (DynAbs.Tracing.TraceSender.Expression_False(10433, 27512, 27580) || !f_10433_27550_27580(toSpecialType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 27508, 27638);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 27614, 27623);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 27508, 27638);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 27654, 27699);

                int
                fromSize = f_10433_27669_27698(fromSpecialType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 27713, 27754);

                int
                toSize = f_10433_27726_27753(toSpecialType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 27770, 27860) || true) && (fromSize == 0 || (DynAbs.Tracing.TraceSender.Expression_False(10433, 27774, 27802) || toSize == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 27770, 27860);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 27836, 27845);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 27770, 27860);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 28081, 28145);

                ulong
                recursive = f_10433_28099_28144(f_10433_28131_28143(conv))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 28161, 28280) || true) && (fromSize == toSize)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 28161, 28280);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 28248, 28265);

                    return recursive;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 28161, 28280);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 28296, 28867) || true) && (toSize < fromSize)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 28296, 28867);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 28487, 28755);

                    switch (toSize)
                    {

                        case 1:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 28487, 28755);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 28551, 28592);

                            return unchecked((ulong)(byte)recursive);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 28487, 28755);

                        case 2:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 28487, 28755);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 28622, 28665);

                            return unchecked((ulong)(ushort)recursive);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 28487, 28755);

                        case 4:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 28487, 28755);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 28695, 28736);

                            return unchecked((ulong)(uint)recursive);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 28487, 28755);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 28773, 28817);

                    f_10433_28773_28816(false, "How did we get here?");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 28835, 28852);

                    return recursive;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 28296, 28867);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 29120, 29177);

                bool
                fromSigned = f_10433_29138_29176(fromSpecialType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 29193, 29274) || true) && (!fromSigned)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 29193, 29274);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 29242, 29259);

                    return recursive;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 29193, 29274);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 29667, 29800) || true) && (f_10433_29671_29694(conv) && (DynAbs.Tracing.TraceSender.Expression_True(10433, 29671, 29734) && f_10433_29698_29734(toSpecialType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 29667, 29800);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 29768, 29785);

                    return recursive;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 29667, 29800);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 30876, 30901);

                ulong
                result = recursive
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 30924, 30936);
                    for (int
        i = fromSize
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 30915, 31032) || true) && (i < toSize)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 30950, 30953)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 30915, 31032))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 30915, 31032);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 30987, 31017);

                        result |= (0xFFUL) << (i * 8);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10433, 1, 118);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10433, 1, 118);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 31048, 31062);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10433, 26653, 31073);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10433_26756_26765(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 26756, 26765);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_26940_26952(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 26940, 26952);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10433_26940_26957(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 26940, 26957);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10433_26988_26997(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 26988, 26997);
                    return return_v;
                }


                bool
                f_10433_27138_27159(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 27138, 27159);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10433_27200_27232(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 27200, 27232);
                    return return_v;
                }


                bool
                f_10433_27268_27287(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 27268, 27287);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10433_27326_27356(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 27326, 27356);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10433_27418_27434(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 27418, 27434);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10433_27477_27491(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 27477, 27491);
                    return return_v;
                }


                bool
                f_10433_27513_27545(Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = specialType.IsIntegralType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 27513, 27545);
                    return return_v;
                }


                bool
                f_10433_27550_27580(Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = specialType.IsIntegralType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 27550, 27580);
                    return return_v;
                }


                int
                f_10433_27669_27698(Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = specialType.SizeInBytes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 27669, 27698);
                    return return_v;
                }


                int
                f_10433_27726_27753(Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = specialType.SizeInBytes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 27726, 27753);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_28131_28143(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 28131, 28143);
                    return return_v;
                }


                ulong
                f_10433_28099_28144(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = FindSurprisingSignExtensionBits(expr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 28099, 28144);
                    return return_v;
                }


                int
                f_10433_28773_28816(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 28773, 28816);
                    return 0;
                }


                bool
                f_10433_29138_29176(Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = specialType.IsSignedIntegralType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 29138, 29176);
                    return return_v;
                }


                bool
                f_10433_29671_29694(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ExplicitCastInCode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 29671, 29694);
                    return return_v;
                }


                bool
                f_10433_29698_29734(Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = specialType.IsSignedIntegralType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 29698, 29734);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10433, 26653, 31073);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10433, 26653, 31073);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CheckLiftedCompoundAssignment(BoundCompoundAssignmentOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10433, 31085, 31568);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 31190, 31217);

                f_10433_31190_31216(node != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 31231, 31321) || true) && (!f_10433_31236_31265(node.Operator.Kind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 31231, 31321);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 31299, 31306);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 31231, 31321);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 31421, 31557) || true) && (f_10433_31425_31459(f_10433_31425_31435(node)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 31421, 31557);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 31493, 31542);

                    f_10433_31493_31541(this, ErrorCode.WRN_AlwaysNull, node, f_10433_31531_31540(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 31421, 31557);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10433, 31085, 31568);

                int
                f_10433_31190_31216(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 31190, 31216);
                    return 0;
                }


                bool
                f_10433_31236_31265(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.IsLifted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 31236, 31265);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_31425_31435(Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 31425, 31435);
                    return return_v;
                }


                bool
                f_10433_31425_31459(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = expr.NullableNeverHasValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 31425, 31459);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10433_31531_31540(Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 31531, 31540);
                    return return_v;
                }


                int
                f_10433_31493_31541(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundCompoundAssignmentOperator
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 31493, 31541);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10433, 31085, 31568);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10433, 31085, 31568);
            }
        }

        private void CheckLiftedUnaryOp(BoundUnaryOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10433, 31580, 32042);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 31661, 31688);

                f_10433_31661_31687(node != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 31704, 31793) || true) && (!f_10433_31709_31737(f_10433_31709_31726(node)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 31704, 31793);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 31771, 31778);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 31704, 31793);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 31893, 32031) || true) && (f_10433_31897_31933(f_10433_31897_31909(node)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 31893, 32031);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 31967, 32016);

                    f_10433_31967_32015(this, ErrorCode.WRN_AlwaysNull, node, f_10433_32005_32014(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 31893, 32031);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10433, 31580, 32042);

                int
                f_10433_31661_31687(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 31661, 31687);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                f_10433_31709_31726(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 31709, 31726);
                    return return_v;
                }


                bool
                f_10433_31709_31737(Microsoft.CodeAnalysis.CSharp.UnaryOperatorKind
                kind)
                {
                    var return_v = kind.IsLifted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 31709, 31737);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_31897_31909(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 31897, 31909);
                    return return_v;
                }


                bool
                f_10433_31897_31933(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = expr.NullableNeverHasValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 31897, 31933);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10433_32005_32014(Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 32005, 32014);
                    return return_v;
                }


                int
                f_10433_31967_32015(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundUnaryOperator
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 31967, 32015);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10433, 31580, 32042);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10433, 31580, 32042);
            }
        }

        private void CheckNullableNullBinOp(BoundBinaryOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10433, 32054, 33629);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 32140, 32267) || true) && (f_10433_32144_32176(f_10433_32144_32161(node)) != BinaryOperatorKind.NullableNull)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 32140, 32267);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 32245, 32252);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 32140, 32267);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 32283, 33618);

                switch (f_10433_32291_32319(f_10433_32291_32308(node)))
                {

                    case BinaryOperatorKind.Equal:
                    case BinaryOperatorKind.NotEqual:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 32283, 33618);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 32803, 32898);

                        string
                        always = (DynAbs.Tracing.TraceSender.Conditional_F1(10433, 32819, 32878) || ((f_10433_32819_32847(f_10433_32819_32836(node)) == BinaryOperatorKind.NotEqual && DynAbs.Tracing.TraceSender.Conditional_F2(10433, 32881, 32887)) || DynAbs.Tracing.TraceSender.Conditional_F3(10433, 32890, 32897))) ? "true" : "false"
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 33036, 33575) || true) && (f_10433_33040_33066(f_10433_33040_33050(node)) && (DynAbs.Tracing.TraceSender.Expression_True(10433, 33040, 33104) && f_10433_33070_33104(f_10433_33070_33079(node))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 33036, 33575);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 33154, 33268);

                            f_10433_33154_33267(this, ErrorCode.WRN_NubExprIsConstBool, node, always, f_10433_33208_33250(f_10433_33208_33222(f_10433_33208_33217(node))), f_10433_33252_33266(f_10433_33252_33261(node)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 33036, 33575);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 33036, 33575);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 33318, 33575) || true) && (f_10433_33322_33347(f_10433_33322_33331(node)) && (DynAbs.Tracing.TraceSender.Expression_True(10433, 33322, 33386) && f_10433_33351_33386(f_10433_33351_33361(node))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 33318, 33575);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 33436, 33552);

                                f_10433_33436_33551(this, ErrorCode.WRN_NubExprIsConstBool, node, always, f_10433_33490_33533(f_10433_33490_33505(f_10433_33490_33500(node))), f_10433_33535_33550(f_10433_33535_33545(node)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 33318, 33575);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 33036, 33575);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10433, 33597, 33603);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 32283, 33618);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10433, 32054, 33629);

                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10433_32144_32161(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 32144, 32161);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10433_32144_32176(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.OperandTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 32144, 32176);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10433_32291_32308(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 32291, 32308);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10433_32291_32319(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.Operator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 32291, 32319);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10433_32819_32836(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 32819, 32836);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10433_32819_32847(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.Operator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 32819, 32847);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_33040_33050(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 33040, 33050);
                    return return_v;
                }


                bool
                f_10433_33040_33066(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = node.IsLiteralNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 33040, 33066);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_33070_33079(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 33070, 33079);
                    return return_v;
                }


                bool
                f_10433_33070_33104(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = expr.NullableAlwaysHasValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 33070, 33104);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_33208_33217(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 33208, 33217);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10433_33208_33222(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 33208, 33222);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10433_33208_33250(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 33208, 33250);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_33252_33261(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 33252, 33261);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10433_33252_33266(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 33252, 33266);
                    return return_v;
                }


                int
                f_10433_33154_33267(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 33154, 33267);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_33322_33331(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 33322, 33331);
                    return return_v;
                }


                bool
                f_10433_33322_33347(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = node.IsLiteralNull();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 33322, 33347);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_33351_33361(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 33351, 33361);
                    return return_v;
                }


                bool
                f_10433_33351_33386(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = expr.NullableAlwaysHasValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 33351, 33386);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_33490_33500(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 33490, 33500);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10433_33490_33505(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 33490, 33505);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10433_33490_33533(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 33490, 33533);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_33535_33545(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 33535, 33545);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10433_33535_33550(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 33535, 33550);
                    return return_v;
                }


                int
                f_10433_33436_33551(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 33436, 33551);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10433, 32054, 33629);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10433, 32054, 33629);
            }
        }

        private void CheckLiftedBinOp(BoundBinaryOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10433, 33641, 37069);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 33721, 33748);

                f_10433_33721_33747(node != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 33764, 33853) || true) && (!f_10433_33769_33797(f_10433_33769_33786(node)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 33764, 33853);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 33831, 33838);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 33764, 33853);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 33869, 37058);

                switch (f_10433_33877_33905(f_10433_33877_33894(node)))
                {

                    case BinaryOperatorKind.LessThan:
                    case BinaryOperatorKind.LessThanOrEqual:
                    case BinaryOperatorKind.GreaterThan:
                    case BinaryOperatorKind.GreaterThanOrEqual:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 33869, 37058);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 34365, 34790) || true) && (f_10433_34369_34403(f_10433_34369_34379(node)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 34365, 34790);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 34453, 34542);

                            f_10433_34453_34541(this, ErrorCode.WRN_CmpAlwaysFalse, node, f_10433_34495_34540(f_10433_34529_34539(node)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 34365, 34790);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 34365, 34790);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 34592, 34790) || true) && (f_10433_34596_34629(f_10433_34596_34605(node)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 34592, 34790);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 34679, 34767);

                                f_10433_34679_34766(this, ErrorCode.WRN_CmpAlwaysFalse, node, f_10433_34721_34765(f_10433_34755_34764(node)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 34592, 34790);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 34365, 34790);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10433, 34812, 34818);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 33869, 37058);

                    case BinaryOperatorKind.Equal:
                    case BinaryOperatorKind.NotEqual:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 33869, 37058);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 35286, 35381);

                        string
                        always = (DynAbs.Tracing.TraceSender.Conditional_F1(10433, 35302, 35361) || ((f_10433_35302_35330(f_10433_35302_35319(node)) == BinaryOperatorKind.NotEqual && DynAbs.Tracing.TraceSender.Conditional_F2(10433, 35364, 35370)) || DynAbs.Tracing.TraceSender.Conditional_F3(10433, 35373, 35380))) ? "true" : "false"
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 35405, 36164) || true) && (f_10433_35409_35443(f_10433_35409_35419(node)) && (DynAbs.Tracing.TraceSender.Expression_True(10433, 35409, 35481) && f_10433_35447_35481(f_10433_35447_35456(node))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 35405, 36164);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 35531, 35748);

                            f_10433_35531_35747(this, (DynAbs.Tracing.TraceSender.Conditional_F1(10433, 35537, 35570) || ((f_10433_35537_35570(f_10433_35537_35554(node)) && DynAbs.Tracing.TraceSender.Conditional_F2(10433, 35573, 35606)) || DynAbs.Tracing.TraceSender.Conditional_F3(10433, 35609, 35641))) ? ErrorCode.WRN_NubExprIsConstBool2 : ErrorCode.WRN_NubExprIsConstBool, node, always, f_10433_35657_35699(f_10433_35657_35671(f_10433_35657_35666(node))), f_10433_35701_35746(f_10433_35735_35745(node)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 35405, 36164);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 35405, 36164);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 35798, 36164) || true) && (f_10433_35802_35835(f_10433_35802_35811(node)) && (DynAbs.Tracing.TraceSender.Expression_True(10433, 35802, 35874) && f_10433_35839_35874(f_10433_35839_35849(node))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 35798, 36164);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 35924, 36141);

                                f_10433_35924_36140(this, (DynAbs.Tracing.TraceSender.Conditional_F1(10433, 35930, 35963) || ((f_10433_35930_35963(f_10433_35930_35947(node)) && DynAbs.Tracing.TraceSender.Conditional_F2(10433, 35966, 35999)) || DynAbs.Tracing.TraceSender.Conditional_F3(10433, 36002, 36034))) ? ErrorCode.WRN_NubExprIsConstBool2 : ErrorCode.WRN_NubExprIsConstBool, node, always, f_10433_36050_36093(f_10433_36050_36065(f_10433_36050_36060(node))), f_10433_36095_36139(f_10433_36129_36138(node)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 35798, 36164);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 35405, 36164);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10433, 36186, 36192);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 33869, 37058);

                    case BinaryOperatorKind.Or:
                    case BinaryOperatorKind.And:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 33869, 37058);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 36397, 36650) || true) && ((f_10433_36402_36435(f_10433_36402_36411(node)) && (DynAbs.Tracing.TraceSender.Expression_True(10433, 36402, 36472) && f_10433_36439_36472(f_10433_36439_36449(node)))) || (DynAbs.Tracing.TraceSender.Expression_False(10433, 36401, 36574) || (f_10433_36503_36535(f_10433_36503_36512(node)) && (DynAbs.Tracing.TraceSender.Expression_True(10433, 36503, 36573) && f_10433_36539_36573(f_10433_36539_36549(node))))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 36397, 36650);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 36601, 36650);

                            f_10433_36601_36649(this, ErrorCode.WRN_AlwaysNull, node, f_10433_36639_36648(node));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 36397, 36650);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10433, 36672, 36678);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 33869, 37058);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 33869, 37058);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 36818, 37015) || true) && (f_10433_36822_36856(f_10433_36822_36832(node)) || (DynAbs.Tracing.TraceSender.Expression_False(10433, 36822, 36893) || f_10433_36860_36893(f_10433_36860_36869(node))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 36818, 37015);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 36943, 36992);

                            f_10433_36943_36991(this, ErrorCode.WRN_AlwaysNull, node, f_10433_36981_36990(node));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 36818, 37015);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(10433, 37037, 37043);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 33869, 37058);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10433, 33641, 37069);

                int
                f_10433_33721_33747(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 33721, 33747);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10433_33769_33786(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 33769, 33786);
                    return return_v;
                }


                bool
                f_10433_33769_33797(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.IsLifted();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 33769, 33797);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10433_33877_33894(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 33877, 33894);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10433_33877_33905(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.Operator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 33877, 33905);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_34369_34379(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 34369, 34379);
                    return return_v;
                }


                bool
                f_10433_34369_34403(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = expr.NullableNeverHasValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 34369, 34403);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_34529_34539(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 34529, 34539);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10433_34495_34540(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = GetTypeForLiftedComparisonWarning(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 34495, 34540);
                    return return_v;
                }


                int
                f_10433_34453_34541(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 34453, 34541);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_34596_34605(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 34596, 34605);
                    return return_v;
                }


                bool
                f_10433_34596_34629(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = expr.NullableNeverHasValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 34596, 34629);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_34755_34764(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 34755, 34764);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10433_34721_34765(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = GetTypeForLiftedComparisonWarning(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 34721, 34765);
                    return return_v;
                }


                int
                f_10433_34679_34766(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 34679, 34766);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10433_35302_35319(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 35302, 35319);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10433_35302_35330(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.Operator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 35302, 35330);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_35409_35419(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 35409, 35419);
                    return return_v;
                }


                bool
                f_10433_35409_35443(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = expr.NullableNeverHasValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 35409, 35443);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_35447_35456(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 35447, 35456);
                    return return_v;
                }


                bool
                f_10433_35447_35481(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = expr.NullableAlwaysHasValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 35447, 35481);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10433_35537_35554(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 35537, 35554);
                    return return_v;
                }


                bool
                f_10433_35537_35570(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.IsUserDefined();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 35537, 35570);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_35657_35666(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 35657, 35666);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10433_35657_35671(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 35657, 35671);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10433_35657_35699(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 35657, 35699);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_35735_35745(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 35735, 35745);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10433_35701_35746(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = GetTypeForLiftedComparisonWarning(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 35701, 35746);
                    return return_v;
                }


                int
                f_10433_35531_35747(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 35531, 35747);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_35802_35811(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 35802, 35811);
                    return return_v;
                }


                bool
                f_10433_35802_35835(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = expr.NullableNeverHasValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 35802, 35835);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_35839_35849(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 35839, 35849);
                    return return_v;
                }


                bool
                f_10433_35839_35874(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = expr.NullableAlwaysHasValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 35839, 35874);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                f_10433_35930_35947(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.OperatorKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 35930, 35947);
                    return return_v;
                }


                bool
                f_10433_35930_35963(Microsoft.CodeAnalysis.CSharp.BinaryOperatorKind
                kind)
                {
                    var return_v = kind.IsUserDefined();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 35930, 35963);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_36050_36060(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 36050, 36060);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10433_36050_36065(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 36050, 36065);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10433_36050_36093(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                type)
                {
                    var return_v = type.GetNullableUnderlyingType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 36050, 36093);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_36129_36138(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 36129, 36138);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10433_36095_36139(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = GetTypeForLiftedComparisonWarning(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 36095, 36139);
                    return return_v;
                }


                int
                f_10433_35924_36140(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 35924, 36140);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_36402_36411(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 36402, 36411);
                    return return_v;
                }


                bool
                f_10433_36402_36435(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = expr.NullableNeverHasValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 36402, 36435);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_36439_36449(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 36439, 36449);
                    return return_v;
                }


                bool
                f_10433_36439_36472(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = expr.IsNullableNonBoolean();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 36439, 36472);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_36503_36512(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 36503, 36512);
                    return return_v;
                }


                bool
                f_10433_36503_36535(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = expr.IsNullableNonBoolean();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 36503, 36535);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_36539_36549(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 36539, 36549);
                    return return_v;
                }


                bool
                f_10433_36539_36573(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = expr.NullableNeverHasValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 36539, 36573);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10433_36639_36648(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 36639, 36648);
                    return return_v;
                }


                int
                f_10433_36601_36649(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 36601, 36649);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_36822_36832(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 36822, 36832);
                    return return_v;
                }


                bool
                f_10433_36822_36856(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = expr.NullableNeverHasValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 36822, 36856);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_36860_36869(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 36860, 36869);
                    return return_v;
                }


                bool
                f_10433_36860_36893(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = expr.NullableNeverHasValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 36860, 36893);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10433_36981_36990(Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 36981, 36990);
                    return return_v;
                }


                int
                f_10433_36943_36991(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundBinaryOperator
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 36943, 36991);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10433, 33641, 37069);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10433, 33641, 37069);
            }
        }

        private void CheckLiftedUserDefinedConditionalLogicalOperator(BoundUserDefinedConditionalLogicalOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10433, 37081, 37484);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 37300, 37473) || true) && (f_10433_37304_37338(f_10433_37304_37314(node)) || (DynAbs.Tracing.TraceSender.Expression_False(10433, 37304, 37375) || f_10433_37342_37375(f_10433_37342_37351(node))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 37300, 37473);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 37409, 37458);

                    f_10433_37409_37457(this, ErrorCode.WRN_AlwaysNull, node, f_10433_37447_37456(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 37300, 37473);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10433, 37081, 37484);

                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_37304_37314(Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 37304, 37314);
                    return return_v;
                }


                bool
                f_10433_37304_37338(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = expr.NullableNeverHasValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 37304, 37338);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_37342_37351(Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 37342, 37351);
                    return return_v;
                }


                bool
                f_10433_37342_37375(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr)
                {
                    var return_v = expr.NullableNeverHasValue();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 37342, 37375);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10433_37447_37456(Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 37447, 37456);
                    return return_v;
                }


                int
                f_10433_37409_37457(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundUserDefinedConditionalLogicalOperator
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 37409, 37457);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10433, 37081, 37484);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10433, 37081, 37484);
            }
        }

        private static TypeSymbol GetTypeForLiftedComparisonWarning(BoundExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10433, 37496, 38466);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 37869, 37990) || true) && ((object)f_10433_37881_37890(node) == null || (DynAbs.Tracing.TraceSender.Expression_False(10433, 37873, 37929) || !f_10433_37903_37929(f_10433_37903_37912(node))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 37869, 37990);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 37963, 37975);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 37869, 37990);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 38006, 38029);

                TypeSymbol
                type = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 38045, 38414) || true) && (f_10433_38049_38058(node) == BoundKind.Conversion)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 38045, 38414);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 38116, 38149);

                    var
                    conv = (BoundConversion)node
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 38167, 38399) || true) && (f_10433_38171_38190(conv) == ConversionKind.ExplicitNullable || (DynAbs.Tracing.TraceSender.Expression_False(10433, 38171, 38283) || f_10433_38229_38248(conv) == ConversionKind.ImplicitNullable))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 38167, 38399);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 38325, 38380);

                        type = f_10433_38332_38379(f_10433_38366_38378(conv));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 38167, 38399);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 38045, 38414);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 38430, 38455);

                return type ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?>(10433, 38437, 38454) ?? f_10433_38445_38454(node));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10433, 37496, 38466);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10433_37881_37890(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 37881, 37890);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10433_37903_37912(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 37903, 37912);
                    return return_v;
                }


                bool
                f_10433_37903_37929(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsNullableType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 37903, 37929);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10433_38049_38058(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 38049, 38058);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10433_38171_38190(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 38171, 38190);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10433_38229_38248(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 38229, 38248);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_38366_38378(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 38366, 38378);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10433_38332_38379(Microsoft.CodeAnalysis.CSharp.BoundExpression
                node)
                {
                    var return_v = GetTypeForLiftedComparisonWarning(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 38332, 38379);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10433_38445_38454(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 38445, 38454);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10433, 37496, 38466);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10433, 37496, 38466);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool CheckForAssignmentToSelf(BoundAssignmentOperator node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10433, 38478, 38798);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 38570, 38760) || true) && (f_10433_38574_38592_M(!node.HasAnyErrors) && (DynAbs.Tracing.TraceSender.Expression_True(10433, 38574, 38637) && f_10433_38596_38637(f_10433_38615_38624(node), f_10433_38626_38636(node))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 38570, 38760);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 38671, 38715);

                    f_10433_38671_38714(this, ErrorCode.WRN_AssignmentToSelf, node);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 38733, 38745);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 38570, 38760);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 38774, 38787);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10433, 38478, 38798);

                bool
                f_10433_38574_38592_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 38574, 38592);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_38615_38624(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 38615, 38624);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_38626_38636(Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 38626, 38636);
                    return return_v;
                }


                bool
                f_10433_38596_38637(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr1, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr2)
                {
                    var return_v = IsSameLocalOrField(expr1, expr2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 38596, 38637);
                    return return_v;
                }


                int
                f_10433_38671_38714(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundAssignmentOperator
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 38671, 38714);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10433, 38478, 38798);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10433, 38478, 38798);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CheckForDeconstructionAssignmentToSelf(BoundTupleExpression leftTuple, BoundExpression right)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10433, 38810, 40470);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 38941, 39480) || true) && (f_10433_38948_38958(right) == BoundKind.Conversion)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 38941, 39480);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 39016, 39056);

                        var
                        conversion = (BoundConversion)right
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 39074, 39465);

                        switch (f_10433_39082_39107(conversion))
                        {

                            case ConversionKind.Deconstruction:
                            case ConversionKind.ImplicitTupleLiteral:
                            case ConversionKind.Identity:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 39074, 39465);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 39324, 39351);

                                right = f_10433_39332_39350(conversion);
                                DynAbs.Tracing.TraceSender.TraceBreak(10433, 39377, 39383);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 39074, 39465);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 39074, 39465);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 39439, 39446);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 39074, 39465);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 38941, 39480);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10433, 38941, 39480);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10433, 38941, 39480);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 39496, 39641) || true) && (f_10433_39500_39510(right) != BoundKind.ConvertedTupleLiteral && (DynAbs.Tracing.TraceSender.Expression_True(10433, 39500, 39585) && f_10433_39549_39559(right) != BoundKind.TupleLiteral))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 39496, 39641);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 39619, 39626);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 39496, 39641);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 39657, 39702);

                var
                rightTuple = (BoundTupleExpression)right
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 39716, 39756);

                var
                leftArguments = f_10433_39736_39755(leftTuple)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 39770, 39804);

                int
                length = leftArguments.Length
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 39818, 39870);

                f_10433_39818_39869(length == rightTuple.Arguments.Length);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 39895, 39900);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 39886, 40459) || true) && (i < length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 39914, 39917)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 39886, 40459))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 39886, 40459);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 39951, 39987);

                        var
                        leftArgument = leftArguments[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 40005, 40049);

                        var
                        rightArgument = f_10433_40025_40045(rightTuple)[i]
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 40069, 40444) || true) && (leftArgument is BoundTupleExpression tupleExpression)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 40069, 40444);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 40167, 40238);

                            f_10433_40167_40237(this, tupleExpression, rightArgument);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 40069, 40444);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 40069, 40444);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 40280, 40444) || true) && (f_10433_40284_40331(leftArgument, rightArgument))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10433, 40280, 40444);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 40373, 40425);

                                f_10433_40373_40424(this, ErrorCode.WRN_AssignmentToSelf, leftArgument);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 40280, 40444);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10433, 40069, 40444);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10433, 1, 574);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10433, 1, 574);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10433, 38810, 40470);

                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10433_38948_38958(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 38948, 38958);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ConversionKind
                f_10433_39082_39107(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.ConversionKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 39082, 39107);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundExpression
                f_10433_39332_39350(Microsoft.CodeAnalysis.CSharp.BoundConversion
                this_param)
                {
                    var return_v = this_param.Operand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 39332, 39350);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10433_39500_39510(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 39500, 39510);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BoundKind
                f_10433_39549_39559(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 39549, 39559);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10433_39736_39755(Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 39736, 39755);
                    return return_v;
                }


                int
                f_10433_39818_39869(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 39818, 39869);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10433_40025_40045(Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 40025, 40045);
                    return return_v;
                }


                int
                f_10433_40167_40237(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundTupleExpression
                leftTuple, Microsoft.CodeAnalysis.CSharp.BoundExpression
                right)
                {
                    this_param.CheckForDeconstructionAssignmentToSelf(leftTuple, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 40167, 40237);
                    return 0;
                }


                bool
                f_10433_40284_40331(Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr1, Microsoft.CodeAnalysis.CSharp.BoundExpression
                expr2)
                {
                    var return_v = IsSameLocalOrField(expr1, expr2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 40284, 40331);
                    return return_v;
                }


                int
                f_10433_40373_40424(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.CSharp.BoundExpression
                node, params object[]
                args)
                {
                    this_param.Error(code, (Microsoft.CodeAnalysis.CSharp.BoundNode)node, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 40373, 40424);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10433, 38810, 40470);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10433, 38810, 40470);
            }
        }

        public override BoundNode VisitFieldAccess(BoundFieldAccess node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10433, 40482, 40671);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 40572, 40611);

                f_10433_40572_40610(this, f_10433_40593_40609(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 40625, 40660);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitFieldAccess(node), 10433, 40632, 40659);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10433, 40482, 40671);

                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10433_40593_40609(Microsoft.CodeAnalysis.CSharp.BoundFieldAccess
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 40593, 40609);
                    return return_v;
                }


                int
                f_10433_40572_40610(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt)
                {
                    this_param.CheckReceiverIfField(receiverOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 40572, 40610);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10433, 40482, 40671);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10433, 40482, 40671);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override BoundNode VisitPropertyGroup(BoundPropertyGroup node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10433, 40683, 40878);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 40777, 40816);

                f_10433_40777_40815(this, f_10433_40798_40814(node));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10433, 40830, 40867);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitPropertyGroup(node), 10433, 40837, 40866);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10433, 40683, 40878);

                Microsoft.CodeAnalysis.CSharp.BoundExpression?
                f_10433_40798_40814(Microsoft.CodeAnalysis.CSharp.BoundPropertyGroup
                this_param)
                {
                    var return_v = this_param.ReceiverOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10433, 40798, 40814);
                    return return_v;
                }


                int
                f_10433_40777_40815(Microsoft.CodeAnalysis.CSharp.DiagnosticsPass
                this_param, Microsoft.CodeAnalysis.CSharp.BoundExpression?
                receiverOpt)
                {
                    this_param.CheckReceiverIfField(receiverOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10433, 40777, 40815);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10433, 40683, 40878);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10433, 40683, 40878);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
