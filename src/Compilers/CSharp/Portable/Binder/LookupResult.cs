// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    /// <summary>
    /// represents one-to-one symbol -> SingleLookupResult filter.
    /// </summary>
    internal delegate SingleLookupResult LookupFilter(Symbol sym);
    internal sealed class LookupResult
    {
        private LookupResultKind _kind;

        private readonly ArrayBuilder<Symbol> _symbolList;

        private DiagnosticInfo _error;

        private readonly ObjectPool<LookupResult> _pool;

        private LookupResult(ObjectPool<LookupResult> pool)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10354, 3398, 3626);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 3068, 3073);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 3200, 3211);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 3319, 3325);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 3380, 3385);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 3474, 3487);

                _pool = pool;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 3501, 3532);

                _kind = LookupResultKind.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 3546, 3587);

                _symbolList = f_10354_3560_3586();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 3601, 3615);

                _error = null;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10354, 3398, 3626);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10354, 3398, 3626);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10354, 3398, 3626);
            }
        }

        internal bool IsClear
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10354, 3684, 3818);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 3720, 3803);

                    return _kind == LookupResultKind.Empty && (DynAbs.Tracing.TraceSender.Expression_True(10354, 3727, 3776) && _error == null) && (DynAbs.Tracing.TraceSender.Expression_True(10354, 3727, 3802) && f_10354_3780_3797(_symbolList) == 0);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10354, 3684, 3818);

                    int
                    f_10354_3780_3797(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10354, 3780, 3797);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10354, 3638, 3829);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10354, 3638, 3829);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal void Clear()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10354, 3841, 3991);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 3887, 3918);

                _kind = LookupResultKind.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 3932, 3952);

                f_10354_3932_3951(_symbolList);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 3966, 3980);

                _error = null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10354, 3841, 3991);

                int
                f_10354_3932_3951(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10354, 3932, 3951);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10354, 3841, 3991);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10354, 3841, 3991);
            }
        }

        internal LookupResultKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10354, 4058, 4122);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 4094, 4107);

                    return _kind;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10354, 4058, 4122);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10354, 4003, 4133);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10354, 4003, 4133);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Symbol SingleSymbolOrDefault
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10354, 4333, 4440);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 4369, 4425);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10354, 4376, 4400) || (((f_10354_4377_4394(_symbolList) == 1) && DynAbs.Tracing.TraceSender.Conditional_F2(10354, 4403, 4417)) || DynAbs.Tracing.TraceSender.Conditional_F3(10354, 4420, 4424))) ? f_10354_4403_4417(_symbolList, 0) : null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10354, 4333, 4440);

                    int
                    f_10354_4377_4394(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10354, 4377, 4394);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10354_4403_4417(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10354, 4403, 4417);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10354, 4271, 4451);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10354, 4271, 4451);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal ArrayBuilder<Symbol> Symbols
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10354, 4525, 4595);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 4561, 4580);

                    return _symbolList;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10354, 4525, 4595);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10354, 4463, 4606);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10354, 4463, 4606);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal DiagnosticInfo Error
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10354, 4672, 4737);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 4708, 4722);

                    return _error;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10354, 4672, 4737);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10354, 4618, 4748);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10354, 4618, 4748);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsMultiViable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10354, 4919, 5009);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 4955, 4994);

                    return f_10354_4962_4966() == LookupResultKind.Viable;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10354, 4919, 5009);

                    Microsoft.CodeAnalysis.CSharp.LookupResultKind
                    f_10354_4962_4966()
                    {
                        var return_v = Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10354, 4962, 4966);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10354, 4867, 5020);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10354, 4867, 5020);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsSingleViable
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10354, 5221, 5337);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 5257, 5322);

                    return f_10354_5264_5268() == LookupResultKind.Viable && (DynAbs.Tracing.TraceSender.Expression_True(10354, 5264, 5321) && f_10354_5299_5316(_symbolList) == 1);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10354, 5221, 5337);

                    Microsoft.CodeAnalysis.CSharp.LookupResultKind
                    f_10354_5264_5268()
                    {
                        var return_v = Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10354, 5264, 5268);
                        return return_v;
                    }


                    int
                    f_10354_5299_5316(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10354, 5299, 5316);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10354, 5168, 5348);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10354, 5168, 5348);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal static SingleLookupResult Good(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10354, 5360, 5519);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 5439, 5508);

                return f_10354_5446_5507(LookupResultKind.Viable, symbol, null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10354, 5360, 5519);

                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10354_5446_5507(Microsoft.CodeAnalysis.CSharp.LookupResultKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.DiagnosticInfo
                error)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SingleLookupResult(kind, symbol, error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10354, 5446, 5507);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10354, 5360, 5519);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10354, 5360, 5519);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SingleLookupResult WrongArity(Symbol symbol, DiagnosticInfo error)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10354, 5531, 5723);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 5638, 5712);

                return f_10354_5645_5711(LookupResultKind.WrongArity, symbol, error);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10354, 5531, 5723);

                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10354_5645_5711(Microsoft.CodeAnalysis.CSharp.LookupResultKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.DiagnosticInfo
                error)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SingleLookupResult(kind, symbol, error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10354, 5645, 5711);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10354, 5531, 5723);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10354, 5531, 5723);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SingleLookupResult Empty()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10354, 5735, 5879);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 5802, 5868);

                return f_10354_5809_5867(LookupResultKind.Empty, null, null);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10354, 5735, 5879);

                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10354_5809_5867(Microsoft.CodeAnalysis.CSharp.LookupResultKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.DiagnosticInfo
                error)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SingleLookupResult(kind, symbol, error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10354, 5809, 5867);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10354, 5735, 5879);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10354, 5735, 5879);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SingleLookupResult NotReferencable(Symbol symbol, DiagnosticInfo error)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10354, 5891, 6093);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 6003, 6082);

                return f_10354_6010_6081(LookupResultKind.NotReferencable, symbol, error);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10354, 5891, 6093);

                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10354_6010_6081(Microsoft.CodeAnalysis.CSharp.LookupResultKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.DiagnosticInfo
                error)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SingleLookupResult(kind, symbol, error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10354, 6010, 6081);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10354, 5891, 6093);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10354, 5891, 6093);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SingleLookupResult StaticInstanceMismatch(Symbol symbol, DiagnosticInfo error)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10354, 6105, 6321);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 6224, 6310);

                return f_10354_6231_6309(LookupResultKind.StaticInstanceMismatch, symbol, error);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10354, 6105, 6321);

                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10354_6231_6309(Microsoft.CodeAnalysis.CSharp.LookupResultKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.DiagnosticInfo
                error)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SingleLookupResult(kind, symbol, error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10354, 6231, 6309);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10354, 6105, 6321);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10354, 6105, 6321);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SingleLookupResult Inaccessible(Symbol symbol, DiagnosticInfo error)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10354, 6333, 6529);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 6442, 6518);

                return f_10354_6449_6517(LookupResultKind.Inaccessible, symbol, error);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10354, 6333, 6529);

                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10354_6449_6517(Microsoft.CodeAnalysis.CSharp.LookupResultKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.DiagnosticInfo
                error)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SingleLookupResult(kind, symbol, error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10354, 6449, 6517);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10354, 6333, 6529);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10354, 6333, 6529);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SingleLookupResult NotInvocable(Symbol unwrappedSymbol, Symbol symbol, bool diagnose)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10354, 6541, 6882);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 6667, 6778);

                var
                diagInfo = (DynAbs.Tracing.TraceSender.Conditional_F1(10354, 6682, 6690) || ((diagnose && DynAbs.Tracing.TraceSender.Conditional_F2(10354, 6693, 6770)) || DynAbs.Tracing.TraceSender.Conditional_F3(10354, 6773, 6777))) ? f_10354_6693_6770(ErrorCode.ERR_NonInvocableMemberCalled, unwrappedSymbol) : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 6792, 6871);

                return f_10354_6799_6870(LookupResultKind.NotInvocable, symbol, diagInfo);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10354, 6541, 6882);

                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10354_6693_6770(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10354, 6693, 6770);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10354_6799_6870(Microsoft.CodeAnalysis.CSharp.LookupResultKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo?
                error)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SingleLookupResult(kind, symbol, (Microsoft.CodeAnalysis.DiagnosticInfo?)error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10354, 6799, 6870);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10354, 6541, 6882);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10354, 6541, 6882);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SingleLookupResult NotLabel(Symbol symbol, DiagnosticInfo error)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10354, 6894, 7082);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 6999, 7071);

                return f_10354_7006_7070(LookupResultKind.NotLabel, symbol, error);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10354, 6894, 7082);

                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10354_7006_7070(Microsoft.CodeAnalysis.CSharp.LookupResultKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.DiagnosticInfo
                error)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SingleLookupResult(kind, symbol, error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10354, 7006, 7070);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10354, 6894, 7082);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10354, 6894, 7082);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SingleLookupResult NotTypeOrNamespace(Symbol symbol, DiagnosticInfo error)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10354, 7094, 7303);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 7209, 7292);

                return f_10354_7216_7291(LookupResultKind.NotATypeOrNamespace, symbol, error);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10354, 7094, 7303);

                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10354_7216_7291(Microsoft.CodeAnalysis.CSharp.LookupResultKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.DiagnosticInfo
                error)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SingleLookupResult(kind, symbol, error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10354, 7216, 7291);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10354, 7094, 7303);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10354, 7094, 7303);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SingleLookupResult NotTypeOrNamespace(Symbol unwrappedSymbol, Symbol symbol, bool diagnose)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10354, 7315, 7776);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 7498, 7665);

                var
                diagInfo = (DynAbs.Tracing.TraceSender.Conditional_F1(10354, 7513, 7521) || ((diagnose && DynAbs.Tracing.TraceSender.Conditional_F2(10354, 7524, 7657)) || DynAbs.Tracing.TraceSender.Conditional_F3(10354, 7660, 7664))) ? f_10354_7524_7657(ErrorCode.ERR_BadSKknown, f_10354_7571_7591(unwrappedSymbol), f_10354_7593_7622(unwrappedSymbol), f_10354_7624_7656(MessageID.IDS_SK_TYPE)) : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 7679, 7765);

                return f_10354_7686_7764(LookupResultKind.NotATypeOrNamespace, symbol, diagInfo);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10354, 7315, 7776);

                string
                f_10354_7571_7591(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10354, 7571, 7591);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10354_7593_7622(Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = symbol.GetKindText();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10354, 7593, 7622);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LocalizableErrorArgument
                f_10354_7624_7656(Microsoft.CodeAnalysis.CSharp.MessageID
                id)
                {
                    var return_v = id.Localize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10354, 7624, 7656);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10354_7524_7657(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10354, 7524, 7657);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10354_7686_7764(Microsoft.CodeAnalysis.CSharp.LookupResultKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo?
                error)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SingleLookupResult(kind, symbol, (Microsoft.CodeAnalysis.DiagnosticInfo?)error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10354, 7686, 7764);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10354, 7315, 7776);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10354, 7315, 7776);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SingleLookupResult NotAnAttributeType(Symbol symbol, DiagnosticInfo error)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10354, 7788, 7996);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 7903, 7985);

                return f_10354_7910_7984(LookupResultKind.NotAnAttributeType, symbol, error);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10354, 7788, 7996);

                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10354_7910_7984(Microsoft.CodeAnalysis.CSharp.LookupResultKind
                kind, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol, Microsoft.CodeAnalysis.DiagnosticInfo
                error)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.SingleLookupResult(kind, symbol, error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10354, 7910, 7984);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10354, 7788, 7996);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10354, 7788, 7996);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void SetFrom(SingleLookupResult other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10354, 8109, 8324);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 8181, 8200);

                _kind = other.Kind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 8214, 8234);

                f_10354_8214_8233(_symbolList);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 8248, 8278);

                f_10354_8248_8277(_symbolList, other.Symbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 8292, 8313);

                _error = other.Error;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10354, 8109, 8324);

                int
                f_10354_8214_8233(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10354, 8214, 8233);
                    return 0;
                }


                int
                f_10354_8248_8277(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10354, 8248, 8277);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10354, 8109, 8324);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10354, 8109, 8324);
            }
        }

        internal void SetFrom(LookupResult other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10354, 8437, 8658);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 8503, 8523);

                _kind = other._kind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 8537, 8557);

                f_10354_8537_8556(_symbolList);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 8571, 8611);

                f_10354_8571_8610(_symbolList, other._symbolList);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 8625, 8647);

                _error = other._error;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10354, 8437, 8658);

                int
                f_10354_8537_8556(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10354, 8537, 8556);
                    return 0;
                }


                int
                f_10354_8571_8610(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10354, 8571, 8610);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10354, 8437, 8658);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10354, 8437, 8658);
            }
        }

        internal void SetFrom(DiagnosticInfo error)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10354, 8670, 8791);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 8738, 8751);

                f_10354_8738_8750(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 8765, 8780);

                _error = error;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10354, 8670, 8791);

                int
                f_10354_8738_8750(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10354, 8738, 8750);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10354, 8670, 8791);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10354, 8670, 8791);
            }
        }

        internal void MergePrioritized(LookupResult other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10354, 8981, 9152);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 9056, 9141) || true) && (f_10354_9060_9070(other) > f_10354_9073_9077())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10354, 9056, 9141);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 9111, 9126);

                    f_10354_9111_9125(this, other);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10354, 9056, 9141);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10354, 8981, 9152);

                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10354_9060_9070(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10354, 9060, 9070);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10354_9073_9077()
                {
                    var return_v = Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10354, 9073, 9077);
                    return return_v;
                }


                int
                f_10354_9111_9125(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                other)
                {
                    this_param.SetFrom(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10354, 9111, 9125);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10354, 8981, 9152);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10354, 8981, 9152);
            }
        }

        internal void MergeEqual(LookupResult other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10354, 9432, 10180);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 9501, 10169) || true) && (f_10354_9505_9509() > f_10354_9512_9522(other))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10354, 9501, 10169);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 9556, 9563);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10354, 9501, 10169);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10354, 9501, 10169);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 9597, 10169) || true) && (f_10354_9601_9611(other) > f_10354_9614_9618())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10354, 9597, 10169);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 9652, 9672);

                        f_10354_9652_9671(this, other);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10354, 9597, 10169);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10354, 9597, 10169);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 9706, 10169) || true) && (f_10354_9710_9714() != LookupResultKind.Viable)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10354, 9706, 10169);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 9935, 9942);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10354, 9706, 10169);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10354, 9706, 10169);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 10114, 10154);

                            f_10354_10114_10153(                // Merging two viable results together. We will always end up with at least two symbols.
                                            _symbolList, other._symbolList);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10354, 9706, 10169);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10354, 9597, 10169);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10354, 9501, 10169);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10354, 9432, 10180);

                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10354_9505_9509()
                {
                    var return_v = Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10354, 9505, 9509);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10354_9512_9522(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10354, 9512, 9522);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10354_9601_9611(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10354, 9601, 9611);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10354_9614_9618()
                {
                    var return_v = Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10354, 9614, 9618);
                    return return_v;
                }


                int
                f_10354_9652_9671(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                other)
                {
                    this_param.SetFrom(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10354, 9652, 9671);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10354_9710_9714()
                {
                    var return_v = Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10354, 9710, 9714);
                    return return_v;
                }


                int
                f_10354_10114_10153(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                items)
                {
                    this_param.AddRange(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10354, 10114, 10153);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10354, 9432, 10180);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10354, 9432, 10180);
            }
        }

        internal void MergeEqual(SingleLookupResult result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10354, 10192, 10676);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 10268, 10665) || true) && (f_10354_10272_10276() > result.Kind)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10354, 10268, 10665);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10354, 10268, 10665);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10354, 10268, 10665);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 10386, 10665) || true) && (result.Kind > f_10354_10404_10408())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10354, 10386, 10665);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 10442, 10463);

                        f_10354_10442_10462(this, result);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10354, 10386, 10665);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10354, 10386, 10665);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 10497, 10665) || true) && ((object)result.Symbol != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10354, 10497, 10665);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 10619, 10650);

                            f_10354_10619_10649(                // Same goodness. Include all symbols
                                            _symbolList, result.Symbol);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10354, 10497, 10665);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10354, 10386, 10665);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10354, 10268, 10665);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10354, 10192, 10676);

                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10354_10272_10276()
                {
                    var return_v = Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10354, 10272, 10276);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.LookupResultKind
                f_10354_10404_10408()
                {
                    var return_v = Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10354, 10404, 10408);
                    return return_v;
                }


                int
                f_10354_10442_10462(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param, Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                other)
                {
                    this_param.SetFrom(other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10354, 10442, 10462);
                    return 0;
                }


                int
                f_10354_10619_10649(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10354, 10619, 10649);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10354, 10192, 10676);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10354, 10192, 10676);
            }
        }

        private static readonly ObjectPool<LookupResult> s_poolInstance;

        internal static ObjectPool<LookupResult> CreatePool()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10354, 10897, 11165);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 10975, 11012);

                ObjectPool<LookupResult>
                pool = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 11026, 11097);

                pool = f_10354_11033_11096(() => new LookupResult(pool), 128);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 11142, 11154);

                return pool;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10354, 10897, 11165);

                Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.LookupResult>
                f_10354_11033_11096(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.LookupResult>.Factory
                factory, int
                size)
                {
                    var return_v = new Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.LookupResult>(factory, size);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10354, 11033, 11096);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10354, 10897, 11165);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10354, 10897, 11165);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static LookupResult GetInstance()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10354, 11177, 11371);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 11244, 11285);

                var
                instance = f_10354_11259_11284(s_poolInstance)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 11299, 11330);

                f_10354_11299_11329(f_10354_11312_11328(instance));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 11344, 11360);

                return instance;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10354, 11177, 11371);

                Microsoft.CodeAnalysis.CSharp.LookupResult
                f_10354_11259_11284(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.LookupResult>
                this_param)
                {
                    var return_v = this_param.Allocate();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10354, 11259, 11284);
                    return return_v;
                }


                bool
                f_10354_11312_11328(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.IsClear;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10354, 11312, 11328);
                    return return_v;
                }


                int
                f_10354_11299_11329(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10354, 11299, 11329);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10354, 11177, 11371);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10354, 11177, 11371);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void Free()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10354, 11383, 11549);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 11428, 11441);

                f_10354_11428_11440(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 11455, 11538) || true) && (_pool != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10354, 11455, 11538);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 11506, 11523);

                    f_10354_11506_11522(_pool, this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10354, 11455, 11538);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10354, 11383, 11549);

                int
                f_10354_11428_11440(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10354, 11428, 11440);
                    return 0;
                }


                int
                f_10354_11506_11522(Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.LookupResult>
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                obj)
                {
                    this_param.Free(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10354, 11506, 11522);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10354, 11383, 11549);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10354, 11383, 11549);
            }
        }

        static LookupResult()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10354, 2960, 11556);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10354, 10809, 10838);
            s_poolInstance = f_10354_10826_10838(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10354, 2960, 11556);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10354, 2960, 11556);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10354, 2960, 11556);

        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
        f_10354_3560_3586()
        {
            var return_v = new Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10354, 3560, 3586);
            return return_v;
        }


        static Microsoft.CodeAnalysis.PooledObjects.ObjectPool<Microsoft.CodeAnalysis.CSharp.LookupResult>
        f_10354_10826_10838()
        {
            var return_v = CreatePool();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10354, 10826, 10838);
            return return_v;
        }

    }
}
