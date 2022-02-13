// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.Emit;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Emit
{
    internal sealed class ParameterTypeInformation : Cci.IParameterTypeInformation
    {
        private readonly ParameterSymbol _underlyingParameter;

        public ParameterTypeInformation(ParameterSymbol underlyingParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10201, 651, 864);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10201, 618, 638);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10201, 744, 794);

                f_10201_744_793((object)underlyingParameter != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10201, 810, 853);

                _underlyingParameter = underlyingParameter;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10201, 651, 864);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10201, 651, 864);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10201, 651, 864);
            }
        }

        ImmutableArray<Cci.ICustomModifier> Cci.IParameterTypeInformation.CustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10201, 982, 1141);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10201, 1018, 1126);

                    return ImmutableArray<Cci.ICustomModifier>.CastUp(_underlyingParameter.TypeWithAnnotations.CustomModifiers);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10201, 982, 1141);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10201, 876, 1152);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10201, 876, 1152);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.IParameterTypeInformation.IsByReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10201, 1237, 1340);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10201, 1273, 1325);

                    return f_10201_1280_1308(_underlyingParameter) != RefKind.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10201, 1237, 1340);

                    Microsoft.CodeAnalysis.RefKind
                    f_10201_1280_1308(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10201, 1280, 1308);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10201, 1164, 1351);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10201, 1164, 1351);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<Cci.ICustomModifier> Cci.IParameterTypeInformation.RefCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10201, 1472, 1614);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10201, 1508, 1599);

                    return ImmutableArray<Cci.ICustomModifier>.CastUp(f_10201_1558_1597(_underlyingParameter));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10201, 1472, 1614);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10201_1558_1597(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.RefCustomModifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10201, 1558, 1597);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10201, 1363, 1625);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10201, 1363, 1625);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.ITypeReference Cci.IParameterTypeInformation.GetType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10201, 1637, 1918);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10201, 1739, 1907);

                return f_10201_1746_1906(((PEModuleBuilder)context.Module), f_10201_1790_1815(_underlyingParameter), (CSharpSyntaxNode)context.SyntaxNodeOpt, diagnostics: context.Diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10201, 1637, 1918);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10201_1790_1815(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10201, 1790, 1815);
                    return return_v;
                }


                Microsoft.Cci.ITypeReference
                f_10201_1746_1906(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(typeSymbol, syntaxNodeOpt: (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10201, 1746, 1906);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10201, 1637, 1918);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10201, 1637, 1918);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        ushort Cci.IParameterListEntry.Index
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10201, 1991, 2086);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10201, 2027, 2071);

                    return (ushort)f_10201_2042_2070(_underlyingParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10201, 1991, 2086);

                    int
                    f_10201_2042_2070(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.Ordinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10201, 2042, 2070);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10201, 1930, 2097);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10201, 1930, 2097);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10201, 2109, 2265);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10201, 2167, 2254);

                return f_10201_2174_2253(_underlyingParameter, SymbolDisplayFormat.ILVisualizationFormat);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10201, 2109, 2265);

                string
                f_10201_2174_2253(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format)
                {
                    var return_v = this_param.ToDisplayString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10201, 2174, 2253);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10201, 2109, 2265);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10201, 2109, 2265);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override bool Equals(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10201, 2277, 2556);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10201, 2491, 2545);

                throw f_10201_2497_2544();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10201, 2277, 2556);

                System.Exception
                f_10201_2497_2544()
                {
                    var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10201, 2497, 2544);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10201, 2277, 2556);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10201, 2277, 2556);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10201, 2568, 2841);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10201, 2776, 2830);

                throw f_10201_2782_2829();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10201, 2568, 2841);

                System.Exception
                f_10201_2782_2829()
                {
                    var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10201, 2782, 2829);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10201, 2568, 2841);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10201, 2568, 2841);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ParameterTypeInformation()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10201, 490, 2848);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10201, 490, 2848);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10201, 490, 2848);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10201, 490, 2848);

        int
        f_10201_744_793(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10201, 744, 793);
            return 0;
        }

    }
    internal sealed class ArgListParameterTypeInformation : Cci.IParameterTypeInformation
    {
        private readonly ushort _ordinal;

        private readonly bool _isByRef;

        private readonly Cci.ITypeReference _type;

        public ArgListParameterTypeInformation(int ordinal, bool isByRef, Cci.ITypeReference type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10201, 3096, 3309);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10201, 2982, 2990);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10201, 3023, 3031);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10201, 3078, 3083);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10201, 3211, 3238);

                _ordinal = (ushort)ordinal;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10201, 3252, 3271);

                _isByRef = isByRef;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10201, 3285, 3298);

                _type = type;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10201, 3096, 3309);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10201, 3096, 3309);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10201, 3096, 3309);
            }
        }

        ImmutableArray<Cci.ICustomModifier> Cci.IParameterTypeInformation.CustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10201, 3427, 3484);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10201, 3433, 3482);

                    return ImmutableArray<Cci.ICustomModifier>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10201, 3427, 3484);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10201, 3321, 3495);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10201, 3321, 3495);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        bool Cci.IParameterTypeInformation.IsByReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10201, 3580, 3604);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10201, 3586, 3602);

                    return _isByRef;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10201, 3580, 3604);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10201, 3507, 3615);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10201, 3507, 3615);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        ImmutableArray<Cci.ICustomModifier> Cci.IParameterTypeInformation.RefCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10201, 3736, 3793);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10201, 3742, 3791);

                    return ImmutableArray<Cci.ICustomModifier>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10201, 3736, 3793);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10201, 3627, 3804);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10201, 3627, 3804);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        Cci.ITypeReference Cci.IParameterTypeInformation.GetType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10201, 3816, 3942);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10201, 3918, 3931);

                return _type;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10201, 3816, 3942);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10201, 3816, 3942);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10201, 3816, 3942);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        ushort Cci.IParameterListEntry.Index
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10201, 4015, 4039);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10201, 4021, 4037);

                    return _ordinal;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10201, 4015, 4039);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10201, 3954, 4050);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10201, 3954, 4050);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool Equals(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10201, 4062, 4341);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10201, 4276, 4330);

                throw f_10201_4282_4329();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10201, 4062, 4341);

                System.Exception
                f_10201_4282_4329()
                {
                    var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10201, 4282, 4329);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10201, 4062, 4341);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10201, 4062, 4341);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10201, 4353, 4626);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10201, 4561, 4615);

                throw f_10201_4567_4614();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10201, 4353, 4626);

                System.Exception
                f_10201_4567_4614()
                {
                    var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10201, 4567, 4614);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10201, 4353, 4626);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10201, 4353, 4626);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ArgListParameterTypeInformation()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10201, 2856, 4633);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10201, 2856, 4633);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10201, 2856, 4633);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10201, 2856, 4633);
    }
}
