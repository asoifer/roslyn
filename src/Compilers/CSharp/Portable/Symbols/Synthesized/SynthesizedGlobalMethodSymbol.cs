// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.Text;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class SynthesizedGlobalMethodSymbol : MethodSymbol
    {
        private readonly ModuleSymbol _containingModule;

        private readonly PrivateImplementationDetails _privateImplType;

        private readonly TypeSymbol _returnType;

        private ImmutableArray<ParameterSymbol> _parameters;

        private readonly string _name;

        internal SynthesizedGlobalMethodSymbol(ModuleSymbol containingModule, PrivateImplementationDetails privateImplType, TypeSymbol returnType, string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10679, 1168, 1718);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 913, 930);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 987, 1003);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 1042, 1053);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 1150, 1155);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 1344, 1391);

                f_10679_1344_1390((object)containingModule != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 1405, 1443);

                f_10679_1405_1442(privateImplType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 1457, 1498);

                f_10679_1457_1497((object)returnType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 1512, 1539);

                f_10679_1512_1538(name != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 1555, 1592);

                _containingModule = containingModule;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 1606, 1641);

                _privateImplType = privateImplType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 1655, 1680);

                _returnType = returnType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 1694, 1707);

                _name = name;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10679, 1168, 1718);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 1168, 1718);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 1168, 1718);
            }
        }

        protected void SetParameters(ImmutableArray<ParameterSymbol> parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 1730, 1908);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 1827, 1897);

                f_10679_1827_1896(ref _parameters, parameters);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 1730, 1908);

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10679_1827_1896(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedExchange(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10679, 1827, 1896);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 1730, 1908);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 1730, 1908);
            }
        }

        public sealed override bool IsImplicitlyDeclared
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 1993, 2013);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 1999, 2011);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 1993, 2013);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 1920, 2024);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 1920, 2024);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool GenerateDebugInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 2108, 2129);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 2114, 2127);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 2108, 2129);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 2036, 2140);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 2036, 2140);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 2231, 2307);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 2267, 2292);

                    return _containingModule;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 2231, 2307);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 2152, 2318);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 2152, 2318);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override AssemblySymbol ContainingAssembly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 2411, 2506);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 2447, 2491);

                    return f_10679_2454_2490(_containingModule);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 2411, 2506);

                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10679_2454_2490(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10679, 2454, 2490);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 2330, 2517);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 2330, 2517);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 2809, 2829);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 2815, 2827);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 2809, 2829);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 2738, 2840);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 2738, 2840);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override NamedTypeSymbol ContainingType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 2930, 2993);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 2966, 2978);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 2930, 2993);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 2852, 3004);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 2852, 3004);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal PrivateImplementationDetails ContainingPrivateImplementationDetailsType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 3121, 3153);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 3127, 3151);

                    return _privateImplType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 3121, 3153);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 3016, 3164);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 3016, 3164);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 3228, 3249);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 3234, 3247);

                    return _name;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 3228, 3249);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 3176, 3260);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 3176, 3260);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 3334, 3355);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 3340, 3353);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 3334, 3355);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 3272, 3366);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 3272, 3366);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override System.Reflection.MethodImplAttributes ImplementationAttributes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 3484, 3547);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 3490, 3545);

                    return default(System.Reflection.MethodImplAttributes);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 3484, 3547);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 3378, 3558);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 3378, 3558);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool RequiresSecurityObject
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 3640, 3661);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 3646, 3659);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 3640, 3661);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 3570, 3672);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 3570, 3672);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override DllImportData GetDllImportData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 3684, 3780);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 3757, 3769);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 3684, 3780);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 3684, 3780);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 3684, 3780);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override FlowAnalysisAnnotations ReturnTypeFlowAnalysisAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 3873, 3904);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 3876, 3904);
                    return FlowAnalysisAnnotations.None; DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 3873, 3904);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 3873, 3904);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 3873, 3904);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override ImmutableHashSet<string> ReturnNotNullIfParameterNotNull
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 3997, 4030);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 4000, 4030);
                    return ImmutableHashSet<string>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 3997, 4030);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 3997, 4030);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 3997, 4030);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool AreLocalsZeroed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 4087, 4122);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 4090, 4122);
                    return f_10679_4090_4122(f_10679_4090_4106()); DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 4087, 4122);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 4087, 4122);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 4087, 4122);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override MarshalPseudoCustomAttributeData ReturnValueMarshallingInformation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 4244, 4264);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 4250, 4262);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 4244, 4264);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 4135, 4275);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 4135, 4275);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasDeclarativeSecurity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 4357, 4378);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 4363, 4376);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 4357, 4378);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 4287, 4389);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 4287, 4389);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override IEnumerable<Cci.SecurityAttribute> GetSecurityInformation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 4401, 4551);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 4503, 4540);

                throw f_10679_4509_4539();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 4401, 4551);

                System.Exception
                f_10679_4509_4539()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10679, 4509, 4539);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 4401, 4551);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 4401, 4551);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override ObsoleteAttributeData ObsoleteAttributeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 4656, 4676);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 4662, 4674);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 4656, 4676);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 4563, 4687);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 4563, 4687);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override UnmanagedCallersOnlyAttributeData GetUnmanagedCallersOnlyAttributeData(bool forceComplete)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 4815, 4822);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 4818, 4822);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 4815, 4822);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 4815, 4822);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 4815, 4822);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override ImmutableArray<string> GetAppliedConditionalSymbols()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 4835, 4985);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 4938, 4974);

                return ImmutableArray<string>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 4835, 4985);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 4835, 4985);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 4835, 4985);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool IsVararg
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 5051, 5072);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 5057, 5070);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 5051, 5072);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 4997, 5083);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 4997, 5083);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<TypeParameterSymbol> TypeParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 5186, 5243);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 5192, 5241);

                    return ImmutableArray<TypeParameterSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 5186, 5243);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 5095, 5254);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 5095, 5254);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<ParameterSymbol> Parameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 5349, 5568);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 5385, 5514) || true) && (_parameters.IsEmpty)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10679, 5385, 5514);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 5450, 5495);

                        return ImmutableArray<ParameterSymbol>.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10679, 5385, 5514);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 5534, 5553);

                    return _parameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 5349, 5568);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 5266, 5579);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 5266, 5579);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Accessibility DeclaredAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 5667, 5705);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 5673, 5703);

                    return Accessibility.Internal;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 5667, 5705);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 5591, 5716);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 5591, 5716);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 5803, 5849);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 5809, 5847);

                    return ImmutableArray<Location>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 5803, 5849);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 5728, 5860);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 5728, 5860);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 5970, 6066);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 6006, 6051);

                    return ImmutableArray<SyntaxReference>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 5970, 6066);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 5872, 6077);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 5872, 6077);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override RefKind RefKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 6145, 6173);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 6151, 6171);

                    return RefKind.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 6145, 6173);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 6089, 6184);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 6089, 6184);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override TypeWithAnnotations ReturnTypeWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 6282, 6337);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 6288, 6335);

                    return TypeWithAnnotations.Create(_returnType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 6282, 6337);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 6196, 6348);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 6196, 6348);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override FlowAnalysisAnnotations FlowAnalysisAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 6455, 6499);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 6461, 6497);

                    return FlowAnalysisAnnotations.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 6455, 6499);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 6360, 6510);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 6360, 6510);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<CustomModifier> RefCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 6612, 6664);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 6618, 6662);

                    return ImmutableArray<CustomModifier>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 6612, 6664);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 6522, 6675);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 6522, 6675);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<TypeWithAnnotations> TypeArgumentsWithAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 6792, 6849);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 6798, 6847);

                    return ImmutableArray<TypeWithAnnotations>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 6792, 6849);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 6687, 6860);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 6687, 6860);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol AssociatedSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 6936, 6956);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 6942, 6954);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 6936, 6956);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 6872, 6967);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 6872, 6967);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Arity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 7029, 7046);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 7035, 7044);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 7029, 7046);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 6979, 7057);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 6979, 7057);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool ReturnsVoid
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 7126, 7170);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 7132, 7168);

                    return f_10679_7139_7167(f_10679_7139_7154(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 7126, 7170);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10679_7139_7154(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedGlobalMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10679, 7139, 7154);
                        return return_v;
                    }


                    bool
                    f_10679_7139_7167(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = type.IsVoidType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10679, 7139, 7167);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 7069, 7181);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 7069, 7181);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override MethodKind MethodKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 7255, 7290);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 7261, 7288);

                    return MethodKind.Ordinary;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 7255, 7290);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 7193, 7301);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 7193, 7301);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsExtern
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 7367, 7388);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 7373, 7386);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 7367, 7388);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 7313, 7399);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 7313, 7399);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsSealed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 7465, 7486);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 7471, 7484);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 7465, 7486);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 7411, 7497);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 7411, 7497);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsAbstract
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 7565, 7586);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 7571, 7584);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 7565, 7586);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 7509, 7597);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 7509, 7597);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsOverride
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 7665, 7686);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 7671, 7684);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 7665, 7686);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 7609, 7697);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 7609, 7697);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsVirtual
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 7764, 7785);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 7770, 7783);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 7764, 7785);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 7709, 7796);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 7709, 7796);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsStatic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 7862, 7882);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 7868, 7880);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 7862, 7882);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 7808, 7893);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 7808, 7893);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsAsync
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 7958, 7979);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 7964, 7977);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 7958, 7979);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 7905, 7990);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 7905, 7990);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool HidesBaseMethodsByName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 8070, 8091);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 8076, 8089);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 8070, 8091);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 8002, 8102);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 8002, 8102);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool IsMetadataNewSlot(bool ignoreInterfaceImplementationChanges = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 8114, 8261);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 8237, 8250);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 8114, 8261);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 8114, 8261);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 8114, 8261);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override bool IsMetadataVirtual(bool ignoreInterfaceImplementationChanges = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 8273, 8420);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 8396, 8409);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 8273, 8420);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 8273, 8420);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 8273, 8420);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsMetadataFinal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 8495, 8559);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 8531, 8544);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 8495, 8559);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 8432, 8570);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 8432, 8570);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsExtensionMethod
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 8645, 8666);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 8651, 8664);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 8645, 8666);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 8582, 8677);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 8582, 8677);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override Cci.CallingConvention CallingConvention
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 8771, 8788);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 8777, 8786);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 8771, 8788);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 8689, 8799);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 8689, 8799);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsExplicitInterfaceImplementation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 8892, 8913);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 8898, 8911);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 8892, 8913);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 8811, 8924);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 8811, 8924);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<MethodSymbol> ExplicitInterfaceImplementations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 9038, 9088);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 9044, 9086);

                    return ImmutableArray<MethodSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 9038, 9088);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 8936, 9099);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 8936, 9099);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool IsDeclaredReadOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 9160, 9168);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 9163, 9168);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 9160, 9168);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 9160, 9168);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 9160, 9168);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool IsInitOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 9222, 9230);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 9225, 9230);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 9222, 9230);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 9222, 9230);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 9222, 9230);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool SynthesizesLoweredBoundBody
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 9318, 9338);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 9324, 9336);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 9318, 9338);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 9243, 9349);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 9243, 9349);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract override void GenerateMethodBody(TypeCompilationState compilationState, DiagnosticBag diagnostics);

        internal override int CalculateLocalSyntaxOffset(int localPosition, SyntaxTree localTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 9490, 9652);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 9604, 9641);

                throw f_10679_9610_9640();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 9490, 9652);

                System.Exception
                f_10679_9610_9640()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10679, 9610, 9640);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 9490, 9652);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 9490, 9652);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override bool IsNullableAnalysisEnabled()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10679, 9722, 9730);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10679, 9725, 9730);
                return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10679, 9722, 9730);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10679, 9722, 9730);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 9722, 9730);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SynthesizedGlobalMethodSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10679, 798, 9738);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10679, 798, 9738);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10679, 798, 9738);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10679, 798, 9738);

        int
        f_10679_1344_1390(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10679, 1344, 1390);
            return 0;
        }


        int
        f_10679_1405_1442(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10679, 1405, 1442);
            return 0;
        }


        int
        f_10679_1457_1497(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10679, 1457, 1497);
            return 0;
        }


        int
        f_10679_1512_1538(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10679, 1512, 1538);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
        f_10679_4090_4106()
        {
            var return_v = ContainingModule;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10679, 4090, 4106);
            return return_v;
        }


        bool
        f_10679_4090_4122(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
        this_param)
        {
            var return_v = this_param.AreLocalsZeroed;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10679, 4090, 4122);
            return return_v;
        }

    }
}
