// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Globalization;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using System.Threading;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting
{
    internal sealed partial class RetargetingModuleSymbol : NonMissingModuleSymbol
    {
        private readonly RetargetingAssemblySymbol _retargetingAssembly;

        private readonly SourceModuleSymbol _underlyingModule;

        private readonly Dictionary<AssemblySymbol, DestinationData> _retargetingAssemblyMap;

        private struct DestinationData
        {

            public AssemblySymbol To;

            private ConcurrentDictionary<NamedTypeSymbol, NamedTypeSymbol> _symbolMap;

            public ConcurrentDictionary<NamedTypeSymbol, NamedTypeSymbol> SymbolMap
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10598, 2698, 2750);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 2701, 2750);
                        return f_10598_2701_2750(ref _symbolMap); DynAbs.Tracing.TraceSender.TraceExitMethod(10598, 2698, 2750);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10598, 2698, 2750);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10598, 2698, 2750);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }
            static DestinationData()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10598, 2442, 2762);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10598, 2442, 2762);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10598, 2442, 2762);
            }

            System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
            f_10598_2701_2750(ref System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
            target)
            {
                var return_v = LazyInitializer.EnsureInitialized(ref target);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10598, 2701, 2750);
                return return_v;
            }

        }

        internal readonly RetargetingSymbolTranslator RetargetingTranslator;

        private ImmutableArray<CSharpAttributeData> _lazyCustomAttributes;

        public RetargetingModuleSymbol(RetargetingAssemblySymbol retargetingAssembly, SourceModuleSymbol underlyingModule)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10598, 3346, 4281);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 1621, 1641);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 1850, 1867);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 2341, 2429);
                this._retargetingAssemblyMap = f_10598_2380_2429(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 2820, 2841);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 1022, 1122);
                // LAFHIS
                this._symbolMap = new ConcurrentDictionary<Symbol, Symbol>(concurrencyLevel: 2, capacity: 4);
                //f_10603_1048_1122(concurrencyLevel: 2, capacity: 4); 
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 1048, 1122);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 1190, 1214);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 1283, 1310);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 1383, 1414);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 1483, 1510);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 1575, 1598);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 1666, 1692);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 1757, 1780);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 3485, 3535);

                f_10598_3485_3534((object)retargetingAssembly != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 3549, 3596);

                f_10598_3549_3595((object)underlyingModule != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 3612, 3655);

                _retargetingAssembly = retargetingAssembly;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 3669, 3706);

                _underlyingModule = underlyingModule;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 3720, 3787);

                this.RetargetingTranslator = f_10598_3749_3786(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 3803, 3854);

                _createRetargetingMethod = CreateRetargetingMethod;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 3868, 3925);

                _createRetargetingNamespace = CreateRetargetingNamespace;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 3939, 3996);

                _createRetargetingNamedType = CreateRetargetingNamedType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 4010, 4059);

                _createRetargetingField = CreateRetargetingField;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 4073, 4128);

                _createRetargetingProperty = CreateRetargetingProperty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 4142, 4191);

                _createRetargetingEvent = CreateRetargetingEvent;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 4205, 4270);

                _createRetargetingTypeParameter = CreateRetargetingTypeParameter;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10598, 3346, 4281);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10598, 3346, 4281);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10598, 3346, 4281);
            }
        }

        internal override int Ordinal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10598, 4347, 4496);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 4383, 4428);

                    f_10598_4383_4427(f_10598_4396_4421(_underlyingModule) == 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 4472, 4481);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10598, 4347, 4496);

                    int
                    f_10598_4396_4421(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Ordinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10598, 4396, 4421);
                        return return_v;
                    }


                    int
                    f_10598_4383_4427(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10598, 4383, 4427);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10598, 4293, 4507);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10598, 4293, 4507);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override Machine Machine
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10598, 4577, 4661);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 4613, 4646);

                    return f_10598_4620_4645(_underlyingModule);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10598, 4577, 4661);

                    System.Reflection.PortableExecutable.Machine
                    f_10598_4620_4645(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Machine;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10598, 4620, 4645);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10598, 4519, 4672);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10598, 4519, 4672);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool Bit32Required
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10598, 4745, 4835);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 4781, 4820);

                    return f_10598_4788_4819(_underlyingModule);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10598, 4745, 4835);

                    bool
                    f_10598_4788_4819(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Bit32Required;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10598, 4788, 4819);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10598, 4684, 4846);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10598, 4684, 4846);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public SourceModuleSymbol UnderlyingModule
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10598, 5057, 5133);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 5093, 5118);

                    return _underlyingModule;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10598, 5057, 5133);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10598, 4990, 5144);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10598, 4990, 5144);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override NamespaceSymbol GlobalNamespace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10598, 5228, 5352);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 5264, 5337);

                    return f_10598_5271_5336(RetargetingTranslator, f_10598_5302_5335(_underlyingModule));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10598, 5228, 5352);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    f_10598_5302_5335(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.GlobalNamespace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10598, 5302, 5335);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    f_10598_5271_5336(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    ns)
                    {
                        var return_v = this_param.Retarget(ns);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10598, 5271, 5336);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10598, 5156, 5363);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10598, 5156, 5363);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsImplicitlyDeclared
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10598, 5441, 5495);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 5447, 5493);

                    return f_10598_5454_5492(_underlyingModule);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10598, 5441, 5495);

                    bool
                    f_10598_5454_5492(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.IsImplicitlyDeclared;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10598, 5454, 5492);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10598, 5375, 5506);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10598, 5375, 5506);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10598, 5570, 5651);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 5606, 5636);

                    return f_10598_5613_5635(_underlyingModule);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10598, 5570, 5651);

                    string
                    f_10598_5613_5635(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10598, 5613, 5635);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10598, 5518, 5662);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10598, 5518, 5662);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string GetDocumentationCommentXml(CultureInfo preferredCulture = null, bool expandIncludes = false, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10598, 5674, 5996);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 5880, 5985);

                return f_10598_5887_5984(_underlyingModule, preferredCulture, expandIncludes, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10598, 5674, 5996);

                string
                f_10598_5887_5984(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                this_param, System.Globalization.CultureInfo?
                preferredCulture, bool
                expandIncludes, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDocumentationCommentXml(preferredCulture, expandIncludes, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10598, 5887, 5984);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10598, 5674, 5996);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10598, 5674, 5996);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10598, 6072, 6151);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 6108, 6136);

                    return _retargetingAssembly;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10598, 6072, 6151);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10598, 6008, 6162);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10598, 6008, 6162);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10598, 6248, 6327);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 6284, 6312);

                    return _retargetingAssembly;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10598, 6248, 6327);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10598, 6174, 6338);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10598, 6174, 6338);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<Location> Locations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10598, 6425, 6511);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 6461, 6496);

                    return f_10598_6468_6495(_underlyingModule);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10598, 6425, 6511);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10598_6468_6495(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Locations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10598, 6468, 6495);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10598, 6350, 6522);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10598, 6350, 6522);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override void SetReferences(ModuleReferences<AssemblySymbol> moduleReferences, SourceAssemblySymbol originatingSourceAssemblyDebugOnly)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10598, 6710, 9556);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 6879, 6952);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.SetReferences(moduleReferences, originatingSourceAssemblyDebugOnly), 10598, 6879, 6951);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 7010, 7042);

                f_10598_7010_7041(
                            // Build the retargeting map
                            _retargetingAssemblyMap);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 7058, 7166);

                ImmutableArray<AssemblySymbol>
                underlyingBoundReferences = f_10598_7117_7165(_underlyingModule)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 7180, 7264);

                ImmutableArray<AssemblySymbol>
                referencedAssemblySymbols = moduleReferences.Symbols
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 7280, 7365);

                f_10598_7280_7364(referencedAssemblySymbols.Length == moduleReferences.Identities.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 7379, 7462);

                f_10598_7379_7461(referencedAssemblySymbols.Length <= underlyingBoundReferences.Length);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 7517, 7526);

                int
                i
                = default(int),
                j
                = default(int);
                try
                {
                    for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 7545, 7550)
   , i = 0, DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 7552, 7557)
   , j = 0; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 7540, 9305) || true) && (i < referencedAssemblySymbols.Length)
   ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 7597, 7600)
   , i++, DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 7602, 7605)
   , j++, DynAbs.Tracing.TraceSender.TraceExitCondition(10598, 7540, 9305))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10598, 7540, 9305);
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 7700, 7809) || true) && (f_10598_7707_7744(underlyingBoundReferences[j]))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10598, 7700, 7809);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 7786, 7790);

                                j++;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10598, 7700, 7809);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10598, 7700, 7809);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10598, 7700, 7809);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 7840, 7935);

                        var
                        identityComparer = f_10598_7863_7934(f_10598_7863_7909(f_10598_7863_7901(_underlyingModule)))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 7953, 8220);

                        var
                        definitionIdentity = (DynAbs.Tracing.TraceSender.Conditional_F1(10598, 7978, 8059) || ((f_10598_7978_8059(referencedAssemblySymbols[i], originatingSourceAssemblyDebugOnly) && DynAbs.Tracing.TraceSender.Conditional_F2(10598, 8087, 8154)) || DynAbs.Tracing.TraceSender.Conditional_F3(10598, 8182, 8219))) ? f_10598_8087_8154(name: f_10598_8114_8153(originatingSourceAssemblyDebugOnly)) : f_10598_8182_8219(referencedAssemblySymbols[i])
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 8240, 8390);

                        f_10598_8240_8389(f_10598_8253_8329(identityComparer, moduleReferences.Identities[i], definitionIdentity) != AssemblyIdentityComparer.ComparisonResult.NotEquivalent);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 8408, 8577);

                        f_10598_8408_8576(f_10598_8421_8516(identityComparer, moduleReferences.Identities[i], f_10598_8478_8515(underlyingBoundReferences[j])) != AssemblyIdentityComparer.ComparisonResult.NotEquivalent);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 8605, 9290) || true) && (!f_10598_8610_8685(referencedAssemblySymbols[i], underlyingBoundReferences[j]))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10598, 8605, 9290);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 8727, 8759);

                            DestinationData
                            destinationData
                            = default(DestinationData);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 8783, 9271) || true) && (!f_10598_8788_8874(_retargetingAssemblyMap, underlyingBoundReferences[j], out destinationData))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10598, 8783, 9271);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 8924, 9070);

                                f_10598_8924_9069(_retargetingAssemblyMap, underlyingBoundReferences[j], new DestinationData { To = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => referencedAssemblySymbols[i], 10598, 9011, 9068) });
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10598, 8783, 9271);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10598, 8783, 9271);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 9168, 9248);

                                f_10598_9168_9247(f_10598_9181_9246(destinationData.To, referencedAssemblySymbols[i]));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10598, 8783, 9271);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10598, 8605, 9290);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10598, 1, 1766);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10598, 1, 1766);
                }
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 9332, 9469) || true) && (j < underlyingBoundReferences.Length && (DynAbs.Tracing.TraceSender.Expression_True(10598, 9339, 9416) && f_10598_9379_9416(underlyingBoundReferences[j])))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10598, 9332, 9469);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 9450, 9454);

                        j++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10598, 9332, 9469);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10598, 9332, 9469);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10598, 9332, 9469);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 9485, 9537);

                f_10598_9485_9536(j == underlyingBoundReferences.Length);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10598, 6710, 9556);

                int
                f_10598_7010_7041(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.DestinationData>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10598, 7010, 7041);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                f_10598_7117_7165(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                this_param)
                {
                    var return_v = this_param.GetReferencedAssemblySymbols();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10598, 7117, 7165);
                    return return_v;
                }


                int
                f_10598_7280_7364(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10598, 7280, 7364);
                    return 0;
                }


                int
                f_10598_7379_7461(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10598, 7379, 7461);
                    return 0;
                }


                bool
                f_10598_7707_7744(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.IsLinked;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10598, 7707, 7744);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10598_7863_7901(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10598, 7863, 7901);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10598_7863_7909(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10598, 7863, 7909);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentityComparer
                f_10598_7863_7934(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.AssemblyIdentityComparer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10598, 7863, 7934);
                    return return_v;
                }


                bool
                f_10598_7978_8059(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10598, 7978, 8059);
                    return return_v;
                }


                string
                f_10598_8114_8153(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10598, 8114, 8153);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_10598_8087_8154(string
                name)
                {
                    var return_v = new Microsoft.CodeAnalysis.AssemblyIdentity(name: name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10598, 8087, 8154);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_10598_8182_8219(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10598, 8182, 8219);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentityComparer.ComparisonResult
                f_10598_8253_8329(Microsoft.CodeAnalysis.AssemblyIdentityComparer
                this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                reference, Microsoft.CodeAnalysis.AssemblyIdentity
                definition)
                {
                    var return_v = this_param.Compare(reference, definition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10598, 8253, 8329);
                    return return_v;
                }


                int
                f_10598_8240_8389(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10598, 8240, 8389);
                    return 0;
                }


                Microsoft.CodeAnalysis.AssemblyIdentity
                f_10598_8478_8515(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.Identity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10598, 8478, 8515);
                    return return_v;
                }


                Microsoft.CodeAnalysis.AssemblyIdentityComparer.ComparisonResult
                f_10598_8421_8516(Microsoft.CodeAnalysis.AssemblyIdentityComparer
                this_param, Microsoft.CodeAnalysis.AssemblyIdentity
                reference, Microsoft.CodeAnalysis.AssemblyIdentity
                definition)
                {
                    var return_v = this_param.Compare(reference, definition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10598, 8421, 8516);
                    return return_v;
                }


                int
                f_10598_8408_8576(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10598, 8408, 8576);
                    return 0;
                }


                bool
                f_10598_8610_8685(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10598, 8610, 8685);
                    return return_v;
                }


                bool
                f_10598_8788_8874(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.DestinationData>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                key, out Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.DestinationData
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10598, 8788, 8874);
                    return return_v;
                }


                int
                f_10598_8924_9069(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.DestinationData>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                key, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.DestinationData
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10598, 8924, 9069);
                    return 0;
                }


                bool
                f_10598_9181_9246(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10598, 9181, 9246);
                    return return_v;
                }


                int
                f_10598_9168_9247(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10598, 9168, 9247);
                    return 0;
                }


                bool
                f_10598_9379_9416(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.IsLinked;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10598, 9379, 9416);
                    return return_v;
                }


                int
                f_10598_9485_9536(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10598, 9485, 9536);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10598, 6710, 9556);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10598, 6710, 9556);
            }
        }

        internal override ICollection<string> TypeNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10598, 9640, 9726);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 9676, 9711);

                    return f_10598_9683_9710(_underlyingModule);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10598, 9640, 9726);

                    System.Collections.Generic.ICollection<string>
                    f_10598_9683_9710(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeNames;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10598, 9683, 9710);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10598, 9568, 9737);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10598, 9568, 9737);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ICollection<string> NamespaceNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10598, 9826, 9917);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 9862, 9902);

                    return f_10598_9869_9901(_underlyingModule);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10598, 9826, 9917);

                    System.Collections.Generic.ICollection<string>
                    f_10598_9869_9901(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.NamespaceNames;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10598, 9869, 9901);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10598, 9749, 9928);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10598, 9749, 9928);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10598, 9940, 10158);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 10032, 10147);

                return f_10598_10039_10146(RetargetingTranslator, f_10598_10085_10118(_underlyingModule), ref _lazyCustomAttributes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10598, 9940, 10158);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10598_10085_10118(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10598, 10085, 10118);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10598_10039_10146(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                underlyingAttributes, ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                lazyCustomAttributes)
                {
                    var return_v = this_param.GetRetargetedAttributes(underlyingAttributes, ref lazyCustomAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10598, 10039, 10146);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10598, 9940, 10158);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10598, 9940, 10158);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool HasAssemblyCompilationRelaxationsAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10598, 10260, 10379);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 10296, 10364);

                    return f_10598_10303_10363(_underlyingModule);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10598, 10260, 10379);

                    bool
                    f_10598_10303_10363(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.HasAssemblyCompilationRelaxationsAttribute;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10598, 10303, 10363);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10598, 10170, 10390);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10598, 10170, 10390);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasAssemblyRuntimeCompatibilityAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10598, 10490, 10607);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 10526, 10592);

                    return f_10598_10533_10591(_underlyingModule);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10598, 10490, 10607);

                    bool
                    f_10598_10533_10591(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.HasAssemblyRuntimeCompatibilityAttribute;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10598, 10533, 10591);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10598, 10402, 10618);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10598, 10402, 10618);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override CharSet? DefaultMarshallingCharSet
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10598, 10707, 10809);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 10743, 10794);

                    return f_10598_10750_10793(_underlyingModule);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10598, 10707, 10809);

                    System.Runtime.InteropServices.CharSet?
                    f_10598_10750_10793(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.DefaultMarshallingCharSet;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10598, 10750, 10793);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10598, 10630, 10820);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10598, 10630, 10820);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override CSharpCompilation DeclaringCompilation // perf, not correctness
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10598, 10945, 10965);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 10951, 10963);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10598, 10945, 10965);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10598, 10832, 10976);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10598, 10832, 10976);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ModuleMetadata GetMetadata()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10598, 11033, 11067);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 11036, 11067);
                return f_10598_11036_11067(_underlyingModule); DynAbs.Tracing.TraceSender.TraceExitMethod(10598, 11033, 11067);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10598, 11033, 11067);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10598, 11033, 11067);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.ModuleMetadata
            f_10598_11036_11067(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
            this_param)
            {
                var return_v = this_param.GetMetadata();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10598, 11036, 11067);
                return return_v;
            }

        }

        public sealed override bool AreLocalsZeroed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10598, 11148, 11236);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10598, 11184, 11221);

                    throw f_10598_11190_11220();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10598, 11148, 11236);

                    System.Exception
                    f_10598_11190_11220()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10598, 11190, 11220);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10598, 11080, 11247);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10598, 11080, 11247);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static RetargetingModuleSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10598, 1375, 11254);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10598, 1375, 11254);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10598, 1375, 11254);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10598, 1375, 11254);

        System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.DestinationData>
        f_10598_2380_2429()
        {
            var return_v = new System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.DestinationData>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10598, 2380, 2429);
            return return_v;
        }


        int
        f_10598_3485_3534(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10598, 3485, 3534);
            return 0;
        }


        int
        f_10598_3549_3595(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10598, 3549, 3595);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
        f_10598_3749_3786(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol
        retargetingModule)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator(retargetingModule);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10598, 3749, 3786);
            return return_v;
        }

    }
}
