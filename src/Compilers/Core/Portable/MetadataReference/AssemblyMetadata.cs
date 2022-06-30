// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Reflection.Metadata;
using System.Reflection.PortableExecutable;
using System.Threading;
using System.Diagnostics;
using Roslyn.Utilities;
using Microsoft.CodeAnalysis.Symbols;

namespace Microsoft.CodeAnalysis
{
    public sealed class AssemblyMetadata : Metadata
    {
        private sealed class Data
        {
            public static readonly Data Disposed;

            public readonly ImmutableArray<ModuleMetadata> Modules;

            public readonly PEAssembly? Assembly;

            private Data()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(426, 961, 1005);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 936, 944);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(426, 961, 1005);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(426, 961, 1005);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(426, 961, 1005);
                }
            }

            public Data(ImmutableArray<ModuleMetadata> modules, PEAssembly assembly)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(426, 1021, 1287);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 936, 944);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 1126, 1186);

                    f_426_1126_1185(f_426_1139_1164_M(!modules.IsDefaultOrEmpty) && (DynAbs.Tracing.TraceSender.Expression_True(426, 1139, 1184) && assembly != null));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 1206, 1229);

                    this.Modules = modules;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 1247, 1272);

                    this.Assembly = assembly;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(426, 1021, 1287);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(426, 1021, 1287);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(426, 1021, 1287);
                }
            }

            public bool IsDisposed
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(426, 1358, 1390);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 1364, 1388);

                        return Assembly == null;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(426, 1358, 1390);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(426, 1303, 1405);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(426, 1303, 1405);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static Data()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(426, 723, 1416);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 801, 822);
                Disposed = f_426_812_822(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(426, 723, 1416);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(426, 723, 1416);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(426, 723, 1416);

            static Microsoft.CodeAnalysis.AssemblyMetadata.Data
            f_426_812_822()
            {
                var return_v = new Microsoft.CodeAnalysis.AssemblyMetadata.Data();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 812, 822);
                return return_v;
            }


            bool
            f_426_1139_1164_M(bool
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(426, 1139, 1164);
                return return_v;
            }


            static int
            f_426_1126_1185(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 1126, 1185);
                return 0;
            }

        }

        private readonly Func<string, ModuleMetadata>? _moduleFactoryOpt;

        private readonly ImmutableArray<ModuleMetadata> _initialModules;

        private Data? _lazyData;

        private ImmutableArray<ModuleMetadata> _lazyPublishedModules;

        internal readonly WeakList<IAssemblySymbolInternal> CachedSymbols;

        private AssemblyMetadata(AssemblyMetadata other, bool shareCachedSymbols)
        : base(isImageOwner: f_426_2944_2963_C(false), id: f_426_2969_2977(other))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(426, 2850, 3384);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 1841, 1858);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 2221, 2230);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 2755, 2810);
                this.CachedSymbols = f_426_2771_2810();
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 3003, 3115) || true) && (shareCachedSymbols)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(426, 3003, 3115);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 3059, 3100);

                    this.CachedSymbols = other.CachedSymbols;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(426, 3003, 3115);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 3131, 3159);

                _lazyData = other._lazyData;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 3173, 3217);

                _moduleFactoryOpt = other._moduleFactoryOpt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 3231, 3271);

                _initialModules = other._initialModules;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(426, 2850, 3384);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(426, 2850, 3384);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(426, 2850, 3384);
            }
        }

        internal AssemblyMetadata(ImmutableArray<ModuleMetadata> modules)
        : base(isImageOwner: f_426_3482_3500_C(true), id: f_426_3506_3530())
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(426, 3396, 3647);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 1841, 1858);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 2221, 2230);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 2755, 2810);
                this.CachedSymbols = f_426_2771_2810(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 3556, 3596);

                f_426_3556_3595(f_426_3569_3594_M(!modules.IsDefaultOrEmpty));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 3610, 3636);

                _initialModules = modules;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(426, 3396, 3647);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(426, 3396, 3647);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(426, 3396, 3647);
            }
        }

        internal AssemblyMetadata(ModuleMetadata manifestModule, Func<string, ModuleMetadata> moduleFactory)
        : base(isImageOwner: f_426_3780_3798_C(true), id: f_426_3804_3828())
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(426, 3659, 4072);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 1841, 1858);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 2221, 2230);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 2755, 2810);
                this.CachedSymbols = f_426_2771_2810(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 3854, 3891);

                f_426_3854_3890(manifestModule != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 3905, 3941);

                f_426_3905_3940(moduleFactory != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 3957, 4013);

                _initialModules = f_426_3975_4012(manifestModule);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 4027, 4061);

                _moduleFactoryOpt = moduleFactory;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(426, 3659, 4072);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(426, 3659, 4072);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(426, 3659, 4072);
            }
        }

        public static AssemblyMetadata CreateFromImage(ImmutableArray<byte> peImage)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(426, 4373, 4540);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 4474, 4529);

                return f_426_4481_4528(f_426_4488_4527(peImage));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(426, 4373, 4540);

                Microsoft.CodeAnalysis.ModuleMetadata
                f_426_4488_4527(System.Collections.Immutable.ImmutableArray<byte>
                peImage)
                {
                    var return_v = ModuleMetadata.CreateFromImage(peImage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 4488, 4527);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyMetadata
                f_426_4481_4528(Microsoft.CodeAnalysis.ModuleMetadata
                module)
                {
                    var return_v = Create(module);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 4481, 4528);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(426, 4373, 4540);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(426, 4373, 4540);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static AssemblyMetadata CreateFromImage(IEnumerable<byte> peImage)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(426, 4940, 5104);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 5038, 5093);

                return f_426_5045_5092(f_426_5052_5091(peImage));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(426, 4940, 5104);

                Microsoft.CodeAnalysis.ModuleMetadata
                f_426_5052_5091(System.Collections.Generic.IEnumerable<byte>
                peImage)
                {
                    var return_v = ModuleMetadata.CreateFromImage(peImage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 5052, 5091);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyMetadata
                f_426_5045_5092(Microsoft.CodeAnalysis.ModuleMetadata
                module)
                {
                    var return_v = Create(module);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 5045, 5092);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(426, 4940, 5104);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(426, 4940, 5104);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static AssemblyMetadata CreateFromStream(Stream peStream, bool leaveOpen = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(426, 5488, 5680);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 5601, 5669);

                return f_426_5608_5668(f_426_5615_5667(peStream, leaveOpen));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(426, 5488, 5680);

                Microsoft.CodeAnalysis.ModuleMetadata
                f_426_5615_5667(System.IO.Stream
                peStream, bool
                leaveOpen)
                {
                    var return_v = ModuleMetadata.CreateFromStream(peStream, leaveOpen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 5615, 5667);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyMetadata
                f_426_5608_5668(Microsoft.CodeAnalysis.ModuleMetadata
                module)
                {
                    var return_v = Create(module);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 5608, 5668);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(426, 5488, 5680);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(426, 5488, 5680);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static AssemblyMetadata CreateFromStream(Stream peStream, PEStreamOptions options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(426, 6062, 6253);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 6176, 6242);

                return f_426_6183_6241(f_426_6190_6240(peStream, options));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(426, 6062, 6253);

                Microsoft.CodeAnalysis.ModuleMetadata
                f_426_6190_6240(System.IO.Stream
                peStream, System.Reflection.PortableExecutable.PEStreamOptions
                options)
                {
                    var return_v = ModuleMetadata.CreateFromStream(peStream, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 6190, 6240);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyMetadata
                f_426_6183_6241(Microsoft.CodeAnalysis.ModuleMetadata
                module)
                {
                    var return_v = Create(module);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 6183, 6241);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(426, 6062, 6253);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(426, 6062, 6253);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static AssemblyMetadata CreateFromFile(string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(426, 7010, 7169);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 7093, 7158);

                return f_426_7100_7157(f_426_7115_7150(path), path);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(426, 7010, 7169);

                Microsoft.CodeAnalysis.ModuleMetadata
                f_426_7115_7150(string
                path)
                {
                    var return_v = ModuleMetadata.CreateFromFile(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 7115, 7150);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyMetadata
                f_426_7100_7157(Microsoft.CodeAnalysis.ModuleMetadata
                manifestModule, string
                path)
                {
                    var return_v = CreateFromFile(manifestModule, path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 7100, 7157);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(426, 7010, 7169);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(426, 7010, 7169);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static AssemblyMetadata CreateFromFile(ModuleMetadata manifestModule, string path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(426, 7181, 7458);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 7297, 7447);

                return f_426_7304_7446(manifestModule, moduleName => ModuleMetadata.CreateFromFile(Path.Combine(Path.GetDirectoryName(path) ?? "", moduleName)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(426, 7181, 7458);

                Microsoft.CodeAnalysis.AssemblyMetadata
                f_426_7304_7446(Microsoft.CodeAnalysis.ModuleMetadata
                manifestModule, System.Func<string, Microsoft.CodeAnalysis.ModuleMetadata>
                moduleFactory)
                {
                    var return_v = new Microsoft.CodeAnalysis.AssemblyMetadata(manifestModule, moduleFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 7304, 7446);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(426, 7181, 7458);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(426, 7181, 7458);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static AssemblyMetadata Create(ModuleMetadata module)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(426, 7761, 8047);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 7846, 7961) || true) && (module == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(426, 7846, 7961);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 7898, 7946);

                    throw f_426_7904_7945(nameof(module));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(426, 7846, 7961);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 7977, 8036);

                return f_426_7984_8035(f_426_8005_8034(module));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(426, 7761, 8047);

                System.ArgumentNullException
                f_426_7904_7945(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 7904, 7945);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModuleMetadata>
                f_426_8005_8034(Microsoft.CodeAnalysis.ModuleMetadata
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 8005, 8034);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyMetadata
                f_426_7984_8035(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModuleMetadata>
                modules)
                {
                    var return_v = new Microsoft.CodeAnalysis.AssemblyMetadata(modules);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 7984, 8035);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(426, 7761, 8047);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(426, 7761, 8047);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static AssemblyMetadata Create(ImmutableArray<ModuleMetadata> modules)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(426, 8853, 9689);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 8955, 9133) || true) && (modules.IsDefaultOrEmpty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(426, 8955, 9133);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 9017, 9118);

                    throw f_426_9023_9117(f_426_9045_9099(), nameof(modules));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(426, 8955, 9133);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 9158, 9163);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 9149, 9625) || true) && (i < modules.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 9185, 9188)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(426, 9149, 9625))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(426, 9149, 9625);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 9222, 9370) || true) && (modules[i] == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(426, 9222, 9370);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 9286, 9351);

                            throw f_426_9292_9350(nameof(modules) + "[" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (i).ToString(), 426, 9342, 9343) + "]");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(426, 9222, 9370);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 9390, 9610) || true) && (!modules[i].IsImageOwner)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(426, 9390, 9610);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 9460, 9591);

                            throw f_426_9466_9590(f_426_9488_9556(), nameof(modules) + "[" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (i).ToString(), 426, 9582, 9583) + "]");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(426, 9390, 9610);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(426, 1, 477);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(426, 1, 477);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 9641, 9678);

                return f_426_9648_9677(modules);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(426, 8853, 9689);

                string
                f_426_9045_9099()
                {
                    var return_v = CodeAnalysisResources.AssemblyMustHaveAtLeastOneModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(426, 9045, 9099);
                    return return_v;
                }


                System.ArgumentException
                f_426_9023_9117(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 9023, 9117);
                    return return_v;
                }


                System.ArgumentNullException
                f_426_9292_9350(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 9292, 9350);
                    return return_v;
                }


                string
                f_426_9488_9556()
                {
                    var return_v = CodeAnalysisResources.ModuleCopyCannotBeUsedToCreateAssemblyMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(426, 9488, 9556);
                    return return_v;
                }


                System.ArgumentException
                f_426_9466_9590(string
                message, string
                paramName)
                {
                    var return_v = new System.ArgumentException(message, paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 9466, 9590);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyMetadata
                f_426_9648_9677(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModuleMetadata>
                modules)
                {
                    var return_v = new Microsoft.CodeAnalysis.AssemblyMetadata(modules);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 9648, 9677);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(426, 8853, 9689);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(426, 8853, 9689);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static AssemblyMetadata Create(IEnumerable<ModuleMetadata> modules)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(426, 10495, 10648);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 10594, 10637);

                return f_426_10601_10636(f_426_10608_10635(modules));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(426, 10495, 10648);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModuleMetadata>
                f_426_10608_10635(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ModuleMetadata>
                items)
                {
                    var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.ModuleMetadata>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 10608, 10635);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyMetadata
                f_426_10601_10636(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModuleMetadata>
                modules)
                {
                    var return_v = Create(modules);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 10601, 10636);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(426, 10495, 10648);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(426, 10495, 10648);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static AssemblyMetadata Create(params ModuleMetadata[] modules)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(426, 11440, 11597);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 11535, 11586);

                return f_426_11542_11585(f_426_11549_11584(modules));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(426, 11440, 11597);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModuleMetadata>
                f_426_11549_11584(Microsoft.CodeAnalysis.ModuleMetadata[]
                items)
                {
                    var return_v = ImmutableArray.CreateRange((System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.ModuleMetadata>)items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 11549, 11584);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyMetadata
                f_426_11542_11585(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModuleMetadata>
                modules)
                {
                    var return_v = Create(modules);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 11542, 11585);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(426, 11440, 11597);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(426, 11440, 11597);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal new AssemblyMetadata Copy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(426, 12245, 12377);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 12306, 12366);

                return f_426_12313_12365(this, shareCachedSymbols: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(426, 12245, 12377);

                Microsoft.CodeAnalysis.AssemblyMetadata
                f_426_12313_12365(Microsoft.CodeAnalysis.AssemblyMetadata
                other, bool
                shareCachedSymbols)
                {
                    var return_v = new Microsoft.CodeAnalysis.AssemblyMetadata(other, shareCachedSymbols: shareCachedSymbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 12313, 12365);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(426, 12245, 12377);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(426, 12245, 12377);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal AssemblyMetadata CopyWithoutSharingCachedSymbols()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(426, 12389, 12545);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 12473, 12534);

                return f_426_12480_12533(this, shareCachedSymbols: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(426, 12389, 12545);

                Microsoft.CodeAnalysis.AssemblyMetadata
                f_426_12480_12533(Microsoft.CodeAnalysis.AssemblyMetadata
                other, bool
                shareCachedSymbols)
                {
                    var return_v = new Microsoft.CodeAnalysis.AssemblyMetadata(other, shareCachedSymbols: shareCachedSymbols);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 12480, 12533);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(426, 12389, 12545);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(426, 12389, 12545);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override Metadata CommonCopy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(426, 12557, 12647);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 12622, 12636);

                return f_426_12629_12635(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(426, 12557, 12647);

                Microsoft.CodeAnalysis.AssemblyMetadata
                f_426_12629_12635(Microsoft.CodeAnalysis.AssemblyMetadata
                this_param)
                {
                    var return_v = this_param.Copy();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 12629, 12635);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(426, 12557, 12647);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(426, 12557, 12647);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ImmutableArray<ModuleMetadata> GetModules()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(426, 13132, 13842);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 13207, 13631) || true) && (_lazyPublishedModules.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(426, 13207, 13631);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 13276, 13305);

                    var
                    data = f_426_13287_13304(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 13323, 13353);

                    var
                    newModules = data.Modules
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 13373, 13514) || true) && (!IsImageOwner)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(426, 13373, 13514);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 13432, 13495);

                        newModules = newModules.SelectAsArray(module => module.Copy());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(426, 13373, 13514);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 13534, 13616);

                    f_426_13534_13615(ref _lazyPublishedModules, newModules);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(426, 13207, 13631);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 13647, 13786) || true) && (_lazyData == Data.Disposed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(426, 13647, 13786);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 13711, 13771);

                    throw f_426_13717_13770(nameof(AssemblyMetadata));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(426, 13647, 13786);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 13802, 13831);

                return _lazyPublishedModules;
                DynAbs.Tracing.TraceSender.TraceExitMethod(426, 13132, 13842);

                Microsoft.CodeAnalysis.AssemblyMetadata.Data
                f_426_13287_13304(Microsoft.CodeAnalysis.AssemblyMetadata
                this_param)
                {
                    var return_v = this_param.GetOrCreateData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 13287, 13304);
                    return return_v;
                }


                bool
                f_426_13534_13615(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModuleMetadata>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModuleMetadata>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 13534, 13615);
                    return return_v;
                }


                System.ObjectDisposedException
                f_426_13717_13770(string
                objectName)
                {
                    var return_v = new System.ObjectDisposedException(objectName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 13717, 13770);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(426, 13132, 13842);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(426, 13132, 13842);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal PEAssembly? GetAssembly()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(426, 14198, 14302);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 14257, 14291);

                return f_426_14264_14281(this).Assembly;
                DynAbs.Tracing.TraceSender.TraceExitMethod(426, 14198, 14302);

                Microsoft.CodeAnalysis.AssemblyMetadata.Data
                f_426_14264_14281(Microsoft.CodeAnalysis.AssemblyMetadata
                this_param)
                {
                    var return_v = this_param.GetOrCreateData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 14264, 14281);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(426, 14198, 14302);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(426, 14198, 14302);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Data GetOrCreateData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(426, 14658, 16812);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 14713, 16619) || true) && (_lazyData == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(426, 14713, 16619);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 14768, 14825);

                    ImmutableArray<ModuleMetadata>
                    modules = _initialModules
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 14843, 14904);

                    ImmutableArray<ModuleMetadata>.Builder?
                    moduleBuilder = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 14924, 14956);

                    bool
                    createdModulesUsed = false
                    ;
                    try
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 15018, 15863) || true) && (_moduleFactoryOpt != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(426, 15018, 15863);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 15097, 15139);

                            f_426_15097_15138(_initialModules.Length == 1);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 15167, 15231);

                            var
                            additionalModuleNames = f_426_15195_15230(_initialModules[0])
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 15257, 15840) || true) && (additionalModuleNames.Length > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(426, 15257, 15840);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 15351, 15446);

                                moduleBuilder = f_426_15367_15445(1 + additionalModuleNames.Length);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 15476, 15514);

                                f_426_15476_15513(moduleBuilder, _initialModules[0]);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 15546, 15743);
                                    foreach (string moduleName in f_426_15576_15597_I(additionalModuleNames))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(426, 15546, 15743);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 15663, 15712);

                                        f_426_15663_15711(moduleBuilder, f_426_15681_15710(this, moduleName));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(426, 15546, 15743);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(426, 1, 198);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(426, 1, 198);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 15775, 15813);

                                modules = f_426_15785_15812(moduleBuilder);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(426, 15257, 15840);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(426, 15018, 15863);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 15887, 15961);

                        var
                        assembly = f_426_15902_15960(this, modules.SelectAsArray(m => m.Module))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 15983, 16025);

                        var
                        newData = f_426_15997_16024(modules, assembly)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 16049, 16136);

                        createdModulesUsed = f_426_16070_16127(ref _lazyData, newData, null) == null;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(426, 16173, 16604);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 16221, 16585) || true) && (moduleBuilder != null && (DynAbs.Tracing.TraceSender.Expression_True(426, 16225, 16269) && !createdModulesUsed))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(426, 16221, 16585);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 16394, 16420);
                                // dispose unused modules created above:
                                for (int
        i = _initialModules.Length
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 16385, 16562) || true) && (i < f_426_16426_16445(moduleBuilder))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 16447, 16450)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(426, 16385, 16562))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(426, 16385, 16562);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 16508, 16535);

                                    f_426_16508_16534(f_426_16508_16524(moduleBuilder, i));
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(426, 1, 178);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(426, 1, 178);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(426, 16221, 16585);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitFinally(426, 16173, 16604);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(426, 14713, 16619);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 16635, 16768) || true) && (f_426_16639_16659(_lazyData))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(426, 16635, 16768);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 16693, 16753);

                    throw f_426_16699_16752(nameof(AssemblyMetadata));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(426, 16635, 16768);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 16784, 16801);

                return _lazyData;
                DynAbs.Tracing.TraceSender.TraceExitMethod(426, 14658, 16812);

                int
                f_426_15097_15138(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 15097, 15138);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_426_15195_15230(Microsoft.CodeAnalysis.ModuleMetadata
                this_param)
                {
                    var return_v = this_param.GetModuleNames();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 15195, 15230);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModuleMetadata>.Builder
                f_426_15367_15445(int
                initialCapacity)
                {
                    var return_v = ImmutableArray.CreateBuilder<ModuleMetadata>(initialCapacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 15367, 15445);
                    return return_v;
                }


                int
                f_426_15476_15513(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModuleMetadata>.Builder
                this_param, Microsoft.CodeAnalysis.ModuleMetadata
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 15476, 15513);
                    return 0;
                }


                Microsoft.CodeAnalysis.ModuleMetadata
                f_426_15681_15710(Microsoft.CodeAnalysis.AssemblyMetadata
                this_param, string
                arg)
                {
                    var return_v = this_param._moduleFactoryOpt(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 15681, 15710);
                    return return_v;
                }


                int
                f_426_15663_15711(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModuleMetadata>.Builder
                this_param, Microsoft.CodeAnalysis.ModuleMetadata
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 15663, 15711);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<string>
                f_426_15576_15597_I(System.Collections.Immutable.ImmutableArray<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 15576, 15597);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModuleMetadata>
                f_426_15785_15812(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModuleMetadata>.Builder
                this_param)
                {
                    var return_v = this_param.ToImmutable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 15785, 15812);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEAssembly
                f_426_15902_15960(Microsoft.CodeAnalysis.AssemblyMetadata
                owner, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.PEModule>
                modules)
                {
                    var return_v = new Microsoft.CodeAnalysis.PEAssembly(owner, modules);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 15902, 15960);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyMetadata.Data
                f_426_15997_16024(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModuleMetadata>
                modules, Microsoft.CodeAnalysis.PEAssembly
                assembly)
                {
                    var return_v = new Microsoft.CodeAnalysis.AssemblyMetadata.Data(modules, assembly);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 15997, 16024);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyMetadata.Data?
                f_426_16070_16127(ref Microsoft.CodeAnalysis.AssemblyMetadata.Data?
                location1, Microsoft.CodeAnalysis.AssemblyMetadata.Data
                value, Microsoft.CodeAnalysis.AssemblyMetadata.Data?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 16070, 16127);
                    return return_v;
                }


                int
                f_426_16426_16445(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModuleMetadata>.Builder
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(426, 16426, 16445);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ModuleMetadata
                f_426_16508_16524(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModuleMetadata>.Builder
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(426, 16508, 16524);
                    return return_v;
                }


                int
                f_426_16508_16534(Microsoft.CodeAnalysis.ModuleMetadata
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 16508, 16534);
                    return 0;
                }


                bool
                f_426_16639_16659(Microsoft.CodeAnalysis.AssemblyMetadata.Data
                this_param)
                {
                    var return_v = this_param.IsDisposed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(426, 16639, 16659);
                    return return_v;
                }


                System.ObjectDisposedException
                f_426_16699_16752(string
                objectName)
                {
                    var return_v = new System.ObjectDisposedException(objectName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 16699, 16752);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(426, 14658, 16812);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(426, 14658, 16812);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(426, 16932, 17991);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 16987, 17057);

                var
                previousData = f_426_17006_17056(ref _lazyData, Data.Disposed)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 17073, 17238) || true) && (previousData == Data.Disposed || (DynAbs.Tracing.TraceSender.Expression_False(426, 17077, 17128) || !this.IsImageOwner))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(426, 17073, 17238);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 17216, 17223);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(426, 17073, 17238);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 17353, 17457);
                    foreach (var module in f_426_17376_17391_I(_initialModules))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(426, 17353, 17457);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 17425, 17442);

                        f_426_17425_17441(module);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(426, 17353, 17457);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(426, 1, 105);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(426, 1, 105);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 17473, 17634) || true) && (previousData == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(426, 17473, 17634);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 17612, 17619);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(426, 17473, 17634);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 17650, 17749);

                f_426_17650_17748(_initialModules.Length == 1 || (DynAbs.Tracing.TraceSender.Expression_False(426, 17663, 17747) || _initialModules.Length == previousData.Modules.Length));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 17833, 17859);

                    // dispose additional modules created lazily:
                    for (int
        i = _initialModules.Length
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 17824, 17980) || true) && (i < previousData.Modules.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 17894, 17897)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(426, 17824, 17980))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(426, 17824, 17980);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 17931, 17965);

                        f_426_17931_17964(previousData.Modules[i]);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(426, 1, 157);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(426, 1, 157);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(426, 16932, 17991);

                Microsoft.CodeAnalysis.AssemblyMetadata.Data?
                f_426_17006_17056(ref Microsoft.CodeAnalysis.AssemblyMetadata.Data?
                location1, Microsoft.CodeAnalysis.AssemblyMetadata.Data
                value)
                {
                    var return_v = Interlocked.Exchange(ref location1, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 17006, 17056);
                    return return_v;
                }


                int
                f_426_17425_17441(Microsoft.CodeAnalysis.ModuleMetadata
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 17425, 17441);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModuleMetadata>
                f_426_17376_17391_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModuleMetadata>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 17376, 17391);
                    return return_v;
                }


                int
                f_426_17650_17748(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 17650, 17748);
                    return 0;
                }


                int
                f_426_17931_17964(Microsoft.CodeAnalysis.ModuleMetadata
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 17931, 17964);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(426, 16932, 17991);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(426, 16932, 17991);
            }
        }

        internal bool IsValidAssembly()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(426, 18501, 19170);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 18557, 18584);

                var
                modules = f_426_18571_18583(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 18600, 18701) || true) && (f_426_18604_18639_M(!f_426_18605_18622(modules[0]).IsManifestModule))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(426, 18600, 18701);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 18673, 18686);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(426, 18600, 18701);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 18726, 18731);

                    for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 18717, 19131) || true) && (i < modules.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 18753, 18756)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(426, 18717, 19131))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(426, 18717, 19131);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 18897, 18928);

                        var
                        module = f_426_18910_18927(modules[i])
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 18946, 19116) || true) && (f_426_18950_18972_M(!module.IsLinkedModule) && (DynAbs.Tracing.TraceSender.Expression_True(426, 18950, 19042) && f_426_18976_19010(f_426_18976_18997(module)) != MetadataKind.WindowsMetadata))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(426, 18946, 19116);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 19084, 19097);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(426, 18946, 19116);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(426, 1, 415);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(426, 1, 415);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 19147, 19159);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(426, 18501, 19170);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModuleMetadata>
                f_426_18571_18583(Microsoft.CodeAnalysis.AssemblyMetadata
                this_param)
                {
                    var return_v = this_param.GetModules();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 18571, 18583);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_426_18605_18622(Microsoft.CodeAnalysis.ModuleMetadata
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(426, 18605, 18622);
                    return return_v;
                }


                bool
                f_426_18604_18639_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(426, 18604, 18639);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PEModule
                f_426_18910_18927(Microsoft.CodeAnalysis.ModuleMetadata
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(426, 18910, 18927);
                    return return_v;
                }


                bool
                f_426_18950_18972_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(426, 18950, 18972);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataReader
                f_426_18976_18997(Microsoft.CodeAnalysis.PEModule
                this_param)
                {
                    var return_v = this_param.MetadataReader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(426, 18976, 18997);
                    return return_v;
                }


                System.Reflection.Metadata.MetadataKind
                f_426_18976_19010(System.Reflection.Metadata.MetadataReader
                this_param)
                {
                    var return_v = this_param.MetadataKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(426, 18976, 19010);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(426, 18501, 19170);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(426, 18501, 19170);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override MetadataImageKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(426, 19368, 19410);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 19374, 19408);

                    return MetadataImageKind.Assembly;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(426, 19368, 19410);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(426, 19305, 19421);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(426, 19305, 19421);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public PortableExecutableReference GetReference(
                    DocumentationProvider? documentation = null,
                    ImmutableArray<string> aliases = default,
                    bool embedInteropTypes = false,
                    string? filePath = null,
                    string? display = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(426, 20305, 20785);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(426, 20611, 20774);

                return f_426_20618_20773(this, f_426_20651_20738(MetadataImageKind.Assembly, aliases, embedInteropTypes), documentation, filePath, display);
                DynAbs.Tracing.TraceSender.TraceExitMethod(426, 20305, 20785);

                Microsoft.CodeAnalysis.MetadataReferenceProperties
                f_426_20651_20738(Microsoft.CodeAnalysis.MetadataImageKind
                kind, System.Collections.Immutable.ImmutableArray<string>
                aliases, bool
                embedInteropTypes)
                {
                    var return_v = new Microsoft.CodeAnalysis.MetadataReferenceProperties(kind, aliases, embedInteropTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 20651, 20738);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MetadataImageReference
                f_426_20618_20773(Microsoft.CodeAnalysis.AssemblyMetadata
                metadata, Microsoft.CodeAnalysis.MetadataReferenceProperties
                properties, Microsoft.CodeAnalysis.DocumentationProvider?
                documentation, string?
                filePath, string?
                display)
                {
                    var return_v = new Microsoft.CodeAnalysis.MetadataImageReference((Microsoft.CodeAnalysis.Metadata)metadata, properties, documentation, filePath, display);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 20618, 20773);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(426, 20305, 20785);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(426, 20305, 20785);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AssemblyMetadata()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(426, 659, 20792);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(426, 659, 20792);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(426, 659, 20792);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(426, 659, 20792);

        Roslyn.Utilities.WeakList<Microsoft.CodeAnalysis.Symbols.IAssemblySymbolInternal>
        f_426_2771_2810()
        {
            var return_v = new Roslyn.Utilities.WeakList<Microsoft.CodeAnalysis.Symbols.IAssemblySymbolInternal>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 2771, 2810);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataId
        f_426_2969_2977(Microsoft.CodeAnalysis.AssemblyMetadata
        this_param)
        {
            var return_v = this_param.Id;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(426, 2969, 2977);
            return return_v;
        }


        static bool
        f_426_2944_2963_C(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(426, 2850, 3384);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataId
        f_426_3506_3530()
        {
            var return_v = MetadataId.CreateNewId();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 3506, 3530);
            return return_v;
        }


        bool
        f_426_3569_3594_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(426, 3569, 3594);
            return return_v;
        }


        static int
        f_426_3556_3595(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 3556, 3595);
            return 0;
        }


        static bool
        f_426_3482_3500_C(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(426, 3396, 3647);
            return return_v;
        }


        static Microsoft.CodeAnalysis.MetadataId
        f_426_3804_3828()
        {
            var return_v = MetadataId.CreateNewId();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 3804, 3828);
            return return_v;
        }


        static int
        f_426_3854_3890(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 3854, 3890);
            return 0;
        }


        static int
        f_426_3905_3940(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 3905, 3940);
            return 0;
        }


        static System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ModuleMetadata>
        f_426_3975_4012(Microsoft.CodeAnalysis.ModuleMetadata
        item)
        {
            var return_v = ImmutableArray.Create(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(426, 3975, 4012);
            return return_v;
        }


        static bool
        f_426_3780_3798_C(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(426, 3659, 4072);
            return return_v;
        }

    }
}
