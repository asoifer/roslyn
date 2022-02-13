// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;
using System.Threading;

namespace Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE
{
    internal sealed class PEAttributeData : CSharpAttributeData
    {
        private readonly MetadataDecoder _decoder;

        private readonly CustomAttributeHandle _handle;

        private NamedTypeSymbol? _lazyAttributeClass;

        private MethodSymbol? _lazyAttributeConstructor;

        private ImmutableArray<TypedConstant> _lazyConstructorArguments;

        private ImmutableArray<KeyValuePair<string, TypedConstant>> _lazyNamedArguments;

        private ThreeState _lazyHasErrors;

        internal PEAttributeData(PEModuleSymbol moduleSymbol, CustomAttributeHandle handle)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10403, 1151, 1346);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10403, 667, 675);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10403, 768, 823);
                this._lazyAttributeClass = ErrorTypeSymbol.UnknownResultType; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10403, 884, 909);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10403, 1103, 1138);
                this._lazyHasErrors = ThreeState.Unknown; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10403, 1259, 1304);

                _decoder = f_10403_1270_1303(moduleSymbol);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10403, 1318, 1335);

                _handle = handle;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10403, 1151, 1346);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10403, 1151, 1346);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10403, 1151, 1346);
            }
        }

        public override NamedTypeSymbol? AttributeClass
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10403, 1430, 1570);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10403, 1466, 1510);

                    f_10403_1466_1509(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10403, 1528, 1555);

                    return _lazyAttributeClass;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10403, 1430, 1570);

                    int
                    f_10403_1466_1509(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAttributeData
                    this_param)
                    {
                        this_param.EnsureClassAndConstructorSymbolsAreLoaded();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10403, 1466, 1509);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10403, 1358, 1581);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10403, 1358, 1581);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override MethodSymbol? AttributeConstructor
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10403, 1668, 1814);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10403, 1704, 1748);

                    f_10403_1704_1747(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10403, 1766, 1799);

                    return _lazyAttributeConstructor;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10403, 1668, 1814);

                    int
                    f_10403_1704_1747(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAttributeData
                    this_param)
                    {
                        this_param.EnsureClassAndConstructorSymbolsAreLoaded();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10403, 1704, 1747);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10403, 1593, 1825);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10403, 1593, 1825);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override SyntaxReference? ApplicationSyntaxReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10403, 1921, 1941);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10403, 1927, 1939);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10403, 1921, 1941);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10403, 1837, 1952);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10403, 1837, 1952);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected internal override ImmutableArray<TypedConstant> CommonConstructorArguments
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10403, 2073, 2211);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10403, 2109, 2145);

                    f_10403_2109_2144(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10403, 2163, 2196);

                    return _lazyConstructorArguments;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10403, 2073, 2211);

                    int
                    f_10403_2109_2144(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAttributeData
                    this_param)
                    {
                        this_param.EnsureAttributeArgumentsAreLoaded();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10403, 2109, 2144);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10403, 1964, 2222);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10403, 1964, 2222);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected internal override ImmutableArray<KeyValuePair<string, TypedConstant>> CommonNamedArguments
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10403, 2359, 2491);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10403, 2395, 2431);

                    f_10403_2395_2430(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10403, 2449, 2476);

                    return _lazyNamedArguments;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10403, 2359, 2491);

                    int
                    f_10403_2395_2430(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAttributeData
                    this_param)
                    {
                        this_param.EnsureAttributeArgumentsAreLoaded();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10403, 2395, 2430);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10403, 2234, 2502);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10403, 2234, 2502);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private void EnsureClassAndConstructorSymbolsAreLoaded()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10403, 2514, 3658);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10403, 2625, 3617) || true) && ((object?)_lazyAttributeClass == ErrorTypeSymbol.UnknownResultType)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10403, 2625, 3617);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10403, 2728, 2755);

                    TypeSymbol?
                    attributeClass
                    = default(TypeSymbol?);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10403, 2773, 2808);

                    MethodSymbol?
                    attributeConstructor
                    = default(MethodSymbol?);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10403, 2828, 3319) || true) && (!f_10403_2833_2915(_decoder, _handle, out attributeClass, out attributeConstructor))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10403, 2828, 3319);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10403, 3044, 3077);

                        _lazyHasErrors = ThreeState.True;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10403, 2828, 3319);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10403, 2828, 3319);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10403, 3119, 3319) || true) && ((object)attributeClass == null || (DynAbs.Tracing.TraceSender.Expression_False(10403, 3123, 3185) || f_10403_3157_3185(attributeClass)) || (DynAbs.Tracing.TraceSender.Expression_False(10403, 3123, 3225) || (object)attributeConstructor == null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10403, 3119, 3319);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10403, 3267, 3300);

                            _lazyHasErrors = ThreeState.True;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10403, 3119, 3319);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10403, 2828, 3319);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10403, 3339, 3426);

                    f_10403_3339_3425(ref _lazyAttributeConstructor, attributeConstructor, null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10403, 3444, 3566);

                    f_10403_3444_3565(ref _lazyAttributeClass, attributeClass, ErrorTypeSymbol.UnknownResultType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10403, 2625, 3617);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10403, 2514, 3658);

                bool
                f_10403_2833_2915(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle, out Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                attributeClass, out Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                attributeCtor)
                {
                    var return_v = this_param.GetCustomAttribute(handle, out attributeClass, out attributeCtor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10403, 2833, 2915);
                    return return_v;
                }


                bool
                f_10403_3157_3185(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10403, 3157, 3185);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                f_10403_3339_3425(ref Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                location1, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                value, Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10403, 3339, 3425);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?
                f_10403_3444_3565(ref Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                location1, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
                value, Microsoft.CodeAnalysis.CSharp.Symbols.ErrorTypeSymbol
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, (Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol?)value, (Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol)comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10403, 3444, 3565);
                    return return_v;
                }

#pragma warning restore 0252
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10403, 2514, 3658);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10403, 2514, 3658);
            }
        }

        private void EnsureAttributeArgumentsAreLoaded()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10403, 3670, 4681);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10403, 3743, 4670) || true) && (_lazyConstructorArguments.IsDefault || (DynAbs.Tracing.TraceSender.Expression_False(10403, 3747, 3815) || _lazyNamedArguments.IsDefault))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10403, 3743, 4670);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10403, 3849, 3898);

                    TypedConstant[]?
                    lazyConstructorArguments = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10403, 3916, 3981);

                    KeyValuePair<string, TypedConstant>[]?
                    lazyNamedArguments = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10403, 4001, 4190) || true) && (!f_10403_4006_4096(_decoder, _handle, out lazyConstructorArguments, out lazyNamedArguments))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10403, 4001, 4190);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10403, 4138, 4171);

                        _lazyHasErrors = ThreeState.True;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10403, 4001, 4190);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10403, 4210, 4287);

                    f_10403_4210_4286(lazyConstructorArguments != null && (DynAbs.Tracing.TraceSender.Expression_True(10403, 4223, 4285) && lazyNamedArguments != null));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10403, 4307, 4466);

                    f_10403_4307_4465(ref _lazyConstructorArguments, f_10403_4402_4464(lazyConstructorArguments));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10403, 4486, 4655);

                    f_10403_4486_4654(ref _lazyNamedArguments, f_10403_4575_4653(lazyNamedArguments));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10403, 3743, 4670);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10403, 3670, 4681);

                bool
                f_10403_4006_4096(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                handle, out Microsoft.CodeAnalysis.TypedConstant[]?
                positionalArgs, out System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>[]?
                namedArgs)
                {
                    var return_v = this_param.GetCustomAttribute(handle, out positionalArgs, out namedArgs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10403, 4006, 4096);
                    return return_v;
                }


                int
                f_10403_4210_4286(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10403, 4210, 4286);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                f_10403_4402_4464(params Microsoft.CodeAnalysis.TypedConstant[]
                items)
                {
                    var return_v = ImmutableArray.Create<TypedConstant>(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10403, 4402, 4464);
                    return return_v;
                }


                bool
                f_10403_4307_4465(ref System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                location, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.TypedConstant>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10403, 4307, 4465);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                f_10403_4575_4653(params System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>[]
                items)
                {
                    var return_v = ImmutableArray.Create<KeyValuePair<string, TypedConstant>>(items);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10403, 4575, 4653);
                    return return_v;
                }


                bool
                f_10403_4486_4654(ref System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                location, System.Collections.Immutable.ImmutableArray<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.TypedConstant>>
                value)
                {
                    var return_v = ImmutableInterlocked.InterlockedInitialize(ref location, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10403, 4486, 4654);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10403, 3670, 4681);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10403, 3670, 4681);
            }
        }

        internal override bool IsTargetAttribute(string namespaceName, string typeName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10403, 5042, 5308);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10403, 5229, 5297);

                return f_10403_5236_5296(_decoder, _handle, namespaceName, typeName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10403, 5042, 5308);

                bool
                f_10403_5236_5296(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                customAttribute, string
                namespaceName, string
                typeName)
                {
                    var return_v = this_param.IsTargetAttribute(customAttribute, namespaceName, typeName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10403, 5236, 5296);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10403, 5042, 5308);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10403, 5042, 5308);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override int GetTargetAttributeSignatureIndex(Symbol targetSymbol, AttributeDescription description)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10403, 5851, 6150);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10403, 6068, 6139);

                return f_10403_6075_6138(_decoder, _handle, description);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10403, 5851, 6150);

                int
                f_10403_6075_6138(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
                this_param, System.Reflection.Metadata.CustomAttributeHandle
                customAttribute, Microsoft.CodeAnalysis.AttributeDescription
                description)
                {
                    var return_v = this_param.GetTargetAttributeSignatureIndex(customAttribute, description);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10403, 6075, 6138);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10403, 5851, 6150);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10403, 5851, 6150);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [MemberNotNullWhen(true, nameof(AttributeClass), nameof(AttributeConstructor))]
        internal override bool HasErrors
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10403, 6308, 6783);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10403, 6344, 6718) || true) && (_lazyHasErrors == ThreeState.Unknown)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10403, 6344, 6718);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10403, 6426, 6470);

                        f_10403_6426_6469(this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10403, 6492, 6528);

                        f_10403_6492_6527(this);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10403, 6552, 6699) || true) && (_lazyHasErrors == ThreeState.Unknown)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10403, 6552, 6699);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10403, 6642, 6676);

                            _lazyHasErrors = ThreeState.False;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10403, 6552, 6699);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10403, 6344, 6718);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10403, 6738, 6768);

                    return f_10403_6745_6767(_lazyHasErrors);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10403, 6308, 6783);

                    int
                    f_10403_6426_6469(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAttributeData
                    this_param)
                    {
                        this_param.EnsureClassAndConstructorSymbolsAreLoaded();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10403, 6426, 6469);
                        return 0;
                    }


                    int
                    f_10403_6492_6527(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEAttributeData
                    this_param)
                    {
                        this_param.EnsureAttributeArgumentsAreLoaded();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10403, 6492, 6527);
                        return 0;
                    }


                    bool
                    f_10403_6745_6767(Microsoft.CodeAnalysis.ThreeState
                    value)
                    {
                        var return_v = value.Value();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10403, 6745, 6767);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10403, 6162, 6794);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10403, 6162, 6794);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static PEAttributeData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10403, 558, 6801);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10403, 558, 6801);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10403, 558, 6801);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10403, 558, 6801);

        Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder
        f_10403_1270_1303(Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.PEModuleSymbol
        moduleSymbol)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.Metadata.PE.MetadataDecoder(moduleSymbol);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10403, 1270, 1303);
            return return_v;
        }

    }
}
