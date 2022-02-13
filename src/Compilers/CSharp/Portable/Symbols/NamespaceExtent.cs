// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{

    internal struct NamespaceExtent : IEquatable<NamespaceExtent>
    {

        private readonly NamespaceKind _kind;

        private readonly object _symbolOrCompilation;

        public NamespaceKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10127, 1074, 1138);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10127, 1110, 1123);

                    return _kind;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10127, 1074, 1138);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10127, 1024, 1149);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10127, 1024, 1149);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ModuleSymbol Module
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10127, 1422, 1667);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10127, 1458, 1594) || true) && (_kind == NamespaceKind.Module)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10127, 1458, 1594);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10127, 1533, 1575);

                        return (ModuleSymbol)_symbolOrCompilation;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10127, 1458, 1594);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10127, 1614, 1652);

                    throw f_10127_1620_1651();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10127, 1422, 1667);

                    System.InvalidOperationException
                    f_10127_1620_1651()
                    {
                        var return_v = new System.InvalidOperationException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10127, 1620, 1651);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10127, 1371, 1678);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10127, 1371, 1678);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public AssemblySymbol Assembly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10127, 1959, 2208);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10127, 1995, 2135) || true) && (_kind == NamespaceKind.Assembly)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10127, 1995, 2135);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10127, 2072, 2116);

                        return (AssemblySymbol)_symbolOrCompilation;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10127, 1995, 2135);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10127, 2155, 2193);

                    throw f_10127_2161_2192();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10127, 1959, 2208);

                    System.InvalidOperationException
                    f_10127_2161_2192()
                    {
                        var return_v = new System.InvalidOperationException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10127, 2161, 2192);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10127, 1904, 2219);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10127, 1904, 2219);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public CSharpCompilation Compilation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10127, 2512, 2767);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10127, 2548, 2694) || true) && (_kind == NamespaceKind.Compilation)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10127, 2548, 2694);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10127, 2628, 2675);

                        return (CSharpCompilation)_symbolOrCompilation;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10127, 2548, 2694);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10127, 2714, 2752);

                    throw f_10127_2720_2751();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10127, 2512, 2767);

                    System.InvalidOperationException
                    f_10127_2720_2751()
                    {
                        var return_v = new System.InvalidOperationException();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10127, 2720, 2751);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10127, 2451, 2778);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10127, 2451, 2778);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10127, 2790, 2901);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10127, 2848, 2890);

                return $"{_kind}: {_symbolOrCompilation}";
                DynAbs.Tracing.TraceSender.TraceExitMethod(10127, 2790, 2901);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10127, 2790, 2901);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10127, 2790, 2901);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal NamespaceExtent(ModuleSymbol module)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10127, 3036, 3190);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10127, 3106, 3135);

                _kind = NamespaceKind.Module;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10127, 3149, 3179);

                _symbolOrCompilation = module;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10127, 3036, 3190);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10127, 3036, 3190);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10127, 3036, 3190);
            }
        }

        internal NamespaceExtent(AssemblySymbol assembly)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10127, 3327, 3489);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10127, 3401, 3432);

                _kind = NamespaceKind.Assembly;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10127, 3446, 3478);

                _symbolOrCompilation = assembly;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10127, 3327, 3489);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10127, 3327, 3489);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10127, 3327, 3489);
            }
        }

        internal NamespaceExtent(CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10127, 3623, 3797);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10127, 3703, 3737);

                _kind = NamespaceKind.Compilation;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10127, 3751, 3786);

                _symbolOrCompilation = compilation;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10127, 3623, 3797);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10127, 3623, 3797);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10127, 3623, 3797);
            }
        }

        public override bool Equals(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10127, 3809, 3946);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10127, 3873, 3935);

                return obj is NamespaceExtent && (DynAbs.Tracing.TraceSender.Expression_True(10127, 3880, 3934) && Equals(obj));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10127, 3809, 3946);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10127, 3809, 3946);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10127, 3809, 3946);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool Equals(NamespaceExtent other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10127, 3958, 4106);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10127, 4024, 4095);

                return f_10127_4031_4094(_symbolOrCompilation, other._symbolOrCompilation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10127, 3958, 4106);

                bool
                f_10127_4031_4094(object
                objA, object
                objB)
                {
                    var return_v = object.Equals(objA, objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10127, 4031, 4094);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10127, 3958, 4106);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10127, 3958, 4106);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10127, 4118, 4266);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10127, 4176, 4255);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(10127, 4183, 4213) || (((_symbolOrCompilation == null) && DynAbs.Tracing.TraceSender.Conditional_F2(10127, 4216, 4217)) || DynAbs.Tracing.TraceSender.Conditional_F3(10127, 4220, 4254))) ? 0 : f_10127_4220_4254(_symbolOrCompilation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10127, 4118, 4266);

                int
                f_10127_4220_4254(object
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10127, 4220, 4254);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10127, 4118, 4266);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10127, 4118, 4266);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        static NamespaceExtent()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10127, 719, 4273);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10127, 719, 4273);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10127, 719, 4273);
        }
    }
}
