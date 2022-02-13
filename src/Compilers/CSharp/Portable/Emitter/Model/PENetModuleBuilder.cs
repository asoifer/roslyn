// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Emit
{
    internal sealed class PENetModuleBuilder : PEModuleBuilder
    {
        internal PENetModuleBuilder(
                    SourceModuleSymbol sourceModule,
                    EmitOptions emitOptions,
                    Cci.ModulePropertiesForSerialization serializationProperties,
                    IEnumerable<ResourceDescription> manifestResources)
        : base(f_10204_910_922_C(sourceModule), emitOptions, OutputKind.NetModule, serializationProperties, manifestResources)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10204, 637, 1024);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10204, 637, 1024);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10204, 637, 1024);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10204, 637, 1024);
            }
        }

        internal override SynthesizedAttributeData SynthesizeEmbeddedAttribute()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10204, 1036, 1257);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10204, 1209, 1246);

                throw f_10204_1215_1245();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10204, 1036, 1257);

                System.Exception
                f_10204_1215_1245()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10204, 1215, 1245);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10204, 1036, 1257);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10204, 1036, 1257);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void AddEmbeddedResourcesFromAddedModules(ArrayBuilder<Cci.ManagedResource> builder, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10204, 1269, 1472);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10204, 1424, 1461);

                throw f_10204_1430_1460();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10204, 1269, 1472);

                System.Exception
                f_10204_1430_1460()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10204, 1430, 1460);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10204, 1269, 1472);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10204, 1269, 1472);
            }
        }

        public override int CurrentGenerationOrdinal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10204, 1529, 1533);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10204, 1532, 1533);
                    return 0; DynAbs.Tracing.TraceSender.TraceExitMethod(10204, 1529, 1533);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10204, 1529, 1533);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10204, 1529, 1533);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override IEnumerable<Cci.IFileReference> GetFiles(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10204, 1622, 1685);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10204, 1625, 1685);
                return f_10204_1625_1685(); DynAbs.Tracing.TraceSender.TraceExitMethod(10204, 1622, 1685);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10204, 1622, 1685);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10204, 1622, 1685);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Generic.IEnumerable<Microsoft.Cci.IFileReference>
            f_10204_1625_1685()
            {
                var return_v = SpecializedCollections.EmptyEnumerable<Cci.IFileReference>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10204, 1625, 1685);
                return return_v;
            }

        }

        public override ISourceAssemblySymbolInternal SourceAssemblyOpt
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10204, 1760, 1767);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10204, 1763, 1767);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10204, 1760, 1767);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10204, 1760, 1767);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10204, 1760, 1767);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static PENetModuleBuilder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10204, 562, 1775);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10204, 562, 1775);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10204, 562, 1775);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10204, 562, 1775);

        static Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
        f_10204_910_922_C(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10204, 637, 1024);
            return return_v;
        }

    }
}
