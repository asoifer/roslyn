// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

#nullable disable

using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using Microsoft.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;

namespace Microsoft.CodeAnalysis.CSharp.Symbols
{
    internal sealed class LambdaSymbol : SourceMethodSymbol
    {
        private readonly Symbol _containingSymbol;

        private readonly MessageID _messageID;

        private readonly SyntaxNode _syntax;

        private readonly ImmutableArray<ParameterSymbol> _parameters;

        private RefKind _refKind;

        private TypeWithAnnotations _returnType;

        private readonly bool _isSynthesized;

        private readonly bool _isAsync;

        private readonly bool _isStatic;

        internal static readonly TypeSymbol ReturnTypeIsBeingInferred;

        internal static readonly TypeSymbol InferenceFailureReturnType;

        private static readonly TypeWithAnnotations UnknownReturnType;

        public LambdaSymbol(
                    CSharpCompilation compilation,
                    Symbol containingSymbol,
                    UnboundLambda unboundLambda,
                    ImmutableArray<TypeWithAnnotations> parameterTypes,
                    ImmutableArray<RefKind> parameterRefKinds,
                    RefKind refKind,
                    TypeWithAnnotations returnType,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(10232, 1732, 2832);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 597, 614);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 652, 662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 701, 708);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 806, 814);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 897, 911);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 944, 952);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 985, 994);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 2137, 2174);

                _containingSymbol = containingSymbol;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 2188, 2230);

                _messageID = f_10232_2201_2229(f_10232_2201_2219(unboundLambda));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 2244, 2275);

                _syntax = unboundLambda.Syntax;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 2289, 2308);

                _refKind = refKind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 2322, 2425);

                _returnType = (DynAbs.Tracing.TraceSender.Conditional_F1(10232, 2336, 2355) || ((f_10232_2336_2355_M(!returnType.HasType) && DynAbs.Tracing.TraceSender.Conditional_F2(10232, 2358, 2411)) || DynAbs.Tracing.TraceSender.Conditional_F3(10232, 2414, 2424))) ? TypeWithAnnotations.Create(ReturnTypeIsBeingInferred) : returnType;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 2439, 2491);

                _isSynthesized = f_10232_2456_2490(unboundLambda);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 2505, 2538);

                _isAsync = f_10232_2516_2537(unboundLambda);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 2552, 2587);

                _isStatic = f_10232_2564_2586(unboundLambda);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 2716, 2821);

                _parameters = f_10232_2730_2820(this, compilation, unboundLambda, parameterTypes, parameterRefKinds, diagnostics);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(10232, 1732, 2832);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 1732, 2832);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 1732, 2832);
            }
        }

        public MessageID MessageID
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 2873, 2899);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 2879, 2897);

                    return _messageID;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 2873, 2899);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 2844, 2901);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 2844, 2901);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 2975, 3019);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 2981, 3017);

                    return MethodKind.AnonymousFunction;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 2975, 3019);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 2913, 3030);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 2913, 3030);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 3096, 3117);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 3102, 3115);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 3096, 3117);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 3042, 3128);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 3042, 3128);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 3194, 3215);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 3200, 3213);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 3194, 3215);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 3140, 3226);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 3140, 3226);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 3294, 3315);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 3300, 3313);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 3294, 3315);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 3238, 3326);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 3238, 3326);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 3393, 3414);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 3399, 3412);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 3393, 3414);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 3338, 3425);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 3338, 3425);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 3493, 3514);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 3499, 3512);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 3493, 3514);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 3437, 3525);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 3437, 3525);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 3567, 3579);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 3570, 3579);
                    return _isStatic; DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 3567, 3579);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 3567, 3579);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 3567, 3579);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 3645, 3669);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 3651, 3667);

                    return _isAsync;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 3645, 3669);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 3592, 3680);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 3592, 3680);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 3785, 3805);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 3791, 3803);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 3785, 3805);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 3692, 3816);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 3692, 3816);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal sealed override UnmanagedCallersOnlyAttributeData GetUnmanagedCallersOnlyAttributeData(bool forceComplete)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 3944, 3951);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 3947, 3951);
                return null; DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 3944, 3951);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 3944, 3951);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 3944, 3951);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override bool IsMetadataNewSlot(bool ignoreInterfaceImplementationChanges = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 3964, 4111);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 4087, 4100);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 3964, 4111);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 3964, 4111);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 3964, 4111);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal sealed override bool IsMetadataVirtual(bool ignoreInterfaceImplementationChanges = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 4123, 4270);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 4246, 4259);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 4123, 4270);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 4123, 4270);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 4123, 4270);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsMetadataFinal
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 4345, 4409);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 4381, 4394);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 4345, 4409);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 4282, 4420);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 4282, 4420);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 4486, 4507);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 4492, 4505);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 4486, 4507);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 4432, 4518);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 4432, 4518);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool HasSpecialName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 4592, 4613);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 4598, 4611);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 4592, 4613);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 4530, 4624);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 4530, 4624);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 4742, 4805);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 4748, 4803);

                    return default(System.Reflection.MethodImplAttributes);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 4742, 4805);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 4636, 4816);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 4636, 4816);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 4898, 4919);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 4904, 4917);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 4898, 4919);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 4828, 4930);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 4828, 4930);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override DllImportData GetDllImportData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 4942, 5038);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 5015, 5027);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 4942, 5038);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 4942, 5038);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 4942, 5038);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool AreLocalsZeroed
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 5111, 5158);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 5117, 5156);

                    return f_10232_5124_5155();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 5111, 5158);

                    bool
                    f_10232_5124_5155()
                    {
                        var return_v = AreContainingSymbolLocalsZeroed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10232, 5124, 5155);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 5050, 5169);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 5050, 5169);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 5290, 5310);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 5296, 5308);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 5290, 5310);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 5181, 5321);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 5181, 5321);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 5403, 5424);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 5409, 5422);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 5403, 5424);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 5333, 5435);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 5333, 5435);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override IEnumerable<Microsoft.Cci.SecurityAttribute> GetSecurityInformation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 5447, 5607);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 5559, 5596);

                throw f_10232_5565_5595();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 5447, 5607);

                System.Exception
                f_10232_5565_5595()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10232, 5565, 5595);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 5447, 5607);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 5447, 5607);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override ImmutableArray<string> GetAppliedConditionalSymbols()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 5619, 5762);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 5715, 5751);

                return ImmutableArray<string>.Empty;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 5619, 5762);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 5619, 5762);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 5619, 5762);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool ReturnsVoid
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 5831, 5917);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 5837, 5915);

                    return this.ReturnTypeWithAnnotations.HasType && (DynAbs.Tracing.TraceSender.Expression_True(10232, 5844, 5914) && f_10232_5886_5914(f_10232_5886_5901(this)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 5831, 5917);

                    Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    f_10232_5886_5901(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                    this_param)
                    {
                        var return_v = this_param.ReturnType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10232, 5886, 5901);
                        return return_v;
                    }


                    bool
                    f_10232_5886_5914(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                    type)
                    {
                        var return_v = type.IsVoidType();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10232, 5886, 5914);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 5774, 5928);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 5774, 5928);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 5996, 6020);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 6002, 6018);

                    return _refKind;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 5996, 6020);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 5940, 6031);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 5940, 6031);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 6129, 6156);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 6135, 6154);

                    return _returnType;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 6129, 6156);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 6043, 6167);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 6043, 6167);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override FlowAnalysisAnnotations ReturnTypeFlowAnalysisAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 6253, 6284);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 6256, 6284);
                    return FlowAnalysisAnnotations.None; DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 6253, 6284);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 6253, 6284);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 6253, 6284);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableHashSet<string> ReturnNotNullIfParameterNotNull
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 6370, 6403);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 6373, 6403);
                    return ImmutableHashSet<string>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 6370, 6403);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 6370, 6403);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 6370, 6403);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override FlowAnalysisAnnotations FlowAnalysisAnnotations
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 6480, 6511);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 6483, 6511);
                    return FlowAnalysisAnnotations.None; DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 6480, 6511);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 6480, 6511);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 6480, 6511);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal void SetInferredReturnType(RefKind refKind, TypeWithAnnotations inferredReturnType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 6854, 7162);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 6971, 7012);

                f_10232_6971_7011(inferredReturnType.HasType);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 7026, 7071);

                f_10232_7026_7070(f_10232_7039_7069(_returnType.Type));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 7085, 7104);

                _refKind = refKind;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 7118, 7151);

                _returnType = inferredReturnType;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 6854, 7162);

                int
                f_10232_6971_7011(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10232, 6971, 7011);
                    return 0;
                }


                bool
                f_10232_7039_7069(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                type)
                {
                    var return_v = type.IsErrorType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10232, 7039, 7069);
                    return return_v;
                }


                int
                f_10232_7026_7070(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10232, 7026, 7070);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 6854, 7162);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 6854, 7162);
            }
        }

        public override ImmutableArray<CustomModifier> RefCustomModifiers
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 7264, 7316);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 7270, 7314);

                    return ImmutableArray<CustomModifier>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 7264, 7316);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 7174, 7327);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 7174, 7327);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 7420, 7441);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 7426, 7439);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 7420, 7441);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 7339, 7452);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 7339, 7452);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 7566, 7616);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 7572, 7614);

                    return ImmutableArray<MethodSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 7566, 7616);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 7464, 7627);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 7464, 7627);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 7703, 7723);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 7709, 7721);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 7703, 7723);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 7639, 7734);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 7639, 7734);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 7851, 7908);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 7857, 7906);

                    return ImmutableArray<TypeWithAnnotations>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 7851, 7908);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 7746, 7919);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 7746, 7919);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 8022, 8079);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 8028, 8077);

                    return ImmutableArray<TypeParameterSymbol>.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 8022, 8079);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 7931, 8090);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 7931, 8090);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 8152, 8169);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 8158, 8167);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 8152, 8169);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 8102, 8180);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 8102, 8180);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 8275, 8302);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 8281, 8300);

                    return _parameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 8275, 8302);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 8192, 8313);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 8192, 8313);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool TryGetThisParameter(out ParameterSymbol thisParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 8325, 8541);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 8483, 8504);

                thisParameter = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 8518, 8530);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 8325, 8541);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 8325, 8541);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 8325, 8541);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override Accessibility DeclaredAccessibility
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 8629, 8666);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 8635, 8664);

                    return Accessibility.Private;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 8629, 8666);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 8553, 8677);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 8553, 8677);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 8764, 8872);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 8800, 8857);

                    return f_10232_8807_8856(f_10232_8839_8855(_syntax));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 8764, 8872);

                    Microsoft.CodeAnalysis.Location
                    f_10232_8839_8855(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.Location;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10232, 8839, 8855);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10232_8807_8856(Microsoft.CodeAnalysis.Location
                    item)
                    {
                        var return_v = ImmutableArray.Create<Location>(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10232, 8807, 8856);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 8689, 8883);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 8689, 8883);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Location DiagnosticLocation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 9251, 9830);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 9287, 9815);

                    switch (f_10232_9295_9309(_syntax))
                    {

                        case SyntaxKind.AnonymousMethodExpression:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10232, 9287, 9815);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 9419, 9499);

                            return ((AnonymousMethodExpressionSyntax)_syntax).DelegateKeyword.GetLocation();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10232, 9287, 9815);

                        case SyntaxKind.SimpleLambdaExpression:
                        case SyntaxKind.ParenthesizedLambdaExpression:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10232, 9287, 9815);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 9654, 9720);

                            return ((LambdaExpressionSyntax)_syntax).ArrowToken.GetLocation();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10232, 9287, 9815);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10232, 9287, 9815);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 9776, 9796);

                            return f_10232_9783_9792()[0];
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10232, 9287, 9815);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 9251, 9830);

                    Microsoft.CodeAnalysis.CSharp.SyntaxKind
                    f_10232_9295_9309(Microsoft.CodeAnalysis.SyntaxNode
                    node)
                    {
                        var return_v = node.Kind();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10232, 9295, 9309);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                    f_10232_9783_9792()
                    {
                        var return_v = Locations;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10232, 9783, 9792);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 9190, 9841);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 9190, 9841);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 9951, 10072);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 9987, 10057);

                    return f_10232_9994_10056(f_10232_10033_10055(_syntax));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 9951, 10072);

                    Microsoft.CodeAnalysis.SyntaxReference
                    f_10232_10033_10055(Microsoft.CodeAnalysis.SyntaxNode
                    this_param)
                    {
                        var return_v = this_param.GetReference();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10232, 10033, 10055);
                        return return_v;
                    }


                    System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.SyntaxReference>
                    f_10232_9994_10056(Microsoft.CodeAnalysis.SyntaxReference
                    item)
                    {
                        var return_v = ImmutableArray.Create<SyntaxReference>(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(10232, 9994, 10056);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 9853, 10083);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 9853, 10083);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override Symbol ContainingSymbol
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 10159, 10192);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 10165, 10190);

                    return _containingSymbol;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 10159, 10192);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 10095, 10203);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 10095, 10203);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override Microsoft.Cci.CallingConvention CallingConvention
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 10307, 10362);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 10313, 10360);

                    return Microsoft.Cci.CallingConvention.Default;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 10307, 10362);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 10215, 10373);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 10215, 10373);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 10448, 10469);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 10454, 10467);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 10448, 10469);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 10385, 10480);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 10385, 10480);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 10560, 10581);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 10566, 10579);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 10560, 10581);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 10492, 10592);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 10492, 10592);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ImmutableArray<ParameterSymbol> MakeParameters(
                    CSharpCompilation compilation,
                    UnboundLambda unboundLambda,
                    ImmutableArray<TypeWithAnnotations> parameterTypes,
                    ImmutableArray<RefKind> parameterRefKinds,
                    DiagnosticBag diagnostics)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 10604, 14031);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 10931, 10995);

                f_10232_10931_10994(parameterTypes.Length == parameterRefKinds.Length);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 11011, 11921) || true) && (f_10232_11015_11042_M(!unboundLambda.HasSignature) || (DynAbs.Tracing.TraceSender.Expression_False(10232, 11015, 11079) || f_10232_11046_11074(unboundLambda) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10232, 11011, 11921);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 11216, 11906);

                    return parameterTypes.SelectAsArray((type, ordinal, arg) =>
                                                                            SynthesizedParameterSymbol.Create(
                                                                                arg.owner,
                                                                                type,
                                                                                ordinal,
                                                                                arg.refKinds[ordinal],
                                                                                GeneratedNames.LambdaCopyParameterName(ordinal)), (owner: this, refKinds: parameterRefKinds));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10232, 11011, 11921);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 11937, 12023);

                var
                builder = f_10232_11951_12022(f_10232_11993_12021(unboundLambda))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 12037, 12121);

                var
                hasExplicitlyTypedParameterList = f_10232_12075_12120(unboundLambda)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 12135, 12185);

                var
                numDelegateParameters = parameterTypes.Length
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 12210, 12215);

                    for (int
        p = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 12201, 13932) || true) && (p < f_10232_12221_12249(unboundLambda))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 12251, 12254)
        , ++p, DynAbs.Tracing.TraceSender.TraceExitCondition(10232, 12201, 13932))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(10232, 12201, 13932);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 12730, 12755);

                        TypeWithAnnotations
                        type
                        = default(TypeWithAnnotations);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 12773, 12789);

                        RefKind
                        refKind
                        = default(RefKind);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 12807, 13454) || true) && (hasExplicitlyTypedParameterList)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10232, 12807, 13454);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 12884, 12937);

                            type = f_10232_12891_12936(unboundLambda, p);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 12959, 12994);

                            refKind = f_10232_12969_12993(unboundLambda, p);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10232, 12807, 13454);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(10232, 12807, 13454);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 13036, 13454) || true) && (p < numDelegateParameters)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10232, 13036, 13454);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 13107, 13132);

                                type = parameterTypes[p];
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 13154, 13185);

                                refKind = parameterRefKinds[p];
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10232, 13036, 13454);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(10232, 13036, 13454);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 13267, 13390);

                                type = TypeWithAnnotations.Create(f_10232_13301_13388(compilation, name: string.Empty, arity: 0, errorInfo: null));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 13412, 13435);

                                refKind = RefKind.None;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(10232, 13036, 13454);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(10232, 12807, 13454);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 13474, 13516);

                        var
                        name = f_10232_13485_13515(unboundLambda, p)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 13534, 13584);

                        var
                        location = f_10232_13549_13583(unboundLambda, p)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 13602, 13712);

                        var
                        locations = (DynAbs.Tracing.TraceSender.Conditional_F1(10232, 13618, 13634) || ((location == null && DynAbs.Tracing.TraceSender.Conditional_F2(10232, 13637, 13667)) || DynAbs.Tracing.TraceSender.Conditional_F3(10232, 13670, 13711))) ? ImmutableArray<Location>.Empty : f_10232_13670_13711(location)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 13732, 13874);

                        var
                        parameter = f_10232_13748_13873(owner: this, type, ordinal: p, refKind, name, f_10232_13826_13861(unboundLambda, p), locations)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 13894, 13917);

                        f_10232_13894_13916(
                                        builder, parameter);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(10232, 1, 1732);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(10232, 1, 1732);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 13948, 13990);

                var
                result = f_10232_13961_13989(builder)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 14006, 14020);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 10604, 14031);

                int
                f_10232_10931_10994(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10232, 10931, 10994);
                    return 0;
                }


                bool
                f_10232_11015_11042_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10232, 11015, 11042);
                    return return_v;
                }


                int
                f_10232_11046_11074(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10232, 11046, 11074);
                    return return_v;
                }


                int
                f_10232_11993_12021(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10232, 11993, 12021);
                    return return_v;
                }


                Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10232_11951_12022(int
                capacity)
                {
                    var return_v = ArrayBuilder<ParameterSymbol>.GetInstance(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10232, 11951, 12022);
                    return return_v;
                }


                bool
                f_10232_12075_12120(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param)
                {
                    var return_v = this_param.HasExplicitlyTypedParameterList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10232, 12075, 12120);
                    return return_v;
                }


                int
                f_10232_12221_12249(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param)
                {
                    var return_v = this_param.ParameterCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10232, 12221, 12249);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                f_10232_12891_12936(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param, int
                index)
                {
                    var return_v = this_param.ParameterTypeWithAnnotations(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10232, 12891, 12936);
                    return return_v;
                }


                Microsoft.CodeAnalysis.RefKind
                f_10232_12969_12993(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param, int
                index)
                {
                    var return_v = this_param.RefKind(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10232, 12969, 12993);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol
                f_10232_13301_13388(Microsoft.CodeAnalysis.CSharp.CSharpCompilation
                compilation, string
                name, int
                arity, Microsoft.CodeAnalysis.DiagnosticInfo?
                errorInfo)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.ExtendedErrorTypeSymbol(compilation, name: name, arity: arity, errorInfo: errorInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10232, 13301, 13388);
                    return return_v;
                }


                string
                f_10232_13485_13515(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param, int
                index)
                {
                    var return_v = this_param.ParameterName(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10232, 13485, 13515);
                    return return_v;
                }


                Microsoft.CodeAnalysis.Location
                f_10232_13549_13583(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param, int
                index)
                {
                    var return_v = this_param.ParameterLocation(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10232, 13549, 13583);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                f_10232_13670_13711(Microsoft.CodeAnalysis.Location
                item)
                {
                    var return_v = ImmutableArray.Create<Location>(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10232, 13670, 13711);
                    return return_v;
                }


                bool
                f_10232_13826_13861(Microsoft.CodeAnalysis.CSharp.UnboundLambda
                this_param, int
                index)
                {
                    var return_v = this_param.ParameterIsDiscard(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10232, 13826, 13861);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.SourceSimpleParameterSymbol
                f_10232_13748_13873(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                owner, Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations
                parameterType, int
                ordinal, Microsoft.CodeAnalysis.RefKind
                refKind, string
                name, bool
                isDiscard, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.Location>
                locations)
                {
                    var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.SourceSimpleParameterSymbol(owner: (Microsoft.CodeAnalysis.CSharp.Symbol)owner, parameterType, ordinal: ordinal, refKind, name, isDiscard, locations);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10232, 13748, 13873);
                    return return_v;
                }


                int
                f_10232_13894_13916(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                this_param, Microsoft.CodeAnalysis.CSharp.Symbols.SourceSimpleParameterSymbol
                item)
                {
                    this_param.Add((Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10232, 13894, 13916);
                    return 0;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                f_10232_13961_13989(Microsoft.CodeAnalysis.PooledObjects.ArrayBuilder<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
                this_param)
                {
                    var return_v = this_param.ToImmutableAndFree();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10232, 13961, 13989);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 10604, 14031);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 10604, 14031);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override bool Equals(Symbol symbol, TypeCompareKind compareKind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 14043, 14745);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 14146, 14186) || true) && ((object)this == symbol)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(10232, 14146, 14186);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 14174, 14186);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(10232, 14146, 14186);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 14202, 14734);

                return symbol is LambdaSymbol lambda
                && (DynAbs.Tracing.TraceSender.Expression_True(10232, 14209, 14284) && lambda._syntax == _syntax
                ) && (DynAbs.Tracing.TraceSender.Expression_True(10232, 14209, 14332) && lambda._refKind == _refKind
                ) && (DynAbs.Tracing.TraceSender.Expression_True(10232, 14209, 14419) && f_10232_14353_14419(f_10232_14371_14388(lambda), f_10232_14390_14405(this), compareKind)) && (DynAbs.Tracing.TraceSender.Expression_True(10232, 14209, 14651) && f_10232_14440_14469().SequenceEqual(f_10232_14484_14520(lambda), compareKind, (p1, p2, compareKind) => p1.Equals(p2, compareKind))) && (DynAbs.Tracing.TraceSender.Expression_True(10232, 14209, 14733) && f_10232_14672_14733(f_10232_14672_14695(lambda), f_10232_14703_14719(), compareKind));
                DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 14043, 14745);

                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10232_14371_14388(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10232, 14371, 14388);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                f_10232_14390_14405(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10232, 14390, 14405);
                    return return_v;
                }


                bool
                f_10232_14353_14419(Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                left, Microsoft.CodeAnalysis.CSharp.Symbols.TypeSymbol
                right, Microsoft.CodeAnalysis.TypeCompareKind
                comparison)
                {
                    var return_v = TypeSymbol.Equals(left, right, comparison);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10232, 14353, 14419);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10232_14440_14469()
                {
                    var return_v = ParameterTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10232, 14440, 14469);
                    return return_v;
                }


                System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
                f_10232_14484_14520(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                this_param)
                {
                    var return_v = this_param.ParameterTypesWithAnnotations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10232, 14484, 14520);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10232_14672_14695(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
                this_param)
                {
                    var return_v = this_param.ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10232, 14672, 14695);
                    return return_v;
                }


                Microsoft.CodeAnalysis.CSharp.Symbol
                f_10232_14703_14719()
                {
                    var return_v = ContainingSymbol;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10232, 14703, 14719);
                    return return_v;
                }


                bool
                f_10232_14672_14733(Microsoft.CodeAnalysis.CSharp.Symbol
                this_param, Microsoft.CodeAnalysis.CSharp.Symbol
                other, Microsoft.CodeAnalysis.TypeCompareKind
                compareKind)
                {
                    var return_v = this_param.Equals(other, compareKind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10232, 14672, 14733);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 14043, 14745);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 14043, 14745);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 14757, 14855);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 14815, 14844);

                return f_10232_14822_14843(_syntax);
                DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 14757, 14855);

                int
                f_10232_14822_14843(Microsoft.CodeAnalysis.SyntaxNode
                this_param)
                {
                    var return_v = this_param.GetHashCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(10232, 14822, 14843);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 14757, 14855);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 14757, 14855);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool IsImplicitlyDeclared
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 14933, 15006);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 14969, 14991);

                    return _isSynthesized;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 14933, 15006);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 14867, 15017);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 14867, 15017);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool GenerateDebugInfo
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 15094, 15114);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 15100, 15112);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 15094, 15114);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 15029, 15125);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 15029, 15125);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsDeclaredReadOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 15179, 15187);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 15182, 15187);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 15179, 15187);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 15179, 15187);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 15179, 15187);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override bool IsInitOnly
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 15234, 15242);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 15237, 15242);
                    return false; DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 15234, 15242);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 15234, 15242);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 15234, 15242);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override ImmutableArray<ImmutableArray<TypeWithAnnotations>> GetTypeParameterConstraintTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 15357, 15417);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 15360, 15417);
                return ImmutableArray<ImmutableArray<TypeWithAnnotations>>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 15357, 15417);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 15357, 15417);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 15357, 15417);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override ImmutableArray<TypeParameterConstraintKind> GetTypeParameterConstraintKinds()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 15524, 15576);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 15527, 15576);
                return ImmutableArray<TypeParameterConstraintKind>.Empty; DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 15524, 15576);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 15524, 15576);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 15524, 15576);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override int CalculateLocalSyntaxOffset(int localPosition, SyntaxTree localTree)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 15589, 15751);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 15703, 15740);

                throw f_10232_15709_15739();
                DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 15589, 15751);

                System.Exception
                f_10232_15709_15739()
                {
                    var return_v = ExceptionUtilities.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10232, 15709, 15739);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 15589, 15751);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 15589, 15751);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool IsNullableAnalysisEnabled()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(10232, 15814, 15853);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 15817, 15853);
                throw f_10232_15823_15853(); DynAbs.Tracing.TraceSender.TraceExitMethod(10232, 15814, 15853);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(10232, 15814, 15853);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 15814, 15853);
            }
            throw new System.Exception("Slicer error: unreachable code");

            System.Exception
            f_10232_15823_15853()
            {
                var return_v = ExceptionUtilities.Unreachable;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10232, 15823, 15853);
                return return_v;
            }

        }

        static LambdaSymbol()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(10232, 501, 15861);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 1247, 1310);
            ReturnTypeIsBeingInferred = f_10232_1275_1310(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 1517, 1581);
            InferenceFailureReturnType = f_10232_1546_1581(); DynAbs.Tracing.TraceSender.TraceSimpleStatement(10232, 1638, 1719);
            UnknownReturnType = TypeWithAnnotations.Create(ErrorTypeSymbol.UnknownResultType); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(10232, 501, 15861);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(10232, 501, 15861);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(10232, 501, 15861);

        static Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol
        f_10232_1275_1310()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10232, 1275, 1310);
            return return_v;
        }


        static Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol
        f_10232_1546_1581()
        {
            var return_v = new Microsoft.CodeAnalysis.CSharp.Symbols.UnsupportedMetadataTypeSymbol();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10232, 1546, 1581);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
        f_10232_2201_2219(Microsoft.CodeAnalysis.CSharp.UnboundLambda
        this_param)
        {
            var return_v = this_param.Data;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10232, 2201, 2219);
            return return_v;
        }


        Microsoft.CodeAnalysis.CSharp.MessageID
        f_10232_2201_2229(Microsoft.CodeAnalysis.CSharp.UnboundLambdaState
        this_param)
        {
            var return_v = this_param.MessageID;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10232, 2201, 2229);
            return return_v;
        }


        bool
        f_10232_2336_2355_M(bool
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10232, 2336, 2355);
            return return_v;
        }


        bool
        f_10232_2456_2490(Microsoft.CodeAnalysis.CSharp.UnboundLambda
        this_param)
        {
            var return_v = this_param.WasCompilerGenerated;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10232, 2456, 2490);
            return return_v;
        }


        bool
        f_10232_2516_2537(Microsoft.CodeAnalysis.CSharp.UnboundLambda
        this_param)
        {
            var return_v = this_param.IsAsync;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10232, 2516, 2537);
            return return_v;
        }


        bool
        f_10232_2564_2586(Microsoft.CodeAnalysis.CSharp.UnboundLambda
        this_param)
        {
            var return_v = this_param.IsStatic;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(10232, 2564, 2586);
            return return_v;
        }


        System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.ParameterSymbol>
        f_10232_2730_2820(Microsoft.CodeAnalysis.CSharp.Symbols.LambdaSymbol
        this_param, Microsoft.CodeAnalysis.CSharp.CSharpCompilation
        compilation, Microsoft.CodeAnalysis.CSharp.UnboundLambda
        unboundLambda, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.CSharp.Symbols.TypeWithAnnotations>
        parameterTypes, System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.RefKind>
        parameterRefKinds, Microsoft.CodeAnalysis.DiagnosticBag
        diagnostics)
        {
            var return_v = this_param.MakeParameters(compilation, unboundLambda, parameterTypes, parameterRefKinds, diagnostics);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(10232, 2730, 2820);
            return return_v;
        }

    }
}
