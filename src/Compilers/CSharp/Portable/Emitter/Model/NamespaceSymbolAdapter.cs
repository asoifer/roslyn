// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal partial class
            NamespaceSymbolAdapter : SymbolAdapter,
            Cci.INamespace
    {
        Cci.INamespace Cci.INamespace.ContainingNamespace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10199, 528, 590);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10199, 531, 590);
                    return f_10199_531_590_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10199_531_573(f_10199_531_553()), 10199, 531, 590)?.GetCciAdapter()); DynAbs.Tracing.TraceSender.TraceExitMethod(10199, 528, 590);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10199, 528, 590);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10199, 528, 590);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        string Cci.INamedEntity.Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10199, 632, 670);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10199, 635, 670);
                    return f_10199_635_670(f_10199_635_657()); DynAbs.Tracing.TraceSender.TraceExitMethod(10199, 632, 670);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10199, 632, 670);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10199, 632, 670);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        CodeAnalysis.Symbols.INamespaceSymbolInternal Cci.INamespace.GetInternalSymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10199, 764, 789);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10199, 767, 789);
                return f_10199_767_789(); DynAbs.Tracing.TraceSender.TraceExitMethod(10199, 764, 789);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10199, 764, 789);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10199, 764, 789);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
            f_10199_767_789()
            {
                var return_v = AdaptedNamespaceSymbol;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10199, 767, 789);
                return return_v;
            }

        }

        static NamespaceSymbolAdapter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10199, 312, 797);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10199, 312, 797);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10199, 312, 797);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10199, 312, 797);

        Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
        f_10199_531_553()
        {
            var return_v = AdaptedNamespaceSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10199, 531, 553);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
        f_10199_531_573(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
        this_param)
        {
            var return_v = this_param.ContainingNamespace;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10199, 531, 573);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbolAdapter?
        f_10199_531_590_I(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbolAdapter?
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10199, 531, 590);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
        f_10199_635_657()
        {
            var return_v = AdaptedNamespaceSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10199, 635, 657);
            return return_v;
        }


        string
        f_10199_635_670(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
        this_param)
        {
            var return_v = this_param.MetadataName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10199, 635, 670);
            return return_v;
        }

    }
    internal partial class NamespaceSymbol
    {
        private NamespaceSymbolAdapter _lazyAdapter;

        protected sealed override SymbolAdapter GetCciAdapterImpl()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10199, 987, 1005);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10199, 990, 1005);
                return f_10199_990_1005(this); DynAbs.Tracing.TraceSender.TraceExitMethod(10199, 987, 1005);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10199, 987, 1005);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10199, 987, 1005);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbolAdapter
            f_10199_990_1005(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
            this_param)
            {
                var return_v = this_param.GetCciAdapter();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10199, 990, 1005);
                return return_v;
            }

        }

        internal new NamespaceSymbolAdapter GetCciAdapter()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10199, 1016, 1304);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10199, 1092, 1257) || true) && (_lazyAdapter is null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10199, 1092, 1257);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10199, 1150, 1242);

                    return f_10199_1157_1241(ref _lazyAdapter, f_10199_1208_1240(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10199, 1092, 1257);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10199, 1273, 1293);

                return _lazyAdapter;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10199, 1016, 1304);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbolAdapter
                f_10199_1208_1240(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                underlyingNamespaceSymbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbolAdapter(underlyingNamespaceSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10199, 1208, 1240);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbolAdapter
                f_10199_1157_1241(ref Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbolAdapter?
                target, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbolAdapter
                value)
                {
                    var return_v = InterlockedOperations.Initialize(ref target, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10199, 1157, 1241);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10199, 1016, 1304);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10199, 1016, 1304);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static NamespaceSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10199, 805, 1497);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10199, 805, 1497);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10199, 805, 1497);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10199, 805, 1497);
    }
    internal partial class NamespaceSymbolAdapter
    {
        internal NamespaceSymbolAdapter(NamespaceSymbol underlyingNamespaceSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10199, 1578, 1739);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10199, 1833, 1889);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10199, 1677, 1728);

                AdaptedNamespaceSymbol = underlyingNamespaceSymbol;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10199, 1578, 1739);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10199, 1578, 1739);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10199, 1578, 1739);
            }
        }

        internal sealed override Symbol AdaptedSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10199, 1797, 1822);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10199, 1800, 1822);
                    return f_10199_1800_1822(); DynAbs.Tracing.TraceSender.TraceExitMethod(10199, 1797, 1822);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10199, 1797, 1822);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10199, 1797, 1822);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal NamespaceSymbol AdaptedNamespaceSymbol { get; }

        Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
        f_10199_1800_1822()
        {
            var return_v = AdaptedNamespaceSymbol;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10199, 1800, 1822);
            return return_v;
        }

    }
}
