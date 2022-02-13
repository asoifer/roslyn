// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CodeGen;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.Symbols;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp
{
    internal sealed class StateMachineFieldSymbol : SynthesizedFieldSymbolBase, ISynthesizedMethodBodyImplementationSymbol
    {
        private readonly TypeWithAnnotations _type;

        private readonly bool _isThis;

        internal readonly int SlotIndex;

        internal readonly LocalSlotDebugInfo SlotDebugInfo;

        public StateMachineFieldSymbol(NamedTypeSymbol stateMachineType, TypeWithAnnotations type, string name, bool isPublic, bool isThis)
        : this(f_10541_1234_1250_C(stateMachineType), type, name, f_10541_1264_1340(SynthesizedLocalKind.LoweringTemp, LocalDebugId.None), slotIndex: -1, isPublic: isPublic)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10541, 1082, 1429);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10541, 1401, 1418);

                _isThis = isThis;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10541, 1082, 1429);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10541, 1082, 1429);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10541, 1082, 1429);
            }
        }

        public StateMachineFieldSymbol(NamedTypeSymbol stateMachineType, TypeSymbol type, string name, SynthesizedLocalKind synthesizedKind, int slotIndex, bool isPublic)
        : this(f_10541_1624_1640_C(stateMachineType), type, name, f_10541_1654_1712(synthesizedKind, LocalDebugId.None), slotIndex, isPublic: isPublic)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10541, 1441, 1766);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10541, 1441, 1766);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10541, 1441, 1766);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10541, 1441, 1766);
            }
        }

        public StateMachineFieldSymbol(NamedTypeSymbol stateMachineType, TypeSymbol type, string name, LocalSlotDebugInfo slotDebugInfo, int slotIndex, bool isPublic) : this(f_10541_1957_1973_C(stateMachineType), TypeWithAnnotations.Create(type), name, slotDebugInfo, slotIndex, isPublic)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10541, 1778, 2072);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10541, 1778, 2072);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10541, 1778, 2072);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10541, 1778, 2072);
            }
        }

        public StateMachineFieldSymbol(NamedTypeSymbol stateMachineType, TypeWithAnnotations type, string name, LocalSlotDebugInfo slotDebugInfo, int slotIndex, bool isPublic)
        : base(f_10541_2272_2288_C(stateMachineType), name, isPublic: isPublic, isReadOnly: false, isStatic: false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10541, 2084, 2633);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10541, 774, 781);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10541, 896, 905);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10541, 2376, 2411);

                f_10541_2376_2410((object)type != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10541, 2425, 2503);

                f_10541_2425_2502(f_10541_2438_2481(slotDebugInfo.SynthesizedKind) == (slotIndex >= 0));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10541, 2519, 2532);

                _type = type;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10541, 2546, 2573);

                this.SlotIndex = slotIndex;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10541, 2587, 2622);

                this.SlotDebugInfo = slotDebugInfo;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10541, 2084, 2633);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10541, 2084, 2633);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10541, 2084, 2633);
            }
        }

        internal override bool SuppressDynamicAttribute
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10541, 2717, 2737);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10541, 2723, 2735);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10541, 2717, 2737);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10541, 2645, 2748);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10541, 2645, 2748);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override TypeWithAnnotations GetFieldType(ConsList<FieldSymbol> fieldsBeingBound)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10541, 2760, 2899);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10541, 2875, 2888);

                return _type;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10541, 2760, 2899);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10541, 2760, 2899);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10541, 2760, 2899);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        bool ISynthesizedMethodBodyImplementationSymbol.HasMethodBodyDependency
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10541, 3007, 3027);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10541, 3013, 3025);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10541, 3007, 3027);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10541, 2911, 3038);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10541, 2911, 3038);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        IMethodSymbolInternal ISynthesizedMethodBodyImplementationSymbol.Method
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10541, 3146, 3231);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10541, 3152, 3229);

                    return f_10541_3159_3228(((ISynthesizedMethodBodyImplementationSymbol)f_10541_3204_3220()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10541, 3146, 3231);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10541_3204_3220()
                    {
                        var return_v = ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10541, 3204, 3220);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal?
                    f_10541_3159_3228(Microsoft.CodeAnalysis.Symbols.ISynthesizedMethodBodyImplementationSymbol
                    this_param)
                    {
                        var return_v = this_param.Method;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10541, 3159, 3228);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10541, 3050, 3242);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10541, 3050, 3242);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsCapturedFrame
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10541, 3317, 3340);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10541, 3323, 3338);

                    return _isThis;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10541, 3317, 3340);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10541, 3254, 3351);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10541, 3254, 3351);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static StateMachineFieldSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10541, 564, 3358);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10541, 564, 3358);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10541, 564, 3358);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10541, 564, 3358);

        static Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo
        f_10541_1264_1340(Microsoft.CodeAnalysis.SynthesizedLocalKind
        synthesizedKind, Microsoft.CodeAnalysis.CodeGen.LocalDebugId
        id)
        {
            var return_v = new Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo(synthesizedKind, id);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10541, 1264, 1340);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10541_1234_1250_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10541, 1082, 1429);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo
        f_10541_1654_1712(Microsoft.CodeAnalysis.SynthesizedLocalKind
        synthesizedKind, Microsoft.CodeAnalysis.CodeGen.LocalDebugId
        id)
        {
            var return_v = new Microsoft.CodeAnalysis.CodeGen.LocalSlotDebugInfo(synthesizedKind, id);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10541, 1654, 1712);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10541_1624_1640_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10541, 1441, 1766);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10541_1957_1973_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10541, 1778, 2072);
            return return_v;
        }


        int
        f_10541_2376_2410(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10541, 2376, 2410);
            return 0;
        }


        bool
        f_10541_2438_2481(Microsoft.CodeAnalysis.SynthesizedLocalKind
        kind)
        {
            var return_v = kind.IsLongLived();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10541, 2438, 2481);
            return return_v;
        }


        int
        f_10541_2425_2502(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10541, 2425, 2502);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10541_2272_2288_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10541, 2084, 2633);
            return return_v;
        }

    }
}
