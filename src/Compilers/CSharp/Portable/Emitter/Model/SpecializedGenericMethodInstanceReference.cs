// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Symbols;
using Microsoft.CodeAnalysis.Emit;

namespace Microsoft.CodeAnalysis.CSharp.Emit
{
    internal sealed class SpecializedGenericMethodInstanceReference : SpecializedMethodReference, Cci.IGenericMethodInstanceReference
    {
        private readonly SpecializedMethodReference _genericMethod;

        public SpecializedGenericMethodInstanceReference(MethodSymbol underlyingMethod)
        : base(f_10209_944_960_C(underlyingMethod))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10209, 844, 1202);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10209, 817, 831);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10209, 986, 1111);

                f_10209_986_1110(f_10209_999_1061(f_10209_1029_1060(underlyingMethod)) && (DynAbs.Tracing.TraceSender.Expression_True(10209, 999, 1109) && f_10209_1065_1109(f_10209_1065_1096(underlyingMethod))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10209, 1125, 1191);

                _genericMethod = f_10209_1142_1190(underlyingMethod);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10209, 844, 1202);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10209, 844, 1202);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10209, 844, 1202);
            }
        }

        IEnumerable<Cci.ITypeReference> Cci.IGenericMethodInstanceReference.GetGenericArguments(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10209, 1214, 1755);

                var listYield = new List<Cci.ITypeReference>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10209, 1347, 1414);

                PEModuleBuilder
                moduleBeingBuilt = (PEModuleBuilder)context.Module
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10209, 1430, 1744);
                    foreach (var arg in f_10209_1450_1495_I(f_10209_1450_1495(UnderlyingMethod)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10209, 1430, 1744);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10209, 1529, 1571);

                        f_10209_1529_1570(arg.CustomModifiers.IsEmpty);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10209, 1589, 1729);

                        listYield.Add(f_10209_1602_1728(moduleBeingBuilt, arg.Type, (CSharpSyntaxNode)context.SyntaxNodeOpt, diagnostics: context.Diagnostics));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10209, 1430, 1744);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10209, 1, 315);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10209, 1, 315);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(10209, 1214, 1755);

                return listYield;

                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10209_1450_1495(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.TypeArgumentsWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10209, 1450, 1495);
                    return return_v;
                }


                int
                f_10209_1529_1570(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10209, 1529, 1570);
                    return 0;
                }


                Microsoft.Cci.ITypeReference
                f_10209_1602_1728(Microsoft.CodeAnalysis.CSharp.Emit.PEModuleBuilder
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                typeSymbol, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                syntaxNodeOpt, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = this_param.Translate(typeSymbol, syntaxNodeOpt: (Microsoft.CodeAnalysis.SyntaxNode)syntaxNodeOpt, diagnostics: diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10209, 1602, 1728);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10209_1450_1495_I(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10209, 1450, 1495);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10209, 1214, 1755);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10209, 1214, 1755);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        Cci.IMethodReference Cci.IGenericMethodInstanceReference.GetGenericMethod(EmitContext context)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10209, 1767, 1919);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10209, 1886, 1908);

                return _genericMethod;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10209, 1767, 1919);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10209, 1767, 1919);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10209, 1767, 1919);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Cci.IGenericMethodInstanceReference AsGenericMethodInstanceReference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10209, 2040, 2103);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10209, 2076, 2088);

                    return this;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10209, 2040, 2103);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10209, 1931, 2114);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10209, 1931, 2114);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override void Dispatch(Cci.MetadataVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10209, 2126, 2277);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10209, 2209, 2266);

                f_10209_2209_2265(visitor, this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10209, 2126, 2277);

                int
                f_10209_2209_2265(Microsoft.Cci.MetadataVisitor
                this_param, Microsoft.CodeAnalysis.CSharp.Emit.SpecializedGenericMethodInstanceReference
                genericMethodInstanceReference)
                {
                    this_param.Visit((Microsoft.Cci.IGenericMethodInstanceReference)genericMethodInstanceReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10209, 2209, 2265);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10209, 2126, 2277);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10209, 2126, 2277);
            }
        }

        static SpecializedGenericMethodInstanceReference()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10209, 627, 2284);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10209, 627, 2284);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10209, 627, 2284);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10209, 627, 2284);

        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10209_1029_1060(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ContainingType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10209, 1029, 1060);
            return return_v;
        }


        bool
        f_10209_999_1061(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        toCheck)
        {
            var return_v = PEModuleBuilder.IsGenericType(toCheck);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10209, 999, 1061);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        f_10209_1065_1096(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        this_param)
        {
            var return_v = this_param.ContainingType;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10209, 1065, 1096);
            return return_v;
        }


        bool
        f_10209_1065_1109(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
        this_param)
        {
            var return_v = this_param.IsDefinition;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10209, 1065, 1109);
            return return_v;
        }


        int
        f_10209_986_1110(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10209, 986, 1110);
            return 0;
        }


        Microsoft.CodeAnalysis.CSharp.Emit.SpecializedMethodReference
        f_10209_1142_1190(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        underlyingMethod)
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Emit.SpecializedMethodReference(underlyingMethod);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10209, 1142, 1190);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        f_10209_944_960_C(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10209, 844, 1202);
            return return_v;
        }

    }
}
