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
using Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting
{
    internal enum RetargetOptions : byte
    {
        RetargetPrimitiveTypesByName = 0,
        RetargetPrimitiveTypesByTypeCode = 1,
    }
    internal partial class RetargetingModuleSymbol
    {
        private readonly ConcurrentDictionary<Symbol, Symbol> _symbolMap;

        private readonly Func<Symbol, RetargetingMethodSymbol> _createRetargetingMethod;

        private readonly Func<Symbol, RetargetingNamespaceSymbol> _createRetargetingNamespace;

        private readonly Func<Symbol, RetargetingTypeParameterSymbol> _createRetargetingTypeParameter;

        private readonly Func<Symbol, RetargetingNamedTypeSymbol> _createRetargetingNamedType;

        private readonly Func<Symbol, RetargetingFieldSymbol> _createRetargetingField;

        private readonly Func<Symbol, RetargetingPropertySymbol> _createRetargetingProperty;

        private readonly Func<Symbol, RetargetingEventSymbol> _createRetargetingEvent;

        private RetargetingMethodSymbol CreateRetargetingMethod(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 1793, 2050);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 1888, 1962);

                f_10603_1888_1961(f_10603_1901_1960(f_10603_1917_1940(symbol), _underlyingModule));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 1976, 2039);

                return f_10603_1983_2038(this, (MethodSymbol)symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 1793, 2050);

                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10603_1917_1940(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 1917, 1940);
                    return return_v;
                }


                bool
                f_10603_1901_1960(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 1901, 1960);
                    return return_v;
                }


                int
                f_10603_1888_1961(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 1888, 1961);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingMethodSymbol
                f_10603_1983_2038(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol
                retargetingModule, Microsoft.CodeAnalysis.CSharp.Symbol
                underlyingMethod)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingMethodSymbol(retargetingModule, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)underlyingMethod);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 1983, 2038);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 1793, 2050);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 1793, 2050);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private RetargetingNamespaceSymbol CreateRetargetingNamespace(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 2062, 2331);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 2163, 2237);

                f_10603_2163_2236(f_10603_2176_2235(f_10603_2192_2215(symbol), _underlyingModule));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 2251, 2320);

                return f_10603_2258_2319(this, (NamespaceSymbol)symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 2062, 2331);

                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10603_2192_2215(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 2192, 2215);
                    return return_v;
                }


                bool
                f_10603_2176_2235(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 2176, 2235);
                    return return_v;
                }


                int
                f_10603_2163_2236(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 2163, 2236);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamespaceSymbol
                f_10603_2258_2319(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol
                retargetingModule, Microsoft.CodeAnalysis.CSharp.Symbol
                underlyingNamespace)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamespaceSymbol(retargetingModule, (Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol)underlyingNamespace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 2258, 2319);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 2062, 2331);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 2062, 2331);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private RetargetingNamedTypeSymbol CreateRetargetingNamedType(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 2343, 2612);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 2444, 2518);

                f_10603_2444_2517(f_10603_2457_2516(f_10603_2473_2496(symbol), _underlyingModule));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 2532, 2601);

                return f_10603_2539_2600(this, (NamedTypeSymbol)symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 2343, 2612);

                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10603_2473_2496(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 2473, 2496);
                    return return_v;
                }


                bool
                f_10603_2457_2516(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 2457, 2516);
                    return return_v;
                }


                int
                f_10603_2444_2517(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 2444, 2517);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamedTypeSymbol
                f_10603_2539_2600(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol
                retargetingModule, Microsoft.CodeAnalysis.CSharp.Symbol
                underlyingType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamedTypeSymbol(retargetingModule, (Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)underlyingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 2539, 2600);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 2343, 2612);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 2343, 2612);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private RetargetingFieldSymbol CreateRetargetingField(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 2624, 2877);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 2717, 2791);

                f_10603_2717_2790(f_10603_2730_2789(f_10603_2746_2769(symbol), _underlyingModule));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 2805, 2866);

                return f_10603_2812_2865(this, (FieldSymbol)symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 2624, 2877);

                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10603_2746_2769(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 2746, 2769);
                    return return_v;
                }


                bool
                f_10603_2730_2789(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 2730, 2789);
                    return return_v;
                }


                int
                f_10603_2717_2790(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 2717, 2790);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingFieldSymbol
                f_10603_2812_2865(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol
                retargetingModule, Microsoft.CodeAnalysis.CSharp.Symbol
                underlyingField)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingFieldSymbol(retargetingModule, (Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol)underlyingField);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 2812, 2865);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 2624, 2877);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 2624, 2877);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private RetargetingPropertySymbol CreateRetargetingProperty(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 2889, 3154);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 2988, 3062);

                f_10603_2988_3061(f_10603_3001_3060(f_10603_3017_3040(symbol), _underlyingModule));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 3076, 3143);

                return f_10603_3083_3142(this, (PropertySymbol)symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 2889, 3154);

                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10603_3017_3040(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 3017, 3040);
                    return return_v;
                }


                bool
                f_10603_3001_3060(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 3001, 3060);
                    return return_v;
                }


                int
                f_10603_2988_3061(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 2988, 3061);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingPropertySymbol
                f_10603_3083_3142(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol
                retargetingModule, Microsoft.CodeAnalysis.CSharp.Symbol
                underlyingProperty)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingPropertySymbol(retargetingModule, (Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol)underlyingProperty);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 3083, 3142);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 2889, 3154);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 2889, 3154);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private RetargetingEventSymbol CreateRetargetingEvent(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 3166, 3419);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 3259, 3333);

                f_10603_3259_3332(f_10603_3272_3331(f_10603_3288_3311(symbol), _underlyingModule));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 3347, 3408);

                return f_10603_3354_3407(this, (EventSymbol)symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 3166, 3419);

                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10603_3288_3311(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 3288, 3311);
                    return return_v;
                }


                bool
                f_10603_3272_3331(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 3272, 3331);
                    return return_v;
                }


                int
                f_10603_3259_3332(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 3259, 3332);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingEventSymbol
                f_10603_3354_3407(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol
                retargetingModule, Microsoft.CodeAnalysis.CSharp.Symbol
                underlyingEvent)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingEventSymbol(retargetingModule, (Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol)underlyingEvent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 3354, 3407);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 3166, 3419);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 3166, 3419);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private RetargetingTypeParameterSymbol CreateRetargetingTypeParameter(Symbol symbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 3431, 3716);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 3540, 3614);

                f_10603_3540_3613(f_10603_3553_3612(f_10603_3569_3592(symbol), _underlyingModule));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 3628, 3705);

                return f_10603_3635_3704(this, (TypeParameterSymbol)symbol);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 3431, 3716);

                Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                f_10603_3569_3592(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.ContainingModule;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 3569, 3592);
                    return return_v;
                }


                bool
                f_10603_3553_3612(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 3553, 3612);
                    return return_v;
                }


                int
                f_10603_3540_3613(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 3540, 3613);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingTypeParameterSymbol
                f_10603_3635_3704(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol
                retargetingModule, Microsoft.CodeAnalysis.CSharp.Symbol
                underlyingTypeParameter)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingTypeParameterSymbol(retargetingModule, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol)underlyingTypeParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 3635, 3704);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 3431, 3716);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 3431, 3716);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        internal class RetargetingSymbolTranslator
                    : CSharpSymbolVisitor<RetargetOptions, Symbol>
        {
            private readonly RetargetingModuleSymbol _retargetingModule;

            public RetargetingSymbolTranslator(RetargetingModuleSymbol retargetingModule)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10603, 3931, 4161);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 3896, 3914);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 4041, 4089);

                    f_10603_4041_4088((object)retargetingModule != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 4107, 4146);

                    _retargetingModule = retargetingModule;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10603, 3931, 4161);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 3931, 4161);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 3931, 4161);
                }
            }

            private ConcurrentDictionary<Symbol, Symbol> SymbolMap
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 4402, 4502);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 4446, 4483);

                        return _retargetingModule._symbolMap;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 4402, 4502);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 4315, 4517);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 4315, 4517);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private RetargetingAssemblySymbol RetargetingAssembly
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 4743, 4853);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 4787, 4834);

                        return _retargetingModule._retargetingAssembly;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 4743, 4853);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 4657, 4868);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 4657, 4868);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private SourceModuleSymbol UnderlyingModule
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 5083, 5190);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 5127, 5171);

                        return _retargetingModule._underlyingModule;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 5083, 5190);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 5007, 5205);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 5007, 5205);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private Dictionary<AssemblySymbol, DestinationData> RetargetingAssemblyMap
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 5736, 5849);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 5780, 5830);

                        return _retargetingModule._retargetingAssemblyMap;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 5736, 5849);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 5629, 5864);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 5629, 5864);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public Symbol Retarget(Symbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 5880, 6191);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 5950, 6085);

                    f_10603_5950_6084(f_10603_5963_5974(symbol) != SymbolKind.NamedType || (DynAbs.Tracing.TraceSender.Expression_False(10603, 5963, 6083) || f_10603_6002_6045(((NamedTypeSymbol)symbol)) == Cci.PrimitiveTypeCode.NotPrimitive));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 6103, 6176);

                    return f_10603_6110_6175(symbol, this, RetargetOptions.RetargetPrimitiveTypesByName);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 5880, 6191);

                    Microsoft.CodeAnalysis.SymbolKind
                    f_10603_5963_5974(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 5963, 5974);
                        return return_v;
                    }


                    Microsoft.Cci.PrimitiveTypeCode
                    f_10603_6002_6045(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.PrimitiveTypeCode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 6002, 6045);
                        return return_v;
                    }


                    int
                    f_10603_5950_6084(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 5950, 6084);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10603_6110_6175(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    visitor, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions
                    a)
                    {
                        var return_v = this_param.Accept<Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions, Microsoft.CodeAnalysis.CSharp.Symbol>((Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions, Microsoft.CodeAnalysis.CSharp.Symbol>)visitor, a);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 6110, 6175);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 5880, 6191);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 5880, 6191);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public MarshalPseudoCustomAttributeData Retarget(MarshalPseudoCustomAttributeData marshallingInfo)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 6207, 6678);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 6451, 6663);

                    return f_10603_6458_6662_I(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(marshallingInfo, 10603, 6458, 6662)?.WithTranslatedTypes<TypeSymbol, RetargetingSymbolTranslator>((type, translator) => translator.Retarget(type, RetargetOptions.RetargetPrimitiveTypesByTypeCode), this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 6207, 6678);

                    Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData?
                    f_10603_6458_6662_I(Microsoft.CodeAnalysis.MarshalPseudoCustomAttributeData?
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 6458, 6662);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 6207, 6678);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 6207, 6678);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public TypeSymbol Retarget(TypeSymbol symbol, RetargetOptions options)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 6694, 6860);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 6797, 6845);

                    return (TypeSymbol)f_10603_6816_6844(symbol, this, options);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 6694, 6860);

                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10603_6816_6844(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    visitor, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions
                    a)
                    {
                        var return_v = this_param.Accept<Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions, Microsoft.CodeAnalysis.CSharp.Symbol>((Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions, Microsoft.CodeAnalysis.CSharp.Symbol>)visitor, a);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 6816, 6844);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 6694, 6860);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 6694, 6860);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public TypeWithAnnotations Retarget(TypeWithAnnotations underlyingType, RetargetOptions options, NamedTypeSymbol asDynamicIfNoPiaContainingType = null)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 6876, 7817);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 7060, 7119);

                    var
                    newTypeSymbol = f_10603_7080_7118(this, underlyingType.Type, options)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 7139, 7329) || true) && ((object)asDynamicIfNoPiaContainingType != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 7139, 7329);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 7231, 7310);

                        newTypeSymbol = f_10603_7247_7309(newTypeSymbol, asDynamicIfNoPiaContainingType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 7139, 7329);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 7349, 7375);

                    bool
                    modifiersHaveChanged
                    = default(bool);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 7393, 7488);

                    var
                    newModifiers = f_10603_7412_7487(this, underlyingType.CustomModifiers, out modifiersHaveChanged)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 7508, 7760) || true) && (modifiersHaveChanged || (DynAbs.Tracing.TraceSender.Expression_False(10603, 7512, 7627) || !f_10603_7537_7627(underlyingType.Type, newTypeSymbol, TypeCompareKind.ConsiderEverything2)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 7508, 7760);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 7669, 7741);

                        return underlyingType.WithTypeAndModifiers(newTypeSymbol, newModifiers);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 7508, 7760);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 7780, 7802);

                    return underlyingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 6876, 7817);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10603_7080_7118(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    symbol, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions
                    options)
                    {
                        var return_v = this_param.Retarget(symbol, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 7080, 7118);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10603_7247_7309(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    containingType)
                    {
                        var return_v = type.AsDynamicIfNoPia(containingType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 7247, 7309);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10603_7412_7487(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    oldModifiers, out bool
                    modifiersHaveChanged)
                    {
                        var return_v = this_param.RetargetModifiers(oldModifiers, out modifiersHaveChanged);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 7412, 7487);
                        return return_v;
                    }


                    bool
                    f_10603_7537_7627(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    right, Microsoft.CodeAnalysis.TypeCompareKind
                    comparison)
                    {
                        var return_v = TypeSymbol.Equals(left, right, comparison);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 7537, 7627);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 6876, 7817);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 6876, 7817);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public NamespaceSymbol Retarget(NamespaceSymbol ns)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 7833, 8032);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 7917, 8017);

                    return (NamespaceSymbol)f_10603_7941_8016(f_10603_7941_7955(this), ns, _retargetingModule._createRetargetingNamespace);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 7833, 8032);

                    System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10603_7941_7955(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param)
                    {
                        var return_v = this_param.SymbolMap;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 7941, 7955);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10603_7941_8016(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    key, System.Func<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamespaceSymbol>
                    valueFactory)
                    {
                        var return_v = this_param.GetOrAdd((Microsoft.CodeAnalysis.CSharp.Symbol)key, (System.Func<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>)valueFactory);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 7941, 8016);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 7833, 8032);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 7833, 8032);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private NamedTypeSymbol RetargetNamedTypeDefinition(NamedTypeSymbol type, RetargetOptions options)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 8048, 10999);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 8179, 8211);

                    f_10603_8179_8210(f_10603_8192_8209(type));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 8231, 8508) || true) && (f_10603_8235_8259(type))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 8231, 8508);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 8301, 8385);

                        var
                        result = f_10603_8314_8384(this, f_10603_8342_8374(type), options)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 8407, 8489);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(10603, 8414, 8452) || ((f_10603_8414_8432(result) == SpecialType.None && DynAbs.Tracing.TraceSender.Conditional_F2(10603, 8455, 8461)) || DynAbs.Tracing.TraceSender.Conditional_F3(10603, 8464, 8488))) ? result : f_10603_8464_8488(result);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 8231, 8508);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 8718, 9099) || true) && (options == RetargetOptions.RetargetPrimitiveTypesByTypeCode)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 8718, 9099);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 8823, 8879);

                        Cci.PrimitiveTypeCode
                        typeCode = f_10603_8856_8878(type)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 8903, 9080) || true) && (typeCode != Cci.PrimitiveTypeCode.NotPrimitive)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 8903, 9080);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 9003, 9057);

                            return f_10603_9010_9056(f_10603_9010_9029(), typeCode);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 8903, 9080);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 8718, 9099);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 9119, 9256) || true) && (f_10603_9123_9132(type) == SymbolKind.ErrorType)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 9119, 9256);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 9198, 9237);

                        return f_10603_9205_9236(type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 9119, 9256);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 9276, 9330);

                    AssemblySymbol
                    retargetFrom = f_10603_9306_9329(type)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 9596, 9613);

                    bool
                    isLocalType
                    = default(bool);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 9633, 10005) || true) && (f_10603_9637_9711(retargetFrom, f_10603_9667_9710(f_10603_9667_9691(this))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 9633, 10005);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 9753, 9790);

                        f_10603_9753_9789(f_10603_9766_9788_M(!retargetFrom.IsLinked));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 9812, 9868);

                        isLocalType = f_10603_9826_9867(type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 9633, 10005);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 9633, 10005);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 9950, 9986);

                        isLocalType = f_10603_9964_9985(retargetFrom);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 9633, 10005);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 10025, 10137) || true) && (isLocalType)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 10025, 10137);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 10082, 10118);

                        return f_10603_10089_10117(this, type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 10025, 10137);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 10208, 10410) || true) && (f_10603_10212_10286(retargetFrom, f_10603_10242_10285(f_10603_10242_10266(this))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 10208, 10410);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 10328, 10391);

                        return f_10603_10335_10390(this, type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 10208, 10410);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 10509, 10537);

                    DestinationData
                    destination
                    = default(DestinationData);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 10557, 10749) || true) && (!f_10603_10562_10632(f_10603_10562_10589(this), retargetFrom, out destination))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 10557, 10749);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 10718, 10730);

                        return type;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 10557, 10749);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 10827, 10880);

                    type = f_10603_10834_10879(ref destination, type);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 10898, 10954);

                    f_10603_10898_10925(this)[retargetFrom] = destination;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 10972, 10984);

                    return type;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 8048, 10999);

                    bool
                    f_10603_8192_8209(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 8192, 8209);
                        return return_v;
                    }


                    int
                    f_10603_8179_8210(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 8179, 8210);
                        return 0;
                    }


                    bool
                    f_10603_8235_8259(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsNativeIntegerType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 8235, 8259);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_8342_8374(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.NativeIntegerUnderlyingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 8342, 8374);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_8314_8384(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions
                    options)
                    {
                        var return_v = this_param.RetargetNamedTypeDefinition(type, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 8314, 8384);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SpecialType
                    f_10603_8414_8432(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.SpecialType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 8414, 8432);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_8464_8488(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.AsNativeInteger();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 8464, 8488);
                        return return_v;
                    }


                    Microsoft.Cci.PrimitiveTypeCode
                    f_10603_8856_8878(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.PrimitiveTypeCode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 8856, 8878);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingAssemblySymbol
                    f_10603_9010_9029()
                    {
                        var return_v = RetargetingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 9010, 9029);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_9010_9056(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingAssemblySymbol
                    this_param, Microsoft.Cci.PrimitiveTypeCode
                    type)
                    {
                        var return_v = this_param.GetPrimitiveType(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 9010, 9056);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10603_9123_9132(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 9123, 9132);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                    f_10603_9205_9236(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type)
                    {
                        var return_v = Retarget((Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol)type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 9205, 9236);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10603_9306_9329(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 9306, 9329);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingAssemblySymbol
                    f_10603_9667_9691(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param)
                    {
                        var return_v = this_param.RetargetingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 9667, 9691);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10603_9667_9710(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.UnderlyingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 9667, 9710);
                        return return_v;
                    }


                    bool
                    f_10603_9637_9711(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    objA, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 9637, 9711);
                        return return_v;
                    }


                    bool
                    f_10603_9766_9788_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 9766, 9788);
                        return return_v;
                    }


                    int
                    f_10603_9753_9789(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 9753, 9789);
                        return 0;
                    }


                    bool
                    f_10603_9826_9867(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsExplicitDefinitionOfNoPiaLocalType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 9826, 9867);
                        return return_v;
                    }


                    bool
                    f_10603_9964_9985(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.IsLinked;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 9964, 9985);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_10089_10117(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type)
                    {
                        var return_v = this_param.RetargetNoPiaLocalType(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 10089, 10117);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingAssemblySymbol
                    f_10603_10242_10266(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param)
                    {
                        var return_v = this_param.RetargetingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 10242, 10266);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10603_10242_10285(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.UnderlyingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 10242, 10285);
                        return return_v;
                    }


                    bool
                    f_10603_10212_10286(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    objA, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 10212, 10286);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_10335_10390(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type)
                    {
                        var return_v = this_param.RetargetNamedTypeDefinitionFromUnderlyingAssembly(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 10335, 10390);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.DestinationData>
                    f_10603_10562_10589(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param)
                    {
                        var return_v = this_param.RetargetingAssemblyMap;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 10562, 10589);
                        return return_v;
                    }


                    bool
                    f_10603_10562_10632(System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.DestinationData>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    key, out Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.DestinationData
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 10562, 10632);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_10834_10879(ref Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.DestinationData
                    destination, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type)
                    {
                        var return_v = PerformTypeRetargeting(ref destination, type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 10834, 10879);
                        return return_v;
                    }


                    System.Collections.Generic.Dictionary<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.DestinationData>
                    f_10603_10898_10925(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param)
                    {
                        var return_v = this_param.RetargetingAssemblyMap;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 10898, 10925);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 8048, 10999);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 8048, 10999);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private NamedTypeSymbol RetargetNamedTypeDefinitionFromUnderlyingAssembly(NamedTypeSymbol type)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 11015, 12693);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 11211, 11246);

                    var
                    module = f_10603_11224_11245(type)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 11266, 12678) || true) && (f_10603_11270_11316(module, f_10603_11294_11315(this)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 11266, 12678);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 11358, 11392);

                        f_10603_11358_11391(f_10603_11371_11385(module) == 0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 11414, 11471);

                        f_10603_11414_11470(f_10603_11427_11469_M(!type.IsExplicitDefinitionOfNoPiaLocalType));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 11493, 11529);

                        var
                        container = f_10603_11509_11528(type)
                        ;
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 11553, 12030) || true) && ((object)container != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 11553, 12030);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 11635, 11942) || true) && (f_10603_11639_11685(container))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 11635, 11942);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 11824, 11915);

                                    return (NamedTypeSymbol)f_10603_11848_11914(f_10603_11848_11862(this), type, f_10603_11878_11913());
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 11635, 11942);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 11970, 12007);

                                container = f_10603_11982_12006(container);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 11553, 12030);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10603, 11553, 12030);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10603, 11553, 12030);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 12054, 12156);

                        return (NamedTypeSymbol)f_10603_12078_12155(f_10603_12078_12092(this), type, _retargetingModule._createRetargetingNamedType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 11266, 12678);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 11266, 12678);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 12310, 12343);

                        f_10603_12310_12342(f_10603_12323_12337(module) > 0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 12365, 12459);

                        PEModuleSymbol
                        addedModule = (PEModuleSymbol)f_10603_12410_12442(f_10603_12410_12434(this))[f_10603_12443_12457(module)]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 12481, 12564);

                        f_10603_12481_12563(f_10603_12494_12562(f_10603_12510_12541(((PEModuleSymbol)module)), f_10603_12543_12561(addedModule)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 12586, 12659);

                        return f_10603_12593_12658(type, addedModule);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 11266, 12678);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 11015, 12693);

                    Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    f_10603_11224_11245(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 11224, 11245);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    f_10603_11294_11315(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param)
                    {
                        var return_v = this_param.UnderlyingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 11294, 11315);
                        return return_v;
                    }


                    bool
                    f_10603_11270_11316(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    objA, Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 11270, 11316);
                        return return_v;
                    }


                    int
                    f_10603_11371_11385(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Ordinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 11371, 11385);
                        return return_v;
                    }


                    int
                    f_10603_11358_11391(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 11358, 11391);
                        return 0;
                    }


                    bool
                    f_10603_11427_11469_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 11427, 11469);
                        return return_v;
                    }


                    int
                    f_10603_11414_11470(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 11414, 11470);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_11509_11528(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 11509, 11528);
                        return return_v;
                    }


                    bool
                    f_10603_11639_11685(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsExplicitDefinitionOfNoPiaLocalType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 11639, 11685);
                        return return_v;
                    }


                    System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10603_11848_11862(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param)
                    {
                        var return_v = this_param.SymbolMap;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 11848, 11862);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol
                    f_10603_11878_11913()
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 11878, 11913);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10603_11848_11914(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    key, Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol
                    value)
                    {
                        var return_v = this_param.GetOrAdd((Microsoft.CodeAnalysis.CSharp.Symbol)key, (Microsoft.CodeAnalysis.CSharp.Symbol)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 11848, 11914);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_11982_12006(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 11982, 12006);
                        return return_v;
                    }


                    System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10603_12078_12092(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param)
                    {
                        var return_v = this_param.SymbolMap;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 12078, 12092);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10603_12078_12155(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    key, System.Func<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingNamedTypeSymbol>
                    valueFactory)
                    {
                        var return_v = this_param.GetOrAdd((Microsoft.CodeAnalysis.CSharp.Symbol)key, (System.Func<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>)valueFactory);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 12078, 12155);
                        return return_v;
                    }


                    int
                    f_10603_12323_12337(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Ordinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 12323, 12337);
                        return return_v;
                    }


                    int
                    f_10603_12310_12342(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 12310, 12342);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingAssemblySymbol
                    f_10603_12410_12434(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param)
                    {
                        var return_v = this_param.RetargetingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 12410, 12434);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol>
                    f_10603_12410_12442(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.Modules;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 12410, 12442);
                        return return_v;
                    }


                    int
                    f_10603_12443_12457(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Ordinal;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 12443, 12457);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PEModule
                    f_10603_12510_12541(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 12510, 12541);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PEModule
                    f_10603_12543_12561(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 12543, 12561);
                        return return_v;
                    }


                    bool
                    f_10603_12494_12562(Microsoft.CodeAnalysis.PEModule
                    objA, Microsoft.CodeAnalysis.PEModule
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 12494, 12562);
                        return return_v;
                    }


                    int
                    f_10603_12481_12563(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 12481, 12563);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_12593_12658(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    addedModule)
                    {
                        var return_v = RetargetNamedTypeDefinition((Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol)type, addedModule);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 12593, 12658);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 11015, 12693);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 11015, 12693);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private NamedTypeSymbol RetargetNoPiaLocalType(NamedTypeSymbol type)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 12709, 16588);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 12810, 12833);

                    NamedTypeSymbol
                    cached
                    = default(NamedTypeSymbol);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 12853, 12908);

                    var
                    map = f_10603_12863_12907(f_10603_12863_12887(this))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 12926, 13038) || true) && (f_10603_12930_12963(map, type, out cached))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 12926, 13038);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 13005, 13019);

                        return cached;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 12926, 13038);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 13058, 13081);

                    NamedTypeSymbol
                    result
                    = default(NamedTypeSymbol);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 13101, 16483) || true) && (f_10603_13105_13131(f_10603_13105_13126(type)) != SymbolKind.NamedType && (DynAbs.Tracing.TraceSender.Expression_True(10603, 13105, 13195) && f_10603_13180_13190(type) == 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 13101, 16483);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 13283, 13319);

                        bool
                        isInterface = f_10603_13302_13318(type)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 13341, 13362);

                        bool
                        hasGuid = false
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 13384, 13412);

                        string
                        interfaceGuid = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 13434, 13454);

                        string
                        scope = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 13478, 13658) || true) && (isInterface)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 13478, 13658);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 13587, 13635);

                            hasGuid = f_10603_13597_13634(type, out interfaceGuid);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 13478, 13658);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 13682, 13828);

                        MetadataTypeName
                        name = MetadataTypeName.FromFullName(f_10603_13736_13801(type, SymbolDisplayFormat.QualifiedNameOnlyFormat), forcedArity: f_10603_13816_13826(type))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 13850, 13875);

                        string
                        identifier = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 13899, 15862) || true) && ((object)f_10603_13911_13932(type) == (object)f_10603_13944_13979(_retargetingModule))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 13899, 15862);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 14156, 15057);
                                foreach (var attrData in f_10603_14181_14201_I(f_10603_14181_14201(type)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 14156, 15057);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 14259, 14374);

                                    int
                                    signatureIndex = f_10603_14280_14373(attrData, type, AttributeDescription.TypeIdentifierAttribute)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 14406, 15030) || true) && (signatureIndex != -1)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 14406, 15030);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 14496, 14553);

                                        f_10603_14496_14552(signatureIndex == 0 || (DynAbs.Tracing.TraceSender.Expression_False(10603, 14509, 14551) || signatureIndex == 1));

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 14589, 14957) || true) && (signatureIndex == 1 && (DynAbs.Tracing.TraceSender.Expression_True(10603, 14593, 14663) && attrData.CommonConstructorArguments.Length == 2))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 14589, 14957);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 14737, 14808);

                                            scope = f_10603_14745_14780(attrData)[0].ValueInternal as string;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 14846, 14922);

                                            identifier = f_10603_14859_14894(attrData)[1].ValueInternal as string;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 14589, 14957);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceBreak(10603, 14993, 14999);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 14406, 15030);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 14156, 15057);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10603, 1, 902);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10603, 1, 902);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 13899, 15862);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 13899, 15862);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 15155, 15251);

                            f_10603_15155_15250((object)f_10603_15176_15199(type) != (object)f_10603_15211_15249(f_10603_15211_15230()));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 15619, 15839) || true) && (!(hasGuid && (DynAbs.Tracing.TraceSender.Expression_True(10603, 15625, 15647) && isInterface)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 15619, 15839);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 15706, 15755);

                                f_10603_15706_15754(f_10603_15706_15729(type), out scope);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 15785, 15812);

                                identifier = name.FullName;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 15619, 15839);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 13899, 15862);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 15886, 16225);

                        result = f_10603_15895_16224(ref name, isInterface, f_10603_16035_16068(type), interfaceGuid, scope, identifier, f_10603_16204_16223());
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 16249, 16286);

                        f_10603_16249_16285((object)result != null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 13101, 16483);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 13101, 16483);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 16419, 16464);

                        result = f_10603_16428_16463();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 13101, 16483);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 16503, 16539);

                    cached = f_10603_16512_16538(map, type, result);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 16559, 16573);

                    return cached;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 12709, 16588);

                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingAssemblySymbol
                    f_10603_12863_12887(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param)
                    {
                        var return_v = this_param.RetargetingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 12863, 12887);
                        return return_v;
                    }


                    System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    f_10603_12863_12907(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.NoPiaUnificationMap;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 12863, 12907);
                        return return_v;
                    }


                    bool
                    f_10603_12930_12963(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    key, out Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 12930, 12963);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10603_13105_13126(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 13105, 13126);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10603_13105_13131(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 13105, 13131);
                        return return_v;
                    }


                    int
                    f_10603_13180_13190(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 13180, 13190);
                        return return_v;
                    }


                    bool
                    f_10603_13302_13318(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsInterface;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 13302, 13318);
                        return return_v;
                    }


                    bool
                    f_10603_13597_13634(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param, out string
                    guidString)
                    {
                        var return_v = this_param.GetGuidString(out guidString);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 13597, 13634);
                        return return_v;
                    }


                    string
                    f_10603_13736_13801(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
                    format)
                    {
                        var return_v = this_param.ToDisplayString(format);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 13736, 13801);
                        return return_v;
                    }


                    int
                    f_10603_13816_13826(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 13816, 13826);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    f_10603_13911_13932(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 13911, 13932);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    f_10603_13944_13979(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.UnderlyingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 13944, 13979);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                    f_10603_14181_14201(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetAttributes();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 14181, 14201);
                        return return_v;
                    }


                    int
                    f_10603_14280_14373(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    targetSymbol, Microsoft.CodeAnalysis.AttributeDescription
                    description)
                    {
                        var return_v = this_param.GetTargetAttributeSignatureIndex((Microsoft.CodeAnalysis.CSharp.Symbol)targetSymbol, description);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 14280, 14373);
                        return return_v;
                    }


                    int
                    f_10603_14496_14552(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 14496, 14552);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                    f_10603_14745_14780(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                    this_param)
                    {
                        var return_v = this_param.CommonConstructorArguments;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 14745, 14780);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                    f_10603_14859_14894(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                    this_param)
                    {
                        var return_v = this_param.CommonConstructorArguments;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 14859, 14894);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                    f_10603_14181_14201_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 14181, 14201);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10603_15176_15199(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 15176, 15199);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingAssemblySymbol
                    f_10603_15211_15230()
                    {
                        var return_v = RetargetingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 15211, 15230);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10603_15211_15249(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.UnderlyingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 15211, 15249);
                        return return_v;
                    }


                    int
                    f_10603_15155_15250(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 15155, 15250);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10603_15706_15729(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 15706, 15729);
                        return return_v;
                    }


                    bool
                    f_10603_15706_15754(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param, out string
                    guidString)
                    {
                        var return_v = this_param.GetGuidString(out guidString);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 15706, 15754);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_16035_16068(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.BaseTypeNoUseSiteDiagnostics;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 16035, 16068);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingAssemblySymbol
                    f_10603_16204_16223()
                    {
                        var return_v = RetargetingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 16204, 16223);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_15895_16224(ref Microsoft.CodeAnalysis.MetadataTypeName
                    name, bool
                    isInterface, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    baseType, string?
                    interfaceGuid, string?
                    scope, string?
                    identifier, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingAssemblySymbol
                    referringAssembly)
                    {
                        var return_v = MetadataDecoder.SubstituteNoPiaLocalType(ref name, isInterface, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)baseType, interfaceGuid, scope, identifier, (Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol)referringAssembly);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 15895, 16224);
                        return return_v;
                    }


                    int
                    f_10603_16249_16285(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 16249, 16285);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol
                    f_10603_16428_16463()
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 16428, 16463);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_16512_16538(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    key, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    value)
                    {
                        var return_v = this_param.GetOrAdd(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 16512, 16538);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 12709, 16588);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 12709, 16588);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static NamedTypeSymbol RetargetNamedTypeDefinition(PENamedTypeSymbol type, PEModuleSymbol addedModule)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10603, 16604, 18459);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 16747, 16921);

                    f_10603_16747_16920(!f_10603_16761_16802(f_10603_16761_16782(type), addedModule) && (DynAbs.Tracing.TraceSender.Expression_True(10603, 16760, 16919) && f_10603_16836_16919(f_10603_16852_16898(((PEModuleSymbol)f_10603_16869_16890(type))), f_10603_16900_16918(addedModule))));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 16941, 16959);

                    TypeSymbol
                    cached
                    = default(TypeSymbol);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 16979, 17143) || true) && (f_10603_16983_17051(addedModule.TypeHandleToTypeMap, f_10603_17027_17038(type), out cached))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 16979, 17143);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 17093, 17124);

                        return (NamedTypeSymbol)cached;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 16979, 17143);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 17163, 17186);

                    NamedTypeSymbol
                    result
                    = default(NamedTypeSymbol);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 17206, 17259);

                    NamedTypeSymbol
                    containingType = f_10603_17239_17258(type)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 17277, 17301);

                    MetadataTypeName
                    mdName
                    = default(MetadataTypeName);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 17321, 18410) || true) && ((object)containingType != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 17321, 18410);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 17557, 17657);

                        NamedTypeSymbol
                        scope = f_10603_17581_17656(containingType, addedModule)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 17681, 17764);

                        mdName = MetadataTypeName.FromTypeName(f_10603_17720_17737(type), forcedArity: f_10603_17752_17762(type));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 17786, 17832);

                        result = f_10603_17795_17831(scope, ref mdName);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 17854, 17921);

                        f_10603_17854_17920((object)result != null && (DynAbs.Tracing.TraceSender.Expression_True(10603, 17867, 17919) && f_10603_17893_17905(result) == f_10603_17909_17919(type)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 17321, 18410);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 17321, 18410);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 18003, 18112);

                        string
                        namespaceName = f_10603_18026_18111(f_10603_18026_18050(type), SymbolDisplayFormat.QualifiedNameOnlyFormat)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 18134, 18244);

                        mdName = MetadataTypeName.FromNamespaceAndTypeName(namespaceName, f_10603_18200_18217(type), forcedArity: f_10603_18232_18242(type));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 18266, 18326);

                        result = f_10603_18275_18325(addedModule, ref mdName);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 18350, 18391);

                        f_10603_18350_18390(f_10603_18363_18375(result) == f_10603_18379_18389(type));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 17321, 18410);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 18430, 18444);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10603, 16604, 18459);

                    Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    f_10603_16761_16782(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 16761, 16782);
                        return return_v;
                    }


                    bool
                    f_10603_16761_16802(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    obj)
                    {
                        var return_v = this_param.Equals((object)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 16761, 16802);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    f_10603_16869_16890(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 16869, 16890);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PEModule
                    f_10603_16852_16898(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 16852, 16898);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PEModule
                    f_10603_16900_16918(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.Module;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 16900, 16918);
                        return return_v;
                    }


                    bool
                    f_10603_16836_16919(Microsoft.CodeAnalysis.PEModule
                    objA, Microsoft.CodeAnalysis.PEModule
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 16836, 16919);
                        return return_v;
                    }


                    int
                    f_10603_16747_16920(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 16747, 16920);
                        return 0;
                    }


                    System.Reflection.Metadata.TypeDefinitionHandle
                    f_10603_17027_17038(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Handle;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 17027, 17038);
                        return return_v;
                    }


                    bool
                    f_10603_16983_17051(System.Collections.Concurrent.ConcurrentDictionary<System.Reflection.Metadata.TypeDefinitionHandle, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                    this_param, System.Reflection.Metadata.TypeDefinitionHandle
                    key, out Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 16983, 17051);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_17239_17258(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 17239, 17258);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_17581_17656(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    addedModule)
                    {
                        var return_v = RetargetNamedTypeDefinition((Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol)type, addedModule);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 17581, 17656);
                        return return_v;
                    }


                    string
                    f_10603_17720_17737(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.MetadataName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 17720, 17737);
                        return return_v;
                    }


                    int
                    f_10603_17752_17762(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 17752, 17762);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_17795_17831(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                    emittedTypeName)
                    {
                        var return_v = this_param.LookupMetadataType(ref emittedTypeName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 17795, 17831);
                        return return_v;
                    }


                    int
                    f_10603_17893_17905(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 17893, 17905);
                        return return_v;
                    }


                    int
                    f_10603_17909_17919(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 17909, 17919);
                        return return_v;
                    }


                    int
                    f_10603_17854_17920(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 17854, 17920);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    f_10603_18026_18050(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingNamespace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 18026, 18050);
                        return return_v;
                    }


                    string
                    f_10603_18026_18111(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
                    format)
                    {
                        var return_v = this_param.ToDisplayString(format);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 18026, 18111);
                        return return_v;
                    }


                    string
                    f_10603_18200_18217(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.MetadataName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 18200, 18217);
                        return return_v;
                    }


                    int
                    f_10603_18232_18242(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 18232, 18242);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_18275_18325(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
                    this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                    emittedName)
                    {
                        var return_v = this_param.LookupTopLevelMetadataType(ref emittedName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 18275, 18325);
                        return return_v;
                    }


                    int
                    f_10603_18363_18375(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 18363, 18375);
                        return return_v;
                    }


                    int
                    f_10603_18379_18389(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PENamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 18379, 18389);
                        return return_v;
                    }


                    int
                    f_10603_18350_18390(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 18350, 18390);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 16604, 18459);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 16604, 18459);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static NamedTypeSymbol PerformTypeRetargeting(
                            ref DestinationData destination,
                            NamedTypeSymbol type)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10603, 18475, 20464);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 18651, 18674);

                    NamedTypeSymbol
                    result
                    = default(NamedTypeSymbol);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 18694, 20415) || true) && (!f_10603_18699_18750(destination.SymbolMap, type, out result))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 18694, 20415);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 18845, 18898);

                        NamedTypeSymbol
                        containingType = f_10603_18878_18897(type)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 18920, 18944);

                        NamedTypeSymbol
                        result1
                        = default(NamedTypeSymbol);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 18966, 18990);

                        MetadataTypeName
                        mdName
                        = default(MetadataTypeName);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 19014, 20209) || true) && ((object)containingType != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 19014, 20209);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 19294, 19374);

                            NamedTypeSymbol
                            scope = f_10603_19318_19373(ref destination, containingType)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 19400, 19483);

                            mdName = MetadataTypeName.FromTypeName(f_10603_19439_19456(type), forcedArity: f_10603_19471_19481(type));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 19509, 19556);

                            result1 = f_10603_19519_19555(scope, ref mdName);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 19582, 19651);

                            f_10603_19582_19650((object)result1 != null && (DynAbs.Tracing.TraceSender.Expression_True(10603, 19595, 19649) && f_10603_19622_19635(result1) == f_10603_19639_19649(type)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 19014, 20209);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 19014, 20209);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 19749, 19858);

                            string
                            namespaceName = f_10603_19772_19857(f_10603_19772_19796(type), SymbolDisplayFormat.QualifiedNameOnlyFormat)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 19884, 19994);

                            mdName = MetadataTypeName.FromNamespaceAndTypeName(namespaceName, f_10603_19950_19967(type), forcedArity: f_10603_19982_19992(type));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 20020, 20116);

                            result1 = f_10603_20030_20115(destination.To, ref mdName, digThroughForwardedTypes: true);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 20144, 20186);

                            f_10603_20144_20185(f_10603_20157_20170(result1) == f_10603_20174_20184(type));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 19014, 20209);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 20233, 20288);

                        result = f_10603_20242_20287(destination.SymbolMap, type, result1);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 20310, 20396);

                        f_10603_20310_20395(f_10603_20323_20394(result1, result, TypeCompareKind.ConsiderEverything2));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 18694, 20415);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 20435, 20449);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10603, 18475, 20464);

                    bool
                    f_10603_18699_18750(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    key, out Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    value)
                    {
                        var return_v = this_param.TryGetValue(key, out value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 18699, 18750);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_18878_18897(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 18878, 18897);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_19318_19373(ref Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.DestinationData
                    destination, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type)
                    {
                        var return_v = PerformTypeRetargeting(ref destination, type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 19318, 19373);
                        return return_v;
                    }


                    string
                    f_10603_19439_19456(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.MetadataName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 19439, 19456);
                        return return_v;
                    }


                    int
                    f_10603_19471_19481(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 19471, 19481);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_19519_19555(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                    emittedTypeName)
                    {
                        var return_v = this_param.LookupMetadataType(ref emittedTypeName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 19519, 19555);
                        return return_v;
                    }


                    int
                    f_10603_19622_19635(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 19622, 19635);
                        return return_v;
                    }


                    int
                    f_10603_19639_19649(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 19639, 19649);
                        return return_v;
                    }


                    int
                    f_10603_19582_19650(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 19582, 19650);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    f_10603_19772_19796(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingNamespace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 19772, 19796);
                        return return_v;
                    }


                    string
                    f_10603_19772_19857(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
                    format)
                    {
                        var return_v = this_param.ToDisplayString(format);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 19772, 19857);
                        return return_v;
                    }


                    string
                    f_10603_19950_19967(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.MetadataName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 19950, 19967);
                        return return_v;
                    }


                    int
                    f_10603_19982_19992(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 19982, 19992);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_20030_20115(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param, ref Microsoft.CodeAnalysis.MetadataTypeName
                    emittedName, bool
                    digThroughForwardedTypes)
                    {
                        var return_v = this_param.LookupTopLevelMetadataType(ref emittedName, digThroughForwardedTypes: digThroughForwardedTypes);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 20030, 20115);
                        return return_v;
                    }


                    int
                    f_10603_20157_20170(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 20157, 20170);
                        return return_v;
                    }


                    int
                    f_10603_20174_20184(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 20174, 20184);
                        return return_v;
                    }


                    int
                    f_10603_20144_20185(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 20144, 20185);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_20242_20287(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    key, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    value)
                    {
                        var return_v = this_param.GetOrAdd(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 20242, 20287);
                        return return_v;
                    }


                    bool
                    f_10603_20323_20394(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    left, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    right, Microsoft.CodeAnalysis.TypeCompareKind
                    comparison)
                    {
                        var return_v = TypeSymbol.Equals((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)left, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)right, comparison);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 20323, 20394);
                        return return_v;
                    }


                    int
                    f_10603_20310_20395(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 20310, 20395);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 18475, 20464);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 18475, 20464);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public NamedTypeSymbol Retarget(NamedTypeSymbol type, RetargetOptions options)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 20480, 25308);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 20591, 20652);

                    NamedTypeSymbol
                    originalDefinition = f_10603_20628_20651(type)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 20672, 20761);

                    NamedTypeSymbol
                    newDefinition = f_10603_20704_20760(this, originalDefinition, options)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 20781, 20908) || true) && (f_10603_20785_20826(type, originalDefinition))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 20781, 20908);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 20868, 20889);

                        return newDefinition;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 20781, 20908);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 20928, 21088) || true) && (f_10603_20932_20950(newDefinition) == SymbolKind.ErrorType && (DynAbs.Tracing.TraceSender.Expression_True(10603, 20932, 21006) && f_10603_20978_21006_M(!newDefinition.IsGenericType)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 20928, 21088);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 21048, 21069);

                        return newDefinition;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 20928, 21088);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 21108, 21200);

                    f_10603_21108_21199(f_10603_21121_21145(originalDefinition) == 0 || (DynAbs.Tracing.TraceSender.Expression_False(10603, 21121, 21198) || !f_10603_21155_21198(f_10603_21171_21191(type), type)));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 21218, 21515) || true) && (f_10603_21222_21247(type))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 21218, 21515);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 21289, 21428) || true) && (f_10603_21293_21343(newDefinition, originalDefinition))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 21289, 21428);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 21393, 21405);

                            return type;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 21289, 21428);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 21452, 21496);

                        return f_10603_21459_21495(newDefinition);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 21218, 21515);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 21535, 21632);

                    f_10603_21535_21631((object)f_10603_21556_21575(type) == null || (DynAbs.Tracing.TraceSender.Expression_False(10603, 21548, 21630) || !f_10603_21588_21630(f_10603_21588_21607(type))));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 21736, 21771);

                    NamedTypeSymbol
                    genericType = type
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 21789, 21856);

                    var
                    oldArguments = f_10603_21808_21855()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 21874, 21922);

                    int
                    startOfNonInterfaceArguments = int.MaxValue
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 22021, 22511) || true) && ((object)genericType != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 22021, 22511);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 22097, 22321) || true) && (startOfNonInterfaceArguments == int.MaxValue && (DynAbs.Tracing.TraceSender.Expression_True(10603, 22101, 22198) && f_10603_22174_22198_M(!genericType.IsInterface)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 22097, 22321);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 22248, 22298);

                                startOfNonInterfaceArguments = f_10603_22279_22297(oldArguments);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 22097, 22321);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 22345, 22429);

                            f_10603_22345_22428(
                                                oldArguments, f_10603_22367_22427(genericType));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 22451, 22492);

                            genericType = f_10603_22465_22491(genericType);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 22021, 22511);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10603, 22021, 22511);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10603, 22021, 22511);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 22531, 22599);

                    bool
                    anythingRetargeted = !f_10603_22558_22598(originalDefinition, newDefinition)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 22662, 22747);

                    var
                    newArguments = f_10603_22681_22746(f_10603_22727_22745(oldArguments))
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 22767, 23197);
                        foreach (var arg in f_10603_22787_22799_I(oldArguments))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 22767, 23197);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 22841, 22918);

                            var
                            newArg = f_10603_22854_22917(this, arg, RetargetOptions.RetargetPrimitiveTypesByTypeCode)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 22982, 23129) || true) && (!anythingRetargeted && (DynAbs.Tracing.TraceSender.Expression_True(10603, 22986, 23030) && !newArg.IsSameAs(arg)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 22982, 23129);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 23080, 23106);

                                anythingRetargeted = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 22982, 23129);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 23153, 23178);

                            f_10603_23153_23177(
                                                newArguments, newArg);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 22767, 23197);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10603, 1, 431);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10603, 1, 431);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 23323, 23456);

                    bool
                    noPiaIllegalGenericInstantiation = f_10603_23363_23455(this, oldArguments, newArguments, startOfNonInterfaceArguments)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 23474, 23494);

                    f_10603_23474_23493(oldArguments);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 23512, 23544);

                    NamedTypeSymbol
                    constructedType
                    = default(NamedTypeSymbol);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 23564, 25006) || true) && (!anythingRetargeted)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 23564, 25006);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 23706, 23729);

                        constructedType = type;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 23564, 25006);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 23564, 25006);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 24060, 24088);

                        genericType = newDefinition;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 24110, 24226);

                        ArrayBuilder<TypeParameterSymbol>
                        newParameters = f_10603_24160_24225(f_10603_24206_24224(newArguments))
                        ;
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 24333, 24670) || true) && ((object)genericType != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 24333, 24670);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 24417, 24578) || true) && (f_10603_24421_24438(genericType) > 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 24417, 24578);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 24500, 24551);

                                    f_10603_24500_24550(newParameters, f_10603_24523_24549(genericType));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 24417, 24578);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 24606, 24647);

                                genericType = f_10603_24620_24646(genericType);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 24333, 24670);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10603, 24333, 24670);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10603, 24333, 24670);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 24694, 24750);

                        f_10603_24694_24749(f_10603_24707_24726(newParameters) == f_10603_24730_24748(newArguments));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 24774, 24873);

                        TypeMap
                        substitution = f_10603_24797_24872(f_10603_24809_24843(newParameters), f_10603_24845_24871(newArguments))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 24897, 24987);

                        constructedType = f_10603_24915_24986(f_10603_24915_24962(substitution, newDefinition), type);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 23564, 25006);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 25026, 25046);

                    f_10603_25026_25045(
                                    newArguments);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 25066, 25250) || true) && (noPiaIllegalGenericInstantiation)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 25066, 25250);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 25144, 25231);

                        return f_10603_25151_25230(_retargetingModule, constructedType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 25066, 25250);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 25270, 25293);

                    return constructedType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 20480, 25308);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_20628_20651(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 20628, 20651);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_20704_20760(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions
                    options)
                    {
                        var return_v = this_param.RetargetNamedTypeDefinition(type, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 20704, 20760);
                        return return_v;
                    }


                    bool
                    f_10603_20785_20826(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    objA, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 20785, 20826);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10603_20932_20950(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 20932, 20950);
                        return return_v;
                    }


                    bool
                    f_10603_20978_21006_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 20978, 21006);
                        return return_v;
                    }


                    int
                    f_10603_21121_21145(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 21121, 21145);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_21171_21191(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ConstructedFrom;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 21171, 21191);
                        return return_v;
                    }


                    bool
                    f_10603_21155_21198(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    objA, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 21155, 21198);
                        return return_v;
                    }


                    int
                    f_10603_21108_21199(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 21108, 21199);
                        return 0;
                    }


                    bool
                    f_10603_21222_21247(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsUnboundGenericType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 21222, 21247);
                        return return_v;
                    }


                    bool
                    f_10603_21293_21343(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    objA, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 21293, 21343);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_21459_21495(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type)
                    {
                        var return_v = type.AsUnboundGenericType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 21459, 21495);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_21556_21575(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 21556, 21575);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_21588_21607(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 21588, 21607);
                        return return_v;
                    }


                    bool
                    f_10603_21588_21630(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type)
                    {
                        var return_v = type.IsUnboundGenericType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 21588, 21630);
                        return return_v;
                    }


                    int
                    f_10603_21535_21631(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 21535, 21631);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10603_21808_21855()
                    {
                        var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 21808, 21855);
                        return return_v;
                    }


                    bool
                    f_10603_22174_22198_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 22174, 22198);
                        return return_v;
                    }


                    int
                    f_10603_22279_22297(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 22279, 22297);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10603_22367_22427(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 22367, 22427);
                        return return_v;
                    }


                    int
                    f_10603_22345_22428(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    items)
                    {
                        this_param.AddRange(items);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 22345, 22428);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                    f_10603_22465_22491(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 22465, 22491);
                        return return_v;
                    }


                    bool
                    f_10603_22558_22598(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    obj)
                    {
                        var return_v = this_param.Equals((object)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 22558, 22598);
                        return return_v;
                    }


                    int
                    f_10603_22727_22745(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 22727, 22745);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10603_22681_22746(int
                    capacity)
                    {
                        var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance(capacity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 22681, 22746);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10603_22854_22917(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    underlyingType, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions
                    options)
                    {
                        var return_v = this_param.Retarget(underlyingType, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 22854, 22917);
                        return return_v;
                    }


                    int
                    f_10603_23153_23177(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 23153, 23177);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10603_22787_22799_I(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 22787, 22799);
                        return return_v;
                    }


                    bool
                    f_10603_23363_23455(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    oldArguments, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    newArguments, int
                    startOfNonInterfaceArguments)
                    {
                        var return_v = this_param.IsNoPiaIllegalGenericInstantiation(oldArguments, newArguments, startOfNonInterfaceArguments);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 23363, 23455);
                        return return_v;
                    }


                    int
                    f_10603_23474_23493(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 23474, 23493);
                        return 0;
                    }


                    int
                    f_10603_24206_24224(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 24206, 24224);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10603_24160_24225(int
                    capacity)
                    {
                        var return_v = ArrayBuilder<TypeParameterSymbol>.GetInstance(capacity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 24160, 24225);
                        return return_v;
                    }


                    int
                    f_10603_24421_24438(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Arity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 24421, 24438);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10603_24523_24549(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 24523, 24549);
                        return return_v;
                    }


                    int
                    f_10603_24500_24550(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    items)
                    {
                        this_param.AddRange(items);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 24500, 24550);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_24620_24646(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 24620, 24646);
                        return return_v;
                    }


                    int
                    f_10603_24707_24726(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 24707, 24726);
                        return return_v;
                    }


                    int
                    f_10603_24730_24748(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 24730, 24748);
                        return return_v;
                    }


                    int
                    f_10603_24694_24749(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 24694, 24749);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10603_24809_24843(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 24809, 24843);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10603_24845_24871(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    this_param)
                    {
                        var return_v = this_param.ToImmutable();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 24845, 24871);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                    f_10603_24797_24872(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    from, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    to)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap(from, to);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 24797, 24872);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_24915_24962(Microsoft.CodeAnalysis.CSharp.Symbols.TypeMap
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    previous)
                    {
                        var return_v = this_param.SubstituteNamedType(previous);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 24915, 24962);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_24915_24986(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    original)
                    {
                        var return_v = this_param.WithTupleDataFrom(original);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 24915, 24986);
                        return return_v;
                    }


                    int
                    f_10603_25026_25045(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 25026, 25045);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NoPiaIllegalGenericInstantiationSymbol
                    f_10603_25151_25230(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol
                    exposingModule, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    underlyingSymbol)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.NoPiaIllegalGenericInstantiationSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol)exposingModule, underlyingSymbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 25151, 25230);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 20480, 25308);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 20480, 25308);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool IsNoPiaIllegalGenericInstantiation(ArrayBuilder<TypeWithAnnotations> oldArguments, ArrayBuilder<TypeWithAnnotations> newArguments, int startOfNonInterfaceArguments)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 25324, 27272);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 25622, 26051) || true) && (f_10603_25626_25691(f_10603_25626_25647(this)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 25622, 26051);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 25742, 25774);
                            for (int
        i = startOfNonInterfaceArguments
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 25733, 26032) || true) && (i < f_10603_25780_25798(oldArguments))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 25800, 25803)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 25733, 26032))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 25733, 26032);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 25853, 26009) || true) && (f_10603_25857_25912(this, oldArguments[i].Type))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 25853, 26009);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 25970, 25982);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 25853, 26009);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10603, 1, 300);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10603, 1, 300);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 25622, 26051);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 26071, 26185);

                    ImmutableArray<AssemblySymbol>
                    assembliesToEmbedTypesFrom = f_10603_26131_26184(f_10603_26131_26152(this))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 26205, 26650) || true) && (assembliesToEmbedTypesFrom.Length > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 26205, 26650);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 26297, 26329);
                            for (int
        i = startOfNonInterfaceArguments
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 26288, 26631) || true) && (i < f_10603_26335_26353(oldArguments))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 26355, 26358)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 26288, 26631))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 26288, 26631);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 26408, 26608) || true) && (f_10603_26412_26511(oldArguments[i].Type, assembliesToEmbedTypesFrom))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 26408, 26608);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 26569, 26581);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 26408, 26608);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10603, 1, 344);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10603, 1, 344);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 26205, 26650);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 26670, 26772);

                    ImmutableArray<AssemblySymbol>
                    linkedAssemblies = f_10603_26720_26771(f_10603_26720_26739())
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 26792, 27224) || true) && (f_10603_26796_26830_M(!linkedAssemblies.IsDefaultOrEmpty))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 26792, 27224);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 26881, 26913);
                            for (int
        i = startOfNonInterfaceArguments
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 26872, 27205) || true) && (i < f_10603_26919_26937(newArguments))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 26939, 26942)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 26872, 27205))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 26872, 27205);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 26992, 27182) || true) && (f_10603_26996_27085(newArguments[i].Type, linkedAssemblies))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 26992, 27182);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 27143, 27155);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 26992, 27182);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10603, 1, 334);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10603, 1, 334);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 26792, 27224);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 27244, 27257);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 25324, 27272);

                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    f_10603_25626_25647(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param)
                    {
                        var return_v = this_param.UnderlyingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 25626, 25647);
                        return return_v;
                    }


                    bool
                    f_10603_25626_25691(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainsExplicitDefinitionOfNoPiaLocalTypes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 25626, 25691);
                        return return_v;
                    }


                    int
                    f_10603_25780_25798(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 25780, 25798);
                        return return_v;
                    }


                    bool
                    f_10603_25857_25912(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    symbol)
                    {
                        var return_v = this_param.IsOrClosedOverAnExplicitLocalType(symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 25857, 25912);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    f_10603_26131_26152(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param)
                    {
                        var return_v = this_param.UnderlyingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 26131, 26152);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    f_10603_26131_26184(Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.GetAssembliesToEmbedTypesFrom();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 26131, 26184);
                        return return_v;
                    }


                    int
                    f_10603_26335_26353(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 26335, 26353);
                        return return_v;
                    }


                    bool
                    f_10603_26412_26511(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    symbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    assemblies)
                    {
                        var return_v = MetadataDecoder.IsOrClosedOverATypeFromAssemblies(symbol, assemblies);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 26412, 26511);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingAssemblySymbol
                    f_10603_26720_26739()
                    {
                        var return_v = RetargetingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 26720, 26739);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    f_10603_26720_26771(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingAssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.GetLinkedReferencedAssemblies();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 26720, 26771);
                        return return_v;
                    }


                    bool
                    f_10603_26796_26830_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 26796, 26830);
                        return return_v;
                    }


                    int
                    f_10603_26919_26937(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 26919, 26937);
                        return return_v;
                    }


                    bool
                    f_10603_26996_27085(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    symbol, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol>
                    assemblies)
                    {
                        var return_v = MetadataDecoder.IsOrClosedOverATypeFromAssemblies(symbol, assemblies);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 26996, 27085);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 25324, 27272);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 25324, 27272);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private bool IsOrClosedOverAnExplicitLocalType(TypeSymbol symbol)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 27526, 29415);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 27624, 29400);

                    switch (f_10603_27632_27643(symbol))
                    {

                        case SymbolKind.TypeParameter:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 27624, 29400);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 27741, 27754);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 27624, 29400);

                        case SymbolKind.ArrayType:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 27624, 29400);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 27830, 27910);

                            return f_10603_27837_27909(this, f_10603_27871_27908(((ArrayTypeSymbol)symbol)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 27624, 29400);

                        case SymbolKind.PointerType:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 27624, 29400);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 27988, 28072);

                            return f_10603_27995_28071(this, f_10603_28029_28070(((PointerTypeSymbol)symbol)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 27624, 29400);

                        case SymbolKind.DynamicType:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 27624, 29400);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 28150, 28163);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 27624, 29400);

                        case SymbolKind.ErrorType:
                        case SymbolKind.NamedType:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 27624, 29400);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 28289, 28329);

                            var
                            namedType = (NamedTypeSymbol)symbol
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 28355, 28632) || true) && ((object)f_10603_28367_28409(f_10603_28367_28392(symbol)) == (object)f_10603_28421_28456(_retargetingModule) && (DynAbs.Tracing.TraceSender.Expression_True(10603, 28359, 28535) && f_10603_28489_28535(namedType)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 28355, 28632);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 28593, 28605);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 28355, 28632);
                            }
                            try
                            {
                                do

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 28660, 29228);
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 28719, 29072);
                                        foreach (var argument in f_10603_28744_28802_I(f_10603_28744_28802(namedType)))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 28719, 29072);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 28868, 29041) || true) && (f_10603_28872_28920(this, argument.Type))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 28868, 29041);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 28994, 29006);

                                                return true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 28868, 29041);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 28719, 29072);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10603, 1, 354);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(10603, 1, 354);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 29104, 29141);

                                    namedType = f_10603_29116_29140(namedType);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 28660, 29228);
                                }
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 28660, 29228) || true) && ((object)namedType != null)
                                );
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(10603, 28660, 29228);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(10603, 28660, 29228);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 29256, 29269);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 27624, 29400);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 27624, 29400);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 29327, 29381);

                            throw f_10603_29333_29380(f_10603_29368_29379(symbol));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 27624, 29400);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 27526, 29415);

                    Microsoft.CodeAnalysis.SymbolKind
                    f_10603_27632_27643(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 27632, 27643);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10603_27871_27908(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ElementType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 27871, 27908);
                        return return_v;
                    }


                    bool
                    f_10603_27837_27909(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    symbol)
                    {
                        var return_v = this_param.IsOrClosedOverAnExplicitLocalType(symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 27837, 27909);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10603_28029_28070(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.PointedAtType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 28029, 28070);
                        return return_v;
                    }


                    bool
                    f_10603_27995_28071(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    symbol)
                    {
                        var return_v = this_param.IsOrClosedOverAnExplicitLocalType(symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 27995, 28071);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10603_28367_28392(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 28367, 28392);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    f_10603_28367_28409(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 28367, 28409);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    f_10603_28421_28456(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.UnderlyingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 28421, 28456);
                        return return_v;
                    }


                    bool
                    f_10603_28489_28535(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsExplicitDefinitionOfNoPiaLocalType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 28489, 28535);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10603_28744_28802(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeArgumentsWithAnnotationsNoUseSiteDiagnostics;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 28744, 28802);
                        return return_v;
                    }


                    bool
                    f_10603_28872_28920(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    symbol)
                    {
                        var return_v = this_param.IsOrClosedOverAnExplicitLocalType(symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 28872, 28920);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10603_28744_28802_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 28744, 28802);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_29116_29140(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 29116, 29140);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10603_29368_29379(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 29368, 29379);
                        return return_v;
                    }


                    System.Exception
                    f_10603_29333_29380(Microsoft.CodeAnalysis.SymbolKind
                    o)
                    {
                        var return_v = ExceptionUtilities.UnexpectedValue((object)o);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 29333, 29380);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 27526, 29415);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 27526, 29415);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public virtual TypeParameterSymbol Retarget(TypeParameterSymbol typeParameter)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 29431, 29676);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 29542, 29661);

                    return (TypeParameterSymbol)f_10603_29570_29660(f_10603_29570_29584(this), typeParameter, _retargetingModule._createRetargetingTypeParameter);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 29431, 29676);

                    System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10603_29570_29584(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param)
                    {
                        var return_v = this_param.SymbolMap;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 29570, 29584);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10603_29570_29660(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    key, System.Func<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingTypeParameterSymbol>
                    valueFactory)
                    {
                        var return_v = this_param.GetOrAdd((Microsoft.CodeAnalysis.CSharp.Symbol)key, (System.Func<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>)valueFactory);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 29570, 29660);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 29431, 29676);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 29431, 29676);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public ArrayTypeSymbol Retarget(ArrayTypeSymbol type)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 29692, 30418);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 29778, 29843);

                    TypeWithAnnotations
                    oldElement = f_10603_29811_29842(type)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 29861, 29965);

                    TypeWithAnnotations
                    newElement = f_10603_29894_29964(this, oldElement, RetargetOptions.RetargetPrimitiveTypesByTypeCode)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 29985, 30093) || true) && (oldElement.IsSameAs(newElement))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 29985, 30093);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 30062, 30074);

                        return type;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 29985, 30093);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 30113, 30267) || true) && (f_10603_30117_30131(type))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 30113, 30267);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 30173, 30248);

                        return f_10603_30180_30247(f_10603_30210_30234(this), newElement);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 30113, 30267);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 30287, 30403);

                    return f_10603_30294_30402(f_10603_30324_30348(this), newElement, f_10603_30362_30371(type), f_10603_30373_30383(type), f_10603_30385_30401(type));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 29692, 30418);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10603_29811_29842(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ElementTypeWithAnnotations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 29811, 29842);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10603_29894_29964(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    underlyingType, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions
                    options)
                    {
                        var return_v = this_param.Retarget(underlyingType, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 29894, 29964);
                        return return_v;
                    }


                    bool
                    f_10603_30117_30131(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.IsSZArray;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 30117, 30131);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingAssemblySymbol
                    f_10603_30210_30234(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param)
                    {
                        var return_v = this_param.RetargetingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 30210, 30234);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                    f_10603_30180_30247(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingAssemblySymbol
                    declaringAssembly, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    elementType)
                    {
                        var return_v = ArrayTypeSymbol.CreateSZArray((Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol)declaringAssembly, elementType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 30180, 30247);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingAssemblySymbol
                    f_10603_30324_30348(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param)
                    {
                        var return_v = this_param.RetargetingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 30324, 30348);
                        return return_v;
                    }


                    int
                    f_10603_30362_30371(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Rank;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 30362, 30371);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<int>
                    f_10603_30373_30383(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Sizes;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 30373, 30383);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<int>
                    f_10603_30385_30401(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.LowerBounds;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 30385, 30401);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                    f_10603_30294_30402(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingAssemblySymbol
                    declaringAssembly, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    elementType, int
                    rank, System.Collections.Immutable.ImmutableArray<int>
                    sizes, System.Collections.Immutable.ImmutableArray<int>
                    lowerBounds)
                    {
                        var return_v = ArrayTypeSymbol.CreateMDArray((Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol)declaringAssembly, elementType, rank, sizes, lowerBounds);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 30294, 30402);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 29692, 30418);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 29692, 30418);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal ImmutableArray<CustomModifier> RetargetModifiers(ImmutableArray<CustomModifier> oldModifiers, out bool modifiersHaveChanged)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 30434, 32184);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 30600, 30649);

                    ArrayBuilder<CustomModifier>
                    newModifiers = null
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 30678, 30683);

                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 30669, 31908) || true) && (i < oldModifiers.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 30710, 30713)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 30669, 31908))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 30669, 31908);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 30755, 30789);

                            var
                            oldModifier = oldModifiers[i]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 30811, 30898);

                            NamedTypeSymbol
                            oldModifierSymbol = f_10603_30847_30897(((CSharpCustomModifier)oldModifier))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 30920, 31030);

                            NamedTypeSymbol
                            newModifierSymbol = f_10603_30956_31029(this, oldModifierSymbol, RetargetOptions.RetargetPrimitiveTypesByName)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 31086, 31889) || true) && (!f_10603_31091_31134(newModifierSymbol, oldModifierSymbol))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 31086, 31889);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 31184, 31439) || true) && (newModifiers == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 31184, 31439);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 31266, 31343);

                                    newModifiers = f_10603_31281_31342(oldModifiers.Length);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 31373, 31412);

                                    f_10603_31373_31411(newModifiers, oldModifiers, i);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 31184, 31439);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 31467, 31712);

                                f_10603_31467_31711(
                                                        newModifiers, (DynAbs.Tracing.TraceSender.Conditional_F1(10603, 31484, 31506) || ((f_10603_31484_31506(oldModifier) && DynAbs.Tracing.TraceSender.Conditional_F2(10603, 31554, 31608)) || DynAbs.Tracing.TraceSender.Conditional_F3(10603, 31656, 31710))) ? f_10603_31554_31608(newModifierSymbol) : f_10603_31656_31710(newModifierSymbol));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 31086, 31889);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 31086, 31889);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 31762, 31889) || true) && (newModifiers != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 31762, 31889);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 31836, 31866);

                                    f_10603_31836_31865(newModifiers, oldModifier);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 31762, 31889);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 31086, 31889);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10603, 1, 1240);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10603, 1, 1240);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 31928, 32008);

                    f_10603_31928_32007(newModifiers == null || (DynAbs.Tracing.TraceSender.Expression_False(10603, 31941, 32006) || f_10603_31965_31983(newModifiers) == oldModifiers.Length));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 32026, 32072);

                    modifiersHaveChanged = (newModifiers != null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 32090, 32169);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10603, 32097, 32117) || ((modifiersHaveChanged && DynAbs.Tracing.TraceSender.Conditional_F2(10603, 32120, 32153)) || DynAbs.Tracing.TraceSender.Conditional_F3(10603, 32156, 32168))) ? f_10603_32120_32153(newModifiers) : oldModifiers;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 30434, 32184);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_30847_30897(Microsoft.CodeAnalysis.CSharp.Symbols.CSharpCustomModifier
                    this_param)
                    {
                        var return_v = this_param.ModifierSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 30847, 30897);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_30956_31029(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions
                    options)
                    {
                        var return_v = this_param.Retarget(type, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 30956, 31029);
                        return return_v;
                    }


                    bool
                    f_10603_31091_31134(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    obj)
                    {
                        var return_v = this_param.Equals((object)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 31091, 31134);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CustomModifier>
                    f_10603_31281_31342(int
                    capacity)
                    {
                        var return_v = ArrayBuilder<CustomModifier>.GetInstance(capacity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 31281, 31342);
                        return return_v;
                    }


                    int
                    f_10603_31373_31411(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CustomModifier>
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    items, int
                    length)
                    {
                        this_param.AddRange(items, length);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 31373, 31411);
                        return 0;
                    }


                    bool
                    f_10603_31484_31506(Microsoft.CodeAnalysis.CustomModifier
                    this_param)
                    {
                        var return_v = this_param.IsOptional;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 31484, 31506);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CustomModifier
                    f_10603_31554_31608(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    modifier)
                    {
                        var return_v = CSharpCustomModifier.CreateOptional(modifier);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 31554, 31608);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CustomModifier
                    f_10603_31656_31710(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    modifier)
                    {
                        var return_v = CSharpCustomModifier.CreateRequired(modifier);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 31656, 31710);
                        return return_v;
                    }


                    int
                    f_10603_31467_31711(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CustomModifier>
                    this_param, Microsoft.CodeAnalysis.CustomModifier
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 31467, 31711);
                        return 0;
                    }


                    int
                    f_10603_31836_31865(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CustomModifier>
                    this_param, Microsoft.CodeAnalysis.CustomModifier
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 31836, 31865);
                        return 0;
                    }


                    int
                    f_10603_31965_31983(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CustomModifier>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 31965, 31983);
                        return return_v;
                    }


                    int
                    f_10603_31928_32007(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 31928, 32007);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10603_32120_32153(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CustomModifier>?
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 32120, 32153);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 30434, 32184);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 30434, 32184);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public PointerTypeSymbol Retarget(PointerTypeSymbol type)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 32200, 32683);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 32290, 32357);

                    TypeWithAnnotations
                    oldPointed = f_10603_32323_32356(type)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 32375, 32479);

                    TypeWithAnnotations
                    newPointed = f_10603_32408_32478(this, oldPointed, RetargetOptions.RetargetPrimitiveTypesByTypeCode)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 32499, 32607) || true) && (oldPointed.IsSameAs(newPointed))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 32499, 32607);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 32576, 32588);

                        return type;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 32499, 32607);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 32627, 32668);

                    return f_10603_32634_32667(newPointed);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 32200, 32683);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10603_32323_32356(Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.PointedAtTypeWithAnnotations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 32323, 32356);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10603_32408_32478(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    underlyingType, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions
                    options)
                    {
                        var return_v = this_param.Retarget(underlyingType, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 32408, 32478);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                    f_10603_32634_32667(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    pointedAtType)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol(pointedAtType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 32634, 32667);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 32200, 32683);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 32200, 32683);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public FunctionPointerTypeSymbol Retarget(FunctionPointerTypeSymbol type)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 32699, 35415);
                    bool symbolModified = default(bool);
                    bool customModifiersChanged = default(bool);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 32805, 32836);

                    var
                    signature = f_10603_32821_32835(type)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 32854, 32966);

                    var
                    newReturn = f_10603_32870_32965(this, f_10603_32879_32914(signature), RetargetOptions.RetargetPrimitiveTypesByTypeCode)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 32984, 33079);

                    var
                    newRefModifiers = f_10603_33006_33078(this, f_10603_33024_33052(signature), out symbolModified)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 33097, 33189);

                    symbolModified = symbolModified || (DynAbs.Tracing.TraceSender.Expression_False(10603, 33114, 33188) || !signature.ReturnTypeWithAnnotations.IsSameAs(newReturn));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 33209, 33275);

                    var
                    newParameterTypes = ImmutableArray<TypeWithAnnotations>.Empty
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 33293, 33368);

                    ImmutableArray<ImmutableArray<CustomModifier>>
                    newParamModifiers = default
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 33388, 33430);

                    var
                    paramCount = f_10603_33405_33429(signature)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 33448, 35108) || true) && (paramCount > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 33448, 35108);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 33508, 33597);

                        var
                        newParameterTypesBuilder = f_10603_33539_33596(paramCount)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 33619, 33729);

                        var
                        newParameterCustomModifiersBuilder = f_10603_33660_33728(paramCount)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 33751, 33783);

                        bool
                        parametersModified = false
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 33807, 34470);
                            foreach (var parameter in f_10603_33833_33853_I(f_10603_33833_33853(signature)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 33807, 34470);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 33903, 34016);

                                var
                                newParameterType = f_10603_33926_34015(this, f_10603_33935_33964(parameter), RetargetOptions.RetargetPrimitiveTypesByTypeCode)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 34042, 34142);

                                var
                                newModifiers = f_10603_34061_34141(this, f_10603_34079_34107(parameter), out customModifiersChanged)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 34168, 34215);

                                f_10603_34168_34214(newParameterTypesBuilder, newParameterType);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 34241, 34294);

                                f_10603_34241_34293(newParameterCustomModifiersBuilder, newModifiers);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 34320, 34447);

                                parametersModified = parametersModified || (DynAbs.Tracing.TraceSender.Expression_False(10603, 34341, 34420) || !parameter.TypeWithAnnotations.IsSameAs(newParameterType)) || (DynAbs.Tracing.TraceSender.Expression_False(10603, 34341, 34446) || customModifiersChanged);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 33807, 34470);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10603, 1, 664);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10603, 1, 664);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 34494, 35089) || true) && (parametersModified)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 34494, 35089);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 34566, 34632);

                            newParameterTypes = f_10603_34586_34631(newParameterTypesBuilder);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 34658, 34734);

                            newParamModifiers = f_10603_34678_34733(newParameterCustomModifiersBuilder);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 34760, 34782);

                            symbolModified = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 34494, 35089);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 34494, 35089);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 34880, 34912);

                            f_10603_34880_34911(newParameterTypesBuilder);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 34938, 34980);

                            f_10603_34938_34979(newParameterCustomModifiersBuilder);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 35006, 35066);

                            newParameterTypes = f_10603_35026_35065(signature);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 34494, 35089);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 33448, 35108);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 35128, 35400) || true) && (symbolModified)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 35128, 35400);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 35188, 35287);

                        return f_10603_35195_35286(type, newReturn, newParameterTypes, newRefModifiers, newParamModifiers);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 35128, 35400);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 35128, 35400);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 35369, 35381);

                        return type;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 35128, 35400);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 32699, 35415);

                    Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                    f_10603_32821_32835(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.Signature;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 32821, 32835);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10603_32879_32914(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnTypeWithAnnotations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 32879, 32914);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10603_32870_32965(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    underlyingType, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions
                    options)
                    {
                        var return_v = this_param.Retarget(underlyingType, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 32870, 32965);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10603_33024_33052(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.RefCustomModifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 33024, 33052);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10603_33006_33078(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    oldModifiers, out bool
                    modifiersHaveChanged)
                    {
                        var return_v = this_param.RetargetModifiers(oldModifiers, out modifiersHaveChanged);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 33006, 33078);
                        return return_v;
                    }


                    int
                    f_10603_33405_33429(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ParameterCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 33405, 33429);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10603_33539_33596(int
                    capacity)
                    {
                        var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance(capacity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 33539, 33596);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>>
                    f_10603_33660_33728(int
                    capacity)
                    {
                        var return_v = ArrayBuilder<ImmutableArray<CustomModifier>>.GetInstance(capacity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 33660, 33728);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10603_33833_33853(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 33833, 33853);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10603_33935_33964(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeWithAnnotations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 33935, 33964);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10603_33926_34015(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    underlyingType, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions
                    options)
                    {
                        var return_v = this_param.Retarget(underlyingType, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 33926, 34015);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10603_34079_34107(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.RefCustomModifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 34079, 34107);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10603_34061_34141(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    oldModifiers, out bool
                    modifiersHaveChanged)
                    {
                        var return_v = this_param.RetargetModifiers(oldModifiers, out modifiersHaveChanged);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 34061, 34141);
                        return return_v;
                    }


                    int
                    f_10603_34168_34214(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 34168, 34214);
                        return 0;
                    }


                    int
                    f_10603_34241_34293(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>>
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 34241, 34293);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10603_33833_33853_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 33833, 33853);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10603_34586_34631(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 34586, 34631);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>>
                    f_10603_34678_34733(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 34678, 34733);
                        return return_v;
                    }


                    int
                    f_10603_34880_34911(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 34880, 34911);
                        return 0;
                    }


                    int
                    f_10603_34938_34979(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>>
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 34938, 34979);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10603_35026_35065(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ParameterTypesWithAnnotations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 35026, 35065);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                    f_10603_35195_35286(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    substitutedReturnType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    substitutedParameterTypes, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    refCustomModifiers, System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>>
                    paramRefCustomModifiers)
                    {
                        var return_v = this_param.SubstituteTypeSymbol(substitutedReturnType, substitutedParameterTypes, refCustomModifiers, paramRefCustomModifiers);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 35195, 35286);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 32699, 35415);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 32699, 35415);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public static ErrorTypeSymbol Retarget(ErrorTypeSymbol type)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10603, 35431, 36680);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 35659, 35711);

                    var
                    useSiteDiagnostic = f_10603_35683_35710(type)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 35729, 35831) || true) && (useSiteDiagnostic != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 35729, 35831);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 35800, 35812);

                        return type;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 35729, 35831);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 36082, 36665);

                    return
                                        ((DynAbs.Tracing.TraceSender.Conditional_F1(10603, 36111, 36144) || (((type is ExtendedErrorTypeSymbol) && DynAbs.Tracing.TraceSender.Conditional_F2(10603, 36147, 36193)) || DynAbs.Tracing.TraceSender.Conditional_F3(10603, 36196, 36225))) ? f_10603_36147_36193(((ExtendedErrorTypeSymbol)type)) : (ExtendedErrorTypeSymbol)null) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol?>(10603, 36110, 36664) ?? f_10603_36298_36664(type, f_10603_36332_36347(type), f_10603_36374_36388(type) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.DiagnosticInfo?>(10603, 36374, 36632) ?? f_10603_36392_36632(ErrorCode.ERR_ErrorInReferencedAssembly, ((DynAbs.Tracing.TraceSender.Conditional_F1(10603, 36516, 36547) || ((f_10603_36516_36539(type) != null && DynAbs.Tracing.TraceSender.Conditional_F2(10603, 36550, 36599)) || DynAbs.Tracing.TraceSender.Conditional_F3(10603, 36602, 36614))) ? f_10603_36550_36599(f_10603_36550_36582(f_10603_36550_36573(type))) : (string)null) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string?>(10603, 36515, 36631) ?? string.Empty))), true));
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10603, 35431, 36680);

                    Microsoft.CodeAnalysis.DiagnosticInfo?
                    f_10603_35683_35710(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetUseSiteDiagnostic();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 35683, 35710);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                    f_10603_36147_36193(Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.AsUnreported();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 36147, 36193);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.LookupResultKind
                    f_10603_36332_36347(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ResultKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 36332, 36347);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.DiagnosticInfo?
                    f_10603_36374_36388(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ErrorInfo;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 36374, 36388);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10603_36516_36539(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 36516, 36539);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    f_10603_36550_36573(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingAssembly;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 36550, 36573);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.AssemblyIdentity
                    f_10603_36550_36582(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol
                    this_param)
                    {
                        var return_v = this_param.Identity;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 36550, 36582);
                        return return_v;
                    }


                    string
                    f_10603_36550_36599(Microsoft.CodeAnalysis.AssemblyIdentity
                    this_param)
                    {
                        var return_v = this_param.GetDisplayName();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 36550, 36599);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                    f_10603_36392_36632(Microsoft.CodeAnalysis.CSharp.ErrorCode
                    code, params object[]
                    args)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 36392, 36632);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                    f_10603_36298_36664(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                    guessSymbol, Microsoft.CodeAnalysis.CSharp.LookupResultKind
                    resultKind, Microsoft.CodeAnalysis.DiagnosticInfo
                    errorInfo, bool
                    unreported)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)guessSymbol, resultKind, errorInfo, unreported);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 36298, 36664);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 35431, 36680);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 35431, 36680);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public ImmutableArray<Symbol> Retarget(ImmutableArray<Symbol> arr)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 36696, 37052);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 36795, 36854);

                    var
                    symbols = f_10603_36809_36853(arr.Length)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 36874, 36981);
                        foreach (var s in f_10603_36892_36895_I(arr))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 36874, 36981);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 36937, 36962);

                            f_10603_36937_36961(symbols, f_10603_36949_36960(this, s));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 36874, 36981);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10603, 1, 108);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10603, 1, 108);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 37001, 37037);

                    return f_10603_37008_37036(symbols);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 36696, 37052);

                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10603_36809_36853(int
                    capacity)
                    {
                        var return_v = ArrayBuilder<Symbol>.GetInstance(capacity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 36809, 36853);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10603_36949_36960(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    symbol)
                    {
                        var return_v = this_param.Retarget(symbol);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 36949, 36960);
                        return return_v;
                    }


                    int
                    f_10603_36937_36961(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 36937, 36961);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10603_36892_36895_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 36892, 36895);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10603_37008_37036(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbol>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 37008, 37036);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 36696, 37052);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 36696, 37052);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public ImmutableArray<NamedTypeSymbol> Retarget(ImmutableArray<NamedTypeSymbol> sequence)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 37068, 37995);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 37190, 37262);

                    var
                    result = f_10603_37203_37261(sequence.Length)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 37282, 37925);
                        foreach (var nts in f_10603_37302_37310_I(sequence))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 37282, 37925);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 37704, 37812);

                            f_10603_37704_37811(f_10603_37717_37729(nts) == TypeKind.Error || (DynAbs.Tracing.TraceSender.Expression_False(10603, 37717, 37810) || f_10603_37751_37772(nts) == Cci.PrimitiveTypeCode.NotPrimitive));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 37834, 37906);

                            f_10603_37834_37905(result, f_10603_37845_37904(this, nts, RetargetOptions.RetargetPrimitiveTypesByName));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 37282, 37925);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10603, 1, 644);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10603, 1, 644);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 37945, 37980);

                    return f_10603_37952_37979(result);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 37068, 37995);

                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    f_10603_37203_37261(int
                    capacity)
                    {
                        var return_v = ArrayBuilder<NamedTypeSymbol>.GetInstance(capacity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 37203, 37261);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.TypeKind
                    f_10603_37717_37729(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 37717, 37729);
                        return return_v;
                    }


                    Microsoft.Cci.PrimitiveTypeCode
                    f_10603_37751_37772(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.PrimitiveTypeCode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 37751, 37772);
                        return return_v;
                    }


                    int
                    f_10603_37704_37811(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 37704, 37811);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_37845_37904(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions
                    options)
                    {
                        var return_v = this_param.Retarget(type, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 37845, 37904);
                        return return_v;
                    }


                    int
                    f_10603_37834_37905(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 37834, 37905);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    f_10603_37302_37310_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 37302, 37310);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    f_10603_37952_37979(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 37952, 37979);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 37068, 37995);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 37068, 37995);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public ImmutableArray<TypeSymbol> Retarget(ImmutableArray<TypeSymbol> sequence)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 38011, 38672);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 38123, 38190);

                    var
                    result = f_10603_38136_38189(sequence.Length)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 38210, 38602);
                        foreach (var ts in f_10603_38229_38237_I(sequence))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 38210, 38602);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 38384, 38490);

                            f_10603_38384_38489(f_10603_38397_38408(ts) == TypeKind.Error || (DynAbs.Tracing.TraceSender.Expression_False(10603, 38397, 38488) || f_10603_38430_38450(ts) == Cci.PrimitiveTypeCode.NotPrimitive));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 38512, 38583);

                            f_10603_38512_38582(result, f_10603_38523_38581(this, ts, RetargetOptions.RetargetPrimitiveTypesByName));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 38210, 38602);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10603, 1, 393);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10603, 1, 393);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 38622, 38657);

                    return f_10603_38629_38656(result);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 38011, 38672);

                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                    f_10603_38136_38189(int
                    capacity)
                    {
                        var return_v = ArrayBuilder<TypeSymbol>.GetInstance(capacity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 38136, 38189);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.TypeKind
                    f_10603_38397_38408(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 38397, 38408);
                        return return_v;
                    }


                    Microsoft.Cci.PrimitiveTypeCode
                    f_10603_38430_38450(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    this_param)
                    {
                        var return_v = this_param.PrimitiveTypeCode;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 38430, 38450);
                        return return_v;
                    }


                    int
                    f_10603_38384_38489(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 38384, 38489);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10603_38523_38581(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    symbol, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions
                    options)
                    {
                        var return_v = this_param.Retarget(symbol, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 38523, 38581);
                        return return_v;
                    }


                    int
                    f_10603_38512_38582(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 38512, 38582);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                    f_10603_38229_38237_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 38229, 38237);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                    f_10603_38629_38656(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 38629, 38656);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 38011, 38672);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 38011, 38672);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public ImmutableArray<TypeWithAnnotations> Retarget(ImmutableArray<TypeWithAnnotations> sequence)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 38688, 39143);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 38818, 38894);

                    var
                    result = f_10603_38831_38893(sequence.Length)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 38914, 39073);
                        foreach (var ts in f_10603_38933_38941_I(sequence))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 38914, 39073);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 38983, 39054);

                            f_10603_38983_39053(result, f_10603_38994_39052(this, ts, RetargetOptions.RetargetPrimitiveTypesByName));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 38914, 39073);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10603, 1, 160);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10603, 1, 160);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 39093, 39128);

                    return f_10603_39100_39127(result);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 38688, 39143);

                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10603_38831_38893(int
                    capacity)
                    {
                        var return_v = ArrayBuilder<TypeWithAnnotations>.GetInstance(capacity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 38831, 38893);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10603_38994_39052(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    underlyingType, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions
                    options)
                    {
                        var return_v = this_param.Retarget(underlyingType, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 38994, 39052);
                        return return_v;
                    }


                    int
                    f_10603_38983_39053(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 38983, 39053);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10603_38933_38941_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 38933, 38941);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    f_10603_39100_39127(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 39100, 39127);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 38688, 39143);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 38688, 39143);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public ImmutableArray<TypeParameterSymbol> Retarget(ImmutableArray<TypeParameterSymbol> list)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 39159, 39570);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 39285, 39361);

                    var
                    parameters = f_10603_39302_39360(list.Length)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 39381, 39496);
                        foreach (var tps in f_10603_39401_39405_I(list))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 39381, 39496);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 39447, 39477);

                            f_10603_39447_39476(parameters, f_10603_39462_39475(this, tps));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 39381, 39496);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10603, 1, 116);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10603, 1, 116);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 39516, 39555);

                    return f_10603_39523_39554(parameters);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 39159, 39570);

                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10603_39302_39360(int
                    capacity)
                    {
                        var return_v = ArrayBuilder<TypeParameterSymbol>.GetInstance(capacity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 39302, 39360);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    f_10603_39462_39475(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    typeParameter)
                    {
                        var return_v = this_param.Retarget(typeParameter);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 39462, 39475);
                        return return_v;
                    }


                    int
                    f_10603_39447_39476(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 39447, 39476);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10603_39401_39405_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 39401, 39405);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    f_10603_39523_39554(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 39523, 39554);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 39159, 39570);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 39159, 39570);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public MethodSymbol Retarget(MethodSymbol method)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 39586, 39962);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 39668, 39746);

                    f_10603_39668_39745(f_10603_39681_39744(f_10603_39697_39720(method), f_10603_39722_39743(this)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 39764, 39829);

                    f_10603_39764_39828(f_10603_39777_39827(method, f_10603_39801_39826(method)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 39849, 39947);

                    return (MethodSymbol)f_10603_39870_39946(f_10603_39870_39884(this), method, _retargetingModule._createRetargetingMethod);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 39586, 39962);

                    Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    f_10603_39697_39720(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 39697, 39720);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    f_10603_39722_39743(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param)
                    {
                        var return_v = this_param.UnderlyingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 39722, 39743);
                        return return_v;
                    }


                    bool
                    f_10603_39681_39744(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    objA, Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 39681, 39744);
                        return return_v;
                    }


                    int
                    f_10603_39668_39745(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 39668, 39745);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10603_39801_39826(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 39801, 39826);
                        return return_v;
                    }


                    bool
                    f_10603_39777_39827(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    objA, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 39777, 39827);
                        return return_v;
                    }


                    int
                    f_10603_39764_39828(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 39764, 39828);
                        return 0;
                    }


                    System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10603_39870_39884(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param)
                    {
                        var return_v = this_param.SymbolMap;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 39870, 39884);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10603_39870_39946(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    key, System.Func<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingMethodSymbol>
                    valueFactory)
                    {
                        var return_v = this_param.GetOrAdd((Microsoft.CodeAnalysis.CSharp.Symbol)key, (System.Func<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>)valueFactory);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 39870, 39946);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 39586, 39962);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 39586, 39962);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public MethodSymbol Retarget(MethodSymbol method, IEqualityComparer<MethodSymbol> retargetedMethodComparer)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 39978, 40863);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 40118, 40324) || true) && (f_10603_40122_40185(f_10603_40138_40161(method), f_10603_40163_40184(this)) && (DynAbs.Tracing.TraceSender.Expression_True(10603, 40122, 40239) && f_10603_40189_40239(method, f_10603_40213_40238(method))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 40118, 40324);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 40281, 40305);

                        return f_10603_40288_40304(this, method);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 40118, 40324);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 40344, 40387);

                    var
                    containingType = f_10603_40365_40386(method)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 40405, 40497);

                    var
                    retargetedType = f_10603_40426_40496(this, containingType, RetargetOptions.RetargetPrimitiveTypesByName)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 40649, 40848);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10603, 40656, 40703) || ((f_10603_40656_40703(retargetedType, containingType) && DynAbs.Tracing.TraceSender.Conditional_F2(10603, 40734, 40740)) || DynAbs.Tracing.TraceSender.Conditional_F3(10603, 40771, 40847))) ? method : f_10603_40771_40847(this, method, retargetedType, retargetedMethodComparer);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 39978, 40863);

                    Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    f_10603_40138_40161(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 40138, 40161);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    f_10603_40163_40184(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param)
                    {
                        var return_v = this_param.UnderlyingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 40163, 40184);
                        return return_v;
                    }


                    bool
                    f_10603_40122_40185(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    objA, Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 40122, 40185);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10603_40213_40238(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 40213, 40238);
                        return return_v;
                    }


                    bool
                    f_10603_40189_40239(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    objA, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 40189, 40239);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10603_40288_40304(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    method)
                    {
                        var return_v = this_param.Retarget(method);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 40288, 40304);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_40365_40386(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 40365, 40386);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_40426_40496(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions
                    options)
                    {
                        var return_v = this_param.Retarget(type, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 40426, 40496);
                        return return_v;
                    }


                    bool
                    f_10603_40656_40703(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    objA, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 40656, 40703);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10603_40771_40847(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    method, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    retargetedType, System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    retargetedMethodComparer)
                    {
                        var return_v = this_param.FindMethodInRetargetedType(method, retargetedType, retargetedMethodComparer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 40771, 40847);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 39978, 40863);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 39978, 40863);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public FieldSymbol Retarget(FieldSymbol field)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 40879, 41068);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 40958, 41053);

                    return (FieldSymbol)f_10603_40978_41052(f_10603_40978_40992(this), field, _retargetingModule._createRetargetingField);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 40879, 41068);

                    System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10603_40978_40992(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param)
                    {
                        var return_v = this_param.SymbolMap;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 40978, 40992);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10603_40978_41052(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    key, System.Func<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingFieldSymbol>
                    valueFactory)
                    {
                        var return_v = this_param.GetOrAdd((Microsoft.CodeAnalysis.CSharp.Symbol)key, (System.Func<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>)valueFactory);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 40978, 41052);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 40879, 41068);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 40879, 41068);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public PropertySymbol Retarget(PropertySymbol property)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 41084, 41478);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 41172, 41252);

                    f_10603_41172_41251(f_10603_41185_41250(f_10603_41201_41226(property), f_10603_41228_41249(this)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 41270, 41339);

                    f_10603_41270_41338(f_10603_41283_41337(property, f_10603_41309_41336(property)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 41359, 41463);

                    return (PropertySymbol)f_10603_41382_41462(f_10603_41382_41396(this), property, _retargetingModule._createRetargetingProperty);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 41084, 41478);

                    Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    f_10603_41201_41226(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 41201, 41226);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    f_10603_41228_41249(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param)
                    {
                        var return_v = this_param.UnderlyingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 41228, 41249);
                        return return_v;
                    }


                    bool
                    f_10603_41185_41250(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    objA, Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 41185, 41250);
                        return return_v;
                    }


                    int
                    f_10603_41172_41251(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 41172, 41251);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10603_41309_41336(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 41309, 41336);
                        return return_v;
                    }


                    bool
                    f_10603_41283_41337(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    objA, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 41283, 41337);
                        return return_v;
                    }


                    int
                    f_10603_41270_41338(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 41270, 41338);
                        return 0;
                    }


                    System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10603_41382_41396(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param)
                    {
                        var return_v = this_param.SymbolMap;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 41382, 41396);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10603_41382_41462(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    key, System.Func<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingPropertySymbol>
                    valueFactory)
                    {
                        var return_v = this_param.GetOrAdd((Microsoft.CodeAnalysis.CSharp.Symbol)key, (System.Func<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>)valueFactory);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 41382, 41462);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 41084, 41478);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 41084, 41478);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public PropertySymbol Retarget(PropertySymbol property, IEqualityComparer<PropertySymbol> retargetedPropertyComparer)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 41494, 42409);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 41644, 41858) || true) && (f_10603_41648_41713(f_10603_41664_41689(property), f_10603_41691_41712(this)) && (DynAbs.Tracing.TraceSender.Expression_True(10603, 41648, 41771) && f_10603_41717_41771(property, f_10603_41743_41770(property))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 41644, 41858);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 41813, 41839);

                        return f_10603_41820_41838(this, property);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 41644, 41858);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 41878, 41923);

                    var
                    containingType = f_10603_41899_41922(property)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 41941, 42033);

                    var
                    retargetedType = f_10603_41962_42032(this, containingType, RetargetOptions.RetargetPrimitiveTypesByName)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 42187, 42394);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10603, 42194, 42241) || ((f_10603_42194_42241(retargetedType, containingType) && DynAbs.Tracing.TraceSender.Conditional_F2(10603, 42272, 42280)) || DynAbs.Tracing.TraceSender.Conditional_F3(10603, 42311, 42393))) ? property : f_10603_42311_42393(this, property, retargetedType, retargetedPropertyComparer);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 41494, 42409);

                    Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    f_10603_41664_41689(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 41664, 41689);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    f_10603_41691_41712(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param)
                    {
                        var return_v = this_param.UnderlyingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 41691, 41712);
                        return return_v;
                    }


                    bool
                    f_10603_41648_41713(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    objA, Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 41648, 41713);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10603_41743_41770(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 41743, 41770);
                        return return_v;
                    }


                    bool
                    f_10603_41717_41771(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    objA, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 41717, 41771);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10603_41820_41838(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    property)
                    {
                        var return_v = this_param.Retarget(property);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 41820, 41838);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_41899_41922(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 41899, 41922);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_41962_42032(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions
                    options)
                    {
                        var return_v = this_param.Retarget(type, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 41962, 42032);
                        return return_v;
                    }


                    bool
                    f_10603_42194_42241(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    objA, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 42194, 42241);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10603_42311_42393(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    property, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    retargetedType, System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                    retargetedPropertyComparer)
                    {
                        var return_v = this_param.FindPropertyInRetargetedType(property, retargetedType, retargetedPropertyComparer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 42311, 42393);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 41494, 42409);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 41494, 42409);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public EventSymbol Retarget(EventSymbol @event)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 42425, 43294);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 42505, 42783) || true) && (f_10603_42509_42572(f_10603_42525_42548(@event), f_10603_42550_42571(this)) && (DynAbs.Tracing.TraceSender.Expression_True(10603, 42509, 42626) && f_10603_42576_42626(@event, f_10603_42600_42625(@event))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 42505, 42783);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 42668, 42764);

                        return (EventSymbol)f_10603_42688_42763(f_10603_42688_42702(this), @event, _retargetingModule._createRetargetingEvent);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 42505, 42783);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 42803, 42846);

                    var
                    containingType = f_10603_42824_42845(@event)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 42864, 42956);

                    var
                    retargetedType = f_10603_42885_42955(this, containingType, RetargetOptions.RetargetPrimitiveTypesByName)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 43107, 43279);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(10603, 43114, 43161) || ((f_10603_43114_43161(retargetedType, containingType) && DynAbs.Tracing.TraceSender.Conditional_F2(10603, 43192, 43198)) || DynAbs.Tracing.TraceSender.Conditional_F3(10603, 43229, 43278))) ? @event : f_10603_43229_43278(this, @event, retargetedType);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 42425, 43294);

                    Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    f_10603_42525_42548(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 42525, 42548);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    f_10603_42550_42571(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param)
                    {
                        var return_v = this_param.UnderlyingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 42550, 42571);
                        return return_v;
                    }


                    bool
                    f_10603_42509_42572(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    objA, Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 42509, 42572);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    f_10603_42600_42625(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.OriginalDefinition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 42600, 42625);
                        return return_v;
                    }


                    bool
                    f_10603_42576_42626(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    objA, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 42576, 42626);
                        return return_v;
                    }


                    System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10603_42688_42702(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param)
                    {
                        var return_v = this_param.SymbolMap;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 42688, 42702);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbol
                    f_10603_42688_42763(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    key, System.Func<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingEventSymbol>
                    valueFactory)
                    {
                        var return_v = this_param.GetOrAdd((Microsoft.CodeAnalysis.CSharp.Symbol)key, (System.Func<Microsoft.CodeAnalysis.CSharp.Symbol, Microsoft.CodeAnalysis.CSharp.Symbol>)valueFactory);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 42688, 42763);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_42824_42845(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 42824, 42845);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_42885_42955(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions
                    options)
                    {
                        var return_v = this_param.Retarget(type, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 42885, 42955);
                        return return_v;
                    }


                    bool
                    f_10603_43114_43161(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    objA, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 43114, 43161);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    f_10603_43229_43278(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    @event, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    retargetedType)
                    {
                        var return_v = this_param.FindEventInRetargetedType(@event, retargetedType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 43229, 43278);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 42425, 43294);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 42425, 43294);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private MethodSymbol FindMethodInRetargetedType(MethodSymbol method, NamedTypeSymbol retargetedType, IEqualityComparer<MethodSymbol> retargetedMethodComparer)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 43310, 43611);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 43501, 43596);

                    return f_10603_43508_43595(this, method, retargetedType, retargetedMethodComparer);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 43310, 43611);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10603_43508_43595(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    translator, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    method, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    retargetedType, System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                    retargetedMethodComparer)
                    {
                        var return_v = RetargetedTypeMethodFinder.Find(translator, method, retargetedType, retargetedMethodComparer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 43508, 43595);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 43310, 43611);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 43310, 43611);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            private class RetargetedTypeMethodFinder : RetargetingSymbolTranslator
            {
                private RetargetedTypeMethodFinder(RetargetingModuleSymbol retargetingModule) : base(f_10603_43836_43853_C(retargetingModule))
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(10603, 43730, 43892);
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(10603, 43730, 43892);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 43730, 43892);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 43730, 43892);
                    }
                }

                public static MethodSymbol Find(RetargetingSymbolTranslator translator, MethodSymbol method, NamedTypeSymbol retargetedType, IEqualityComparer<MethodSymbol> retargetedMethodComparer)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10603, 43912, 44694);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 44135, 44315) || true) && (f_10603_44139_44162_M(!method.IsGenericMethod))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 44135, 44315);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 44212, 44292);

                            return f_10603_44219_44291(translator, method, retargetedType, retargetedMethodComparer);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 44135, 44315);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 44502, 44577);

                        var
                        finder = f_10603_44515_44576(translator._retargetingModule)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 44599, 44675);

                        return f_10603_44606_44674(finder, method, retargetedType, retargetedMethodComparer);
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10603, 43912, 44694);

                        bool
                        f_10603_44139_44162_M(bool
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 44139, 44162);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        f_10603_44219_44291(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                        translator, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        method, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        retargetedType, System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                        retargetedMethodComparer)
                        {
                            var return_v = FindWorker(translator, method, retargetedType, retargetedMethodComparer);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 44219, 44291);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator.RetargetedTypeMethodFinder
                        f_10603_44515_44576(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol
                        retargetingModule)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator.RetargetedTypeMethodFinder(retargetingModule);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 44515, 44576);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        f_10603_44606_44674(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator.RetargetedTypeMethodFinder
                        translator, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        method, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        retargetedType, System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                        retargetedMethodComparer)
                        {
                            var return_v = FindWorker((Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator)translator, method, retargetedType, retargetedMethodComparer);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 44606, 44674);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 43912, 44694);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 43912, 44694);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                private static MethodSymbol FindWorker
                                (
                                    RetargetingSymbolTranslator translator,
                                    MethodSymbol method,
                                    NamedTypeSymbol retargetedType,
                                    IEqualityComparer<MethodSymbol> retargetedMethodComparer
                                )
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10603, 44714, 47606);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 45065, 45099);

                        bool
                        modifiersHaveChanged_Ignored
                        = default(bool);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 45133, 45227);

                        var
                        targetParamsBuilder = f_10603_45159_45226(method.Parameters.Length)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 45249, 45801);
                            foreach (var param in f_10603_45271_45288_I(f_10603_45271_45288(method)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 45249, 45801);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 45338, 45778);

                                f_10603_45338_45777(targetParamsBuilder, f_10603_45392_45776(f_10603_45459_45555(translator, f_10603_45479_45504(param), RetargetOptions.RetargetPrimitiveTypesByTypeCode), f_10603_45590_45678(translator, f_10603_45619_45643(param), out modifiersHaveChanged_Ignored), f_10603_45713_45727(param), f_10603_45762_45775(param)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 45249, 45801);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10603, 1, 553);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10603, 1, 553);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 46218, 46980);

                        var
                        targetMethod = f_10603_46237_46979(f_10603_46293_46304(method), retargetedType, f_10603_46372_46389(method), f_10603_46416_46440(method), f_10603_46467_46519(f_10603_46506_46518(method)), f_10603_46546_46586(targetParamsBuilder), f_10603_46613_46627(method), f_10603_46654_46671(method), f_10603_46698_46801(translator, f_10603_46718_46750(method), RetargetOptions.RetargetPrimitiveTypesByTypeCode), f_10603_46828_46917(translator, f_10603_46857_46882(method), out modifiersHaveChanged_Ignored), ImmutableArray<MethodSymbol>.Empty)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 47004, 47551);
                            foreach (var retargetedMember in f_10603_47037_47075_I(f_10603_47037_47075(retargetedType, f_10603_47063_47074(method))))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 47004, 47551);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 47125, 47528) || true) && (f_10603_47129_47150(retargetedMember) == SymbolKind.Method)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 47125, 47528);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 47229, 47283);

                                    var
                                    retargetedMethod = (MethodSymbol)retargetedMember
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 47313, 47501) || true) && (f_10603_47317_47380(retargetedMethodComparer, retargetedMethod, targetMethod))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 47313, 47501);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 47446, 47470);

                                        return retargetedMethod;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 47313, 47501);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 47125, 47528);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 47004, 47551);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10603, 1, 548);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10603, 1, 548);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 47575, 47587);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10603, 44714, 47606);

                        Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                        f_10603_45159_45226(int
                        capacity)
                        {
                            var return_v = ArrayBuilder<ParameterSymbol>.GetInstance(capacity);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 45159, 45226);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                        f_10603_45271_45288(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.Parameters;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 45271, 45288);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        f_10603_45479_45504(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.TypeWithAnnotations;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 45479, 45504);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        f_10603_45459_45555(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        underlyingType, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions
                        options)
                        {
                            var return_v = this_param.Retarget(underlyingType, options);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 45459, 45555);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                        f_10603_45619_45643(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.RefCustomModifiers;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 45619, 45643);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                        f_10603_45590_45678(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                        this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                        oldModifiers, out bool
                        modifiersHaveChanged)
                        {
                            var return_v = this_param.RetargetModifiers(oldModifiers, out modifiersHaveChanged);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 45590, 45678);
                            return return_v;
                        }


                        bool
                        f_10603_45713_45727(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.IsParams;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 45713, 45727);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.RefKind
                        f_10603_45762_45775(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.RefKind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 45762, 45775);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.SignatureOnlyParameterSymbol
                        f_10603_45392_45776(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        type, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                        refCustomModifiers, bool
                        isParams, Microsoft.CodeAnalysis.RefKind
                        refKind)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SignatureOnlyParameterSymbol(type, refCustomModifiers, isParams, refKind);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 45392, 45776);
                            return return_v;
                        }


                        int
                        f_10603_45338_45777(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SignatureOnlyParameterSymbol
                        item)
                        {
                            this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol)item);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 45338, 45777);
                            return 0;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                        f_10603_45271_45288_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 45271, 45288);
                            return return_v;
                        }


                        string
                        f_10603_46293_46304(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.Name;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 46293, 46304);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.MethodKind
                        f_10603_46372_46389(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.MethodKind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 46372, 46389);
                            return return_v;
                        }


                        Microsoft.Cci.CallingConvention
                        f_10603_46416_46440(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.CallingConvention;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 46416, 46440);
                            return return_v;
                        }


                        int
                        f_10603_46506_46518(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.Arity;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 46506, 46518);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                        f_10603_46467_46519(int
                        count)
                        {
                            var return_v = IndexedTypeParameterSymbol.TakeSymbols(count);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 46467, 46519);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                        f_10603_46546_46586(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                        this_param)
                        {
                            var return_v = this_param.ToImmutableAndFree();
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 46546, 46586);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.RefKind
                        f_10603_46613_46627(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.RefKind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 46613, 46627);
                            return return_v;
                        }


                        bool
                        f_10603_46654_46671(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.IsInitOnly;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 46654, 46671);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        f_10603_46718_46750(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.ReturnTypeWithAnnotations;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 46718, 46750);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        f_10603_46698_46801(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        underlyingType, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions
                        options)
                        {
                            var return_v = this_param.Retarget(underlyingType, options);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 46698, 46801);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                        f_10603_46857_46882(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.RefCustomModifiers;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 46857, 46882);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                        f_10603_46828_46917(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                        this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                        oldModifiers, out bool
                        modifiersHaveChanged)
                        {
                            var return_v = this_param.RetargetModifiers(oldModifiers, out modifiersHaveChanged);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 46828, 46917);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.SignatureOnlyMethodSymbol
                        f_10603_46237_46979(string
                        name, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        containingType, Microsoft.CodeAnalysis.MethodKind
                        methodKind, Microsoft.Cci.CallingConvention
                        callingConvention, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol>
                        typeParameters, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                        parameters, Microsoft.CodeAnalysis.RefKind
                        refKind, bool
                        isInitOnly, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                        returnType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                        refCustomModifiers, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                        explicitInterfaceImplementations)
                        {
                            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SignatureOnlyMethodSymbol(name, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)containingType, methodKind, callingConvention, typeParameters, parameters, refKind, isInitOnly, returnType, refCustomModifiers, explicitInterfaceImplementations);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 46237, 46979);
                            return return_v;
                        }


                        string
                        f_10603_47063_47074(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        this_param)
                        {
                            var return_v = this_param.Name;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 47063, 47074);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                        f_10603_47037_47075(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                        this_param, string
                        name)
                        {
                            var return_v = this_param.GetMembers(name);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 47037, 47075);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.SymbolKind
                        f_10603_47129_47150(Microsoft.CodeAnalysis.CSharp.Symbol
                        this_param)
                        {
                            var return_v = this_param.Kind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 47129, 47150);
                            return return_v;
                        }


                        bool
                        f_10603_47317_47380(System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>
                        this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                        x, Microsoft.CodeAnalysis.CSharp.Symbols.SignatureOnlyMethodSymbol
                        y)
                        {
                            var return_v = this_param.Equals(x, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)y);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 47317, 47380);
                            return return_v;
                        }


                        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                        f_10603_47037_47075_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                        i)
                        {
                            var return_v = i;
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 47037, 47075);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 44714, 47606);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 44714, 47606);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                public override TypeParameterSymbol Retarget(TypeParameterSymbol typeParameter)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 47626, 48340);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 47746, 47929) || true) && (f_10603_47750_47820(f_10603_47766_47796(typeParameter), f_10603_47798_47819(this)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 47746, 47929);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 47870, 47906);

                            return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Retarget(typeParameter), 10603, 47877, 47905);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 47746, 47929);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 47953, 48027);

                        f_10603_47953_48026(f_10603_47966_47997(typeParameter) == TypeParameterKind.Method);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 48247, 48321);

                        return f_10603_48254_48320(f_10603_48298_48319(typeParameter));
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 47626, 48340);

                        Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                        f_10603_47766_47796(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.ContainingModule;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 47766, 47796);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                        f_10603_47798_47819(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator.RetargetedTypeMethodFinder
                        this_param)
                        {
                            var return_v = this_param.UnderlyingModule;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 47798, 47819);
                            return return_v;
                        }


                        bool
                        f_10603_47750_47820(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                        objA, Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                        objB)
                        {
                            var return_v = ReferenceEquals((object)objA, (object)objB);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 47750, 47820);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.TypeParameterKind
                        f_10603_47966_47997(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.TypeParameterKind;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 47966, 47997);
                            return return_v;
                        }


                        int
                        f_10603_47953_48026(bool
                        condition)
                        {
                            Debug.Assert(condition);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 47953, 48026);
                            return 0;
                        }


                        int
                        f_10603_48298_48319(Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                        this_param)
                        {
                            var return_v = this_param.Ordinal;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 48298, 48319);
                            return return_v;
                        }


                        Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                        f_10603_48254_48320(int
                        index)
                        {
                            var return_v = IndexedTypeParameterSymbol.GetTypeParameter(index);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 48254, 48320);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 47626, 48340);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 47626, 48340);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                static RetargetedTypeMethodFinder()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10603, 43627, 48355);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10603, 43627, 48355);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 43627, 48355);
                }

                int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10603, 43627, 48355);

                static Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol
                f_10603_43836_43853_C(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceBaseCall(10603, 43730, 43892);
                    return return_v;
                }

            }

            private PropertySymbol FindPropertyInRetargetedType(PropertySymbol property, NamedTypeSymbol retargetedType, IEqualityComparer<PropertySymbol> retargetedPropertyComparer)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 48371, 50404);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 48574, 48608);

                    bool
                    modifiersHaveChanged_Ignored
                    = default(bool);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 48638, 48734);

                    var
                    targetParamsBuilder = f_10603_48664_48733(property.Parameters.Length)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 48752, 49252);
                        foreach (var param in f_10603_48774_48793_I(f_10603_48774_48793(property)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 48752, 49252);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 48835, 49233);

                            f_10603_48835_49232(targetParamsBuilder, f_10603_48885_49231(f_10603_48948_49033(this, f_10603_48957_48982(param), RetargetOptions.RetargetPrimitiveTypesByTypeCode), f_10603_49064_49141(this, f_10603_49082_49106(param), out modifiersHaveChanged_Ignored), f_10603_49172_49186(param), f_10603_49217_49230(param)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 48752, 49252);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10603, 1, 501);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10603, 1, 501);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 49272, 49814);

                    var
                    targetProperty = f_10603_49293_49813(f_10603_49347_49360(property), retargetedType, f_10603_49420_49460(targetParamsBuilder), f_10603_49483_49499(property), f_10603_49522_49610(this, f_10603_49531_49559(property), RetargetOptions.RetargetPrimitiveTypesByTypeCode), f_10603_49633_49713(this, f_10603_49651_49678(property), out modifiersHaveChanged_Ignored), f_10603_49736_49753(property), ImmutableArray<PropertySymbol>.Empty)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 49834, 50357);
                        foreach (var retargetedMember in f_10603_49867_49907_I(f_10603_49867_49907(retargetedType, f_10603_49893_49906(property))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 49834, 50357);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 49949, 50338) || true) && (f_10603_49953_49974(retargetedMember) == SymbolKind.Property)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 49949, 50338);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 50047, 50105);

                                var
                                retargetedProperty = (PropertySymbol)retargetedMember
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 50131, 50315) || true) && (f_10603_50135_50204(retargetedPropertyComparer, retargetedProperty, targetProperty))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 50131, 50315);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 50262, 50288);

                                    return retargetedProperty;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 50131, 50315);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 49949, 50338);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 49834, 50357);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10603, 1, 524);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10603, 1, 524);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 50377, 50389);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 48371, 50404);

                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10603_48664_48733(int
                    capacity)
                    {
                        var return_v = ArrayBuilder<ParameterSymbol>.GetInstance(capacity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 48664, 48733);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10603_48774_48793(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.Parameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 48774, 48793);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10603_48957_48982(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeWithAnnotations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 48957, 48982);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10603_48948_49033(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    underlyingType, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions
                    options)
                    {
                        var return_v = this_param.Retarget(underlyingType, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 48948, 49033);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10603_49082_49106(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.RefCustomModifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 49082, 49106);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10603_49064_49141(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    oldModifiers, out bool
                    modifiersHaveChanged)
                    {
                        var return_v = this_param.RetargetModifiers(oldModifiers, out modifiersHaveChanged);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 49064, 49141);
                        return return_v;
                    }


                    bool
                    f_10603_49172_49186(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.IsParams;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 49172, 49186);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.RefKind
                    f_10603_49217_49230(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 49217, 49230);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SignatureOnlyParameterSymbol
                    f_10603_48885_49231(Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    type, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    refCustomModifiers, bool
                    isParams, Microsoft.CodeAnalysis.RefKind
                    refKind)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SignatureOnlyParameterSymbol(type, refCustomModifiers, isParams, refKind);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 48885, 49231);
                        return return_v;
                    }


                    int
                    f_10603_48835_49232(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SignatureOnlyParameterSymbol
                    item)
                    {
                        this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 48835, 49232);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10603_48774_48793_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 48774, 48793);
                        return return_v;
                    }


                    string
                    f_10603_49347_49360(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 49347, 49360);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    f_10603_49420_49460(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    this_param)
                    {
                        var return_v = this_param.ToImmutableAndFree();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 49420, 49460);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.RefKind
                    f_10603_49483_49499(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.RefKind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 49483, 49499);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10603_49531_49559(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.TypeWithAnnotations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 49531, 49559);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10603_49522_49610(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    underlyingType, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions
                    options)
                    {
                        var return_v = this_param.Retarget(underlyingType, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 49522, 49610);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10603_49651_49678(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.RefCustomModifiers;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 49651, 49678);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10603_49633_49713(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    oldModifiers, out bool
                    modifiersHaveChanged)
                    {
                        var return_v = this_param.RetargetModifiers(oldModifiers, out modifiersHaveChanged);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 49633, 49713);
                        return return_v;
                    }


                    bool
                    f_10603_49736_49753(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.IsStatic;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 49736, 49753);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SignatureOnlyPropertySymbol
                    f_10603_49293_49813(string
                    name, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    containingType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                    parameters, Microsoft.CodeAnalysis.RefKind
                    refKind, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    type, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    refCustomModifiers, bool
                    isStatic, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                    explicitInterfaceImplementations)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SignatureOnlyPropertySymbol(name, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)containingType, parameters, refKind, type, refCustomModifiers, isStatic, explicitInterfaceImplementations);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 49293, 49813);
                        return return_v;
                    }


                    string
                    f_10603_49893_49906(Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 49893, 49906);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10603_49867_49907(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param, string
                    name)
                    {
                        var return_v = this_param.GetMembers(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 49867, 49907);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10603_49953_49974(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 49953, 49974);
                        return return_v;
                    }


                    bool
                    f_10603_50135_50204(System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol>
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    x, Microsoft.CodeAnalysis.CSharp.Symbols.SignatureOnlyPropertySymbol
                    y)
                    {
                        var return_v = this_param.Equals(x, (Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol)y);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 50135, 50204);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10603_49867_49907_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 49867, 49907);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 48371, 50404);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 48371, 50404);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private EventSymbol FindEventInRetargetedType(EventSymbol @event, NamedTypeSymbol retargetedType)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 50420, 51254);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 50550, 50654);

                    var
                    targetType = f_10603_50567_50653(this, f_10603_50576_50602(@event), RetargetOptions.RetargetPrimitiveTypesByTypeCode)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 50674, 51207);
                        foreach (var retargetedMember in f_10603_50707_50745_I(f_10603_50707_50745(retargetedType, f_10603_50733_50744(@event))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 50674, 51207);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 50787, 51188) || true) && (f_10603_50791_50812(retargetedMember) == SymbolKind.Event)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 50787, 51188);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 50882, 50934);

                                var
                                retargetedEvent = (EventSymbol)retargetedMember
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 50960, 51165) || true) && (f_10603_50964_51057(f_10603_50982_51002(retargetedEvent), targetType.Type, TypeCompareKind.ConsiderEverything2))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 50960, 51165);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 51115, 51138);

                                    return retargetedEvent;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 50960, 51165);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 50787, 51188);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 50674, 51207);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10603, 1, 534);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10603, 1, 534);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 51227, 51239);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 50420, 51254);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10603_50576_50602(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.TypeWithAnnotations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 50576, 50602);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    f_10603_50567_50653(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    underlyingType, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions
                    options)
                    {
                        var return_v = this_param.Retarget(underlyingType, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 50567, 50653);
                        return return_v;
                    }


                    string
                    f_10603_50733_50744(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.Name;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 50733, 50744);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10603_50707_50745(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param, string
                    name)
                    {
                        var return_v = this_param.GetMembers(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 50707, 50745);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SymbolKind
                    f_10603_50791_50812(Microsoft.CodeAnalysis.CSharp.Symbol
                    this_param)
                    {
                        var return_v = this_param.Kind;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 50791, 50812);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10603_50982_51002(Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 50982, 51002);
                        return return_v;
                    }


                    bool
                    f_10603_50964_51057(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    right, Microsoft.CodeAnalysis.TypeCompareKind
                    comparison)
                    {
                        var return_v = TypeSymbol.Equals(left, right, comparison);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 50964, 51057);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                    f_10603_50707_50745_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbol>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 50707, 50745);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 50420, 51254);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 50420, 51254);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal ImmutableArray<CustomModifier> RetargetModifiers(
                            ImmutableArray<CustomModifier> oldModifiers,
                            ref ImmutableArray<CustomModifier> lazyCustomModifiers)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 51270, 51959);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 51496, 51897) || true) && (lazyCustomModifiers.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 51496, 51897);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 51571, 51597);

                        bool
                        modifiersHaveChanged
                        = default(bool);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 51619, 51728);

                        ImmutableArray<CustomModifier>
                        newModifiers = f_10603_51665_51727(this, oldModifiers, out modifiersHaveChanged)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 51750, 51878);

                        f_10603_51750_51877(ref lazyCustomModifiers, newModifiers, default(ImmutableArray<CustomModifier>));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 51496, 51897);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 51917, 51944);

                    return lazyCustomModifiers;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 51270, 51959);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10603_51665_51727(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    oldModifiers, out bool
                    modifiersHaveChanged)
                    {
                        var return_v = this_param.RetargetModifiers(oldModifiers, out modifiersHaveChanged);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 51665, 51727);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    f_10603_51750_51877(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    value, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
                    comparand)
                    {
                        var return_v = ImmutableInterlocked.InterlockedCompareExchange(ref location, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 51750, 51877);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 51270, 51959);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 51270, 51959);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private ImmutableArray<CSharpAttributeData> RetargetAttributes(ImmutableArray<CSharpAttributeData> oldAttributes)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 51975, 52215);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 52121, 52200);

                    return oldAttributes.SelectAsArray((a, t) => t.RetargetAttributeData(a), this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 51975, 52215);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 51975, 52215);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 51975, 52215);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal IEnumerable<CSharpAttributeData> RetargetAttributes(IEnumerable<CSharpAttributeData> attributes)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 52231, 52802);

                    var listYield = new List<CSharpAttributeData>();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 52380, 52414);

                    SynthesizedAttributeData
                    x = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 52432, 52458);

                    SourceAttributeData
                    y = x
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 52573, 52605);

                    x = (SynthesizedAttributeData)y;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 52631, 52787);
                        foreach (var attributeData in f_10603_52661_52671_I(attributes))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 52631, 52787);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 52713, 52768);

                            listYield.Add(f_10603_52726_52767(this, attributeData));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 52631, 52787);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(10603, 1, 157);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(10603, 1, 157);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 52231, 52802);

                    return listYield;

                    Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                    f_10603_52726_52767(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData
                    oldAttributeData)
                    {
                        var return_v = this_param.RetargetAttributeData(oldAttributeData);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 52726, 52767);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                    f_10603_52661_52671_I(System.Collections.Generic.IEnumerable<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 52661, 52671);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 52231, 52802);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 52231, 52802);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private CSharpAttributeData RetargetAttributeData(CSharpAttributeData oldAttributeData)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 52818, 55220);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 52938, 53011);

                    SourceAttributeData
                    oldAttribute = (SourceAttributeData)oldAttributeData
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 53031, 53097);

                    MethodSymbol
                    oldAttributeCtor = f_10603_53063_53096(oldAttribute)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 53115, 53324);

                    MethodSymbol
                    newAttributeCtor = (DynAbs.Tracing.TraceSender.Conditional_F1(10603, 53147, 53179) || (((object)oldAttributeCtor == null && DynAbs.Tracing.TraceSender.Conditional_F2(10603, 53203, 53207)) || DynAbs.Tracing.TraceSender.Conditional_F3(10603, 53231, 53323))) ? null : f_10603_53231_53323(this, oldAttributeCtor, MemberSignatureComparer.RetargetedExplicitImplementationComparer)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 53344, 53407);

                    NamedTypeSymbol
                    oldAttributeType = f_10603_53379_53406(oldAttribute)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 53425, 53458);

                    NamedTypeSymbol
                    newAttributeType
                    = default(NamedTypeSymbol);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 53476, 53946) || true) && ((object)newAttributeCtor != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 53476, 53946);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 53554, 53605);

                        newAttributeType = f_10603_53573_53604(newAttributeCtor);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 53476, 53946);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 53476, 53946);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 53647, 53946) || true) && ((object)oldAttributeType != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 53647, 53946);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 53725, 53821);

                            newAttributeType = f_10603_53744_53820(this, oldAttributeType, RetargetOptions.RetargetPrimitiveTypesByTypeCode);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 53647, 53946);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 53647, 53946);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 53903, 53927);

                            newAttributeType = null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 53647, 53946);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 53476, 53946);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 53966, 54064);

                    ImmutableArray<TypedConstant>
                    oldAttributeCtorArguments = f_10603_54024_54063(oldAttribute)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 54082, 54205);

                    ImmutableArray<TypedConstant>
                    newAttributeCtorArguments = f_10603_54140_54204(this, oldAttributeCtorArguments)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 54225, 54340);

                    ImmutableArray<KeyValuePair<string, TypedConstant>>
                    oldAttributeNamedArguments = f_10603_54306_54339(oldAttribute)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 54358, 54499);

                    ImmutableArray<KeyValuePair<string, TypedConstant>>
                    newAttributeNamedArguments = f_10603_54439_54498(this, oldAttributeNamedArguments)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 54759, 55205);

                    return f_10603_54766_55204(f_10603_54817_54856(oldAttribute), newAttributeType, newAttributeCtor, newAttributeCtorArguments, f_10603_55005_55051(oldAttribute), newAttributeNamedArguments, f_10603_55123_55145(oldAttribute), f_10603_55168_55203(oldAttribute));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 52818, 55220);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    f_10603_53063_53096(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
                    this_param)
                    {
                        var return_v = this_param.AttributeConstructor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 53063, 53096);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10603_53231_53323(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    method, Microsoft.CodeAnalysis.CSharp.Symbols.MemberSignatureComparer
                    retargetedMethodComparer)
                    {
                        var return_v = this_param.Retarget(method, (System.Collections.Generic.IEqualityComparer<Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol>)retargetedMethodComparer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 53231, 53323);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_53379_53406(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
                    this_param)
                    {
                        var return_v = this_param.AttributeClass;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 53379, 53406);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_53573_53604(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    this_param)
                    {
                        var return_v = this_param.ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 53573, 53604);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_53744_53820(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions
                    options)
                    {
                        var return_v = this_param.Retarget(type, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 53744, 53820);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                    f_10603_54024_54063(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
                    this_param)
                    {
                        var return_v = this_param.CommonConstructorArguments;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 54024, 54063);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                    f_10603_54140_54204(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                    constructorArguments)
                    {
                        var return_v = this_param.RetargetAttributeConstructorArguments(constructorArguments);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 54140, 54204);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                    f_10603_54306_54339(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
                    this_param)
                    {
                        var return_v = this_param.CommonNamedArguments;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 54306, 54339);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                    f_10603_54439_54498(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                    namedArguments)
                    {
                        var return_v = this_param.RetargetAttributeNamedArguments(namedArguments);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 54439, 54498);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.SyntaxReference?
                    f_10603_54817_54856(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
                    this_param)
                    {
                        var return_v = this_param.ApplicationSyntaxReference;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 54817, 54856);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<int>
                    f_10603_55005_55051(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
                    this_param)
                    {
                        var return_v = this_param.ConstructorArgumentsSourceIndices;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 55005, 55051);
                        return return_v;
                    }


                    bool
                    f_10603_55123_55145(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
                    this_param)
                    {
                        var return_v = this_param.HasErrors;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 55123, 55145);
                        return return_v;
                    }


                    bool
                    f_10603_55168_55203(Microsoft.CodeAnalysis.CSharp.Symbols.SourceAttributeData
                    this_param)
                    {
                        var return_v = this_param.IsConditionallyOmitted;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 55168, 55203);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingAttributeData
                    f_10603_54766_55204(Microsoft.CodeAnalysis.SyntaxReference?
                    applicationNode, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                    attributeClass, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                    attributeConstructor, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                    constructorArguments, System.Collections.Immutable.ImmutableArray<int>
                    constructorArgumentsSourceIndices, System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                    namedArguments, bool
                    hasErrors, bool
                    isConditionallyOmitted)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingAttributeData(applicationNode, attributeClass, attributeConstructor, constructorArguments, constructorArgumentsSourceIndices, namedArguments, hasErrors, isConditionallyOmitted);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 54766, 55204);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 52818, 55220);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 52818, 55220);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private ImmutableArray<TypedConstant> RetargetAttributeConstructorArguments(ImmutableArray<TypedConstant> constructorArguments)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 55236, 56345);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 55396, 55469);

                    ImmutableArray<TypedConstant>
                    retargetedArguments = constructorArguments
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 55487, 55521);

                    bool
                    argumentsHaveChanged = false
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 55541, 56283) || true) && (f_10603_55545_55576_M(!constructorArguments.IsDefault) && (DynAbs.Tracing.TraceSender.Expression_True(10603, 55545, 55606) && constructorArguments.Any()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 55541, 56283);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 55648, 55736);

                        var
                        newArguments = f_10603_55667_55735(constructorArguments.Length)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 55760, 56050);
                            foreach (TypedConstant oldArgument in f_10603_55798_55818_I(constructorArguments))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 55760, 56050);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 55868, 55964);

                                TypedConstant
                                retargetedArgument = f_10603_55903_55963(this, oldArgument, ref argumentsHaveChanged)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 55990, 56027);

                                f_10603_55990_56026(newArguments, retargetedArgument);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 55760, 56050);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10603, 1, 291);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10603, 1, 291);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 56074, 56220) || true) && (argumentsHaveChanged)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 56074, 56220);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 56148, 56197);

                            retargetedArguments = f_10603_56170_56196(newArguments);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 56074, 56220);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 56244, 56264);

                        f_10603_56244_56263(
                                            newArguments);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 55541, 56283);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 56303, 56330);

                    return retargetedArguments;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 55236, 56345);

                    bool
                    f_10603_55545_55576_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 55545, 55576);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.TypedConstant>
                    f_10603_55667_55735(int
                    capacity)
                    {
                        var return_v = ArrayBuilder<TypedConstant>.GetInstance(capacity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 55667, 55735);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.TypedConstant
                    f_10603_55903_55963(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.TypedConstant
                    oldConstant, ref bool
                    typedConstantChanged)
                    {
                        var return_v = this_param.RetargetTypedConstant(oldConstant, ref typedConstantChanged);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 55903, 55963);
                        return return_v;
                    }


                    int
                    f_10603_55990_56026(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.TypedConstant>
                    this_param, Microsoft.CodeAnalysis.TypedConstant
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 55990, 56026);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                    f_10603_55798_55818_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 55798, 55818);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                    f_10603_56170_56196(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.TypedConstant>
                    this_param)
                    {
                        var return_v = this_param.ToImmutable();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 56170, 56196);
                        return return_v;
                    }


                    int
                    f_10603_56244_56263(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.TypedConstant>
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 56244, 56263);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 55236, 56345);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 55236, 56345);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private TypedConstant RetargetTypedConstant(TypedConstant oldConstant, ref bool typedConstantChanged)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 56361, 58368);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 56495, 56561);

                    TypeSymbol
                    oldConstantType = (TypeSymbol)oldConstant.TypeInternal
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 56579, 56767);

                    TypeSymbol
                    newConstantType = (DynAbs.Tracing.TraceSender.Conditional_F1(10603, 56608, 56639) || (((object)oldConstantType == null && DynAbs.Tracing.TraceSender.Conditional_F2(10603, 56663, 56667)) || DynAbs.Tracing.TraceSender.Conditional_F3(10603, 56691, 56766))) ? null : f_10603_56691_56766(this, oldConstantType, RetargetOptions.RetargetPrimitiveTypesByTypeCode)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 56787, 57413) || true) && (oldConstant.Kind == TypedConstantKind.Array)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 56787, 57413);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 56876, 56949);

                        var
                        newArray = f_10603_56891_56948(this, oldConstant.Values)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 56971, 57394) || true) && (!f_10603_56976_57064(newConstantType, oldConstantType, TypeCompareKind.ConsiderEverything2) || (DynAbs.Tracing.TraceSender.Expression_False(10603, 56975, 57098) || newArray != oldConstant.Values))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 56971, 57394);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 57148, 57176);

                            typedConstantChanged = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 57202, 57254);

                            return f_10603_57209_57253(newConstantType, newArray);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 56971, 57394);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 56971, 57394);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 57352, 57371);

                            return oldConstant;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 56971, 57394);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 56787, 57413);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 57433, 57457);

                    object
                    newConstantValue
                    = default(object);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 57475, 57527);

                    object
                    oldConstantValue = oldConstant.ValueInternal
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 57545, 57910) || true) && ((oldConstant.Kind == TypedConstantKind.Type) && (DynAbs.Tracing.TraceSender.Expression_True(10603, 57549, 57623) && (oldConstantValue != null)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 57545, 57910);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 57665, 57773);

                        newConstantValue = f_10603_57684_57772(this, oldConstantValue, RetargetOptions.RetargetPrimitiveTypesByTypeCode);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 57545, 57910);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 57545, 57910);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 57855, 57891);

                        newConstantValue = oldConstantValue;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 57545, 57910);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 57930, 58353) || true) && (!f_10603_57935_58023(newConstantType, oldConstantType, TypeCompareKind.ConsiderEverything2) || (DynAbs.Tracing.TraceSender.Expression_False(10603, 57934, 58063) || newConstantValue != oldConstantValue))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 57930, 58353);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 58105, 58133);

                        typedConstantChanged = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 58155, 58233);

                        return f_10603_58162_58232(newConstantType, oldConstant.Kind, newConstantValue);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 57930, 58353);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 57930, 58353);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 58315, 58334);

                        return oldConstant;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 57930, 58353);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 56361, 58368);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10603_56691_56766(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    symbol, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions
                    options)
                    {
                        var return_v = this_param.Retarget(symbol, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 56691, 56766);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                    f_10603_56891_56948(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                    constructorArguments)
                    {
                        var return_v = this_param.RetargetAttributeConstructorArguments(constructorArguments);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 56891, 56948);
                        return return_v;
                    }


                    bool
                    f_10603_56976_57064(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    right, Microsoft.CodeAnalysis.TypeCompareKind
                    comparison)
                    {
                        var return_v = TypeSymbol.Equals(left, right, comparison);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 56976, 57064);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.TypedConstant
                    f_10603_57209_57253(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    type, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                    array)
                    {
                        var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal?)type, array);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 57209, 57253);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10603_57684_57772(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, object
                    symbol, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions
                    options)
                    {
                        var return_v = this_param.Retarget((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)symbol, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 57684, 57772);
                        return return_v;
                    }


                    bool
                    f_10603_57935_58023(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    right, Microsoft.CodeAnalysis.TypeCompareKind
                    comparison)
                    {
                        var return_v = TypeSymbol.Equals(left, right, comparison);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 57935, 58023);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.TypedConstant
                    f_10603_58162_58232(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                    type, Microsoft.CodeAnalysis.TypedConstantKind
                    kind, object?
                    value)
                    {
                        var return_v = new Microsoft.CodeAnalysis.TypedConstant((Microsoft.CodeAnalysis.Symbols.ITypeSymbolInternal?)type, kind, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 58162, 58232);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 56361, 58368);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 56361, 58368);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private ImmutableArray<KeyValuePair<string, TypedConstant>> RetargetAttributeNamedArguments(ImmutableArray<KeyValuePair<string, TypedConstant>> namedArguments)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 58384, 59973);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 58576, 58617);

                    var
                    retargetedArguments = namedArguments
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 58635, 58669);

                    bool
                    argumentsHaveChanged = false
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 58689, 59911) || true) && (namedArguments.Any())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 58689, 59911);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 58755, 58859);

                        var
                        newArguments = f_10603_58774_58858(namedArguments.Length)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 58883, 59678);
                            foreach (KeyValuePair<string, TypedConstant> oldArgument in f_10603_58943_58957_I(namedArguments))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 58883, 59678);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 59007, 59053);

                                TypedConstant
                                oldConstant = oldArgument.Value
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 59079, 59113);

                                bool
                                typedConstantChanged = false
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 59139, 59228);

                                TypedConstant
                                newConstant = f_10603_59167_59227(this, oldConstant, ref typedConstantChanged)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 59256, 59655) || true) && (typedConstantChanged)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 59256, 59655);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 59338, 59426);

                                    f_10603_59338_59425(newArguments, f_10603_59355_59424(oldArgument.Key, newConstant));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 59456, 59484);

                                    argumentsHaveChanged = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 59256, 59655);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 59256, 59655);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 59598, 59628);

                                    f_10603_59598_59627(newArguments, oldArgument);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 59256, 59655);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 58883, 59678);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(10603, 1, 796);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(10603, 1, 796);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 59702, 59848) || true) && (argumentsHaveChanged)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 59702, 59848);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 59776, 59825);

                            retargetedArguments = f_10603_59798_59824(newArguments);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 59702, 59848);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 59872, 59892);

                        f_10603_59872_59891(
                                            newArguments);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 58689, 59911);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 59931, 59958);

                    return retargetedArguments;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 58384, 59973);

                    Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                    f_10603_58774_58858(int
                    capacity)
                    {
                        var return_v = ArrayBuilder<KeyValuePair<string, TypedConstant>>.GetInstance(capacity);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 58774, 58858);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.TypedConstant
                    f_10603_59167_59227(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.TypedConstant
                    oldConstant, ref bool
                    typedConstantChanged)
                    {
                        var return_v = this_param.RetargetTypedConstant(oldConstant, ref typedConstantChanged);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 59167, 59227);
                        return return_v;
                    }


                    System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>
                    f_10603_59355_59424(string
                    key, Microsoft.CodeAnalysis.TypedConstant
                    value)
                    {
                        var return_v = new System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>(key, value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 59355, 59424);
                        return return_v;
                    }


                    int
                    f_10603_59338_59425(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                    this_param, System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 59338, 59425);
                        return 0;
                    }


                    int
                    f_10603_59598_59627(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                    this_param, System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 59598, 59627);
                        return 0;
                    }


                    System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                    f_10603_58943_58957_I(System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 58943, 58957);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                    f_10603_59798_59824(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                    this_param)
                    {
                        var return_v = this_param.ToImmutable();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 59798, 59824);
                        return return_v;
                    }


                    int
                    f_10603_59872_59891(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                    this_param)
                    {
                        this_param.Free();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 59872, 59891);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 58384, 59973);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 58384, 59973);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal ImmutableArray<CSharpAttributeData> GetRetargetedAttributes(
                            ImmutableArray<CSharpAttributeData> underlyingAttributes,
                            ref ImmutableArray<CSharpAttributeData> lazyCustomAttributes)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 60035, 60768);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 60291, 60705) || true) && (lazyCustomAttributes.IsDefault)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10603, 60291, 60705);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 60415, 60520);

                        ImmutableArray<CSharpAttributeData>
                        retargetedAttributes = f_10603_60474_60519(this, underlyingAttributes)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 60544, 60686);

                        f_10603_60544_60685(ref lazyCustomAttributes, retargetedAttributes, default(ImmutableArray<CSharpAttributeData>));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10603, 60291, 60705);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 60725, 60753);

                    return lazyCustomAttributes;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 60035, 60768);

                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                    f_10603_60474_60519(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                    oldAttributes)
                    {
                        var return_v = this_param.RetargetAttributes(oldAttributes);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 60474, 60519);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                    f_10603_60544_60685(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                    location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                    value, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.CSharpAttributeData>
                    comparand)
                    {
                        var return_v = ImmutableInterlocked.InterlockedCompareExchange(ref location, value, comparand);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 60544, 60685);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 60035, 60768);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 60035, 60768);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Symbol VisitModule(ModuleSymbol symbol, RetargetOptions options)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 60784, 61117);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 60983, 61058);

                    f_10603_60983_61057(f_10603_60996_61056(symbol, f_10603_61020_61055(_retargetingModule)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 61076, 61102);

                    return _retargetingModule;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 60784, 61117);

                    Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    f_10603_61020_61055(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol
                    this_param)
                    {
                        var return_v = this_param.UnderlyingModule;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 61020, 61055);
                        return return_v;
                    }


                    bool
                    f_10603_60996_61056(Microsoft.CodeAnalysis.CSharp.Symbols.ModuleSymbol
                    objA, Microsoft.CodeAnalysis.CSharp.Symbols.SourceModuleSymbol
                    objB)
                    {
                        var return_v = ReferenceEquals((object)objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 60996, 61056);
                        return return_v;
                    }


                    int
                    f_10603_60983_61057(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 60983, 61057);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 60784, 61117);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 60784, 61117);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Symbol VisitNamespace(NamespaceSymbol symbol, RetargetOptions options)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 61133, 61291);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 61252, 61276);

                    return f_10603_61259_61275(this, symbol);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 61133, 61291);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    f_10603_61259_61275(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    ns)
                    {
                        var return_v = this_param.Retarget(ns);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 61259, 61275);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 61133, 61291);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 61133, 61291);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Symbol VisitNamedType(NamedTypeSymbol symbol, RetargetOptions options)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 61307, 61474);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 61426, 61459);

                    return f_10603_61433_61458(this, symbol, options);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 61307, 61474);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10603_61433_61458(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    type, Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetOptions
                    options)
                    {
                        var return_v = this_param.Retarget(type, options);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 61433, 61458);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 61307, 61474);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 61307, 61474);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Symbol VisitArrayType(ArrayTypeSymbol symbol, RetargetOptions options)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 61490, 61648);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 61609, 61633);

                    return f_10603_61616_61632(this, symbol);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 61490, 61648);

                    Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                    f_10603_61616_61632(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                    type)
                    {
                        var return_v = this_param.Retarget(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 61616, 61632);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 61490, 61648);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 61490, 61648);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Symbol VisitPointerType(PointerTypeSymbol symbol, RetargetOptions options)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 61664, 61826);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 61787, 61811);

                    return f_10603_61794_61810(this, symbol);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 61664, 61826);

                    Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                    f_10603_61794_61810(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PointerTypeSymbol
                    type)
                    {
                        var return_v = this_param.Retarget(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 61794, 61810);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 61664, 61826);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 61664, 61826);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Symbol VisitFunctionPointerType(FunctionPointerTypeSymbol symbol, RetargetOptions argument)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 61842, 62021);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 61982, 62006);

                    return f_10603_61989_62005(this, symbol);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 61842, 62021);

                    Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                    f_10603_61989_62005(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                    type)
                    {
                        var return_v = this_param.Retarget(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 61989, 62005);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 61842, 62021);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 61842, 62021);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Symbol VisitMethod(MethodSymbol symbol, RetargetOptions options)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 62037, 62189);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 62150, 62174);

                    return f_10603_62157_62173(this, symbol);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 62037, 62189);

                    Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    f_10603_62157_62173(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                    method)
                    {
                        var return_v = this_param.Retarget(method);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 62157, 62173);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 62037, 62189);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 62037, 62189);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Symbol VisitParameter(ParameterSymbol symbol, RetargetOptions options)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 62205, 62376);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 62324, 62361);

                    throw f_10603_62330_62360();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 62205, 62376);

                    System.Exception
                    f_10603_62330_62360()
                    {
                        var return_v = ExceptionUtilities.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10603, 62330, 62360);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 62205, 62376);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 62205, 62376);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Symbol VisitField(FieldSymbol symbol, RetargetOptions options)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 62392, 62542);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 62503, 62527);

                    return f_10603_62510_62526(this, symbol);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 62392, 62542);

                    Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    f_10603_62510_62526(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FieldSymbol
                    field)
                    {
                        var return_v = this_param.Retarget(field);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 62510, 62526);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 62392, 62542);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 62392, 62542);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Symbol VisitProperty(PropertySymbol symbol, RetargetOptions argument)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 62558, 62715);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 62676, 62700);

                    return f_10603_62683_62699(this, symbol);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 62558, 62715);

                    Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    f_10603_62683_62699(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.PropertySymbol
                    property)
                    {
                        var return_v = this_param.Retarget(property);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 62683, 62699);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 62558, 62715);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 62558, 62715);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Symbol VisitTypeParameter(TypeParameterSymbol symbol, RetargetOptions options)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 62731, 62897);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 62858, 62882);

                    return f_10603_62865_62881(this, symbol);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 62731, 62897);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    f_10603_62865_62881(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeParameterSymbol
                    typeParameter)
                    {
                        var return_v = this_param.Retarget(typeParameter);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 62865, 62881);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 62731, 62897);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 62731, 62897);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Symbol VisitErrorType(ErrorTypeSymbol symbol, RetargetOptions options)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 62913, 63071);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 63032, 63056);

                    return f_10603_63039_63055(symbol);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 62913, 63071);

                    Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                    f_10603_63039_63055(Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                    type)
                    {
                        var return_v = Retarget(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 63039, 63055);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 62913, 63071);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 62913, 63071);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Symbol VisitEvent(EventSymbol symbol, RetargetOptions options)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 63087, 63237);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 63198, 63222);

                    return f_10603_63205_63221(this, symbol);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 63087, 63237);

                    Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    f_10603_63205_63221(Microsoft.CodeAnalysis.CSharp.Symbols.Retargeting.RetargetingModuleSymbol.RetargetingSymbolTranslator
                    this_param, Microsoft.CodeAnalysis.CSharp.Symbols.EventSymbol
                    @event)
                    {
                        var return_v = this_param.Retarget(@event);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 63205, 63221);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 63087, 63237);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 63087, 63237);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override Symbol VisitDynamicType(DynamicTypeSymbol symbol, RetargetOptions argument)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10603, 63253, 63475);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10603, 63446, 63460);

                    return symbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10603, 63253, 63475);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10603, 63253, 63475);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 63253, 63475);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static RetargetingSymbolTranslator()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10603, 3728, 63486);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10603, 3728, 63486);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10603, 3728, 63486);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10603, 3728, 63486);

            int
            f_10603_4041_4088(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10603, 4041, 4088);
                return 0;
            }

        }
    }
}
