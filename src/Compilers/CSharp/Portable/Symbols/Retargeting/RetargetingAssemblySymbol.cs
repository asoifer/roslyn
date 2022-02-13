// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;
using System.Diagnostics;
using System.Globalization;
using System.Threading;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting
{
    internal sealed class RetargetingAssemblySymbol : NonMissingAssemblySymbol
    {
        private readonly SourceAssemblySymbol _underlyingAssembly;

        private readonly ImmutableArray<ModuleSymbol> _modules;

        private ImmutableArray<AssemblySymbol> _noPiaResolutionAssemblies;

        private ImmutableArray<AssemblySymbol> _linkedReferencedAssemblies;

        private ConcurrentDictionary<NamedTypeSymbol, NamedTypeSymbol> _noPiaUnificationMap;

        internal ConcurrentDictionary<NamedTypeSymbol, NamedTypeSymbol> NoPiaUnificationMap
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10594, 4113, 4288);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 4129, 4288);
                    return f_10594_4129_4288(ref _noPiaUnificationMap, () => new ConcurrentDictionary<NamedTypeSymbol, NamedTypeSymbol>(concurrencyLevel: 2, capacity: 0)); DynAbs.Tracing.TraceSender.TraceExitMethod(10594, 4113, 4288);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10594, 4113, 4288);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10594, 4113, 4288);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private readonly bool _isLinked;

        private ImmutableArray<CSharpAttributeData> _lazyCustomAttributes;

        public RetargetingAssemblySymbol(SourceAssemblySymbol underlyingAssembly, bool isLinked)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10594, 5014, 5827);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 2310, 2329);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 3873, 3893);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 4449, 4458);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 5127, 5176);

                f_10594_5127_5175((object)underlyingAssembly != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 5192, 5233);

                _underlyingAssembly = underlyingAssembly;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 5249, 5326);

                ModuleSymbol[]
                modules = new ModuleSymbol[underlyingAssembly.Modules.Length]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 5342, 5440);

                modules[0] = f_10594_5355_5439(this, (SourceModuleSymbol)f_10594_5409_5435(underlyingAssembly)[0]);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 5465, 5470);

                    for (int
        i = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 5456, 5726) || true) && (i < underlyingAssembly.Modules.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 5511, 5514)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10594, 5456, 5726))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10594, 5456, 5726);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 5548, 5617);

                        PEModuleSymbol
                        under = (PEModuleSymbol)f_10594_5587_5613(underlyingAssembly)[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 5635, 5711);

                        modules[i] = f_10594_5648_5710(this, f_10594_5673_5685(under), under.ImportOptions, i);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10594, 1, 271);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10594, 1, 271);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 5742, 5781);

                _modules = f_10594_5753_5780(modules);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 5795, 5816);

                _isLinked = isLinked;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10594, 5014, 5827);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10594, 5014, 5827);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10594, 5014, 5827);
            }
        }

        private RetargetingModuleSymbol.RetargetingSymbolTranslator RetargetingTranslator
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10594, 5945, 6064);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 5981, 6049);

                    return ((RetargetingModuleSymbol)_modules[0]).RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10594, 5945, 6064);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10594, 5839, 6075);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10594, 5839, 6075);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public AssemblySymbol UnderlyingAssembly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10594, 6313, 6391);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 6349, 6376);

                    return _underlyingAssembly;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10594, 6313, 6391);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10594, 6248, 6402);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10594, 6248, 6402);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10594, 6480, 6536);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 6486, 6534);

                    return f_10594_6493_6533(_underlyingAssembly);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10594, 6480, 6536);

                    bool
                    f_10594_6493_6533(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.IsImplicitlyDeclared;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10594, 6493, 6533);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10594, 6414, 6547);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10594, 6414, 6547);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override AssemblyIdentity Identity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10594, 6625, 6712);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 6661, 6697);

                    return f_10594_6668_6696(_underlyingAssembly);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10594, 6625, 6712);

                    Microsoft.CodeAnalysis.AssemblyIdentity
                    f_10594_6668_6696(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.Identity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10594, 6668, 6696);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10594, 6559, 6723);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10594, 6559, 6723);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Version AssemblyVersionPattern
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10594, 6782, 6827);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 6785, 6827);
                    return f_10594_6785_6827(_underlyingAssembly); DynAbs.Tracing.TraceSender.TraceExitMethod(10594, 6782, 6827);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10594, 6782, 6827);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10594, 6782, 6827);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ImmutableArray<byte> PublicKey
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10594, 6913, 6958);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 6919, 6956);

                    return f_10594_6926_6955(_underlyingAssembly);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10594, 6913, 6958);

                    System.Collections.Immutable.ImmutableArray<byte>
                    f_10594_6926_6955(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.PublicKey;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10594, 6926, 6955);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10594, 6840, 6969);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10594, 6840, 6969);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string GetDocumentationCommentXml(CultureInfo preferredCulture = null, bool expandIncludes = false, CancellationToken cancellationToken = default(CancellationToken))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10594, 6981, 7305);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 7187, 7294);

                return f_10594_7194_7293(_underlyingAssembly, preferredCulture, expandIncludes, cancellationToken);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10594, 6981, 7305);

                string
                f_10594_7194_7293(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, System.Globalization.CultureInfo?
                preferredCulture, bool
                expandIncludes, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = this_param.GetDocumentationCommentXml(preferredCulture, expandIncludes, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10594, 7194, 7293);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10594, 6981, 7305);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10594, 6981, 7305);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<ModuleSymbol> Modules
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10594, 7394, 7461);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 7430, 7446);

                    return _modules;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10594, 7394, 7461);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10594, 7317, 7472);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10594, 7317, 7472);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool KeepLookingForDeclaredSpecialTypes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10594, 7566, 7708);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 7680, 7693);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10594, 7566, 7708);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10594, 7484, 7719);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10594, 7484, 7719);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10594, 7806, 7894);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 7842, 7879);

                    return f_10594_7849_7878(_underlyingAssembly);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10594, 7806, 7894);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10594_7849_7878(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.Locations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10594, 7849, 7878);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10594, 7731, 7905);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10594, 7731, 7905);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override IEnumerable<ImmutableArray<byte>> GetInternalsVisibleToPublicKeys(string simpleName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10594, 7917, 8126);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 8044, 8115);

                return f_10594_8051_8114(_underlyingAssembly, simpleName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10594, 7917, 8126);

                System.Collections.Generic.IEnumerable<System.Collections.Immutable.ImmutableArray<byte>>
                f_10594_8051_8114(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, string
                simpleName)
                {
                    var return_v = this_param.GetInternalsVisibleToPublicKeys(simpleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10594, 8051, 8114);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10594, 7917, 8126);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10594, 7917, 8126);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool AreInternalsVisibleToThisAssembly(AssemblySymbol other)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10594, 8138, 8320);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 8241, 8309);

                return f_10594_8248_8308(_underlyingAssembly, other);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10594, 8138, 8320);

                bool
                f_10594_8248_8308(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                potentialGiverOfAccess)
                {
                    var return_v = this_param.AreInternalsVisibleToThisAssembly(potentialGiverOfAccess);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10594, 8248, 8308);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10594, 8138, 8320);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10594, 8138, 8320);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<CSharpAttributeData> GetAttributes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10594, 8332, 8552);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 8424, 8541);

                return f_10594_8431_8540(f_10594_8431_8452(), f_10594_8477_8512(_underlyingAssembly), ref _lazyCustomAttributes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10594, 8332, 8552);

                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10594_8431_8452()
                {
                    var return_v = RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10594, 8431, 8452);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10594_8477_8512(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.GetAttributes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10594, 8477, 8512);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                f_10594_8431_8540(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                underlyingAttributes, ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                lazyCustomAttributes)
                {
                    var return_v = this_param.GetRetargetedAttributes(underlyingAttributes, ref lazyCustomAttributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10594, 8431, 8540);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10594, 8332, 8552);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10594, 8332, 8552);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override NamedTypeSymbol GetDeclaredSpecialType(SpecialType type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10594, 8780, 9074);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 9026, 9063);

                throw f_10594_9032_9062();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10594, 8780, 9074);

                System.Exception
                f_10594_9032_9062()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10594, 9032, 9062);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10594, 8780, 9074);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10594, 8780, 9074);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<AssemblySymbol> GetNoPiaResolutionAssemblies()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10594, 9086, 9235);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 9190, 9224);

                return _noPiaResolutionAssemblies;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10594, 9086, 9235);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10594, 9086, 9235);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10594, 9086, 9235);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void SetNoPiaResolutionAssemblies(ImmutableArray<AssemblySymbol> assemblies)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10594, 9247, 9417);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 9366, 9406);

                _noPiaResolutionAssemblies = assemblies;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10594, 9247, 9417);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10594, 9247, 9417);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10594, 9247, 9417);
            }
        }

        internal override void SetLinkedReferencedAssemblies(ImmutableArray<AssemblySymbol> assemblies)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10594, 9429, 9601);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 9549, 9590);

                _linkedReferencedAssemblies = assemblies;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10594, 9429, 9601);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10594, 9429, 9601);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10594, 9429, 9601);
            }
        }

        internal override ImmutableArray<AssemblySymbol> GetLinkedReferencedAssemblies()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10594, 9613, 9764);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 9718, 9753);

                return _linkedReferencedAssemblies;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10594, 9613, 9764);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10594, 9613, 9764);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10594, 9613, 9764);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsLinked
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10594, 9832, 9900);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 9868, 9885);

                    return _isLinked;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10594, 9832, 9900);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10594, 9776, 9911);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10594, 9776, 9911);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ICollection<string> TypeNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10594, 9993, 10081);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 10029, 10066);

                    return f_10594_10036_10065(_underlyingAssembly);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10594, 9993, 10081);

                    System.Collections.Generic.ICollection<string>
                    f_10594_10036_10065(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.TypeNames;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10594, 10036, 10065);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10594, 9923, 10092);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10594, 9923, 10092);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ICollection<string> NamespaceNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10594, 10179, 10272);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 10215, 10257);

                    return f_10594_10222_10256(_underlyingAssembly);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10594, 10179, 10272);

                    System.Collections.Generic.ICollection<string>
                    f_10594_10222_10256(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.NamespaceNames;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10594, 10222, 10256);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10594, 10104, 10283);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10594, 10104, 10283);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool MightContainExtensionMethods
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10594, 10369, 10476);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 10405, 10461);

                    return f_10594_10412_10460(_underlyingAssembly);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10594, 10369, 10476);

                    bool
                    f_10594_10412_10460(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.MightContainExtensionMethods;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10594, 10412, 10460);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10594, 10295, 10487);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10594, 10295, 10487);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10594, 10612, 10632);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 10618, 10630);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10594, 10612, 10632);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10594, 10499, 10643);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10594, 10499, 10643);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool GetGuidString(out string guidString)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10594, 10655, 10807);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 10739, 10796);

                return f_10594_10746_10795(_underlyingAssembly, out guidString);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10594, 10655, 10807);

                bool
                f_10594_10746_10795(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, out string
                guidString)
                {
                    var return_v = this_param.GetGuidString(out guidString);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10594, 10746, 10795);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10594, 10655, 10807);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10594, 10655, 10807);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override NamedTypeSymbol TryLookupForwardedMetadataTypeWithCycleDetection(ref MetadataTypeName emittedName, ConsList<AssemblySymbol> visitedAssemblies)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10594, 10819, 11336);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 11004, 11101);

                NamedTypeSymbol
                underlying = f_10594_11033_11100(_underlyingAssembly, ref emittedName)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 11117, 11208) || true) && ((object)underlying == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10594, 11117, 11208);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 11181, 11193);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10594, 11117, 11208);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 11224, 11325);

                return f_10594_11231_11324(f_10594_11231_11257(this), underlying, RetargetOptions.RetargetPrimitiveTypesByName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10594, 10819, 11336);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10594_11033_11100(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                emittedName)
                {
                    var return_v = this_param.TryLookupForwardedMetadataType(ref emittedName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10594, 11033, 11100);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10594_11231_11257(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingAssemblySymbol
                this_param)
                {
                    var return_v = this_param.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10594, 11231, 11257);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10594_11231_11324(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions
                options)
                {
                    var return_v = this_param.Retarget(type, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10594, 11231, 11324);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10594, 10819, 11336);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10594, 10819, 11336);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override IEnumerable<NamedTypeSymbol> GetAllTopLevelForwardedTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10594, 11348, 11706);

                var listYield = new List<NamedTypeSymbol>();
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 11450, 11695);
                    foreach (NamedTypeSymbol underlying in f_10594_11489_11539_I(f_10594_11489_11539(_underlyingAssembly)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10594, 11450, 11695);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 11573, 11680);

                        listYield.Add(f_10594_11586_11679(f_10594_11586_11612(this), underlying, RetargetOptions.RetargetPrimitiveTypesByName));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10594, 11450, 11695);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10594, 1, 246);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10594, 1, 246);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10594, 11348, 11706);

                return listYield;

                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10594_11489_11539(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
                this_param)
                {
                    var return_v = this_param.GetAllTopLevelForwardedTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10594, 11489, 11539);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                f_10594_11586_11612(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingAssemblySymbol
                this_param)
                {
                    var return_v = this_param.RetargetingTranslator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10594, 11586, 11612);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10594_11586_11679(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions
                options)
                {
                    var return_v = this_param.Retarget(type, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10594, 11586, 11679);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                f_10594_11489_11539_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10594, 11489, 11539);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10594, 11348, 11706);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10594, 11348, 11706);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AssemblyMetadata GetMetadata()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10594, 11765, 11801);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10594, 11768, 11801);
                return f_10594_11768_11801(_underlyingAssembly); DynAbs.Tracing.TraceSender.TraceExitMethod(10594, 11765, 11801);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10594, 11765, 11801);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10594, 11765, 11801);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.AssemblyMetadata
            f_10594_11768_11801(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
            this_param)
            {
                var return_v = this_param.GetMetadata();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10594, 11768, 11801);
                return return_v;
            }

        }

        static RetargetingAssemblySymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10594, 1976, 11809);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10594, 1976, 11809);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10594, 1976, 11809);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10594, 1976, 11809);

        System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
        f_10594_4129_4288(ref System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
        target, System.Func<System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>>
        valueFactory)
        {
            var return_v = LazyInitializer.EnsureInitialized(ref target, valueFactory);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10594, 4129, 4288);
            return return_v;
        }


        int
        f_10594_5127_5175(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10594, 5127, 5175);
            return 0;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
        f_10594_5409_5435(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
        this_param)
        {
            var return_v = this_param.Modules;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10594, 5409, 5435);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol
        f_10594_5355_5439(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingAssemblySymbol
        retargetingAssembly, Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
        underlyingModule)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol(retargetingAssembly, (Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol)underlyingModule);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10594, 5355, 5439);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
        f_10594_5587_5613(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
        this_param)
        {
            var return_v = this_param.Modules;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10594, 5587, 5613);
            return return_v;
        }


        Microsoft.CodeAnalysis.PEModule
        f_10594_5673_5685(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        this_param)
        {
            var return_v = this_param.Module;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10594, 5673, 5685);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        f_10594_5648_5710(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingAssemblySymbol
        assemblySymbol, Microsoft.CodeAnalysis.PEModule
        module, Microsoft.CodeAnalysis.MetadataImportOptions
        importOptions, int
        ordinal)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol(assemblySymbol, module, importOptions, ordinal);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10594, 5648, 5710);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
        f_10594_5753_5780(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol[]
        items)
        {
            var return_v = items.AsImmutableOrNull<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10594, 5753, 5780);
            return return_v;
        }


        System.Version
        f_10594_6785_6827(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAssemblySymbol
        this_param)
        {
            var return_v = this_param.AssemblyVersionPattern;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10594, 6785, 6827);
            return return_v;
        }

    }
}
