// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal abstract class WithTypeParametersBinder : Binder
    {
        internal WithTypeParametersBinder(Binder next)
        : base(f_10382_553_557_C(next))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10382, 486, 580);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10382, 486, 580);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10382, 486, 580);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10382, 486, 580);
            }
        }

        protected abstract MultiDictionary<string, TypeParameterSymbol> TypeParameterMap { get; }

        protected virtual LookupOptions LookupMask
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10382, 913, 1046);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10382, 949, 1031);

                    return LookupOptions.NamespaceAliasesOnly | LookupOptions.MustBeInvocableIfMember;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10382, 913, 1046);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10382, 846, 1057);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10382, 846, 1057);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected bool CanConsiderTypeParameters(LookupOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10382, 1069, 1263);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10382, 1157, 1252);

                return (options & (f_10382_1176_1186() | LookupOptions.MustBeInstance | LookupOptions.LabelsOnly)) == 0;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10382, 1069, 1263);

                Microsoft.CodeAnalysis.CSharp.LookupOptions
                f_10382_1176_1186()
                {
                    var return_v = LookupMask;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10382, 1176, 1186);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10382, 1069, 1263);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10382, 1069, 1263);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void LookupSymbolsInSingleBinder(
                    LookupResult result, string name, int arity, ConsList<TypeSymbol> basesBeingResolved, LookupOptions options, Binder originalBinder, bool diagnose, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10382, 1275, 1939);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10382, 1559, 1588);

                f_10382_1559_1587(f_10382_1572_1586(result));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10382, 1604, 1691) || true) && ((options & f_10382_1619_1629()) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10382, 1604, 1691);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10382, 1669, 1676);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10382, 1604, 1691);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10382, 1707, 1928);
                    foreach (var typeParameter in f_10382_1737_1759_I(f_10382_1737_1759(f_10382_1737_1753(), name)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10382, 1707, 1928);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10382, 1793, 1913);

                        f_10382_1793_1912(result, f_10382_1811_1911(originalBinder, typeParameter, arity, options, null, diagnose, ref useSiteDiagnostics));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10382, 1707, 1928);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10382, 1, 222);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10382, 1, 222);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10382, 1275, 1939);

                bool
                f_10382_1572_1586(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param)
                {
                    var return_v = this_param.IsClear;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10382, 1572, 1586);
                    return return_v;
                }


                int
                f_10382_1559_1587(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10382, 1559, 1587);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.LookupOptions
                f_10382_1619_1629()
                {
                    var return_v = LookupMask;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10382, 1619, 1629);
                    return return_v;
                }


                Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                f_10382_1737_1753()
                {
                    var return_v = TypeParameterMap;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10382, 1737, 1753);
                    return return_v;
                }


                Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>.ValueSet
                f_10382_1737_1759(Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10382, 1737, 1759);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                f_10382_1811_1911(Microsoft.CodeAnalysis.CSharp.Binder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                symbol, int
                arity, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                accessThroughType, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    var return_v = this_param.CheckViability((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, arity, options, accessThroughType, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10382, 1811, 1911);
                    return return_v;
                }


                int
                f_10382_1793_1912(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param, Microsoft.CodeAnalysis.CSharp.SingleLookupResult
                result)
                {
                    this_param.MergeEqual(result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10382, 1793, 1912);
                    return 0;
                }


                Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>.ValueSet
                f_10382_1737_1759_I(Roslyn.Utilities.MultiDictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>.ValueSet
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10382, 1737, 1759);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10382, 1275, 1939);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10382, 1275, 1939);
            }
        }

        static WithTypeParametersBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10382, 412, 1946);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10382, 412, 1946);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10382, 412, 1946);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10382, 412, 1946);

        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10382_553_557_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10382, 486, 580);
            return return_v;
        }

    }
}
