// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class HostObjectModelBinder : Binder
    {
        public HostObjectModelBinder(Binder next)
        : base(f_10342_580_584_C(next))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10342, 518, 607);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10342, 518, 607);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10342, 518, 607);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10342, 518, 607);
            }
        }

        private TypeSymbol GetHostObjectType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10342, 619, 938);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10342, 682, 745);

                TypeSymbol
                result = f_10342_702_744(f_10342_702_718(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10342, 860, 897);

                f_10342_860_896((object)result != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10342, 913, 927);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10342, 619, 938);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10342_702_718(Microsoft.CodeAnalysis.CSharp.HostObjectModelBinder
                this_param)
                {
                    var return_v = this_param.Compilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10342, 702, 718);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10342_702_744(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GetHostObjectTypeSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10342, 702, 744);
                    return return_v;
                }


                int
                f_10342_860_896(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10342, 860, 896);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10342, 619, 938);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10342, 619, 938);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void LookupSymbolsInSingleBinder(
                    LookupResult result, string name, int arity, ConsList<TypeSymbol> basesBeingResolved, LookupOptions options, Binder originalBinder, bool diagnose, ref HashSet<DiagnosticInfo> useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10342, 950, 2076);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10342, 1234, 1275);

                var
                hostObjectType = f_10342_1255_1274(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10342, 1289, 2065) || true) && (f_10342_1293_1312(hostObjectType) == SymbolKind.ErrorType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10342, 1289, 2065);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10342, 1492, 1846);

                    f_10342_1492_1845(                // The name '{0}' does not exist in the current context (are you missing a reference to assembly '{1}'?)
                                    result, f_10342_1507_1844(ErrorCode.ERR_NameNotInContextPossibleMissingReference, new object[] { name, f_10342_1648_1719(f_10342_1648_1710(((MissingMetadataTypeSymbol)hostObjectType))) }, ImmutableArray<Symbol>.Empty, ImmutableArray<Location>.Empty));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10342, 1289, 2065);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10342, 1289, 2065);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10342, 1912, 2050);

                    f_10342_1912_2049(this, result, hostObjectType, name, arity, basesBeingResolved, options, originalBinder, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10342, 1289, 2065);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10342, 950, 2076);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10342_1255_1274(Microsoft.CodeAnalysis.CSharp.HostObjectModelBinder
                this_param)
                {
                    var return_v = this_param.GetHostObjectType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10342, 1255, 1274);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10342_1293_1312(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10342, 1293, 1312);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10342_1648_1710(Microsoft.CodeAnalysis.CSharp.Symbols.MissingMetadataTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10342, 1648, 1710);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_10342_1648_1719(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10342, 1648, 1719);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10342_1507_1844(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, object[]
                args, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                symbols, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                additionalLocations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args, symbols, additionalLocations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10342, 1507, 1844);
                    return return_v;
                }


                int
                f_10342_1492_1845(Microsoft.CodeAnalysis.CSharp.LookupResult
                this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                error)
                {
                    this_param.SetFrom((Microsoft.CodeAnalysis.DiagnosticInfo)error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10342, 1492, 1845);
                    return 0;
                }


                int
                f_10342_1912_2049(Microsoft.CodeAnalysis.CSharp.HostObjectModelBinder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupResult
                result, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                nsOrType, string
                name, int
                arity, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                basesBeingResolved, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder, bool
                diagnose, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.DiagnosticInfo>
                useSiteDiagnostics)
                {
                    this_param.LookupMembersInternal(result, (Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)nsOrType, name, arity, basesBeingResolved, options, originalBinder, diagnose, ref useSiteDiagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10342, 1912, 2049);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10342, 950, 2076);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10342, 950, 2076);
            }
        }

        protected override void AddLookupSymbolsInfoInSingleBinder(LookupSymbolsInfo result, LookupOptions options, Binder originalBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10342, 2088, 2481);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10342, 2243, 2284);

                var
                hostObjectType = f_10342_2264_2283(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10342, 2298, 2470) || true) && (f_10342_2302_2321(hostObjectType) != SymbolKind.ErrorType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10342, 2298, 2470);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10342, 2379, 2455);

                    f_10342_2379_2454(this, result, hostObjectType, options, originalBinder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10342, 2298, 2470);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10342, 2088, 2481);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10342_2264_2283(Microsoft.CodeAnalysis.CSharp.HostObjectModelBinder
                this_param)
                {
                    var return_v = this_param.GetHostObjectType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10342, 2264, 2283);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10342_2302_2321(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10342, 2302, 2321);
                    return return_v;
                }


                int
                f_10342_2379_2454(Microsoft.CodeAnalysis.CSharp.HostObjectModelBinder
                this_param, Microsoft.CodeAnalysis.CSharp.LookupSymbolsInfo
                result, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                nsOrType, Microsoft.CodeAnalysis.CSharp.LookupOptions
                options, Microsoft.CodeAnalysis.CSharp.Binder
                originalBinder)
                {
                    this_param.AddMemberLookupSymbolsInfo(result, (Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)nsOrType, options, originalBinder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10342, 2379, 2454);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10342, 2088, 2481);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10342, 2088, 2481);
            }
        }

        static HostObjectModelBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10342, 449, 2488);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10342, 449, 2488);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10342, 449, 2488);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10342, 449, 2488);

        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10342_580_584_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10342, 518, 607);
            return return_v;
        }

    }
}
