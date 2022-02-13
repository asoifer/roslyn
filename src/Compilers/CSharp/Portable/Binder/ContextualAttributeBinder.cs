// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class ContextualAttributeBinder : Binder
    {
        private readonly Symbol _attributeTarget;

        private readonly Symbol _attributedMember;

        public ContextualAttributeBinder(Binder enclosing, Symbol symbol)
        : base(f_10329_1121_1130_C(enclosing), enclosing.Flags | BinderFlags.InContextualAttributeBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10329, 1035, 1314);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10329, 767, 783);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10329, 818, 835);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10329, 1215, 1241);

                _attributeTarget = symbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10329, 1255, 1303);

                _attributedMember = f_10329_1275_1302(symbol);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10329, 1035, 1314);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10329, 1035, 1314);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10329, 1035, 1314);
            }
        }

        internal Symbol AttributedMember
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10329, 1813, 1889);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10329, 1849, 1874);

                    return _attributedMember;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10329, 1813, 1889);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10329, 1756, 1900);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10329, 1756, 1900);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static Symbol GetAttributedMember(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10329, 2018, 2486);
                try
                {
                    for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10329, 2099, 2445) || true) && ((object)symbol != null)
   ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10329, 2130, 2162)
   , symbol = f_10329_2139_2162(symbol), DynAbs.Tracing.TraceSender.TraceExitCondition(10329, 2099, 2445))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10329, 2099, 2445);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10329, 2196, 2430);

                        switch (f_10329_2204_2215(symbol))
                        {

                            case SymbolKind.Method:
                            case SymbolKind.Property:
                            case SymbolKind.Event:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10329, 2196, 2430);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10329, 2397, 2411);

                                return symbol;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10329, 2196, 2430);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10329, 1, 347);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10329, 1, 347);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10329, 2461, 2475);

                return symbol;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10329, 2018, 2486);

                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10329_2139_2162(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10329, 2139, 2162);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10329_2204_2215(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10329, 2204, 2215);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10329, 2018, 2486);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10329, 2018, 2486);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Symbol AttributeTarget
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10329, 2554, 2629);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10329, 2590, 2614);

                    return _attributeTarget;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10329, 2554, 2629);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10329, 2498, 2640);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10329, 2498, 2640);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static ContextualAttributeBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10329, 670, 2647);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10329, 670, 2647);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10329, 670, 2647);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10329, 670, 2647);

        Microsoft.CodeAnalysis.CSharp.Symbol
        f_10329_1275_1302(Microsoft.CodeAnalysis.CSharp.Symbol
        symbol)
        {
            var return_v = GetAttributedMember(symbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10329, 1275, 1302);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Binder
        f_10329_1121_1130_C(Microsoft.CodeAnalysis.CSharp.Binder
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10329, 1035, 1314);
            return return_v;
        }

    }
}
