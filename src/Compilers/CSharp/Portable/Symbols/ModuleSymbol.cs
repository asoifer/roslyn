// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Reflection;
using System.Reflection.PortableExecutable;
using System.Runtime.InteropServices;
using Microsoft.CodeAnalysis.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class ModuleSymbol : Symbol, IModuleSymbolInternal
    {
        public abstract NamespaceSymbol GlobalNamespace { get; }

        public override AssemblySymbol ContainingAssembly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10051, 1714, 1805);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10051, 1750, 1790);

                    return (AssemblySymbol)f_10051_1773_1789();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10051, 1714, 1805);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10051_1773_1789()
                    {
                        var return_v = ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10051, 1773, 1789);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10051, 1640, 1816);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10051, 1640, 1816);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override ModuleSymbol ContainingModule
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10051, 1907, 1970);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10051, 1943, 1955);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10051, 1907, 1970);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10051, 1828, 1981);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10051, 1828, 1981);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override SymbolKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10051, 2174, 2253);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10051, 2210, 2238);

                    return SymbolKind.NetModule;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10051, 2174, 2253);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10051, 2111, 2264);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10051, 2111, 2264);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override TResult Accept<TArgument, TResult>(CSharpSymbolVisitor<TArgument, TResult> visitor, TArgument argument)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10051, 2276, 2476);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10051, 2422, 2465);

                return f_10051_2429_2464<TResult, TArgument>(visitor, this, argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10051, 2276, 2476);

                TResult
                f_10051_2429_2464<TResult, TArgument>(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TArgument, TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                symbol, TArgument
                argument)
                {
                    var return_v = this_param.VisitModule(symbol, argument);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10051, 2429, 2464);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10051, 2276, 2476);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10051, 2276, 2476);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void Accept(CSharpSymbolVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10051, 2488, 2606);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10051, 2569, 2595);

                f_10051_2569_2594(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10051, 2488, 2606);

                int
                f_10051_2569_2594(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                symbol)
                {
                    this_param.VisitModule(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10051, 2569, 2594);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10051, 2488, 2606);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10051, 2488, 2606);
            }
        }

        public override TResult Accept<TResult>(CSharpSymbolVisitor<TResult> visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10051, 2618, 2764);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10051, 2720, 2753);

                return f_10051_2727_2752<TResult>(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10051, 2618, 2764);

                TResult
                f_10051_2727_2752<TResult>(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TResult>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                symbol)
                {
                    var return_v = this_param.VisitModule(symbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10051, 2727, 2752);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10051, 2618, 2764);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10051, 2618, 2764);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ModuleSymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10051, 2832, 2877);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10051, 2832, 2877);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10051, 2832, 2877);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10051, 2832, 2877);
            }
        }

        internal abstract int Ordinal { get; }

        internal abstract Machine Machine { get; }

        internal abstract bool Bit32Required { get; }

        internal abstract bool IsMissing
        {
            get;
        }

        public sealed override Accessibility DeclaredAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10051, 3997, 4083);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10051, 4033, 4068);

                    return Accessibility.NotApplicable;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10051, 3997, 4083);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10051, 3914, 4094);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10051, 3914, 4094);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsStatic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10051, 4287, 4351);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10051, 4323, 4336);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10051, 4287, 4351);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10051, 4226, 4362);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10051, 4226, 4362);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsVirtual
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10051, 4543, 4607);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10051, 4579, 4592);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10051, 4543, 4607);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10051, 4481, 4618);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10051, 4481, 4618);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsOverride
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10051, 4803, 4867);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10051, 4839, 4852);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10051, 4803, 4867);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10051, 4740, 4878);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10051, 4740, 4878);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsAbstract
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10051, 5061, 5125);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10051, 5097, 5110);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10051, 5061, 5125);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10051, 4998, 5136);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10051, 4998, 5136);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsSealed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10051, 5315, 5379);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10051, 5351, 5364);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10051, 5315, 5379);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10051, 5254, 5390);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10051, 5254, 5390);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool IsExtern
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10051, 5581, 5645);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10051, 5617, 5630);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10051, 5581, 5645);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10051, 5520, 5656);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10051, 5520, 5656);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override ObsoleteAttributeData ObsoleteAttributeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10051, 6029, 6049);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10051, 6035, 6047);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10051, 6029, 6049);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10051, 5936, 6060);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10051, 5936, 6060);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<SyntaxReference> DeclaringSyntaxReferences
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10051, 6170, 6266);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10051, 6206, 6251);

                    return ImmutableArray<SyntaxReference>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10051, 6170, 6266);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10051, 6072, 6277);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10051, 6072, 6277);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<AssemblyIdentity> ReferencedAssemblies
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10051, 6657, 6741);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10051, 6693, 6726);

                    return f_10051_6700_6725(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10051, 6657, 6741);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.AssemblyIdentity>
                    f_10051_6700_6725(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.GetReferencedAssemblies();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10051, 6700, 6725);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10051, 6572, 6752);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10051, 6572, 6752);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract ImmutableArray<AssemblyIdentity> GetReferencedAssemblies();

        public ImmutableArray<AssemblySymbol> ReferencedAssemblySymbols
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10051, 7768, 7857);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10051, 7804, 7842);

                    return f_10051_7811_7841(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10051, 7768, 7857);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    f_10051_7811_7841(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.GetReferencedAssemblySymbols();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10051, 7811, 7841);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10051, 7680, 7868);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10051, 7680, 7868);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract ImmutableArray<AssemblySymbol> GetReferencedAssemblySymbols();

        internal AssemblySymbol GetReferencedAssemblySymbol(int referencedAssemblyIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10051, 8641, 9414);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10051, 8746, 8804);

                var
                referencedAssemblies = f_10051_8773_8803(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10051, 8818, 8977) || true) && (referencedAssemblyIndex < referencedAssemblies.Length)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10051, 8818, 8977);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10051, 8909, 8962);

                    return referencedAssemblies[referencedAssemblyIndex];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10051, 8818, 8977);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10051, 9164, 9198);

                var
                assembly = f_10051_9179_9197()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10051, 9212, 9375) || true) && ((object)assembly != f_10051_9236_9255(assembly))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10051, 9212, 9375);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10051, 9289, 9360);

                    throw f_10051_9295_9359(nameof(referencedAssemblyIndex));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10051, 9212, 9375);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10051, 9391, 9403);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10051, 8641, 9414);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                f_10051_8773_8803(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.GetReferencedAssemblySymbols();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10051, 8773, 8803);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10051_9179_9197()
                {
                    var return_v = ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10051, 9179, 9197);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                f_10051_9236_9255(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                this_param)
                {
                    var return_v = this_param.CorLibrary;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10051, 9236, 9255);
                    return return_v;
                }


                System.ArgumentOutOfRangeException
                f_10051_9295_9359(string
                paramName)
                {
                    var return_v = new System.ArgumentOutOfRangeException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10051, 9295, 9359);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10051, 8641, 9414);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10051, 8641, 9414);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract void SetReferences(ModuleReferences<AssemblySymbol> moduleReferences, SourceAssemblySymbol originatingSourceAssemblyDebugOnly = null);

        internal abstract bool HasUnifiedReferences { get; }

        internal abstract bool GetUnificationUseSiteDiagnostic(ref DiagnosticInfo result, TypeSymbol dependentType);

        internal abstract NamedTypeSymbol LookupTopLevelMetadataType(ref MetadataTypeName emittedName);

        internal abstract ICollection<string> TypeNames { get; }

        internal abstract ICollection<string> NamespaceNames { get; }

        internal abstract bool HasAssemblyCompilationRelaxationsAttribute { get; }

        internal abstract bool HasAssemblyRuntimeCompatibilityAttribute { get; }

        internal abstract CharSet? DefaultMarshallingCharSet { get; }

        internal virtual ImmutableArray<byte> GetHash(AssemblyHashAlgorithm algorithmId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10051, 12587, 12740);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10051, 12692, 12729);

                throw f_10051_12698_12728();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10051, 12587, 12740);

                System.Exception
                f_10051_12698_12728()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10051, 12698, 12728);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10051, 12587, 12740);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10051, 12587, 12740);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public NamespaceSymbol GetModuleNamespace(INamespaceSymbol namespaceSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10051, 12897, 13965);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10051, 12997, 13130) || true) && (namespaceSymbol == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10051, 12997, 13130);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10051, 13058, 13115);

                    throw f_10051_13064_13114(nameof(namespaceSymbol));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10051, 12997, 13130);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10051, 13146, 13196);

                var
                moduleNs = namespaceSymbol as NamespaceSymbol
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10051, 13210, 13453) || true) && ((object)moduleNs != null && (DynAbs.Tracing.TraceSender.Expression_True(10051, 13214, 13286) && moduleNs.Extent.Kind == NamespaceKind.Module) && (DynAbs.Tracing.TraceSender.Expression_True(10051, 13214, 13323) && f_10051_13290_13315(moduleNs) == this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10051, 13210, 13453);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10051, 13422, 13438);

                    return moduleNs;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10051, 13210, 13453);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10051, 13469, 13954) || true) && (f_10051_13473_13506(namespaceSymbol) || (DynAbs.Tracing.TraceSender.Expression_False(10051, 13473, 13561) || (object)f_10051_13518_13553(namespaceSymbol) == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10051, 13469, 13954);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10051, 13595, 13623);

                    return f_10051_13602_13622(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10051, 13469, 13954);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10051, 13469, 13954);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10051, 13689, 13755);

                    var
                    cns = f_10051_13699_13754(this, f_10051_13718_13753(namespaceSymbol))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10051, 13773, 13909) || true) && ((object)cns != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10051, 13773, 13909);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10051, 13838, 13890);

                        return f_10051_13845_13889(cns, f_10051_13868_13888(namespaceSymbol));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10051, 13773, 13909);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10051, 13927, 13939);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10051, 13469, 13954);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10051, 12897, 13965);

                System.ArgumentNullException
                f_10051_13064_13114(string
                paramName)
                {
                    var return_v = new System.ArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10051, 13064, 13114);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10051_13290_13315(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10051, 13290, 13315);
                    return return_v;
                }


                bool
                f_10051_13473_13506(Microsoft.CodeAnalysis.INamespaceSymbol
                this_param)
                {
                    var return_v = this_param.IsGlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10051, 13473, 13506);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamespaceSymbol
                f_10051_13518_13553(Microsoft.CodeAnalysis.INamespaceSymbol
                this_param)
                {
                    var return_v = this_param.ContainingNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10051, 13518, 13553);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10051_13602_13622(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param)
                {
                    var return_v = this_param.GlobalNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10051, 13602, 13622);
                    return return_v;
                }


                Microsoft.CodeAnalysis.INamespaceSymbol
                f_10051_13718_13753(Microsoft.CodeAnalysis.INamespaceSymbol
                this_param)
                {
                    var return_v = this_param.ContainingNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10051, 13718, 13753);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10051_13699_13754(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                this_param, Microsoft.CodeAnalysis.INamespaceSymbol
                namespaceSymbol)
                {
                    var return_v = this_param.GetModuleNamespace(namespaceSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10051, 13699, 13754);
                    return return_v;
                }


                string
                f_10051_13868_13888(Microsoft.CodeAnalysis.INamespaceSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10051, 13868, 13888);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                f_10051_13845_13889(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                this_param, string
                name)
                {
                    var return_v = this_param.GetNestedNamespace(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10051, 13845, 13889);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10051, 12897, 13965);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10051, 12897, 13965);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public abstract bool AreLocalsZeroed { get; }

        public abstract ModuleMetadata GetMetadata();

        protected override ISymbol CreateISymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10051, 14323, 14443);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10051, 14390, 14432);

                return f_10051_14397_14431(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10051, 14323, 14443);

                Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.ModuleSymbol
                f_10051_14397_14431(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                underlying)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.ModuleSymbol(underlying);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10051, 14397, 14431);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10051, 14323, 14443);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10051, 14323, 14443);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ModuleSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10051, 681, 14450);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10051, 681, 14450);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10051, 681, 14450);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10051, 681, 14450);
    }
}
