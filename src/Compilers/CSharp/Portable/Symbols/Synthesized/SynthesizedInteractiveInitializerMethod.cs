// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using Roslyn.Utilities;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Reflection;
using System.Linq;
using Microsoft.CodeAnalysis.Text;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SynthesizedInteractiveInitializerMethod : SynthesizedInstanceMethodSymbol
    {
        internal const string
        InitializerName = "<Initialize>"
        ;

        private readonly SourceMemberContainerTypeSymbol _containingType;

        private readonly TypeSymbol _resultType;

        private readonly TypeSymbol _returnType;

        private ThreeState _lazyIsNullableAnalysisEnabled;

        internal SynthesizedInteractiveInitializerMethod(SourceMemberContainerTypeSymbol containingType, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10683, 909, 1257);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 721, 736);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 775, 786);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 825, 836);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 866, 896);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 1057, 1100);

                f_10683_1057_1099(f_10683_1070_1098(containingType));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 1116, 1149);

                _containingType = containingType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 1163, 1246);

                f_10683_1163_1245(containingType, diagnostics, out _resultType, out _returnType);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10683, 909, 1257);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 909, 1257);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 909, 1257);
            }
        }

        public override string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10683, 1321, 1352);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 1327, 1350);

                    return InitializerName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10683, 1321, 1352);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 1269, 1363);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 1269, 1363);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsScriptInitializer
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10683, 1442, 1462);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 1448, 1460);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10683, 1442, 1462);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 1375, 1473);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 1375, 1473);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10683, 1535, 1577);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 1541, 1575);

                    return this.TypeParameters.Length;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10683, 1535, 1577);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 1485, 1588);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 1485, 1588);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10683, 1664, 1684);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 1670, 1682);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10683, 1664, 1684);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 1600, 1695);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 1600, 1695);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10683, 1771, 1802);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 1777, 1800);

                    return _containingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10683, 1771, 1802);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 1707, 1813);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 1707, 1813);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10683, 1901, 1937);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 1907, 1935);

                    return Accessibility.Friend;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10683, 1901, 1937);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 1825, 1948);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 1825, 1948);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10683, 2062, 2112);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 2068, 2110);

                    return ImmutableArray<MethodSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10683, 2062, 2112);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 1960, 2123);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 1960, 2123);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10683, 2203, 2224);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 2209, 2222);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10683, 2203, 2224);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 2135, 2235);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 2135, 2235);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10683, 2303, 2324);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 2309, 2322);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10683, 2303, 2324);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 2247, 2335);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 2247, 2335);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10683, 2400, 2420);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 2406, 2418);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10683, 2400, 2420);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 2347, 2431);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 2347, 2431);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10683, 2506, 2527);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 2512, 2525);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10683, 2506, 2527);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 2443, 2538);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 2443, 2538);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10683, 2604, 2625);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 2610, 2623);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10683, 2604, 2625);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 2550, 2636);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 2550, 2636);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10683, 2704, 2725);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 2710, 2723);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10683, 2704, 2725);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 2648, 2736);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 2648, 2736);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10683, 2802, 2823);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 2808, 2821);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10683, 2802, 2823);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 2748, 2834);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 2748, 2834);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10683, 2900, 2921);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 2906, 2919);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10683, 2900, 2921);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 2846, 2932);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 2846, 2932);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsVararg
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10683, 2998, 3019);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 3004, 3017);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10683, 2998, 3019);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 2944, 3030);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 2944, 3030);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10683, 3098, 3126);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 3104, 3124);

                    return RefKind.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10683, 3098, 3126);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 3042, 3137);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 3042, 3137);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10683, 3204, 3225);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 3210, 3223);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10683, 3204, 3225);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 3149, 3236);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 3149, 3236);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10683, 3323, 3364);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 3329, 3362);

                    return f_10683_3336_3361(_containingType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10683, 3323, 3364);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10683_3336_3361(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Locations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10683, 3336, 3361);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 3248, 3375);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 3248, 3375);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10683, 3449, 3484);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 3455, 3482);

                    return MethodKind.Ordinary;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10683, 3449, 3484);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 3387, 3495);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 3387, 3495);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10683, 3590, 3643);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 3596, 3641);

                    return ImmutableArray<ParameterSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10683, 3590, 3643);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 3507, 3654);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 3507, 3654);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10683, 3723, 3763);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 3729, 3761);

                    return f_10683_3736_3760(_returnType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10683, 3723, 3763);

                    bool
                    f_10683_3736_3760(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = type.IsVoidType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10683, 3736, 3760);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 3666, 3774);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 3666, 3774);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10683, 3872, 3927);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 3878, 3925);

                    return TypeWithAnnotations.Create(_returnType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10683, 3872, 3927);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 3786, 3938);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 3786, 3938);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override FlowAnalysisAnnotations ReturnTypeFlowAnalysisAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10683, 4024, 4055);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 4027, 4055);
                    return FlowAnalysisAnnotations.None; DynAbs.Tracing.TraceSender.TraceExitMethod(10683, 4024, 4055);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 4024, 4055);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 4024, 4055);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableHashSet<string> ReturnNotNullIfParameterNotNull
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10683, 4141, 4174);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 4144, 4174);
                    return ImmutableHashSet<string>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10683, 4141, 4174);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 4141, 4174);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 4141, 4174);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10683, 4277, 4329);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 4283, 4327);

                    return ImmutableArray<CustomModifier>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10683, 4277, 4329);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 4187, 4340);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 4187, 4340);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10683, 4457, 4514);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 4463, 4512);

                    return ImmutableArray<TypeWithAnnotations>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10683, 4457, 4514);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 4352, 4525);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 4352, 4525);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10683, 4628, 4685);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 4634, 4683);

                    return ImmutableArray<TypeParameterSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10683, 4628, 4685);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 4537, 4696);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 4537, 4696);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10683, 4790, 4979);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 4826, 4855);

                    f_10683_4826_4854(f_10683_4839_4853_M(!this.IsStatic));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 4873, 4909);

                    f_10683_4873_4908(f_10683_4886_4907_M(!this.IsGenericMethod));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 4927, 4964);

                    return Cci.CallingConvention.HasThis;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10683, 4790, 4979);

                    bool
                    f_10683_4839_4853_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10683, 4839, 4853);
                        return return_v;
                    }


                    int
                    f_10683_4826_4854(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10683, 4826, 4854);
                        return 0;
                    }


                    bool
                    f_10683_4886_4907_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10683, 4886, 4907);
                        return return_v;
                    }


                    int
                    f_10683_4873_4908(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10683, 4873, 4908);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 4708, 4990);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 4708, 4990);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool GenerateDebugInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10683, 5067, 5087);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 5073, 5085);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10683, 5067, 5087);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 5002, 5098);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 5002, 5098);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10683, 5180, 5201);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 5186, 5199);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10683, 5180, 5201);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 5110, 5212);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 5110, 5212);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10683, 5286, 5306);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 5292, 5304);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10683, 5286, 5306);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 5224, 5317);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 5224, 5317);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override MethodImplAttributes ImplementationAttributes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10683, 5417, 5462);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 5423, 5460);

                    return default(MethodImplAttributes);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10683, 5417, 5462);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 5329, 5473);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 5329, 5473);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10683, 5555, 5576);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 5561, 5574);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10683, 5555, 5576);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 5485, 5587);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 5485, 5587);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10683, 5708, 5728);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 5714, 5726);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10683, 5708, 5728);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 5599, 5739);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 5599, 5739);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override DllImportData GetDllImportData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10683, 5751, 5847);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 5824, 5836);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10683, 5751, 5847);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 5751, 5847);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 5751, 5847);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<string> GetAppliedConditionalSymbols()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10683, 5859, 6002);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 5955, 5991);

                return ImmutableArray<string>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10683, 5859, 6002);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 5859, 6002);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 5859, 6002);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override IEnumerable<Cci.SecurityAttribute> GetSecurityInformation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10683, 6014, 6164);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 6116, 6153);

                throw f_10683_6122_6152();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10683, 6014, 6164);

                System.Exception
                f_10683_6122_6152()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10683, 6122, 6152);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 6014, 6164);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 6014, 6164);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsMetadataNewSlot(bool ignoreInterfaceImplementationChanges = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10683, 6176, 6316);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 6292, 6305);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10683, 6176, 6316);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 6176, 6316);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 6176, 6316);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsMetadataVirtual(bool ignoreInterfaceImplementationChanges = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10683, 6328, 6468);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 6444, 6457);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10683, 6328, 6468);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 6328, 6468);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 6328, 6468);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override int CalculateLocalSyntaxOffset(int localPosition, SyntaxTree localTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10683, 6480, 6717);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 6594, 6706);

                return f_10683_6601_6705(_containingType, localPosition, localTree, isStatic: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10683, 6480, 6717);

                int
                f_10683_6601_6705(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param, int
                position, Microsoft.CodeAnalysis.SyntaxTree
                tree, bool
                isStatic)
                {
                    var return_v = this_param.CalculateSyntaxOffsetInSynthesizedConstructor(position, tree, isStatic: isStatic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10683, 6601, 6705);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 6480, 6717);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 6480, 6717);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal TypeSymbol ResultType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10683, 6784, 6811);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 6790, 6809);

                    return _resultType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10683, 6784, 6811);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 6729, 6822);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 6729, 6822);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsNullableAnalysisEnabled()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10683, 6834, 7743);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 6909, 7661) || true) && (_lazyIsNullableAnalysisEnabled == ThreeState.Unknown)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10683, 6909, 7661);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 7275, 7314);

                    var
                    compilation = f_10683_7293_7313()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 7332, 7574);

                    bool
                    value = (f_10683_7346_7388(f_10683_7346_7365(compilation)) != NullableContextOptions.Disable) || (DynAbs.Tracing.TraceSender.Expression_False(10683, 7345, 7573) || compilation.SyntaxTrees.Any(tree => ((CSharpSyntaxTree)tree).IsNullableAnalysisEnabled(new TextSpan(0, tree.Length)) == true))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 7592, 7646);

                    _lazyIsNullableAnalysisEnabled = f_10683_7625_7645(value);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10683, 6909, 7661);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 7675, 7732);

                return _lazyIsNullableAnalysisEnabled == ThreeState.True;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10683, 6834, 7743);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10683_7293_7313()
                {
                    var return_v = DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10683, 7293, 7313);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                f_10683_7346_7365(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.Options;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10683, 7346, 7365);
                    return return_v;
                }


                Microsoft.CodeAnalysis.NullableContextOptions
                f_10683_7346_7388(Microsoft.CodeAnalysis.CSharp.CSharpCompilationOptions
                this_param)
                {
                    var return_v = this_param.NullableContextOptions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10683, 7346, 7388);
                    return return_v;
                }


                Microsoft.CodeAnalysis.ThreeState
                f_10683_7625_7645(bool
                value)
                {
                    var return_v = value.ToThreeState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10683, 7625, 7645);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 6834, 7743);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 6834, 7743);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void CalculateReturnType(
                    SourceMemberContainerTypeSymbol containingType,
                    DiagnosticBag diagnostics,
                    out TypeSymbol resultType,
                    out TypeSymbol returnType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10683, 7755, 9110);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 8001, 8069);

                CSharpCompilation
                compilation = f_10683_8033_8068(containingType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 8083, 8162);

                var
                submissionReturnTypeOpt = f_10683_8113_8161_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10683_8113_8146(compilation), 10683, 8113, 8161)?.ReturnTypeOpt)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 8176, 8262);

                var
                taskT = f_10683_8188_8261(compilation, WellKnownType.System_Threading_Tasks_Task_T)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 8276, 8329);

                var
                useSiteDiagnostic = f_10683_8300_8328(taskT)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 8343, 8478) || true) && (useSiteDiagnostic != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10683, 8343, 8478);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 8406, 8463);

                    f_10683_8406_8462(diagnostics, useSiteDiagnostic, NoLocation.Singleton);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10683, 8343, 8478);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 8825, 9044);

                resultType = (DynAbs.Tracing.TraceSender.Conditional_F1(10683, 8838, 8877) || (((object)submissionReturnTypeOpt == null
                && DynAbs.Tracing.TraceSender.Conditional_F2(10683, 8897, 8950)) || DynAbs.Tracing.TraceSender.Conditional_F3(10683, 8970, 9043))) ? f_10683_8897_8950(compilation, SpecialType.System_Object) : f_10683_8970_9043(compilation, submissionReturnTypeOpt, diagnostics);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 9058, 9099);

                returnType = f_10683_9071_9098(taskT, resultType);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10683, 7755, 9110);

                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10683_8033_8068(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10683, 8033, 8068);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpScriptCompilationInfo?
                f_10683_8113_8146(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.ScriptCompilationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10683, 8113, 8146);
                    return return_v;
                }


                System.Type?
                f_10683_8113_8161_M(System.Type?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10683, 8113, 8161);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10683_8188_8261(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.WellKnownType
                type)
                {
                    var return_v = this_param.GetWellKnownType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10683, 8188, 8261);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10683_8300_8328(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10683, 8300, 8328);
                    return return_v;
                }


                int
                f_10683_8406_8462(Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.Location
                location)
                {
                    diagnostics.Add(info, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10683, 8406, 8462);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10683_8897_8950(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SpecialType
                specialType)
                {
                    var return_v = this_param.GetSpecialType(specialType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10683, 8897, 8950);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10683_8970_9043(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, System.Type
                type, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.GetTypeByReflectionType(type, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10683, 8970, 9043);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10683_9071_9098(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param, params Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol[]
                typeArguments)
                {
                    var return_v = this_param.Construct(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10683, 9071, 9098);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10683, 7755, 9110);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 7755, 9110);
            }
        }

        static SynthesizedInteractiveInitializerMethod()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10683, 493, 9117);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10683, 627, 659);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10683, 493, 9117);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10683, 493, 9117);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10683, 493, 9117);

        bool
        f_10683_1070_1098(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        this_param)
        {
            var return_v = this_param.IsScriptClass;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10683, 1070, 1098);
            return return_v;
        }


        int
        f_10683_1057_1099(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10683, 1057, 1099);
            return 0;
        }


        int
        f_10683_1163_1245(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        containingType, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics, out Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        resultType, out Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
        returnType)
        {
            CalculateReturnType(containingType, diagnostics, out resultType, out returnType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10683, 1163, 1245);
            return 0;
        }

    }
}
