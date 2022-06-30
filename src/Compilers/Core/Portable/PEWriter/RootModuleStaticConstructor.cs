// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Reflection;
using Microsoft.CodeAnalysis;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.Debugging;
using Microsoft.CodeAnalysis.Emit;
using Roslyn.Utilities;

namespace Microsoft.Cci
{
    internal sealed partial class RootModuleStaticConstructor : IMethodDefinition, IMethodBody
    {
        public RootModuleStaticConstructor(ITypeDefinition containingTypeDefinition, ImmutableArray<byte> il)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(511, 640, 851);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 910, 966);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 766, 818);

                ContainingTypeDefinition = containingTypeDefinition;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 832, 840);

                IL = il;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(511, 640, 851);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 640, 851);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 640, 851);
            }
        }

        public ITypeDefinition ContainingTypeDefinition { get; }

        public string Name
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 997, 1042);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 1000, 1042);
                    return WellKnownMemberNames.StaticConstructorName; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 997, 1042);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 997, 1042);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 997, 1042);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IMethodBody GetBody(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 1103, 1110);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 1106, 1110);
                return this; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 1103, 1110);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 1103, 1110);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 1103, 1110);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<IGenericMethodParameter> GenericParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 1185, 1253);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 1188, 1253);
                    return f_511_1188_1253(); DynAbs.Tracing.TraceSender.TraceExitMethod(511, 1185, 1253);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 1185, 1253);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 1185, 1253);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsImplicitlyDeclared
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 1299, 1306);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 1302, 1306);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 1299, 1306);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 1299, 1306);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 1299, 1306);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool HasDeclarativeSecurity
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 1354, 1362);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 1357, 1362);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 1354, 1362);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 1354, 1362);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 1354, 1362);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsAbstract
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 1398, 1406);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 1401, 1406);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 1398, 1406);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 1398, 1406);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 1398, 1406);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsAccessCheckedOnOverride
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 1457, 1465);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 1460, 1465);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 1457, 1465);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 1457, 1465);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 1457, 1465);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsConstructor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 1504, 1512);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 1507, 1512);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 1504, 1512);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 1504, 1512);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 1504, 1512);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsExternal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 1548, 1556);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 1551, 1556);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 1548, 1556);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 1548, 1556);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 1548, 1556);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsHiddenBySignature
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 1601, 1608);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 1604, 1608);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 1601, 1608);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 1601, 1608);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 1601, 1608);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsNewSlot
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 1643, 1651);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 1646, 1651);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 1643, 1651);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 1643, 1651);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 1643, 1651);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsPlatformInvoke
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 1693, 1701);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 1696, 1701);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 1693, 1701);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 1693, 1701);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 1693, 1701);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsRuntimeSpecial
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 1743, 1750);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 1746, 1750);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 1743, 1750);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 1743, 1750);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 1743, 1750);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsSealed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 1784, 1792);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 1787, 1792);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 1784, 1792);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 1784, 1792);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 1784, 1792);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 1831, 1838);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 1834, 1838);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 1831, 1838);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 1831, 1838);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 1831, 1838);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsStatic
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 1872, 1879);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 1875, 1879);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 1872, 1879);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 1872, 1879);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 1872, 1879);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsVirtual
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 1914, 1922);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 1917, 1922);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 1914, 1922);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 1914, 1922);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 1914, 1922);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<IParameterDefinition> Parameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 1990, 2035);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 1993, 2035);
                    return ImmutableArray<IParameterDefinition>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 1990, 2035);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 1990, 2035);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 1990, 2035);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IPlatformInvokeInformation PlatformInvokeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 2101, 2108);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 2104, 2108);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 2101, 2108);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 2101, 2108);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 2101, 2108);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool RequiresSecurityObject
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 2156, 2164);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 2159, 2164);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 2156, 2164);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 2156, 2164);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 2156, 2164);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool ReturnValueIsMarshalledExplicitly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 2223, 2231);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 2226, 2231);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 2223, 2231);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 2223, 2231);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 2223, 2231);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IMarshallingInformation ReturnValueMarshallingInformation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 2309, 2316);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 2312, 2316);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 2309, 2316);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 2309, 2316);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 2309, 2316);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<byte> ReturnValueMarshallingDescriptor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 2390, 2400);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 2393, 2400);
                    return default; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 2390, 2400);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 2390, 2400);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 2390, 2400);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IEnumerable<SecurityAttribute> SecurityAttributes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 2470, 2477);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 2473, 2477);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 2470, 2477);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 2470, 2477);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 2470, 2477);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public INamespace ContainingNamespace
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 2528, 2535);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 2531, 2535);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 2528, 2535);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 2528, 2535);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 2528, 2535);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public TypeMemberVisibility Visibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 2587, 2618);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 2590, 2618);
                    return TypeMemberVisibility.Private; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 2587, 2618);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 2587, 2618);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 2587, 2618);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool AcceptsExtraArguments
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 2665, 2673);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 2668, 2673);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 2665, 2673);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 2665, 2673);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 2665, 2673);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ushort GenericParameterCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 2722, 2726);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 2725, 2726);
                    return 0; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 2722, 2726);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 2722, 2726);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 2722, 2726);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool IsGeneric
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 2761, 2769);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 2764, 2769);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 2761, 2769);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 2761, 2769);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 2761, 2769);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<IParameterTypeInformation> ExtraParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 2847, 2897);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 2850, 2897);
                    return ImmutableArray<IParameterTypeInformation>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 2847, 2897);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 2847, 2897);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 2847, 2897);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IGenericMethodInstanceReference AsGenericMethodInstanceReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 2982, 2989);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 2985, 2989);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 2982, 2989);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 2982, 2989);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 2982, 2989);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ISpecializedMethodReference AsSpecializedMethodReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 3066, 3073);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 3069, 3073);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 3066, 3073);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 3066, 3073);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 3066, 3073);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public CallingConvention CallingConvention
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 3129, 3157);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 3132, 3157);
                    return CallingConvention.Default; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 3129, 3157);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 3129, 3157);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 3129, 3157);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ushort ParameterCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 3199, 3203);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 3202, 3203);
                    return 0; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 3199, 3203);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 3199, 3203);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 3199, 3203);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<ICustomModifier> ReturnValueCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 3282, 3322);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 3285, 3322);
                    return ImmutableArray<ICustomModifier>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 3282, 3322);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 3282, 3322);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 3282, 3322);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<ICustomModifier> RefCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 3393, 3433);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 3396, 3433);
                    return ImmutableArray<ICustomModifier>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 3393, 3433);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 3393, 3433);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 3393, 3433);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool ReturnValueIsByRef
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 3477, 3485);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 3480, 3485);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 3477, 3485);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 3477, 3485);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 3477, 3485);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IDefinition AsDefinition(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 3551, 3558);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 3554, 3558);
                return this; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 3551, 3558);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 3551, 3558);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 3551, 3558);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        CodeAnalysis.Symbols.ISymbolInternal Cci.IReference.GetInternalSymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 3643, 3650);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 3646, 3650);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 3643, 3650);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 3643, 3650);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 3643, 3650);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public void Dispatch(MetadataVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 3709, 3750);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 3712, 3750);
                f_511_3712_3750(visitor, this); DynAbs.Tracing.TraceSender.TraceExitMethod(511, 3709, 3750);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 3709, 3750);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 3709, 3750);
            }

            int
            f_511_3712_3750(Microsoft.Cci.MetadataVisitor
            this_param, Microsoft.Cci.RootModuleStaticConstructor
            method)
            {
                this_param.Visit((Microsoft.Cci.IMethodDefinition)method);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(511, 3712, 3750);
                return 0;
            }

        }

        public IEnumerable<ICustomAttribute> GetAttributes(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 3835, 3896);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 3838, 3896);
                return f_511_3838_3896(); DynAbs.Tracing.TraceSender.TraceExitMethod(511, 3835, 3896);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 3835, 3896);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 3835, 3896);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
            f_511_3838_3896()
            {
                var return_v = SpecializedCollections.EmptyEnumerable<ICustomAttribute>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(511, 3838, 3896);
                return return_v;
            }

        }

        public ITypeReference GetContainingType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 3970, 3997);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 3973, 3997);
                return f_511_3973_3997(); DynAbs.Tracing.TraceSender.TraceExitMethod(511, 3970, 3997);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 3970, 3997);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 3970, 3997);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.Cci.ITypeDefinition
            f_511_3973_3997()
            {
                var return_v = ContainingTypeDefinition;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(511, 3973, 3997);
                return return_v;
            }

        }

        public MethodImplAttributes GetImplementationAttributes(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 4087, 4097);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 4090, 4097);
                return default; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 4087, 4097);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 4087, 4097);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 4087, 4097);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ImmutableArray<IParameterTypeInformation> GetParameters(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 4194, 4244);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 4197, 4244);
                return ImmutableArray<IParameterTypeInformation>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 4194, 4244);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 4194, 4244);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 4194, 4244);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IMethodDefinition GetResolvedMethod(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 4321, 4328);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 4324, 4328);
                return this; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 4321, 4328);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 4321, 4328);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 4321, 4328);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public IEnumerable<ICustomAttribute> GetReturnValueAttributes(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 4424, 4485);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 4427, 4485);
                return f_511_4427_4485(); DynAbs.Tracing.TraceSender.TraceExitMethod(511, 4424, 4485);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 4424, 4485);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 4424, 4485);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Collections.Generic.IEnumerable<Microsoft.Cci.ICustomAttribute>
            f_511_4427_4485()
            {
                var return_v = SpecializedCollections.EmptyEnumerable<ICustomAttribute>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(511, 4427, 4485);
                return return_v;
            }

        }

        public ITypeReference GetType(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 4549, 4616);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 4552, 4616);
                return f_511_4552_4616(context.Module, PlatformType.SystemVoid, context); DynAbs.Tracing.TraceSender.TraceExitMethod(511, 4549, 4616);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 4549, 4616);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 4549, 4616);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.Cci.ITypeReference
            f_511_4552_4616(Microsoft.CodeAnalysis.Emit.CommonPEModuleBuilder
            this_param, Microsoft.Cci.PlatformType
            platformType, Microsoft.CodeAnalysis.Emit.EmitContext
            context)
            {
                var return_v = this_param.GetPlatformType(platformType, context);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(511, 4552, 4616);
                return return_v;
            }

        }

        public ushort MaxStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 4693, 4697);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 4696, 4697);
                    return 0; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 4693, 4697);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 4693, 4697);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 4693, 4697);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<byte> IL { get; }

        public IMethodDefinition MethodDefinition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 4803, 4810);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 4806, 4810);
                    return this; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 4803, 4810);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 4803, 4810);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 4803, 4810);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<ExceptionHandlerRegion> ExceptionRegions
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 4886, 4933);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 4889, 4933);
                    return ImmutableArray<ExceptionHandlerRegion>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 4886, 4933);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 4886, 4933);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 4886, 4933);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool AreLocalsZeroed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 4974, 4982);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 4977, 4982);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 4974, 4982);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 4974, 4982);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 4974, 4982);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool HasStackalloc
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 5021, 5029);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 5024, 5029);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 5021, 5029);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 5021, 5029);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 5021, 5029);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<ILocalDefinition> LocalVariables
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 5097, 5138);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 5100, 5138);
                    return ImmutableArray<ILocalDefinition>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 5097, 5138);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 5097, 5138);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 5097, 5138);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public StateMachineMoveNextBodyDebugInfo MoveNextBodyInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 5209, 5216);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 5212, 5216);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 5209, 5216);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 5209, 5216);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 5209, 5216);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<SequencePoint> SequencePoints
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 5281, 5319);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 5284, 5319);
                    return ImmutableArray<SequencePoint>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 5281, 5319);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 5281, 5319);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 5281, 5319);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public bool HasDynamicLocalVariables
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 5369, 5377);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 5372, 5377);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 5369, 5377);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 5369, 5377);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 5369, 5377);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<LocalScope> LocalScopes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 5436, 5471);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 5439, 5471);
                    return ImmutableArray<LocalScope>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 5436, 5471);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 5436, 5471);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 5436, 5471);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IImportScope ImportScope
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 5516, 5523);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 5519, 5523);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 5516, 5523);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 5516, 5523);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 5516, 5523);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public DebugId MethodId
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 5560, 5570);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 5563, 5570);
                    return default; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 5560, 5570);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 5560, 5570);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 5560, 5570);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<StateMachineHoistedLocalScope> StateMachineHoistedLocalScopes
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 5667, 5721);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 5670, 5721);
                    return ImmutableArray<StateMachineHoistedLocalScope>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 5667, 5721);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 5667, 5721);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 5667, 5721);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string StateMachineTypeName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 5769, 5776);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 5772, 5776);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 5769, 5776);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 5769, 5776);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 5769, 5776);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<EncHoistedLocalInfo> StateMachineHoistedLocalSlots
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 5862, 5906);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 5865, 5906);
                    return ImmutableArray<EncHoistedLocalInfo>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 5862, 5906);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 5862, 5906);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 5862, 5906);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<ITypeReference> StateMachineAwaiterSlots
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 5982, 6021);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 5985, 6021);
                    return ImmutableArray<ITypeReference>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 5982, 6021);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 5982, 6021);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 5982, 6021);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<ClosureDebugInfo> ClosureDebugInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 6091, 6132);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 6094, 6132);
                    return ImmutableArray<ClosureDebugInfo>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 6091, 6132);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 6091, 6132);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 6091, 6132);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public ImmutableArray<LambdaDebugInfo> LambdaDebugInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 6200, 6240);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 6203, 6240);
                    return ImmutableArray<LambdaDebugInfo>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 6200, 6240);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 6200, 6240);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 6200, 6240);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public DynamicAnalysisMethodBodyData DynamicAnalysisData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 6310, 6317);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 6313, 6317);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(511, 6310, 6317);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 6310, 6317);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 6310, 6317);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override bool Equals(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 6330, 6609);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 6544, 6598);

                throw f_511_6550_6597();
                DynAbs.Tracing.TraceSender.TraceExitMethod(511, 6330, 6609);

                System.Exception
                f_511_6550_6597()
                {
                    var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(511, 6550, 6597);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 6330, 6609);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 6330, 6609);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(511, 6621, 6894);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(511, 6829, 6883);

                throw f_511_6835_6882();
                DynAbs.Tracing.TraceSender.TraceExitMethod(511, 6621, 6894);

                System.Exception
                f_511_6835_6882()
                {
                    var return_v = Roslyn.Utilities.ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(511, 6835, 6882);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(511, 6621, 6894);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 6621, 6894);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static RootModuleStaticConstructor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(511, 533, 6901);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(511, 533, 6901);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(511, 533, 6901);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(511, 533, 6901);

        System.Collections.Generic.IEnumerable<Microsoft.Cci.IGenericMethodParameter>
        f_511_1188_1253()
        {
            var return_v = SpecializedCollections.EmptyEnumerable<IGenericMethodParameter>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(511, 1188, 1253);
            return return_v;
        }

    }
}
