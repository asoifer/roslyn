// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Reflection;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Roslyn.Utilities;
using System.Diagnostics;
using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.CSharp.Emit
{
    internal sealed class AssemblyReference : Cci.IAssemblyReference
    {
        private readonly AssemblySymbol _targetAssembly;

        internal AssemblyReference(AssemblySymbol assemblySymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10182, 701, 886);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10182, 673, 688);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10182, 783, 828);

                f_10182_783_827((object)assemblySymbol != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10182, 842, 875);

                _targetAssembly = assemblySymbol;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10182, 701, 886);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10182, 701, 886);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10182, 701, 886);
            }
        }

        public AssemblyIdentity Identity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10182, 931, 958);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10182, 934, 958);
                    return f_10182_934_958(_targetAssembly); DynAbs.Tracing.TraceSender.TraceExitMethod(10182, 931, 958);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10182, 931, 958);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10182, 931, 958);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Version AssemblyVersionPattern
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10182, 1007, 1048);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10182, 1010, 1048);
                    return f_10182_1010_1048(_targetAssembly); DynAbs.Tracing.TraceSender.TraceExitMethod(10182, 1007, 1048);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10182, 1007, 1048);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10182, 1007, 1048);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10182, 1061, 1164);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10182, 1119, 1153);

                return f_10182_1126_1152(_targetAssembly);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10182, 1061, 1164);

                string
                f_10182_1126_1152(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10182, 1126, 1152);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10182, 1061, 1164);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10182, 1061, 1164);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        void Cci.IReference.Dispatch(Cci.MetadataVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10182, 1176, 1289);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10182, 1258, 1278);

                f_10182_1258_1277(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10182, 1176, 1289);

                int
                f_10182_1258_1277(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.AssemblyReference
                assemblyReference)
                {
                    this_param.Visit((Microsoft.Cci.IAssemblyReference)assemblyReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10182, 1258, 1277);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10182, 1176, 1289);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10182, 1176, 1289);
            }
        }

        string Cci.INamedEntity.Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10182, 1330, 1346);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10182, 1333, 1346);
                    return f_10182_1333_1346(f_10182_1333_1341()); DynAbs.Tracing.TraceSender.TraceExitMethod(10182, 1330, 1346);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10182, 1330, 1346);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10182, 1330, 1346);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.IAssemblyReference Cci.IModuleReference.GetContainingAssembly(CodeAnalysis.Emit.EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10182, 1359, 1511);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10182, 1488, 1500);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10182, 1359, 1511);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10182, 1359, 1511);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10182, 1359, 1511);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        IEnumerable<Cci.ICustomAttribute> Cci.IReference.GetAttributes(CodeAnalysis.Emit.EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10182, 1523, 1730);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10182, 1649, 1719);

                return f_10182_1656_1718();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10182, 1523, 1730);

                System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
                f_10182_1656_1718()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<Cci.ICustomAttribute>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10182, 1656, 1718);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10182, 1523, 1730);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10182, 1523, 1730);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Cci.IDefinition Cci.IReference.AsDefinition(CodeAnalysis.Emit.EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10182, 1742, 1872);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10182, 1849, 1861);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10182, 1742, 1872);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10182, 1742, 1872);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10182, 1742, 1872);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        CodeAnalysis.Symbols.ISymbolInternal Cci.IReference.GetInternalSymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10182, 1956, 1963);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10182, 1959, 1963);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10182, 1956, 1963);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10182, 1956, 1963);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10182, 1956, 1963);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AssemblyReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10182, 495, 1971);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10182, 495, 1971);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10182, 495, 1971);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10182, 495, 1971);

        int
        f_10182_783_827(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10182, 783, 827);
            return 0;
        }


        Microsoft.CodeAnalysis.AssemblyIdentity
        f_10182_934_958(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        this_param)
        {
            var return_v = this_param.Identity;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10182, 934, 958);
            return return_v;
        }


        System.Version
        f_10182_1010_1048(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
        this_param)
        {
            var return_v = this_param.AssemblyVersionPattern;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10182, 1010, 1048);
            return return_v;
        }


        Microsoft.CodeAnalysis.AssemblyIdentity
        f_10182_1333_1341()
        {
            var return_v = Identity;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10182, 1333, 1341);
            return return_v;
        }


        string
        f_10182_1333_1346(Microsoft.CodeAnalysis.AssemblyIdentity
        this_param)
        {
            var return_v = this_param.Name;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10182, 1333, 1346);
            return return_v;
        }

    }
}
