// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class SynthesizedRecordConstructor : SourceConstructorSymbolBase
    {
        public SynthesizedRecordConstructor(
                     SourceMemberContainerTypeSymbol containingType,
                     RecordDeclarationSyntax syntax) : base(f_10719_601_615_C(containingType), syntax.Identifier.GetLocation(), syntax, isIterator: false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10719, 435, 1065);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10719, 701, 995);

                f_10719_701_994(this, MethodKind.Constructor, (DynAbs.Tracing.TraceSender.Conditional_F1(10719, 775, 800) || ((f_10719_775_800(containingType) && DynAbs.Tracing.TraceSender.Conditional_F2(10719, 803, 833)) || DynAbs.Tracing.TraceSender.Conditional_F3(10719, 836, 863))) ? DeclarationModifiers.Protected : DeclarationModifiers.Public, returnsVoid: true, isExtensionMethod: false, isNullableAnalysisEnabled: false);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10719, 435, 1065);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10719, 435, 1065);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10719, 435, 1065);
            }
        }

        internal RecordDeclarationSyntax GetSyntax()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10719, 1077, 1275);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10719, 1146, 1187);

                f_10719_1146_1186(syntaxReferenceOpt != null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10719, 1201, 1264);

                return (RecordDeclarationSyntax)f_10719_1233_1263(syntaxReferenceOpt);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10719, 1077, 1275);

                int
                f_10719_1146_1186(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10719, 1146, 1186);
                    return 0;
                }


                Microsoft.CodeAnalysis.SyntaxNode
                f_10719_1233_1263(Microsoft.CodeAnalysis.SyntaxReference
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10719, 1233, 1263);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10719, 1077, 1275);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10719, 1077, 1275);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override ParameterListSyntax GetParameterList()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10719, 1345, 1374);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10719, 1348, 1374);
                return f_10719_1348_1359(this).ParameterList!; DynAbs.Tracing.TraceSender.TraceExitMethod(10719, 1345, 1374);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10719, 1345, 1374);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10719, 1345, 1374);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax
            f_10719_1348_1359(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordConstructor
            this_param)
            {
                var return_v = this_param.GetSyntax();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10719, 1348, 1359);
                return return_v;
            }

        }

        protected override CSharpSyntaxNode? GetInitializer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10719, 1387, 1522);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10719, 1465, 1511);

                return f_10719_1472_1510(f_10719_1472_1483(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10719, 1387, 1522);

                Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax
                f_10719_1472_1483(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordConstructor
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10719, 1472, 1483);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Syntax.PrimaryConstructorBaseTypeSyntax?
                f_10719_1472_1510(Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.PrimaryConstructorBaseType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10719, 1472, 1510);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10719, 1387, 1522);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10719, 1387, 1522);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override bool AllowRefOrOut
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10719, 1572, 1580);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10719, 1575, 1580);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10719, 1572, 1580);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10719, 1572, 1580);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10719, 1572, 1580);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsExpressionBodied
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10719, 1635, 1643);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10719, 1638, 1643);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10719, 1635, 1643);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10719, 1635, 1643);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10719, 1635, 1643);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsNullableAnalysisEnabled()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10719, 1656, 1857);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10719, 1731, 1846);

                return f_10719_1738_1845(((SourceMemberContainerTypeSymbol)f_10719_1772_1786()), f_10719_1836_1844());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10719, 1656, 1857);

                Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                f_10719_1772_1786()
                {
                    var return_v = ContainingType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10719, 1772, 1786);
                    return return_v;
                }


                bool
                f_10719_1836_1844()
                {
                    var return_v = IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10719, 1836, 1844);
                    return return_v;
                }


                bool
                f_10719_1738_1845(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
                this_param, bool
                useStatic)
                {
                    var return_v = this_param.IsNullableEnabledForConstructorsAndInitializers(useStatic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10719, 1738, 1845);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10719, 1656, 1857);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10719, 1656, 1857);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override bool IsWithinExpressionOrBlockBody(int position, out int offset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10719, 1869, 2027);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10719, 1977, 1989);

                offset = -1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10719, 2003, 2016);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10719, 1869, 2027);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10719, 1869, 2027);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10719, 1869, 2027);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ExecutableCodeBinder TryGetBodyBinder(BinderFactory? binderFactoryOpt = null, bool ignoreAccessibility = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10719, 2039, 2580);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10719, 2193, 2238);

                TypeDeclarationSyntax
                typeDecl = f_10719_2226_2237(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10719, 2252, 2403);

                InMethodBinder
                result = f_10719_2276_2402((binderFactoryOpt ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.CodeAnalysis.CSharp.BinderFactory?>(10719, 2277, 2360) ?? f_10719_2297_2360(f_10719_2297_2322(this), f_10719_2340_2359(typeDecl)))), this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10719, 2417, 2569);

                return f_10719_2424_2568(f_10719_2449_2459(), this, f_10719_2467_2567(result, (DynAbs.Tracing.TraceSender.Conditional_F1(10719, 2494, 2513) || ((ignoreAccessibility && DynAbs.Tracing.TraceSender.Conditional_F2(10719, 2516, 2547)) || DynAbs.Tracing.TraceSender.Conditional_F3(10719, 2550, 2566))) ? BinderFlags.IgnoreAccessibility : BinderFlags.None));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10719, 2039, 2580);

                Microsoft.CodeAnalysis.CSharp.Syntax.RecordDeclarationSyntax
                f_10719_2226_2237(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordConstructor
                this_param)
                {
                    var return_v = this_param.GetSyntax();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10719, 2226, 2237);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                f_10719_2297_2322(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordConstructor
                this_param)
                {
                    var return_v = this_param.DeclaringCompilation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10719, 2297, 2322);
                    return return_v;
                }


                Microsoft.CodeAnalysis.SyntaxTree
                f_10719_2340_2359(Microsoft.CodeAnalysis.CSharp.Syntax.TypeDeclarationSyntax
                this_param)
                {
                    var return_v = this_param.SyntaxTree;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10719, 2340, 2359);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.BinderFactory
                f_10719_2297_2360(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                this_param, Microsoft.CodeAnalysis.SyntaxTree
                syntaxTree)
                {
                    var return_v = this_param.GetBinderFactory(syntaxTree);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10719, 2297, 2360);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.InMethodBinder
                f_10719_2276_2402(Microsoft.CodeAnalysis.CSharp.BinderFactory
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordConstructor
                constructor)
                {
                    var return_v = this_param.GetRecordConstructorInMethodBinder(constructor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10719, 2276, 2402);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                f_10719_2449_2459()
                {
                    var return_v = SyntaxNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10719, 2449, 2459);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Binder
                f_10719_2467_2567(Microsoft.CodeAnalysis.CSharp.InMethodBinder
                this_param, Microsoft.CodeAnalysis.CSharp.BinderFlags
                flags)
                {
                    var return_v = this_param.WithAdditionalFlags(flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10719, 2467, 2567);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder
                f_10719_2424_2568(Microsoft.CodeAnalysis.CSharp.CSharpSyntaxNode
                root, Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordConstructor
                memberSymbol, Microsoft.CodeAnalysis.CSharp.Binder
                next)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.ExecutableCodeBinder((Microsoft.CodeAnalysis.SyntaxNode)root, (Microsoft.CodeAnalysis.CSharp.Symbol)memberSymbol, next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10719, 2424, 2568);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10719, 2039, 2580);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10719, 2039, 2580);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SynthesizedRecordConstructor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10719, 338, 2587);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10719, 338, 2587);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10719, 338, 2587);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10719, 338, 2587);

        bool
        f_10719_775_800(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        this_param)
        {
            var return_v = this_param.IsAbstract;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10719, 775, 800);
            return return_v;
        }


        int
        f_10719_701_994(Microsoft.CodeAnalysis.CSharp.Symbols.SynthesizedRecordConstructor
        this_param, Microsoft.CodeAnalysis.MethodKind
        methodKind, Microsoft.CodeAnalysis.CSharp.DeclarationModifiers
        declarationModifiers, bool
        returnsVoid, bool
        isExtensionMethod, bool
        isNullableAnalysisEnabled)
        {
            this_param.MakeFlags(methodKind, declarationModifiers, returnsVoid: returnsVoid, isExtensionMethod: isExtensionMethod, isNullableAnalysisEnabled: isNullableAnalysisEnabled);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10719, 701, 994);
            return 0;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        f_10719_601_615_C(Microsoft.CodeAnalysis.CSharp.Symbols.SourceMemberContainerTypeSymbol
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(10719, 435, 1065);
            return return_v;
        }

    }
}
