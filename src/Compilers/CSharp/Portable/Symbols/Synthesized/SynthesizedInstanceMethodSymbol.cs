// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Immutable;
using System.Diagnostics;
using System.Threading;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class SynthesizedInstanceMethodSymbol : MethodSymbol
    {
        private ParameterSymbol _lazyThisParameter;

        public override ImmutableArray<SyntaxReference> DeclaringSyntaxReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10682, 754, 850);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10682, 790, 835);

                    return ImmutableArray<SyntaxReference>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10682, 754, 850);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10682, 656, 861);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10682, 656, 861);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsImplicitlyDeclared
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10682, 946, 1009);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10682, 982, 994);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10682, 946, 1009);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10682, 873, 1020);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10682, 873, 1020);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool AreLocalsZeroed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10682, 1100, 1189);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10682, 1136, 1174);

                    return f_10682_1143_1173(f_10682_1143_1157());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10682, 1100, 1189);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10682_1143_1157()
                    {
                        var return_v = ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10682, 1143, 1157);
                        return return_v;
                    }


                    bool
                    f_10682_1143_1173(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.AreLocalsZeroed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10682, 1143, 1173);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10682, 1032, 1200);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10682, 1032, 1200);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool TryGetThisParameter(out ParameterSymbol thisParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10682, 1212, 1618);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10682, 1314, 1338);

                f_10682_1314_1337(f_10682_1327_1336_M(!IsStatic));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10682, 1354, 1530) || true) && ((object)_lazyThisParameter == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10682, 1354, 1530);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10682, 1426, 1515);

                    f_10682_1426_1514(ref _lazyThisParameter, f_10682_1478_1507(this), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10682, 1354, 1530);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10682, 1546, 1581);

                thisParameter = _lazyThisParameter;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10682, 1595, 1607);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10682, 1212, 1618);

                bool
                f_10682_1327_1336_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10682, 1327, 1336);
                    return return_v;
                }


                int
                f_10682_1314_1337(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10682, 1314, 1337);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ThisParameterSymbol
                f_10682_1478_1507(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInstanceMethodSymbol
                forMethod)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ThisParameterSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)forMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10682, 1478, 1507);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol?
                f_10682_1426_1514(ref Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol?
                location1, Microsoft.CodeAnalysis.CSharp.Symbols.ThisParameterSymbol
                value, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, (Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol)value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10682, 1426, 1514);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10682, 1212, 1618);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10682, 1212, 1618);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override ObsoleteAttributeData ObsoleteAttributeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10682, 1991, 2011);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10682, 1997, 2009);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10682, 1991, 2011);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10682, 1898, 2022);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10682, 1898, 2022);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override UnmanagedCallersOnlyAttributeData GetUnmanagedCallersOnlyAttributeData(bool forceComplete)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10682, 2150, 2157);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10682, 2153, 2157);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10682, 2150, 2157);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10682, 2150, 2157);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10682, 2150, 2157);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override int CalculateLocalSyntaxOffset(int localPosition, SyntaxTree localTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10682, 2170, 2332);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10682, 2284, 2321);

                throw f_10682_2290_2320();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10682, 2170, 2332);

                System.Exception
                f_10682_2290_2320()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10682, 2290, 2320);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10682, 2170, 2332);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10682, 2170, 2332);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsDeclaredReadOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10682, 2386, 2394);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10682, 2389, 2394);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10682, 2386, 2394);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10682, 2386, 2394);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10682, 2386, 2394);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsInitOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10682, 2441, 2449);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10682, 2444, 2449);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10682, 2441, 2449);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10682, 2441, 2449);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10682, 2441, 2449);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override FlowAnalysisAnnotations FlowAnalysisAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10682, 2533, 2564);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10682, 2536, 2564);
                    return FlowAnalysisAnnotations.None; DynAbs.Tracing.TraceSender.TraceExitMethod(10682, 2533, 2564);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10682, 2533, 2564);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10682, 2533, 2564);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsNullableAnalysisEnabled()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10682, 2628, 2636);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10682, 2631, 2636);
                return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10682, 2628, 2636);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10682, 2628, 2636);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10682, 2628, 2636);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public SynthesizedInstanceMethodSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(10682, 514, 2644);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10682, 625, 643);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(10682, 514, 2644);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10682, 514, 2644);
        }


        static SynthesizedInstanceMethodSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10682, 514, 2644);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10682, 514, 2644);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10682, 514, 2644);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10682, 514, 2644);
    }
}
