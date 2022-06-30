// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.Operations
{
    internal static class OperationFactory
    {
        public static IInvalidOperation CreateInvalidOperation(SemanticModel semanticModel, SyntaxNode syntax, ImmutableArray<IOperation> children, bool isImplicit)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(469, 354, 664);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(469, 535, 653);

                return f_469_542_652(children, semanticModel, syntax, type: null, constantValue: null, isImplicit: isImplicit);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(469, 354, 664);

                Microsoft.CodeAnalysis.Operations.InvalidOperation
                f_469_542_652(System.Collections.Immutable.ImmutableArray<Microsoft.CodeAnalysis.IOperation>
                children, Microsoft.CodeAnalysis.SemanticModel
                semanticModel, Microsoft.CodeAnalysis.SyntaxNode
                syntax, Microsoft.CodeAnalysis.ITypeSymbol?
                type, Microsoft.CodeAnalysis.ConstantValue?
                constantValue, bool
                isImplicit)
                {
                    var return_v = new Microsoft.CodeAnalysis.Operations.InvalidOperation(children, semanticModel, syntax, type: type, constantValue: constantValue, isImplicit: isImplicit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(469, 542, 652);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(469, 354, 664);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(469, 354, 664);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static readonly IConvertibleConversion IdentityConversion;
        private class IdentityConvertibleConversion : IConvertibleConversion
        {
            public CommonConversion ToCommonConversion()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(469, 929, 1079);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(469, 932, 1079);
                    return f_469_932_1079(exists: true, isIdentity: true, isNumeric: false, isReference: false, methodSymbol: null, isImplicit: true, isNullable: false); DynAbs.Tracing.TraceSender.TraceExitMethod(469, 929, 1079);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(469, 929, 1079);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(469, 929, 1079);
                }
                throw new System.Exception("Slicer error: unreachable code");

                Microsoft.CodeAnalysis.Operations.CommonConversion
                f_469_932_1079(bool
                exists, bool
                isIdentity, bool
                isNumeric, bool
                isReference, Microsoft.CodeAnalysis.IMethodSymbol?
                methodSymbol, bool
                isImplicit, bool
                isNullable)
                {
                    var return_v = new Microsoft.CodeAnalysis.Operations.CommonConversion(exists: exists, isIdentity: isIdentity, isNumeric: isNumeric, isReference: isReference, methodSymbol: methodSymbol, isImplicit: isImplicit, isNullable: isNullable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(469, 932, 1079);
                    return return_v;
                }

            }

            public IdentityConvertibleConversion()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(469, 791, 1091);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(469, 791, 1091);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(469, 791, 1091);
            }


            static IdentityConvertibleConversion()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(469, 791, 1091);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(469, 791, 1091);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(469, 791, 1091);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(469, 791, 1091);
        }

        static OperationFactory()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(469, 299, 1098);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(469, 722, 778);
            IdentityConversion = f_469_743_778(); DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(469, 299, 1098);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(469, 299, 1098);
        }


        static Microsoft.CodeAnalysis.Operations.OperationFactory.IdentityConvertibleConversion
        f_469_743_778()
        {
            var return_v = new Microsoft.CodeAnalysis.Operations.OperationFactory.IdentityConvertibleConversion();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(469, 743, 778);
            return return_v;
        }

    }
}
