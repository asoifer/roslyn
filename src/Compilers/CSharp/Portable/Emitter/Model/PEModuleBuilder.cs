// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Threading;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Emit
{
    internal abstract class PEModuleBuilder : PEModuleBuilder<CSharpCompilation, SourceModuleSymbol, AssemblySymbol, TypeSymbol, NamedTypeSymbol, MethodSymbol, SyntaxNode, NoPia.EmbeddedTypesManager, ModuleCompilationState>
    {
        protected readonly ConcurrentDictionary<Symbol, Cci.IModuleReference> AssemblyOrModuleSymbolToModuleRefMap;

        private readonly ConcurrentDictionary<Symbol, object> _genericInstanceMap;

        private readonly ConcurrentSet<TypeSymbol> _reportedErrorTypesMap;

        private readonly NoPia.EmbeddedTypesManager _embeddedTypesManagerOpt;

        public override NoPia.EmbeddedTypesManager EmbeddedTypesManagerOpt
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 1712, 1739);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 1715, 1739);
                    return _embeddedTypesManagerOpt; DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 1712, 1739);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 1712, 1739);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 1712, 1739);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private readonly string _metadataName;

        private ImmutableArray<Cci.ExportedType> _lazyExportedTypes;

        private Dictionary<FieldSymbol, NamedTypeSymbol> _fixedImplementationTypes;

        private int _needsGeneratedAttributes;

        private bool _needsGeneratedAttributes_IsFrozen;

        internal EmbeddableAttributes GetNeedsGeneratedAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 2720, 2916);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 2804, 2846);

                _needsGeneratedAttributes_IsFrozen = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 2860, 2905);

                return f_10203_2867_2904(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 2720, 2916);

                Microsoft.CodeAnalysis.CSharp.EmbeddableAttributes
                f_10203_2867_2904(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param)
                {
                    var return_v = this_param.GetNeedsGeneratedAttributesInternal();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 2867, 2904);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 2720, 2916);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 2720, 2916);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private EmbeddableAttributes GetNeedsGeneratedAttributesInternal()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 2928, 3129);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 3019, 3118);

                return (EmbeddableAttributes)_needsGeneratedAttributes | f_10203_3076_3117(Compilation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 2928, 3129);

                Microsoft.CodeAnalysis.CSharp.EmbeddableAttributes
                f_10203_3076_3117(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GetNeedsGeneratedAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 3076, 3117);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 2928, 3129);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 2928, 3129);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void SetNeedsGeneratedAttributes(EmbeddableAttributes attributes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 3141, 3391);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 3239, 3289);

                f_10203_3239_3288(!_needsGeneratedAttributes_IsFrozen);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 3303, 3380);

                f_10203_3303_3379(ref _needsGeneratedAttributes, attributes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 3141, 3391);

                int
                f_10203_3239_3288(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 3239, 3288);
                    return 0;
                }


                bool
                f_10203_3303_3379(ref int
                flags, Microsoft.CodeAnalysis.CSharp.EmbeddableAttributes
                toSet)
                {
                    var return_v = ThreadSafeFlagOperations.Set(ref flags, (int)toSet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 3303, 3379);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 3141, 3391);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 3141, 3391);
            }
        }

        internal PEModuleBuilder(
                    SourceModuleSymbol sourceModule,
                    EmitOptions emitOptions,
                    OutputKind outputKind,
                    Cci.ModulePropertiesForSerialization serializationProperties,
                    IEnumerable<ResourceDescription> manifestResources)
        : base(f_10203_3709_3767_C(f_10203_3709_3767(f_10203_3709_3746(sourceModule))), sourceModule, serializationProperties, manifestResources, outputKind, emitOptions, f_10203_3972_4000())
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10203, 3403, 4576);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 1157, 1252);
                this.AssemblyOrModuleSymbolToModuleRefMap = f_10203_1196_1252(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 1317, 1430);
                this._genericInstanceMap = f_10203_1339_1430(Symbols.SymbolEqualityComparer.ConsiderEverything); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 1484, 1540);
                this._reportedErrorTypesMap = f_10203_1509_1540(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 1597, 1621);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 1910, 1923);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 2188, 2213);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 2238, 2263);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 2287, 2321);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 4026, 4072);

                var
                specifiedName = f_10203_4046_4071(sourceModule)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 4088, 4310);

                _metadataName = (DynAbs.Tracing.TraceSender.Conditional_F1(10203, 4104, 4185) || ((specifiedName != Microsoft.CodeAnalysis.Compilation.UnspecifiedModuleAssemblyName && DynAbs.Tracing.TraceSender.Conditional_F2(10203, 4217, 4230)) || DynAbs.Tracing.TraceSender.Conditional_F3(10203, 4262, 4309))) ? specifiedName : f_10203_4262_4292(emitOptions) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(10203, 4262, 4309) ?? specifiedName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 4326, 4387);

                f_10203_4326_4386(
                            AssemblyOrModuleSymbolToModuleRefMap, sourceModule, this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 4403, 4565) || true) && (f_10203_4407_4452(sourceModule))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 4403, 4565);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 4486, 4550);

                    _embeddedTypesManagerOpt = f_10203_4513_4549(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 4403, 4565);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10203, 3403, 4576);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 3403, 4576);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 3403, 4576);
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 4640, 4669);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 4646, 4667);

                    return _metadataName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 4640, 4669);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 4588, 4680);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 4588, 4680);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override string ModuleName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 4759, 4788);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 4765, 4786);

                    return _metadataName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 4759, 4788);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 4692, 4799);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 4692, 4799);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override Cci.ICustomAttribute SynthesizeAttribute(WellKnownMember attributeConstructor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 4811, 5014);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 4939, 5003);

                return f_10203_4946_5002(Compilation, attributeConstructor);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 4811, 5014);

                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10203_4946_5002(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 4946, 5002);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 4811, 5014);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 4811, 5014);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override IEnumerable<Cci.ICustomAttribute> GetSourceAssemblyAttributes(bool isRefAssembly)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 5026, 5341);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 5155, 5330);

                return f_10203_5162_5329(f_10203_5162_5199(SourceModule), this, isRefAssembly, emittingAssemblyAttributesInNetModule: f_10203_5304_5328(OutputKind));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 5026, 5341);

                Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                f_10203_5162_5199(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSourceAssembly
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 5162, 5199);
                    return return_v;
                }


                bool
                f_10203_5304_5328(Microsoft.CodeAnalysis.OutputKind
                kind)
                {
                    var return_v = kind.IsNetModule();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 5304, 5328);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10203_5162_5329(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBuilder, bool
                emittingRefAssembly, bool
                emittingAssemblyAttributesInNetModule)
                {
                    var return_v = this_param.GetCustomAttributesToEmit(moduleBuilder, emittingRefAssembly, emittingAssemblyAttributesInNetModule: emittingAssemblyAttributesInNetModule);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 5162, 5329);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 5026, 5341);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 5026, 5341);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override IEnumerable<Cci.SecurityAttribute> GetSourceAssemblySecurityAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 5353, 5553);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 5473, 5542);

                return f_10203_5480_5541(f_10203_5480_5517(SourceModule));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 5353, 5553);

                Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                f_10203_5480_5517(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSourceAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 5480, 5517);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.Cci.SecurityAttribute>
                f_10203_5480_5541(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.GetSecurityAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 5480, 5541);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 5353, 5553);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 5353, 5553);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override IEnumerable<Cci.ICustomAttribute> GetSourceModuleAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 5565, 5737);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 5674, 5726);

                return f_10203_5681_5725(SourceModule, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 5565, 5737);

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10203_5681_5725(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBuilder)
                {
                    var return_v = this_param.GetCustomAttributesToEmit(moduleBuilder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 5681, 5725);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 5565, 5737);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 5565, 5737);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override AssemblySymbol CorLibrary
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 5824, 5888);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 5830, 5886);

                    return f_10203_5837_5885(f_10203_5837_5874(SourceModule));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 5824, 5888);

                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    f_10203_5837_5874(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSourceAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 5837, 5874);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10203_5837_5885(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.CorLibrary;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 5837, 5885);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 5749, 5899);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 5749, 5899);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool GenerateVisualBasicStylePdb
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 5967, 5975);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 5970, 5975);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 5967, 5975);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 5967, 5975);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 5967, 5975);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override IEnumerable<string> LinkedAssembliesDebugInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 6118, 6169);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 6121, 6169);
                    return f_10203_6121_6169(); DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 6118, 6169);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 6118, 6169);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 6118, 6169);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableArray<Cci.UsedNamespaceOrType> GetImports()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 6341, 6389);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 6344, 6389);
                return ImmutableArray<Cci.UsedNamespaceOrType>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 6341, 6389);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 6341, 6389);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 6341, 6389);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override string DefaultNamespace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 6523, 6530);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 6526, 6530);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 6523, 6530);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 6523, 6530);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 6523, 6530);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected sealed override IEnumerable<Cci.IAssemblyReference> GetAssemblyReferencesFromAddedModules(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 6543, 7064);

                var listYield = new List<Cci.IAssemblyReference>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 6694, 6773);

                ImmutableArray<ModuleSymbol>
                modules = f_10203_6733_6772(f_10203_6733_6764(SourceModule))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 6798, 6803);

                    for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 6789, 7053) || true) && (i < modules.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 6825, 6828)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 6789, 7053))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 6789, 7053);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 6862, 7038);
                            foreach (AssemblySymbol aRef in f_10203_6894_6935_I(f_10203_6894_6935(modules[i])))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 6862, 7038);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 6977, 7019);

                                listYield.Add(f_10203_6990_7018(this, aRef, diagnostics));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 6862, 7038);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10203, 1, 177);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10203, 1, 177);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10203, 1, 265);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10203, 1, 265);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 6543, 7064);

                return listYield;

                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10203_6733_6764(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 6733, 6764);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_10203_6733_6772(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 6733, 6772);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                f_10203_6894_6935(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.GetReferencedAssemblySymbols();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 6894, 6935);
                    return return_v;
                }


                Microsoft.Cci.IAssemblyReference
                f_10203_6990_7018(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                assembly, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(assembly, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 6990, 7018);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                f_10203_6894_6935_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 6894, 6935);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 6543, 7064);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 6543, 7064);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ValidateReferencedAssembly(AssemblySymbol assembly, AssemblyReference asmRef, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 7076, 9657);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 7218, 7290);

                AssemblyIdentity
                asmIdentity = f_10203_7249_7289(f_10203_7249_7280(SourceModule))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 7304, 7351);

                AssemblyIdentity
                refIdentity = f_10203_7335_7350(asmRef)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 7367, 7863) || true) && (f_10203_7371_7395(asmIdentity) && (DynAbs.Tracing.TraceSender.Expression_True(10203, 7371, 7424) && f_10203_7399_7424_M(!refIdentity.IsStrongName)) && (DynAbs.Tracing.TraceSender.Expression_True(10203, 7371, 7510) && f_10203_7445_7472(f_10203_7445_7460(asmRef)) != AssemblyContentType.WindowsRuntime))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 7367, 7863);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 7723, 7848);

                    f_10203_7723_7847(                // Dev12 reported error, we have changed it to a warning to allow referencing libraries 
                                                      // built for platforms that don't support strong names.
                                    diagnostics, f_10203_7739_7824(ErrorCode.WRN_ReferencedAssemblyDoesNotHaveStrongName, assembly), NoLocation.Singleton);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 7367, 7863);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 7879, 8281) || true) && (OutputKind != OutputKind.NetModule && (DynAbs.Tracing.TraceSender.Expression_True(10203, 7883, 7983) && !f_10203_7938_7983(f_10203_7959_7982(refIdentity))) && (DynAbs.Tracing.TraceSender.Expression_True(10203, 7883, 8103) && !f_10203_8004_8103(f_10203_8018_8041(refIdentity), f_10203_8043_8066(asmIdentity), StringComparison.OrdinalIgnoreCase)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 7879, 8281);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 8137, 8266);

                    f_10203_8137_8265(diagnostics, f_10203_8153_8242(ErrorCode.WRN_RefCultureMismatch, assembly, f_10203_8218_8241(refIdentity)), NoLocation.Singleton);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 7879, 8281);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 8297, 8331);

                var
                refMachine = f_10203_8314_8330(assembly)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 8832, 9417) || true) && ((object)assembly != (object)f_10203_8864_8883(assembly) && (DynAbs.Tracing.TraceSender.Expression_True(10203, 8836, 8960) && !(refMachine == Machine.I386 && (DynAbs.Tracing.TraceSender.Expression_True(10203, 8906, 8959) && f_10203_8936_8959_M(!assembly.Bit32Required)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 8832, 9417);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 8994, 9029);

                    var
                    machine = f_10203_9008_9028(SourceModule)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 9049, 9402) || true) && (!(machine == Machine.I386 && (DynAbs.Tracing.TraceSender.Expression_True(10203, 9055, 9109) && f_10203_9082_9109_M(!SourceModule.Bit32Required))) && (DynAbs.Tracing.TraceSender.Expression_True(10203, 9053, 9156) && machine != refMachine))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 9049, 9402);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 9271, 9383);

                        f_10203_9271_9382(                    // Different machine types, and neither is agnostic
                                            diagnostics, f_10203_9287_9359(ErrorCode.WRN_ConflictingMachineAssembly, assembly), NoLocation.Singleton);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 9049, 9402);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 8832, 9417);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 9433, 9646) || true) && (_embeddedTypesManagerOpt != null && (DynAbs.Tracing.TraceSender.Expression_True(10203, 9437, 9506) && f_10203_9473_9506(_embeddedTypesManagerOpt)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 9433, 9646);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 9540, 9631);

                    f_10203_9540_9630(_embeddedTypesManagerOpt, assembly, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 9433, 9646);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 7076, 9657);

                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10203_7249_7280(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 7249, 7280);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_10203_7249_7289(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 7249, 7289);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_10203_7335_7350(Microsoft.CodeAnalysis.CSharp.Emit.AssemblyReference
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 7335, 7350);
                    return return_v;
                }


                bool
                f_10203_7371_7395(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.IsStrongName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 7371, 7395);
                    return return_v;
                }


                bool
                f_10203_7399_7424_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 7399, 7424);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_10203_7445_7460(Microsoft.CodeAnalysis.CSharp.Emit.AssemblyReference
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 7445, 7460);
                    return return_v;
                }


                System.Reflection.AssemblyContentType
                f_10203_7445_7472(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.ContentType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 7445, 7472);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10203_7739_7824(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 7739, 7824);
                    return return_v;
                }


                int
                f_10203_7723_7847(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 7723, 7847);
                    return 0;
                }


                string
                f_10203_7959_7982(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.CultureName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 7959, 7982);
                    return return_v;
                }


                bool
                f_10203_7938_7983(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 7938, 7983);
                    return return_v;
                }


                string
                f_10203_8018_8041(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.CultureName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 8018, 8041);
                    return return_v;
                }


                string
                f_10203_8043_8066(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.CultureName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 8043, 8066);
                    return return_v;
                }


                bool
                f_10203_8004_8103(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 8004, 8103);
                    return return_v;
                }


                string
                f_10203_8218_8241(Microsoft.CodeAnalysis.AssemblyIdentity
                this_param)
                {
                    var return_v = this_param.CultureName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 8218, 8241);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10203_8153_8242(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 8153, 8242);
                    return return_v;
                }


                int
                f_10203_8137_8265(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 8137, 8265);
                    return 0;
                }


                System.Reflection.PortableExecutable.Machine
                f_10203_8314_8330(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.Machine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 8314, 8330);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10203_8864_8883(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.CorLibrary;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 8864, 8883);
                    return return_v;
                }


                bool
                f_10203_8936_8959_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 8936, 8959);
                    return return_v;
                }


                System.Reflection.PortableExecutable.Machine
                f_10203_9008_9028(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                this_param)
                {
                    var return_v = this_param.Machine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 9008, 9028);
                    return return_v;
                }


                bool
                f_10203_9082_9109_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 9082, 9109);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10203_9287_9359(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 9287, 9359);
                    return return_v;
                }


                int
                f_10203_9271_9382(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 9271, 9382);
                    return 0;
                }


                bool
                f_10203_9473_9506(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
                this_param)
                {
                    var return_v = this_param.IsFrozen;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 9473, 9506);
                    return return_v;
                }


                int
                f_10203_9540_9630(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                a, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ReportIndirectReferencesToLinkedAssemblies(a, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 9540, 9630);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 7076, 9657);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 7076, 9657);
            }
        }

        internal sealed override IEnumerable<Cci.INestedTypeDefinition> GetSynthesizedNestedTypes(NamedTypeSymbol container)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 9669, 9833);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 9810, 9822);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 9669, 9833);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 9669, 9833);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 9669, 9833);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override MultiDictionary<Cci.DebugSourceDocument, Cci.DefinitionWithLocation> GetSymbolToLocationMap()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 9845, 15063);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 9986, 10074);

                var
                result = f_10203_9999_10073()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 10090, 10159);

                var
                namespacesAndTypesToProcess = f_10203_10124_10158()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 10173, 10236);

                f_10203_10173_10235(namespacesAndTypesToProcess, f_10203_10206_10234(SourceModule));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 10252, 10277);

                Location
                location = null
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 10293, 15022) || true) && (f_10203_10300_10333(namespacesAndTypesToProcess) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 10293, 15022);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 10371, 10436);

                        NamespaceOrTypeSymbol
                        symbol = f_10203_10402_10435(namespacesAndTypesToProcess)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 10454, 15007);

                        switch (f_10203_10462_10473(symbol))
                        {

                            case SymbolKind.Namespace:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 10454, 15007);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 10567, 10618);

                                location = f_10203_10578_10617(this, symbol);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 10802, 11562) || true) && (location != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 10802, 11562);
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 10880, 11535);
                                        foreach (var member in f_10203_10903_10922_I(f_10203_10903_10922(symbol)))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 10880, 11535);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 10988, 11504);

                                            switch (f_10203_10996_11007(member))
                                            {

                                                case SymbolKind.Namespace:
                                                case SymbolKind.NamedType:
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 10988, 11504);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 11213, 11277);

                                                    f_10203_11213_11276(namespacesAndTypesToProcess, member);
                                                    DynAbs.Tracing.TraceSender.TraceBreak(10203, 11319, 11325);

                                                    break;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 10988, 11504);

                                                default:
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 10988, 11504);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 11415, 11469);

                                                    throw f_10203_11421_11468(f_10203_11456_11467(member));
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 10988, 11504);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 10880, 11535);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10203, 1, 656);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(10203, 1, 656);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 10802, 11562);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10203, 11588, 11594);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 10454, 15007);

                            case SymbolKind.NamedType:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 10454, 15007);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 11670, 11721);

                                location = f_10203_11681_11720(this, symbol);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 11747, 14844) || true) && (location != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 11747, 14844);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 11887, 11964);

                                    f_10203_11887_11963(this, result, location, f_10203_11940_11962(symbol));
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 11996, 14817);
                                        foreach (var member in f_10203_12019_12038_I(f_10203_12019_12038(symbol)))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 11996, 14817);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 12104, 14786);

                                            switch (f_10203_12112_12123(member))
                                            {

                                                case SymbolKind.NamedType:
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 12104, 14786);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 12265, 12329);

                                                    f_10203_12265_12328(namespacesAndTypesToProcess, member);
                                                    DynAbs.Tracing.TraceSender.TraceBreak(10203, 12371, 12377);

                                                    break;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 12104, 14786);

                                                case SymbolKind.Method:
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 12104, 14786);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 12707, 12741);

                                                    var
                                                    method = (MethodSymbol)member
                                                    ;

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 12783, 12946) || true) && (!f_10203_12788_12807(method))
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 12783, 12946);
                                                        DynAbs.Tracing.TraceSender.TraceBreak(10203, 12897, 12903);

                                                        break;
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 12783, 12946);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 12990, 13024);

                                                    f_10203_12990_13023(this, result, member);
                                                    DynAbs.Tracing.TraceSender.TraceBreak(10203, 13066, 13072);

                                                    break;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 12104, 14786);

                                                case SymbolKind.Property:
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 12104, 14786);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 13179, 13213);

                                                    f_10203_13179_13212(this, result, member);
                                                    DynAbs.Tracing.TraceSender.TraceBreak(10203, 13255, 13261);

                                                    break;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 12104, 14786);

                                                case SymbolKind.Field:
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 12104, 14786);
                                                    // NOTE: Dev11 does not add synthesized backing fields for properties,
                                                    //       but adds backing fields for events, Roslyn adds both
                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 13625, 13657);

                                                        var
                                                        field = (FieldSymbol)member
                                                        ;
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 13703, 13766);

                                                        f_10203_13703_13765(this, result, f_10203_13729_13755(field) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>(10203, 13729, 13764) ?? field));
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceBreak(10203, 13851, 13857);

                                                    break;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 12104, 14786);

                                                case SymbolKind.Event:
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 12104, 14786);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 13961, 13995);

                                                    f_10203_13961_13994(this, result, member);
                                                    //  event backing fields do not show up in GetMembers
                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 14179, 14237);

                                                        FieldSymbol
                                                        field = f_10203_14199_14236(((EventSymbol)member))
                                                        ;

                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 14283, 14516) || true) && ((object)field != null)
                                                        )

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 14283, 14516);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 14406, 14469);

                                                            f_10203_14406_14468(this, result, f_10203_14432_14458(field) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>(10203, 14432, 14467) ?? field));
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 14283, 14516);
                                                        }
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceBreak(10203, 14601, 14607);

                                                    break;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 12104, 14786);

                                                default:
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 12104, 14786);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 14697, 14751);

                                                    throw f_10203_14703_14750(f_10203_14738_14749(member));
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 12104, 14786);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 11996, 14817);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10203, 1, 2822);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(10203, 1, 2822);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 11747, 14844);
                                }
                                DynAbs.Tracing.TraceSender.TraceBreak(10203, 14870, 14876);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 10454, 15007);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 10454, 15007);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 14934, 14988);

                                throw f_10203_14940_14987(f_10203_14975_14986(symbol));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 10454, 15007);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 10293, 15022);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10203, 10293, 15022);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10203, 10293, 15022);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 15038, 15052);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 9845, 15063);

                Roslyn.Utilities.MultiDictionary<Microsoft.Cci.DebugSourceDocument, Microsoft.Cci.DefinitionWithLocation>
                f_10203_9999_10073()
                {
                    var return_v = new Roslyn.Utilities.MultiDictionary<Microsoft.Cci.DebugSourceDocument, Microsoft.Cci.DefinitionWithLocation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 9999, 10073);
                    return return_v;
                }


                System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                f_10203_10124_10158()
                {
                    var return_v = new System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 10124, 10158);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10203_10206_10234(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 10206, 10234);
                    return return_v;
                }


                int
                f_10203_10173_10235(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                item)
                {
                    this_param.Push((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 10173, 10235);
                    return 0;
                }


                int
                f_10203_10300_10333(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 10300, 10333);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                f_10203_10402_10435(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 10402, 10435);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10203_10462_10473(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 10462, 10473);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10203_10578_10617(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                symbol)
                {
                    var return_v = this_param.GetSmallestSourceLocationOrNull((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 10578, 10617);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10203_10903_10922(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 10903, 10922);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10203_10996_11007(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 10996, 11007);
                    return return_v;
                }


                int
                f_10203_11213_11276(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    this_param.Push((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 11213, 11276);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10203_11456_11467(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 11456, 11467);
                    return return_v;
                }


                System.Exception
                f_10203_11421_11468(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 11421, 11468);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10203_10903_10922_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 10903, 10922);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10203_11681_11720(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                symbol)
                {
                    var return_v = this_param.GetSmallestSourceLocationOrNull((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 11681, 11720);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SymbolAdapter
                f_10203_11940_11962(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 11940, 11962);
                    return return_v;
                }


                int
                f_10203_11887_11963(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Roslyn.Utilities.MultiDictionary<Microsoft.Cci.DebugSourceDocument, Microsoft.Cci.DefinitionWithLocation>
                result, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.CSharp.SymbolAdapter
                definition)
                {
                    this_param.AddSymbolLocation(result, location, (Microsoft.Cci.IDefinition)definition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 11887, 11963);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10203_12019_12038(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 12019, 12038);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10203_12112_12123(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 12112, 12123);
                    return return_v;
                }


                int
                f_10203_12265_12328(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    this_param.Push((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 12265, 12328);
                    return 0;
                }


                bool
                f_10203_12788_12807(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = method.ShouldEmit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 12788, 12807);
                    return return_v;
                }


                int
                f_10203_12990_13023(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Roslyn.Utilities.MultiDictionary<Microsoft.Cci.DebugSourceDocument, Microsoft.Cci.DefinitionWithLocation>
                result, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    this_param.AddSymbolLocation(result, symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 12990, 13023);
                    return 0;
                }


                int
                f_10203_13179_13212(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Roslyn.Utilities.MultiDictionary<Microsoft.Cci.DebugSourceDocument, Microsoft.Cci.DefinitionWithLocation>
                result, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    this_param.AddSymbolLocation(result, symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 13179, 13212);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10203_13729_13755(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.TupleUnderlyingField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 13729, 13755);
                    return return_v;
                }


                int
                f_10203_13703_13765(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Roslyn.Utilities.MultiDictionary<Microsoft.Cci.DebugSourceDocument, Microsoft.Cci.DefinitionWithLocation>
                result, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                symbol)
                {
                    this_param.AddSymbolLocation(result, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 13703, 13765);
                    return 0;
                }


                int
                f_10203_13961_13994(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Roslyn.Utilities.MultiDictionary<Microsoft.Cci.DebugSourceDocument, Microsoft.Cci.DefinitionWithLocation>
                result, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    this_param.AddSymbolLocation(result, symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 13961, 13994);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol?
                f_10203_14199_14236(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                this_param)
                {
                    var return_v = this_param.AssociatedField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 14199, 14236);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10203_14432_14458(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.TupleUnderlyingField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 14432, 14458);
                    return return_v;
                }


                int
                f_10203_14406_14468(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Roslyn.Utilities.MultiDictionary<Microsoft.Cci.DebugSourceDocument, Microsoft.Cci.DefinitionWithLocation>
                result, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                symbol)
                {
                    this_param.AddSymbolLocation(result, (Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 14406, 14468);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10203_14738_14749(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 14738, 14749);
                    return return_v;
                }


                System.Exception
                f_10203_14703_14750(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 14703, 14750);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10203_12019_12038_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 12019, 12038);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10203_14975_14986(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 14975, 14986);
                    return return_v;
                }


                System.Exception
                f_10203_14940_14987(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 14940, 14987);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 9845, 15063);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 9845, 15063);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void AddSymbolLocation(MultiDictionary<Cci.DebugSourceDocument, Cci.DefinitionWithLocation> result, Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 15075, 15448);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 15222, 15277);

                var
                location = f_10203_15237_15276(this, symbol)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 15291, 15437) || true) && (location != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 15291, 15437);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 15345, 15422);

                    f_10203_15345_15421(this, result, location, f_10203_15398_15420(symbol));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 15291, 15437);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 15075, 15448);

                Microsoft.CodeAnalysis.Location
                f_10203_15237_15276(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                symbol)
                {
                    var return_v = this_param.GetSmallestSourceLocationOrNull(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 15237, 15276);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SymbolAdapter
                f_10203_15398_15420(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 15398, 15420);
                    return return_v;
                }


                int
                f_10203_15345_15421(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Roslyn.Utilities.MultiDictionary<Microsoft.Cci.DebugSourceDocument, Microsoft.Cci.DefinitionWithLocation>
                result, Microsoft.CodeAnalysis.Location
                location, Microsoft.CodeAnalysis.CSharp.SymbolAdapter
                definition)
                {
                    this_param.AddSymbolLocation(result, location, (Microsoft.Cci.IDefinition)definition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 15345, 15421);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 15075, 15448);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 15075, 15448);
            }
        }

        private void AddSymbolLocation(MultiDictionary<Cci.DebugSourceDocument, Cci.DefinitionWithLocation> result, Location location, Cci.IDefinition definition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 15460, 16291);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 15639, 15690);

                FileLinePositionSpan
                span = f_10203_15667_15689(location)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 15706, 15829);

                Cci.DebugSourceDocument
                doc = f_10203_15736_15828(DebugDocumentsBuilder, span.Path, basePath: f_10203_15799_15827(f_10203_15799_15818(location)))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 15845, 16280) || true) && (doc != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 15845, 16280);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 15894, 16265);

                    f_10203_15894_16264(result, doc, f_10203_15938_16263(definition, span.StartLinePosition.Line, span.StartLinePosition.Character, span.EndLinePosition.Line, span.EndLinePosition.Character));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 15845, 16280);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 15460, 16291);

                Microsoft.CodeAnalysis.FileLinePositionSpan
                f_10203_15667_15689(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.GetLineSpan();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 15667, 15689);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree?
                f_10203_15799_15818(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.SourceTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 15799, 15818);
                    return return_v;
                }


                string
                f_10203_15799_15827(Microsoft.CodeAnalysis.SyntaxTree?
                this_param)
                {
                    var return_v = this_param.FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 15799, 15827);
                    return return_v;
                }


                Microsoft.Cci.DebugSourceDocument
                f_10203_15736_15828(Microsoft.CodeAnalysis.Emit.DebugDocumentsBuilder
                this_param, string
                path, string
                basePath)
                {
                    var return_v = this_param.TryGetDebugDocument(path, basePath: basePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 15736, 15828);
                    return return_v;
                }


                Microsoft.Cci.DefinitionWithLocation
                f_10203_15938_16263(Microsoft.Cci.IDefinition
                definition, int
                startLine, int
                startColumn, int
                endLine, int
                endColumn)
                {
                    var return_v = new Microsoft.Cci.DefinitionWithLocation(definition, startLine, startColumn, endLine, endColumn);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 15938, 16263);
                    return return_v;
                }


                bool
                f_10203_15894_16264(Roslyn.Utilities.MultiDictionary<Microsoft.Cci.DebugSourceDocument, Microsoft.Cci.DefinitionWithLocation>
                this_param, Microsoft.Cci.DebugSourceDocument
                k, Microsoft.Cci.DefinitionWithLocation
                v)
                {
                    var return_v = this_param.Add(k, v);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 15894, 16264);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 15460, 16291);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 15460, 16291);
            }
        }

        private Location GetSmallestSourceLocationOrNull(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 16303, 16905);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 16391, 16451);

                CSharpCompilation
                compilation = f_10203_16423_16450(symbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 16465, 16559);

                f_10203_16465_16558(Compilation == compilation, "How did we get symbol from different compilation?");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 16575, 16598);

                Location
                result = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 16612, 16864);
                    foreach (var loc in f_10203_16632_16648_I(f_10203_16632_16648(symbol)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 16612, 16864);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 16682, 16849) || true) && (f_10203_16686_16700(loc) && (DynAbs.Tracing.TraceSender.Expression_True(10203, 16686, 16775) && (result == null || (DynAbs.Tracing.TraceSender.Expression_False(10203, 16705, 16774) || f_10203_16723_16770(compilation, result, loc) > 0))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 16682, 16849);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 16817, 16830);

                            result = loc;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 16682, 16849);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 16612, 16864);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10203, 1, 253);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10203, 1, 253);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 16880, 16894);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 16303, 16905);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10203_16423_16450(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 16423, 16450);
                    return return_v;
                }


                int
                f_10203_16465_16558(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 16465, 16558);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10203_16632_16648(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Locations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 16632, 16648);
                    return return_v;
                }


                bool
                f_10203_16686_16700(Microsoft.CodeAnalysis.Location
                this_param)
                {
                    var return_v = this_param.IsInSource;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 16686, 16700);
                    return return_v;
                }


                int
                f_10203_16723_16770(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.Location
                loc1, Microsoft.CodeAnalysis.Location
                loc2)
                {
                    var return_v = this_param.CompareSourceLocations(loc1, loc2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 16723, 16770);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10203_16632_16648_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 16632, 16648);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 16303, 16905);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 16303, 16905);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual bool IgnoreAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 17192, 17200);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 17195, 17200);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 17192, 17200);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 17192, 17200);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 17192, 17200);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual bool IsEncDelta
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 17344, 17352);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 17347, 17352);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 17344, 17352);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 17344, 17352);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 17344, 17352);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal virtual NamedTypeSymbol GetDynamicOperationContextType(NamedTypeSymbol contextType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 17506, 17653);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 17623, 17642);

                return contextType;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 17506, 17653);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 17506, 17653);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 17506, 17653);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual VariableSlotAllocator TryCreateVariableSlotAllocator(MethodSymbol method, MethodSymbol topLevelMethod, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 17665, 17859);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 17836, 17848);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 17665, 17859);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 17665, 17859);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 17665, 17859);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual ImmutableArray<AnonymousTypeKey> GetPreviousAnonymousTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 17871, 18030);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 17973, 18019);

                return ImmutableArray<AnonymousTypeKey>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 17871, 18030);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 17871, 18030);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 17871, 18030);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual int GetNextAnonymousTypeIndex()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 18042, 18135);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 18115, 18124);

                return 0;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 18042, 18135);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 18042, 18135);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 18042, 18135);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual bool TryGetAnonymousTypeName(AnonymousTypeManager.AnonymousTypeTemplateSymbol template, out string name, out int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 18147, 18458);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 18308, 18367);

                f_10203_18308_18366(Compilation == f_10203_18336_18365(template));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 18383, 18395);

                name = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 18409, 18420);

                index = -1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 18434, 18447);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 18147, 18458);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10203_18336_18365(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager.AnonymousTypeTemplateSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 18336, 18365);
                    return return_v;
                }


                int
                f_10203_18308_18366(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 18308, 18366);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 18147, 18458);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 18147, 18458);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override IEnumerable<Cci.INamespaceTypeDefinition> GetAnonymousTypeDefinitions(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 18470, 18951);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 18608, 18759) || true) && (context.MetadataOnly)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 18608, 18759);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 18666, 18744);

                    return f_10203_18673_18743();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 18608, 18759);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 18775, 18940);

                return f_10203_18782_18839(f_10203_18782_18814(Compilation))

                   .Select(type => type.GetCciAdapter())
                                   ;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 18470, 18951);

                System.Collections.Generic.IEnumerable<Microsoft.Cci.INamespaceTypeDefinition>
                f_10203_18673_18743()
                {
                    var return_v = SpecializedCollections.EmptyEnumerable<Cci.INamespaceTypeDefinition>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 18673, 18743);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                f_10203_18782_18814(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.AnonymousTypeManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 18782, 18814);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10203_18782_18839(Microsoft.CodeAnalysis.CSharp.Symbols.AnonymousTypeManager
                this_param)
                {
                    var return_v = this_param.GetAllCreatedTemplates();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 18782, 18839);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 18470, 18951);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 18470, 18951);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IEnumerable<Cci.INamespaceTypeDefinition> GetTopLevelSourceTypeDefinitions(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 18963, 19802);

                var listYield = new List<Cci.INamespaceTypeDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 19099, 19154);

                var
                namespacesToProcess = f_10203_19125_19153()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 19168, 19223);

                f_10203_19168_19222(namespacesToProcess, f_10203_19193_19221(SourceModule));
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 19239, 19791) || true) && (f_10203_19246_19271(namespacesToProcess) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 19239, 19791);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 19309, 19344);

                        var
                        ns = f_10203_19318_19343(namespacesToProcess)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 19362, 19776);
                            foreach (var member in f_10203_19385_19400_I(f_10203_19385_19400(ns)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 19362, 19776);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 19442, 19757) || true) && (f_10203_19446_19457(member) == SymbolKind.Namespace)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 19442, 19757);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 19531, 19581);

                                    f_10203_19531_19580(namespacesToProcess, member);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 19442, 19757);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 19442, 19757);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 19679, 19734);

                                    listYield.Add(f_10203_19692_19733(((NamedTypeSymbol)member)));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 19442, 19757);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 19362, 19776);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10203, 1, 415);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10203, 1, 415);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 19239, 19791);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10203, 19239, 19791);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10203, 19239, 19791);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 18963, 19802);

                return listYield;

                System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                f_10203_19125_19153()
                {
                    var return_v = new System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 19125, 19153);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10203_19193_19221(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 19193, 19221);
                    return return_v;
                }


                int
                f_10203_19168_19222(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 19168, 19222);
                    return 0;
                }


                int
                f_10203_19246_19271(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 19246, 19271);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10203_19318_19343(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 19318, 19343);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10203_19385_19400(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 19385, 19400);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10203_19446_19457(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 19446, 19457);
                    return return_v;
                }


                int
                f_10203_19531_19580(System.Collections.Generic.Stack<Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                item)
                {
                    this_param.Push((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 19531, 19580);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                f_10203_19692_19733(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 19692, 19733);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10203_19385_19400_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 19385, 19400);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 18963, 19802);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 18963, 19802);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void GetExportedTypes(NamespaceOrTypeSymbol symbol, int parentIndex, ArrayBuilder<Cci.ExportedType> builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10203, 19814, 20834);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 19962, 19972);

                int
                index
                = default(int);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 19986, 20498) || true) && (f_10203_19990_20001(symbol) == SymbolKind.NamedType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 19986, 20498);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 20059, 20183) || true) && (f_10203_20063_20091(symbol) != Accessibility.Public)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 20059, 20183);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 20157, 20164);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 20059, 20183);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 20203, 20237);

                    f_10203_20203_20236(f_10203_20216_20235(symbol));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 20255, 20277);

                    index = f_10203_20263_20276(builder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 20295, 20406);

                    f_10203_20295_20405(builder, f_10203_20307_20404(f_10203_20348_20370(symbol), parentIndex, isForwarder: false));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 19986, 20498);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 19986, 20498);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 20472, 20483);

                    index = -1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 19986, 20498);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 20514, 20823);
                    foreach (var member in f_10203_20537_20556_I(f_10203_20537_20556(symbol)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 20514, 20823);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 20590, 20644);

                        var
                        namespaceOrType = member as NamespaceOrTypeSymbol
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 20662, 20808) || true) && ((object)namespaceOrType != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 20662, 20808);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 20739, 20789);

                            f_10203_20739_20788(namespaceOrType, index, builder);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 20662, 20808);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 20514, 20823);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10203, 1, 310);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10203, 1, 310);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10203, 19814, 20834);

                Microsoft.CodeAnalysis.SymbolKind
                f_10203_19990_20001(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 19990, 20001);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10203_20063_20091(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 20063, 20091);
                    return return_v;
                }


                bool
                f_10203_20216_20235(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 20216, 20235);
                    return return_v;
                }


                int
                f_10203_20203_20236(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 20203, 20236);
                    return 0;
                }


                int
                f_10203_20263_20276(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ExportedType>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 20263, 20276);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.SymbolAdapter
                f_10203_20348_20370(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 20348, 20370);
                    return return_v;
                }


                Microsoft.Cci.ExportedType
                f_10203_20307_20404(Microsoft.CodeAnalysis.CSharp.SymbolAdapter
                type, int
                parentIndex, bool
                isForwarder)
                {
                    var return_v = new Microsoft.Cci.ExportedType((Microsoft.Cci.ITypeReference)type, parentIndex, isForwarder: isForwarder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 20307, 20404);
                    return return_v;
                }


                int
                f_10203_20295_20405(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ExportedType>
                this_param, Microsoft.Cci.ExportedType
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 20295, 20405);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10203_20537_20556(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 20537, 20556);
                    return return_v;
                }


                int
                f_10203_20739_20788(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                symbol, int
                parentIndex, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ExportedType>
                builder)
                {
                    GetExportedTypes(symbol, parentIndex, builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 20739, 20788);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                f_10203_20537_20556_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 20537, 20556);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 19814, 20834);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 19814, 20834);
            }
        }

        public sealed override ImmutableArray<Cci.ExportedType> GetExportedTypes(DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 20846, 21388);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 20970, 21012);

                f_10203_20970_21011(f_10203_20983_21010());

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 21028, 21335) || true) && (_lazyExportedTypes.IsDefault)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 21028, 21335);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 21094, 21140);

                    _lazyExportedTypes = f_10203_21115_21139(this);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 21160, 21320) || true) && (_lazyExportedTypes.Length > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 21160, 21320);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 21235, 21301);

                        f_10203_21235_21300(this, _lazyExportedTypes, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 21160, 21320);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 21028, 21335);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 21351, 21377);

                return _lazyExportedTypes;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 20846, 21388);

                bool
                f_10203_20983_21010()
                {
                    var return_v = HaveDeterminedTopLevelTypes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 20983, 21010);
                    return return_v;
                }


                int
                f_10203_20970_21011(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 20970, 21011);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ExportedType>
                f_10203_21115_21139(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param)
                {
                    var return_v = this_param.CalculateExportedTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 21115, 21139);
                    return return_v;
                }


                int
                f_10203_21235_21300(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ExportedType>
                exportedTypes, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ReportExportedTypeNameCollisions(exportedTypes, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 21235, 21300);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 20846, 21388);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 20846, 21388);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<Cci.ExportedType> CalculateExportedTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 21653, 22474);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 21743, 21819);

                SourceAssemblySymbol
                sourceAssembly = f_10203_21781_21818(SourceModule)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 21833, 21892);

                var
                builder = f_10203_21847_21891()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 21908, 22227) || true) && (!f_10203_21913_21937(OutputKind))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 21908, 22227);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 21971, 22008);

                    var
                    modules = f_10203_21985_22007(sourceAssembly)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 22035, 22040);
                        for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 22026, 22212) || true) && (i < modules.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 22062, 22065)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 22026, 22212)) //NOTE: skipping modules[0]

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 22026, 22212);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 22135, 22193);

                            f_10203_22135_22192(f_10203_22152_22178(modules[i]), -1, builder);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10203, 1, 187);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10203, 1, 187);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 21908, 22227);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 22243, 22354);

                f_10203_22243_22353(f_10203_22256_22280(OutputKind) == f_10203_22284_22352(f_10203_22284_22338(f_10203_22284_22327(f_10203_22284_22319(sourceAssembly)))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 22368, 22411);

                f_10203_22368_22410(sourceAssembly, builder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 22427, 22463);

                return f_10203_22434_22462(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 21653, 22474);

                Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                f_10203_21781_21818(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSourceAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 21781, 21818);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ExportedType>
                f_10203_21847_21891()
                {
                    var return_v = ArrayBuilder<Cci.ExportedType>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 21847, 21891);
                    return return_v;
                }


                bool
                f_10203_21913_21937(Microsoft.CodeAnalysis.OutputKind
                kind)
                {
                    var return_v = kind.IsNetModule();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 21913, 21937);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_10203_21985_22007(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 21985, 22007);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10203_22152_22178(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 22152, 22178);
                    return return_v;
                }


                int
                f_10203_22135_22192(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                symbol, int
                parentIndex, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ExportedType>
                builder)
                {
                    GetExportedTypes((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)symbol, parentIndex, builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 22135, 22192);
                    return 0;
                }


                bool
                f_10203_22256_22280(Microsoft.CodeAnalysis.OutputKind
                kind)
                {
                    var return_v = kind.IsNetModule();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 22256, 22280);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10203_22284_22319(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 22284, 22319);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10203_22284_22327(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 22284, 22327);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_10203_22284_22338(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 22284, 22338);
                    return return_v;
                }


                bool
                f_10203_22284_22352(Microsoft.CodeAnalysis.OutputKind
                kind)
                {
                    var return_v = kind.IsNetModule();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 22284, 22352);
                    return return_v;
                }


                int
                f_10203_22243_22353(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 22243, 22353);
                    return 0;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10203_22368_22410(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                sourceAssembly, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ExportedType>
                builder)
                {
                    var return_v = GetForwardedTypes(sourceAssembly, builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 22368, 22410);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ExportedType>
                f_10203_22434_22462(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ExportedType>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 22434, 22462);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 21653, 22474);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 21653, 22474);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static HashSet<NamedTypeSymbol> GetForwardedTypes(SourceAssemblySymbol sourceAssembly, ArrayBuilder<Cci.ExportedType>? builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10203, 22607, 23272);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 22768, 22832);

                var
                seenTopLevelForwardedTypes = f_10203_22801_22831()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 22846, 22958);

                f_10203_22846_22957(seenTopLevelForwardedTypes, f_10203_22892_22947(sourceAssembly), builder);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 22974, 23211) || true) && (!f_10203_22979_23047(f_10203_22979_23033(f_10203_22979_23022(f_10203_22979_23014(sourceAssembly)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 22974, 23211);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 23081, 23196);

                    f_10203_23081_23195(seenTopLevelForwardedTypes, f_10203_23127_23185(sourceAssembly), builder);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 22974, 23211);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 23227, 23261);

                return seenTopLevelForwardedTypes;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10203, 22607, 23272);

                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10203_22801_22831()
                {
                    var return_v = new System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 22801, 22831);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10203_22892_22947(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.GetSourceDecodedWellKnownAttributeData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 22892, 22947);
                    return return_v;
                }


                int
                f_10203_22846_22957(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                seenTopLevelTypes, Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                wellKnownAttributeData, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ExportedType>?
                builder)
                {
                    GetForwardedTypes(seenTopLevelTypes, wellKnownAttributeData, builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 22846, 22957);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10203_22979_23014(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 22979, 23014);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10203_22979_23022(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 22979, 23022);
                    return return_v;
                }


                Microsoft.CodeAnalysis.OutputKind
                f_10203_22979_23033(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.OutputKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 22979, 23033);
                    return return_v;
                }


                bool
                f_10203_22979_23047(Microsoft.CodeAnalysis.OutputKind
                kind)
                {
                    var return_v = kind.IsNetModule();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 22979, 23047);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10203_23127_23185(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.GetNetModuleDecodedWellKnownAttributeData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 23127, 23185);
                    return return_v;
                }


                int
                f_10203_23081_23195(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                seenTopLevelTypes, Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                wellKnownAttributeData, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ExportedType>?
                builder)
                {
                    GetForwardedTypes(seenTopLevelTypes, wellKnownAttributeData, builder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 23081, 23195);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 22607, 23272);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 22607, 23272);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ReportExportedTypeNameCollisions(ImmutableArray<Cci.ExportedType> exportedTypes, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 23303, 26431);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 23448, 23507);

                var
                sourceAssembly = f_10203_23469_23506(SourceModule)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 23521, 23616);

                var
                exportedNamesMap = f_10203_23544_23615(StringOrdinalComparer.Instance)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 23632, 26420);
                    foreach (var exportedType in f_10203_23661_23674_I(exportedTypes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 23632, 26420);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 23708, 23774);

                        var
                        type = (NamedTypeSymbol)f_10203_23736_23773(exportedType.Type)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 23794, 23826);

                        f_10203_23794_23825(f_10203_23807_23824(type));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 23846, 23942) || true) && (!f_10203_23851_23872(type))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 23846, 23942);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 23914, 23923);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 23846, 23942);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 23962, 24189);

                        string
                        fullEmittedName = f_10203_23987_24188(f_10203_24044_24109(((Cci.INamespaceTypeReference)f_10203_24074_24094(type))), f_10203_24132_24187(f_10203_24166_24186(type)))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 24286, 24861) || true) && (f_10203_24290_24327(this, fullEmittedName))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 24286, 24861);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 24369, 24809) || true) && ((object)f_10203_24381_24404(type) == sourceAssembly)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 24369, 24809);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 24472, 24591);

                                f_10203_24472_24590(diagnostics, ErrorCode.ERR_ExportedTypeConflictsWithDeclaration, NoLocation.Singleton, type, f_10203_24568_24589(type));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 24369, 24809);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 24369, 24809);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 24689, 24786);

                                f_10203_24689_24785(diagnostics, ErrorCode.ERR_ForwardedTypeConflictsWithDeclaration, NoLocation.Singleton, type);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 24369, 24809);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 24833, 24842);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 24286, 24861);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 24881, 24907);

                        NamedTypeSymbol
                        contender
                        = default(NamedTypeSymbol);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 24986, 26341) || true) && (f_10203_24990_25050(exportedNamesMap, fullEmittedName, out contender))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 24986, 26341);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 25092, 26289) || true) && ((object)f_10203_25104_25127(type) == sourceAssembly)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 25092, 26289);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 25315, 25376);

                                f_10203_25315_25375(f_10203_25328_25356(contender) == sourceAssembly);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 25404, 25547);

                                f_10203_25404_25546(
                                                        diagnostics, ErrorCode.ERR_ExportedTypesConflict, NoLocation.Singleton, type, f_10203_25485_25506(type), contender, f_10203_25519_25545(contender));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 25092, 26289);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 25092, 26289);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 25597, 26289) || true) && ((object)f_10203_25609_25637(contender) == sourceAssembly)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 25597, 26289);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 25777, 25939);

                                    f_10203_25777_25938(                        // Forwarded type conflicts with exported type
                                                            diagnostics, ErrorCode.ERR_ForwardedTypeConflictsWithExportedType, NoLocation.Singleton, type, f_10203_25875_25898(type), contender, f_10203_25911_25937(contender));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 25597, 26289);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 25597, 26289);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 26118, 26266);

                                    f_10203_26118_26265(                        // Forwarded type conflicts with another forwarded type
                                                            diagnostics, ErrorCode.ERR_ForwardedTypesConflict, NoLocation.Singleton, type, f_10203_26200_26223(type), contender, f_10203_26236_26264(contender));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 25597, 26289);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 25092, 26289);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 26313, 26322);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 24986, 26341);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 26361, 26405);

                        f_10203_26361_26404(
                                        exportedNamesMap, fullEmittedName, type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 23632, 26420);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10203, 1, 2789);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10203, 1, 2789);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 23303, 26431);

                Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                f_10203_23469_23506(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSourceAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 23469, 23506);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10203_23544_23615(Roslyn.Utilities.StringOrdinalComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 23544, 23615);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                f_10203_23736_23773(Microsoft.Cci.ITypeReference
                this_param)
                {
                    var return_v = this_param.GetInternalSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 23736, 23773);
                    return return_v;
                }


                bool
                f_10203_23807_23824(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 23807, 23824);
                    return return_v;
                }


                int
                f_10203_23794_23825(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 23794, 23825);
                    return 0;
                }


                bool
                f_10203_23851_23872(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsTopLevelType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 23851, 23872);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                f_10203_24074_24094(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 24074, 24094);
                    return return_v;
                }


                string
                f_10203_24044_24109(Microsoft.Cci.INamespaceTypeReference
                this_param)
                {
                    var return_v = this_param.NamespaceName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 24044, 24109);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                f_10203_24166_24186(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 24166, 24186);
                    return return_v;
                }


                string
                f_10203_24132_24187(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                namedType)
                {
                    var return_v = Cci.MetadataWriter.GetMangledName((Microsoft.Cci.INamedTypeReference)namedType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 24132, 24187);
                    return return_v;
                }


                string
                f_10203_23987_24188(string
                qualifier, string
                name)
                {
                    var return_v = MetadataHelpers.BuildQualifiedName(qualifier, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 23987, 24188);
                    return return_v;
                }


                bool
                f_10203_24290_24327(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, string
                fullEmittedName)
                {
                    var return_v = this_param.ContainsTopLevelType(fullEmittedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 24290, 24327);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10203_24381_24404(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 24381, 24404);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10203_24568_24589(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 24568, 24589);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10203_24472_24590(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 24472, 24590);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10203_24689_24785(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 24689, 24785);
                    return return_v;
                }


                bool
                f_10203_24990_25050(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, string
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 24990, 25050);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10203_25104_25127(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 25104, 25127);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10203_25328_25356(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 25328, 25356);
                    return return_v;
                }


                int
                f_10203_25315_25375(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 25315, 25375);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10203_25485_25506(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 25485, 25506);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10203_25519_25545(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 25519, 25545);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10203_25404_25546(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 25404, 25546);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10203_25609_25637(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 25609, 25637);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10203_25875_25898(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 25875, 25898);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10203_25911_25937(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 25911, 25937);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10203_25777_25938(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 25777, 25938);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10203_26200_26223(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 26200, 26223);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10203_26236_26264(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 26236, 26264);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10203_26118_26265(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, Microsoft.CodeAnalysis.Location
                location, params object[]
                args)
                {
                    var return_v = diagnostics.Add(code, location, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 26118, 26265);
                    return return_v;
                }


                int
                f_10203_26361_26404(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, string
                key, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 26361, 26404);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ExportedType>
                f_10203_23661_23674_I(System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ExportedType>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 23661, 23674);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 23303, 26431);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 23303, 26431);
            }
        }

        private static void GetForwardedTypes(
                    HashSet<NamedTypeSymbol> seenTopLevelTypes,
                    CommonAssemblyWellKnownAttributeData<NamedTypeSymbol> wellKnownAttributeData,
                    ArrayBuilder<Cci.ExportedType>? builder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10203, 26461, 30121);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 26749, 30110) || true) && (wellKnownAttributeData != null && (DynAbs.Tracing.TraceSender.Expression_True(10203, 26753, 26832) && f_10203_26787_26824(wellKnownAttributeData) != null) && (DynAbs.Tracing.TraceSender.Expression_True(10203, 26753, 26883) && f_10203_26836_26879(f_10203_26836_26873(wellKnownAttributeData)) > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 26749, 30110);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 27029, 27109);

                    var
                    stack = f_10203_27041_27108()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 27256, 27347);

                    IEnumerable<NamedTypeSymbol>
                    orderedForwardedTypes = f_10203_27309_27346(wellKnownAttributeData)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 27367, 27592) || true) && (builder is object)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 27367, 27592);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 27430, 27573);

                        orderedForwardedTypes = f_10203_27454_27572(orderedForwardedTypes, t => t.OriginalDefinition.ToDisplayString(SymbolDisplayFormat.QualifiedNameArityFormat));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 27367, 27592);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 27612, 30062);
                        foreach (NamedTypeSymbol forwardedType in f_10203_27654_27675_I(orderedForwardedTypes))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 27612, 30062);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 27717, 27787);

                            NamedTypeSymbol
                            originalDefinition = f_10203_27754_27786(forwardedType)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 27809, 27913);

                            f_10203_27809_27912((object)f_10203_27830_27863(originalDefinition) == null, "How did a nested type get forwarded?");

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 28137, 28194) || true) && (!f_10203_28142_28183(seenTopLevelTypes, originalDefinition))
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 28137, 28194);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 28185, 28194);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 28137, 28194);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 28218, 30043) || true) && (builder is object)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 28218, 30043);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 28462, 28493);

                                f_10203_28462_28492(f_10203_28475_28486(stack) == 0);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 28519, 28556);

                                stack.Push((originalDefinition, -1));
                                try
                                {
                                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 28584, 30020) || true) && (f_10203_28591_28602(stack) > 0)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 28584, 30020);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 28664, 28702);

                                        var (type, parentIndex) = f_10203_28690_28701(stack);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 29043, 29290) || true) && (f_10203_29047_29073(type) == Accessibility.Private)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 29043, 29290);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 29250, 29259);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 29043, 29290);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 29454, 29480);

                                        int
                                        index = f_10203_29466_29479(builder)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 29510, 29598);

                                        f_10203_29510_29597(builder, f_10203_29522_29596(f_10203_29543_29563(type), parentIndex, isForwarder: true));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 29717, 29780);

                                        ImmutableArray<NamedTypeSymbol>
                                        nested = f_10203_29758_29779(type)
                                        ;
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 29831, 29852);
                                            for (int
                i = nested.Length - 1
                ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 29822, 29993) || true) && (i >= 0)
                ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 29862, 29865)
                , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 29822, 29993))

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 29822, 29993);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 29931, 29962);

                                                stack.Push((nested[i], index));
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10203, 1, 172);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(10203, 1, 172);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 28584, 30020);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10203, 28584, 30020);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(10203, 28584, 30020);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 28218, 30043);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 27612, 30062);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10203, 1, 2451);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10203, 1, 2451);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 30082, 30095);

                    f_10203_30082_30094(
                                    stack);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 26749, 30110);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10203, 26461, 30121);

                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10203_26787_26824(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    var return_v = this_param.ForwardedTypes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 26787, 26824);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10203_26836_26873(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    var return_v = this_param.ForwardedTypes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 26836, 26873);
                    return return_v;
                }


                int
                f_10203_26836_26879(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 26836, 26879);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol type, int parentIndex)>
                f_10203_27041_27108()
                {
                    var return_v = ArrayBuilder<(NamedTypeSymbol type, int parentIndex)>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 27041, 27108);
                    return return_v;
                }


                System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10203_27309_27346(Microsoft.CodeAnalysis.CommonAssemblyWellKnownAttributeData<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param)
                {
                    var return_v = this_param.ForwardedTypes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 27309, 27346);
                    return return_v;
                }


                System.Linq.IOrderedEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10203_27454_27572(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                source, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, string>
                keySelector)
                {
                    var return_v = source.OrderBy<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, string>(keySelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 27454, 27572);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10203_27754_27786(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 27754, 27786);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10203_27830_27863(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 27830, 27863);
                    return return_v;
                }


                int
                f_10203_27809_27912(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 27809, 27912);
                    return 0;
                }


                bool
                f_10203_28142_28183(System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 28142, 28183);
                    return return_v;
                }


                int
                f_10203_28475_28486(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol type, int parentIndex)>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 28475, 28486);
                    return return_v;
                }


                int
                f_10203_28462_28492(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 28462, 28492);
                    return 0;
                }


                int
                f_10203_28591_28602(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol type, int parentIndex)>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 28591, 28602);
                    return return_v;
                }


                (Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol type, int parentIndex)
                f_10203_28690_28701(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol type, int parentIndex)>
                builder)
                {
                    var return_v = builder.Pop<(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol type, int parentIndex)>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 28690, 28701);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10203_29047_29073(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 29047, 29073);
                    return return_v;
                }


                int
                f_10203_29466_29479(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ExportedType>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 29466, 29479);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                f_10203_29543_29563(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 29543, 29563);
                    return return_v;
                }


                Microsoft.Cci.ExportedType
                f_10203_29522_29596(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                type, int
                parentIndex, bool
                isForwarder)
                {
                    var return_v = new Microsoft.Cci.ExportedType((Microsoft.Cci.ITypeReference)type, parentIndex, isForwarder: isForwarder);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 29522, 29596);
                    return return_v;
                }


                int
                f_10203_29510_29597(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.ExportedType>
                this_param, Microsoft.Cci.ExportedType
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 29510, 29597);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10203_29758_29779(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetTypeMembers();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 29758, 29779);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10203_27654_27675_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 27654, 27675);
                    return return_v;
                }


                int
                f_10203_30082_30094(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol type, int parentIndex)>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 30082, 30094);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 26461, 30121);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 26461, 30121);
            }
        }

        internal IEnumerable<AssemblySymbol> GetReferencedAssembliesUsedSoFar()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 30152, 30542);

                var listYield = new List<AssemblySymbol>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 30248, 30531);
                    foreach (AssemblySymbol a in f_10203_30277_30320_I(f_10203_30277_30320(SourceModule)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 30248, 30531);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 30354, 30516) || true) && (f_10203_30358_30369_M(!a.IsLinked) && (DynAbs.Tracing.TraceSender.Expression_True(10203, 30358, 30385) && f_10203_30373_30385_M(!a.IsMissing)) && (DynAbs.Tracing.TraceSender.Expression_True(10203, 30358, 30440) && f_10203_30389_30440(AssemblyOrModuleSymbolToModuleRefMap, a)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 30354, 30516);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 30482, 30497);

                            listYield.Add(a);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 30354, 30516);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 30248, 30531);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10203, 1, 284);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10203, 1, 284);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 30152, 30542);

                return listYield;

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                f_10203_30277_30320(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                this_param)
                {
                    var return_v = this_param.GetReferencedAssemblySymbols();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 30277, 30320);
                    return return_v;
                }


                bool
                f_10203_30358_30369_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 30358, 30369);
                    return return_v;
                }


                bool
                f_10203_30373_30385_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 30373, 30385);
                    return return_v;
                }


                bool
                f_10203_30389_30440(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.Cci.IModuleReference>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                key)
                {
                    var return_v = this_param.ContainsKey((Microsoft.CodeAnalysis.CSharp.Symbol)key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 30389, 30440);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                f_10203_30277_30320_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 30277, 30320);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 30152, 30542);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 30152, 30542);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private NamedTypeSymbol GetUntranslatedSpecialType(SpecialType specialType, SyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 30554, 31247);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 30707, 30741);

                f_10203_30707_30740(diagnostics != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 30757, 30834);

                var
                typeSymbol = f_10203_30774_30833(f_10203_30774_30805(SourceModule), specialType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 30850, 30906);

                DiagnosticInfo
                info = f_10203_30872_30905(typeSymbol)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 30920, 31202) || true) && (info != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 30920, 31202);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 30970, 31187);

                    f_10203_30970_31186(info, diagnostics, (DynAbs.Tracing.TraceSender.Conditional_F1(10203, 31116, 31137) || ((syntaxNodeOpt != null && DynAbs.Tracing.TraceSender.Conditional_F2(10203, 31140, 31162)) || DynAbs.Tracing.TraceSender.Conditional_F3(10203, 31165, 31185))) ? f_10203_31140_31162(syntaxNodeOpt) : NoLocation.Singleton);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 30920, 31202);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 31218, 31236);

                return typeSymbol;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 30554, 31247);

                int
                f_10203_30707_30740(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 30707, 30740);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10203_30774_30805(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 30774, 30805);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10203_30774_30833(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param, Microsoft.CodeAnalysis.SpecialType
                type)
                {
                    var return_v = this_param.GetSpecialType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 30774, 30833);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10203_30872_30905(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 30872, 30905);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10203_31140_31162(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 31140, 31162);
                    return return_v;
                }


                bool
                f_10203_30970_31186(Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = Symbol.ReportUseSiteDiagnostic(info, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 30970, 31186);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 30554, 31247);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 30554, 31247);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override Cci.INamedTypeReference GetSpecialType(SpecialType specialType, SyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 31259, 31691);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 31425, 31680);

                return f_10203_31432_31679(this, f_10203_31442_31509(this, specialType, syntaxNodeOpt, diagnostics), diagnostics: diagnostics, syntaxNodeOpt: syntaxNodeOpt, needDeclaration: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 31259, 31691);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10203_31442_31509(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetUntranslatedSpecialType(specialType, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 31442, 31509);
                    return return_v;
                }


                Microsoft.Cci.INamedTypeReference
                f_10203_31432_31679(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                namedTypeSymbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, bool
                needDeclaration)
                {
                    var return_v = this_param.Translate(namedTypeSymbol, diagnostics: diagnostics, syntaxNodeOpt: syntaxNodeOpt, needDeclaration: needDeclaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 31432, 31679);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 31259, 31691);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 31259, 31691);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override Cci.INamedTypeReference GetSystemType(SyntaxNode syntaxOpt, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 31703, 32405);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 31839, 31930);

                NamedTypeSymbol
                systemTypeSymbol = f_10203_31874_31929(Compilation, WellKnownType.System_Type)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 31946, 32008);

                DiagnosticInfo
                info = f_10203_31968_32007(systemTypeSymbol)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 32022, 32296) || true) && (info != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 32022, 32296);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 32072, 32281);

                    f_10203_32072_32280(info, diagnostics, (DynAbs.Tracing.TraceSender.Conditional_F1(10203, 32218, 32235) || ((syntaxOpt != null && DynAbs.Tracing.TraceSender.Conditional_F2(10203, 32238, 32256)) || DynAbs.Tracing.TraceSender.Conditional_F3(10203, 32259, 32279))) ? f_10203_32238_32256(syntaxOpt) : NoLocation.Singleton);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 32022, 32296);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 32312, 32394);

                return f_10203_32319_32393(this, systemTypeSymbol, syntaxOpt, diagnostics, needDeclaration: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 31703, 32405);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10203_31874_31929(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 31874, 31929);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10203_31968_32007(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 31968, 32007);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10203_32238_32256(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 32238, 32256);
                    return return_v;
                }


                bool
                f_10203_32072_32280(Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = Symbol.ReportUseSiteDiagnostic(info, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 32072, 32280);
                    return return_v;
                }


                Microsoft.Cci.INamedTypeReference
                f_10203_32319_32393(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                namedTypeSymbol, Microsoft.CodeAnalysis.SyntaxNode?
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                needDeclaration)
                {
                    var return_v = this_param.Translate(namedTypeSymbol, syntaxNodeOpt, diagnostics, needDeclaration: needDeclaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 32319, 32393);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 31703, 32405);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 31703, 32405);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override Cci.IMethodReference GetInitArrayHelper()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 32417, 32696);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 32506, 32685);

                return f_10203_32513_32684_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(((MethodSymbol)f_10203_32528_32666(Compilation, WellKnownMember.System_Runtime_CompilerServices_RuntimeHelpers__InitializeArrayArrayRuntimeFieldHandle)), 10203, 32513, 32684)?.GetCciAdapter());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 32417, 32696);

                Microsoft.CodeAnalysis.CSharp.Symbol?
                f_10203_32528_32666(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                member)
                {
                    var return_v = this_param.GetWellKnownTypeMember(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 32528, 32666);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter?
                f_10203_32513_32684_I(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 32513, 32684);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 32417, 32696);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 32417, 32696);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override bool IsPlatformType(Cci.ITypeReference typeRef, Cci.PlatformType platformType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 32708, 33307);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 32834, 32897);

                var
                namedType = f_10203_32850_32877(typeRef) as NamedTypeSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 32911, 33267) || true) && ((object)namedType != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 32911, 33267);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 32974, 33174) || true) && (platformType == Cci.PlatformType.SystemType)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 32974, 33174);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 33063, 33155);

                        return (object)namedType == (object)f_10203_33099_33154(Compilation, WellKnownType.System_Type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 32974, 33174);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 33194, 33252);

                    return f_10203_33201_33222(namedType) == (SpecialType)platformType;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 32911, 33267);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 33283, 33296);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 32708, 33307);

                Microsoft.CodeAnalysis.Symbols.ISymbolInternal?
                f_10203_32850_32877(Microsoft.Cci.ITypeReference
                this_param)
                {
                    var return_v = this_param.GetInternalSymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 32850, 32877);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10203_33099_33154(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 33099, 33154);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10203_33201_33222(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 33201, 33222);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 32708, 33307);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 32708, 33307);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected sealed override Cci.IAssemblyReference GetCorLibraryReferenceToEmit(CodeAnalysis.Emit.EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 33319, 33801);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 33460, 33499);

                AssemblySymbol
                corLibrary = f_10203_33488_33498()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 33515, 33762) || true) && (f_10203_33519_33540_M(!corLibrary.IsMissing) && (DynAbs.Tracing.TraceSender.Expression_True(10203, 33519, 33581) && f_10203_33561_33581_M(!corLibrary.IsLinked)) && (DynAbs.Tracing.TraceSender.Expression_True(10203, 33519, 33663) && !f_10203_33603_33663(corLibrary, f_10203_33631_33662(SourceModule))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 33515, 33762);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 33697, 33747);

                    return f_10203_33704_33746(this, corLibrary, context.Diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 33515, 33762);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 33778, 33790);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 33319, 33801);

                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10203_33488_33498()
                {
                    var return_v = CorLibrary;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 33488, 33498);
                    return return_v;
                }


                bool
                f_10203_33519_33540_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 33519, 33540);
                    return return_v;
                }


                bool
                f_10203_33561_33581_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 33561, 33581);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10203_33631_33662(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 33631, 33662);
                    return return_v;
                }


                bool
                f_10203_33603_33663(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 33603, 33663);
                    return return_v;
                }


                Microsoft.Cci.IAssemblyReference
                f_10203_33704_33746(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                assembly, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(assembly, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 33704, 33746);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 33319, 33801);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 33319, 33801);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override Cci.IAssemblyReference Translate(AssemblySymbol assembly, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 33813, 34933);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 33947, 34094) || true) && (f_10203_33951_34009(f_10203_33967_33998(SourceModule), assembly))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 33947, 34094);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 34043, 34079);

                    return (Cci.IAssemblyReference)this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 33947, 34094);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 34110, 34141);

                Cci.IModuleReference
                reference
                = default(Cci.IModuleReference);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 34157, 34324) || true) && (f_10203_34161_34234(AssemblyOrModuleSymbolToModuleRefMap, assembly, out reference))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 34157, 34324);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 34268, 34309);

                    return (Cci.IAssemblyReference)reference;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 34157, 34324);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 34340, 34399);

                AssemblyReference
                asmRef = f_10203_34367_34398(assembly)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 34415, 34531);

                AssemblyReference
                cachedAsmRef = (AssemblyReference)f_10203_34467_34530(AssemblyOrModuleSymbolToModuleRefMap, assembly, asmRef)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 34547, 34686) || true) && (cachedAsmRef == asmRef)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 34547, 34686);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 34607, 34671);

                    f_10203_34607_34670(this, assembly, cachedAsmRef, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 34547, 34686);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 34807, 34886);

                f_10203_34807_34885(
                            // TryAdd because whatever is associated with assembly should be associated with Modules[0]
                            AssemblyOrModuleSymbolToModuleRefMap, f_10203_34851_34867(assembly)[0], cachedAsmRef);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 34902, 34922);

                return cachedAsmRef;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 33813, 34933);

                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10203_33967_33998(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 33967, 33998);
                    return return_v;
                }


                bool
                f_10203_33951_34009(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 33951, 34009);
                    return return_v;
                }


                bool
                f_10203_34161_34234(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.Cci.IModuleReference>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                key, out Microsoft.Cci.IModuleReference
                value)
                {
                    var return_v = this_param.TryGetValue((Microsoft.CodeAnalysis.CSharp.Symbol)key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 34161, 34234);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.AssemblyReference
                f_10203_34367_34398(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                assemblySymbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Emit.AssemblyReference(assemblySymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 34367, 34398);
                    return return_v;
                }


                Microsoft.Cci.IModuleReference
                f_10203_34467_34530(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.Cci.IModuleReference>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                key, Microsoft.CodeAnalysis.CSharp.Emit.AssemblyReference
                value)
                {
                    var return_v = this_param.GetOrAdd((Microsoft.CodeAnalysis.CSharp.Symbol)key, (Microsoft.Cci.IModuleReference)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 34467, 34530);
                    return return_v;
                }


                int
                f_10203_34607_34670(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                assembly, Microsoft.CodeAnalysis.CSharp.Emit.AssemblyReference
                asmRef, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ValidateReferencedAssembly(assembly, asmRef, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 34607, 34670);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_10203_34851_34867(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 34851, 34867);
                    return return_v;
                }


                bool
                f_10203_34807_34885(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.Cci.IModuleReference>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                key, Microsoft.CodeAnalysis.CSharp.Emit.AssemblyReference
                value)
                {
                    var return_v = this_param.TryAdd((Microsoft.CodeAnalysis.CSharp.Symbol)key, (Microsoft.Cci.IModuleReference)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 34807, 34885);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 33813, 34933);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 33813, 34933);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Cci.IModuleReference Translate(ModuleSymbol module, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 34945, 35666);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 35057, 35159) || true) && (f_10203_35061_35098(SourceModule, module))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 35057, 35159);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 35132, 35144);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 35057, 35159);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 35175, 35262) || true) && ((object)module == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 35175, 35262);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 35235, 35247);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 35175, 35262);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 35278, 35309);

                Cci.IModuleReference
                moduleRef
                = default(Cci.IModuleReference);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 35325, 35466) || true) && (f_10203_35329_35400(AssemblyOrModuleSymbolToModuleRefMap, module, out moduleRef))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 35325, 35466);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 35434, 35451);

                    return moduleRef;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 35325, 35466);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 35482, 35531);

                moduleRef = f_10203_35494_35530(this, module, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 35545, 35622);

                moduleRef = f_10203_35557_35621(AssemblyOrModuleSymbolToModuleRefMap, module, moduleRef);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 35638, 35655);

                return moduleRef;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 34945, 35666);

                bool
                f_10203_35061_35098(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 35061, 35098);
                    return return_v;
                }


                bool
                f_10203_35329_35400(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.Cci.IModuleReference>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                key, out Microsoft.Cci.IModuleReference
                value)
                {
                    var return_v = this_param.TryGetValue((Microsoft.CodeAnalysis.CSharp.Symbol)key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 35329, 35400);
                    return return_v;
                }


                Microsoft.Cci.IModuleReference
                f_10203_35494_35530(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                module, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.TranslateModule(module, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 35494, 35530);
                    return return_v;
                }


                Microsoft.Cci.IModuleReference
                f_10203_35557_35621(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.Cci.IModuleReference>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                key, Microsoft.Cci.IModuleReference
                value)
                {
                    var return_v = this_param.GetOrAdd((Microsoft.CodeAnalysis.CSharp.Symbol)key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 35557, 35621);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 34945, 35666);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 34945, 35666);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual Cci.IModuleReference TranslateModule(ModuleSymbol module, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 35678, 36651);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 35805, 35858);

                AssemblySymbol
                container = f_10203_35832_35857(module)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 35874, 36640) || true) && ((object)container != null && (DynAbs.Tracing.TraceSender.Expression_True(10203, 35878, 35952) && f_10203_35907_35952(f_10203_35923_35940(container)[0], module)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 35874, 36640);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 35986, 36052);

                    Cci.IModuleReference
                    moduleRef = f_10203_36019_36051(container)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 36070, 36177);

                    Cci.IModuleReference
                    cachedModuleRef = f_10203_36109_36176(AssemblyOrModuleSymbolToModuleRefMap, container, moduleRef)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 36197, 36481) || true) && (cachedModuleRef == moduleRef)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 36197, 36481);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 36271, 36352);

                        f_10203_36271_36351(this, container, moduleRef, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 36197, 36481);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 36197, 36481);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 36434, 36462);

                        moduleRef = cachedModuleRef;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 36197, 36481);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 36501, 36518);

                    return moduleRef;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 35874, 36640);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 35874, 36640);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 36584, 36625);

                    return f_10203_36591_36624(this, module);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 35874, 36640);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 35678, 36651);

                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10203_35832_35857(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 35832, 35857);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                f_10203_35923_35940(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 35923, 35940);
                    return return_v;
                }


                bool
                f_10203_35907_35952(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 35907, 35952);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.AssemblyReference
                f_10203_36019_36051(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                assemblySymbol)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Emit.AssemblyReference(assemblySymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 36019, 36051);
                    return return_v;
                }


                Microsoft.Cci.IModuleReference
                f_10203_36109_36176(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.Cci.IModuleReference>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                key, Microsoft.Cci.IModuleReference
                value)
                {
                    var return_v = this_param.GetOrAdd((Microsoft.CodeAnalysis.CSharp.Symbol)key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 36109, 36176);
                    return return_v;
                }


                int
                f_10203_36271_36351(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                assembly, Microsoft.Cci.IModuleReference
                asmRef, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.ValidateReferencedAssembly(assembly, (Microsoft.CodeAnalysis.CSharp.Emit.AssemblyReference)asmRef, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 36271, 36351);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.ModuleReference
                f_10203_36591_36624(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                moduleBeingBuilt, Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                underlyingModule)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Emit.ModuleReference(moduleBeingBuilt, underlyingModule);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 36591, 36624);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 35678, 36651);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 35678, 36651);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Cci.INamedTypeReference Translate(
                    NamedTypeSymbol namedTypeSymbol,
                    SyntaxNode syntaxNodeOpt,
                    DiagnosticBag diagnostics,
                    bool fromImplements = false,
                    bool needDeclaration = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 36663, 41746);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 36941, 36996);

                f_10203_36941_36995(f_10203_36954_36994(namedTypeSymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 37010, 37044);

                f_10203_37010_37043(diagnostics != null);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 37108, 37495) || true) && (f_10203_37112_37143(namedTypeSymbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 37108, 37495);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 37177, 37208);

                    f_10203_37177_37207(!needDeclaration);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 37226, 37311);

                    namedTypeSymbol = f_10203_37244_37310(namedTypeSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 37108, 37495);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 37108, 37495);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 37345, 37495) || true) && (f_10203_37349_37376(namedTypeSymbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 37345, 37495);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 37410, 37480);

                        f_10203_37410_37479(this, namedTypeSymbol, syntaxNodeOpt, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 37345, 37495);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 37108, 37495);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 37667, 38713) || true) && (f_10203_37671_37710(f_10203_37671_37705(namedTypeSymbol)) == SymbolKind.ErrorType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 37667, 38713);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 37768, 37848);

                    ErrorTypeSymbol
                    errorType = (ErrorTypeSymbol)f_10203_37813_37847(namedTypeSymbol)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 37866, 37948);

                    DiagnosticInfo
                    diagInfo = f_10203_37892_37924(errorType) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.DiagnosticInfo?>(10203, 37892, 37947) ?? f_10203_37928_37947(errorType))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 37968, 38231) || true) && (diagInfo == null && (DynAbs.Tracing.TraceSender.Expression_True(10203, 37972, 38036) && f_10203_37992_38012(namedTypeSymbol) == SymbolKind.ErrorType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 37968, 38231);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 38078, 38123);

                        errorType = (ErrorTypeSymbol)namedTypeSymbol;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 38145, 38212);

                        diagInfo = f_10203_38156_38188(errorType) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.DiagnosticInfo?>(10203, 38156, 38211) ?? f_10203_38192_38211(errorType));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 37968, 38231);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 38353, 38633) || true) && (f_10203_38357_38394(_reportedErrorTypesMap, errorType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 38353, 38633);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 38436, 38614);

                        f_10203_38436_38613(diagnostics, f_10203_38452_38612(diagInfo ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.DiagnosticInfo?>(10203, 38469, 38540) ?? f_10203_38481_38540(ErrorCode.ERR_BogusType, string.Empty)), (DynAbs.Tracing.TraceSender.Conditional_F1(10203, 38542, 38563) || ((syntaxNodeOpt == null && DynAbs.Tracing.TraceSender.Conditional_F2(10203, 38566, 38586)) || DynAbs.Tracing.TraceSender.Conditional_F3(10203, 38589, 38611))) ? NoLocation.Singleton : f_10203_38589_38611(syntaxNodeOpt)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 38353, 38633);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 38653, 38698);

                    return CodeAnalysis.Emit.ErrorType.Singleton;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 37667, 38713);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 38729, 41416) || true) && (f_10203_38733_38762_M(!namedTypeSymbol.IsDefinition))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 38729, 41416);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 38847, 38878);

                    f_10203_38847_38877(!needDeclaration);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 38898, 39197) || true) && (f_10203_38902_38938(namedTypeSymbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 38898, 39197);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 38980, 39033);

                        namedTypeSymbol = f_10203_38998_39032(namedTypeSymbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 38898, 39197);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 38898, 39197);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 39115, 39178);

                        return (Cci.INamedTypeReference)f_10203_39147_39177(this, namedTypeSymbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 38898, 39197);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 38729, 41416);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 38729, 41416);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 39231, 41416) || true) && (!needDeclaration)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 39231, 41416);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 39285, 39302);

                        object
                        reference
                        = default(object);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 39320, 39352);

                        Cci.INamedTypeReference
                        typeRef
                        = default(Cci.INamedTypeReference);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 39372, 39431);

                        NamedTypeSymbol
                        container = f_10203_39400_39430(namedTypeSymbol)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 39451, 41401) || true) && (f_10203_39455_39476(namedTypeSymbol) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 39451, 41401);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 39522, 39704) || true) && (f_10203_39526_39589(_genericInstanceMap, namedTypeSymbol, out reference))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 39522, 39704);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 39639, 39681);

                                return (Cci.INamedTypeReference)reference;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 39522, 39704);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 39728, 40436) || true) && ((object)container != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 39728, 40436);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 39807, 40246) || true) && (f_10203_39811_39835(container))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 39807, 40246);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 39962, 40039);

                                    typeRef = f_10203_39972_40038(namedTypeSymbol);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 39807, 40246);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 39807, 40246);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 40153, 40219);

                                    typeRef = f_10203_40163_40218(namedTypeSymbol);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 39807, 40246);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 39728, 40436);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 39728, 40436);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 40344, 40413);

                                typeRef = f_10203_40354_40412(namedTypeSymbol);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 39728, 40436);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 40460, 40550);

                            typeRef = (Cci.INamedTypeReference)f_10203_40495_40549(_genericInstanceMap, namedTypeSymbol, typeRef);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 40574, 40589);

                            return typeRef;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 39451, 41401);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 39451, 41401);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 40631, 41401) || true) && (f_10203_40635_40659(container))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 40631, 41401);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 40701, 40741);

                                f_10203_40701_40740((object)container != null);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 40765, 40947) || true) && (f_10203_40769_40832(_genericInstanceMap, namedTypeSymbol, out reference))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 40765, 40947);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 40882, 40924);

                                    return (Cci.INamedTypeReference)reference;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 40765, 40947);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 40971, 41033);

                                typeRef = f_10203_40981_41032(namedTypeSymbol);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 41055, 41145);

                                typeRef = (Cci.INamedTypeReference)f_10203_41090_41144(_genericInstanceMap, namedTypeSymbol, typeRef);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 41169, 41184);

                                return typeRef;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 40631, 41401);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 40631, 41401);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 41226, 41401) || true) && (f_10203_41230_41273(namedTypeSymbol) is NamedTypeSymbol underlyingType)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 41226, 41401);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 41349, 41382);

                                    namedTypeSymbol = underlyingType;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 41226, 41401);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 40631, 41401);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 39451, 41401);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 39231, 41416);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 38729, 41416);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 41529, 41572);

                f_10203_41529_41571(f_10203_41542_41570(namedTypeSymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 41588, 41735);

                return f_10203_41595_41699_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_embeddedTypesManagerOpt, 10203, 41595, 41699)?.EmbedTypeIfNeedTo(namedTypeSymbol, fromImplements, syntaxNodeOpt, diagnostics)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.Cci.INamedTypeReference?>(10203, 41595, 41734) ?? f_10203_41703_41734(namedTypeSymbol));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 36663, 41746);

                bool
                f_10203_36954_36994(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinitionOrDistinct();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 36954, 36994);
                    return return_v;
                }


                int
                f_10203_36941_36995(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 36941, 36995);
                    return 0;
                }


                int
                f_10203_37010_37043(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 37010, 37043);
                    return 0;
                }


                bool
                f_10203_37112_37143(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsAnonymousType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 37112, 37143);
                    return return_v;
                }


                int
                f_10203_37177_37207(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 37177, 37207);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10203_37244_37310(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = AnonymousTypeManager.TranslateAnonymousTypeSymbol(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 37244, 37310);
                    return return_v;
                }


                bool
                f_10203_37349_37376(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsTupleType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 37349, 37376);
                    return return_v;
                }


                int
                f_10203_37410_37479(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                namedTypeSymbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    this_param.CheckTupleUnderlyingType(namedTypeSymbol, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 37410, 37479);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10203_37671_37705(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 37671, 37705);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10203_37671_37710(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 37671, 37710);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10203_37813_37847(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 37813, 37847);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo?
                f_10203_37892_37924(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 37892, 37924);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo?
                f_10203_37928_37947(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                this_param)
                {
                    var return_v = this_param.ErrorInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 37928, 37947);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10203_37992_38012(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 37992, 38012);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo?
                f_10203_38156_38188(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 38156, 38188);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo?
                f_10203_38192_38211(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                this_param)
                {
                    var return_v = this_param.ErrorInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 38192, 38211);
                    return return_v;
                }


                bool
                f_10203_38357_38394(Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                value)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 38357, 38394);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10203_38481_38540(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 38481, 38540);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10203_38589_38611(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 38589, 38611);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10203_38452_38612(Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic(info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 38452, 38612);
                    return return_v;
                }


                int
                f_10203_38436_38613(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                diag)
                {
                    this_param.Add((Microsoft.CodeAnalysis.Diagnostic)diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 38436, 38613);
                    return 0;
                }


                bool
                f_10203_38733_38762_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 38733, 38762);
                    return return_v;
                }


                int
                f_10203_38847_38877(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 38847, 38877);
                    return 0;
                }


                bool
                f_10203_38902_38938(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsUnboundGenericType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 38902, 38938);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10203_38998_39032(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 38998, 39032);
                    return return_v;
                }


                object
                f_10203_39147_39177(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                symbol)
                {
                    var return_v = this_param.GetCciAdapter((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 39147, 39177);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10203_39400_39430(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 39400, 39430);
                    return return_v;
                }


                int
                f_10203_39455_39476(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 39455, 39476);
                    return return_v;
                }


                bool
                f_10203_39526_39589(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, object>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                key, out object
                value)
                {
                    var return_v = this_param.TryGetValue((Microsoft.CodeAnalysis.CSharp.Symbol)key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 39526, 39589);
                    return return_v;
                }


                bool
                f_10203_39811_39835(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                toCheck)
                {
                    var return_v = IsGenericType(toCheck);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 39811, 39835);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.SpecializedGenericNestedTypeInstanceReference
                f_10203_39972_40038(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                underlyingNamedType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Emit.SpecializedGenericNestedTypeInstanceReference(underlyingNamedType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 39972, 40038);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.GenericNestedTypeInstanceReference
                f_10203_40163_40218(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                underlyingNamedType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Emit.GenericNestedTypeInstanceReference(underlyingNamedType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 40163, 40218);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.GenericNamespaceTypeInstanceReference
                f_10203_40354_40412(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                underlyingNamedType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Emit.GenericNamespaceTypeInstanceReference(underlyingNamedType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 40354, 40412);
                    return return_v;
                }


                object
                f_10203_40495_40549(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, object>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                key, Microsoft.Cci.INamedTypeReference
                value)
                {
                    var return_v = this_param.GetOrAdd((Microsoft.CodeAnalysis.CSharp.Symbol)key, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 40495, 40549);
                    return return_v;
                }


                bool
                f_10203_40635_40659(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                toCheck)
                {
                    var return_v = IsGenericType(toCheck);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 40635, 40659);
                    return return_v;
                }


                int
                f_10203_40701_40740(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 40701, 40740);
                    return 0;
                }


                bool
                f_10203_40769_40832(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, object>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                key, out object
                value)
                {
                    var return_v = this_param.TryGetValue((Microsoft.CodeAnalysis.CSharp.Symbol)key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 40769, 40832);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.SpecializedNestedTypeReference
                f_10203_40981_41032(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                underlyingNamedType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Emit.SpecializedNestedTypeReference(underlyingNamedType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 40981, 41032);
                    return return_v;
                }


                object
                f_10203_41090_41144(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, object>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                key, Microsoft.Cci.INamedTypeReference
                value)
                {
                    var return_v = this_param.GetOrAdd((Microsoft.CodeAnalysis.CSharp.Symbol)key, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 41090, 41144);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10203_41230_41273(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.NativeIntegerUnderlyingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 41230, 41273);
                    return return_v;
                }


                bool
                f_10203_41542_41570(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 41542, 41570);
                    return return_v;
                }


                int
                f_10203_41529_41571(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 41529, 41571);
                    return 0;
                }


                Microsoft.Cci.INamedTypeReference?
                f_10203_41595_41699_I(Microsoft.Cci.INamedTypeReference?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 41595, 41699);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                f_10203_41703_41734(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 41703, 41734);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 36663, 41746);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 36663, 41746);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private object GetCciAdapter(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 41758, 41905);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 41826, 41894);

                return f_10203_41833_41893(_genericInstanceMap, symbol, s => s.GetCciAdapter());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 41758, 41905);

                object
                f_10203_41833_41893(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, object>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                key, System.Func<Microsoft.CodeAnalysis.CSharp.Symbol, object>
                valueFactory)
                {
                    var return_v = this_param.GetOrAdd(key, valueFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 41833, 41893);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 41758, 41905);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 41758, 41905);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void CheckTupleUnderlyingType(NamedTypeSymbol namedTypeSymbol, SyntaxNode syntaxNodeOpt, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 41917, 43506);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 42342, 42406);

                var
                declaredBase = f_10203_42361_42405(namedTypeSymbol)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 42420, 42568) || true) && ((object)declaredBase != null && (DynAbs.Tracing.TraceSender.Expression_True(10203, 42424, 42512) && f_10203_42456_42480(declaredBase) == SpecialType.System_ValueType))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 42420, 42568);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 42546, 42553);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 42420, 42568);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 42682, 42786) || true) && (!f_10203_42687_42730(_reportedErrorTypesMap, namedTypeSymbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 42682, 42786);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 42764, 42771);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 42682, 42786);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 42802, 42887);

                var
                location = (DynAbs.Tracing.TraceSender.Conditional_F1(10203, 42817, 42838) || ((syntaxNodeOpt == null && DynAbs.Tracing.TraceSender.Conditional_F2(10203, 42841, 42861)) || DynAbs.Tracing.TraceSender.Conditional_F3(10203, 42864, 42886))) ? NoLocation.Singleton : f_10203_42864_42886(syntaxNodeOpt)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 42901, 43270) || true) && ((object)declaredBase != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 42901, 43270);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 42967, 43024);

                    var
                    diagnosticInfo = f_10203_42988_43023(declaredBase)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 43042, 43255) || true) && (diagnosticInfo != null && (DynAbs.Tracing.TraceSender.Expression_True(10203, 43046, 43123) && f_10203_43072_43095(diagnosticInfo) == DiagnosticSeverity.Error))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 43042, 43255);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 43165, 43207);

                        f_10203_43165_43206(diagnostics, diagnosticInfo, location);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 43229, 43236);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 43042, 43255);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 42901, 43270);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 43286, 43495);

                f_10203_43286_43494(
                            diagnostics, f_10203_43320_43493(f_10203_43359_43461(ErrorCode.ERR_PredefinedValueTupleTypeMustBeStruct, f_10203_43432_43460(namedTypeSymbol)), location));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 41917, 43506);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10203_42361_42405(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 42361, 42405);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SpecialType
                f_10203_42456_42480(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.SpecialType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 42456, 42480);
                    return return_v;
                }


                bool
                f_10203_42687_42730(Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                value)
                {
                    var return_v = this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 42687, 42730);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10203_42864_42886(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 42864, 42886);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10203_42988_43023(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 42988, 43023);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticSeverity
                f_10203_43072_43095(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Severity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 43072, 43095);
                    return return_v;
                }


                int
                f_10203_43165_43206(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add(info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 43165, 43206);
                    return 0;
                }


                string
                f_10203_43432_43460(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.MetadataName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 43432, 43460);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10203_43359_43461(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 43359, 43461);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                f_10203_43320_43493(Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnostic((Microsoft.CodeAnalysis.DiagnosticInfo)info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 43320, 43493);
                    return return_v;
                }


                int
                f_10203_43286_43494(Microsoft.CodeAnalysis.DiagnosticBag
                this_param, Microsoft.CodeAnalysis.CSharp.CSDiagnostic
                diag)
                {
                    this_param.Add((Microsoft.CodeAnalysis.Diagnostic)diag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 43286, 43494);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 41917, 43506);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 41917, 43506);
            }
        }

        public static bool IsGenericType(NamedTypeSymbol toCheck)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10203, 43518, 43866);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 43600, 43826) || true) && ((object)toCheck != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 43600, 43826);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 43664, 43758) || true) && (f_10203_43668_43681(toCheck) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 43664, 43758);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 43727, 43739);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 43664, 43758);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 43778, 43811);

                        toCheck = f_10203_43788_43810(toCheck);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 43600, 43826);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10203, 43600, 43826);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10203, 43600, 43826);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 43842, 43855);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10203, 43518, 43866);

                int
                f_10203_43668_43681(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 43668, 43681);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10203_43788_43810(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 43788, 43810);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 43518, 43866);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 43518, 43866);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Cci.IGenericParameterReference Translate(TypeParameterSymbol param)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10203, 43878, 44191);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 43986, 44135) || true) && (f_10203_43990_44009_M(!param.IsDefinition))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 43986, 44135);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 44028, 44135);

                    throw f_10203_44034_44134(f_10203_44064_44133(f_10203_44078_44120(), f_10203_44122_44132(param)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 43986, 44135);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 44151, 44180);

                return f_10203_44158_44179(param);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10203, 43878, 44191);

                bool
                f_10203_43990_44009_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 43990, 44009);
                    return return_v;
                }


                string
                f_10203_44078_44120()
                {
                    var return_v = CSharpResources.GenericParameterDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 44078, 44120);
                    return return_v;
                }


                string
                f_10203_44122_44132(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 44122, 44132);
                    return return_v;
                }


                string
                f_10203_44064_44133(string
                format, string
                arg0)
                {
                    var return_v = string.Format(format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 44064, 44133);
                    return return_v;
                }


                System.InvalidOperationException
                f_10203_44034_44134(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 44034, 44134);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbolAdapter
                f_10203_44158_44179(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 44158, 44179);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 43878, 44191);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 43878, 44191);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override Cci.ITypeReference Translate(
                    TypeSymbol typeSymbol,
                    SyntaxNode syntaxNodeOpt,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 44203, 45404);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 44397, 44431);

                f_10203_44397_44430(diagnostics != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 44447, 45319);

                switch (f_10203_44455_44470(typeSymbol))
                {

                    case SymbolKind.DynamicType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 44447, 45319);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 44554, 44630);

                        return f_10203_44561_44629(this, typeSymbol, syntaxNodeOpt, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 44447, 45319);

                    case SymbolKind.ArrayType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 44447, 45319);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 44698, 44744);

                        return f_10203_44705_44743(this, typeSymbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 44447, 45319);

                    case SymbolKind.ErrorType:
                    case SymbolKind.NamedType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 44447, 45319);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 44856, 44930);

                        return f_10203_44863_44929(this, typeSymbol, syntaxNodeOpt, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 44447, 45319);

                    case SymbolKind.PointerType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 44447, 45319);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 45000, 45048);

                        return f_10203_45007_45047(this, typeSymbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 44447, 45319);

                    case SymbolKind.TypeParameter:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 44447, 45319);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 45120, 45170);

                        return f_10203_45127_45169(typeSymbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 44447, 45319);

                    case SymbolKind.FunctionPointerType:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 44447, 45319);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 45248, 45304);

                        return f_10203_45255_45303(this, typeSymbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 44447, 45319);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 45335, 45393);

                throw f_10203_45341_45392(f_10203_45376_45391(typeSymbol));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 44203, 45404);

                int
                f_10203_44397_44430(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 44397, 44430);
                    return 0;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10203_44455_44470(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 44455, 44470);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_10203_44561_44629(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate((Microsoft.CodeAnalysis.CSharp.Symbols.DynamicTypeSymbol)symbol, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 44561, 44629);
                    return return_v;
                }


                Microsoft.Cci.IArrayTypeReference
                f_10203_44705_44743(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol)
                {
                    var return_v = this_param.Translate((Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 44705, 44743);
                    return return_v;
                }


                Microsoft.Cci.INamedTypeReference
                f_10203_44863_44929(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                namedTypeSymbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate((Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)namedTypeSymbol, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 44863, 44929);
                    return return_v;
                }


                Microsoft.Cci.IPointerTypeReference
                f_10203_45007_45047(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol)
                {
                    var return_v = this_param.Translate((Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 45007, 45047);
                    return return_v;
                }


                Microsoft.Cci.IGenericParameterReference
                f_10203_45127_45169(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                param)
                {
                    var return_v = Translate((Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol)param);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 45127, 45169);
                    return return_v;
                }


                Microsoft.Cci.IFunctionPointerTypeReference
                f_10203_45255_45303(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                symbol)
                {
                    var return_v = this_param.Translate((Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 45255, 45303);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SymbolKind
                f_10203_45376_45391(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 45376, 45391);
                    return return_v;
                }


                System.Exception
                f_10203_45341_45392(Microsoft.CodeAnalysis.SymbolKind
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 45341, 45392);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 44203, 45404);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 44203, 45404);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Cci.IFieldReference Translate(
                    FieldSymbol fieldSymbol,
                    SyntaxNode syntaxNodeOpt,
                    DiagnosticBag diagnostics,
                    bool needDeclaration = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 45416, 46843);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 45640, 45691);

                f_10203_45640_45690(f_10203_45653_45689(fieldSymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 45705, 45885);

                f_10203_45705_45884(f_10203_45718_45750_M(!fieldSymbol.IsVirtualTupleField) && (DynAbs.Tracing.TraceSender.Expression_True(10203, 45718, 45826) && (object)(f_10203_45763_45795(fieldSymbol) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol>(10203, 45763, 45810) ?? fieldSymbol)) == fieldSymbol), "tuple fields should be rewritten to underlying by now");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 45901, 46676) || true) && (f_10203_45905_45930_M(!fieldSymbol.IsDefinition))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 45901, 46676);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 45964, 45995);

                    f_10203_45964_45994(!needDeclaration);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 46015, 46070);

                    return (Cci.IFieldReference)f_10203_46043_46069(this, fieldSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 45901, 46676);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 45901, 46676);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 46104, 46676) || true) && (!needDeclaration && (DynAbs.Tracing.TraceSender.Expression_True(10203, 46108, 46169) && f_10203_46128_46169(f_10203_46142_46168(fieldSymbol))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 46104, 46676);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 46203, 46220);

                        object
                        reference
                        = default(object);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 46238, 46267);

                        Cci.IFieldReference
                        fieldRef
                        = default(Cci.IFieldReference);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 46287, 46449) || true) && (f_10203_46291_46350(_genericInstanceMap, fieldSymbol, out reference))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 46287, 46449);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 46392, 46430);

                            return (Cci.IFieldReference)reference;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 46287, 46449);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 46469, 46523);

                        fieldRef = f_10203_46480_46522(fieldSymbol);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 46541, 46625);

                        fieldRef = (Cci.IFieldReference)f_10203_46573_46624(_genericInstanceMap, fieldSymbol, fieldRef);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 46645, 46661);

                        return fieldRef;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 46104, 46676);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 45901, 46676);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 46692, 46832);

                return f_10203_46699_46800_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(_embeddedTypesManagerOpt, 10203, 46699, 46800)?.EmbedFieldIfNeedTo(f_10203_46744_46771(fieldSymbol), syntaxNodeOpt, diagnostics)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.Cci.IFieldReference?>(10203, 46699, 46831) ?? f_10203_46804_46831(fieldSymbol));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 45416, 46843);

                bool
                f_10203_45653_45689(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinitionOrDistinct();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 45653, 45689);
                    return return_v;
                }


                int
                f_10203_45640_45690(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 45640, 45690);
                    return 0;
                }


                bool
                f_10203_45718_45750_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 45718, 45750);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                f_10203_45763_45795(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.TupleUnderlyingField;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 45763, 45795);
                    return return_v;
                }


                int
                f_10203_45705_45884(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 45705, 45884);
                    return 0;
                }


                bool
                f_10203_45905_45930_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 45905, 45930);
                    return return_v;
                }


                int
                f_10203_45964_45994(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 45964, 45994);
                    return 0;
                }


                object
                f_10203_46043_46069(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                symbol)
                {
                    var return_v = this_param.GetCciAdapter((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 46043, 46069);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10203_46142_46168(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 46142, 46168);
                    return return_v;
                }


                bool
                f_10203_46128_46169(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                toCheck)
                {
                    var return_v = IsGenericType(toCheck);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 46128, 46169);
                    return return_v;
                }


                bool
                f_10203_46291_46350(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, object>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                key, out object
                value)
                {
                    var return_v = this_param.TryGetValue((Microsoft.CodeAnalysis.CSharp.Symbol)key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 46291, 46350);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.SpecializedFieldReference
                f_10203_46480_46522(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                underlyingField)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Emit.SpecializedFieldReference(underlyingField);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 46480, 46522);
                    return return_v;
                }


                object
                f_10203_46573_46624(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, object>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                key, Microsoft.Cci.IFieldReference
                value)
                {
                    var return_v = this_param.GetOrAdd((Microsoft.CodeAnalysis.CSharp.Symbol)key, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 46573, 46624);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                f_10203_46744_46771(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 46744, 46771);
                    return return_v;
                }


                Microsoft.Cci.IFieldReference?
                f_10203_46699_46800_I(Microsoft.Cci.IFieldReference?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 46699, 46800);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbolAdapter
                f_10203_46804_46831(Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 46804, 46831);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 45416, 46843);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 45416, 46843);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static Cci.TypeMemberVisibility MemberVisibility(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10203, 46855, 49966);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 47689, 49955);

                switch (f_10203_47697_47725(symbol))
                {

                    case Accessibility.Public:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 47689, 49955);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 47807, 47846);

                        return Cci.TypeMemberVisibility.Public;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 47689, 49955);

                    case Accessibility.Private:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 47689, 49955);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 47915, 48277) || true) && (f_10203_47919_47950_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10203_47919_47940(symbol), 10203, 47919, 47950)?.TypeKind) == TypeKind.Submission)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 47915, 48277);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 48077, 48116);

                            return Cci.TypeMemberVisibility.Public;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 47915, 48277);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 47915, 48277);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 48214, 48254);

                            return Cci.TypeMemberVisibility.Private;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 47915, 48277);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 47689, 49955);

                    case Accessibility.Internal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 47689, 49955);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 48347, 48706) || true) && (f_10203_48351_48390(f_10203_48351_48376(symbol)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 48347, 48706);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 48505, 48544);

                            return Cci.TypeMemberVisibility.Public;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 48347, 48706);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 48347, 48706);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 48642, 48683);

                            return Cci.TypeMemberVisibility.Assembly;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 48347, 48706);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 47689, 49955);

                    case Accessibility.Protected:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 47689, 49955);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 48777, 49139) || true) && (f_10203_48781_48811(f_10203_48781_48802(symbol)) == TypeKind.Submission)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 48777, 49139);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 48940, 48979);

                            return Cci.TypeMemberVisibility.Public;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 48777, 49139);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 48777, 49139);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 49077, 49116);

                            return Cci.TypeMemberVisibility.Family;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 48777, 49139);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 47689, 49955);

                    case Accessibility.ProtectedAndInternal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 47689, 49955);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 49221, 49289);

                        f_10203_49221_49288(f_10203_49234_49264(f_10203_49234_49255(symbol)) != TypeKind.Submission);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 49311, 49361);

                        return Cci.TypeMemberVisibility.FamilyAndAssembly;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 47689, 49955);

                    case Accessibility.ProtectedOrInternal:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 47689, 49955);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 49442, 49819) || true) && (f_10203_49446_49485(f_10203_49446_49471(symbol)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 49442, 49819);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 49610, 49649);

                            return Cci.TypeMemberVisibility.Public;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 49442, 49819);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 49442, 49819);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 49747, 49796);

                            return Cci.TypeMemberVisibility.FamilyOrAssembly;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 49442, 49819);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 47689, 49955);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 47689, 49955);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 49869, 49940);

                        throw f_10203_49875_49939(f_10203_49910_49938(symbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 47689, 49955);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10203, 46855, 49966);

                Microsoft.CodeAnalysis.Accessibility
                f_10203_47697_47725(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 47697, 47725);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10203_47919_47940(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 47919, 47940);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind?
                f_10203_47919_47950_M(Microsoft.CodeAnalysis.TypeKind?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 47919, 47950);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10203_48351_48376(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 48351, 48376);
                    return return_v;
                }


                bool
                f_10203_48351_48390(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.IsInteractive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 48351, 48390);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10203_48781_48802(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 48781, 48802);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10203_48781_48811(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 48781, 48811);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10203_49234_49255(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 49234, 49255);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypeKind
                f_10203_49234_49264(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.TypeKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 49234, 49264);
                    return return_v;
                }


                int
                f_10203_49221_49288(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 49221, 49288);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10203_49446_49471(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 49446, 49471);
                    return return_v;
                }


                bool
                f_10203_49446_49485(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.IsInteractive;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 49446, 49485);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Accessibility
                f_10203_49910_49938(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.DeclaredAccessibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 49910, 49938);
                    return return_v;
                }


                System.Exception
                f_10203_49875_49939(Microsoft.CodeAnalysis.Accessibility
                o)
                {
                    var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 49875, 49939);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 46855, 49966);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 46855, 49966);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override Cci.IMethodReference Translate(MethodSymbol symbol, DiagnosticBag diagnostics, bool needDeclaration)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 49978, 50206);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 50128, 50195);

                return f_10203_50135_50194(this, symbol, null, diagnostics, null, needDeclaration);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 49978, 50206);

                Microsoft.Cci.IMethodReference
                f_10203_50135_50194(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodSymbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.CSharp.BoundArgListOperator
                optArgList, bool
                needDeclaration)
                {
                    var return_v = this_param.Translate(methodSymbol, syntaxNodeOpt, diagnostics, optArgList, needDeclaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 50135, 50194);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 49978, 50206);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 49978, 50206);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Cci.IMethodReference Translate(
                    MethodSymbol methodSymbol,
                    SyntaxNode syntaxNodeOpt,
                    DiagnosticBag diagnostics,
                    BoundArgListOperator optArgList = null,
                    bool needDeclaration = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 50218, 51803);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 50498, 50558);

                f_10203_50498_50557(!f_10203_50512_50556(methodSymbol));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 50572, 50652);

                f_10203_50572_50651(optArgList == null || (DynAbs.Tracing.TraceSender.Expression_False(10203, 50585, 50650) || (f_10203_50608_50629(methodSymbol) && (DynAbs.Tracing.TraceSender.Expression_True(10203, 50608, 50649) && !needDeclaration))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 50668, 50780);

                Cci.IMethodReference
                unexpandedMethodRef = f_10203_50711_50779(this, methodSymbol, syntaxNodeOpt, diagnostics, needDeclaration)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 50796, 51792) || true) && (optArgList != null && (DynAbs.Tracing.TraceSender.Expression_True(10203, 50800, 50853) && optArgList.Arguments.Length > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 50796, 51792);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 50887, 50992);

                    Cci.IParameterTypeInformation[]
                    @params = new Cci.IParameterTypeInformation[optArgList.Arguments.Length]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 51010, 51052);

                    int
                    ordinal = f_10203_51024_51051(methodSymbol)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 51081, 51086);

                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 51072, 51572) || true) && (i < f_10203_51092_51106(@params))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 51108, 51111)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 51072, 51572))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 51072, 51572);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 51153, 51521);

                            @params[i] = f_10203_51166_51520(ordinal, f_10203_51280_51328_M(!optArgList.ArgumentRefKindsOpt.IsDefaultOrEmpty) && (DynAbs.Tracing.TraceSender.Expression_True(10203, 51280, 51381) && f_10203_51332_51362(optArgList)[i] != RefKind.None), f_10203_51452_51519(this, f_10203_51462_51490(f_10203_51462_51482(optArgList)[i]), syntaxNodeOpt, diagnostics));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 51543, 51553);

                            ordinal++;
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10203, 1, 501);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10203, 1, 501);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 51592, 51684);

                    return f_10203_51599_51683(unexpandedMethodRef, f_10203_51655_51682(@params));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 50796, 51792);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 50796, 51792);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 51750, 51777);

                    return unexpandedMethodRef;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 50796, 51792);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 50218, 51803);

                bool
                f_10203_50512_50556(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = method.IsDefaultValueTypeConstructor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 50512, 50556);
                    return return_v;
                }


                int
                f_10203_50498_50557(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 50498, 50557);
                    return 0;
                }


                bool
                f_10203_50608_50629(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsVararg;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 50608, 50629);
                    return return_v;
                }


                int
                f_10203_50572_50651(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 50572, 50651);
                    return 0;
                }


                Microsoft.Cci.IMethodReference
                f_10203_50711_50779(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                methodSymbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, bool
                needDeclaration)
                {
                    var return_v = this_param.Translate(methodSymbol, syntaxNodeOpt, diagnostics, needDeclaration);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 50711, 50779);
                    return return_v;
                }


                int
                f_10203_51024_51051(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 51024, 51051);
                    return return_v;
                }


                int
                f_10203_51092_51106(Microsoft.Cci.IParameterTypeInformation[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 51092, 51106);
                    return return_v;
                }


                bool
                f_10203_51280_51328_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 51280, 51328);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
                f_10203_51332_51362(Microsoft.CodeAnalysis.CSharp.BoundArgListOperator
                this_param)
                {
                    var return_v = this_param.ArgumentRefKindsOpt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 51332, 51362);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                f_10203_51462_51482(Microsoft.CodeAnalysis.CSharp.BoundArgListOperator
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 51462, 51482);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                f_10203_51462_51490(Microsoft.CodeAnalysis.CSharp.BoundExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 51462, 51490);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_10203_51452_51519(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                typeSymbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(typeSymbol, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 51452, 51519);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.ArgListParameterTypeInformation
                f_10203_51166_51520(int
                ordinal, bool
                isByRef, Microsoft.Cci.ITypeReference
                type)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Emit.ArgListParameterTypeInformation(ordinal, isByRef, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 51166, 51520);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterTypeInformation>
                f_10203_51655_51682(Microsoft.Cci.IParameterTypeInformation[]
                items)
                {
                    var return_v = items.AsImmutableOrNull<Microsoft.Cci.IParameterTypeInformation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 51655, 51682);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.ExpandedVarargsMethodReference
                f_10203_51599_51683(Microsoft.Cci.IMethodReference
                underlyingMethod, System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterTypeInformation>
                argListParams)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Emit.ExpandedVarargsMethodReference(underlyingMethod, argListParams);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 51599, 51683);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 50218, 51803);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 50218, 51803);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Cci.IMethodReference Translate(
                    MethodSymbol methodSymbol,
                    SyntaxNode syntaxNodeOpt,
                    DiagnosticBag diagnostics,
                    bool needDeclaration)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 51815, 54805);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 52033, 52050);

                object
                reference
                = default(object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 52064, 52095);

                Cci.IMethodReference
                methodRef
                = default(Cci.IMethodReference);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 52109, 52165);

                NamedTypeSymbol
                container = f_10203_52137_52164(methodSymbol)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 52239, 52451) || true) && (f_10203_52243_52268(container))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 52239, 52451);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 52302, 52333);

                    f_10203_52302_52332(!needDeclaration);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 52351, 52436);

                    methodSymbol = f_10203_52366_52435(methodSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 52239, 52451);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 52467, 52519);

                f_10203_52467_52518(f_10203_52480_52517(methodSymbol));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 52535, 54531) || true) && (f_10203_52539_52565_M(!methodSymbol.IsDefinition))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 52535, 54531);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 52599, 52630);

                    f_10203_52599_52629(!needDeclaration);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 52648, 52726);

                    f_10203_52648_52725(!(f_10203_52663_52694(methodSymbol) is NativeIntegerMethodSymbol));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 52744, 52819);

                    f_10203_52744_52818(!(f_10203_52759_52787(methodSymbol) is NativeIntegerMethodSymbol));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 52839, 52896);

                    return (Cci.IMethodReference)f_10203_52868_52895(this, methodSymbol);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 52535, 54531);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 52535, 54531);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 52930, 54531) || true) && (!needDeclaration)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 52930, 54531);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 52984, 53036);

                        bool
                        methodIsGeneric = f_10203_53007_53035(methodSymbol)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 53054, 53100);

                        bool
                        typeIsGeneric = f_10203_53075_53099(container)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 53120, 54516) || true) && (methodIsGeneric || (DynAbs.Tracing.TraceSender.Expression_False(10203, 53124, 53156) || typeIsGeneric))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 53120, 54516);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 53198, 53374) || true) && (f_10203_53202_53262(_genericInstanceMap, methodSymbol, out reference))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 53198, 53374);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 53312, 53351);

                                return (Cci.IMethodReference)reference;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 53198, 53374);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 53398, 54131) || true) && (methodIsGeneric)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 53398, 54131);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 53467, 53899) || true) && (typeIsGeneric)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 53467, 53899);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 53625, 53697);

                                    methodRef = f_10203_53637_53696(methodSymbol);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 53467, 53899);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 53467, 53899);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 53811, 53872);

                                    methodRef = f_10203_53823_53871(methodSymbol);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 53467, 53899);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 53398, 54131);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 53398, 54131);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 53997, 54025);

                                f_10203_53997_54024(typeIsGeneric);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 54051, 54108);

                                methodRef = f_10203_54063_54107(methodSymbol);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 53398, 54131);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 54155, 54243);

                            methodRef = (Cci.IMethodReference)f_10203_54189_54242(_genericInstanceMap, methodSymbol, methodRef);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 54267, 54284);

                            return methodRef;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 53120, 54516);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 53120, 54516);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 54326, 54516) || true) && (methodSymbol is NativeIntegerMethodSymbol { UnderlyingMethod: MethodSymbol underlyingMethod })
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 54326, 54516);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 54465, 54497);

                                methodSymbol = underlyingMethod;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 54326, 54516);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 53120, 54516);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 52930, 54531);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 52535, 54531);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 54547, 54742) || true) && (_embeddedTypesManagerOpt != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 54547, 54742);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 54617, 54727);

                    return f_10203_54624_54726(_embeddedTypesManagerOpt, f_10203_54669_54697(methodSymbol), syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 54547, 54742);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 54758, 54794);

                return f_10203_54765_54793(methodSymbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 51815, 54805);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10203_52137_52164(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 52137, 52164);
                    return return_v;
                }


                bool
                f_10203_52243_52268(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.IsAnonymousType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 52243, 52268);
                    return return_v;
                }


                int
                f_10203_52302_52332(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 52302, 52332);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10203_52366_52435(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                method)
                {
                    var return_v = AnonymousTypeManager.TranslateAnonymousTypeMethodSymbol(method);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 52366, 52435);
                    return return_v;
                }


                bool
                f_10203_52480_52517(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinitionOrDistinct();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 52480, 52517);
                    return return_v;
                }


                int
                f_10203_52467_52518(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 52467, 52518);
                    return 0;
                }


                bool
                f_10203_52539_52565_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 52539, 52565);
                    return return_v;
                }


                int
                f_10203_52599_52629(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 52599, 52629);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10203_52663_52694(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.OriginalDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 52663, 52694);
                    return return_v;
                }


                int
                f_10203_52648_52725(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 52648, 52725);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                f_10203_52759_52787(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ConstructedFrom;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 52759, 52787);
                    return return_v;
                }


                int
                f_10203_52744_52818(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 52744, 52818);
                    return 0;
                }


                object
                f_10203_52868_52895(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                symbol)
                {
                    var return_v = this_param.GetCciAdapter((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 52868, 52895);
                    return return_v;
                }


                bool
                f_10203_53007_53035(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsGenericMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 53007, 53035);
                    return return_v;
                }


                bool
                f_10203_53075_53099(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                toCheck)
                {
                    var return_v = IsGenericType(toCheck);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 53075, 53099);
                    return return_v;
                }


                bool
                f_10203_53202_53262(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, object>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                key, out object
                value)
                {
                    var return_v = this_param.TryGetValue((Microsoft.CodeAnalysis.CSharp.Symbol)key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 53202, 53262);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.SpecializedGenericMethodInstanceReference
                f_10203_53637_53696(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                underlyingMethod)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Emit.SpecializedGenericMethodInstanceReference(underlyingMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 53637, 53696);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.GenericMethodInstanceReference
                f_10203_53823_53871(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                underlyingMethod)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Emit.GenericMethodInstanceReference(underlyingMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 53823, 53871);
                    return return_v;
                }


                int
                f_10203_53997_54024(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 53997, 54024);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.SpecializedMethodReference
                f_10203_54063_54107(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                underlyingMethod)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Emit.SpecializedMethodReference(underlyingMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 54063, 54107);
                    return return_v;
                }


                object
                f_10203_54189_54242(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, object>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                key, Microsoft.Cci.IMethodReference
                value)
                {
                    var return_v = this_param.GetOrAdd((Microsoft.CodeAnalysis.CSharp.Symbol)key, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 54189, 54242);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                f_10203_54669_54697(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 54669, 54697);
                    return return_v;
                }


                Microsoft.Cci.IMethodReference
                f_10203_54624_54726(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                methodSymbol, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.EmbedMethodIfNeedTo(methodSymbol, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 54624, 54726);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                f_10203_54765_54793(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 54765, 54793);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 51815, 54805);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 51815, 54805);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Cci.IMethodReference TranslateOverriddenMethodReference(
                    MethodSymbol methodSymbol,
                    CSharpSyntaxNode syntaxNodeOpt,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 54817, 56451);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 55032, 55063);

                Cci.IMethodReference
                methodRef
                = default(Cci.IMethodReference);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 55077, 55133);

                NamedTypeSymbol
                container = f_10203_55105_55132(methodSymbol)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 55149, 56407) || true) && (f_10203_55153_55177(container))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 55149, 56407);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 55211, 55931) || true) && (f_10203_55215_55240(methodSymbol))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 55211, 55931);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 55282, 55299);

                        object
                        reference
                        = default(object);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 55323, 55773) || true) && (f_10203_55327_55387(_genericInstanceMap, methodSymbol, out reference))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 55323, 55773);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 55437, 55481);

                            methodRef = (Cci.IMethodReference)reference;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 55323, 55773);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 55323, 55773);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 55579, 55636);

                            methodRef = f_10203_55591_55635(methodSymbol);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 55662, 55750);

                            methodRef = (Cci.IMethodReference)f_10203_55696_55749(_genericInstanceMap, methodSymbol, methodRef);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 55323, 55773);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 55211, 55931);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 55211, 55931);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 55855, 55912);

                        methodRef = f_10203_55867_55911(methodSymbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 55211, 55931);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 55149, 56407);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 55149, 56407);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 55997, 56037);

                    f_10203_55997_56036(f_10203_56010_56035(methodSymbol));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 56057, 56392) || true) && (_embeddedTypesManagerOpt != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 56057, 56392);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 56135, 56250);

                        methodRef = f_10203_56147_56249(_embeddedTypesManagerOpt, f_10203_56192_56220(methodSymbol), syntaxNodeOpt, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 56057, 56392);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 56057, 56392);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 56332, 56373);

                        methodRef = f_10203_56344_56372(methodSymbol);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 56057, 56392);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 55149, 56407);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 56423, 56440);

                return methodRef;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 54817, 56451);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10203_55105_55132(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 55105, 55132);
                    return return_v;
                }


                bool
                f_10203_55153_55177(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                toCheck)
                {
                    var return_v = IsGenericType(toCheck);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 55153, 55177);
                    return return_v;
                }


                bool
                f_10203_55215_55240(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 55215, 55240);
                    return return_v;
                }


                bool
                f_10203_55327_55387(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, object>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                key, out object
                value)
                {
                    var return_v = this_param.TryGetValue((Microsoft.CodeAnalysis.CSharp.Symbol)key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 55327, 55387);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.SpecializedMethodReference
                f_10203_55591_55635(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                underlyingMethod)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Emit.SpecializedMethodReference(underlyingMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 55591, 55635);
                    return return_v;
                }


                object
                f_10203_55696_55749(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, object>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                key, Microsoft.Cci.IMethodReference
                value)
                {
                    var return_v = this_param.GetOrAdd((Microsoft.CodeAnalysis.CSharp.Symbol)key, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 55696, 55749);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.SpecializedMethodReference
                f_10203_55867_55911(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                underlyingMethod)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Emit.SpecializedMethodReference(underlyingMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 55867, 55911);
                    return return_v;
                }


                bool
                f_10203_56010_56035(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 56010, 56035);
                    return return_v;
                }


                int
                f_10203_55997_56036(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 55997, 56036);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                f_10203_56192_56220(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 56192, 56220);
                    return return_v;
                }


                Microsoft.Cci.IMethodReference
                f_10203_56147_56249(Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                methodSymbol, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.EmbedMethodIfNeedTo(methodSymbol, (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 56147, 56249);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                f_10203_56344_56372(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 56344, 56372);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 54817, 56451);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 54817, 56451);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ImmutableArray<Cci.IParameterTypeInformation> Translate(ImmutableArray<ParameterSymbol> @params)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 56463, 57221);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 56593, 56652);

                f_10203_56593_56651(@params.All(p => p.IsDefinitionOrDistinct()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 56668, 56740);

                bool
                mustBeTranslated = @params.Any() && (DynAbs.Tracing.TraceSender.Expression_True(10203, 56692, 56739) && f_10203_56709_56739(@params.First()))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 56754, 56871);

                f_10203_56754_56870(@params.All(p => mustBeTranslated == MustBeWrapped(p)), "either all or no parameters need translating");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 56887, 57165) || true) && (!mustBeTranslated)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 56887, 57165);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 56953, 57054);

                    return @params.SelectAsArray<ParameterSymbol, Cci.IParameterTypeInformation>(p => p.GetCciAdapter());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 56887, 57165);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 57181, 57210);

                return f_10203_57188_57209(this, @params);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 56463, 57221);

                int
                f_10203_56593_56651(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 56593, 56651);
                    return 0;
                }


                bool
                f_10203_56709_56739(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                param)
                {
                    var return_v = MustBeWrapped(param);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 56709, 56739);
                    return return_v;
                }


                int
                f_10203_56754_56870(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 56754, 56870);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterTypeInformation>
                f_10203_57188_57209(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                @params)
                {
                    var return_v = this_param.TranslateAll(@params);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 57188, 57209);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 56463, 57221);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 56463, 57221);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool MustBeWrapped(ParameterSymbol param)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10203, 57233, 57974);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 57700, 57934) || true) && (f_10203_57704_57722(param))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 57700, 57934);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 57756, 57795);

                    var
                    container = f_10203_57772_57794(param)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 57813, 57919) || true) && (f_10203_57817_57846(container))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 57813, 57919);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 57888, 57900);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 57813, 57919);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 57700, 57934);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 57950, 57963);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10203, 57233, 57974);

                bool
                f_10203_57704_57722(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.IsDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 57704, 57722);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10203_57772_57794(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 57772, 57794);
                    return return_v;
                }


                bool
                f_10203_57817_57846(Microsoft.CodeAnalysis.CSharp.Symbol
                container)
                {
                    var return_v = ContainerIsGeneric(container);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 57817, 57846);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 57233, 57974);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 57233, 57974);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableArray<Cci.IParameterTypeInformation> TranslateAll(ImmutableArray<ParameterSymbol> @params)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 57986, 58401);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 58118, 58190);

                var
                builder = f_10203_58132_58189()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 58204, 58340);
                    foreach (var param in f_10203_58226_58233_I(@params))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 58204, 58340);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 58267, 58325);

                        f_10203_58267_58324(builder, f_10203_58279_58323(this, param));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 58204, 58340);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10203, 1, 137);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10203, 1, 137);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 58354, 58390);

                return f_10203_58361_58389(builder);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 57986, 58401);

                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.IParameterTypeInformation>
                f_10203_58132_58189()
                {
                    var return_v = ArrayBuilder<Cci.IParameterTypeInformation>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 58132, 58189);
                    return return_v;
                }


                Microsoft.Cci.IParameterTypeInformation
                f_10203_58279_58323(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                param)
                {
                    var return_v = this_param.CreateParameterTypeInformationWrapper(param);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 58279, 58323);
                    return return_v;
                }


                int
                f_10203_58267_58324(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.IParameterTypeInformation>
                this_param, Microsoft.Cci.IParameterTypeInformation
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 58267, 58324);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10203_58226_58233_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 58226, 58233);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.Cci.IParameterTypeInformation>
                f_10203_58361_58389(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.Cci.IParameterTypeInformation>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 58361, 58389);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 57986, 58401);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 57986, 58401);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Cci.IParameterTypeInformation CreateParameterTypeInformationWrapper(ParameterSymbol param)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 58413, 58984);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 58536, 58553);

                object
                reference
                = default(object);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 58567, 58606);

                Cci.IParameterTypeInformation
                paramRef
                = default(Cci.IParameterTypeInformation);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 58622, 58776) || true) && (f_10203_58626_58679(_genericInstanceMap, param, out reference))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 58622, 58776);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 58713, 58761);

                    return (Cci.IParameterTypeInformation)reference;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 58622, 58776);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 58792, 58839);

                paramRef = f_10203_58803_58838(param);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 58853, 58941);

                paramRef = (Cci.IParameterTypeInformation)f_10203_58895_58940(_genericInstanceMap, param, paramRef);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 58957, 58973);

                return paramRef;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 58413, 58984);

                bool
                f_10203_58626_58679(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, object>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                key, out object
                value)
                {
                    var return_v = this_param.TryGetValue((Microsoft.CodeAnalysis.CSharp.Symbol)key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 58626, 58679);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Emit.ParameterTypeInformation
                f_10203_58803_58838(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                underlyingParameter)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Emit.ParameterTypeInformation(underlyingParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 58803, 58838);
                    return return_v;
                }


                object
                f_10203_58895_58940(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, object>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                key, Microsoft.Cci.IParameterTypeInformation
                value)
                {
                    var return_v = this_param.GetOrAdd((Microsoft.CodeAnalysis.CSharp.Symbol)key, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 58895, 58940);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 58413, 58984);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 58413, 58984);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool ContainerIsGeneric(Symbol container)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10203, 58996, 59236);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 59077, 59225);

                return f_10203_59084_59098(container) == SymbolKind.Method && (DynAbs.Tracing.TraceSender.Expression_True(10203, 59084, 59164) && f_10203_59123_59164(((MethodSymbol)container))) || (DynAbs.Tracing.TraceSender.Expression_False(10203, 59084, 59224) || f_10203_59185_59224(f_10203_59199_59223(container)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10203, 58996, 59236);

                Microsoft.CodeAnalysis.SymbolKind
                f_10203_59084_59098(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.Kind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 59084, 59098);
                    return return_v;
                }


                bool
                f_10203_59123_59164(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.IsGenericMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 59123, 59164);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10203_59199_59223(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 59199, 59223);
                    return return_v;
                }


                bool
                f_10203_59185_59224(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                toCheck)
                {
                    var return_v = IsGenericType(toCheck);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 59185, 59224);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 58996, 59236);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 58996, 59236);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Cci.ITypeReference Translate(
                    DynamicTypeSymbol symbol,
                    SyntaxNode syntaxNodeOpt,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 59248, 59844);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 59756, 59833);

                return f_10203_59763_59832(this, SpecialType.System_Object, syntaxNodeOpt, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 59248, 59844);

                Microsoft.Cci.INamedTypeReference
                f_10203_59763_59832(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetSpecialType(specialType, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 59763, 59832);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 59248, 59844);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 59248, 59844);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Cci.IArrayTypeReference Translate(ArrayTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 59856, 60012);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 59947, 60001);

                return (Cci.IArrayTypeReference)f_10203_59979_60000(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 59856, 60012);

                object
                f_10203_59979_60000(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                symbol)
                {
                    var return_v = this_param.GetCciAdapter((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 59979, 60000);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 59856, 60012);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 59856, 60012);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Cci.IPointerTypeReference Translate(PointerTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 60024, 60186);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 60119, 60175);

                return (Cci.IPointerTypeReference)f_10203_60153_60174(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 60024, 60186);

                object
                f_10203_60153_60174(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                symbol)
                {
                    var return_v = this_param.GetCciAdapter((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 60153, 60174);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 60024, 60186);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 60024, 60186);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Cci.IFunctionPointerTypeReference Translate(FunctionPointerTypeSymbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 60198, 60384);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 60309, 60373);

                return (Cci.IFunctionPointerTypeReference)f_10203_60351_60372(this, symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 60198, 60384);

                object
                f_10203_60351_60372(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                symbol)
                {
                    var return_v = this_param.GetCciAdapter((Microsoft.CodeAnalysis.CSharp.Symbol)symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 60351, 60372);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 60198, 60384);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 60198, 60384);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public NamedTypeSymbol SetFixedImplementationType(SourceMemberFieldSymbol field)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 60532, 61373);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 60637, 60836) || true) && (_fixedImplementationTypes == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 60637, 60836);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 60708, 60821);

                    f_10203_60708_60820(ref _fixedImplementationTypes, f_10203_60767_60813(), null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 60637, 60836);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 60858, 60883);

                lock (_fixedImplementationTypes)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 60917, 60940);

                    NamedTypeSymbol
                    result
                    = default(NamedTypeSymbol);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 60958, 61093) || true) && (f_10203_60962_61018(_fixedImplementationTypes, field, out result))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 60958, 61093);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 61060, 61074);

                        return result;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 60958, 61093);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 61113, 61162);

                    result = f_10203_61122_61161(field);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 61180, 61225);

                    f_10203_61180_61224(_fixedImplementationTypes, field, result);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 61243, 61315);

                    f_10203_61243_61314(this, f_10203_61268_61289(result), f_10203_61291_61313(result));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 61333, 61347);

                    return result;
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 60532, 61373);

                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10203_60767_60813()
                {
                    var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 60767, 60813);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>?
                f_10203_60708_60820(ref System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>?
                location1, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                value, System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 60708, 60820);
                    return return_v;
                }


                bool
                f_10203_60962_61018(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbol
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                value)
                {
                    var return_v = this_param.TryGetValue((Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol)key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 60962, 61018);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FixedFieldImplementationType
                f_10203_61122_61161(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbol
                field)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.FixedFieldImplementationType(field);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 61122, 61161);
                    return return_v;
                }


                int
                f_10203_61180_61224(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberFieldSymbol
                key, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                value)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol)key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 61180, 61224);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10203_61268_61289(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 61268, 61289);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                f_10203_61291_61313(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 61291, 61313);
                    return return_v;
                }


                int
                f_10203_61243_61314(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                container, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbolAdapter
                nestedType)
                {
                    this_param.AddSynthesizedDefinition(container, (Microsoft.Cci.INestedTypeDefinition)nestedType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 61243, 61314);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 60532, 61373);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 60532, 61373);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal NamedTypeSymbol GetFixedImplementationType(FieldSymbol field)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 61385, 61937);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 61758, 61781);

                NamedTypeSymbol
                result
                = default(NamedTypeSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 61795, 61864);

                var
                found = f_10203_61807_61863(_fixedImplementationTypes, field, out result)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 61878, 61898);

                f_10203_61878_61897(found);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 61912, 61926);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 61385, 61937);

                bool
                f_10203_61807_61863(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 61807, 61863);
                    return return_v;
                }


                int
                f_10203_61878_61897(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 61878, 61897);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 61385, 61937);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 61385, 61937);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override Cci.IMethodDefinition CreatePrivateImplementationDetailsStaticConstructor(PrivateImplementationDetails details, SyntaxNode syntaxOpt, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 61949, 62348);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 62153, 62337);

                return f_10203_62160_62336(f_10203_62160_62320(SourceModule, details, f_10203_62244_62319(this, SpecialType.System_Void, syntaxOpt, diagnostics)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 61949, 62348);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10203_62244_62319(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType, Microsoft.CodeAnalysis.SyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetUntranslatedSpecialType(specialType, syntaxNodeOpt, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 62244, 62319);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedPrivateImplementationDetailsStaticConstructor
                f_10203_62160_62320(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                containingModule, Microsoft.CodeAnalysis.CodeGen.PrivateImplementationDetails
                privateImplementationType, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                voidType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedPrivateImplementationDetailsStaticConstructor(containingModule, privateImplementationType, voidType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 62160, 62320);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbolAdapter
                f_10203_62160_62336(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedPrivateImplementationDetailsStaticConstructor
                this_param)
                {
                    var return_v = this_param.GetCciAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 62160, 62336);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 61949, 62348);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 61949, 62348);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract SynthesizedAttributeData SynthesizeEmbeddedAttribute();

        internal SynthesizedAttributeData SynthesizeIsReadOnlyAttribute(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 62445, 62865);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 62548, 62796) || true) && ((object)f_10203_62560_62584(Compilation) != f_10203_62588_62611(symbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 62548, 62796);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 62769, 62781);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 62548, 62796);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 62812, 62854);

                return f_10203_62819_62853(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 62445, 62865);

                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10203_62560_62584(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 62560, 62584);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10203_62588_62611(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 62588, 62611);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10203_62819_62853(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param)
                {
                    var return_v = this_param.TrySynthesizeIsReadOnlyAttribute();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 62819, 62853);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 62445, 62865);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 62445, 62865);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SynthesizedAttributeData SynthesizeIsUnmanagedAttribute(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 62877, 63299);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 62981, 63229) || true) && ((object)f_10203_62993_63017(Compilation) != f_10203_63021_63044(symbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 62981, 63229);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 63202, 63214);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 62981, 63229);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 63245, 63288);

                return f_10203_63252_63287(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 62877, 63299);

                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10203_62993_63017(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 62993, 63017);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10203_63021_63044(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 63021, 63044);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10203_63252_63287(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param)
                {
                    var return_v = this_param.TrySynthesizeIsUnmanagedAttribute();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 63252, 63287);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 62877, 63299);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 62877, 63299);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SynthesizedAttributeData SynthesizeIsByRefLikeAttribute(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 63311, 63733);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 63415, 63663) || true) && ((object)f_10203_63427_63451(Compilation) != f_10203_63455_63478(symbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 63415, 63663);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 63636, 63648);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 63415, 63663);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 63679, 63722);

                return f_10203_63686_63721(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 63311, 63733);

                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10203_63427_63451(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 63427, 63451);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10203_63455_63478(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 63455, 63478);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10203_63686_63721(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param)
                {
                    var return_v = this_param.TrySynthesizeIsByRefLikeAttribute();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 63686, 63721);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 63311, 63733);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 63311, 63733);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SynthesizedAttributeData SynthesizeNullableAttributeIfNecessary(Symbol symbol, byte? nullableContextValue, TypeWithAnnotations type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 64083, 65987);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 64249, 64497) || true) && ((object)f_10203_64261_64285(Compilation) != f_10203_64289_64312(symbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 64249, 64497);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 64470, 64482);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 64249, 64497);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 64513, 64565);

                var
                flagsBuilder = f_10203_64532_64564()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 64579, 64620);

                type.AddNullableTransforms(flagsBuilder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 64636, 64671);

                SynthesizedAttributeData
                attribute
                = default(SynthesizedAttributeData);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 64685, 65909) || true) && (!f_10203_64690_64708(flagsBuilder))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 64685, 65909);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 64742, 64759);

                    attribute = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 64685, 65909);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 64685, 65909);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 64825, 64869);

                    f_10203_64825_64868(f_10203_64838_64867(flagsBuilder, f => f <= 2));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 64887, 64967);

                    byte?
                    commonValue = MostCommonNullableValueBuilder.GetCommonValue(flagsBuilder)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 64985, 65894) || true) && (commonValue != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 64985, 65894);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 65050, 65156);

                        attribute = f_10203_65062_65155(this, nullableContextValue, f_10203_65123_65154(commonValue));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 64985, 65894);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 64985, 65894);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 65238, 65317);

                        NamedTypeSymbol
                        byteType = f_10203_65265_65316(Compilation, SpecialType.System_Byte)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 65339, 65456);

                        var
                        byteArrayType = f_10203_65359_65455(f_10203_65389_65416(byteType), TypeWithAnnotations.Create(byteType))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 65478, 65611);

                        var
                        value = f_10203_65490_65610(flagsBuilder, (flag, byteType) => new TypedConstant(byteType, TypedConstantKind.Primitive, flag), byteType)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 65633, 65875);

                        attribute = f_10203_65645_65874(this, WellKnownMember.System_Runtime_CompilerServices_NullableAttribute__ctorTransformFlags, f_10203_65811_65873(f_10203_65833_65872(byteArrayType, value)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 64985, 65894);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 64685, 65909);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 65925, 65945);

                f_10203_65925_65944(
                            flagsBuilder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 65959, 65976);

                return attribute;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 64083, 65987);

                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10203_64261_64285(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 64261, 64285);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10203_64289_64312(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 64289, 64312);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                f_10203_64532_64564()
                {
                    var return_v = ArrayBuilder<byte>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 64532, 64564);
                    return return_v;
                }


                bool
                f_10203_64690_64708(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                this_param)
                {
                    var return_v = this_param.Any();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 64690, 64708);
                    return return_v;
                }


                bool
                f_10203_64838_64867(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                builder, System.Func<byte, bool>
                predicate)
                {
                    var return_v = builder.All<byte>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 64838, 64867);
                    return return_v;
                }


                int
                f_10203_64825_64868(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 64825, 64868);
                    return 0;
                }


                byte
                f_10203_65123_65154(byte?
                this_param)
                {
                    var return_v = this_param.GetValueOrDefault();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 65123, 65154);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10203_65062_65155(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, byte?
                nullableContextValue, byte
                nullableValue)
                {
                    var return_v = this_param.SynthesizeNullableAttributeIfNecessary(nullableContextValue, nullableValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 65062, 65155);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10203_65265_65316(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 65265, 65316);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10203_65389_65416(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 65389, 65416);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                f_10203_65359_65455(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                declaringAssembly, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                elementType)
                {
                    var return_v = ArrayTypeSymbol.CreateSZArray(declaringAssembly, elementType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 65359, 65455);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10203_65490_65610(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                items, System.Func<byte, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.TypedConstant>
                map, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                arg)
                {
                    var return_v = items.SelectAsArray<byte, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.TypedConstant>(map, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 65490, 65610);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_10203_65833_65872(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                type, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                array)
                {
                    var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 65833, 65872);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10203_65811_65873(Microsoft.CodeAnalysis.TypedConstant
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 65811, 65873);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10203_65645_65874(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                member, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                arguments)
                {
                    var return_v = this_param.SynthesizeNullableAttribute(member, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 65645, 65874);
                    return return_v;
                }


                int
                f_10203_65925_65944(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 65925, 65944);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 64083, 65987);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 64083, 65987);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SynthesizedAttributeData SynthesizeNullableAttributeIfNecessary(byte? nullableContextValue, byte nullableValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 65999, 66682);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 66144, 66319) || true) && (nullableValue == nullableContextValue || (DynAbs.Tracing.TraceSender.Expression_False(10203, 66148, 66258) || (nullableContextValue == null && (DynAbs.Tracing.TraceSender.Expression_True(10203, 66207, 66257) && nullableValue == 0))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 66144, 66319);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 66292, 66304);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 66144, 66319);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 66335, 66414);

                NamedTypeSymbol
                byteType = f_10203_66362_66413(Compilation, SpecialType.System_Byte)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 66428, 66671);

                return f_10203_66435_66670(this, WellKnownMember.System_Runtime_CompilerServices_NullableAttribute__ctorByte, f_10203_66575_66669(f_10203_66597_66668(byteType, TypedConstantKind.Primitive, nullableValue)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 65999, 66682);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10203_66362_66413(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 66362, 66413);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_10203_66597_66668(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, byte
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, kind, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 66597, 66668);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10203_66575_66669(Microsoft.CodeAnalysis.TypedConstant
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 66575, 66669);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10203_66435_66670(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                member, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                arguments)
                {
                    var return_v = this_param.SynthesizeNullableAttribute(member, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 66435, 66670);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 65999, 66682);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 65999, 66682);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual SynthesizedAttributeData SynthesizeNullableAttribute(WellKnownMember member, ImmutableArray<TypedConstant> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 66694, 67141);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 67048, 67130);

                return f_10203_67055_67129(Compilation, member, arguments, isOptionalUse: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 66694, 67141);

                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10203_67055_67129(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                arguments, bool
                isOptionalUse)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor, arguments, isOptionalUse: isOptionalUse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 67055, 67129);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 66694, 67141);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 66694, 67141);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SynthesizedAttributeData SynthesizeNullableContextAttribute(Symbol symbol, byte value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 67153, 67801);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 67273, 67311);

                var
                module = f_10203_67286_67310(Compilation)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 67325, 67583) || true) && ((object)module != symbol && (DynAbs.Tracing.TraceSender.Expression_True(10203, 67329, 67398) && (object)module != f_10203_67375_67398(symbol)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 67325, 67583);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 67556, 67568);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 67325, 67583);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 67599, 67790);

                return f_10203_67606_67789(this, f_10203_67659_67788(f_10203_67681_67787(f_10203_67699_67750(Compilation, SpecialType.System_Byte), TypedConstantKind.Primitive, value)));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 67153, 67801);

                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10203_67286_67310(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 67286, 67310);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10203_67375_67398(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 67375, 67398);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10203_67699_67750(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 67699, 67750);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_10203_67681_67787(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.TypedConstantKind
                kind, byte
                value)
                {
                    var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, kind, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 67681, 67787);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10203_67659_67788(Microsoft.CodeAnalysis.TypedConstant
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 67659, 67788);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10203_67606_67789(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                arguments)
                {
                    var return_v = this_param.SynthesizeNullableContextAttribute(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 67606, 67789);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 67153, 67801);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 67153, 67801);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual SynthesizedAttributeData SynthesizeNullableContextAttribute(ImmutableArray<TypedConstant> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 67813, 68315);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 68150, 68304);

                return f_10203_68157_68303(Compilation, WellKnownMember.System_Runtime_CompilerServices_NullableContextAttribute__ctor, arguments, isOptionalUse: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 67813, 68315);

                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10203_68157_68303(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                arguments, bool
                isOptionalUse)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor, arguments, isOptionalUse: isOptionalUse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 68157, 68303);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 67813, 68315);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 67813, 68315);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SynthesizedAttributeData SynthesizePreserveBaseOverridesAttribute()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 68327, 68586);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 68428, 68575);

                return f_10203_68435_68574(Compilation, SpecialMember.System_Runtime_CompilerServices_PreserveBaseOverridesAttribute__ctor, isOptionalUse: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 68327, 68586);

                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10203_68435_68574(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialMember
                constructor, bool
                isOptionalUse)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor, isOptionalUse: isOptionalUse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 68435, 68574);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 68327, 68586);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 68327, 68586);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal SynthesizedAttributeData SynthesizeNativeIntegerAttribute(Symbol symbol, TypeSymbol type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 68598, 70485);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 68721, 68756);

                f_10203_68721_68755((object)type != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 68770, 68813);

                f_10203_68770_68812(f_10203_68783_68811(type));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 68829, 69077) || true) && ((object)f_10203_68841_68865(Compilation) != f_10203_68869_68892(symbol))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 68829, 69077);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 69050, 69062);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 68829, 69077);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 69093, 69140);

                var
                builder = f_10203_69107_69139()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 69154, 69225);

                f_10203_69154_69224(builder, type);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 69241, 69269);

                f_10203_69241_69268(f_10203_69254_69267(builder));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 69283, 69320);

                f_10203_69283_69319(f_10203_69296_69318(builder, true));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 69336, 69371);

                SynthesizedAttributeData
                attribute
                = default(SynthesizedAttributeData);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 69385, 70412) || true) && (f_10203_69389_69402(builder) == 1 && (DynAbs.Tracing.TraceSender.Expression_True(10203, 69389, 69421) && f_10203_69411_69421(builder, 0)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 69385, 70412);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 69455, 69615);

                    attribute = f_10203_69467_69614(this, WellKnownMember.System_Runtime_CompilerServices_NativeIntegerAttribute__ctor, ImmutableArray<TypedConstant>.Empty);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 69385, 70412);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 69385, 70412);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 69681, 69766);

                    NamedTypeSymbol
                    booleanType = f_10203_69711_69765(Compilation, SpecialType.System_Boolean)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 69784, 69826);

                    f_10203_69784_69825((object)booleanType != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 69844, 69992);

                    var
                    transformFlags = f_10203_69865_69991(builder, (flag, constantType) => new TypedConstant(constantType, TypedConstantKind.Primitive, flag), booleanType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 70010, 70129);

                    var
                    boolArray = f_10203_70026_70128(f_10203_70056_70086(booleanType), TypeWithAnnotations.Create(booleanType))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 70147, 70231);

                    var
                    arguments = f_10203_70163_70230(f_10203_70185_70229(boolArray, transformFlags))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 70249, 70397);

                    attribute = f_10203_70261_70396(this, WellKnownMember.System_Runtime_CompilerServices_NativeIntegerAttribute__ctorTransformFlags, arguments);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 69385, 70412);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 70428, 70443);

                f_10203_70428_70442(
                            builder);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 70457, 70474);

                return attribute;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 68598, 70485);

                int
                f_10203_68721_68755(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 68721, 68755);
                    return 0;
                }


                bool
                f_10203_68783_68811(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.ContainsNativeInteger();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 68783, 68811);
                    return return_v;
                }


                int
                f_10203_68770_68812(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 68770, 68812);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10203_68841_68865(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.SourceModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 68841, 68865);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10203_68869_68892(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 68869, 68892);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                f_10203_69107_69139()
                {
                    var return_v = ArrayBuilder<bool>.GetInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 69107, 69139);
                    return return_v;
                }


                int
                f_10203_69154_69224(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                builder, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    CSharpCompilation.NativeIntegerTransformsEncoder.Encode(builder, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 69154, 69224);
                    return 0;
                }


                bool
                f_10203_69254_69267(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                this_param)
                {
                    var return_v = this_param.Any();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 69254, 69267);
                    return return_v;
                }


                int
                f_10203_69241_69268(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 69241, 69268);
                    return 0;
                }


                bool
                f_10203_69296_69318(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                this_param, bool
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 69296, 69318);
                    return return_v;
                }


                int
                f_10203_69283_69319(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 69283, 69319);
                    return 0;
                }


                int
                f_10203_69389_69402(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 69389, 69402);
                    return return_v;
                }


                bool
                f_10203_69411_69421(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 69411, 69421);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10203_69467_69614(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                member, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                arguments)
                {
                    var return_v = this_param.SynthesizeNativeIntegerAttribute(member, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 69467, 69614);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10203_69711_69765(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 69711, 69765);
                    return return_v;
                }


                int
                f_10203_69784_69825(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 69784, 69825);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10203_69865_69991(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                items, System.Func<bool, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.TypedConstant>
                map, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                arg)
                {
                    var return_v = items.SelectAsArray<bool, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.TypedConstant>(map, arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 69865, 69991);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10203_70056_70086(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 70056, 70086);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                f_10203_70026_70128(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                declaringAssembly, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                elementType)
                {
                    var return_v = ArrayTypeSymbol.CreateSZArray(declaringAssembly, elementType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 70026, 70128);
                    return return_v;
                }


                Microsoft.CodeAnalysis.TypedConstant
                f_10203_70185_70229(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                type, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                array)
                {
                    var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal)type, array);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 70185, 70229);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10203_70163_70230(Microsoft.CodeAnalysis.TypedConstant
                item)
                {
                    var return_v = ImmutableArray.Create(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 70163, 70230);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData
                f_10203_70261_70396(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                member, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                arguments)
                {
                    var return_v = this_param.SynthesizeNativeIntegerAttribute(member, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 70261, 70396);
                    return return_v;
                }


                int
                f_10203_70428_70442(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<bool>
                this_param)
                {
                    this_param.Free();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 70428, 70442);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 68598, 70485);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 68598, 70485);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual SynthesizedAttributeData SynthesizeNativeIntegerAttribute(WellKnownMember member, ImmutableArray<TypedConstant> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 70497, 70949);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 70856, 70938);

                return f_10203_70863_70937(Compilation, member, arguments, isOptionalUse: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 70497, 70949);

                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10203_70863_70937(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                arguments, bool
                isOptionalUse)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor, arguments, isOptionalUse: isOptionalUse);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 70863, 70937);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 70497, 70949);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 70497, 70949);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool ShouldEmitNullablePublicOnlyAttribute()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 70961, 71311);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 71215, 71300);

                return f_10203_71222_71261(Compilation) && (DynAbs.Tracing.TraceSender.Expression_True(10203, 71222, 71299) && f_10203_71265_71299(Compilation));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 70961, 71311);

                bool
                f_10203_71222_71261(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.GetUsesNullableAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 71222, 71261);
                    return return_v;
                }


                bool
                f_10203_71265_71299(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.EmitNullablePublicOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 71265, 71299);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 70961, 71311);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 70961, 71311);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual SynthesizedAttributeData SynthesizeNullablePublicOnlyAttribute(ImmutableArray<TypedConstant> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 71323, 71724);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 71577, 71713);

                return f_10203_71584_71712(Compilation, WellKnownMember.System_Runtime_CompilerServices_NullablePublicOnlyAttribute__ctor, arguments);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 71323, 71724);

                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10203_71584_71712(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                arguments)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 71584, 71712);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 71323, 71724);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 71323, 71724);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual SynthesizedAttributeData TrySynthesizeIsReadOnlyAttribute()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 71736, 72075);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 71947, 72064);

                return f_10203_71954_72063(Compilation, WellKnownMember.System_Runtime_CompilerServices_IsReadOnlyAttribute__ctor);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 71736, 72075);

                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10203_71954_72063(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 71954, 72063);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 71736, 72075);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 71736, 72075);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual SynthesizedAttributeData TrySynthesizeIsUnmanagedAttribute()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 72087, 72428);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 72299, 72417);

                return f_10203_72306_72416(Compilation, WellKnownMember.System_Runtime_CompilerServices_IsUnmanagedAttribute__ctor);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 72087, 72428);

                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10203_72306_72416(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 72306, 72416);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 72087, 72428);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 72087, 72428);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual SynthesizedAttributeData TrySynthesizeIsByRefLikeAttribute()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 72440, 72781);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 72652, 72770);

                return f_10203_72659_72769(Compilation, WellKnownMember.System_Runtime_CompilerServices_IsByRefLikeAttribute__ctor);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 72440, 72781);

                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                f_10203_72659_72769(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownMember
                constructor)
                {
                    var return_v = this_param.TrySynthesizeAttribute(constructor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 72659, 72769);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 72440, 72781);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 72440, 72781);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void EnsureEmbeddableAttributeExists(EmbeddableAttributes attribute)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 72793, 73372);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 72894, 72944);

                f_10203_72894_72943(!_needsGeneratedAttributes_IsFrozen);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 72960, 73076) || true) && ((f_10203_72965_73002(this) & attribute) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 72960, 73076);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 73054, 73061);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 72960, 73076);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 73173, 73361) || true) && (f_10203_73177_73273(Compilation, attribute, diagnosticsOpt: null, locationOpt: null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10203, 73173, 73361);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 73307, 73346);

                    f_10203_73307_73345(this, attribute);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10203, 73173, 73361);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 72793, 73372);

                int
                f_10203_72894_72943(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 72894, 72943);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.EmbeddableAttributes
                f_10203_72965_73002(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param)
                {
                    var return_v = this_param.GetNeedsGeneratedAttributesInternal();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 72965, 73002);
                    return return_v;
                }


                bool
                f_10203_73177_73273(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.EmbeddableAttributes
                attribute, Microsoft.CodeAnalysis.DiagnosticBag?
                diagnosticsOpt, Microsoft.CodeAnalysis.Location
                locationOpt)
                {
                    var return_v = this_param.CheckIfAttributeShouldBeEmbedded(attribute, diagnosticsOpt: diagnosticsOpt, locationOpt: locationOpt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 73177, 73273);
                    return return_v;
                }


                int
                f_10203_73307_73345(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.EmbeddableAttributes
                attributes)
                {
                    this_param.SetNeedsGeneratedAttributes(attributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 73307, 73345);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 72793, 73372);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 72793, 73372);
            }
        }

        internal void EnsureIsReadOnlyAttributeExists()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 73384, 73541);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 73456, 73530);

                f_10203_73456_73529(this, EmbeddableAttributes.IsReadOnlyAttribute);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 73384, 73541);

                int
                f_10203_73456_73529(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.EmbeddableAttributes
                attribute)
                {
                    this_param.EnsureEmbeddableAttributeExists(attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 73456, 73529);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 73384, 73541);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 73384, 73541);
            }
        }

        internal void EnsureIsUnmanagedAttributeExists()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 73553, 73712);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 73626, 73701);

                f_10203_73626_73700(this, EmbeddableAttributes.IsUnmanagedAttribute);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 73553, 73712);

                int
                f_10203_73626_73700(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.EmbeddableAttributes
                attribute)
                {
                    this_param.EnsureEmbeddableAttributeExists(attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 73626, 73700);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 73553, 73712);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 73553, 73712);
            }
        }

        internal void EnsureNullableAttributeExists()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 73724, 73877);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 73794, 73866);

                f_10203_73794_73865(this, EmbeddableAttributes.NullableAttribute);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 73724, 73877);

                int
                f_10203_73794_73865(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.EmbeddableAttributes
                attribute)
                {
                    this_param.EnsureEmbeddableAttributeExists(attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 73794, 73865);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 73724, 73877);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 73724, 73877);
            }
        }

        internal void EnsureNativeIntegerAttributeExists()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 73889, 74052);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 73964, 74041);

                f_10203_73964_74040(this, EmbeddableAttributes.NativeIntegerAttribute);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 73889, 74052);

                int
                f_10203_73964_74040(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.EmbeddableAttributes
                attribute)
                {
                    this_param.EnsureEmbeddableAttributeExists(attribute);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 73964, 74040);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 73889, 74052);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 73889, 74052);
            }
        }

        public override IEnumerable<Cci.INamespaceTypeDefinition> GetAdditionalTopLevelTypeDefinitions(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 74064, 74368);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 74204, 74357);

                return f_10203_74211_74258(this, context.Diagnostics)

                   .Select(type => type.GetCciAdapter());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 74064, 74368);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10203_74211_74258(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetAdditionalTopLevelTypes(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 74211, 74258);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 74064, 74368);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 74064, 74368);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override IEnumerable<Cci.INamespaceTypeDefinition> GetEmbeddedTypeDefinitions(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10203, 74380, 74664);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10203, 74510, 74653);

                return f_10203_74517_74554(this, context.Diagnostics)

                   .Select(type => type.GetCciAdapter());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10203, 74380, 74664);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10203_74517_74554(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetEmbeddedTypes(diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 74517, 74554);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10203, 74380, 74664);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 74380, 74664);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PEModuleBuilder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10203, 743, 74671);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10203, 743, 74671);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10203, 743, 74671);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10203, 743, 74671);

        System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.Cci.IModuleReference>
        f_10203_1196_1252()
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.Cci.IModuleReference>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 1196, 1252);
            return return_v;
        }


        System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, object>
        f_10203_1339_1430(System.Collections.Generic.EqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>
        comparer)
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, object>((System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbol>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 1339, 1430);
            return return_v;
        }


        Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
        f_10203_1509_1540()
        {
            var return_v = new Roslyn.Utilities.ConcurrentSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 1509, 1540);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
        f_10203_3709_3746(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
        this_param)
        {
            var return_v = this_param.ContainingSourceAssembly;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 3709, 3746);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10203_3709_3767(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
        this_param)
        {
            var return_v = this_param.DeclaringCompilation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 3709, 3767);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.ModuleCompilationState
        f_10203_3972_4000()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.ModuleCompilationState();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 3972, 4000);
            return return_v;
        }


        string
        f_10203_4046_4071(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
        this_param)
        {
            var return_v = this_param.MetadataName;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 4046, 4071);
            return return_v;
        }


        string?
        f_10203_4262_4292(Microsoft.CodeAnalysis.Emit.EmitOptions
        this_param)
        {
            var return_v = this_param.OutputNameOverride;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 4262, 4292);
            return return_v;
        }


        int
        f_10203_4326_4386(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.Cci.IModuleReference>
        dict, Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
        key, Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
        value)
        {
            dict.Add<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.Cci.IModuleReference>((Microsoft.CodeAnalysis.CSharp.Symbol)key, (Microsoft.Cci.IModuleReference)value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 4326, 4386);
            return 0;
        }


        bool
        f_10203_4407_4452(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
        this_param)
        {
            var return_v = this_param.AnyReferencedAssembliesAreLinked;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10203, 4407, 4452);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager
        f_10203_4513_4549(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
        moduleBeingBuilt)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Emit.NoPia.EmbeddedTypesManager(moduleBeingBuilt);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 4513, 4549);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        f_10203_3709_3767_C(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10203, 3403, 4576);
            return return_v;
        }


        System.Collections.Generic.IEnumerable<string>
        f_10203_6121_6169()
        {
            var return_v = SpecializedCollections.EmptyEnumerable<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10203, 6121, 6169);
            return return_v;
        }

    }
}
