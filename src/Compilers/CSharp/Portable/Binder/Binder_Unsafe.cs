// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal partial class Binder
    {
        internal bool InUnsafeRegion
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10321, 819, 880);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10321, 825, 878);

                    return f_10321_832_877(this.Flags, BinderFlags.UnsafeRegion);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10321, 819, 880);

                    bool
                    f_10321_832_877(Microsoft.CodeAnalysis.CSharp.BinderFlags
                    self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                    other)
                    {
                        var return_v = self.Includes(other);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10321, 832, 877);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10321, 766, 891);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10321, 766, 891);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool ReportUnsafeIfNotAllowed(SyntaxNode node, DiagnosticBag diagnostics, TypeSymbol sizeOfTypeOpt = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10321, 969, 1550);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10321, 1109, 1256);

                f_10321_1109_1255((f_10321_1123_1134(node) == SyntaxKind.SizeOfExpression) == ((object)sizeOfTypeOpt != null), "Should have a type for (only) sizeof expressions.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10321, 1270, 1330);

                var
                diagnosticInfo = f_10321_1291_1329(this, sizeOfTypeOpt)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10321, 1344, 1432) || true) && (diagnosticInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10321, 1344, 1432);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10321, 1404, 1417);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10321, 1344, 1432);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10321, 1448, 1513);

                f_10321_1448_1512(
                            diagnostics, f_10321_1464_1511(diagnosticInfo, f_10321_1497_1510(node)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10321, 1527, 1539);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10321, 969, 1550);

                Microsoft.CodeAnalysis.CSharp.SyntaxKind
                f_10321_1123_1134(Microsoft.CodeAnalysis.SyntaxNode
                node)
                {
                    var return_v = node.Kind();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10321, 1123, 1134);
                    return return_v;
                }


                int
                f_10321_1109_1255(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10321, 1109, 1255);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10321_1291_1329(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                sizeOfTypeOpt)
                {
                    var return_v = this_param.GetUnsafeDiagnosticInfo(sizeOfTypeOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10321, 1291, 1329);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10321_1497_1510(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10321, 1497, 1510);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10321_1464_1511(Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10321, 1464, 1511);
                    return return_v;
                }


                int
                f_10321_1448_1512(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                diag)
                {
                    this_param.Add((Microsoft.CodeAnalysis.Diagnostic)diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10321, 1448, 1512);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10321, 969, 1550);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10321, 969, 1550);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool ReportUnsafeIfNotAllowed(Location location, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10321, 1628, 2018);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10321, 1737, 1803);

                var
                diagnosticInfo = f_10321_1758_1802(this, sizeOfTypeOpt: null)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10321, 1817, 1905) || true) && (diagnosticInfo == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10321, 1817, 1905);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10321, 1877, 1890);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10321, 1817, 1905);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10321, 1921, 1981);

                f_10321_1921_1980(
                            diagnostics, f_10321_1937_1979(diagnosticInfo, location));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10321, 1995, 2007);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10321, 1628, 2018);

                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10321_1758_1802(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                sizeOfTypeOpt)
                {
                    var return_v = this_param.GetUnsafeDiagnosticInfo(sizeOfTypeOpt: sizeOfTypeOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10321, 1758, 1802);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10321_1937_1979(Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10321, 1937, 1979);
                    return return_v;
                }


                int
                f_10321_1921_1980(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                diag)
                {
                    this_param.Add((Microsoft.CodeAnalysis.Diagnostic)diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10321, 1921, 1980);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10321, 1628, 2018);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10321, 1628, 2018);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CSDiagnosticInfo GetUnsafeDiagnosticInfo(TypeSymbol sizeOfTypeOpt)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10321, 2030, 2951);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10321, 2129, 2940) || true) && (f_10321_2133_2191(this.Flags, BinderFlags.SuppressUnsafeDiagnostics))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10321, 2129, 2940);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10321, 2225, 2237);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10321, 2129, 2940);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10321, 2129, 2940);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10321, 2271, 2940) || true) && (f_10321_2275_2302(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10321, 2271, 2940);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10321, 2495, 2557);

                        return f_10321_2502_2556(ErrorCode.ERR_IllegalInnerUnsafe);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10321, 2271, 2940);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10321, 2271, 2940);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10321, 2591, 2940) || true) && (f_10321_2595_2615_M(!this.InUnsafeRegion))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10321, 2591, 2940);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10321, 2649, 2847);

                            return (DynAbs.Tracing.TraceSender.Conditional_F1(10321, 2656, 2687) || ((((object)sizeOfTypeOpt == null)
                            && DynAbs.Tracing.TraceSender.Conditional_F2(10321, 2711, 2759)) || DynAbs.Tracing.TraceSender.Conditional_F3(10321, 2783, 2846))) ? f_10321_2711_2759(ErrorCode.ERR_UnsafeNeeded) : f_10321_2783_2846(ErrorCode.ERR_SizeofUnsafe, sizeOfTypeOpt);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10321, 2591, 2940);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10321, 2591, 2940);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10321, 2913, 2925);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10321, 2591, 2940);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10321, 2271, 2940);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10321, 2129, 2940);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10321, 2030, 2951);

                bool
                f_10321_2133_2191(Microsoft.CodeAnalysis.CSharp.BinderFlags
                self, Microsoft.CodeAnalysis.CSharp.BinderFlags
                other)
                {
                    var return_v = self.Includes(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10321, 2133, 2191);
                    return return_v;
                }


                bool
                f_10321_2275_2302(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.IsIndirectlyInIterator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10321, 2275, 2302);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10321_2502_2556(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10321, 2502, 2556);
                    return return_v;
                }


                bool
                f_10321_2595_2615_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10321, 2595, 2615);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10321_2711_2759(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10321, 2711, 2759);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10321_2783_2846(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10321, 2783, 2846);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10321, 2030, 2951);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10321, 2030, 2951);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
