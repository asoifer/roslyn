// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Threading;
using Roslyn.Utilities;
using System.Diagnostics;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE
{
    internal sealed class PENestedNamespaceSymbol
            : PENamespaceSymbol
    {
        private readonly PENamespaceSymbol _containingNamespaceSymbol;

        private readonly string _name;

        private IEnumerable<IGrouping<string, TypeDefinitionHandle>> _typesByNS;

        internal PENestedNamespaceSymbol(
                    string name,
                    PENamespaceSymbol containingNamespace,
                    IEnumerable<IGrouping<string, TypeDefinitionHandle>> typesByNS)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10711, 3156, 3646);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10711, 1020, 1046);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10711, 1203, 1208);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10711, 2158, 2168);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10711, 3369, 3396);

                f_10711_3369_3395(name != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10711, 3410, 3460);

                f_10711_3410_3459((object)containingNamespace != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10711, 3474, 3506);

                f_10711_3474_3505(typesByNS != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10711, 3522, 3571);

                _containingNamespaceSymbol = containingNamespace;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10711, 3585, 3598);

                _name = name;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10711, 3612, 3635);

                _typesByNS = typesByNS;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10711, 3156, 3646);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10711, 3156, 3646);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10711, 3156, 3646);
            }
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10711, 3722, 3764);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10711, 3728, 3762);

                    return _containingNamespaceSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10711, 3722, 3764);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10711, 3658, 3775);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10711, 3658, 3775);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override PEModuleSymbol ContainingPEModule
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10711, 3863, 3924);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10711, 3869, 3922);

                    return f_10711_3876_3921(_containingNamespaceSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10711, 3863, 3924);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    f_10711_3876_3921(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamespaceSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingPEModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10711, 3876, 3921);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10711, 3787, 3935);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10711, 3787, 3935);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10711, 3999, 4063);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10711, 4035, 4048);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10711, 3999, 4063);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10711, 3947, 4074);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10711, 3947, 4074);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsGlobalNamespace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10711, 4149, 4213);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10711, 4185, 4198);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10711, 4149, 4213);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10711, 4086, 4224);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10711, 4086, 4224);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override AssemblySymbol ContainingAssembly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10711, 4310, 4406);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10711, 4346, 4391);

                    return f_10711_4353_4390(f_10711_4353_4371());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10711, 4310, 4406);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    f_10711_4353_4371()
                    {
                        var return_v = ContainingPEModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10711, 4353, 4371);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10711_4353_4390(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10711, 4353, 4390);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10711, 4236, 4417);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10711, 4236, 4417);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ModuleSymbol ContainingModule
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10711, 4501, 4605);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10711, 4537, 4590);

                    return f_10711_4544_4589(_containingNamespaceSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10711, 4501, 4605);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    f_10711_4544_4589(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamespaceSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingPEModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10711, 4544, 4589);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10711, 4429, 4616);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10711, 4429, 4616);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override void EnsureAllMembersLoaded()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10711, 4628, 5007);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10711, 4701, 4728);

                var
                typesByNS = _typesByNS
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10711, 4744, 4996) || true) && (lazyTypes == null || (DynAbs.Tracing.TraceSender.Expression_False(10711, 4748, 4791) || lazyNamespaces == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10711, 4744, 4996);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10711, 4825, 4876);

                    f_10711_4825_4875(typesByNS != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10711, 4894, 4920);

                    f_10711_4894_4919(this, typesByNS);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10711, 4938, 4981);

                    f_10711_4938_4980(ref _typesByNS, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10711, 4744, 4996);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10711, 4628, 5007);

                int
                f_10711_4825_4875(bool
                condition)
                {
                    System.Diagnostics.Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10711, 4825, 4875);
                    return 0;
                }


                int
                f_10711_4894_4919(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENestedNamespaceSymbol
                this_param, System.Collections.Generic.IEnumerable<System.Linq.IGrouping<string, System.Reflection.Metadata.TypeDefinitionHandle>>
                typesByNS)
                {
                    this_param.LoadAllMembers(typesByNS);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10711, 4894, 4919);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Linq.IGrouping<string, System.Reflection.Metadata.TypeDefinitionHandle>>
                f_10711_4938_4980(ref System.Collections.Generic.IEnumerable<System.Linq.IGrouping<string, System.Reflection.Metadata.TypeDefinitionHandle>>
                location1, System.Collections.Generic.IEnumerable<System.Linq.IGrouping<string, System.Reflection.Metadata.TypeDefinitionHandle>>
                value)
                {
                    var return_v = Interlocked.Exchange(ref location1, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10711, 4938, 4980);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10711, 4628, 5007);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10711, 4628, 5007);
            }
        }

        internal sealed override CSharpCompilation DeclaringCompilation // perf, not correctness
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10711, 5132, 5152);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10711, 5138, 5150);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10711, 5132, 5152);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10711, 5019, 5163);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10711, 5019, 5163);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static PENestedNamespaceSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10711, 692, 5170);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10711, 692, 5170);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10711, 692, 5170);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10711, 692, 5170);

        int
        f_10711_3369_3395(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10711, 3369, 3395);
            return 0;
        }


        int
        f_10711_3410_3459(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10711, 3410, 3459);
            return 0;
        }


        int
        f_10711_3474_3505(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10711, 3474, 3505);
            return 0;
        }

    }
}
