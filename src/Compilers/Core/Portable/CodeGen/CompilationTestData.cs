// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CodeAnalysis.Emit;
using Microsoft.CodeAnalysis.Symbols;
using Microsoft.DiaSymReader;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading;

namespace Microsoft.CodeAnalysis.CodeGen
{
    internal sealed class CompilationTestData
    {
        internal struct MethodData
        {

            public readonly ILBuilder ILBuilder;

            public readonly IMethodSymbolInternal Method;

            public MethodData(ILBuilder ilBuilder, IMethodSymbolInternal method)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(51, 755, 937);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(51, 856, 883);

                    this.ILBuilder = ilBuilder;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(51, 901, 922);

                    this.Method = method;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(51, 755, 937);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(51, 755, 937);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(51, 755, 937);
                }
            }
            static MethodData()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(51, 593, 948);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(51, 593, 948);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(51, 593, 948);
            }
        }

        public readonly ConcurrentDictionary<IMethodSymbolInternal, MethodData> Methods;

        public CommonPEModuleBuilder? Module;

        public Func<ISymWriterMetadataProvider, SymUnmanagedWriter>? SymWriterFactory;

        public ILBuilder GetIL(Func<IMethodSymbolInternal, bool> predicate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(51, 1370, 1534);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(51, 1462, 1523);

                return f_51_1469_1506(Methods, p => predicate(p.Key)).Value.ILBuilder;
                DynAbs.Tracing.TraceSender.TraceExitMethod(51, 1370, 1534);

                System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>
                f_51_1469_1506(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>
                source, System.Func<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>, bool>
                predicate)
                {
                    var return_v = source.Single<System.Collections.Generic.KeyValuePair<Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(51, 1469, 1506);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(51, 1370, 1534);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(51, 1370, 1534);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ImmutableDictionary<string, MethodData>? _lazyMethodsByName;

        public ImmutableDictionary<string, MethodData> GetMethodsByName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(51, 1709, 2586);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(51, 1799, 2535) || true) && (_lazyMethodsByName == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(51, 1799, 2535);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(51, 1863, 1910);

                    var
                    map = f_51_1873_1909()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(51, 1928, 2328);
                        foreach (var pair in f_51_1949_1956_I(Methods))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(51, 1928, 2328);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(51, 1998, 2033);

                            var
                            name = f_51_2009_2032(pair.Key)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(51, 2055, 2309) || true) && (f_51_2059_2080(map, name))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(51, 2055, 2309);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(51, 2130, 2162);

                                map[name] = default(MethodData);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(51, 2055, 2309);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(51, 2055, 2309);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(51, 2260, 2286);

                                f_51_2260_2285(map, name, pair.Value);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(51, 2055, 2309);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(51, 1928, 2328);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(51, 1, 401);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(51, 1, 401);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(51, 2346, 2429);

                    var
                    methodsByName = f_51_2366_2428(f_51_2366_2404(map, p => p.Value.Method != null))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(51, 2447, 2520);

                    f_51_2447_2519(ref _lazyMethodsByName, methodsByName, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(51, 1799, 2535);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(51, 2549, 2575);

                return _lazyMethodsByName;
                DynAbs.Tracing.TraceSender.TraceExitMethod(51, 1709, 2586);

                System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>
                f_51_1873_1909()
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(51, 1873, 1909);
                    return return_v;
                }


                string
                f_51_2009_2032(Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal
                methodSymbol)
                {
                    var return_v = GetMethodName(methodSymbol);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(51, 2009, 2032);
                    return return_v;
                }


                bool
                f_51_2059_2080(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(51, 2059, 2080);
                    return return_v;
                }


                int
                f_51_2260_2285(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>
                this_param, string
                key, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(51, 2260, 2285);
                    return 0;
                }


                System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>
                f_51_1949_1956_I(System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(51, 1949, 1956);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>>
                f_51_2366_2404(System.Collections.Generic.Dictionary<string, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>
                source, System.Func<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>, bool>
                predicate)
                {
                    var return_v = source.Where<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(51, 2366, 2404);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>
                f_51_2366_2428(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>>
                source)
                {
                    var return_v = source.ToImmutableDictionary<string, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(51, 2366, 2428);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>?
                f_51_2447_2519(ref System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>?
                location1, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>
                value, System.Collections.Immutable.ImmutableDictionary<string, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>?
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(51, 2447, 2519);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(51, 1709, 2586);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(51, 1709, 2586);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly SymbolDisplayFormat _testDataKeyFormat;

        private static readonly SymbolDisplayFormat _testDataOperatorKeyFormat;

        private static string GetMethodName(IMethodSymbolInternal methodSymbol)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(51, 4944, 5335);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(51, 5040, 5105);

                IMethodSymbol
                iMethod = (IMethodSymbol)f_51_5079_5104(methodSymbol)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(51, 5119, 5271);

                var
                format = (DynAbs.Tracing.TraceSender.Conditional_F1(51, 5132, 5186) || (((f_51_5133_5151(iMethod) == MethodKind.UserDefinedOperator) && DynAbs.Tracing.TraceSender.Conditional_F2(51, 5206, 5232)) || DynAbs.Tracing.TraceSender.Conditional_F3(51, 5252, 5270))) ? _testDataOperatorKeyFormat : _testDataKeyFormat
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(51, 5285, 5324);

                return f_51_5292_5323(iMethod, format);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(51, 4944, 5335);

                Microsoft.CodeAnalysis.ISymbol
                f_51_5079_5104(Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal
                this_param)
                {
                    var return_v = this_param.GetISymbol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(51, 5079, 5104);
                    return return_v;
                }


                Microsoft.CodeAnalysis.MethodKind
                f_51_5133_5151(Microsoft.CodeAnalysis.IMethodSymbol
                this_param)
                {
                    var return_v = this_param.MethodKind;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(51, 5133, 5151);
                    return return_v;
                }


                string
                f_51_5292_5323(Microsoft.CodeAnalysis.IMethodSymbol
                this_param, Microsoft.CodeAnalysis.SymbolDisplayFormat
                format)
                {
                    var return_v = this_param.ToDisplayString(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(51, 5292, 5323);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(51, 4944, 5335);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(51, 4944, 5335);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CompilationTestData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(51, 535, 5342);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(51, 1115, 1186);
            this.Methods = f_51_1125_1186(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(51, 1261, 1267);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(51, 1341, 1357);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(51, 1595, 1613);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(51, 535, 5342);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(51, 535, 5342);
        }


        static CompilationTestData()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(51, 535, 5342);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(51, 2642, 4162);
            _testDataKeyFormat = f_51_2663_4162(compilerInternalOptions: SymbolDisplayCompilerInternalOptions.UseMetadataMethodNames | SymbolDisplayCompilerInternalOptions.UseValueTuple, globalNamespaceStyle: SymbolDisplayGlobalNamespaceStyle.OmittedAsContaining, typeQualificationStyle: SymbolDisplayTypeQualificationStyle.NameAndContainingTypesAndNamespaces, genericsOptions: SymbolDisplayGenericsOptions.IncludeTypeParameters | SymbolDisplayGenericsOptions.IncludeVariance, memberOptions:
                            SymbolDisplayMemberOptions.IncludeParameters |
                            SymbolDisplayMemberOptions.IncludeContainingType |
                            SymbolDisplayMemberOptions.IncludeExplicitInterface, parameterOptions:
                            SymbolDisplayParameterOptions.IncludeParamsRefOut |
                            SymbolDisplayParameterOptions.IncludeExtensionThis |
                            SymbolDisplayParameterOptions.IncludeType, miscellaneousOptions:
                            SymbolDisplayMiscellaneousOptions.EscapeKeywordIdentifiers |
                            SymbolDisplayMiscellaneousOptions.UseSpecialTypes |
                            SymbolDisplayMiscellaneousOptions.UseAsterisksInMultiDimensionalArrays |
                            SymbolDisplayMiscellaneousOptions.UseErrorTypeSymbolName); DynAbs.Tracing.TraceSender.TraceSimpleStatement(51, 4219, 4931);
            _testDataOperatorKeyFormat = f_51_4248_4931(f_51_4287_4329(_testDataKeyFormat), f_51_4345_4384(_testDataKeyFormat), f_51_4400_4441(_testDataKeyFormat), f_51_4457_4491(_testDataKeyFormat), f_51_4507_4539(_testDataKeyFormat) | SymbolDisplayMemberOptions.IncludeType, f_51_4596_4631(_testDataKeyFormat), f_51_4647_4679(_testDataKeyFormat), f_51_4695_4734(_testDataKeyFormat), f_51_4750_4782(_testDataKeyFormat), f_51_4798_4829(_testDataKeyFormat), f_51_4845_4875(_testDataKeyFormat), f_51_4891_4930(_testDataKeyFormat)); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(51, 535, 5342);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(51, 535, 5342);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(51, 535, 5342);

        System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>
        f_51_1125_1186()
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<Microsoft.CodeAnalysis.Symbols.IMethodSymbolInternal, Microsoft.CodeAnalysis.CodeGen.CompilationTestData.MethodData>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(51, 1125, 1186);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolDisplayFormat
        f_51_2663_4162(Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
        compilerInternalOptions, Microsoft.CodeAnalysis.SymbolDisplayGlobalNamespaceStyle
        globalNamespaceStyle, Microsoft.CodeAnalysis.SymbolDisplayTypeQualificationStyle
        typeQualificationStyle, Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
        genericsOptions, Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
        memberOptions, Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
        parameterOptions, Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
        miscellaneousOptions)
        {
            var return_v = new Microsoft.CodeAnalysis.SymbolDisplayFormat(compilerInternalOptions: compilerInternalOptions, globalNamespaceStyle: globalNamespaceStyle, typeQualificationStyle: typeQualificationStyle, genericsOptions: genericsOptions, memberOptions: memberOptions, parameterOptions: parameterOptions, miscellaneousOptions: miscellaneousOptions);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(51, 2663, 4162);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
        f_51_4287_4329(Microsoft.CodeAnalysis.SymbolDisplayFormat
        this_param)
        {
            var return_v = this_param.CompilerInternalOptions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(51, 4287, 4329);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolDisplayGlobalNamespaceStyle
        f_51_4345_4384(Microsoft.CodeAnalysis.SymbolDisplayFormat
        this_param)
        {
            var return_v = this_param.GlobalNamespaceStyle;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(51, 4345, 4384);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolDisplayTypeQualificationStyle
        f_51_4400_4441(Microsoft.CodeAnalysis.SymbolDisplayFormat
        this_param)
        {
            var return_v = this_param.TypeQualificationStyle;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(51, 4400, 4441);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
        f_51_4457_4491(Microsoft.CodeAnalysis.SymbolDisplayFormat
        this_param)
        {
            var return_v = this_param.GenericsOptions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(51, 4457, 4491);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
        f_51_4507_4539(Microsoft.CodeAnalysis.SymbolDisplayFormat
        this_param)
        {
            var return_v = this_param.MemberOptions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(51, 4507, 4539);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
        f_51_4596_4631(Microsoft.CodeAnalysis.SymbolDisplayFormat
        this_param)
        {
            var return_v = this_param.ParameterOptions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(51, 4596, 4631);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolDisplayDelegateStyle
        f_51_4647_4679(Microsoft.CodeAnalysis.SymbolDisplayFormat
        this_param)
        {
            var return_v = this_param.DelegateStyle;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(51, 4647, 4679);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolDisplayExtensionMethodStyle
        f_51_4695_4734(Microsoft.CodeAnalysis.SymbolDisplayFormat
        this_param)
        {
            var return_v = this_param.ExtensionMethodStyle;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(51, 4695, 4734);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolDisplayPropertyStyle
        f_51_4750_4782(Microsoft.CodeAnalysis.SymbolDisplayFormat
        this_param)
        {
            var return_v = this_param.PropertyStyle;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(51, 4750, 4782);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolDisplayLocalOptions
        f_51_4798_4829(Microsoft.CodeAnalysis.SymbolDisplayFormat
        this_param)
        {
            var return_v = this_param.LocalOptions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(51, 4798, 4829);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolDisplayKindOptions
        f_51_4845_4875(Microsoft.CodeAnalysis.SymbolDisplayFormat
        this_param)
        {
            var return_v = this_param.KindOptions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(51, 4845, 4875);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
        f_51_4891_4930(Microsoft.CodeAnalysis.SymbolDisplayFormat
        this_param)
        {
            var return_v = this_param.MiscellaneousOptions;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(51, 4891, 4930);
            return return_v;
        }


        static Microsoft.CodeAnalysis.SymbolDisplayFormat
        f_51_4248_4931(Microsoft.CodeAnalysis.SymbolDisplayCompilerInternalOptions
        compilerInternalOptions, Microsoft.CodeAnalysis.SymbolDisplayGlobalNamespaceStyle
        globalNamespaceStyle, Microsoft.CodeAnalysis.SymbolDisplayTypeQualificationStyle
        typeQualificationStyle, Microsoft.CodeAnalysis.SymbolDisplayGenericsOptions
        genericsOptions, Microsoft.CodeAnalysis.SymbolDisplayMemberOptions
        memberOptions, Microsoft.CodeAnalysis.SymbolDisplayParameterOptions
        parameterOptions, Microsoft.CodeAnalysis.SymbolDisplayDelegateStyle
        delegateStyle, Microsoft.CodeAnalysis.SymbolDisplayExtensionMethodStyle
        extensionMethodStyle, Microsoft.CodeAnalysis.SymbolDisplayPropertyStyle
        propertyStyle, Microsoft.CodeAnalysis.SymbolDisplayLocalOptions
        localOptions, Microsoft.CodeAnalysis.SymbolDisplayKindOptions
        kindOptions, Microsoft.CodeAnalysis.SymbolDisplayMiscellaneousOptions
        miscellaneousOptions)
        {
            var return_v = new Microsoft.CodeAnalysis.SymbolDisplayFormat(compilerInternalOptions, globalNamespaceStyle, typeQualificationStyle, genericsOptions, memberOptions, parameterOptions, delegateStyle, extensionMethodStyle, propertyStyle, localOptions, kindOptions, miscellaneousOptions);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(51, 4248, 4931);
            return return_v;
        }

    }
}
