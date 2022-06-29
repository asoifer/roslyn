// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

#if NETCOREAPP

using System.Diagnostics;
using System.Reflection;
using System.Runtime.Loader;

namespace Microsoft.CodeAnalysis
{
    internal class DefaultAnalyzerAssemblyLoader : AnalyzerAssemblyLoader
    {
        private AssemblyLoadContext _loadContext;

        protected override Assembly LoadFromPathImpl(string fullPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(254, 512, 1637);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(254, 983, 1584) || true) && (_loadContext == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(254, 983, 1584);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(254, 1041, 1172);

                    AssemblyLoadContext
                    loadContext = f_254_1075_1171(f_254_1110_1170(f_254_1110_1161(typeof(DefaultAnalyzerAssemblyLoader))))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(254, 1192, 1569) || true) && (f_254_1196_1277(ref _loadContext, loadContext, null) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(254, 1192, 1569);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(254, 1327, 1550);

                        _loadContext.Resolving += (context, name) =>
                                            {
                                                Debug.Assert(ReferenceEquals(context, _loadContext));
                                                return Load(name.FullName);
                                            };
                        DynAbs.Tracing.TraceSender.TraceExitCondition(254, 1192, 1569);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(254, 983, 1584);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(254, 1600, 1626);

                return f_254_1607_1625(this, fullPath);
                DynAbs.Tracing.TraceSender.TraceExitMethod(254, 512, 1637);

                System.Reflection.TypeInfo
                f_254_1110_1161(System.Type
                type)
                {
                    var return_v = type.GetTypeInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(254, 1110, 1161);
                    return return_v;
                }


                System.Reflection.Assembly
                f_254_1110_1170(System.Reflection.TypeInfo
                this_param)
                {
                    var return_v = this_param.Assembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(254, 1110, 1170);
                    return return_v;
                }


                System.Runtime.Loader.AssemblyLoadContext?
                f_254_1075_1171(System.Reflection.Assembly
                assembly)
                {
                    var return_v = AssemblyLoadContext.GetLoadContext(assembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(254, 1075, 1171);
                    return return_v;
                }


                System.Runtime.Loader.AssemblyLoadContext?
                f_254_1196_1277(ref System.Runtime.Loader.AssemblyLoadContext?
                location1, System.Runtime.Loader.AssemblyLoadContext?
                value, System.Runtime.Loader.AssemblyLoadContext?
                comparand)
                {
                    var return_v = System.Threading.Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(254, 1196, 1277);
                    return return_v;
                }


                System.Reflection.Assembly
                f_254_1607_1625(Microsoft.CodeAnalysis.DefaultAnalyzerAssemblyLoader
                this_param, string
                fullPath)
                {
                    var return_v = this_param.LoadImpl(fullPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(254, 1607, 1625);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(254, 512, 1637);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(254, 512, 1637);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual Assembly LoadImpl(string fullPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(254, 1702, 1748);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(254, 1705, 1748);
                return f_254_1705_1748(_loadContext, fullPath); DynAbs.Tracing.TraceSender.TraceExitMethod(254, 1702, 1748);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(254, 1702, 1748);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(254, 1702, 1748);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Reflection.Assembly
            f_254_1705_1748(System.Runtime.Loader.AssemblyLoadContext
            this_param, string
            assemblyPath)
            {
                var return_v = this_param.LoadFromAssemblyPath(assemblyPath);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(254, 1705, 1748);
                return return_v;
            }

        }

        public DefaultAnalyzerAssemblyLoader()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(254, 373, 1756);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(254, 487, 499);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(254, 373, 1756);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(254, 373, 1756);
        }


        static DefaultAnalyzerAssemblyLoader()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(254, 373, 1756);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(254, 373, 1756);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(254, 373, 1756);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(254, 373, 1756);
    }
}

#endif
