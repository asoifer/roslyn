// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Emit;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal abstract class SynthesizedEntryPointSymbol : MethodSymbol
    {
        internal const string
        MainName = "<Main>"
        ;

        internal const string
        FactoryName = "<Factory>"
        ;

        private readonly NamedTypeSymbol _containingType;

        internal static SynthesizedEntryPointSymbol Create(SynthesizedInteractiveInitializerMethod initializerMethod, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10673, 933, 2065);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 1094, 1148);

                var
                containingType = f_10673_1115_1147(initializerMethod)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 1162, 1216);

                var
                compilation = f_10673_1180_1215(containingType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 1230, 2054) || true) && (f_10673_1234_1258(compilation))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10673, 1230, 2054);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 1292, 1401);

                    var
                    systemObject = f_10673_1311_1400(compilation, SpecialType.System_Object, f_10673_1373_1386(), diagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 1419, 1493);

                    var
                    submissionArrayType = f_10673_1445_1492(compilation, systemObject)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 1511, 1570);

                    f_10673_1511_1569(submissionArrayType, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 1588, 1766);

                    return f_10673_1595_1765(containingType, f_10673_1679_1722(initializerMethod), submissionArrayType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10673, 1230, 2054);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10673, 1230, 2054);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 1832, 1937);

                    var
                    systemVoid = f_10673_1849_1936(compilation, SpecialType.System_Void, f_10673_1909_1922(), diagnostics)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 1955, 2039);

                    return f_10673_1962_2038(containingType, TypeWithAnnotations.Create(systemVoid));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10673, 1230, 2054);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10673, 933, 2065);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10673_1115_1147(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInteractiveInitializerMethod
                this_param)
                {
                    var return_v = this_param.ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10673, 1115, 1147);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10673_1180_1215(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10673, 1180, 1215);
                    return return_v;
                }


                bool
                f_10673_1234_1258(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param)
                {
                    var return_v = this_param.IsSubmission;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10673, 1234, 1258);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10673_1373_1386()
                {
                    var return_v = DummySyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 1373, 1386);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10673_1311_1400(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.SpecialType
                typeId, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = Binder.GetSpecialType(compilation, typeId, (Microsoft.CodeAnalysis.SyntaxNode)node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 1311, 1400);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                f_10673_1445_1492(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                elementType)
                {
                    var return_v = this_param.CreateArrayTypeSymbol((Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)elementType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 1445, 1492);
                    return return_v;
                }


                int
                f_10673_1511_1569(Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                symbol, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    ReportUseSiteDiagnostics((Microsoft.CodeAnalysis.CSharp.Symbol)symbol, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 1511, 1569);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10673_1679_1722(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInteractiveInitializerMethod
                this_param)
                {
                    var return_v = this_param.ReturnTypeWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10673, 1679, 1722);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEntryPointSymbol.SubmissionEntryPoint
                f_10673_1595_1765(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                returnType, Microsoft.CodeAnalysis.CSharp.Symbols.ArrayTypeSymbol
                submissionArrayType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEntryPointSymbol.SubmissionEntryPoint(containingType, returnType, (Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol)submissionArrayType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 1595, 1765);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10673_1909_1922()
                {
                    var return_v = DummySyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 1909, 1922);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10673_1849_1936(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, Microsoft.CodeAnalysis.SpecialType
                typeId, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                node, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics)
                {
                    var return_v = Binder.GetSpecialType(compilation, typeId, (Microsoft.CodeAnalysis.SyntaxNode)node, diagnostics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 1849, 1936);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEntryPointSymbol.ScriptEntryPoint
                f_10673_1962_2038(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                containingType, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                returnType)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEntryPointSymbol.ScriptEntryPoint(containingType, returnType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 1962, 2038);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 933, 2065);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 933, 2065);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private SynthesizedEntryPointSymbol(NamedTypeSymbol containingType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10673, 2077, 2274);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 905, 920);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 2169, 2214);

                f_10673_2169_2213((object)containingType != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 2230, 2263);

                _containingType = containingType;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10673, 2077, 2274);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 2077, 2274);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 2077, 2274);
            }
        }

        internal override bool GenerateDebugInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 2351, 2372);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 2357, 2370);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 2351, 2372);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 2286, 2383);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 2286, 2383);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal abstract BoundBlock CreateBody(DiagnosticBag diagnostics);

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 2538, 2569);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 2544, 2567);

                    return _containingType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 2538, 2569);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 2474, 2580);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 2474, 2580);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public abstract override string Name
        {
            get;
        }

        internal override bool HasSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 2742, 2762);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 2748, 2760);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 2742, 2762);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 2680, 2773);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 2680, 2773);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 2891, 2954);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 2897, 2952);

                    return default(System.Reflection.MethodImplAttributes);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 2891, 2954);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 2785, 2965);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 2785, 2965);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 3047, 3068);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 3053, 3066);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 3047, 3068);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 2977, 3079);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 2977, 3079);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 3145, 3166);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 3151, 3164);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 3145, 3166);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 3091, 3177);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 3091, 3177);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 3280, 3337);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 3286, 3335);

                    return ImmutableArray<TypeParameterSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 3280, 3337);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 3189, 3348);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 3189, 3348);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 3436, 3473);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 3442, 3471);

                    return Accessibility.Private;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 3436, 3473);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 3360, 3484);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 3360, 3484);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 3571, 3617);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 3577, 3615);

                    return ImmutableArray<Location>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 3571, 3617);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 3496, 3628);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 3496, 3628);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 3738, 3834);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 3774, 3819);

                    return ImmutableArray<SyntaxReference>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 3738, 3834);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 3640, 3845);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 3640, 3845);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 3913, 3941);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 3919, 3939);

                    return RefKind.None;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 3913, 3941);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 3857, 3952);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 3857, 3952);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 4054, 4106);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 4060, 4104);

                    return ImmutableArray<CustomModifier>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 4054, 4106);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 3964, 4117);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 3964, 4117);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 4234, 4291);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 4240, 4289);

                    return ImmutableArray<TypeWithAnnotations>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 4234, 4291);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 4129, 4302);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 4129, 4302);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 4378, 4398);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 4384, 4396);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 4378, 4398);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 4314, 4409);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 4314, 4409);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 4471, 4488);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 4477, 4486);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 4471, 4488);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 4421, 4499);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 4421, 4499);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 4568, 4607);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 4574, 4605);

                    return f_10673_4581_4604(f_10673_4581_4591());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 4568, 4607);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10673_4581_4591()
                    {
                        var return_v = ReturnType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10673, 4581, 4591);
                        return return_v;
                    }


                    bool
                    f_10673_4581_4604(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = type.IsVoidType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 4581, 4604);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 4511, 4618);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 4511, 4618);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override FlowAnalysisAnnotations ReturnTypeFlowAnalysisAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 4711, 4742);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 4714, 4742);
                    return FlowAnalysisAnnotations.None; DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 4711, 4742);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 4711, 4742);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 4711, 4742);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 4835, 4868);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 4838, 4868);
                    return ImmutableHashSet<string>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 4835, 4868);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 4835, 4868);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 4835, 4868);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 4952, 4983);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 4955, 4983);
                    return FlowAnalysisAnnotations.None; DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 4952, 4983);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 4952, 4983);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 4952, 4983);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 5058, 5093);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 5064, 5091);

                    return MethodKind.Ordinary;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 5058, 5093);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 4996, 5104);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 4996, 5104);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 5170, 5191);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 5176, 5189);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 5170, 5191);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 5116, 5202);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 5116, 5202);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 5268, 5289);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 5274, 5287);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 5268, 5289);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 5214, 5300);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 5214, 5300);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 5368, 5389);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 5374, 5387);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 5368, 5389);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 5312, 5400);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 5312, 5400);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 5468, 5489);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 5474, 5487);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 5468, 5489);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 5412, 5500);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 5412, 5500);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 5567, 5588);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 5573, 5586);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 5567, 5588);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 5512, 5599);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 5512, 5599);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 5665, 5685);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 5671, 5683);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 5665, 5685);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 5611, 5696);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 5611, 5696);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 5761, 5782);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 5767, 5780);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 5761, 5782);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 5708, 5793);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 5708, 5793);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 5873, 5894);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 5879, 5892);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 5873, 5894);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 5805, 5905);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 5805, 5905);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 5980, 6001);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 5986, 5999);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 5980, 6001);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 5917, 6012);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 5917, 6012);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override ObsoleteAttributeData ObsoleteAttributeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 6117, 6137);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 6123, 6135);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 6117, 6137);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 6024, 6148);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 6024, 6148);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override UnmanagedCallersOnlyAttributeData GetUnmanagedCallersOnlyAttributeData(bool forceComplete)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 6276, 6283);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 6279, 6283);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 6276, 6283);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 6276, 6283);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 6276, 6283);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override Cci.CallingConvention CallingConvention
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 6378, 6395);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 6384, 6393);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 6378, 6395);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 6296, 6406);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 6296, 6406);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 6499, 6520);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 6505, 6518);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 6499, 6520);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 6418, 6531);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 6418, 6531);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 6645, 6695);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 6651, 6693);

                    return ImmutableArray<MethodSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 6645, 6695);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 6543, 6706);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 6543, 6706);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 6767, 6775);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 6770, 6775);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 6767, 6775);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 6767, 6775);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 6767, 6775);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 6829, 6837);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 6832, 6837);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 6829, 6837);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 6829, 6837);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 6829, 6837);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override bool IsMetadataNewSlot(bool ignoreInterfaceImplementationChanges = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 6850, 6997);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 6973, 6986);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 6850, 6997);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 6850, 6997);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 6850, 6997);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override bool IsMetadataVirtual(bool ignoreInterfaceImplementationChanges = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 7009, 7156);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 7132, 7145);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 7009, 7156);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 7009, 7156);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 7009, 7156);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsMetadataFinal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 7231, 7295);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 7267, 7280);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 7231, 7295);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 7168, 7306);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 7168, 7306);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsImplicitlyDeclared
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 7384, 7404);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 7390, 7402);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 7384, 7404);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 7318, 7415);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 7318, 7415);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override DllImportData GetDllImportData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 7427, 7523);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 7500, 7512);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 7427, 7523);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 7427, 7523);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 7427, 7523);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override bool AreLocalsZeroed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 7603, 7649);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 7609, 7647);

                    return f_10673_7616_7646(f_10673_7616_7630());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 7603, 7649);

                    Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    f_10673_7616_7630()
                    {
                        var return_v = ContainingType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10673, 7616, 7630);
                        return return_v;
                    }


                    bool
                    f_10673_7616_7646(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.AreLocalsZeroed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10673, 7616, 7646);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 7535, 7660);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 7535, 7660);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 7781, 7801);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 7787, 7799);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 7781, 7801);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 7672, 7812);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 7672, 7812);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 7894, 7915);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 7900, 7913);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 7894, 7915);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 7824, 7926);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 7824, 7926);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override IEnumerable<Cci.SecurityAttribute> GetSecurityInformation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 7938, 8088);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 8040, 8077);

                throw f_10673_8046_8076();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 7938, 8088);

                System.Exception
                f_10673_8046_8076()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10673, 8046, 8076);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 7938, 8088);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 7938, 8088);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override ImmutableArray<string> GetAppliedConditionalSymbols()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 8100, 8250);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 8203, 8239);

                return ImmutableArray<string>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 8100, 8250);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 8100, 8250);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 8100, 8250);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override int CalculateLocalSyntaxOffset(int localPosition, SyntaxTree localTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 8262, 8424);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 8376, 8413);

                throw f_10673_8382_8412();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 8262, 8424);

                System.Exception
                f_10673_8382_8412()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10673, 8382, 8412);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 8262, 8424);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 8262, 8424);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static CSharpSyntaxNode DummySyntax()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10673, 8436, 8617);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 8506, 8546);

                var
                syntaxTree = CSharpSyntaxTree.Dummy
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 8560, 8606);

                return (CSharpSyntaxNode)f_10673_8585_8605(syntaxTree);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10673, 8436, 8617);

                Microsoft.CodeAnalysis.SyntaxNode
                f_10673_8585_8605(Microsoft.CodeAnalysis.SyntaxTree
                this_param)
                {
                    var return_v = this_param.GetRoot();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 8585, 8605);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 8436, 8617);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 8436, 8617);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void ReportUseSiteDiagnostics(Symbol symbol, DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10673, 8629, 8975);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 8740, 8794);

                var
                useSiteDiagnostic = f_10673_8764_8793(symbol)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 8808, 8964) || true) && (useSiteDiagnostic != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10673, 8808, 8964);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 8871, 8949);

                    f_10673_8871_8948(useSiteDiagnostic, diagnostics, NoLocation.Singleton);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10673, 8808, 8964);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10673, 8629, 8975);

                Microsoft.CodeAnalysis.DiagnosticInfo
                f_10673_8764_8793(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 8764, 8793);
                    return return_v;
                }


                bool
                f_10673_8871_8948(Microsoft.CodeAnalysis.DiagnosticInfo
                info, Microsoft.CodeAnalysis.DiagnosticBag
                diagnostics, Microsoft.CodeAnalysis.Location
                location)
                {
                    var return_v = ReportUseSiteDiagnostic(info, diagnostics, location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 8871, 8948);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 8629, 8975);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 8629, 8975);
            }
        }

        private static BoundCall CreateParameterlessCall(CSharpSyntaxNode syntax, BoundExpression receiver, MethodSymbol method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10673, 8987, 9783);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 9132, 9772);

                return new BoundCall(
                                syntax,
                                receiver,
                                method,
                                ImmutableArray<BoundExpression>.Empty,
                                default(ImmutableArray<string>),
                                default(ImmutableArray<RefKind>),
                                isDelegateCall: false,
                                expanded: false,
                                invokedAsExtensionMethod: false,
                                argsToParamsOpt: default(ImmutableArray<int>),
                                defaultArguments: default(BitVector),
                                resultKind: LookupResultKind.Viable,
                                type: f_10673_9708_9725(method))
                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10673, 9139, 9771) };
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10673, 8987, 9783);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10673_9708_9725(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10673, 9708, 9725);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 8987, 9783);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 8987, 9783);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        internal sealed class AsyncForwardEntryPoint : SynthesizedEntryPointSymbol
        {
            private readonly CSharpSyntaxNode _userMainReturnTypeSyntax;

            private readonly BoundExpression _getAwaiterGetResultCall;

            private readonly ImmutableArray<ParameterSymbol> _parameters;

            internal readonly MethodSymbol UserMain;

            internal AsyncForwardEntryPoint(CSharpCompilation compilation, NamedTypeSymbol containingType, MethodSymbol userMain) : base(f_10673_10603_10617_C(containingType))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10673, 10461, 12786);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 10131, 10156);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 10206, 10230);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 10436, 10444);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 10829, 10904);

                    f_10673_10829_10903(f_10673_10842_10865(userMain) == 0 || (DynAbs.Tracing.TraceSender.Expression_False(10673, 10842, 10902) || f_10673_10874_10897(userMain) == 1));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 10924, 10944);

                    UserMain = userMain;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 10962, 11025);

                    _userMainReturnTypeSyntax = f_10673_10990_11024(userMain);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 11043, 11105);

                    var
                    binder = f_10673_11056_11104(compilation, _userMainReturnTypeSyntax)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 11123, 11197);

                    _parameters = f_10673_11137_11196(userMain, this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 11217, 11346);

                    var
                    arguments = f_10673_11233_11243().SelectAsArray((p, s) => (BoundExpression)new BoundParameter(s, p, p.Type), _userMainReturnTypeSyntax)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 11407, 12249);

                    BoundCall
                    userMainInvocation = new BoundCall(
                                            syntax: _userMainReturnTypeSyntax,
                                            receiverOpt: null,
                                            method: userMain,
                                            arguments: arguments,
                                            argumentNamesOpt: default(ImmutableArray<string>),
                                            argumentRefKindsOpt: default(ImmutableArray<RefKind>),
                                            isDelegateCall: false,
                                            expanded: false,
                                            invokedAsExtensionMethod: false,
                                            argsToParamsOpt: default(ImmutableArray<int>),
                                            defaultArguments: default(BitVector),
                                            resultKind: LookupResultKind.Viable,
                                            type: f_10673_12179_12198(userMain))
                    { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10673, 11438, 12248) }
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 12379, 12424);

                    var
                    droppedBag = f_10673_12396_12423()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 12442, 12580);

                    var
                    success = f_10673_12456_12579(binder, userMainInvocation, out _getAwaiterGetResultCall!, _userMainReturnTypeSyntax, droppedBag)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 12598, 12616);

                    f_10673_12598_12615(droppedBag);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 12636, 12771);

                    f_10673_12636_12770(f_10673_12671_12694(f_10673_12671_12681()) || (DynAbs.Tracing.TraceSender.Expression_False(10673, 12671, 12769) || f_10673_12719_12741(f_10673_12719_12729()) == SpecialType.System_Int32));
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10673, 10461, 12786);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 10461, 12786);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 10461, 12786);
                }
            }

            internal override void AddSynthesizedAttributes(PEModuleBuilder moduleBuilder, ref ArrayBuilder<SynthesizedAttributeData> attributes)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 12802, 13172);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 12968, 13029);

                    // LAFHIS
                    //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.AddSynthesizedAttributes(moduleBuilder, ref attributes), 10673, 12968, 13028);
                    base.AddSynthesizedAttributes(moduleBuilder, ref attributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 12968, 13028);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 13049, 13157);

                    f_10673_13049_13156(ref attributes, f_10673_13089_13155(f_10673_13089_13114(this)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 12802, 13172);

                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10673_13089_13114(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEntryPointSymbol.AsyncForwardEntryPoint
                    this_param)
                    {
                        var return_v = this_param.DeclaringCompilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10673, 13089, 13114);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                    f_10673_13089_13155(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param)
                    {
                        var return_v = this_param.SynthesizeDebuggerStepThroughAttribute();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 13089, 13155);
                        return return_v;
                    }


                    int
                    f_10673_13049_13156(ref Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData>
                    attributes, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedAttributeData?
                    attribute)
                    {
                        AddSynthesizedAttribute(ref attributes, attribute);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 13049, 13156);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 12802, 13172);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 12802, 13172);
                }
            }

            public override string Name
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 13216, 13227);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 13219, 13227);
                        return MainName; DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 13216, 13227);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 13216, 13227);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 13216, 13227);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 13303, 13317);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 13306, 13317);
                        return _parameters; DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 13303, 13317);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 13303, 13317);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 13303, 13317);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 13396, 13456);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 13399, 13456);
                        return TypeWithAnnotations.Create(f_10673_13426_13455(_getAwaiterGetResultCall)); DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 13396, 13456);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 13396, 13456);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 13396, 13456);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override BoundBlock CreateBody(DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 13473, 15268);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 13572, 13611);

                    var
                    syntax = _userMainReturnTypeSyntax
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 13631, 15253) || true) && (f_10673_13635_13646())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10673, 13631, 15253);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 13688, 14575);

                        return new BoundBlock(
                                                syntax: syntax,
                                                locals: ImmutableArray<LocalSymbol>.Empty,
                                                statements: f_10673_13857_14498(new BoundExpressionStatement(
                                                        syntax: syntax,
                                                        expression: _getAwaiterGetResultCall
                                                    )
                                                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10673, 13925, 14165) }, new BoundReturnStatement(
                                                        syntax: syntax,
                                                        refKind: RefKind.None,
                                                        expressionOpt: null
                                                    )
                                                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10673, 14196, 14471) }))
                        { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10673, 13695, 14574) };
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10673, 13631, 15253);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10673, 13631, 15253);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 14659, 15234);

                        return new BoundBlock(
                                                syntax: syntax,
                                                locals: ImmutableArray<LocalSymbol>.Empty,
                                                statements: f_10673_14828_15157(f_10673_14896_15130(syntax: syntax, refKind: RefKind.None, expressionOpt: _getAwaiterGetResultCall)))
                        { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10673, 14666, 15233) };
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10673, 13631, 15253);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 13473, 15268);

                    bool
                    f_10673_13635_13646()
                    {
                        var return_v = ReturnsVoid;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10673, 13635, 13646);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    f_10673_13857_14498(Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    item1, Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                    item2)
                    {
                        var return_v = ImmutableArray.Create<BoundStatement>((Microsoft.CodeAnalysis.CSharp.BoundStatement)item1, (Microsoft.CodeAnalysis.CSharp.BoundStatement)item2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 13857, 14498);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                    f_10673_14896_15130(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    syntax, Microsoft.CodeAnalysis.RefKind
                    refKind, Microsoft.CodeAnalysis.CSharp.BoundExpression
                    expressionOpt)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.BoundReturnStatement(syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, refKind: refKind, expressionOpt: expressionOpt);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 14896, 15130);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    f_10673_14828_15157(Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                    item)
                    {
                        var return_v = ImmutableArray.Create<BoundStatement>((Microsoft.CodeAnalysis.CSharp.BoundStatement)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 14828, 15157);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 13473, 15268);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 13473, 15268);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static AsyncForwardEntryPoint()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10673, 9902, 15279);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10673, 9902, 15279);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 9902, 15279);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10673, 9902, 15279);

            int
            f_10673_10842_10865(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            this_param)
            {
                var return_v = this_param.ParameterCount;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10673, 10842, 10865);
                return return_v;
            }


            int
            f_10673_10874_10897(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            this_param)
            {
                var return_v = this_param.ParameterCount;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10673, 10874, 10897);
                return return_v;
            }


            int
            f_10673_10829_10903(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 10829, 10903);
                return 0;
            }


            Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
            f_10673_10990_11024(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            method)
            {
                var return_v = method.ExtractReturnTypeSyntax();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 10990, 11024);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Binder
            f_10673_11056_11104(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
            this_param, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
            syntax)
            {
                var return_v = this_param.GetBinder(syntax);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 11056, 11104);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
            f_10673_11137_11196(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            sourceMethod, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEntryPointSymbol.AsyncForwardEntryPoint
            destinationMethod)
            {
                var return_v = SynthesizedParameterSymbol.DeriveParameters(sourceMethod, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)destinationMethod);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 11137, 11196);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
            f_10673_11233_11243()
            {
                var return_v = Parameters;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10673, 11233, 11243);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            f_10673_12179_12198(Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol
            this_param)
            {
                var return_v = this_param.ReturnType;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10673, 12179, 12198);
                return return_v;
            }


            Microsoft.CodeAnalysis.DiagnosticBag
            f_10673_12396_12423()
            {
                var return_v = DiagnosticBag.GetInstance();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 12396, 12423);
                return return_v;
            }


            bool
            f_10673_12456_12579(Microsoft.CodeAnalysis.CSharp.Binder
            this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
            expression, out Microsoft.CodeAnalysis.CSharp.BoundExpression
            getAwaiterGetResultCall, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
            node, Microsoft.CodeAnalysis.DiagnosticBag
            diagnostics)
            {
                var return_v = this_param.GetAwaitableExpressionInfo((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression, out getAwaiterGetResultCall, (Microsoft.CodeAnalysis.SyntaxNode)node, diagnostics);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 12456, 12579);
                return return_v;
            }


            int
            f_10673_12598_12615(Microsoft.CodeAnalysis.DiagnosticBag
            this_param)
            {
                this_param.Free();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 12598, 12615);
                return 0;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            f_10673_12671_12681()
            {
                var return_v = ReturnType;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10673, 12671, 12681);
                return return_v;
            }


            bool
            f_10673_12671_12694(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            type)
            {
                var return_v = type.IsVoidType();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 12671, 12694);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            f_10673_12719_12729()
            {
                var return_v = ReturnType;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10673, 12719, 12729);
                return return_v;
            }


            Microsoft.CodeAnalysis.SpecialType
            f_10673_12719_12741(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
            this_param)
            {
                var return_v = this_param.SpecialType;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10673, 12719, 12741);
                return return_v;
            }


            int
            f_10673_12636_12770(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 12636, 12770);
                return 0;
            }


            static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10673_10603_10617_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10673, 10461, 12786);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol?
            f_10673_13426_13455(Microsoft.CodeAnalysis.CSharp.BoundExpression
            this_param)
            {
                var return_v = this_param.Type;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10673, 13426, 13455);
                return return_v;
            }

        }

        internal sealed override bool IsNullableAnalysisEnabled()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 15349, 15357);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 15352, 15357);
                return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 15349, 15357);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 15349, 15357);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 15349, 15357);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private sealed class ScriptEntryPoint : SynthesizedEntryPointSymbol
        {
            private readonly TypeWithAnnotations _returnType;

            internal ScriptEntryPoint(NamedTypeSymbol containingType, TypeWithAnnotations returnType) : base(f_10673_15641_15655_C(containingType))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10673, 15527, 15846);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 15689, 15732);

                    f_10673_15689_15731(f_10673_15702_15730(containingType));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 15750, 15788);

                    f_10673_15750_15787(returnType.IsVoidType());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 15806, 15831);

                    _returnType = returnType;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10673, 15527, 15846);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 15527, 15846);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 15527, 15846);
                }
            }

            public override string Name
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 15890, 15901);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 15893, 15901);
                        return MainName; DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 15890, 15901);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 15890, 15901);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 15890, 15901);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 15977, 16017);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 15980, 16017);
                        return ImmutableArray<ParameterSymbol>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 15977, 16017);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 15977, 16017);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 15977, 16017);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 16096, 16110);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 16099, 16110);
                        return _returnType; DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 16096, 16110);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 16096, 16110);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 16096, 16110);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override BoundBlock CreateBody(DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 16323, 19743);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 16422, 16449);

                    var
                    syntax = f_10673_16435_16448()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 16467, 16522);

                    var
                    compilation = f_10673_16485_16521(_containingType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 16813, 17009);

                    var
                    binder = f_10673_16826_17008(container: null, next: f_10673_16914_16950(compilation), imports: f_10673_16982_17007(compilation))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 17027, 17095);

                    binder = f_10673_17036_17094(f_10673_17058_17085(compilation), binder);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 17115, 17165);

                    var
                    ctor = f_10673_17126_17164(_containingType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 17183, 17222);

                    f_10673_17183_17221(f_10673_17196_17215(ctor) == 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 17242, 17299);

                    var
                    initializer = f_10673_17260_17298(_containingType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 17317, 17363);

                    f_10673_17317_17362(f_10673_17330_17356(initializer) == 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 17383, 17689);

                    var
                    scriptLocal = new BoundLocal(
                                        syntax,
                    f_10673_17467_17573(this, TypeWithAnnotations.Create(_containingType), SynthesizedLocalKind.LoweringTemp),
                                        null,
                                        _containingType)
                    { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10673, 17401, 17688) }
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 17709, 17759);

                    f_10673_17709_17758(!f_10673_17723_17757(f_10673_17723_17745(initializer)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 17777, 17856);

                    var
                    initializeCall = f_10673_17798_17855(syntax, scriptLocal, initializer)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 17874, 17914);

                    BoundExpression
                    getAwaiterGetResultCall
                    = default(BoundExpression);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 17932, 18346) || true) && (!f_10673_17937_18036(binder, initializeCall, out getAwaiterGetResultCall, syntax, diagnostics))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10673, 17932, 18346);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 18078, 18327);

                        return f_10673_18085_18326(syntax: syntax, locals: ImmutableArray<LocalSymbol>.Empty, statements: ImmutableArray<BoundStatement>.Empty, hasErrors: true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(10673, 17932, 18346);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 18366, 19728);

                    return new BoundBlock(syntax,
                    f_10673_18417_18476(f_10673_18452_18475(scriptLocal)),
                    f_10673_18499_19677(new BoundExpressionStatement(
                                                syntax,
                                                new BoundAssignmentOperator(
                                                    syntax,
                                                    scriptLocal,
                                                    new BoundObjectCreationExpression(
                                                        syntax,
                                                        ctor)
                                                    { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10673, 18863, 19050) },
                                                    _containingType)
                                                { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10673, 18714, 19162) })
                    { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10673, 18618, 19220) }, new BoundExpressionStatement(syntax, getAwaiterGetResultCall) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10673, 19323, 19416) }, new BoundReturnStatement(
                                                syntax,
                                                RefKind.None,
                                                null)
                    { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10673, 19479, 19676) }))
                    { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10673, 18373, 19727) };
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 16323, 19743);

                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    f_10673_16435_16448()
                    {
                        var return_v = DummySyntax();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 16435, 16448);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    f_10673_16485_16521(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.DeclaringCompilation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10673, 16485, 16521);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BuckStopsHereBinder
                    f_10673_16914_16950(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    compilation)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.BuckStopsHereBinder(compilation);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 16914, 16950);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Imports
                    f_10673_16982_17007(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param)
                    {
                        var return_v = this_param.GlobalImports;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10673, 16982, 17007);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.InContainerBinder
                    f_10673_16826_17008(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol
                    container, Microsoft.CodeAnalysis.CSharp.BuckStopsHereBinder
                    next, Microsoft.CodeAnalysis.CSharp.Imports
                    imports)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.InContainerBinder(container: container, next: (Microsoft.CodeAnalysis.CSharp.Binder)next, imports: imports);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 16826, 17008);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    f_10673_17058_17085(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                    this_param)
                    {
                        var return_v = this_param.GlobalNamespace;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10673, 17058, 17085);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.InContainerBinder
                    f_10673_17036_17094(Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceSymbol
                    container, Microsoft.CodeAnalysis.CSharp.InContainerBinder
                    next)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.InContainerBinder((Microsoft.CodeAnalysis.CSharp.Symbols.NamespaceOrTypeSymbol)container, (Microsoft.CodeAnalysis.CSharp.Binder)next);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 17036, 17094);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInstanceConstructor
                    f_10673_17126_17164(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetScriptConstructor();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 17126, 17164);
                        return return_v;
                    }


                    int
                    f_10673_17196_17215(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInstanceConstructor
                    this_param)
                    {
                        var return_v = this_param.ParameterCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10673, 17196, 17215);
                        return return_v;
                    }


                    int
                    f_10673_17183_17221(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 17183, 17221);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInteractiveInitializerMethod
                    f_10673_17260_17298(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetScriptInitializer();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 17260, 17298);
                        return return_v;
                    }


                    int
                    f_10673_17330_17356(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInteractiveInitializerMethod
                    this_param)
                    {
                        var return_v = this_param.ParameterCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10673, 17330, 17356);
                        return return_v;
                    }


                    int
                    f_10673_17317_17362(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 17317, 17362);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                    f_10673_17467_17573(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEntryPointSymbol.ScriptEntryPoint
                    containingMethodOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    type, Microsoft.CodeAnalysis.SynthesizedLocalKind
                    kind)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)containingMethodOpt, type, kind);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 17467, 17573);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10673_17723_17745(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInteractiveInitializerMethod
                    this_param)
                    {
                        var return_v = this_param.ReturnType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10673, 17723, 17745);
                        return return_v;
                    }


                    bool
                    f_10673_17723_17757(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = type.IsDynamic();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 17723, 17757);
                        return return_v;
                    }


                    int
                    f_10673_17709_17758(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 17709, 17758);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundCall
                    f_10673_17798_17855(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    syntax, Microsoft.CodeAnalysis.CSharp.BoundLocal
                    receiver, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInteractiveInitializerMethod
                    method)
                    {
                        var return_v = CreateParameterlessCall(syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)method);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 17798, 17855);
                        return return_v;
                    }


                    bool
                    f_10673_17937_18036(Microsoft.CodeAnalysis.CSharp.InContainerBinder
                    this_param, Microsoft.CodeAnalysis.CSharp.BoundCall
                    expression, out Microsoft.CodeAnalysis.CSharp.BoundExpression
                    getAwaiterGetResultCall, Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    node, Microsoft.CodeAnalysis.DiagnosticBag
                    diagnostics)
                    {
                        var return_v = this_param.GetAwaitableExpressionInfo((Microsoft.CodeAnalysis.CSharp.BoundExpression)expression, out getAwaiterGetResultCall, (Microsoft.CodeAnalysis.SyntaxNode)node, diagnostics);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 17937, 18036);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundBlock
                    f_10673_18085_18326(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    syntax, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    locals, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    statements, bool
                    hasErrors)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.BoundBlock(syntax: (Microsoft.CodeAnalysis.SyntaxNode)syntax, locals: locals, statements: statements, hasErrors: hasErrors);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 18085, 18326);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    f_10673_18452_18475(Microsoft.CodeAnalysis.CSharp.BoundLocal
                    this_param)
                    {
                        var return_v = this_param.LocalSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10673, 18452, 18475);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10673_18417_18476(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    item)
                    {
                        var return_v = ImmutableArray.Create<LocalSymbol>(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 18417, 18476);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    f_10673_18499_19677(Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    item1, Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    item2, Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                    item3)
                    {
                        var return_v = ImmutableArray.Create<BoundStatement>((Microsoft.CodeAnalysis.CSharp.BoundStatement)item1, (Microsoft.CodeAnalysis.CSharp.BoundStatement)item2, (Microsoft.CodeAnalysis.CSharp.BoundStatement)item3);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 18499, 19677);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 16323, 19743);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 16323, 19743);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static ScriptEntryPoint()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10673, 15370, 19754);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10673, 15370, 19754);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 15370, 19754);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10673, 15370, 19754);

            bool
            f_10673_15702_15730(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            this_param)
            {
                var return_v = this_param.IsScriptClass;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10673, 15702, 15730);
                return return_v;
            }


            int
            f_10673_15689_15731(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 15689, 15731);
                return 0;
            }


            int
            f_10673_15750_15787(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 15750, 15787);
                return 0;
            }


            static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10673_15641_15655_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10673, 15527, 15846);
                return return_v;
            }

        }
        private sealed class SubmissionEntryPoint : SynthesizedEntryPointSymbol
        {
            private readonly ImmutableArray<ParameterSymbol> _parameters;

            private readonly TypeWithAnnotations _returnType;

            internal SubmissionEntryPoint(NamedTypeSymbol containingType, TypeWithAnnotations returnType, TypeSymbol submissionArrayType) : base(f_10673_20152_20166_C(containingType))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(10673, 20002, 20565);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 20200, 20247);

                    f_10673_20200_20246(f_10673_20213_20245(containingType));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 20265, 20304);

                    f_10673_20265_20303(!returnType.IsVoidType());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 20322, 20505);

                    _parameters = f_10673_20336_20504(f_10673_20358_20503(this, TypeWithAnnotations.Create(submissionArrayType), 0, RefKind.None, "submissionArray"));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 20525, 20550);

                    _returnType = returnType;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(10673, 20002, 20565);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 20002, 20565);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 20002, 20565);
                }
            }

            public override string Name
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 20641, 20668);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 20647, 20666);

                        return FactoryName;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 20641, 20668);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 20581, 20683);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 20581, 20683);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 20790, 20817);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 20796, 20815);

                        return _parameters;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 20790, 20817);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 20699, 20832);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 20699, 20832);
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
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 20910, 20924);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 20913, 20924);
                        return _returnType; DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 20910, 20924);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 20910, 20924);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 20910, 20924);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            internal override BoundBlock CreateBody(DiagnosticBag diagnostics)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10673, 21173, 24141);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 21272, 21299);

                    var
                    syntax = f_10673_21285_21298()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 21319, 21369);

                    var
                    ctor = f_10673_21330_21368(_containingType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 21387, 21426);

                    f_10673_21387_21425(f_10673_21400_21419(ctor) == 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 21446, 21503);

                    var
                    initializer = f_10673_21464_21502(_containingType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 21521, 21567);

                    f_10673_21521_21566(f_10673_21534_21560(initializer) == 0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 21587, 21693);

                    var
                    submissionArrayParameter = new BoundParameter(syntax, _parameters[0]) { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10673, 21618, 21692) }
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 21711, 22021);

                    var
                    submissionLocal = new BoundLocal(
                                        syntax,
                    f_10673_21799_21905(this, TypeWithAnnotations.Create(_containingType), SynthesizedLocalKind.LoweringTemp),
                                        null,
                                        _containingType)
                    { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10673, 21733, 22020) }
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 22113, 23273);

                    var
                    submissionAssignment = new BoundExpressionStatement(
                                        syntax,
                                        new BoundAssignmentOperator(
                                            syntax,
                                            submissionLocal,
                                            new BoundObjectCreationExpression(
                                                syntax,
                                                ctor,
                    f_10673_22485_22549(submissionArrayParameter),
                                                argumentNamesOpt: default(ImmutableArray<string>),
                                                argumentRefKindsOpt: default(ImmutableArray<RefKind>),
                                                expanded: false,
                                                argsToParamsOpt: default(ImmutableArray<int>),
                                                defaultArguments: default(BitVector),
                                                constantValueOpt: null,
                                                initializerExpressionOpt: null,
                                                type: _containingType)
                                            { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10673, 22349, 23126) },
                                            _containingType)
                                        { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10673, 22220, 23222) })
                    { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10673, 22140, 23272) }
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 23347, 23496);

                    var
                    initializeResult = f_10673_23370_23495(syntax, submissionLocal, initializer)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 23514, 23624);

                    f_10673_23514_23623(f_10673_23527_23622(f_10673_23545_23566(initializeResult), _returnType.Type, TypeCompareKind.ConsiderEverything2));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 23642, 23842);

                    var
                    returnStatement = new BoundReturnStatement(
                                        syntax,
                                        RefKind.None,
                                        initializeResult)
                    { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10673, 23664, 23841) }
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 23862, 24126);

                    return new BoundBlock(syntax,
                    f_10673_23913_23976(f_10673_23948_23975(submissionLocal)),
                    f_10673_23999_24075(submissionAssignment, returnStatement))
                    { WasCompilerGenerated = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true, 10673, 23869, 24125) };
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10673, 21173, 24141);

                    Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    f_10673_21285_21298()
                    {
                        var return_v = DummySyntax();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 21285, 21298);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInstanceConstructor
                    f_10673_21330_21368(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetScriptConstructor();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 21330, 21368);
                        return return_v;
                    }


                    int
                    f_10673_21400_21419(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInstanceConstructor
                    this_param)
                    {
                        var return_v = this_param.ParameterCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10673, 21400, 21419);
                        return return_v;
                    }


                    int
                    f_10673_21387_21425(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 21387, 21425);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInteractiveInitializerMethod
                    f_10673_21464_21502(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                    this_param)
                    {
                        var return_v = this_param.GetScriptInitializer();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 21464, 21502);
                        return return_v;
                    }


                    int
                    f_10673_21534_21560(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInteractiveInitializerMethod
                    this_param)
                    {
                        var return_v = this_param.ParameterCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10673, 21534, 21560);
                        return return_v;
                    }


                    int
                    f_10673_21521_21566(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 21521, 21566);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal
                    f_10673_21799_21905(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEntryPointSymbol.SubmissionEntryPoint
                    containingMethodOpt, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                    type, Microsoft.CodeAnalysis.SynthesizedLocalKind
                    kind)
                    {
                        var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedLocal((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)containingMethodOpt, type, kind);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 21799, 21905);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundExpression>
                    f_10673_22485_22549(Microsoft.CodeAnalysis.CSharp.BoundParameter
                    item)
                    {
                        var return_v = ImmutableArray.Create<BoundExpression>((Microsoft.CodeAnalysis.CSharp.BoundExpression)item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 22485, 22549);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.BoundCall
                    f_10673_23370_23495(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                    syntax, Microsoft.CodeAnalysis.CSharp.BoundLocal
                    receiver, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedInteractiveInitializerMethod
                    method)
                    {
                        var return_v = CreateParameterlessCall(syntax, (Microsoft.CodeAnalysis.CSharp.BoundExpression)receiver, (Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)method);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 23370, 23495);
                        return return_v;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10673_23545_23566(Microsoft.CodeAnalysis.CSharp.BoundCall
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10673, 23545, 23566);
                        return return_v;
                    }


                    bool
                    f_10673_23527_23622(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    right, Microsoft.CodeAnalysis.TypeCompareKind
                    comparison)
                    {
                        var return_v = TypeSymbol.Equals(left, right, comparison);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 23527, 23622);
                        return return_v;
                    }


                    int
                    f_10673_23514_23623(bool
                    condition)
                    {
                        Debug.Assert(condition);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 23514, 23623);
                        return 0;
                    }


                    Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    f_10673_23948_23975(Microsoft.CodeAnalysis.CSharp.BoundLocal
                    this_param)
                    {
                        var return_v = this_param.LocalSymbol;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10673, 23948, 23975);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol>
                    f_10673_23913_23976(Microsoft.CodeAnalysis.CSharp.Symbols.LocalSymbol
                    item)
                    {
                        var return_v = ImmutableArray.Create<LocalSymbol>(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 23913, 23976);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.BoundStatement>
                    f_10673_23999_24075(Microsoft.CodeAnalysis.CSharp.BoundExpressionStatement
                    item1, Microsoft.CodeAnalysis.CSharp.BoundReturnStatement
                    item2)
                    {
                        var return_v = ImmutableArray.Create<BoundStatement>((Microsoft.CodeAnalysis.CSharp.BoundStatement)item1, (Microsoft.CodeAnalysis.CSharp.BoundStatement)item2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 23999, 24075);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10673, 21173, 24141);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 21173, 24141);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static SubmissionEntryPoint()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10673, 19766, 24152);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10673, 19766, 24152);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 19766, 24152);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10673, 19766, 24152);

            bool
            f_10673_20213_20245(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            this_param)
            {
                var return_v = this_param.IsSubmissionClass;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10673, 20213, 20245);
                return return_v;
            }


            int
            f_10673_20200_20246(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 20200, 20246);
                return 0;
            }


            int
            f_10673_20265_20303(bool
            condition)
            {
                Debug.Assert(condition);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 20265, 20303);
                return 0;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
            f_10673_20358_20503(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedEntryPointSymbol.SubmissionEntryPoint
            container, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            type, int
            ordinal, Microsoft.CodeAnalysis.RefKind
            refKind, string
            name)
            {
                var return_v = SynthesizedParameterSymbol.Create((Microsoft.CodeAnalysis.CSharp.Symbols.MethodSymbol)container, type, ordinal, refKind, name);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 20358, 20503);
                return return_v;
            }


            System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
            f_10673_20336_20504(Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol
            item)
            {
                var return_v = ImmutableArray.Create(item);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 20336, 20504);
                return return_v;
            }


            static Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            f_10673_20152_20166_C(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(10673, 20002, 20565);
                return return_v;
            }

        }

        static SynthesizedEntryPointSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10673, 677, 24159);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 782, 801);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10673, 834, 859);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10673, 677, 24159);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10673, 677, 24159);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10673, 677, 24159);

        int
        f_10673_2169_2213(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10673, 2169, 2213);
            return 0;
        }

    }
}
