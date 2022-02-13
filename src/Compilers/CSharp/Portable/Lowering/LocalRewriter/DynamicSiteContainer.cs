// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using System.Diagnostics;
using Microsoft.CodeAnalysis.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class DynamicSiteContainer : SynthesizedContainer, ISynthesizedMethodBodyImplementationSymbol
    {
        private readonly MethodSymbol _topLevelMethod;

        internal DynamicSiteContainer(string name, MethodSymbol topLevelMethod, MethodSymbol containingMethod)
        : base(f_10472_739_743_C(name), containingMethod)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10472, 616, 882);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10472, 588, 603);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10472, 787, 824);

                f_10472_787_823(topLevelMethod != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10472, 838, 871);

                _topLevelMethod = topLevelMethod;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10472, 616, 882);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10472, 616, 882);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10472, 616, 882);
            }
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10472, 958, 1006);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10472, 964, 1004);

                    return f_10472_971_1003(_topLevelMethod);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10472, 958, 1006);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10472_971_1003(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10472, 971, 1003);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10472, 894, 1017);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10472, 894, 1017);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override TypeKind TypeKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10472, 1087, 1117);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10472, 1093, 1115);

                    return TypeKind.Class;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10472, 1087, 1117);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10472, 1029, 1128);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10472, 1029, 1128);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10472, 1208, 1253);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10472, 1214, 1251);

                    throw f_10472_1220_1250();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10472, 1208, 1253);

                    System.Exception
                    f_10472_1220_1250()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10472, 1220, 1250);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10472, 1140, 1264);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10472, 1140, 1264);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsRecord
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10472, 1308, 1316);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10472, 1311, 1316);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10472, 1308, 1316);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10472, 1308, 1316);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10472, 1308, 1316);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasPossibleWellKnownCloneMethod()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10472, 1384, 1392);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10472, 1387, 1392);
                return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10472, 1384, 1392);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10472, 1384, 1392);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10472, 1384, 1392);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        bool ISynthesizedMethodBodyImplementationSymbol.HasMethodBodyDependency
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10472, 1501, 1521);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10472, 1507, 1519);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10472, 1501, 1521);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10472, 1405, 1532);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10472, 1405, 1532);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IMethodSymbolInternal ISynthesizedMethodBodyImplementationSymbol.Method
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10472, 1640, 1671);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10472, 1646, 1669);

                    return _topLevelMethod;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10472, 1640, 1671);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10472, 1544, 1682);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10472, 1544, 1682);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static DynamicSiteContainer()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10472, 432, 1689);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10472, 432, 1689);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10472, 432, 1689);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10472, 432, 1689);

        int
        f_10472_787_823(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10472, 787, 823);
            return 0;
        }


        static string
        f_10472_739_743_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10472, 616, 882);
            return return_v;
        }

    }
}
