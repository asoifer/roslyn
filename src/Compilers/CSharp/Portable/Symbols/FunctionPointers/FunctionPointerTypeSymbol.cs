// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.Cci;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed partial class FunctionPointerTypeSymbol : TypeSymbol
    {
        public static FunctionPointerTypeSymbol CreateFromSource(FunctionPointerTypeSyntax syntax, Binder typeBinder, DiagnosticBag diagnostics, ConsList<TypeSymbol> basesBeingResolved, bool suppressUseSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10633, 826, 1109);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 829, 1109);
                return f_10633_829_1109(f_10633_877_1108(syntax, typeBinder, diagnostics, basesBeingResolved, suppressUseSiteDiagnostics)); DynAbs.Tracing.TraceSender.TraceExitMethod(10633, 826, 1109);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 826, 1109);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 826, 1109);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
            f_10633_877_1108(Microsoft.CodeAnalysis.CSharp.Syntax.FunctionPointerTypeSyntax
            syntax, Microsoft.CodeAnalysis.CSharp.Binder
            typeBinder, Microsoft.CodeAnalysis.DiagnosticBag
            diagnostics, Roslyn.Utilities.ConsList<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
            basesBeingResolved, bool
            suppressUseSiteDiagnostics)
            {
                var return_v = FunctionPointerMethodSymbol.CreateFromSource(syntax, typeBinder, diagnostics, basesBeingResolved, suppressUseSiteDiagnostics);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10633, 877, 1108);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
            f_10633_829_1109(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
            signature)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol(signature);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10633, 829, 1109);
                return return_v;
            }

        }

        public static FunctionPointerTypeSymbol CreateFromPartsForTests(
                    CallingConvention callingConvention,
                    TypeWithAnnotations returnType,
                    ImmutableArray<CustomModifier> refCustomModifiers,
                    RefKind returnRefKind,
                    ImmutableArray<TypeWithAnnotations> parameterTypes,
                    ImmutableArray<ImmutableArray<CustomModifier>> parameterRefCustomModifiers,
                    ImmutableArray<RefKind> parameterRefKinds,
                    CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10633, 1876, 2103);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 1879, 2103);
                return f_10633_1879_2103(f_10633_1909_2102(callingConvention, returnType, refCustomModifiers, returnRefKind, parameterTypes, parameterRefCustomModifiers, parameterRefKinds, compilation)); DynAbs.Tracing.TraceSender.TraceExitMethod(10633, 1876, 2103);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 1876, 2103);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 1876, 2103);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
            f_10633_1909_2102(Microsoft.Cci.CallingConvention
            callingConvention, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            returnType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
            refCustomModifiers, Microsoft.CodeAnalysis.RefKind
            returnRefKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
            parameterTypes, System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>>
            parameterRefCustomModifiers, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
            parameterRefKinds, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
            compilation)
            {
                var return_v = FunctionPointerMethodSymbol.CreateFromPartsForTest(callingConvention, returnType, refCustomModifiers, returnRefKind, parameterTypes, parameterRefCustomModifiers, parameterRefKinds, compilation);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10633, 1909, 2102);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
            f_10633_1879_2103(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
            signature)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol(signature);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10633, 1879, 2103);
                return return_v;
            }

        }

        public static FunctionPointerTypeSymbol CreateFromParts(
                    CallingConvention callingConvention,
                    ImmutableArray<CustomModifier> callingConventionModifiers,
                    TypeWithAnnotations returnType,
                    RefKind returnRefKind,
                    ImmutableArray<TypeWithAnnotations> parameterTypes,
                    ImmutableArray<RefKind> parameterRefKinds,
                    CSharpCompilation compilation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10633, 2729, 2928);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 2732, 2928);
                return f_10633_2732_2928(f_10633_2762_2927(callingConvention, callingConventionModifiers, returnType, returnRefKind, parameterTypes, parameterRefKinds, compilation)); DynAbs.Tracing.TraceSender.TraceExitMethod(10633, 2729, 2928);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 2729, 2928);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 2729, 2928);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
            f_10633_2762_2927(Microsoft.Cci.CallingConvention
            callingConvention, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
            callingConventionModifiers, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            returnTypeWithAnnotations, Microsoft.CodeAnalysis.RefKind
            returnRefKind, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
            parameterTypes, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
            parameterRefKinds, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
            compilation)
            {
                var return_v = FunctionPointerMethodSymbol.CreateFromParts(callingConvention, callingConventionModifiers, returnTypeWithAnnotations, returnRefKind, parameterTypes, parameterRefKinds, compilation);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10633, 2762, 2927);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
            f_10633_2732_2928(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
            signature)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol(signature);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10633, 2732, 2928);
                return return_v;
            }

        }

        public static FunctionPointerTypeSymbol CreateFromMetadata(Cci.CallingConvention callingConvention, ImmutableArray<ParamInfo<TypeSymbol>> retAndParamTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10633, 3110, 3245);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 3113, 3245);
                return f_10633_3113_3245(f_10633_3161_3244(callingConvention, retAndParamTypes)); DynAbs.Tracing.TraceSender.TraceExitMethod(10633, 3110, 3245);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 3110, 3245);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 3110, 3245);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
            f_10633_3161_3244(Microsoft.Cci.CallingConvention
            callingConvention, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.ParamInfo<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>>
            retAndParamTypes)
            {
                var return_v = FunctionPointerMethodSymbol.CreateFromMetadata(callingConvention, retAndParamTypes);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10633, 3161, 3244);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
            f_10633_3113_3245(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
            signature)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol(signature);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10633, 3113, 3245);
                return return_v;
            }

        }

        public FunctionPointerTypeSymbol SubstituteTypeSymbol(
                    TypeWithAnnotations substitutedReturnType,
                    ImmutableArray<TypeWithAnnotations> substitutedParameterTypes,
                    ImmutableArray<CustomModifier> refCustomModifiers,
                    ImmutableArray<ImmutableArray<CustomModifier>> paramRefCustomModifiers)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10633, 3607, 3772);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 3610, 3772);
                return f_10633_3610_3772(f_10633_3640_3771(f_10633_3640_3649(), substitutedReturnType, substitutedParameterTypes, refCustomModifiers, paramRefCustomModifiers)); DynAbs.Tracing.TraceSender.TraceExitMethod(10633, 3607, 3772);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 3607, 3772);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 3607, 3772);
            }
            throw new System.Exception("Slicer error: unreachable code");

            Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
            f_10633_3640_3649()
            {
                var return_v = Signature;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10633, 3640, 3649);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
            f_10633_3640_3771(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
            substitutedReturnType, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
            substitutedParameterTypes, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>
            refCustomModifiers, System.Collections.Immutable.ImmutableArray<System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CustomModifier>>
            paramRefCustomModifiers)
            {
                var return_v = this_param.SubstituteParameterSymbols(substitutedReturnType, substitutedParameterTypes, refCustomModifiers, paramRefCustomModifiers);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10633, 3640, 3771);
                return return_v;
            }


            Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
            f_10633_3610_3772(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
            signature)
            {
                var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol(signature);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10633, 3610, 3772);
                return return_v;
            }

        }

        private FunctionPointerTypeSymbol(FunctionPointerMethodSymbol signature)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10633, 3785, 3915);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10188, 5067, 5079);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 3927, 3980);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 3882, 3904);

                Signature = signature;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10633, 3785, 3915);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 3785, 3915);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 3785, 3915);
            }
        }

        public FunctionPointerMethodSymbol Signature { get; }

        public override bool IsReferenceType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10633, 4029, 4037);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 4032, 4037);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10633, 4029, 4037);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 4029, 4037);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 4029, 4037);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsValueType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10633, 4081, 4088);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 4084, 4088);
                    return true; DynAbs.Tracing.TraceSender.TraceExitMethod(10633, 4081, 4088);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 4081, 4088);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 4081, 4088);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override TypeKind TypeKind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10633, 4133, 4160);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 4136, 4160);
                    return TypeKind.FunctionPointer; DynAbs.Tracing.TraceSender.TraceExitMethod(10633, 4133, 4160);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 4133, 4160);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 4133, 4160);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsRefLikeType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10633, 4206, 4214);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 4209, 4214);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10633, 4206, 4214);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 4206, 4214);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 4206, 4214);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool IsReadOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10633, 4257, 4265);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 4260, 4265);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10633, 4257, 4265);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 4257, 4265);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 4257, 4265);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override SymbolKind Kind
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10633, 4308, 4341);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 4311, 4341);
                    return SymbolKind.FunctionPointerType; DynAbs.Tracing.TraceSender.TraceExitMethod(10633, 4308, 4341);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 4308, 4341);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 4308, 4341);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol? ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10633, 4393, 4400);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 4396, 4400);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10633, 4393, 4400);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 4393, 4400);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 4393, 4400);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10633, 4462, 4495);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 4465, 4495);
                    return ImmutableArray<Location>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10633, 4462, 4495);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 4462, 4495);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 4462, 4495);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10633, 4580, 4620);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 4583, 4620);
                    return ImmutableArray<SyntaxReference>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10633, 4580, 4620);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 4580, 4620);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 4580, 4620);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10633, 4683, 4713);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 4686, 4713);
                    return Accessibility.NotApplicable; DynAbs.Tracing.TraceSender.TraceExitMethod(10633, 4683, 4713);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 4683, 4713);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 4683, 4713);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10633, 4754, 4762);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 4757, 4762);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10633, 4754, 4762);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 4754, 4762);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 4754, 4762);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10633, 4805, 4813);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 4808, 4813);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10633, 4805, 4813);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 4805, 4813);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 4805, 4813);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10633, 4854, 4862);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 4857, 4862);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10633, 4854, 4862);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 4854, 4862);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 4854, 4862);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override NamedTypeSymbol? BaseTypeNoUseSiteDiagnostics
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10633, 5015, 5022);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 5018, 5022);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10633, 5015, 5022);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 5015, 5022);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 5015, 5022);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override ManagedKind GetManagedKind(ref HashSet<DiagnosticInfo>? useSiteDiagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10633, 5127, 5151);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 5130, 5151);
                return ManagedKind.Unmanaged; DynAbs.Tracing.TraceSender.TraceExitMethod(10633, 5127, 5151);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 5127, 5151);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 5127, 5151);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ObsoleteAttributeData? ObsoleteAttributeData
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10633, 5225, 5232);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 5228, 5232);
                    return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10633, 5225, 5232);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 5225, 5232);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 5225, 5232);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override void Accept(CSharpSymbolVisitor visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10633, 5300, 5341);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 5303, 5341);
                f_10633_5303_5341(visitor, this); DynAbs.Tracing.TraceSender.TraceExitMethod(10633, 5300, 5341);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 5300, 5341);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 5300, 5341);
            }

            int
            f_10633_5303_5341(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
            symbol)
            {
                this_param.VisitFunctionPointerType(symbol);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10633, 5303, 5341);
                return 0;
            }

        }

        public override TResult Accept<TResult>(CSharpSymbolVisitor<TResult> visitor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10633, 5430, 5471);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 5433, 5471);
                return f_10633_5433_5471<TResult>(visitor, this); DynAbs.Tracing.TraceSender.TraceExitMethod(10633, 5430, 5471);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 5430, 5471);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 5430, 5471);
            }
            throw new System.Exception("Slicer error: unreachable code");

            TResult
            f_10633_5433_5471<TResult>(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TResult>
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
            symbol)
            {
                var return_v = this_param.VisitFunctionPointerType(symbol);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10633, 5433, 5471);
                return return_v;
            }

        }

        public override ImmutableArray<Symbol> GetMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10633, 5534, 5565);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 5537, 5565);
                return ImmutableArray<Symbol>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10633, 5534, 5565);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 5534, 5565);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 5534, 5565);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<Symbol> GetMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10633, 5639, 5670);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 5642, 5670);
                return ImmutableArray<Symbol>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10633, 5639, 5670);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 5639, 5670);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 5639, 5670);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<NamedTypeSymbol> GetTypeMembers()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10633, 5746, 5786);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 5749, 5786);
                return ImmutableArray<NamedTypeSymbol>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10633, 5746, 5786);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 5746, 5786);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 5746, 5786);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<NamedTypeSymbol> GetTypeMembers(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10633, 5873, 5913);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 5876, 5913);
                return ImmutableArray<NamedTypeSymbol>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10633, 5873, 5913);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 5873, 5913);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 5873, 5913);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override TResult Accept<TArgument, TResult>(CSharpSymbolVisitor<TArgument, TResult> visitor, TArgument a)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10633, 6039, 6083);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 6042, 6083);
                return f_10633_6042_6083<TResult, TArgument>(visitor, this, a); DynAbs.Tracing.TraceSender.TraceExitMethod(10633, 6039, 6083);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 6039, 6083);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 6039, 6083);
            }
            throw new System.Exception("Slicer error: unreachable code");

            TResult
            f_10633_6042_6083<TResult, TArgument>(Microsoft.CodeAnalysis.CSharp.CSharpSymbolVisitor<TArgument, TResult>
            this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
            symbol, TArgument
            argument)
            {
                var return_v = this_param.VisitFunctionPointerType(symbol, argument);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(10633, 6042, 6083);
                return return_v;
            }

        }

        internal override ImmutableArray<NamedTypeSymbol> InterfacesNoUseSiteDiagnostics(ConsList<TypeSymbol>? basesBeingResolved = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10633, 6224, 6264);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 6227, 6264);
                return ImmutableArray<NamedTypeSymbol>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10633, 6224, 6264);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 6224, 6264);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 6224, 6264);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool Equals(TypeSymbol t2, TypeCompareKind compareKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10633, 6277, 6668);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 6375, 6465) || true) && (f_10633_6379_6404(this, t2))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10633, 6375, 6465);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 6438, 6450);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10633, 6375, 6465);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 6481, 6587) || true) && (!(t2 is FunctionPointerTypeSymbol other))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10633, 6481, 6587);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 6559, 6572);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10633, 6481, 6587);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 6603, 6657);

                return f_10633_6610_6656(f_10633_6610_6619(), f_10633_6627_6642(other), compareKind);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10633, 6277, 6668);

                bool
                f_10633_6379_6404(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                objA, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                objB)
                {
                    var return_v = ReferenceEquals((object)objA, (object)objB);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10633, 6379, 6404);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10633_6610_6619()
                {
                    var return_v = Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10633, 6610, 6619);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10633_6627_6642(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10633, 6627, 6642);
                    return return_v;
                }


                bool
                f_10633_6610_6656(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                other, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(other, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10633, 6610, 6656);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 6277, 6668);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 6277, 6668);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10633, 6680, 6797);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 6738, 6786);

                return f_10633_6745_6785(1, f_10633_6761_6784(f_10633_6761_6770()));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10633, 6680, 6797);

                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10633_6761_6770()
                {
                    var return_v = Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10633, 6761, 6770);
                    return return_v;
                }


                int
                f_10633_6761_6784(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10633, 6761, 6784);
                    return return_v;
                }


                int
                f_10633_6745_6785(int
                newKey, int
                currentKey)
                {
                    var return_v = Hash.Combine(newKey, currentKey);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10633, 6745, 6785);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 6680, 6797);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 6680, 6797);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override ISymbol CreateISymbol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10633, 6809, 6969);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 6876, 6958);

                return f_10633_6883_6957(this, f_10633_6931_6956());
                DynAbs.Tracing.TraceSender.TraceExitMethod(10633, 6809, 6969);

                Microsoft.CodeAnalysis.NullableAnnotation
                f_10633_6931_6956()
                {
                    var return_v = DefaultNullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10633, 6931, 6956);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.FunctionPointerTypeSymbol
                f_10633_6883_6957(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                underlying, Microsoft.CodeAnalysis.NullableAnnotation
                nullableAnnotation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.FunctionPointerTypeSymbol(underlying, nullableAnnotation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10633, 6883, 6957);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 6809, 6969);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 6809, 6969);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override ITypeSymbol CreateITypeSymbol(CodeAnalysis.NullableAnnotation nullableAnnotation)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10633, 6981, 7268);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 7106, 7168);

                f_10633_7106_7167(nullableAnnotation != f_10633_7141_7166());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 7182, 7257);

                return f_10633_7189_7256(this, nullableAnnotation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10633, 6981, 7268);

                Microsoft.CodeAnalysis.NullableAnnotation
                f_10633_7141_7166()
                {
                    var return_v = DefaultNullableAnnotation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10633, 7141, 7166);
                    return return_v;
                }


                int
                f_10633_7106_7167(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10633, 7106, 7167);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.FunctionPointerTypeSymbol
                f_10633_7189_7256(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                underlying, Microsoft.CodeAnalysis.NullableAnnotation
                nullableAnnotation)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.PublicModel.FunctionPointerTypeSymbol(underlying, nullableAnnotation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10633, 7189, 7256);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 6981, 7268);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 6981, 7268);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void AddNullableTransforms(ArrayBuilder<byte> transforms)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10633, 7280, 7435);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 7380, 7424);

                f_10633_7380_7423(f_10633_7380_7389(), transforms);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10633, 7280, 7435);

                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10633_7380_7389()
                {
                    var return_v = Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10633, 7380, 7389);
                    return return_v;
                }


                int
                f_10633_7380_7423(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param, Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<byte>
                transforms)
                {
                    this_param.AddNullableTransforms(transforms);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10633, 7380, 7423);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 7280, 7435);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 7280, 7435);
            }
        }

        internal override bool ApplyNullableTransforms(byte defaultTransformFlag, ImmutableArray<byte> transforms, ref int position, out TypeSymbol result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10633, 7447, 7919);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 7619, 7720);

                var
                newSignature = f_10633_7638_7719(f_10633_7638_7647(), defaultTransformFlag, transforms, ref position)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 7734, 7787);

                bool
                madeChanges = (object)f_10633_7761_7770() != newSignature
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 7801, 7875);

                result = (DynAbs.Tracing.TraceSender.Conditional_F1(10633, 7810, 7821) || ((madeChanges && DynAbs.Tracing.TraceSender.Conditional_F2(10633, 7824, 7867)) || DynAbs.Tracing.TraceSender.Conditional_F3(10633, 7870, 7874))) ? f_10633_7824_7867(newSignature) : this;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 7889, 7908);

                return madeChanges;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10633, 7447, 7919);

                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10633_7638_7647()
                {
                    var return_v = Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10633, 7638, 7647);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10633_7638_7719(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param, byte
                defaultTransformFlag, System.Collections.Immutable.ImmutableArray<byte>
                transforms, ref int
                position)
                {
                    var return_v = this_param.ApplyNullableTransforms(defaultTransformFlag, transforms, ref position);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10633, 7638, 7719);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10633_7761_7770()
                {
                    var return_v = Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10633, 7761, 7770);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                f_10633_7824_7867(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                signature)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol(signature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10633, 7824, 7867);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 7447, 7919);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 7447, 7919);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override DiagnosticInfo? GetUseSiteDiagnostic()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10633, 7931, 8368);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 8012, 8077);

                DiagnosticInfo?
                fromSignature = f_10633_8044_8076(f_10633_8044_8053())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 8093, 8320) || true) && (f_10633_8097_8116_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(fromSignature, 10633, 8097, 8116)?.Code) == (int)ErrorCode.ERR_BindToBogus && (DynAbs.Tracing.TraceSender.Expression_True(10633, 8097, 8212) && f_10633_8154_8191(f_10633_8154_8177(fromSignature)) == (object)f_10633_8203_8212()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10633, 8093, 8320);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 8246, 8305);

                    return f_10633_8253_8304(ErrorCode.ERR_BogusType, this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10633, 8093, 8320);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 8336, 8357);

                return fromSignature;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10633, 7931, 8368);

                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10633_8044_8053()
                {
                    var return_v = Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10633, 8044, 8053);
                    return return_v;
                }


                Microsoft.CodeAnalysis.DiagnosticInfo?
                f_10633_8044_8076(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param)
                {
                    var return_v = this_param.GetUseSiteDiagnostic();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10633, 8044, 8076);
                    return return_v;
                }


                int?
                f_10633_8097_8116_M(int?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10633, 8097, 8116);
                    return return_v;
                }


                object[]
                f_10633_8154_8177(Microsoft.CodeAnalysis.DiagnosticInfo
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10633, 8154, 8177);
                    return return_v;
                }


                object?
                f_10633_8154_8191(object[]
                source)
                {
                    var return_v = source.AsSingleton<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10633, 8154, 8191);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10633_8203_8212()
                {
                    var return_v = Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10633, 8203, 8212);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo
                f_10633_8253_8304(Microsoft.CodeAnalysis.CSharp.ErrorCode
                code, params object[]
                args)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.CSDiagnosticInfo(code, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10633, 8253, 8304);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 7931, 8368);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 7931, 8368);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool GetUnificationUseSiteDiagnosticRecursive(ref DiagnosticInfo? result, Symbol owner, ref HashSet<TypeSymbol> checkedTypes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10633, 8380, 8654);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 8548, 8643);

                return f_10633_8555_8642(f_10633_8555_8564(), ref result, owner, ref checkedTypes);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10633, 8380, 8654);

                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10633_8555_8564()
                {
                    var return_v = Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10633, 8555, 8564);
                    return return_v;
                }


                bool
                f_10633_8555_8642(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param, ref Microsoft.CodeAnalysis.DiagnosticInfo?
                result, Microsoft.CodeAnalysis.CSharp.Symbol
                owner, ref System.Collections.Generic.HashSet<Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol>
                checkedTypes)
                {
                    var return_v = this_param.GetUnificationUseSiteDiagnosticRecursive(ref result, owner, ref checkedTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10633, 8555, 8642);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 8380, 8654);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 8380, 8654);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override TypeSymbol MergeEquivalentTypes(TypeSymbol other, VarianceKind variance)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10633, 8666, 9167);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 8781, 8848);

                f_10633_8781_8847(f_10633_8794_8846(this, other, TypeCompareKind.AllIgnoreOptions));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 8862, 8971);

                var
                mergedSignature = f_10633_8884_8970(f_10633_8884_8893(), f_10633_8915_8959(((FunctionPointerTypeSymbol)other)), variance)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 8985, 9128) || true) && ((object)mergedSignature != f_10633_9016_9025())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10633, 8985, 9128);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 9059, 9113);

                    return f_10633_9066_9112(mergedSignature);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10633, 8985, 9128);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 9144, 9156);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10633, 8666, 9167);

                bool
                f_10633_8794_8846(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                t2, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(t2, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10633, 8794, 8846);
                    return return_v;
                }


                int
                f_10633_8781_8847(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10633, 8781, 8847);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10633_8884_8893()
                {
                    var return_v = Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10633, 8884, 8893);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10633_8915_8959(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                this_param)
                {
                    var return_v = this_param.Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10633, 8915, 8959);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10633_8884_8970(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                signature, Microsoft.CodeAnalysis.VarianceKind
                variance)
                {
                    var return_v = this_param.MergeEquivalentTypes(signature, variance);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10633, 8884, 8970);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10633_9016_9025()
                {
                    var return_v = Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10633, 9016, 9025);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                f_10633_9066_9112(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                signature)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol(signature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10633, 9066, 9112);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 8666, 9167);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 8666, 9167);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override TypeSymbol SetNullabilityForReferenceTypes(Func<TypeWithAnnotations, TypeWithAnnotations> transform)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10633, 9179, 9608);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 9322, 9402);

                var
                substitutedSignature = f_10633_9349_9401(f_10633_9349_9358(), transform)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 9416, 9569) || true) && ((object)f_10633_9428_9437() != substitutedSignature)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10633, 9416, 9569);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 9495, 9554);

                    return f_10633_9502_9553(substitutedSignature);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10633, 9416, 9569);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 9585, 9597);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10633, 9179, 9608);

                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10633_9349_9358()
                {
                    var return_v = Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10633, 9349, 9358);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10633_9349_9401(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                this_param, System.Func<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                transform)
                {
                    var return_v = this_param.SetNullabilityForReferenceTypes(transform);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10633, 9349, 9401);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                f_10633_9428_9437()
                {
                    var return_v = Signature;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10633, 9428, 9437);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol
                f_10633_9502_9553(Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerMethodSymbol
                signature)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.FunctionPointerTypeSymbol(signature);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10633, 9502, 9553);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 9179, 9608);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 9179, 9608);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool RefKindEquals(TypeCompareKind compareKind, RefKind refKind1, RefKind refKind2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10633, 10180, 10375);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 10183, 10375);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(10633, 10183, 10261) || (((compareKind & TypeCompareKind.FunctionPointerRefMatchesOutInRefReadonly) != 0
                && DynAbs.Tracing.TraceSender.Conditional_F2(10633, 10280, 10336)) || DynAbs.Tracing.TraceSender.Conditional_F3(10633, 10355, 10375))) ? (refKind1 == RefKind.None) == (refKind2 == RefKind.None)
                : refKind1 == refKind2; DynAbs.Tracing.TraceSender.TraceExitMethod(10633, 10180, 10375);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 10180, 10375);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 10180, 10375);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static RefKind GetRefKindForHashCode(RefKind refKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10633, 10880, 10935);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 10883, 10935);
                return (DynAbs.Tracing.TraceSender.Conditional_F1(10633, 10883, 10906) || ((refKind == RefKind.None && DynAbs.Tracing.TraceSender.Conditional_F2(10633, 10909, 10921)) || DynAbs.Tracing.TraceSender.Conditional_F3(10633, 10924, 10935))) ? RefKind.None : RefKind.Ref; DynAbs.Tracing.TraceSender.TraceExitMethod(10633, 10880, 10935);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 10880, 10935);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 10880, 10935);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsCallingConventionModifier(NamedTypeSymbol modifierType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(10633, 11086, 11658);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 11189, 11277);

                f_10633_11189_11276(f_10633_11202_11233(modifierType) is not null || (DynAbs.Tracing.TraceSender.Expression_False(10633, 11202, 11275) || f_10633_11249_11275(modifierType)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 11291, 11647);

                return (object?)f_10633_11307_11338(modifierType) == f_10633_11342_11385_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_10633_11342_11373(modifierType), 10633, 11342, 11385)?.CorLibrary) && (DynAbs.Tracing.TraceSender.Expression_True(10633, 11298, 11432) && f_10633_11409_11427(modifierType) == 0
                ) && (DynAbs.Tracing.TraceSender.Expression_True(10633, 11298, 11487) && f_10633_11456_11473(modifierType) != "CallConv"
                ) && (DynAbs.Tracing.TraceSender.Expression_True(10633, 11298, 11577) && f_10633_11511_11577(f_10633_11511_11528(modifierType), "CallConv", StringComparison.Ordinal)) && (DynAbs.Tracing.TraceSender.Expression_True(10633, 11298, 11646) && f_10633_11601_11646(modifierType));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(10633, 11086, 11658);

                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol?
                f_10633_11202_11233(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10633, 11202, 11233);
                    return return_v;
                }


                bool
                f_10633_11249_11275(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10633, 11249, 11275);
                    return return_v;
                }


                int
                f_10633_11189_11276(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10633, 11189, 11276);
                    return 0;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol?
                f_10633_11307_11338(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10633, 11307, 11338);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol?
                f_10633_11342_11373(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.ContainingAssembly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10633, 11342, 11373);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol?
                f_10633_11342_11385_M(Microsoft.CodeAnalysis.CSharp.Symbols.AssemblySymbol?
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10633, 11342, 11385);
                    return return_v;
                }


                int
                f_10633_11409_11427(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Arity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10633, 11409, 11427);
                    return return_v;
                }


                string
                f_10633_11456_11473(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10633, 11456, 11473);
                    return return_v;
                }


                string
                f_10633_11511_11528(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10633, 11511, 11528);
                    return return_v;
                }


                bool
                f_10633_11511_11577(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10633, 11511, 11577);
                    return return_v;
                }


                bool
                f_10633_11601_11646(Microsoft.CodeAnalysis.CSharp.Symbols.NamedTypeSymbol
                typeSymbol)
                {
                    var return_v = typeSymbol.IsCompilerServicesTopLevelType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10633, 11601, 11646);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 11086, 11658);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 11086, 11658);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsRecord
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10633, 11702, 11710);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10633, 11705, 11710);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10633, 11702, 11710);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10633, 11702, 11710);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10633, 11702, 11710);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }
    }
}
