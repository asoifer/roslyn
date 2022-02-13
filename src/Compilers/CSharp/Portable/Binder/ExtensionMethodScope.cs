// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

namespace Microsoft.CodeAnalysis.CSharp
{

    internal struct ExtensionMethodScope
    {

        public readonly Binder Binder;

        public readonly bool SearchUsingsNotNamespace;

        public ExtensionMethodScope(Binder binder, bool searchUsingsNotNamespace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10337, 737, 938);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10337, 835, 856);

                this.Binder = binder;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10337, 870, 927);

                this.SearchUsingsNotNamespace = searchUsingsNotNamespace;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10337, 737, 938);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10337, 737, 938);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10337, 737, 938);
            }
        }
        static ExtensionMethodScope()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10337, 586, 945);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10337, 586, 945);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10337, 586, 945);
        }
    }

    internal struct ExtensionMethodScopes
    {

        private readonly Binder _binder;

        public ExtensionMethodScopes(Binder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10337, 1232, 1328);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10337, 1300, 1317);

                _binder = binder;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10337, 1232, 1328);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10337, 1232, 1328);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10337, 1232, 1328);
            }
        }

        public ExtensionMethodScopeEnumerator GetEnumerator()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10337, 1340, 1480);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10337, 1418, 1469);

                return f_10337_1425_1468(_binder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10337, 1340, 1480);

                Microsoft.CodeAnalysis.CSharp.ExtensionMethodScopeEnumerator
                f_10337_1425_1468(Microsoft.CodeAnalysis.CSharp.Binder
                binder)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ExtensionMethodScopeEnumerator(binder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10337, 1425, 1468);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10337, 1340, 1480);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10337, 1340, 1480);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static ExtensionMethodScopes()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10337, 1134, 1487);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10337, 1134, 1487);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10337, 1134, 1487);
        }
    }

    internal struct ExtensionMethodScopeEnumerator
    {

        private readonly Binder _binder;

        private ExtensionMethodScope _current;

        public ExtensionMethodScopeEnumerator(Binder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10337, 1740, 1897);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10337, 1817, 1834);

                _binder = binder;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10337, 1848, 1886);

                _current = f_10337_1859_1885();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10337, 1740, 1897);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10337, 1740, 1897);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10337, 1740, 1897);
            }
        }

        public ExtensionMethodScope Current
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10337, 1969, 1993);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10337, 1975, 1991);

                    return _current;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10337, 1969, 1993);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10337, 1909, 2004);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10337, 1909, 2004);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool MoveNext()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10337, 2016, 2895);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10337, 2063, 2835) || true) && (_current.Binder == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10337, 2063, 2835);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10337, 2124, 2157);

                    _current = GetNextScope(_binder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10337, 2063, 2835);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10337, 2063, 2835);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10337, 2223, 2252);

                    var
                    binder = _current.Binder
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10337, 2270, 2820) || true) && (!_current.SearchUsingsNotNamespace)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10337, 2270, 2820);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10337, 2514, 2590);

                        _current = f_10337_2525_2589(binder, searchUsingsNotNamespace: true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10337, 2270, 2820);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10337, 2270, 2820);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10337, 2764, 2801);

                        _current = GetNextScope(f_10337_2788_2799(binder));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10337, 2270, 2820);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10337, 2063, 2835);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10337, 2851, 2884);

                return (_current.Binder != null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10337, 2016, 2895);

                Microsoft.CodeAnalysis.CSharp.ExtensionMethodScope
                f_10337_2525_2589(Microsoft.CodeAnalysis.CSharp.Binder
                binder, bool
                searchUsingsNotNamespace)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ExtensionMethodScope(binder, searchUsingsNotNamespace: searchUsingsNotNamespace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10337, 2525, 2589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10337_2788_2799(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10337, 2788, 2799);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10337, 2016, 2895);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10337, 2016, 2895);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ExtensionMethodScope GetNextScope(Binder binder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10337, 2907, 3330);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10337, 3004, 3018);
                    for (var
        scope = binder
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10337, 2995, 3269) || true) && (scope != null)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10337, 3035, 3053)
        , scope = f_10337_3043_3053(scope), DynAbs.Tracing.TraceSender.TraceExitCondition(10337, 2995, 3269))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10337, 2995, 3269);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10337, 3087, 3254) || true) && (f_10337_3091_3121(scope))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10337, 3087, 3254);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10337, 3163, 3235);

                            return f_10337_3170_3234(scope, searchUsingsNotNamespace: false);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10337, 3087, 3254);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10337, 1, 275);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10337, 1, 275);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10337, 3285, 3319);

                return f_10337_3292_3318();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10337, 2907, 3330);

                Microsoft.CodeAnalysis.CSharp.Binder?
                f_10337_3043_3053(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.Next;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10337, 3043, 3053);
                    return return_v;
                }


                bool
                f_10337_3091_3121(Microsoft.CodeAnalysis.CSharp.Binder
                this_param)
                {
                    var return_v = this_param.SupportsExtensionMethods;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10337, 3091, 3121);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ExtensionMethodScope
                f_10337_3170_3234(Microsoft.CodeAnalysis.CSharp.Binder
                binder, bool
                searchUsingsNotNamespace)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ExtensionMethodScope(binder, searchUsingsNotNamespace: searchUsingsNotNamespace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10337, 3170, 3234);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ExtensionMethodScope
                f_10337_3292_3318()
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ExtensionMethodScope();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10337, 3292, 3318);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10337, 2907, 3330);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10337, 2907, 3330);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static ExtensionMethodScopeEnumerator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10337, 1585, 3337);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10337, 1585, 3337);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10337, 1585, 3337);
        }

        static Microsoft.CodeAnalysis.CSharp.ExtensionMethodScope
        f_10337_1859_1885()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.ExtensionMethodScope();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10337, 1859, 1885);
            return return_v;
        }

    }
}
