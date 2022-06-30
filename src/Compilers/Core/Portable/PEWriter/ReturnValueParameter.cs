// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;
using Microsoft.CodeAnalysis.CodeGen;
using EmitContext = Microsoft.CodeAnalysis.Emit.EmitContext;

namespace Microsoft.Cci
{
    internal class ReturnValueParameter : IParameterDefinition
    {
        internal ReturnValueParameter(IMethodDefinition containingMethod)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(510, 490, 628);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(510, 971, 988);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(510, 580, 617);

                _containingMethod = containingMethod;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(510, 490, 628);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(510, 490, 628);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(510, 490, 628);
            }
        }

        public IEnumerable<ICustomAttribute> GetAttributes(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(510, 640, 806);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(510, 736, 795);

                return f_510_743_794(_containingMethod, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(510, 640, 806);

                System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
                f_510_743_794(Microsoft.Cci.IMethodDefinition
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetReturnValueAttributes(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(510, 743, 794);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(510, 640, 806);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(510, 640, 806);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ISignature ContainingSignature
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(510, 880, 913);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(510, 886, 911);

                    return _containingMethod;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(510, 880, 913);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(510, 818, 924);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(510, 818, 924);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private readonly IMethodDefinition _containingMethod;

        public MetadataConstant? Constant
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(510, 1059, 1079);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(510, 1065, 1077);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(510, 1059, 1079);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(510, 1001, 1090);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(510, 1001, 1090);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<Cci.ICustomModifier> RefCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(510, 1188, 1240);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(510, 1194, 1238);

                    return f_510_1201_1237(_containingMethod);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(510, 1188, 1240);

                    System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                    f_510_1201_1237(Microsoft.Cci.IMethodDefinition
                    this_param)
                    {
                        var return_v = this_param.RefCustomModifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(510, 1201, 1237);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(510, 1102, 1251);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(510, 1102, 1251);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<Cci.ICustomModifier> CustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(510, 1346, 1406);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(510, 1352, 1404);

                    return f_510_1359_1403(_containingMethod);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(510, 1346, 1406);

                    System.Collections.Immutable.ImmutableArray<Microsoft.Cci.ICustomModifier>
                    f_510_1359_1403(Microsoft.Cci.IMethodDefinition
                    this_param)
                    {
                        var return_v = this_param.ReturnValueCustomModifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(510, 1359, 1403);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(510, 1263, 1417);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(510, 1263, 1417);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public MetadataConstant? GetDefaultValue(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(510, 1429, 1538);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(510, 1515, 1527);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(510, 1429, 1538);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(510, 1429, 1538);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(510, 1429, 1538);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Dispatch(MetadataVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(510, 1550, 1617);
                DynAbs.Tracing.TraceSender.TraceExitMethod(510, 1550, 1617);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(510, 1550, 1617);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(510, 1550, 1617);
            }
        }

        public bool HasDefaultValue
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(510, 1681, 1702);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(510, 1687, 1700);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(510, 1681, 1702);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(510, 1629, 1713);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(510, 1629, 1713);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ushort Index
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(510, 1769, 1786);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(510, 1775, 1784);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(510, 1769, 1786);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(510, 1725, 1797);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(510, 1725, 1797);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsIn
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(510, 1850, 1871);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(510, 1856, 1869);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(510, 1850, 1871);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(510, 1809, 1882);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(510, 1809, 1882);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsByReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(510, 1944, 1996);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(510, 1950, 1994);

                    return f_510_1957_1993(_containingMethod);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(510, 1944, 1996);

                    bool
                    f_510_1957_1993(Microsoft.Cci.IMethodDefinition
                    this_param)
                    {
                        var return_v = this_param.ReturnValueIsByRef;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(510, 1957, 1993);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(510, 1894, 2007);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(510, 1894, 2007);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsMarshalledExplicitly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(510, 2078, 2145);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(510, 2084, 2143);

                    return f_510_2091_2142(_containingMethod);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(510, 2078, 2145);

                    bool
                    f_510_2091_2142(Microsoft.Cci.IMethodDefinition
                    this_param)
                    {
                        var return_v = this_param.ReturnValueIsMarshalledExplicitly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(510, 2091, 2142);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(510, 2019, 2156);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(510, 2019, 2156);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsOptional
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(510, 2215, 2236);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(510, 2221, 2234);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(510, 2215, 2236);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(510, 2168, 2247);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(510, 2168, 2247);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsOut
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(510, 2301, 2322);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(510, 2307, 2320);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(510, 2301, 2322);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(510, 2259, 2333);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(510, 2259, 2333);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IMarshallingInformation MarshallingInformation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(510, 2423, 2490);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(510, 2429, 2488);

                    return f_510_2436_2487(_containingMethod);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(510, 2423, 2490);

                    Microsoft.Cci.IMarshallingInformation
                    f_510_2436_2487(Microsoft.Cci.IMethodDefinition
                    this_param)
                    {
                        var return_v = this_param.ReturnValueMarshallingInformation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(510, 2436, 2487);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(510, 2345, 2501);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(510, 2345, 2501);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<byte> MarshallingDescriptor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(510, 2587, 2653);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(510, 2593, 2651);

                    return f_510_2600_2650(_containingMethod);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(510, 2587, 2653);

                    System.Collections.Immutable.ImmutableArray<byte>
                    f_510_2600_2650(Microsoft.Cci.IMethodDefinition
                    this_param)
                    {
                        var return_v = this_param.ReturnValueMarshallingDescriptor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(510, 2600, 2650);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(510, 2513, 2664);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(510, 2513, 2664);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(510, 2719, 2747);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(510, 2725, 2745);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(510, 2719, 2747);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(510, 2676, 2758);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(510, 2676, 2758);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ITypeReference GetType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(510, 2770, 2898);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(510, 2845, 2887);

                return f_510_2852_2886(_containingMethod, context);
                DynAbs.Tracing.TraceSender.TraceExitMethod(510, 2770, 2898);

                Microsoft.Cci.ITypeReference
                f_510_2852_2886(Microsoft.Cci.IMethodDefinition
                this_param, Microsoft.CodeAnalysis.Emit.EmitContext
                context)
                {
                    var return_v = this_param.GetType(context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(510, 2852, 2886);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(510, 2770, 2898);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(510, 2770, 2898);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IDefinition AsDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(510, 2910, 3025);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(510, 2987, 3014);

                return this as IDefinition;
                DynAbs.Tracing.TraceSender.TraceExitMethod(510, 2910, 3025);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(510, 2910, 3025);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(510, 2910, 3025);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        CodeAnalysis.Symbols.ISymbolInternal? Cci.IReference.GetInternalSymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(510, 3110, 3117);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(510, 3113, 3117);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(510, 3110, 3117);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(510, 3110, 3117);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(510, 3110, 3117);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override bool Equals(object? obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(510, 3130, 3410);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(510, 3345, 3399);

                throw f_510_3351_3398();
                DynAbs.Tracing.TraceSender.TraceExitMethod(510, 3130, 3410);

                System.Exception
                f_510_3351_3398()
                {
                    var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(510, 3351, 3398);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(510, 3130, 3410);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(510, 3130, 3410);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(510, 3422, 3695);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(510, 3630, 3684);

                throw f_510_3636_3683();
                DynAbs.Tracing.TraceSender.TraceExitMethod(510, 3422, 3695);

                System.Exception
                f_510_3636_3683()
                {
                    var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(510, 3636, 3683);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(510, 3422, 3695);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(510, 3422, 3695);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ReturnValueParameter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(510, 415, 3702);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(510, 415, 3702);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(510, 415, 3702);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(510, 415, 3702);
    }
}
